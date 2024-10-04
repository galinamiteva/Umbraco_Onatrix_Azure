﻿using Azure.Messaging.ServiceBus;
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
                        <head>
                            <style>
                                :root {{
                                    --color-default: #535656;
                                    --color-dark: #171717;
                                    --color-primary: #4f5955;
                                    --color-primary-light: #6d7573;
                                    --color-primary-dark: #2f3331;
                                    --color-secondary: #d9c3a9;
                                    --color-accent: #f2eddc;
                                    --color-gray: #f7f7f7;
                                    --color-light: #ffffff;
                                    --color-note: #cccccc;
                                }}
                                body {{
                                    font-family: Poppins, sans-serif;
                                    background-color: var(--color-light);
                                    color: var(--color-default);
                                    display: flex;
                                    justify-content: center;
                                    align-items: center;
                                    flex-direction: column;
                                }}

                                h1 {{
                                    color: var(--color-secondary);
                                    font-size: 24px;
                                }}

                                p {{
                                    color: var(--color-dark);
                                    font-size: 16px;
                                }}

                                .email-container {{
                                    width: 100%;
                                    padding: 20px;
                                    background-color: var(--color-gray);
                                    border-radius: 8px;
                                    box-shadow: 0 2px 2px rgba(0, 0, 0, 0.1);
                                }}

                                .email-content {{
                                    background-color: var(--color-light);
                                    padding: 20px;
                                    border: 1px solid var(--color-border-gray);
                                    border-radius: 6px;
                                }}

                                .footer {{
                                    margin-top: 30px;
                                    text-align: center;
                                    font-size: 14px;
                                    color: var(--color-note);
                                }}
                            </style>
                        </head>
                        <body>

                            <div class='email-container'>
                                <div class='email-content'>

                                    <div class=""logo"">
                                        <svg width=""145"" height=""44"" viewBox=""0 0 145 44"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
                                            <g clip-path=""url(#clip0_359_6549)"">
                                            <path d=""M20.2118 0.08128C9.56335 0.925887 0.964268 9.45239 0.0802495 20.1105C-1.00468 32.9003 8.92043 43.6389 21.3771 44.0008V38.9734C21.3771 35.8765 19.6894 33.0209 16.957 31.5731C13.3003 29.6425 10.8492 25.6206 11.2108 21.116C11.6127 15.8071 15.9524 11.5438 21.2967 11.1818C27.5652 10.7796 32.8291 15.7668 32.8291 21.9606C32.8291 26.1032 30.4985 29.6827 27.083 31.5328C24.3104 33.021 22.6629 35.957 22.6629 39.1343V44.0008C34.5168 43.6791 44.0401 33.946 44.0401 22.0008C43.9999 9.29152 33.1506 -0.964424 20.2118 0.08128Z"" fill=""url(#paint0_linear_359_6549)""/>
                                            <path d=""M27.8468 31.0897C27.5655 31.2506 27.3244 31.4115 27.0431 31.5723C24.2705 33.0604 22.623 35.9965 22.623 39.1738V44.0403C34.4769 43.7186 44.0002 33.9855 44.0002 22.0403C44.0002 18.9032 43.3171 15.8868 42.1116 13.1519C44.402 25.4992 35.602 31.0897 27.8468 31.0897Z"" fill=""url(#paint1_linear_359_6549)""/>
                                            <path d=""M16.1132 31.0896C16.3945 31.2505 16.6356 31.4114 16.9169 31.5723C19.6895 33.0604 21.337 35.9964 21.337 39.1737V44.0403C9.52329 43.6783 0 33.9452 0 22.0001C0 18.8629 0.683105 15.8465 1.88858 13.1116C-0.401827 25.4991 8.39817 31.0896 16.1132 31.0896Z"" fill=""url(#paint2_linear_359_6549)""/>
                                            </g>
                                            <g clip-path=""url(#clip1_359_6549)"">
                                            <path d=""M62.5 15.3001C63.9 16.1001 64.9 17.1001 65.7 18.5001C66.5 19.9001 66.9 21.4001 66.9 23.2001C66.9 24.9001 66.5 26.5001 65.7 27.9001C64.9 29.3001 63.8 30.4001 62.5 31.1001C61.1 31.9001 59.6 32.3001 58 32.3001C56.4 32.3001 54.8 31.9001 53.5 31.1001C52.1 30.3001 51.1 29.2001 50.3 27.9001C49.4 26.5001 49 25.0001 49 23.2001C49 21.5001 49.4 19.9001 50.2 18.5001C51 17.2001 52.1 16.1001 53.4 15.3001C54.8 14.5001 56.3 14.1001 57.9 14.1001C59.6 14.2001 61.1 14.6001 62.5 15.3001ZM54.6 19.5001C53.8 20.4001 53.4 21.6001 53.4 23.2001C53.4 24.8001 53.8 26.0001 54.6 26.9001C55.4 27.8001 56.5 28.3001 57.9 28.3001C59.3 28.3001 60.4 27.8001 61.2 26.9001C62 26.0001 62.5 24.8001 62.5 23.2001C62.5 21.7001 62.1 20.4001 61.3 19.5001C60.5 18.6001 59.4 18.1001 58 18.1001C56.6 18.1001 55.4 18.6001 54.6 19.5001Z"" fill=""#4F5955""/>
                                            <path d=""M81.9001 19.6C82.8001 20.7 83.3001 22.1 83.3001 24V32.1H79.0001V24.5C79.0001 23.6 78.8001 22.8 78.3001 22.3C77.8001 21.8 77.2001 21.5 76.3001 21.5C75.4001 21.5 74.7001 21.8 74.2001 22.3C73.7001 22.8 73.4001 23.6 73.4001 24.6V32H69.1001V18H73.4001V20.5C73.8001 19.7 74.4001 19 75.2001 18.5C76.1001 18.3 77.0001 18 78.1001 18C79.7001 18 81.0001 18.6 81.9001 19.6Z"" fill=""#4F5955""/>
                                            <path d=""M94.1999 18.7C94.9999 19.2 95.4999 19.8 95.8999 20.7V18.2H100.2V32.2H95.8999V29.7C95.4999 30.5 94.9999 31.2 94.1999 31.7C93.3999 32.2 92.4999 32.4 91.3999 32.4C90.1999 32.4 89.1999 32.1 88.2999 31.5C87.3999 30.9 86.6999 30 86.1999 29C85.6999 27.9 85.3999 26.6 85.3999 25.2C85.3999 23.7 85.6999 22.5 86.1999 21.4C86.6999 20.3 87.3999 19.5 88.3999 18.9C89.3999 18.3 90.2999 18 91.4999 18C92.4999 18 93.3999 18.2 94.1999 18.7ZM90.5999 22.7C89.9999 23.3 89.7999 24.1 89.7999 25.2C89.7999 26.3 90.0999 27.1 90.5999 27.7C91.1999 28.3 91.8999 28.6 92.7999 28.6C93.6999 28.6 94.3999 28.3 94.9999 27.7C95.5999 27.1 95.8999 26.3 95.8999 25.2C95.8999 24.1 95.5999 23.3 94.9999 22.7C94.3999 22.1 93.6999 21.8 92.7999 21.8C91.8999 21.8 91.1999 22 90.5999 22.7Z"" fill=""#4F5955""/>
                                            <path d=""M111 28.5V32.2001H109.1C107.5 32.2001 106.2 31.8 105.3 31C104.4 30.2 103.9 28.9 103.9 27V21.8H102V18.2H103.9V14.8H108.2V18.2H111V21.8H108.2V27C108.2 27.6 108.3 27.9 108.5 28.2C108.7 28.4 109.1 28.5 109.6 28.5H111Z"" fill=""#4F5955""/>
                                            <path d=""M119.7 18.8C120.6 18.3 121.5 18 122.5 18V22.6H121.3C120.2 22.6 119.3 22.8 118.7 23.3C118.1 23.8 117.8 24.6 117.8 25.8V32.1H113.5V18.1H117.8V20.7C118.2 20 118.9 19.3 119.7 18.8Z"" fill=""#4F5955""/>
                                            <path d=""M124.6 12.6C125 12.2 125.7 12 126.4 12C127.1 12 127.8 12.2 128.2 12.6C128.6 13 128.9 13.6 128.9 14.2C128.9 14.8 128.7 15.4 128.2 15.8C127.7 16.2 127.1 16.4 126.4 16.4C125.7 16.4 125 16.3 124.6 15.8C124.1 15.4 123.9 14.8 123.9 14.2C123.9 13.6 124.1 13.1 124.6 12.6ZM128.5 18.2V32.2H124.2V18.2H128.5Z"" fill=""#4F5955""/>
                                            <path d=""M130.2 32.1H134.4L144.5 18.2H140.2L130.2 32.1Z"" fill=""#4F5955""/>
                                            <path d=""M138.3 29.3999L140.2 32.0999H144.5L140.4 26.3999L138.3 29.3999Z"" fill=""#A6775B""/>
                                            <path d=""M139.5 25.1L134.4 18.2H130.2L137.3 28.1L139.5 25.1Z"" fill=""#4F5955""/>
                                            </g>
                                            <defs>
                                            <linearGradient id=""paint0_linear_359_6549"" x1=""-0.000110826"" y1=""22.0061"" x2=""43.986"" y2=""22.0061"" gradientUnits=""userSpaceOnUse"">
                                            <stop stop-color=""#4F5955""/>
                                            <stop offset=""0.500249"" stop-color=""#929A97""/>
                                            <stop offset=""1"" stop-color=""#4F5955""/>
                                            </linearGradient>
                                            <linearGradient id=""paint1_linear_359_6549"" x1=""22.2197"" y1=""42.9771"" x2=""43.4047"" y2=""21.8114"" gradientUnits=""userSpaceOnUse"">
                                            <stop stop-color=""#4F5955""/>
                                            <stop offset=""1"" stop-color=""#8599A6""/>
                                            </linearGradient>
                                            <linearGradient id=""paint2_linear_359_6549"" x1=""10.6859"" y1=""45.7003"" x2=""10.6859"" y2=""25.9102"" gradientUnits=""userSpaceOnUse"">
                                            <stop stop-color=""#4F5955""/>
                                            <stop offset=""1"" stop-color=""#8599A6""/>
                                            </linearGradient>
                                            <clipPath id=""clip0_359_6549"">
                                            <rect width=""44"" height=""44"" fill=""white""/>
                                            </clipPath>
                                            <clipPath id=""clip1_359_6549"">
                                            <rect width=""95.5"" height=""20.3"" fill=""white"" transform=""translate(49 12)""/>
                                            </clipPath>
                                            </defs>
                                        </svg>
                                    </div>

                                    <h1>Thank you for your request!</h1>
                                    <p>We will contact you as soon as possible.</p>
                                </div>
                            </div>

                            <div class='footer'>
                                <p>© 2024 Onatrix. All rights reserved.</p>
                            </div>
                        </body>
                    </html>
"
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

