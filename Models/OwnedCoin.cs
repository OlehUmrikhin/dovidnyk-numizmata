using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace dovidnyk_numizmata.Models
{
    public class OwnedCoin
    {
        [JsonIgnore]
        public Coin Coin { get; set; }
        [JsonIgnore]
        public string CoinCountry 
        {
            get {  return Coin.Country; }
        }
        [JsonIgnore]
        public string CoinPar
        {
            get { return Coin.Par; }
        }
        [JsonIgnore]
        public string CoinYearOfGraduation
        {
            get { return Coin.YearOfGraduation;  }
        }
        [JsonIgnore]
        public string CoinMaterial 
        {
            get { return Coin.Material; }
        }
        [JsonIgnore]
        public int CoinAmount 
        {
            get { return Coin.Amount; }
        }
        [JsonIgnore]
        public string CoinFeatures 
        {
            get { return Coin.Features; }
        }
        [JsonIgnore]
        public int CoinRemaining 
        {
            get { return Coin.RemainingCoins; }
        }
        [JsonIgnore]
        public bool CoinIsRare
        {
            get { return Coin.IsRare; }
        }


        public Guid CoinId { get; set; }

        public string Condition { get; set; }

        public OwnedCoin(Coin coin, string Condition)
        {
            CoinId = coin.Id;
            Coin = coin;
            this.Condition = Condition;
        }

        [JsonConstructor]
        public OwnedCoin(Guid coinId, string Condition)
        {
            CoinId = coinId;
            this.Condition = Condition;
        }

    }
}
