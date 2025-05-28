using dovidnyk_numizmata.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dovidnyk_numizmata.Interfaces
{
    internal interface IIsIdentical
    {
        bool IsIdentical(Coin coin);
    }
}
