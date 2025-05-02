using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace dovidnyk_numizmata
{
    public class Collectors
    {
        public string Country { get; set; }
        public string Name { get; set; }
        public string Contacts { get; set; }
        public string ReralyCoins { get; set; }
        public string Features { get; set; }

        public Collectors(string Country, string Name, string Contacts, string ReralyCoins, string Features)
        {
            this.Country = Country;
            this.Name = Name;
            this.Contacts = Contacts;
            this.ReralyCoins = ReralyCoins;
            this.Features = Features;
        }
    }
}
