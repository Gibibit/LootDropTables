using System;
using System.Linq;

namespace HermansGameDev.LootDropTable {

    public class DropTableSampler {

        public Random Random;

        public string Sample(DropTable table)
        {
            var totalWeight = table.Sum(item => item.Weight);
            var roll = Random.Next(totalWeight);
            foreach(var item in table)
                if (roll < item.Weight) return item.Name;
                else roll -= item.Weight;
            throw new Exception("No item was rolled. Is your table empty?");
        }

        public DropTableSampler(Random random) { Random = random; }

    }

}