using Azure.Messaging.ServiceBus;
using Microsoft.AspNetCore.Mvc;
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

public class WeHelpSurfaceController(
        IUmbracoContextAccessor umbracoContextAccessor,
        IUmbracoDatabaseFactory databaseFactory,
        ServiceContext services,
        AppCaches appCaches,
        IProfilingLogger profilingLogger,
        IPublishedUrlProvider publishedUrlProvider,
        DataContext dbContext,
        IConfiguration configuration) : SurfaceController(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
{
    private readonly DataContext _dbContext = dbContext;
    private readonly string _serviceBusConnectionString = configuration.GetConnectionString("ServiceBus");
    private readonly string _queueName = "email_request";

    [HttpPost]
    public async Task<IActionResult> HandleSubmit(WeModel form)
    {
        if (!ModelState.IsValid)
        {
            ViewData["error_email"] = "You must enter a valid e-mail address.";
            ViewData["error_email"] = string.IsNullOrEmpty(form.Email);
            return CurrentUmbracoPage();
        }

        var weHelpEntry = new WeModel
        {
            Email = form.Email,
            Date = DateTime.Now
        };

        _dbContext.WeHelpModels.Add(weHelpEntry);
        _dbContext.SaveChanges();

        // Skicka e-postbekräftelse
        await SendConfirmationEmailAsync(form.Email);

        TempData["success"] = "submitted successfully.";
        return RedirectToCurrentUmbracoPage();


    }

    private async Task SendConfirmationEmailAsync(string toEmail)
    {
        var message = new
        {
            to = toEmail,
            subject = "Thank you for your request!",
            plainTextBody = "We will contact you as soon as possible.",
            htmlBody = $@"
            <html>
                <body>
                    <h1>Thank you for your request!</h1>
                     <p>We will contact you as soon as possible.</p>
                </body>
            </html>"
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

