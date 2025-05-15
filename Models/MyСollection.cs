using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dovidnyk_numizmata.Models
{
    public class MyСollection
    {
        public Collector Owner {  get; set; }
        public List<OwnedCoin> OwnedCoins { get; set; }
        public MyСollection(Collector Owner, List<OwnedCoin> OwnedCoins)
        {
            this.Owner = Owner;
            this.OwnedCoins = OwnedCoins;
        }
    }
}
