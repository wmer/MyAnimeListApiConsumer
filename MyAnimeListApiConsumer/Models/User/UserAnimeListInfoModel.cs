using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MyAnimeListApiConsumer.Models.User {
    [XmlRoot(ElementName = "myinfo")]
    public class UserAnimeListInfoModel {
        [XmlElement(ElementName = "user_id")]
        public int Id { get; set; }
        [XmlElement(ElementName = "user_name")]
        public string UserName { get; set; }
        [XmlElement(ElementName = "user_watching")]
        public int Watching { get; set; }
        [XmlElement(ElementName = "user_completed")]
        public int Completed { get; set; }
        [XmlElement(ElementName = "user_onhold")]
        public int Onhold { get; set; }
        [XmlElement(ElementName = "user_dropped")]
        public int Dropped { get; set; }
        [XmlElement(ElementName = "user_plantowatch")]
        public int PlanToWatch { get; set; }
        [XmlElement(ElementName = "user_days_spent_watching")]
        public float DaysSpentWatching { get; set; }
    }
}
