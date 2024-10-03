using Microsoft.AspNetCore.Mvc;
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

public class WeHelpSurfaceController : SurfaceController
{
    private readonly DataContext _dbContext;
    

    public WeHelpSurfaceController(
        IUmbracoContextAccessor umbracoContextAccessor,
        IUmbracoDatabaseFactory databaseFactory,
        ServiceContext services,
        AppCaches appCaches,
        IProfilingLogger profilingLogger,
        IPublishedUrlProvider publishedUrlProvider,
        DataContext dbContext)
        : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
    {
        _dbContext = dbContext;
    }

    [HttpPost]
    public IActionResult HandleSubmit(WeModel form)
    {
        if (!ModelState.IsValid)
        {
            ViewData["error_email"] = "Please enter a valid e-mail address.";
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

        

        TempData["success"] = "submitted successfully.";


        //return Redirect("/confirm");
        return RedirectToCurrentUmbracoPage();
    }


}

