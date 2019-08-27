using MetaLolBuild.UI.Data.JSON;
using MetaLolBuild.UI.Models.Champion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MetaLolBuild.UI.Controllers {
    public class ChampionController : Controller {
        List<ChampionModel> champions;
        public ActionResult Index() {
            champions = GetChampions();
            return View(champions);
        }

        public ActionResult Detail(string Id) {
            champions = GetChampions();

            if (!String.IsNullOrEmpty(Id) && champions != null && champions.Count != 0) {
                ChampionModel champion = champions.Where(s => s.Id == Id).FirstOrDefault();
                return View(champion);
            }

            return new HttpStatusCodeResult(404, "Bulunamadı");
        }

        private List<ChampionModel> GetChampions() {
            if (TempData.Peek("Champions") == null) {
                JsonDataClass jsonDataClass = new JsonDataClass();
                TempData["Champions"] = jsonDataClass.GetChampions();
                TempData.Keep("Champions");
                return (List<ChampionModel>)TempData.Peek("Champions");
            }
            else return (List<ChampionModel>)TempData.Peek("Champions");
        }
    }
}