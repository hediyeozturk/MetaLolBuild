using MetaLolBuild.UI.Data.API.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MetaLolBuild.UI.Data.API {
    public class SummonerClass : BaseApiClass {
        public SummonerClass(string region) : base(region) {
        }

        public SummonerModel GetSummonerByName(string summonerName) {
            string path = "summoner/v4/summoners/by-name/" + summonerName;
            var response = GET(GetURI(path));
            string content = response.Content.ReadAsStringAsync().Result;

            if (response.StatusCode == System.Net.HttpStatusCode.OK) {
                return JsonConvert.DeserializeObject<SummonerModel>(content);
            }
            else {
                return null;
            }
        }
    }
}