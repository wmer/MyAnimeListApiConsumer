using MyAnimeListApiConsumer.Helpers;
using MyAnimeListApiConsumer.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAnimeListApiConsumer.Informers {
    public class MyUserInfo {
        private String _userName;
        private string _userInfo = "https://myanimelist.net/malappinfo.php";
        private ConsumingApiHelper _consumingHelper;

        public MyUserInfo(string username) {
            _userName = username;
            _consumingHelper = new ConsumingApiHelper();
        }

        public MyAnimeListModel GetMyAnimeList() {
            return _consumingHelper.Get<MyAnimeListModel>($"{_userInfo}?u={_userName}");
        }

        public MyMangaListModel GetMyMangaList() {
            return _consumingHelper.Get<MyMangaListModel>($"{_userInfo}?u={_userName}&status=all&type=manga");
        }

    }
}
