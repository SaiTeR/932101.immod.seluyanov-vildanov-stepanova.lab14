﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoservice
{
    public static class ExpRandomValue
    {
        public static double Get(double value)
        {
            Random rand = new Random();
            return -Math.Log(rand.NextDouble()) / value;
        }
    }
}
