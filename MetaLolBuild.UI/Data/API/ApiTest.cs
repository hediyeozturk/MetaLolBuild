using MetaLolBuild.UI.Data.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MetaLolBuild.UI.Data.API {
    public class ApiTest {
        public ApiTest() {

            SummonerClass summonerClass = new SummonerClass("tr1");

            SummonerModel summoner = summonerClass.GetSummonerByName("MSTZTRK");
        }
    }
}