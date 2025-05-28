using dovidnyk_numizmata.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace dovidnyk_numizmata.Models
{
    public class Collector : ICollector
    {
        public Guid Id { get; set; }
        public string Country { get; set; }
        public string Name { get; set; }
        public string Contacts { get; set; }

        public List<OwnedCoin> CoinsCollection { get; set; } = new List<OwnedCoin>();


        public Collector(string Country, string Name, string Contacts)
        {
            this.Id = Guid.NewGuid();
            this.Country = Country;
            this.Name = Name;
            this.Contacts = Contacts;
        }
        public void CollectCoin(Coin coin, string Condition)
        {
            OwnedCoin newOwnedCoin = new OwnedCoin(coin, Condition);
            coin.RemainingCoins--;
            CoinsCollection.Add(newOwnedCoin);
        }

        public void DeCollectCoin(OwnedCoin ownedCoin) 
        {
            ownedCoin.Coin.RemainingCoins++;
            CoinsCollection.Remove(ownedCoin);
        }

        public bool IsIdentical(Collector otherCollector)
        {
            if (otherCollector == null)
            {
                return false;
            }

            return this.Country == otherCollector.Country &&
                   this.Name == otherCollector.Name &&
                   this.Contacts == otherCollector.Contacts;
        }
    }
}
