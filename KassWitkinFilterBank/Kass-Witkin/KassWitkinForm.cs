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
    public partial class KassWitkinForm : Form
    {
        private KassWitkinKernel ___kernel = new KassWitkinKernel();

        public KassWitkinForm()
        {
            InitializeComponent();
        }

        private string path = @"E:\___MSc in CSN\EMSC1,2,3\scratch.png";
        
        private void loadInputImageButton_Click(object sender, EventArgs e)
        {
            Bitmap bInput = Grayscale.ToGrayscale(Bitmap.FromFile(path) as Bitmap);

            inputImagePictureBox.Image = bInput;

            inputImageResolutionTextBox.Text = "" + bInput.Width + " X " + bInput.Height;
        }

        private void loadMaskButton_Click(object sender, EventArgs e)
        {
            int kernelWidth = 32;
            int kernelHeight = 32;

            //Create a KassWitkin kernel.
            ___kernel.Width = kernelWidth;
            ___kernel.Height = kernelHeight;
            ___kernel.CenterX = ( ___kernel.Width) / 2;
            ___kernel.CenterY = ( ___kernel.Height) / 2;
            ___kernel.Du = 2;
            ___kernel.Dv = 2;
            ___kernel.ThetaInRadian = 0.9;//Tools.DegreeToRadian(0.9);
            ___kernel.Compute();

            Bitmap mask = ___kernel.ToBitmap();

            maskPictureBox.Image = mask as Image;

            kassWitkinMaskTestBox.Text = "" + mask.Width + " X " + mask.Height;
        }

        private void padImageButton_Click(object sender, EventArgs e)
        {
            Bitmap image = inputImagePictureBox.Image as Bitmap;

            int combinedWidth = (int)Tools.ToNextPow2(Convert.ToUInt32(image.Width));
            int combinedHeight = (int)Tools.ToNextPow2(Convert.ToUInt32(image.Height));

            Bitmap paddedImage = ImagePadder.Pad(image, combinedWidth, combinedHeight);

            paddedImagePictureBox.Image = paddedImage;

            paddedInputImageResolutionTextBox.Text = "" + paddedImage.Width + " X " + paddedImage.Height;
        }

        private void padMaskButton_Click(object sender, EventArgs e)
        {
            Bitmap image = paddedImagePictureBox.Image as Bitmap;

            int combinedWidth = (int)Tools.ToNextPow2(Convert.ToUInt32(image.Width));
            int combinedHeight = (int)Tools.ToNextPow2(Convert.ToUInt32(image.Height));

            //Sleuth eye
            ___kernel.Pad(image.Width, image.Height, combinedWidth, combinedHeight);

            paddedMaskPictureBox.Image = ___kernel.ToBitmapPadded();

            paddedKassWitkinMaskTextBox.Text = "" + paddedMaskPictureBox.Image.Width + " X " + paddedMaskPictureBox.Image.Height;
        }

        private void convolveButton_Click(object sender, EventArgs e)
        {
            KassWitkinBandpassFilter filter = new KassWitkinBandpassFilter();
            
            Bitmap filtered = filter.Apply((Bitmap)paddedImagePictureBox.Image, ___kernel);

            convolvedImagePictureBox.Image = filtered;
        }

        private void saveConvolvedImageButton_Click(object sender, EventArgs e)
        {
            string filName = @"lenaKWitkin.png";

            paddedImagePictureBox.Image.Save(filName, ImageFormat.Png);
            //convolvedImagePictureBox.Image.Save(filName, ImageFormat.Png);
        }

        private void pictureBox_DoubleClick(object sender, EventArgs e)
        {
            PictureBox pBox = sender as PictureBox;

            PictureBoxForm pbf = new PictureBoxForm(pBox.Image as Bitmap);
            pbf.ShowDialog();
        }
    }
}
