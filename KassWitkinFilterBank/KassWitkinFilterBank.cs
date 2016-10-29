using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;

namespace CustomFilterBank_Test
{
    public class KassWitkinFilterBank
    {
        private List<KassWitkinKernel> Kernels;
        public int NoOfFilters { get; set; }
        public double FilterAngle { get; set; }
        public int WidthWithPadding { get; set; }
        public int HeightWithPadding { get; set; }
        public int KernelDimension { get; set; }

        public KassWitkinFilterBank()
        {}

        public List<Bitmap> Apply(Bitmap bitmap)
        {
            Kernels = new List<KassWitkinKernel>();

            // The generated template filter from the equations gives a line at 45 degrees. 
            // To get the filter to highlight lines starting with an angle of 90 degrees
            // we should start with an additional 45 degrees offset.
            double degrees = 45;

            KassWitkinKernel kernel;
            for (int i = 0; i < NoOfFilters; i++)
            {
                kernel = new KassWitkinKernel();
                kernel.Width = KernelDimension;
                kernel.Height = KernelDimension;
                kernel.CenterX = (kernel.Width) / 2;
                kernel.CenterY = (kernel.Height) / 2;
                kernel.Du = 2;
                kernel.Dv = 2;
                kernel.ThetaInRadian = Tools.DegreeToRadian(degrees);
                kernel.Compute();

                //SleuthEye
                kernel.Pad(kernel.Width, kernel.Height, WidthWithPadding, HeightWithPadding);
                
                Kernels.Add(kernel);

                // Now increment the angle by FilterAngle
                // (not "+= degrees" which doubles the value at each step)
                degrees += FilterAngle;
            }

            List<Bitmap> list = new List<Bitmap>();

            Bitmap image = (Bitmap)bitmap.Clone();

            Complex[,] cImagePadded = ImageDataConverter.ToComplex(image);
            FourierTransform ftForImage = new FourierTransform(cImagePadded); ftForImage.ForwardFFT();
            Complex[,] fftImage = ftForImage.FourierImageComplex;

            foreach (KassWitkinKernel k in Kernels)
            {
                Complex[,] cKernelPadded = k.ToComplexPadded();
                Complex[,] convolved = Convolution.ConvolveInFrequencyDomain(fftImage, cKernelPadded);

                Bitmap temp = ImageDataConverter.ToBitmap(convolved);
                list.Add(temp);
            }

            return list;
        }
    }
}
