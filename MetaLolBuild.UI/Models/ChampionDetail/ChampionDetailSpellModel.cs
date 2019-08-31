using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MetaLolBuild.UI.Models.ChampionDetail {
    public class ChampionDetailSpellModel {
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string tooltip { get; set; }
        public ChampionDetailLeveltipModel leveltip { get; set; }
        public int maxrank { get; set; }
        public float[] cooldown { get; set; }
        public string cooldownBurn { get; set; }
        public int[] cost { get; set; }
        public string costBurn { get; set; }
        public float[][] effect { get; set; }
        public string[] effectBurn { get; set; }
        public ChampionDetailVarModel[] vars { get; set; }
        public string costType { get; set; }
        public string maxammo { get; set; }
        public int[] range { get; set; }
        public string rangeBurn { get; set; }
        public ChampionDetailImage2Model image { get; set; }
        public string resource { get; set; }
    }
}
