using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomFilterBank_Test
{
    public class KassWitkinFunction
    {
        /*
         *  tx = centerX * cos 
         *  ty = centerY * sin
         *  
         *  u* =   cos . (u + tx) + sin . (v + ty)
         *  v* = - sin . (u + tx) + cos . (v + ty)
         *  
         */
        //#region MyRegion
        public static double tx(int centerX, double theta)
        {
            double costheta = Math.Cos(theta);
            double txx = centerX * costheta;
            return txx;
        }

        public static double ty(int centerY, double theta)
        {
            double sintheta = Math.Sin(theta);
            double tyy = centerY * sintheta;
            return tyy;
        }

        public static double uStar(double u, double v, int centerX, int centerY, double theta)
        {
            double sintheta = Math.Sin(theta);
            double costheta = Math.Cos(theta);

            return costheta * (u - centerX) + sintheta * (v - centerY);
        }

        //#endregion

        public static double vStar(double u, double v, int centerX, int centerY, double theta)
        {
            double sintheta = Math.Sin(theta);
            double costheta = Math.Cos(theta);

            return (-1) * sintheta * (u - centerX) + costheta * (v - centerY);
        }

        public static double ApplyFilterOnOneCoord(double u, double v, double Du, double Dv, int CenterX, int CenterY, double Theta, int N)
        {
            double uStarDu = KassWitkinFunction.uStar(u, v, CenterX, CenterY, Theta) / Du;
            double vStarDv = KassWitkinFunction.vStar(u, v, CenterX, CenterY, Theta) / Dv;

            double arg = uStarDu + vStarDv;
            double div = Math.Sqrt(1 + Math.Pow(arg, 2 * N)); ;

            return 1 / div;
        }

    }
}
