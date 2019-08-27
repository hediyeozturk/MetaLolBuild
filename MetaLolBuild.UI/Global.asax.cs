using System;
using System.Globalization;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MetaLolBuild.UI {
    public class MvcApplication : System.Web.HttpApplication {
        protected void Application_Start() {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        protected void Application_AcquireRequestState(object sender, EventArgs e) {
            if (HttpContext.Current.Session == null) return;

            var cultureInfo = (CultureInfo)Ress.SharedStrings.Culture;
            if (cultureInfo == null) {
                var languageName = "en";
                if (HttpContext.Current.Request.UserLanguages != null && HttpContext.Current.Request.UserLanguages.Length != 0) {
                    languageName = HttpContext.Current.Request.UserLanguages[3].Substring(0, 2);
                }
                cultureInfo = new CultureInfo(languageName);
                Ress.SharedStrings.Culture = cultureInfo;
            }
        }

    }
}
