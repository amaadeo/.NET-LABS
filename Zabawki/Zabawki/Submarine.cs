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
        public int speed;
        public int submersion;

        public Submarine(string name)
        {
            this.name = name + "(Submarine)";
        }

        public void Dive(int amount)
        {
            this.submersion = amount;
        }

        public int Speed
        {
            get
            {
                return speed;
            }

            set
            {
                speed = value;
            }
        }

        public int Submersion
        {
            get
            {
                return submersion;
            }

            set
            {
                submersion = value;
            }
        }

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