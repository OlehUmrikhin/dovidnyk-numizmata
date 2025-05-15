using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace dovidnyk_numizmata.Models
{
    public class OwnedCoin
    {
        public Coin Coin { get; set; }
        public string Condition { get; set; }
        public string Info 
        {
            get 
            {
                return ToString();
            }
        }

        public OwnedCoin(Coin coin, string condition)
        {
            Coin = coin;
            Condition = condition;
        }

        public override string ToString()
        {
            return $"{Coin.ToString()}, {Condition}";
        }
    }
}
