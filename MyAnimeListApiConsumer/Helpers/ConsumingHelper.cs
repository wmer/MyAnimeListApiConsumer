using MyAnimeListApiConsumer.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MyAnimeListApiConsumer.Helpers {
    public class ConsumingApiHelper {
        private HttpClient _client;

        public ConsumingApiHelper() {
            _client = HttpClientBuilder.CreateAnonymous();
        }

        public ConsumingApiHelper(string username, string password) {
            _client = HttpClientBuilder.Create(username, password);
        }

        public T Get<T>(string url) {
            var response = _client.GetAsync(url).Result;
            if (response.IsSuccessStatusCode) {
                var serializer = new XmlSerializer(typeof(T));
                return (T)serializer.Deserialize(response.Content.ReadAsStreamAsync().Result);
            }
            return default(T);
        }

        public bool AddOrUpdate<T>(string url, T entry) {
            var xml = EntryHelper.EntryToXML(entry);
            var dic = new Dictionary<String, string>() {
                {"data", xml }
            };
            var httpContent = new FormUrlEncodedContent(dic);
            var response = _client.PostAsync(url, httpContent).Result;
            if (response.IsSuccessStatusCode) {
                return true;
            }
            return false;
        }

        public bool Delete(string url) {
            var response = _client.DeleteAsync(url).Result;
            if (response.IsSuccessStatusCode) {
                return true;
            }
            return false;
        }
    }
}
