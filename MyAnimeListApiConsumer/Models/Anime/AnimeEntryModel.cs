using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MyAnimeListApiConsumer.Models.Anime {
    [Serializable]
    [XmlRoot(ElementName = "entry")]
    public class AnimeEntryModel {
        [XmlElement(ElementName = "episode")]
        public int Episode { get; set; }
        [XmlElement(ElementName = "status")]
        public int Status { get; set; }
        [XmlElement(ElementName = "score")]
        public float Score { get; set; }
        [XmlElement(ElementName = "storage_type")]
        public string Storage_type { get; set; }
        [XmlElement(ElementName = "storage_value")]
        public string Storage_value { get; set; }
        [XmlElement(ElementName = "times_rewatched")]
        public string Times_rewatched { get; set; }
        [XmlElement(ElementName = "rewatch_value")]
        public string Rewatch_value { get; set; }
        [XmlElement(ElementName = "date_start")]
        public string Date_start { get; set; }
        [XmlElement(ElementName = "date_finish")]
        public string Date_finish { get; set; }
        [XmlElement(ElementName = "priority")]
        public string Priority { get; set; }
        [XmlElement(ElementName = "enable_discussion")]
        public int Enable_discussion { get; set; }
        [XmlElement(ElementName = "enable_rewatching")]
        public int Enable_rewatching { get; set; }
        [XmlElement(ElementName = "comments")]
        public string Comments { get; set; }
        [XmlElement(ElementName = "tags")]
        public string Tags { get; set; }
    }
}
