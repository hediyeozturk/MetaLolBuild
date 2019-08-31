using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MetaLolBuild.UI.Models.ChampionDetail {
    public class ChampionDetailModel {
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public ChampionDetailImageModel image { get; set; }
        public ChampionDetailSkinModel[] skins { get; set; }
        public string lore { get; set; }
        public string blurb { get; set; }
        public string[] allytips { get; set; }
        public string[] enemytips { get; set; }
        public string[] tags { get; set; }
        public string partype { get; set; }
        public ChampionDetailInfoModel info { get; set; }
        public ChampionDetailStatsModel stats { get; set; }
        public ChampionDetailSpellModel[] spells { get; set; }
        public ChampionDetailPassiveModel passive { get; set; }
        public ChampionDetailRecommendedModel[] recommended { get; set; }
        public string profilePictureUrl { get; set; }
    }
}