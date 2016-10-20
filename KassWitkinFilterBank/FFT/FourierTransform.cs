using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Numerics;

namespace CustomFilterBank_Test
{
    public class FourierTransform
    {
        // Input Image
        public Bitmap ImageBitmap;
        // Greyscale Image Array Generated from input Image
        public Complex[,] GrayscaleImageComplex;
        public int[,] GrayscaleImageInteger;
        //Fourier Transformed Image
        public Complex[,] FourierImageComplex;

        int Width = 0;
        int Height = 0;

        public FourierTransform() { }
        
        public FourierTransform(Bitmap image)
        {
            ImageBitmap = image;
            Width = image.Width;
            Height = image.Height;

            GrayscaleImageInteger = Grayscale.ToGrayscale2(ImageBitmap);
            GrayscaleImageComplex = ImageDataConverter.ToComplex(GrayscaleImageInteger);  
        }

        public FourierTransform(int[,] image)
        {
            Width = image.GetLength(0);
            Height = image.GetLength(1);

            ImageBitmap = ImageDataConverter.ToBitmap(image);
            GrayscaleImageInteger = image;
            GrayscaleImageComplex = ImageDataConverter.ToComplex(GrayscaleImageInteger);
        }

        public FourierTransform(Complex[,] image)
        {
            Width = image.GetLength(0);
            Height = image.GetLength(1);

            GrayscaleImageComplex = image;
            GrayscaleImageInteger = ImageDataConverter.ToInteger(image);
        }

        public void ForwardFFT()
        {
            FourierImageComplex = FourierFunction.FFT2D(GrayscaleImageComplex, Width, Height, 1);
        }

        public void InverseFFT()
        {
            InverseFFT(FourierImageComplex);
        }

        public void InverseFFT(Complex[,] fftImage)
        {
            if (FourierImageComplex == null)
            {
                FourierImageComplex = fftImage;

                Width = FourierImageComplex.GetLength(0);
                Height = FourierImageComplex.GetLength(1);
            }

            GrayscaleImageComplex = FourierFunction.FFT2D(FourierImageComplex, Width, Height, -1);

            GrayscaleImageInteger = ImageDataConverter.ToInteger(GrayscaleImageComplex);

            ImageBitmap = ImageDataConverter.ToBitmap(GrayscaleImageInteger);
        }
    }
}