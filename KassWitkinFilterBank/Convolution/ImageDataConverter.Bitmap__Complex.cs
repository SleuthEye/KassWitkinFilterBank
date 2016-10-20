using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;

namespace CustomFilterBank_Test
{
    public static partial class ImageDataConverter
    {
        public static Complex[,] ToComplex(Bitmap image)
        {
            return ImageDataConverter.ToComplex(ImageDataConverter.ToInteger(image));
        }

        public static Bitmap ToBitmap(Complex[,] image)
        {
            return ImageDataConverter.ToBitmap(ImageDataConverter.ToInteger(image));
        }
    }
}
