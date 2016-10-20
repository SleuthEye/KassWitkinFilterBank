using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;

namespace CustomFilterBank_Test
{
    
    public class ImageCropper
    {
        public static Bitmap Crop(Bitmap image, Rectangle rect)
        {
            Bitmap bmp = image as Bitmap;

            // Check if it is a bitmap:
            if (bmp == null)
            {
                throw new ArgumentException("No valid bitmap");
            }

            // Crop the image:
            Bitmap cropBmp = bmp.Clone(rect, bmp.PixelFormat);

            // Release the resources:
            image.Dispose();

            return cropBmp;
        }
    }
	
}