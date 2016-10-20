using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CustomFilterBank_Test
{
    public class KassWitkinKernel
    {
        public readonly int N = 4;
        public int Width { get; set; }
        public int Height { get; set; }
        public double[,] Kernel { get; private set; }
        public double[,] PaddedKernel { get; private set; }
        public double Du { get; set; }
        public double Dv { get; set; }
        public int CenterX { get; set; }
        public int CenterY { get; set; }
        public double ThetaInRadian { get; set; }

        //SleuthEye
        private Complex[,] cPaddedKernel;

        public void SetKernel(double[,] value)
        {
            Kernel = value;
            Width = Kernel.GetLength(0);
            Height = Kernel.GetLength(1);
        }
        
        #region SleuthEye

        /*
        public void Pad(int newWidth, int newHeight)
        {
            double[,] temp = (double[,])Kernel.Clone();
            PaddedKernel = ImagePadder.Pad(temp, newWidth, newHeight);
        }*/

        public void Pad(int unpaddedWidth, int unpaddedHeight, int newWidth, int newHeight)
        {
            cPaddedKernel = new Complex[newWidth, newHeight]; 

            //32x32
            Complex[,] unpaddedKernelFrequencyDomain = ImageDataConverter.ToComplex((double[,])Kernel.Clone());

            FourierTransform ftInverse = new FourierTransform();

            ftInverse.InverseFFT(FourierShifter.RemoveFFTShift(unpaddedKernelFrequencyDomain));

            //32x32
            Complex[,] unpaddedKernelTimeDomain = FourierShifter.FFTShift(ftInverse.GrayscaleImageComplex);

            int startPointX = (int)Math.Ceiling((double)(newWidth - unpaddedWidth) / (double)2) - 1;
            int startPointY = (int)Math.Ceiling((double)(newHeight - unpaddedHeight) / (double)2) - 1;

            for(int j=startPointY ; j<startPointY+unpaddedHeight ; j++)
            {
                for (int i = startPointX ; i < startPointX+unpaddedWidth ; i++)
                {
                    cPaddedKernel[i, j] = unpaddedKernelTimeDomain[i-startPointX, j-startPointY];
                }
            }

            /*
            for (int j = 0; j < newHeight; j++)
            {
                for (int i = 0; i < startPointX; i++)
                {
                    unpaddedKernelTimeDomain[i, j] = 0;
                }
                for (int i = startPointX + unpaddedWidth; i < newWidth; i++)
                {
                    unpaddedKernelTimeDomain[i, j] = 0;
                }
            }

            for (int i = startPointX; i < startPointX + unpaddedWidth; i++)
            {
                for (int j = 0; j < startPointY; j++)
                {
                    unpaddedKernelTimeDomain[i, j] = 0;
                }
                for (int j = startPointY + unpaddedHeight; j < newHeight; j++)
                {
                    unpaddedKernelTimeDomain[i, j] = 0;
                }
            }
             **/

            FourierTransform ftForward = new FourierTransform(cPaddedKernel); ftForward.ForwardFFT();

            //cPaddedKernel = ftForward.FourierImageComplex;
        }

        public Complex[,] ToComplexPadded()
        {
            return cPaddedKernel;
        }

        //public Complex[,] ToComplexPadded()
        //{
        //    return ImageDataConverter.ToComplex(PaddedKernel);
        //}
        #endregion

        public Bitmap ToBitmap()
        {
            return ImageDataConverter.ToBitmap(Kernel);
        }

        public Bitmap ToBitmapPadded()
        {
            return ImageDataConverter.ToBitmap(PaddedKernel);
        }

        public Complex[,] ToComplex()
        {
            return ImageDataConverter.ToComplex(Kernel);
        }

        public void Compute()
        {
            Kernel = new double[Width, Height];

            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    Kernel[i, j] = (double)KassWitkinFunction.ApplyFilterOnOneCoord(i, j,
                                                                                Du,
                                                                                Dv,
                                                                                CenterX,
                                                                                CenterY,
                                                                                ThetaInRadian,
                                                                                N);

                    //Data[i, j] = r.NextDouble();
                }
            }

            string str = string.Empty;
        }
    }
}
