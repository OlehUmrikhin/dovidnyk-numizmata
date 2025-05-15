using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace dovidnyk_numizmata.Models
{
    public class Coin
    {
        public Guid Id { get; set; }
        public string Country { get; set; }
        public string Par { get; set; }
        public string YearOfGraduation { get; set; }
        public string Material { get; set; }
        public int Amount { get; set; }
        public string Features { get; set; }
        [JsonIgnore]
        public string Info 
        {
            get 
            {
                return ToString();
            }
            
        }

        public Coin(string Country, string Par, string YearOfGraduation, string Material, int Amount, string Features)
        {
            this.Id = Guid.NewGuid();
            this.Country = Country;
            this.Par = Par;
            this.YearOfGraduation = YearOfGraduation;
            this.Material = Material;
            this.Amount = Amount;
            this.Features = Features;
        }

        [JsonConstructor]
        public Coin(Guid Id, string Country, string Par, string YearOfGraduation, string Material, int Amount, string Features)
        {
            this.Id = Id;
            this.Country = Country;
            this.Par = Par;
            this.YearOfGraduation = YearOfGraduation;
            this.Material = Material;
            this.Amount = Amount;
            this.Features = Features;
        }

        public override string ToString()
        {
            return $"{Country} - {Par} ({YearOfGraduation})  |  Матеріал: {Material}  |  Кількість: {Amount}  |  Особливості: {Features}";
        }

        public bool Equals(Coin other)
        {
            if (other == null)
                return false;

            return Country == other.Country &&
                   Par == other.Par &&
                   YearOfGraduation == other.YearOfGraduation &&
                   Material == other.Material &&
                   Amount == other.Amount &&
                   Features == other.Features;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Coin);
        }

    }
}