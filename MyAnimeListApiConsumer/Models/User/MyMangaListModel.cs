using MyAnimeListApiConsumer.Models.Manga;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MyAnimeListApiConsumer.Models.User {
    [XmlRoot(ElementName = "myanimelist")]
    public class MyMangaListModel {
        [XmlElement(ElementName = "myinfo")]
        public UserMangaListInfoModel Myinfo { get; set; }
        [XmlElement(ElementName = "manga")]
        public List<MangaInfoModel> Mangas { get; set; }
    }
}
