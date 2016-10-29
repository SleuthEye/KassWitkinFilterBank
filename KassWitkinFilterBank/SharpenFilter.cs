using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;

namespace CustomFilterBank_Test
{
    public enum PaddingType
    {
        Sum,
        Max
    }

    public static partial class Filters
    {
        private static double[,] _sharpeningKernel = new double[,]  
                        { 
                             { -1, -1, -1, },
                             { -1,  9, -1, },
                             { -1, -1, -1, }
                        };

        public static Bitmap NonfftSharpen(Bitmap image)
        {
            return NonfftConvolution(image, _sharpeningKernel);
        }

        #region NonfftSharpen
        //Modified by Yosh
        public static Bitmap NonfftConvolution(Bitmap image, double[,] mask)
        {
            Bitmap bitmap = (Bitmap)image.Clone();

            if (bitmap != null)
            {
                int width = bitmap.Width;
                int height = bitmap.Height;

                if (mask.GetLength(0) != mask.GetLength(1))
                {
                    throw new Exception("_sharpeningKernel dimensions must be same");
                }
                // Create sharpening filter.
                int filterSize = mask.GetLength(0);

                double[,] filter = (double[,])mask.Clone();

                int channels = sizeof(byte);
                double bias = 0.0; // 1.0 - strength;
                double factor = 1.0; // strength / 16.0;

                byte[,] result = new byte[bitmap.Width, bitmap.Height];

                // Lock image bits for read/write.

                BitmapData bitmapData = bitmap.LockBits(new System.Drawing.Rectangle(0, 0, width, height),
                                                            ImageLockMode.ReadWrite,
                                                            System.Drawing.Imaging.PixelFormat.Format8bppIndexed);

                // Declare an array to hold the bytes of the bitmap.
                int memorySize = bitmapData.Stride * height;
                byte[] memory = new byte[memorySize];

                // Copy the RGB values into the local array.
                Marshal.Copy(bitmapData.Scan0, memory, 0, memorySize);

                int pixel;
                // Fill the color array with the new sharpened color values.

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        double grayShade = 0.0;

                        for (int filterY = 0; filterY < filterSize; filterY++)
                        {


                            for (int filterX = 0; filterX < filterSize; filterX++)
                            {

                                int imageX = (x - filterSize / 2 + filterX + width) % width;
                                int imageY = (y - filterSize / 2 + filterY + height) % height;

                                pixel = imageY * bitmapData.Stride + channels * imageX;
                                grayShade += memory[pixel] * filter[filterX, filterY];

                            }

                            int newPixel = Math.Min(Math.Max((int)(factor * grayShade + bias), 0), 255);

                            result[x, y] = (byte)newPixel;
                        }
                    }
                }

                // Update the image with the sharpened pixels.
                for (int x = 0; x < width; x++)
                {
                    for (int y = 0; y < height; y++)
                    {
                        pixel = y * bitmapData.Stride + channels * x;

                        memory[pixel] = result[x, y];
                    }
                }

                // Copy the values back to the bitmap.
                Marshal.Copy(memory, 0, bitmapData.Scan0, memorySize);

                // Release image bits.
                bitmap.UnlockBits(bitmapData);

                return bitmap;
            }
            else
            {
                throw new Exception("input paddedImage can't be null");
            }
        } 
        #endregion

        public static Bitmap NonfftConvolution(Bitmap image, Bitmap mask)
        {
            return NonfftConvolution(image, ImageDataConverter.ToDouble(mask));
        }

        #region FFTConvolution
        private static Bitmap FftConvolutionFilter(Bitmap paddedImage, double[,] paddedMask)
        {
            if (paddedImage.PixelFormat == PixelFormat.Format8bppIndexed)
            {
                Bitmap imageClone = (Bitmap)paddedImage.Clone();
                double[,] maskClone = (double[,])paddedMask.Clone();

                Complex[,] cPaddedImage = ImageDataConverter.ToComplex(imageClone);
                Complex[,] cPaddedMask = ImageDataConverter.ToComplex(maskClone);
                Complex[,] cConvolved = Convolution.Convolve(cPaddedImage, cPaddedMask);

                return ImageDataConverter.ToBitmap(cConvolved);
            }
            else
            {
                throw new Exception("not a grascale");
            }
        } 
        #endregion

        public static Bitmap FftPaddedConvolutionFilter(Bitmap unpaddedImage, double[,] unpaddedMask)
        {
            Bitmap unpaddedLena = (Bitmap)unpaddedImage.Clone();

            int maxWidth = 0;
            int maxHeight = 0;

            //if (paddingType == PaddingType.Max)
            //{
            //    maxWidth = (int)Math.Max(unpaddedLena.Width, _sharpeningKernel.GetLength(0));
            //    maxHeight = (int)Math.Max(unpaddedLena.Height, _sharpeningKernel.GetLength(1));
            //}
            //else if (paddingType == PaddingType.Sum)
            //{
                maxWidth = (int)Tools.ToNextPow2(Convert.ToUInt32(unpaddedLena.Width + _sharpeningKernel.GetLength(0)));
                maxHeight = (int)Tools.ToNextPow2(Convert.ToUInt32(unpaddedLena.Height + _sharpeningKernel.GetLength(1)));
            //}

            Bitmap paddedImage = ImagePadder.Pad(unpaddedLena, maxWidth, maxHeight);

            double[,] paddedKernel = ImagePadder.Pad(unpaddedMask, maxWidth, maxHeight);

            Bitmap sharpened = FftConvolutionFilter(paddedImage, paddedKernel);

            //Cropping after convolution
            Bitmap cropped;

            //if (paddingType == PaddingType.Sum)
            //{
                int left = ((maxWidth - unpaddedLena.Width) / 2) - 3;
                int top = ((maxHeight - unpaddedLena.Height) / 2);
                Rectangle rect = new Rectangle(left, top, unpaddedLena.Width, unpaddedLena.Height);
                cropped = ImageCropper.Crop(sharpened, rect);

                //Alternative Way by SleuthEye
                //Rectangle rect = new Rectangle(((sharpened.Width / 2 - 3) / 2) - 1,
                //                                ((sharpened.Height / 2 - 3) / 2) + 2,
                //                                 sharpened.Width / 2,
                //                                 sharpened.Height / 2);
                //cropped = sharpened.Clone(rect, PixelFormat.Format8bppIndexed);
            //}
            //else
            //{
            //    cropped = sharpened;
            //}

            return cropped;
        }

        public static Bitmap FftPaddedConvolutionFilter(Bitmap unpaddedImage, Bitmap unpaddedMask)
        {
            return FftPaddedConvolutionFilter(unpaddedImage, ImageDataConverter.ToDouble(unpaddedMask));
        }

        public static Bitmap FftSharpen(Bitmap unpaddedImage)
        {
            return FftPaddedConvolutionFilter(unpaddedImage, _sharpeningKernel);
        }
    }
}
