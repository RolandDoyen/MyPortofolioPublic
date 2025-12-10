using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using MyPortofolio.Models;
using System.Diagnostics;

namespace MyPortofolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICompositeViewEngine _viewEngine;
        private readonly IWebHostEnvironment _env;

        public HomeController(ICompositeViewEngine viewEngine, IWebHostEnvironment env)
        {
            _viewEngine = viewEngine;
            _env = env;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Projects()
        {
            return View();
        }

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

        private string GetLanguage()
        {
            var cultureFeature = HttpContext.Features.Get<IRequestCultureFeature>();
            var lang = cultureFeature?.RequestCulture.UICulture.TwoLetterISOLanguageName.ToUpper() ?? "EN";

            return lang;
        }

        private bool ViewExists(string name)
        {
            var result = _viewEngine.FindView(ControllerContext, name, false);
            return result.Success;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
