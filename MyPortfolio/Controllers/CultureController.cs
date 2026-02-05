using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.Controllers
{
    /// <summary>
    /// Handles language switching by updating the user's culture cookie.
    /// </summary>
    public class CultureController : Controller
    {
        private readonly string[] _supportedCultures = { "en", "fr" };

        /// <summary>
        /// Sets the culture cookie and redirects the user back to their previous page.
        /// </summary>
        /// <param name="culture">The language code (e.g., "en", "fr").</param>
        /// <param name="returnUrl">The URL to redirect to after setting the culture.</param>
        /// <returns>A redirect to the original page or the Home CV action if applicable.</returns>
        public IActionResult SetCulture(string culture, string returnUrl)
        {
            if (string.IsNullOrEmpty(culture) || !_supportedCultures.Contains(culture))
            {
                culture = "en";
            }

            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions
                {
                    Expires = DateTimeOffset.UtcNow.AddYears(1),
                    HttpOnly = true,
                    Secure = true,
                    IsEssential = true
                }
            );

            if (returnUrl.Contains("/CV", StringComparison.OrdinalIgnoreCase))
            {
                return RedirectToAction("CV", "Home");
            }

            return LocalRedirect(returnUrl ?? "/");
        }
    }
}
