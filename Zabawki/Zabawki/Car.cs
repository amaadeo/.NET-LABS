using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabawki
{
    class Car : IAccelerate
    {
        public string name;
        public int speed;

        public Car(string name)
        {
            this.name = name + "(Car)";
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

        //public int speed { get; set; } = 0;

        /* public int getSpeed()
         {
             return speed;
         }*/

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
