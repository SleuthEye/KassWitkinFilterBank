using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;

namespace CustomFilterBank_Test
{
    public partial class ImageDataConverter
    {
        public static double[,] ToDouble(Bitmap input)
        {
            BitmapData bitmapData = input.LockBits(new Rectangle(0, 0, input.Width, input.Height),
                                                    ImageLockMode.ReadOnly,
                                                    PixelFormat.Format8bppIndexed);
            
            int width = input.Width;
            int height = input.Height;
            int pixelSize = Bitmap.GetPixelFormatSize(input.PixelFormat) / 8;
            int offset = bitmapData.Stride - bitmapData.Width * pixelSize;

            double[,] output = new double[width, height];

            double Min = 0.0;
            double Max = 255.0;

            try
            {
                unsafe
                {
                    fixed (double* ptrData = output)
                    {
                        double* dst = ptrData;

                        byte* src = (byte*)bitmapData.Scan0;

                        for (int y = 0; y < height; y++)
                        {
                            for (int x = 0; x < width; x++)
                            {
                                byte srscsc = (byte)(*src);

                                double scaled = Tools.Scale(srscsc, 0, 255, Min, Max);

                                *dst = scaled;

                                src += pixelSize;

                                dst++;
                            }

                            src += offset;
                        }
                    }
                }
            }
            finally
            {
                input.UnlockBits(bitmapData);
            }

            return output;
        }

        public static Bitmap ToBitmap(double[,] input)
        {
            int width = input.GetLength(0);
            int height = input.GetLength(1);

            Bitmap output = Grayscale.CreateGrayscaleImage(width, height);

            BitmapData data = output.LockBits(new Rectangle(0, 0, width, height),
                                                ImageLockMode.WriteOnly, 
                                                output.PixelFormat);

            int pixelSize = System.Drawing.Image.GetPixelFormatSize(PixelFormat.Format8bppIndexed) / 8;

            int offset = data.Stride - width * pixelSize;

            double Min = 0.0;
            double Max = 255.0;

            unsafe
            {
                byte* address = (byte*) data.Scan0.ToPointer();

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        double v = 255 * (input[x,y] - Min) / (Max - Min);

                        byte value = unchecked((byte)v);

                        for (int c = 0; c < pixelSize; c++, address++)
                        {
                            *address = value;
                        }
                    }

                    address += offset;
                }
            }

            output.UnlockBits(data);

            return output;
        }
    }
}
