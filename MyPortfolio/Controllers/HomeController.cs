using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using MyPortfolio.Models;
using System.Diagnostics;

namespace MyPortfolio.Controllers
{
    /// <summary> Main controller handling core navigation, localized CV rendering, and file downloads. </summary>
    public class HomeController : Controller
    {
        private readonly ICompositeViewEngine _viewEngine;
        private readonly IWebHostEnvironment _env;

        public HomeController(ICompositeViewEngine viewEngine, IWebHostEnvironment env)
        {
            _viewEngine = viewEngine;
            _env = env;
        }

        /// <summary> Displays the portfolio homepage. </summary>
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        /// <summary> Displays the projects gallery page. </summary>
        [HttpGet]
        public IActionResult Projects()
        {
            return View();
        }

        /// <summary> Dynamically resolves and displays the localized CV view (e.g., CV_FR or CV_EN) based on current request culture. </summary>
        [HttpGet]
        public IActionResult CV()
        {
            var cultureFeature = HttpContext.Features.Get<IRequestCultureFeature>();
            var lang = cultureFeature?.RequestCulture.UICulture.TwoLetterISOLanguageName.ToUpper() ?? "EN";

            var viewName = $"CV_{lang}";
            if (!ViewExists(viewName))
                viewName = "CV_EN";

            return View(viewName);
        }

        /// <summary> Serves the localized PDF version of the CV from the web root based on the user's current language. </summary>
        [HttpGet]
        public IActionResult DownloadCV()
        {
            var lang = GetLanguage();

            var fileName = $"Roland_Doyen_CV_{lang}.pdf";
            var filePath = Path.Combine(_env.WebRootPath, "files", fileName);

            if (!System.IO.File.Exists(filePath))
                return NotFound();

            return PhysicalFile(filePath, "application/pdf", fileName);
        }

        /// <summary> Internal helper to retrieve the two-letter ISO language name from the request culture. </summary>
        private string GetLanguage()
        {
            var cultureFeature = HttpContext.Features.Get<IRequestCultureFeature>();
            var lang = cultureFeature?.RequestCulture.UICulture.TwoLetterISOLanguageName.ToUpper() ?? "EN";

            return lang;
        }

        /// <summary> Checks if a specific Razor view exists in the project using the CompositeViewEngine. </summary>
        private bool ViewExists(string name)
        {
            var result = _viewEngine.FindView(ControllerContext, name, false);
            return result.Success;
        }

        /// <summary> Handles application errors and returns the Error view with request tracking ID. </summary>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}