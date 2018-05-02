using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MyAnimeListApiConsumer.Models.Manga {
    [XmlRoot(ElementName = "manga")]
    public class MangaInfoModel {
        [XmlElement(ElementName = "series_mangadb_id")]
        public string Id { get; set; }
        [XmlElement(ElementName = "series_title")]
        public string Title { get; set; }
        [XmlElement(ElementName = "series_synonyms")]
        public string SeriesSynonyms { get; set; }
        [XmlElement(ElementName = "series_type")]
        public string Type { get; set; }
        [XmlElement(ElementName = "series_chapters")]
        public string Chapters { get; set; }
        [XmlElement(ElementName = "series_volumes")]
        public string Volumes { get; set; }
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
        [XmlElement(ElementName = "my_read_chapters")]
        public string ReadChapters { get; set; }
        [XmlElement(ElementName = "my_read_volumes")]
        public string ReadVolumes { get; set; }
        [XmlElement(ElementName = "my_start_date")]
        public string MyStartDate { get; set; }
        [XmlElement(ElementName = "my_finish_date")]
        public string MyFinishDate { get; set; }
        [XmlElement(ElementName = "my_score")]
        public string MyScore { get; set; }
        [XmlElement(ElementName = "my_status")]
        public string MyStatus { get; set; }
        [XmlElement(ElementName = "my_rereadingg")]
        public string MyRereadingg { get; set; }
        [XmlElement(ElementName = "my_rereading_chap")]
        public string MyRereadingChapter { get; set; }
        [XmlElement(ElementName = "my_last_updated")]
        public string MyLastUpdated { get; set; }
        [XmlElement(ElementName = "my_tags")]
        public string MyTags { get; set; }
    }
}
