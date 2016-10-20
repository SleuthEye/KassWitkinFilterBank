using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomFilterBank_Test
{
    public partial class  Tools
    {
        public static double DegreeToRadian(double angle)
        {
            return System.Math.PI * angle / 180.0;
        }

        public static double RadianToDegree(double angle)
        {
            return angle * (180.0 / Math.PI);
        }
    }
}
