using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MyAnimeListApiConsumer.Models.Anime {
    [XmlRoot(ElementName = "anime")]
    public class AnimeInfoModel {
        [XmlElement(ElementName = "series_animedb_id")]
        public string Id { get; set; }
        [XmlElement(ElementName = "series_title")]
        public string Series_title { get; set; }
        [XmlElement(ElementName = "series_synonyms")]
        public string Series_synonyms { get; set; }
        [XmlElement(ElementName = "series_type")]
        public string Series_type { get; set; }
        [XmlElement(ElementName = "series_episodes")]
        public string Episodes { get; set; }
        [XmlElement(ElementName = "series_status")]
        public string SeriesStatus { get; set; }
        [XmlElement(ElementName = "series_start")]
        public string SeriesStart { get; set; }
        [XmlElement(ElementName = "series_end")]
        public string SeriesEnd { get; set; }
        [XmlElement(ElementName = "series_image")]
        public string SeriesImage { get; set; }
        [XmlElement(ElementName = "my_id")]
        public string UserId { get; set; }
        [XmlElement(ElementName = "my_watched_episodes")]
        public string WatchedEpisodes { get; set; }
        [XmlElement(ElementName = "my_start_date")]
        public string MyStartDate { get; set; }
        [XmlElement(ElementName = "my_finish_date")]
        public string MyFinishDate { get; set; }
        [XmlElement(ElementName = "my_score")]
        public string MyScore { get; set; }
        [XmlElement(ElementName = "my_status")]
        public string MyStatus { get; set; }
        [XmlElement(ElementName = "my_rewatching")]
        public string Rewatching { get; set; }
        [XmlElement(ElementName = "my_rewatching_ep")]
        public string MyRewatchingEp { get; set; }
        [XmlElement(ElementName = "my_last_updated")]
        public string MyLastUpdated { get; set; }
        [XmlElement(ElementName = "my_tags")]
        public string MyTags { get; set; }
    }
}
