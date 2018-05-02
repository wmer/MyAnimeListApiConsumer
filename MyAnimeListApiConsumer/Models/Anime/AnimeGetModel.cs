using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MyAnimeListApiConsumer.Models.Anime {
    [XmlRoot(ElementName = "anime")]
    public class AnimeGetModel {
        [XmlElement(ElementName = "entry")]
        public List<EntryGetModel> Entry { get; set; }
    }
}
