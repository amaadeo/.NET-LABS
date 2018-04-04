using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabawki
{
    interface IRise
    {
        int Altitude { get; set; }
        void Rise(int amount);
    }
}
