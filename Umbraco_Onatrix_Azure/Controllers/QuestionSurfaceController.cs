using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.Logging;
using Umbraco.Cms.Core.Routing;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Infrastructure.Persistence;
using Umbraco.Cms.Web.Website.Controllers;
using Umbraco_Onatrix_Azure.Data;
using Umbraco_Onatrix_Azure.Models;

namespace Umbraco_Onatrix_Azure.Controllers
{
    public class QuestionSurfaceController : SurfaceController
    {
        private readonly DataContext _dbContext;
        public QuestionSurfaceController(IUmbracoContextAccessor umbracoContextAccessor, IUmbracoDatabaseFactory databaseFactory, ServiceContext services, AppCaches appCaches, IProfilingLogger profilingLogger, IPublishedUrlProvider publishedUrlProvider, DataContext dbContext) : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        public IActionResult HandleSubmit(QuestionModel form)
        {

            if (!ModelState.IsValid)
            {
                ViewData["error_name"] = "Please enter a valid e-mail address.";
                ViewData["error_name"] = string.IsNullOrEmpty(form.Name);

                ViewData["error_email"] = "Please enter a valid e-mail address.";
                ViewData["error_email"] = string.IsNullOrEmpty(form.Email);

                ViewData["error_message"] = "Please write a message.";
                ViewData["error_message"] = string.IsNullOrEmpty(form.Message);
                return CurrentUmbracoPage();
            }

            var questionEntry = new QuestionModel
            {
                Name = form.Name,
                Email = form.Email,
                Message = form.Message,
                Date = DateTime.Now
            };
            _dbContext.QuestionModels.Add(questionEntry);
            _dbContext.SaveChanges();

            TempData["success"] = "submitted successfully.";
            return RedirectToCurrentUmbracoPage();


        }
    }
}
