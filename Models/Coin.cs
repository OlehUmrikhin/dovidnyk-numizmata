using dovidnyk_numizmata.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace dovidnyk_numizmata.Models
{
    public class Coin : IIsIdentical
    {
        public Guid Id { get; set; }
        public string Country { get; set; }
        public string Par { get; set; }
        public string YearOfGraduation { get; set; }
        public string Material { get; set; }
        public int Amount { get; set; }
        public string Features { get; set; }
        public int RemainingCoins { get; set; }
        public bool IsRare 
        {
            get { return Amount <= 100; }
        }

        public Coin(string Country, string Par, string YearOfGraduation, string Material, int Amount, string Features, int RemainingCoins)
        {
            this.Id = Guid.NewGuid();
            this.Country = Country;
            this.Par = Par;
            this.YearOfGraduation = YearOfGraduation;
            this.Material = Material;
            this.Amount = Amount;
            this.Features = Features;
            this.RemainingCoins = RemainingCoins;
        }

        [JsonConstructor]
        public Coin(Guid Id, string Country, string Par, string YearOfGraduation, string Material, int Amount, string Features, int RemainingCoins)
        {
            this.Id = Id;
            this.Country = Country;
            this.Par = Par;
            this.YearOfGraduation = YearOfGraduation;
            this.Material = Material;
            this.Amount = Amount;
            this.Features = Features;
            this.RemainingCoins = RemainingCoins;
        }

        public bool IsIdentical(Coin otherCoin)
        {
            if (otherCoin == null)
            {
                return false;
            }

            return this.Country == otherCoin.Country &&
                   this.Par == otherCoin.Par &&
                   this.YearOfGraduation == otherCoin.YearOfGraduation &&
                   this.Material == otherCoin.Material &&
                   this.Features == otherCoin.Features;
        }
    }
}