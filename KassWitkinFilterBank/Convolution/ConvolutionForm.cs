using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Windows.Forms;

namespace CustomFilterBank_Test
{
    public partial class ConvolutionForm : Form
    {
        Bitmap _inputImage;
        Bitmap _maskImage;

        public ConvolutionForm()
        {
            InitializeComponent();
        }

        string imagePath = @"E:\___MSc in Computer Systems & Network\EMSC1,2,3\scratch.png";
        private void loadInputImageButton_Click(object sender, EventArgs e)
        {
            Bitmap lena = Bitmap.FromFile(imagePath) as Bitmap;

            _inputImage = lena;

            inputImagePictureBox.Image = lena as Image;
        }

        string maskPath = @"E:\___MSc in Computer Systems & Network\EMSC1,2,3\mask.png";
        private void loadMaskButton_Click(object sender, EventArgs e)
        {
            Bitmap mask = Bitmap.FromFile(maskPath) as Bitmap;

            _maskImage = mask;

            maskPictureBox.Image = mask as Image;
        }

        private void padButton_Click(object sender, EventArgs e)
        {
            Bitmap lena = Grayscale.ToGrayscale(_inputImage);
            Bitmap mask = Grayscale.ToGrayscale(_maskImage);

            ////We must add
            int maxWidth = (int)Tools.ToNextPow2( Convert.ToUInt32(lena.Width + mask.Width));
            int maxHeight = (int)Tools.ToNextPow2(Convert.ToUInt32(lena.Height + mask.Height));

            Bitmap paddedImage = ImagePadder.Pad(lena, maxWidth, maxHeight);
            Bitmap paddedMask = ImagePadder.Pad(mask, maxWidth, maxHeight);

            //new PictureBoxForm(paddedImage, paddedMask).ShowDialog();

            inputImagePictureBox.Image = paddedImage;
            paddedMaskPictureBox.Image = paddedMask;
        }

        private void convolveButton_Click(object sender, EventArgs e)
        {
            Bitmap paddedLena = inputImagePictureBox.Image as Bitmap;
            Bitmap paddedMask = paddedMaskPictureBox.Image as Bitmap;

            Complex[,] cLena = ImageDataConverter.ToComplex(paddedLena);
            Complex[,] cPaddedMask = ImageDataConverter.ToComplex(paddedMask);
            Complex[,] cConvolved = Convolution.Convolve(cLena, cPaddedMask);

            Bitmap convolved = ImageDataConverter.ToBitmap(cConvolved);

            convolvedImagePictureBox.Image = convolved;
        }

        private void kassWitkinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KassWitkinForm f = new KassWitkinForm();
            f.ShowDialog();
        }
    }
}
