using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabawki
{
    interface IDive
    {
        int Submersion { get; set; }
        void Dive(int amount);
    }
}
