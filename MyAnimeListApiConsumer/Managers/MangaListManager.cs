using MyAnimeListApiConsumer.Builders;
using MyAnimeListApiConsumer.Helpers;
using MyAnimeListApiConsumer.Models.Manga;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MyAnimeListApiConsumer.Managers {
    public class MangaListManager {
        private ConsumingApiHelper _consumingHelper;

        public MangaListManager(string username, string password) {
            _consumingHelper = new ConsumingApiHelper(username, password);
        }

        public bool AddManga(int mangaId, MangaEntryModel entry) {
            return _consumingHelper.AddOrUpdate($"/api/mangalist/add/{mangaId}.xml", entry);
        }

        public bool UpdateManga(int mangaId, MangaEntryModel entry) {
            return _consumingHelper.AddOrUpdate($"/api/mangalist/update/{mangaId}.xml", entry);
        }

        public bool DeleteManga(int mangaId) {
            return _consumingHelper.Delete($"/api/mangalist/delete/{mangaId}.xml");
        }
    }
}
