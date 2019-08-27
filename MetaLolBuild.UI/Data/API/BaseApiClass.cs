using MetaLolBuild.UI.Data.API.Consts;
using System.IO;
using System.Net.Http;

namespace MetaLolBuild.UI.Data.API {
    public class BaseApiClass {
        private string Key { get; set; }
        private string Region { get; set; }

        public BaseApiClass(string region) {
            Region = region;
            Key = ApiKey.apiKey0;
        }

        protected HttpResponseMessage GET(string URL) {
            using (HttpClient client = new HttpClient()) {
                var result = client.GetAsync(URL);
                result.Wait();
                return result.Result;
            }
        }

        protected string GetURI(string path) {
            return "https://" + Region + ".api.riotgames.com/lol/" + path + "?api_key=" + Key;
        }

        public string GetKey(string path) {
            StreamReader sr = new StreamReader(path);
            return sr.ReadToEnd();
        }
    }
}