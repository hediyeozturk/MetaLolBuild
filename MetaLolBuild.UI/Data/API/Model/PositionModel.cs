using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MetaLolBuild.UI.Data.API.Model {
    public class PositionModel {
        public string Tier { get; set; }
        public string Rank { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public string QueueType { get; set; }
    }
}