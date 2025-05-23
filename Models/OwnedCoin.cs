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
        public Guid CoinId { get; set; }

        public string Condition { get; set; }
        //public string Country 
        //{
        //    get { return Coin.Country; }
        //}
        //public string Par 
        //{
        //    get { return Coin.Par; }
        //}
        //public string YearOfGraduation 
        //{
        //    get { return Coin.YearOfGraduation; }
        //}
        //public string Material 
        //{
        //    get { return Coin.Material; }
        //}
        //public int Amount 
        //{
        //    get { return Coin.Amount; }
        //}
        //public string Features 
        //{
        //    get { return Coin.Features; }
        //}
        //public int RemainingCoins 
        //{
        //    get { return Coin.RemainingCoins; }
        //}

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

        public override string ToString()
        {
            return $"{Coin.ToString()}, {Condition}";
        }
    }
}
