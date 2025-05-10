using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dovidnyk_numizmata
{
    public class Coin
    {
        public string Country { get; set; }
        public string Par { get; set; }
        public string YearOfGraduation { get; set; }
        public string Material { get; set; }
        public string Number { get; set; }
        public string Features { get; set; }
        public string Info 
        {
            get 
            {
                return ToString();
            }
            
        }

        public Coin(string Country, string Par, string YearOfGraduation, string Material, string Number, string Features)
        {
            this.Country = Country;
            this.Par = Par;
            this.YearOfGraduation = YearOfGraduation;
            this.Material = Material;
            this.Number = Number;
            this.Features = Features;
        }

        public override string ToString()
        {
            return $"{Country} - {Par} ({YearOfGraduation})  |  Матеріал: {Material}  |  Кількість: {Number}  |  Особливості: {Features}";
        }

        public bool Equals(Coin other)
        {
            if (other == null)
                return false;

            return Country == other.Country &&
                   Par == other.Par &&
                   YearOfGraduation == other.YearOfGraduation &&
                   Material == other.Material &&
                   Number == other.Number &&
                   Features == other.Features;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Coin);
        }

    }
}