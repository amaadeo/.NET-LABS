using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabawki
{
    class Submarine : IDive, IAccelerate
    {
        public string name;

        public Submarine(string name)
        {
            this.name = name + "(Submarine)";
        }

        public int submersion { get; private set; } = 0;

        public void Dive(int amount)
        {
            this.submersion = amount;
        }

        public int speed { get; private set; } = 0;

        public void Accelerate(int amount)
        {
            this.speed = amount;
        }

        public override string ToString()
        {
            return name;
        }
    }
}