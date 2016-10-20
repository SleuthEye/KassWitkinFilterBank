using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace CustomFilterBank_Test
{
    public partial class Convolution
    {
        public static Complex[,] ConvolveInFrequencyDomain(Complex[,] fftImage, Complex[,] fftKernel)
        {
            Complex[,] convolve = null;

            int imageWidth = fftImage.GetLength(0);
            int imageHeight = fftImage.GetLength(1);

            int maskWidth = fftKernel.GetLength(0);
            int maskHeight = fftKernel.GetLength(1);

            if (imageWidth == maskWidth && imageHeight == maskHeight)
            {
                Complex[,] fftConvolved = new Complex[imageWidth, imageHeight];

                for (int j = 0; j < imageHeight; j++)
                {
                    for (int i = 0; i < imageWidth; i++)
                    {
                        fftConvolved[i, j] = fftImage[i, j] * fftKernel[i, j];
                    }
                }

                FourierTransform ftForConv = new FourierTransform();
                ftForConv.InverseFFT(fftConvolved);
                convolve = FourierShifter.FFTShift(ftForConv.GrayscaleImageComplex);

                Rescale(convolve);
            }
            else
            {
                throw new Exception("padding needed");
            }

            return convolve;
        }
    }

}
