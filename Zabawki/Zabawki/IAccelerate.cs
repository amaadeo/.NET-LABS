﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabawki
{
    interface IAccelerate
    {
        int speed { get; }
        void Accelerate(int amount);
    }
}
