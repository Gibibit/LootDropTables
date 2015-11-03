using System.Collections;
using System.Collections.Generic;

namespace HermansGameDev.LootDropTable
{
    public class DropTable : IEnumerable<LootItem>
    {
        private DropTableData _data;

        public DropTable(List<LootItem> items, string name)
        {
            _data = new DropTableData {
                LootItems = new List<LootItem>(items),
                Name = name
            };
        }

        public DropTable(DropTableData data)
        {
            _data = data;
        }

        public string Name => _data.Name;
        public LootItem this[int i] => _data.LootItems[i];
        public IEnumerator<LootItem> GetEnumerator() => _data.LootItems.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}