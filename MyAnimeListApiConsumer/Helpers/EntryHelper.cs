using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace MyAnimeListApiConsumer.Helpers {
    public class EntryHelper {
        public static String EntryToXML(object entry) {
            using (MemoryStream memoryStream = new MemoryStream()) {
                using (StreamWriter writer = new StreamWriter(memoryStream, Encoding.UTF8)) {
                    XmlSerializer xml = new XmlSerializer(entry.GetType());
                    xml.Serialize(writer, entry);

                    memoryStream.Seek(0, SeekOrigin.Begin);
                    var streamReader = new StreamReader(memoryStream, System.Text.Encoding.UTF8);
                    return streamReader.ReadToEnd();
                }
            }
        }
    }
}
