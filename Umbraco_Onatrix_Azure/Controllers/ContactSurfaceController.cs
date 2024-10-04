using Azure.Messaging.ServiceBus;
using Microsoft.AspNetCore.Mvc;
using onatrix_assignment.Models;
using System.Text.Json;
using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.Logging;
using Umbraco.Cms.Core.Routing;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Infrastructure.Persistence;
using Umbraco.Cms.Web.Website.Controllers;
using Umbraco_Onatrix_Azure.Data;
using Umbraco_Onatrix_Azure.Models;

namespace Umbraco_Onatrix_Azure.Controllers;

public class ContactSurfaceController(IUmbracoContextAccessor umbracoContextAccessor,IUmbracoDatabaseFactory databaseFactory,ServiceContext services,AppCaches appCaches,IProfilingLogger profilingLogger,IPublishedUrlProvider publishedUrlProvider,DataContext dbContext,IConfiguration configuration) : SurfaceController(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
{
    private readonly DataContext _dbContext = dbContext;
    private readonly string _serviceBusConnectionString = configuration.GetConnectionString("ServiceBus");
    private readonly string _queueName = "email_request";

    [HttpPost]
    public async Task<IActionResult> HandleSubmitAsync(ContactFormModel form)
    {
        if (!ModelState.IsValid)
        {
            ViewData["name"] = form.Name;
            ViewData["email"] = form.Email;
            ViewData["dropdown"] = form.Dropdown;
            ViewData["phone"] = form.Phone;

            ViewData["error_name"] = string.IsNullOrEmpty(form.Name);
            ViewData["error_email"] = string.IsNullOrEmpty(form.Email);
            ViewData["error_dropdown"] = string.IsNullOrEmpty(form.Dropdown);
            ViewData["error_phone"] = string.IsNullOrEmpty(form.Phone);

            return CurrentUmbracoPage();
        }

        var contactFormEntry = new ContactFormEntry
        {
            Name = form.Name,
            Email = form.Email,
            Dropdown = form.Dropdown,
            Phone = form.Phone,
            Date = DateTime.Now
        };

        _dbContext.ContactFormEntries.Add(contactFormEntry);
        _dbContext.SaveChanges();
        
        await Task.Delay(2000);

        
        await SendConfirmationEmailAsync(form.Email, form);

        TempData["success"] = "Form submitted successfully.";
        return RedirectToCurrentUmbracoPage();
    }


    private async Task SendConfirmationEmailAsync(string toEmail, ContactFormModel form)
    {
        var htmlBody = $@"
            <html>
                <body>
                    <h1>Thank you for your request!</h1>
                     <p>We will contact you as soon as possible.</p>
                </body>
            </html>";


        var message = new
        {
            to = toEmail,
            subject = "Confirmation of your form",
            plainTextBody = $"Thank you for contacting us, {form.Name}. We will get back to you soon.",
            htmlBody = htmlBody
        };

        await using (ServiceBusClient client = new ServiceBusClient(_serviceBusConnectionString))
        {
            ServiceBusSender sender = client.CreateSender(_queueName);

            ServiceBusMessage serviceBusMessage = new ServiceBusMessage(JsonSerializer.Serialize(message))
            {
                ContentType = "application/json"
            };

            await sender.SendMessageAsync(serviceBusMessage);
        }

    }
}






