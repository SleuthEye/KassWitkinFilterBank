using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomFilterBank_Test
{
    public static partial class Convolution
    {
        public static Complex[,] Convolve(Complex[,]image, Complex[,]mask)
        {
            Complex[,] convolve = null;

            int imageWidth = image.GetLength(0);
            int imageHeight = image.GetLength(1);

            int maskWidth = mask.GetLength(0);
            int maskeHeight = mask.GetLength(1);

            if (imageWidth == maskWidth && imageHeight == maskeHeight)
            {
                FourierTransform ftForImage = new FourierTransform(image); ftForImage.ForwardFFT();
                FourierTransform ftForMask = new FourierTransform(mask); ftForMask.ForwardFFT();

                Complex[,] fftImage = ftForImage.FourierImageComplex;                
                Complex[,] fftKernel = ftForMask.FourierImageComplex;

                Complex[,] fftConvolved = new Complex[imageWidth, imageHeight];


                for (int j = 0; j < imageHeight; j++)
                {
                    for (int i = 0; i < imageWidth; i++)
                    {
                        fftConvolved[i,j] = fftImage[i,j] * fftKernel[i,j];
                    }
                }

                FourierTransform ftForConv = new FourierTransform();

                ftForConv.InverseFFT(fftConvolved);

                convolve = ftForConv.GrayscaleImageComplex;

                Rescale(convolve);

                convolve = FourierShifter.FFTShift(convolve);
            }
            else
            {
                throw new Exception("padding needed");
            }

            return convolve;
        }

        //Rescale values between 0 and 255.
        private static void Rescale(Complex[,] convolve)
        {
            int imageWidth = convolve.GetLength(0);
            int imageHeight = convolve.GetLength(1);

            double maxAmp = 0.0;
            for (int j = 0; j < imageHeight; j++)
            {
                for (int i = 0; i < imageWidth; i++)
                {
                    maxAmp = Math.Max(maxAmp, convolve[i,j].Magnitude);
                }
            }
            double scale = 255.0 / maxAmp;

            for (int j = 0; j < imageHeight; j++)
            {
                for (int i = 0; i < imageWidth; i++)
                {
                    convolve[i,j] = new Complex(convolve[i,j].Real * scale, convolve[i,j].Imaginary * scale);
                    maxAmp = Math.Max(maxAmp, convolve[i,j].Magnitude);
                }
            }
        }
    }
}
