using System;
using System.IO;
using HermansGameDev.LootDropTable;

namespace LootDropTableExample {

    internal class Program {

        private static void Main(string[] args)
        {
            if (args.Length == 0) {
                Console.WriteLine("Please use the bat files!");
                Console.WriteLine("Press the Any key to quit...");
                Console.ReadKey();
            }
            else {
                var mode = args[0];
                var file = args[1];

                switch (mode) {
                    case "sample":
                        TestSampleNormalTable(file);
                        break;
                    case "display":
                        TestPrintNormalTable(file);
                        break;
                    case "displayJSON":
                        TestPrintNormalTable(file, true);
                        break;
                    case "sampleJSON":
                        TestSampleNormalTable(file, true);
                        break;
                    default:
                        TestPrintNormalTable(file);
                        break;
                }
            }
        }

        private static void TestPrintNormalTable(string fileName, bool json = false)
        {
            Console.WriteLine($"Displaying loot from {fileName}...\n");

            var loader = json ? (IDropTableFileLoader) new DropTableJSONLoader() : new DropTableXmlLoader();

            try
            {
                var table = loader.LoadDropTable(fileName);
                Console.WriteLine("dropTable: {0}", table.Name);
                foreach (var item in table)
                {
                    Console.WriteLine("  item:");
                    Console.WriteLine("    name: {0}", item.Name);
                    Console.WriteLine("    weight: {0}", item.Weight);
                }
            }
            catch (IOException) { }

            Console.WriteLine("Press the Any key to quit...");
            Console.ReadKey();
        }

        private static void TestSampleNormalTable(string fileName, bool json = false)
        {
            Console.WriteLine($"Grabbin' loot from {fileName}...\n");
            var random = new Random();

            try {
                var loader = json ? (IDropTableFileLoader) new DropTableJSONLoader() : new DropTableXmlLoader();
                var table = loader.LoadDropTable(fileName);
                var sampler = new DropTableSampler(random);

                Console.WriteLine("Press the Any key to receive loot...");

                while (true) {

                    Console.ReadKey(true);

                    var sample = sampler.Sample(table);

                    switch (random.Next(4)) {
                        case 0:
                            Console.WriteLine("You found the {0}!", sample);
                            break;
                        case 1:
                            Console.WriteLine("You hoarded a {0}!", sample);
                            break;
                        case 2:
                            Console.WriteLine("Player 69 found: {0}!", sample);
                            break;
                        case 3:
                            Console.WriteLine("{0} get!", sample);
                            break;
                    }
                }
            }
            catch (IOException) { }
        }

    }

}