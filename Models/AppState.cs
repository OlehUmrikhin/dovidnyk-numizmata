using dovidnyk_numizmata.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace dovidnyk_numizmata.Models
{
    public static class AppState
    {
        public static BindingList<Coin>? CoinsList;
        public static BindingList<Collector>? CollectorsList;
        public static string? MyId;
        public static bool isEdit = false;
        public static CollectionsOfCollectorsForm? myCollectionOfCollectorsForm;
        public static CollectorsForm? collectorsForm;
        public static CollectionsOfCollectorsForm? collectionsOfCollectorsForm;
        public static AddCoinForm? addCoinForm;
        public static AddCollectorForm? addCollectorForm;
        public static CoinsForm? coinsForm;
        public static List<Collector> ?collectors;


        public static void Initialize() 
        {
            CreateFileIfNotExists("coins.txt");

            string jsonCoinsListString = File.ReadAllText("coins.txt");
            bool fileExisted = CreateFileIfNotExists("collectors.txt");
            if (jsonCoinsListString.Length > 0)
            {
                CoinsList = JsonSerializer.Deserialize<BindingList<Coin>>(jsonCoinsListString);
            }
            else
            {
                CoinsList = new BindingList<Coin>();
                TestDataCoins("Україна", "гривня", 102);
                TestDataCoins("США", "долар", 20);
                TestDataCoins("Німеччина", "євро", 15);
                TestDataCoins("Китай", "юань", 10);
                TestDataCoins("Японія", "єна", 300);
                TestDataCoins("Турція", "ліра", 1532);
                TestDataCoins("ОАЕ", "дирхам", 24);
                TestDataCoins("Велика Британія", "фунт", 10);
                TestDataCoins("Південна Корея", "вона", 10);
                TestDataCoins("Бразилія", "реал", 10);
                TestDataCoins("Італія", "ліра", 15);
                string coinsJson = JsonSerializer.Serialize(CoinsList);
                File.WriteAllText("coins.txt", coinsJson);
            }
            if (!fileExisted)
            {
                SeedMeCollector();

                SeedCollector("Німеччина", 1, 10);
                SeedCollector("США", 11, 10);
                SeedCollector("Україна", 21, 10);
                string collectorsJson = JsonSerializer.Serialize(AppState.collectors);
                File.WriteAllText("collectors.txt", collectorsJson);
            }
            string jsonCollectorsListString = File.ReadAllText("collectors.txt");
            var collectors = JsonSerializer.Deserialize<List<Collector>>(jsonCollectorsListString);
            collectors?.ForEach(
                collector => collector.CoinsCollection.ForEach(
                    ownedCoin =>
                    {
                        var coin = CoinsList?.FirstOrDefault(coin => ownedCoin.CoinId.ToString() == coin.Id.ToString());
                        ownedCoin.Coin = coin;
                    }
                )
            );
            CollectorsList = new BindingList<Collector>(collectors);
            MyId = CollectorsList[0].Id.ToString();

        }

        private static bool CreateFileIfNotExists(string path)
        {
            bool existed = File.Exists(path);
            if (!existed)
            {
                using (File.Create(path))
                {

                }
            }
            return existed;
        }

        private static void SeedMeCollector()
        {
            var collector = new Collector("Україна", "Я", "-");
            collector.CollectCoin(CoinsList[0], "new");
            collector.CollectCoin(CoinsList[0], "new");
            collector.CollectCoin(CoinsList[0], "new");
            collector.CollectCoin(CoinsList[6], "new");
            collector.CollectCoin(CoinsList[17], "new");
            collector.CollectCoin(CoinsList[18], "new");
            collector.CollectCoin(CoinsList[20], "new");
            collector.CollectCoin(CoinsList[23], "new");
            collector.CollectCoin(CoinsList[35], "new");
            collector.CollectCoin(CoinsList[41], "new");
            collector.CollectCoin(CoinsList[55], "new");
            collector.CollectCoin(CoinsList[85], "new");
            collector.CollectCoin(CoinsList[99], "new");
            collector.CollectCoin(CoinsList[101], "new");
            collector.CollectCoin(CoinsList[102], "new");
            collector.CollectCoin(CoinsList[103], "new");
            collector.CollectCoin(CoinsList[108], "new");
            collectors = [collector];
            MyId = collector.Id.ToString();
        }

        private static void SeedCollector(string country, int startNumber, int count)
        {
            for (int i = 0; i < count; i++)
            {
                var collector = new Collector(country, $"Колекціонер {startNumber + i}", "-");
                collectors?.Add(collector);
            }
        }

        public static void RemoveCoinFromAllCollector(Guid coinId)
        {
            foreach (var collector in CollectorsList.ToList())
            {
                foreach (var coin in collector.CoinsCollection.ToList())
                {
                    if (coin.CoinId == coinId)
                    {
                        collector.CoinsCollection.Remove(coin);
                    }
                }
            }
        }

        public static void TestDataCoins(string country, string par, int amount)
        {
            for (int i = 0; i < 10; i++)
            {
                CoinsList?.Add(new Coin($"{country}", $"{i + 1} {par}", $"200{i}", $"матеріал{i + 1}", amount, "нема", amount));
            }
        }
    }
}
