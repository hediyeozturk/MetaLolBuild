using System.Globalization;
using System.Web.Mvc;

namespace MetaLolBuild.UI.Controllers {
    public class HomeController : Controller {
        // GET: Home
        public ActionResult Index() {
            return View();
        }

        public ActionResult ChangeCulture(string lang, string returnUrl) {
            Ress.SharedStrings.Culture = new CultureInfo(lang);
            TempData["Champions"] = null;
            return Redirect(returnUrl);
        }
    }
}