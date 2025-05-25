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
        public static CollectionsOfCollectorsForm? collectionOfCollectorsForm;
        public static CollectorsForm? collectorsForm;
        public static CollectionsOfCollectorsForm? collectionsOfCollectorsForm;
        public static AddCoinForm? addCoinForm;
        public static AddCollectorForm? addCollectorForm;
        public static CoinsForm? coinsForm;


        public static void Initialize() 
        {
            CreateFileIfNotExists("coins.txt");
            string jsonCoinsListString = File.ReadAllText("coins.txt");
            bool fileExisted = CreateFileIfNotExists("collectors.txt");
            if(!fileExisted)
            {
                SeedCollector();
            }
            string jsonCollectorsListString = File.ReadAllText("collectors.txt");

            if(jsonCoinsListString.Length > 0)
            {
                CoinsList = JsonSerializer.Deserialize<BindingList<Coin>>(jsonCoinsListString);    
                
            } 
            else
            {
                CoinsList = new BindingList<Coin>();
                //TestDataCoins("Україна", "гривня");
                //TestDataCoins("США", "долар");
                //TestDataCoins("Німеччина", "євро");
                //TestDataCoins("Китай", "юань");
                //TestDataCoins("Японія", "єна");
                //TestDataCoins("Турція", "ліра");
                //TestDataCoins("ОАЕ", "дирхам");
                //TestDataCoins("Велика Британія", "фунт");
                //TestDataCoins("Південна Корея", "вона");
                //TestDataCoins("Бразилія", "реал");
                //TestDataCoins("Італія", "ліра");
                //string coinsJson = JsonSerializer.Serialize(CoinsList);
                //File.WriteAllText("coins.txt", coinsJson);
            } 
            var collectors = JsonSerializer.Deserialize<List<Collector>>(jsonCollectorsListString);
            collectors.ForEach(
                collector => collector.CoinsCollection.ForEach(
                    ownedCoin => {
                        var coin = CoinsList.FirstOrDefault(coin => ownedCoin.CoinId.ToString() == coin.Id.ToString());
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

        private static void SeedCollector() 
        {
            var collector = new Collector("Україна", "Я", "-");
            List<Collector> collectors = [collector];
            MyId = collector.Id.ToString();
            string collectorsJson = JsonSerializer.Serialize(collectors);
            File.WriteAllText("collectors.txt", collectorsJson);
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

        public static void TestDataCoins(string country, string par) 
        {
            for (int i = 0; i < 10; i++) 
            {
                CoinsList.Add(new Coin($"{country}", $"{i+1} {par}", $"200{i}", $"матеріал{i+1}", 10, "нема", 10)); 
            }
        }

        public static void TestDataCollectors(string country)
        {
            for (int i = 0; i < 10; i++)
            {
                CollectorsList.Add(new Collector($"{country}", $"Колекціонер {i+1}", "-"));
            }
        }
    }
}
