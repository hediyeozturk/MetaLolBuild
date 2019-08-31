using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MetaLolBuild.UI.Models.ChampionDetail {

    public class ChampionDetailSkinModel {
        public string id { get; set; }
        public int num { get; set; }
        public string name { get; set; }
        public bool chromas { get; set; }
        public string src { get; set; }
    }
}