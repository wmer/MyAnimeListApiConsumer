using MyAnimeListApiConsumer.Builders;
using MyAnimeListApiConsumer.Helpers;
using MyAnimeListApiConsumer.Models.Anime;
using MyAnimeListApiConsumer.Models.Manga;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MyAnimeListApiConsumer.Searchers {
    public class Searcher {
        private String _searchMangaLink = "/api/manga/search.xml";
        private String _searchAnimeLink = "/api/anime/search.xml";
        private ConsumingApiHelper _consumingHelper;

        public Searcher(string username, string password) {
            _consumingHelper = new ConsumingApiHelper(username, password);
        }

        public MangaGetModel SearchManga(string title) {
            title.Replace(" ", "+");
            return _consumingHelper.Get<MangaGetModel>($"{_searchMangaLink}?q={title}");
        }

        public AnimeGetModel SearchAnime(string title) {
            title.Replace(" ", "+");
            return _consumingHelper.Get<AnimeGetModel>($"{_searchAnimeLink}?q={title}");
        }
    }
}
