using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MyAnimeListApiConsumer.Models.Manga {
    [XmlRoot(ElementName = "manga")]
    public class MangaGetModel {
        [XmlElement(ElementName = "entry")]
        public List<EntryGetModel> Entry { get; set; }
    }
}
