using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MetaLolBuild.UI.Models.Champion {
    public class ChampionModel {
        public string Version { get; set; }
        public string Id { get; set; }
        public string Key { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Blurb { get; set; }
        public ChampionInfoModel Info { get; set; }
        public ChampionImageModel Image { get; set; }
        public string[] Tags { get; set; }
        public string PartyType { get; set; }

    }
}