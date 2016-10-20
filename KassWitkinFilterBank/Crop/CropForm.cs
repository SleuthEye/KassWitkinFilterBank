using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CustomFilterBank_Test
{
    public partial class CropForm : Form
    {
        Bitmap _inputImage;

        public CropForm()
        {
            InitializeComponent();
        }

        string imagePath = @"E:\___MSc in Computer Systems & Network\EMSC1,2,3\lena.png";

        private void loadInputImageButton_Click(object sender, EventArgs e)
        {
            _inputImage = Grayscale.ToGrayscale( Bitmap.FromFile(imagePath) as Bitmap);

            inputImagePictureBox.Image = _inputImage as Image;
        }

        private void cropButton_Click(object sender, EventArgs e)
        {
            Bitmap cropped = ImageCropper.Crop(_inputImage, new Rectangle(-100, -100, 200, 150));

            croppedPictureBox.Image = cropped;
        }
    }
}
