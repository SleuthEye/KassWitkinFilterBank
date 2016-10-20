using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CustomFilterBank_Test
{
    public class ImagePadder
    {
        public static Bitmap Pad(Bitmap image, int newWidth, int newHeight)
        {
            int width = image.Width;
            int height = image.Height;
            /*
             It is always guaranteed that,
                 
                    width < newWidth
                 
                        and
                  
                    height < newHeight                  
             */
            if ((width < newWidth && height < newHeight)
                    || (width<newWidth && height == newHeight)
                    || (width==newWidth && height < newHeight))
            {
                Bitmap paddedImage = Grayscale.CreateGrayscaleImage(newWidth, newHeight);

                BitmapLocker inputImageLocker = new BitmapLocker(image);
                BitmapLocker paddedImageLocker = new BitmapLocker(paddedImage);

                inputImageLocker.Lock();
                paddedImageLocker.Lock();

                int startPointX = (int)Math.Ceiling((double)(newWidth - width) / (double)2) - 1;
                int startPointY = (int)Math.Ceiling((double)(newHeight - height) / (double)2) - 1;

                for (int y = startPointY; y < (startPointY + height) ; y++)
                {
                    for (int x = startPointX; x < (startPointX + width) ; x++)
                    {
                        int xxx = x - startPointX;
                        int yyy = y - startPointY;

                        paddedImageLocker.SetPixel(x, y, inputImageLocker.GetPixel(xxx, yyy));
                        
                        

                        string str = string.Empty;
                    }
                }

                paddedImageLocker.Unlock();
                inputImageLocker.Unlock();

                return paddedImage;
            }
            else if (width == newWidth && height == newHeight)
            {
                return image;
            }
            else
            {
                throw new Exception("Pad() -- threw an exception");
            }
        }

        public static double[,] Pad(double[,] image, int newWidth, int newHeight)
        {
            int width = image.GetLength(0);
            int height = image.GetLength(1);
            /*
             It is always guaranteed that,
                 
                    width < newWidth
                 
                        and
                  
                    height < newHeight                  
             */
            if ((width < newWidth && height < newHeight)
                    || (width < newWidth && height == newHeight)
                    || (width == newWidth && height < newHeight))
            {
                double[,] resizedImage = new double[newWidth, newHeight];

                double color = 0.0;

                Grayscale.Fill(resizedImage, color);

                int startPointX = ((newWidth - width) / 2)-1;
                int startPointY = ((newHeight - height) / 2)-1;

                for (int y = startPointY; y < startPointY + height; y++)
                {
                    for (int x = startPointX; x < startPointX + width; x++)
                    {
                        int xxx = x - startPointX;
                        int yyy = y - startPointY;
                        resizedImage[x, y] = image[xxx, yyy];
                    }
                }

                return resizedImage;
            }
            else if (width == newWidth && height == newHeight)
            {
                return image;
            }
            else
            {
                throw new Exception("Pad() -- threw an exception");
            }
        } 

        //public static int[,] Pad(int[,] image, int newWidth, int newHeight)
        //{
        //    int width = image.GetLength(0);
        //    int height = image.GetLength(1);

        //    if ((width == height) && (width < newWidth && height < newHeight))
        //    {
        //        int[,] resizedImage = new int[width, height];

        //        int padValue = Color.Black.ToArgb();

        //        for (int j = 0; j < height; j++)
        //        {
        //            for (int i = 0; i < width; i++)
        //            {
        //                resizedImage[j,i] = padValue;
        //            }
        //        }

        //        if (newWidth != width || newHeight != height)
        //        {
        //            int startPointX = (newWidth - width) / 2;
        //            int startPointY = (newHeight - height) / 2;

        //            for (int y = startPointY; y < startPointY + height; y++)
        //            {
        //                for (int x = startPointX; x < startPointX + width; x++)
        //                {
        //                    int temp = image[y - startPointY, x - startPointX];
        //                    resizedImage[y, x] = temp;
        //                }
        //            }

        //            string str = string.Empty;
        //        }
        //        else
        //        {
        //            for (int j = 0; j < height; j++)
        //            {
        //                for (int i = 0; i < width; i++)
        //                {
        //                    resizedImage[j,i] = image[j,i];
        //                }
        //            }
        //        }

        //        return resizedImage;
        //    }
        //    else
        //    {
        //        throw new Exception("Pad() - threw an exception!");
        //    }
        //}

        #region public static Complex[,] Pad(Complex[,] image, int newMaskWidth, int newMaskHeight, int value)
        /// <summary>
        /// Pad an image to make it bigger in dimensions.
        /// </summary>
        /// <param name="image">image to be padded</param>
        /// <param name="newMaskWidth">width to be attained</param>
        /// <param name="newMaskHeight">height to be attained</param>
        /// <param name="value">the value to be used as a pad</param>
        /// <returns></returns>
        //public static Complex[,] Pad(Complex[,] image, int newMaskWidth, int newMaskHeight, int value)
        //{
        //    int width = image.GetLength(0);
        //    int height = image.GetLength(1);

        //    if ((width == height) && (width < newMaskWidth && height < newMaskHeight))
        //    {
        //        Complex[,] newMask = new Complex[newMaskWidth, newMaskHeight];

        //        //Creating the padding mask
        //        for (int y = 0; y < newMaskHeight; y++)
        //        {
        //            for (int x = 0; x < newMaskWidth; x++)
        //            {
        //                newMask[y,x] = new Complex(value, value);
        //            }
        //        }

        //        if (newMaskWidth > width && newMaskHeight > height)
        //        {
        //            int startPointX = (newMaskWidth  - width)/ 2;
        //            int startPointY = (newMaskHeight - height)/ 2;

        //            for (int y = startPointY; y < startPointY + height; y++)
        //            {
        //                for (int x = startPointX; x < startPointX + width; x++)
        //                {
        //                    newMask[y,x] = new Complex(image[y - startPointY, x - startPointX].Real, image[y - startPointY, x - startPointX].Imaginary);
        //                }

        //                Console.WriteLine();
        //            }

        //            string str = string.Empty;
        //        }
        //        else
        //        {
        //            for (int y = 0; y < newMaskHeight; y++)
        //            {
        //                for (int x = 0; x < newMaskWidth; x++)
        //                {
        //                    newMask[y, x] = new Complex(image[y, x].Real, image[y, x].Imaginary);
        //                }
        //            }
        //        }

        //        return newMask;
        //    }
        //    else
        //    {
        //        throw new Exception("Pad() - threw an exception!");
        //    }
        //} 
        #endregion
    }
}
