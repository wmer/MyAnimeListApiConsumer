using MyAnimeListApiConsumer.Builders;
using MyAnimeListApiConsumer.Helpers;
using MyAnimeListApiConsumer.Models.Anime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MyAnimeListApiConsumer.Managers {
    public class AnimeListManager {
        private ConsumingApiHelper _consumingHelper;

        public AnimeListManager(string username, string password) {
            _consumingHelper = new ConsumingApiHelper(username, password);
        }

        public bool AddAnime(int animeId, AnimeEntryModel entry) {
            return _consumingHelper.AddOrUpdate($"/api/animelist/add/{animeId}.xml", entry);
        }

        public bool UpdateAnime(int animeId, AnimeEntryModel entry) {
            return _consumingHelper.AddOrUpdate($"/api/animelist/update/{animeId}.xml", entry);
        }

        public bool DeleteAnime(int animeId) {
            return _consumingHelper.Delete($"/api/animelist/delete/{animeId}.xml");
        }
    }
}
