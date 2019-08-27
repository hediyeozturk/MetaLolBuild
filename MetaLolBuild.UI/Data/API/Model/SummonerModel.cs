using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MetaLolBuild.UI.Data.API.Model {
    public class SummonerModel {
        public string ProfileIconId { get; set; }
        public string Name { get; set; }
        public long SummonerLevel { get; set; }
        public string Id { get; set; }
    }
}