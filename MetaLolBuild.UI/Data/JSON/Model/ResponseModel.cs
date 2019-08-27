using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MetaLolBuild.UI.Data.JSON.Model {
    public class ResponseModel {
        public string Type { get; set; }
        public string Format { get; set; }
        public string Version { get; set; }
        public JObject Data { get; set; }
    }
}