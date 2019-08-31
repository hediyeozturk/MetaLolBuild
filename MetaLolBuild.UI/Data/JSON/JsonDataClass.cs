using MetaLolBuild.UI.Data.JSON.Model;
using MetaLolBuild.UI.Models.Champion;
using MetaLolBuild.UI.Models.ChampionDetail;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace MetaLolBuild.UI.Data.JSON {
    public class JsonDataClass {
        string mainLink = "http://ddragon.leagueoflegends.com/cdn/";

        public List<ChampionModel> GetChampions() {
            string version = GetVersion();
            string linkString;
            if (Ress.SharedStrings.Culture.Name == "tr") linkString = mainLink + version + "/data/tr_TR/champion.json";
            else linkString = mainLink + version + "/data/en_US/champion.json";
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
                champ.Image.ImageURL = mainLink + version + "/img/champion/" + champ.Image.Full;
                Champions.Add(champ);
            }

            return Champions;
        }

        public ChampionDetailModel GetChampionDetail(string ChampionId) {
            string version = GetVersion();
            string linkString;
            if (Ress.SharedStrings.Culture.Name == "tr") linkString = mainLink + version + "/data/tr_TR/champion/" + ChampionId + ".json";
            else linkString = mainLink + version + "/data/en_US/champion/" + ChampionId + ".json";
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

            ChampionDetailModel championDetail = new ChampionDetailModel();
            foreach (var item in result.Data) {
                championDetail = JsonConvert.DeserializeObject<ChampionDetailModel>(item.Value.ToString());
            }
            foreach (var skin in championDetail.skins) {
                skin.src = mainLink + "img/champion/splash/" + ChampionId + "_" + skin.num + ".jpg";
            }
            championDetail.profilePictureUrl = mainLink + version + "/img/champion/" + championDetail.image.full;

            return championDetail;
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