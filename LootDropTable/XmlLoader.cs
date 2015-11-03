using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace HermansGameDev.LootDropTable
{
    public class DropTableXmlLoader : IDropTableFileLoader
    {
        public DropTable LoadDropTable(string fileName)
        {
            using (var stream = File.OpenRead(fileName)) {
                var serializer = new XmlSerializer(typeof (DropTableData));
                var data = (DropTableData) serializer.Deserialize(stream);
                return new DropTable(data);
            }
        }
    }
}