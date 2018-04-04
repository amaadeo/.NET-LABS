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
        public int speed;
        public int altitude;

        public Plane(string name)
        {
            this.name = name + "(Plane)";
        }

        public void Rise(int amount)
        {
            this.altitude = amount;
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

        public int Altitude
        {
            get
            {
                return altitude;
            }

            set
            {
                altitude = value;
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