﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabawki
{
    interface IAccelerate
    {
        int Speed { get; set; }
        void Accelerate(int amount);
    }
}
