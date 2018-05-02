using MyAnimeListApiConsumer.Models.Anime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MyAnimeListApiConsumer.Models.User {
    [XmlRoot(ElementName = "myanimelist")]
    public class MyAnimeListModel {
        [XmlElement(ElementName = "myinfo")]
        public UserAnimeListInfoModel Myinfo { get; set; }
        [XmlElement(ElementName = "anime")]
        public List<AnimeInfoModel> Animes { get; set; }
    }
}
