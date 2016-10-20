using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomFilterBank_Test
{
    public static partial class Tools
    {
        public static double Scale(this double value, double fromMin, double fromMax, double toMin, double toMax)
        {
            double max = (toMax);
            double min = (toMin);
            double result = (max - min) * (value - fromMin) / (fromMax - fromMin) + min;
            return (result);
        }
    }
}
