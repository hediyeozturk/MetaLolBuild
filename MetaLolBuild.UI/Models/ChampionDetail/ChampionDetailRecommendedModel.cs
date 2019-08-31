using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MetaLolBuild.UI.Models.ChampionDetail {
    public class ChampionDetailRecommendedModel {
        public string champion { get; set; }
        public string title { get; set; }
        public string map { get; set; }
        public string mode { get; set; }
        public string type { get; set; }
        public string customTag { get; set; }
        public int sortrank { get; set; }
        public bool extensionPage { get; set; }
        public object customPanel { get; set; }
        public ChampionDetailBlockModel[] blocks { get; set; }
    }

}