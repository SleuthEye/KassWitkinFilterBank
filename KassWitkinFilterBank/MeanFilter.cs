using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Numerics;
using System.Text;

namespace CustomFilterBank_Test
{
    public partial class Filters
    {
         private static double[,] _meanKernel =
            new double[,] { { .11, .11, .11, }, 
                            { .11, .11, .11, }, 
                            { .11, .11, .11, }, };

        public static Bitmap FftMean(Bitmap image)
         {
             return FftPaddedConvolutionFilter(image, _meanKernel);
         }

         public static Bitmap NonFftMean(Bitmap image)
         {
             return NonfftConvolution(image, _meanKernel);
         }
    }
}
