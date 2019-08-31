using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MetaLolBuild.UI.Models.ChampionDetail {
    public class ChampionDetailStatsModel {
        public float hp { get; set; }
        public float hpperlevel { get; set; }
        public float mp { get; set; }
        public float mpperlevel { get; set; }
        public float movespeed { get; set; }
        public float armor { get; set; }
        public float armorperlevel { get; set; }
        public float spellblock { get; set; }
        public float spellblockperlevel { get; set; }
        public float attackrange { get; set; }
        public float hpregen { get; set; }
        public float hpregenperlevel { get; set; }
        public float mpregen { get; set; }
        public float mpregenperlevel { get; set; }
        public float crit { get; set; }
        public float critperlevel { get; set; }
        public float attackdamage { get; set; }
        public float attackdamageperlevel { get; set; }
        public float attackspeedoffset { get; set; }
        public float attackspeedperlevel { get; set; }
    }

}