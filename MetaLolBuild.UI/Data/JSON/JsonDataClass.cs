using MetaLolBuild.UI.Data.JSON.Model;
using MetaLolBuild.UI.Models.Champion;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace MetaLolBuild.UI.Data.JSON {
    public class JsonDataClass {

        public List<ChampionModel> GetChampions() {
            string version = GetVersion();
            string linkString;
            if (Ress.SharedStrings.Culture.Name == "tr") linkString = "http://ddragon.leagueoflegends.com/cdn/" + version + "/data/tr_TR/champion.json";
            else linkString = "http://ddragon.leagueoflegends.com/cdn/" + version + "/data/en_US/champion.json";
            HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create(string.Format(linkString));

            WebReq.Method = "GET";

            HttpWebResponse WebResp = (HttpWebResponse)WebReq.GetResponse();
            var status = WebResp.StatusCode;
            string jsonString;
            using (Stream stream = WebResp.GetResponseStream())   //modified from your code since the using statement disposes the stream automatically when done
            {
                StreamReader reader = new StreamReader(stream, System.Text.Encoding.UTF8);
                jsonString = reader.ReadToEnd();
            }

            var result = JsonConvert.DeserializeObject<ResponseModel>(jsonString);
            List<ChampionModel> Champions = new List<ChampionModel>();
            foreach (var item in result.Data) {
                ChampionModel champ = JsonConvert.DeserializeObject<ChampionModel>(item.Value.ToString());
                champ.Image.ImageURL = "http://ddragon.leagueoflegends.com/cdn/" + version + "/img/champion/" + champ.Image.Full;
                Champions.Add(champ);
            }

            return Champions;
        }

        private string GetVersion() {
            string versionLink = "https://ddragon.leagueoflegends.com/api/versions.json";
            HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create(string.Format(versionLink));

            WebReq.Method = "GET";

            HttpWebResponse WebResp = (HttpWebResponse)WebReq.GetResponse();
            string jsonString;
            using (Stream stream = WebResp.GetResponseStream())   //modified from your code since the using statement disposes the stream automatically when done
            {
                StreamReader reader = new StreamReader(stream, System.Text.Encoding.UTF8);
                jsonString = reader.ReadToEnd();
            }

            var result = JsonConvert.DeserializeObject<string[]>(jsonString);
            var lastVersion = result[0];

            return lastVersion;
        }
    }
}