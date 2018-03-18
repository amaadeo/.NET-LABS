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

        public Car(string name)
        {
            this.name = name + "(Car)";
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
