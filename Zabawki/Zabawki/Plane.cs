using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabawki
{
    class Plane : IRise, IAccelerate
    {
        public string name;

        public Plane(string name)
        {
            this.name = name + "(Plane)";
        }

        public int altitude { get; private set; } = 0;

        public void Rise(int amount)
        {
            this.altitude = amount;
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