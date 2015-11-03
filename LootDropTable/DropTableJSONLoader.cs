using System.IO;
using Newtonsoft.Json;

namespace HermansGameDev.LootDropTable
{
    public class DropTableJSONLoader : IDropTableFileLoader
    {
        public DropTable LoadDropTable(string fileName)
        {
            using (var stream = File.OpenRead(fileName)) {
                var reader = new StreamReader(stream);
                var json = reader.ReadToEnd();

                var data = JsonConvert.DeserializeObject<DropTableData>(json);

                return new DropTable(data);
            }
        }
    }
}