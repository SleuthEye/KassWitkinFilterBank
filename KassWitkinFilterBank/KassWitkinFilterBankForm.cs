using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Windows.Forms;

namespace CustomFilterBank_Test
{
    public partial class KassWitkinFilterBankForm : Form
    {
        
        private string path = @"..\..\..\scratch.png";

        #region ctor
        public KassWitkinFilterBankForm()
        {
            InitializeComponent();
        }

        private void pictureBox_DoubleClick(object sender, EventArgs e)
        {
            PictureBox pBox = sender as PictureBox;

            PictureBoxForm pbf = new PictureBoxForm(pBox.Image as Bitmap);

            pbf.ShowDialog();
        }

        private void saveConvolvedImageButton_Click(object sender, EventArgs e)
        {
            //string filName = @"lenaKWitkin.png";

            //paddedImagePictureBox.Image.Save(filName, ImageFormat.Png);
            //convolvedImagePictureBox.Image.Save(filName, ImageFormat.Png);
        }
        #endregion

        Bitmap _inputImage;
        private void loadInputImageButton_Click(object sender, EventArgs e)
        {
            _inputImage = Grayscale.ToGrayscale(Bitmap.FromFile(path) as Bitmap);

            inputImagePictureBox.Image = _inputImage;

            inputImageResolutionTextBox.Text = "" + _inputImage.Width + " X " + _inputImage.Height;
        }

        private void convolveButton_Click(object sender, EventArgs e)
        {
            KassWitkinFilterBank _bank = new KassWitkinFilterBank();
            _bank.FilterAngle = 15;
            _bank.NoOfFilters = 12;
            _bank.KernelDimension = 32;
            _bank.WidthWithPadding = (int)Tools.ToNextPow2((uint)(_bank.KernelDimension + _inputImage.Width));
            _bank.HeightWithPadding = (int)Tools.ToNextPow2((uint)(_bank.KernelDimension + _inputImage.Height));

            Bitmap tempBmp = Grayscale.ToGrayscale(Bitmap.FromFile(path) as Bitmap);
            Bitmap meanFilteredImage = Filters.FftMean(tempBmp);
            double[,] meanFilteredImageDouble = ImageDataConverter.ToDouble(ImageDataConverter.ToComplex(ImageDataConverter.ToInteger(meanFilteredImage)));
            double[,] tempImageDouble = ImageDataConverter.ToDouble(ImageDataConverter.ToComplex(ImageDataConverter.ToInteger(tempBmp)));
            for (int i = 0; i < tempImageDouble.GetLength(0); i++)
            {
                for (int j = 0; j < tempImageDouble.GetLength(1); j++)
                {
                    tempImageDouble[i, j] -= meanFilteredImageDouble[i, j];
                }
            }

            double[,] _paddedImage = ImagePadder.Pad(tempImageDouble, _bank.WidthWithPadding, _bank.HeightWithPadding);

            List<Bitmap> filtered = _bank.Apply(_paddedImage);

            pictureBox1.Image = filtered[0];
            pictureBox2.Image = filtered[1];
            pictureBox3.Image = filtered[2];
            pictureBox4.Image = filtered[3];
            pictureBox5.Image = filtered[4];
            pictureBox6.Image = filtered[5];
            pictureBox7.Image = filtered[6];
            pictureBox8.Image = filtered[7];
            pictureBox9.Image = filtered[8];
            pictureBox10.Image = filtered[9];
            pictureBox11.Image = filtered[10];
            pictureBox12.Image = filtered[11];
        }
    }
}
