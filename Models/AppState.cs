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
        public static List<Coin> CoinsList;
        public static List<Collector> CollectorsList;

        public static void Initialize() 
        {
            string jsonCoinsListString = File.ReadAllText("data.txt");
            string jsonCollectorsListString = File.ReadAllText("collectors.txt");
            if(jsonCoinsListString.Length > 0)
            {
                CoinsList = JsonSerializer.Deserialize<List<Coin>>(jsonCoinsListString);
            } else
            {
                CoinsList = new List<Coin>();
            }
            if (jsonCollectorsListString.Length > 0)
            {
                CollectorsList = JsonSerializer.Deserialize<List<Collector>>(jsonCollectorsListString);
            }
            else {
                CollectorsList = new List<Collector>();
            }
        }
    }
}
