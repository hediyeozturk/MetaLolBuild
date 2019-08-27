using MetaLolBuild.UI.Data.API.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MetaLolBuild.UI.Data.API {
    public class LeagueClass : BaseApiClass {
        public LeagueClass(string region) : base(region) {
        }

        public List<PositionModel> GePositions(string summonerId) {
            string path = "league/v4/entries/by-summoner/" + summonerId;
            var response = GET(GetURI(path));
            string content = response.Content.ReadAsStringAsync().Result;

            if (response.StatusCode == System.Net.HttpStatusCode.OK) {
                return JsonConvert.DeserializeObject<List<PositionModel>>(content);
            }
            else {
                return null;
            }
        }
    }
}