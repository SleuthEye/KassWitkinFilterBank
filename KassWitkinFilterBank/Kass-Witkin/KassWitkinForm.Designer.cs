namespace CustomFilterBank_Test
{
    partial class KassWitkinForm
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
            this.convolveButton = new System.Windows.Forms.Button();
            this.padMaskButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.paddedMaskPictureBox = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.convolvedImagePictureBox = new System.Windows.Forms.PictureBox();
            this.loadInputImageButton = new System.Windows.Forms.Button();
            this.loadMaskButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maskPictureBox = new System.Windows.Forms.PictureBox();
            this.inputImagePictureBox = new System.Windows.Forms.PictureBox();
            this.saveConvolvedImageButton = new System.Windows.Forms.Button();
            this.inputImageResolutionTextBox = new System.Windows.Forms.TextBox();
            this.kassWitkinMaskTestBox = new System.Windows.Forms.TextBox();
            this.paddedKassWitkinMaskTextBox = new System.Windows.Forms.TextBox();
            this.convolvedImageTextBox = new System.Windows.Forms.TextBox();
            this.padImageButton = new System.Windows.Forms.Button();
            this.paddedInputImageResolutionTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.paddedImagePictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thresholdingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.paddedMaskPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.convolvedImagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maskPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputImagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddedImagePictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // convolveButton
            // 
            this.convolveButton.Location = new System.Drawing.Point(832, 302);
            this.convolveButton.Name = "convolveButton";
            this.convolveButton.Size = new System.Drawing.Size(94, 34);
            this.convolveButton.TabIndex = 51;
            this.convolveButton.Text = "Convolve";
            this.convolveButton.UseVisualStyleBackColor = true;
            this.convolveButton.Click += new System.EventHandler(this.convolveButton_Click);
            // 
            // padMaskButton
            // 
            this.padMaskButton.Location = new System.Drawing.Point(626, 302);
            this.padMaskButton.Name = "padMaskButton";
            this.padMaskButton.Size = new System.Drawing.Size(200, 34);
            this.padMaskButton.TabIndex = 50;
            this.padMaskButton.Text = "Pad";
            this.padMaskButton.UseVisualStyleBackColor = true;
            this.padMaskButton.Click += new System.EventHandler(this.padMaskButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(623, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Padded Mask";
            // 
            // paddedMaskPictureBox
            // 
            this.paddedMaskPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.paddedMaskPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.paddedMaskPictureBox.Location = new System.Drawing.Point(626, 66);
            this.paddedMaskPictureBox.Name = "paddedMaskPictureBox";
            this.paddedMaskPictureBox.Size = new System.Drawing.Size(200, 200);
            this.paddedMaskPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.paddedMaskPictureBox.TabIndex = 48;
            this.paddedMaskPictureBox.TabStop = false;
            this.paddedMaskPictureBox.DoubleClick += new System.EventHandler(this.pictureBox_DoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(829, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Convolved edge";
            // 
            // convolvedImagePictureBox
            // 
            this.convolvedImagePictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.convolvedImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.convolvedImagePictureBox.Location = new System.Drawing.Point(832, 66);
            this.convolvedImagePictureBox.Name = "convolvedImagePictureBox";
            this.convolvedImagePictureBox.Size = new System.Drawing.Size(200, 200);
            this.convolvedImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.convolvedImagePictureBox.TabIndex = 46;
            this.convolvedImagePictureBox.TabStop = false;
            this.convolvedImagePictureBox.DoubleClick += new System.EventHandler(this.pictureBox_DoubleClick);
            // 
            // loadInputImageButton
            // 
            this.loadInputImageButton.Location = new System.Drawing.Point(8, 302);
            this.loadInputImageButton.Name = "loadInputImageButton";
            this.loadInputImageButton.Size = new System.Drawing.Size(200, 34);
            this.loadInputImageButton.TabIndex = 45;
            this.loadInputImageButton.Text = "Load edge";
            this.loadInputImageButton.UseVisualStyleBackColor = true;
            this.loadInputImageButton.Click += new System.EventHandler(this.loadInputImageButton_Click);
            // 
            // loadMaskButton
            // 
            this.loadMaskButton.Location = new System.Drawing.Point(420, 302);
            this.loadMaskButton.Name = "loadMaskButton";
            this.loadMaskButton.Size = new System.Drawing.Size(200, 34);
            this.loadMaskButton.TabIndex = 44;
            this.loadMaskButton.Text = "Load Kass-Witkin mask";
            this.loadMaskButton.UseVisualStyleBackColor = true;
            this.loadMaskButton.Click += new System.EventHandler(this.loadMaskButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(417, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Kass-Witkin mask";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Selected edge";
            // 
            // maskPictureBox
            // 
            this.maskPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.maskPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.maskPictureBox.Location = new System.Drawing.Point(420, 66);
            this.maskPictureBox.Name = "maskPictureBox";
            this.maskPictureBox.Size = new System.Drawing.Size(200, 200);
            this.maskPictureBox.TabIndex = 41;
            this.maskPictureBox.TabStop = false;
            this.maskPictureBox.DoubleClick += new System.EventHandler(this.pictureBox_DoubleClick);
            // 
            // inputImagePictureBox
            // 
            this.inputImagePictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.inputImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.inputImagePictureBox.Location = new System.Drawing.Point(8, 66);
            this.inputImagePictureBox.Name = "inputImagePictureBox";
            this.inputImagePictureBox.Size = new System.Drawing.Size(200, 200);
            this.inputImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.inputImagePictureBox.TabIndex = 40;
            this.inputImagePictureBox.TabStop = false;
            this.inputImagePictureBox.DoubleClick += new System.EventHandler(this.pictureBox_DoubleClick);
            // 
            // saveConvolvedImageButton
            // 
            this.saveConvolvedImageButton.Location = new System.Drawing.Point(938, 302);
            this.saveConvolvedImageButton.Name = "saveConvolvedImageButton";
            this.saveConvolvedImageButton.Size = new System.Drawing.Size(94, 34);
            this.saveConvolvedImageButton.TabIndex = 52;
            this.saveConvolvedImageButton.Text = "Save";
            this.saveConvolvedImageButton.UseVisualStyleBackColor = true;
            this.saveConvolvedImageButton.Click += new System.EventHandler(this.saveConvolvedImageButton_Click);
            // 
            // inputImageResolutionTextBox
            // 
            this.inputImageResolutionTextBox.Location = new System.Drawing.Point(8, 272);
            this.inputImageResolutionTextBox.Name = "inputImageResolutionTextBox";
            this.inputImageResolutionTextBox.ReadOnly = true;
            this.inputImageResolutionTextBox.Size = new System.Drawing.Size(200, 20);
            this.inputImageResolutionTextBox.TabIndex = 53;
            // 
            // kassWitkinMaskTestBox
            // 
            this.kassWitkinMaskTestBox.Location = new System.Drawing.Point(420, 272);
            this.kassWitkinMaskTestBox.Name = "kassWitkinMaskTestBox";
            this.kassWitkinMaskTestBox.ReadOnly = true;
            this.kassWitkinMaskTestBox.Size = new System.Drawing.Size(200, 20);
            this.kassWitkinMaskTestBox.TabIndex = 54;
            // 
            // paddedKassWitkinMaskTextBox
            // 
            this.paddedKassWitkinMaskTextBox.Location = new System.Drawing.Point(626, 272);
            this.paddedKassWitkinMaskTextBox.Name = "paddedKassWitkinMaskTextBox";
            this.paddedKassWitkinMaskTextBox.ReadOnly = true;
            this.paddedKassWitkinMaskTextBox.Size = new System.Drawing.Size(200, 20);
            this.paddedKassWitkinMaskTextBox.TabIndex = 55;
            // 
            // convolvedImageTextBox
            // 
            this.convolvedImageTextBox.Location = new System.Drawing.Point(832, 272);
            this.convolvedImageTextBox.Name = "convolvedImageTextBox";
            this.convolvedImageTextBox.ReadOnly = true;
            this.convolvedImageTextBox.Size = new System.Drawing.Size(200, 20);
            this.convolvedImageTextBox.TabIndex = 56;
            // 
            // padImageButton
            // 
            this.padImageButton.Location = new System.Drawing.Point(214, 302);
            this.padImageButton.Name = "padImageButton";
            this.padImageButton.Size = new System.Drawing.Size(200, 34);
            this.padImageButton.TabIndex = 57;
            this.padImageButton.Text = "Pad";
            this.padImageButton.UseVisualStyleBackColor = true;
            this.padImageButton.Click += new System.EventHandler(this.padImageButton_Click);
            // 
            // paddedInputImageResolutionTextBox
            // 
            this.paddedInputImageResolutionTextBox.Location = new System.Drawing.Point(214, 272);
            this.paddedInputImageResolutionTextBox.Name = "paddedInputImageResolutionTextBox";
            this.paddedInputImageResolutionTextBox.ReadOnly = true;
            this.paddedInputImageResolutionTextBox.Size = new System.Drawing.Size(200, 20);
            this.paddedInputImageResolutionTextBox.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 59;
            this.label5.Text = "Padded Image";
            // 
            // paddedImagePictureBox
            // 
            this.paddedImagePictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.paddedImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.paddedImagePictureBox.Location = new System.Drawing.Point(214, 66);
            this.paddedImagePictureBox.Name = "paddedImagePictureBox";
            this.paddedImagePictureBox.Size = new System.Drawing.Size(200, 200);
            this.paddedImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.paddedImagePictureBox.TabIndex = 58;
            this.paddedImagePictureBox.TabStop = false;
            this.paddedImagePictureBox.DoubleClick += new System.EventHandler(this.pictureBox_DoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thresholdingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1041, 24);
            this.menuStrip1.TabIndex = 61;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thresholdingToolStripMenuItem
            // 
            this.thresholdingToolStripMenuItem.Name = "thresholdingToolStripMenuItem";
            this.thresholdingToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.thresholdingToolStripMenuItem.Text = "Thresholding";
            // 
            // KassWitkinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 351);
            this.Controls.Add(this.paddedInputImageResolutionTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.paddedImagePictureBox);
            this.Controls.Add(this.padImageButton);
            this.Controls.Add(this.convolvedImageTextBox);
            this.Controls.Add(this.paddedKassWitkinMaskTextBox);
            this.Controls.Add(this.kassWitkinMaskTestBox);
            this.Controls.Add(this.inputImageResolutionTextBox);
            this.Controls.Add(this.saveConvolvedImageButton);
            this.Controls.Add(this.convolveButton);
            this.Controls.Add(this.padMaskButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.paddedMaskPictureBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.convolvedImagePictureBox);
            this.Controls.Add(this.loadInputImageButton);
            this.Controls.Add(this.loadMaskButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maskPictureBox);
            this.Controls.Add(this.inputImagePictureBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "KassWitkinForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KassWitkinForm";
            ((System.ComponentModel.ISupportInitialize)(this.paddedMaskPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.convolvedImagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maskPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputImagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddedImagePictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button convolveButton;
        private System.Windows.Forms.Button padMaskButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox paddedMaskPictureBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox convolvedImagePictureBox;
        private System.Windows.Forms.Button loadInputImageButton;
        private System.Windows.Forms.Button loadMaskButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox maskPictureBox;
        private System.Windows.Forms.PictureBox inputImagePictureBox;
        private System.Windows.Forms.Button saveConvolvedImageButton;
        private System.Windows.Forms.TextBox inputImageResolutionTextBox;
        private System.Windows.Forms.TextBox kassWitkinMaskTestBox;
        private System.Windows.Forms.TextBox paddedKassWitkinMaskTextBox;
        private System.Windows.Forms.TextBox convolvedImageTextBox;
        private System.Windows.Forms.Button padImageButton;
        private System.Windows.Forms.TextBox paddedInputImageResolutionTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox paddedImagePictureBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thresholdingToolStripMenuItem;
    }
}