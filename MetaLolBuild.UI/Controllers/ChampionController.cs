using MetaLolBuild.UI.Data.JSON;
using MetaLolBuild.UI.Models.Champion;
using MetaLolBuild.UI.Models.ChampionDetail;
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
            ChampionDetailModel championDetailModel = GetChampionDetail(Id);

            if (championDetailModel != null) return View(championDetailModel);

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

        private ChampionDetailModel GetChampionDetail(string Id) {
            JsonDataClass jsonDataClass = new JsonDataClass();
            ChampionDetailModel championDetailModel = jsonDataClass.GetChampionDetail(Id);
            return championDetailModel;
        }
    }
}