using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabawki
{
    class Computer
    {
        public string name;

        public Computer(string name)
        {
            this.name = name + "(Computer)";
        }

        public override string ToString()
        {
            return name;
        }
    }
}
