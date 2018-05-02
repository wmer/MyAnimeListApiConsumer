using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MyAnimeListApiConsumer.Models {
    [XmlRoot(ElementName = "entry")]
    public class EntryGetModel {
        [XmlElement(ElementName = "id")]
        public int Id { get; set; }
        [XmlElement(ElementName = "title")]
        public String Title { get; set; }
        [XmlElement(ElementName = "english")]
        public String English { get; set; }
        [XmlElement(ElementName = "synonyms")]
        public String Synonyms { get; set; }
        [XmlElement(ElementName = "chapters")]
        public int Chapters { get; set; }
        [XmlElement(ElementName = "score")]
        public float Score { get; set; }
        [XmlElement(ElementName = "type")]
        public String Type { get; set; }
        [XmlElement(ElementName = "status")]
        public String Status { get; set; }
        [XmlElement(ElementName = "start_date")]
        public String Start_date { get; set; }
        [XmlElement(ElementName = "end_date")]
        public String End_date { get; set; }
        [XmlElement(ElementName = "synopsis")]
        public String Synopsis { get; set; }
        [XmlElement(ElementName = "image")]
        public String Image { get; set; }
    }
}
