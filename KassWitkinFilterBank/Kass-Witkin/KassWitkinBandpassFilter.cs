using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Numerics;

namespace CustomFilterBank_Test
{
    public class KassWitkinBandpassFilter
    {
        public Bitmap Apply(Bitmap image, KassWitkinKernel kernel)
        {
            Complex[,] cImagePadded = ImageDataConverter.ToComplex(image);
            Complex[,] cKernelPadded = kernel.ToComplexPadded();
            Complex[,] convolved = Convolution.Convolve(cImagePadded, cKernelPadded);

            return ImageDataConverter.ToBitmap(convolved);
        }
    }
}
