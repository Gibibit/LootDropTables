using System;
using System.Collections.Generic;

namespace HermansGameDev.LootDropTable {

    [Serializable]
    public struct DropTableData {
        
        public string Name;
        public List<LootItem> LootItems;

    }

}