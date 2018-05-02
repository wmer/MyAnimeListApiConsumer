using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MyAnimeListApiConsumer.Models.Manga {
    [XmlRoot(ElementName = "entry")]
    public class MangaEntryModel {
        [XmlElement(ElementName = "chapter")]
        public int Chapter { get; set; }
        [XmlElement(ElementName = "volume")]
        public int Volume { get; set; }
        [XmlElement(ElementName = "status")]
        public int Status { get; set; }
        [XmlElement(ElementName = "score")]
        public float Score { get; set; }
        [XmlElement(ElementName = "times_reread")]
        public string Times_reread { get; set; }
        [XmlElement(ElementName = "reread_value")]
        public string Reread_value { get; set; }
        [XmlElement(ElementName = "date_start")]
        public string Date_start { get; set; }
        [XmlElement(ElementName = "date_finish")]
        public string Date_finish { get; set; }
        [XmlElement(ElementName = "priority")]
        public string Priority { get; set; }
        [XmlElement(ElementName = "enable_discussion")]
        public string Enable_discussion { get; set; }
        [XmlElement(ElementName = "enable_rereading")]
        public string Enable_rereading { get; set; }
        [XmlElement(ElementName = "comments")]
        public string Comments { get; set; }
        [XmlElement(ElementName = "scan_group")]
        public string Scan_group { get; set; }
        [XmlElement(ElementName = "tags")]
        public string Tags { get; set; }
        [XmlElement(ElementName = "retail_volumes")]
        public string Retail_volumes { get; set; }
    }
}
