using MyAnimeListApiConsumer.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MyAnimeListApiConsumer.Builders {
    public class HttpClientBuilder {
        public static HttpClient Create(string username, string password) {
            var client = new HttpClient() {
                BaseAddress = new Uri("https://myanimelist.net/")
            };
            var mediaType = new MediaTypeWithQualityHeaderValue("application/xml");
            client.DefaultRequestHeaders.Accept.Add(mediaType);
            client.DefaultRequestHeaders.Add("Authorization", $"Basic  {AuthenticationHelper.ConvertToBase64(username, password)}");
            return client;
        }

        public static HttpClient CreateAnonymous() {
            var client = new HttpClient() {
                BaseAddress = new Uri("https://myanimelist.net/")
            };
            var mediaType = new MediaTypeWithQualityHeaderValue("application/xml");
            client.DefaultRequestHeaders.Accept.Add(mediaType);
            return client;
        }
    }
}
