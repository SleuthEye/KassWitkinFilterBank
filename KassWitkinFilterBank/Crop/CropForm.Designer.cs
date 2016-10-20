namespace CustomFilterBank_Test
{
    partial class CropForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loadInputImageButton = new System.Windows.Forms.Button();
            this.cropButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.croppedPictureBox = new System.Windows.Forms.PictureBox();
            this.inputImagePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.croppedPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // loadInputImageButton
            // 
            this.loadInputImageButton.Location = new System.Drawing.Point(14, 317);
            this.loadInputImageButton.Name = "loadInputImageButton";
            this.loadInputImageButton.Size = new System.Drawing.Size(256, 34);
            this.loadInputImageButton.TabIndex = 39;
            this.loadInputImageButton.Text = "Load Image";
            this.loadInputImageButton.UseVisualStyleBackColor = true;
            this.loadInputImageButton.Click += new System.EventHandler(this.loadInputImageButton_Click);
            // 
            // cropButton
            // 
            this.cropButton.Location = new System.Drawing.Point(276, 317);
            this.cropButton.Name = "cropButton";
            this.cropButton.Size = new System.Drawing.Size(256, 34);
            this.cropButton.TabIndex = 38;
            this.cropButton.Text = "ImageCropper";
            this.cropButton.UseVisualStyleBackColor = true;
            this.cropButton.Click += new System.EventHandler(this.cropButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Cropped Image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Selected Image";
            // 
            // croppedPictureBox
            // 
            this.croppedPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.croppedPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.croppedPictureBox.Location = new System.Drawing.Point(276, 55);
            this.croppedPictureBox.Name = "croppedPictureBox";
            this.croppedPictureBox.Size = new System.Drawing.Size(256, 256);
            this.croppedPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.croppedPictureBox.TabIndex = 35;
            this.croppedPictureBox.TabStop = false;
            // 
            // inputImagePictureBox
            // 
            this.inputImagePictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.inputImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.inputImagePictureBox.Location = new System.Drawing.Point(14, 55);
            this.inputImagePictureBox.Name = "inputImagePictureBox";
            this.inputImagePictureBox.Size = new System.Drawing.Size(256, 256);
            this.inputImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.inputImagePictureBox.TabIndex = 34;
            this.inputImagePictureBox.TabStop = false;
            // 
            // CropForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 368);
            this.Controls.Add(this.loadInputImageButton);
            this.Controls.Add(this.cropButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.croppedPictureBox);
            this.Controls.Add(this.inputImagePictureBox);
            this.Name = "CropForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CropForm";
            ((System.ComponentModel.ISupportInitialize)(this.croppedPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputImagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadInputImageButton;
        private System.Windows.Forms.Button cropButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox croppedPictureBox;
        private System.Windows.Forms.PictureBox inputImagePictureBox;
    }
}