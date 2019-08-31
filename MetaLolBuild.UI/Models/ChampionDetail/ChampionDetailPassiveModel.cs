using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MetaLolBuild.UI.Models.ChampionDetail {
    public class ChampionDetailPassiveModel {
        public string name { get; set; }
        public string description { get; set; }
        public ChampionDetailImage1Model image { get; set; }
    }
}