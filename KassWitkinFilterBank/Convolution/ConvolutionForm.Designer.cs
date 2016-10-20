namespace CustomFilterBank_Test
{
    partial class ConvolutionForm
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
            this.loadMaskButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maskPictureBox = new System.Windows.Forms.PictureBox();
            this.inputImagePictureBox = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.convolvedImagePictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.paddedMaskPictureBox = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kassWitkinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.maskPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputImagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.convolvedImagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddedMaskPictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadInputImageButton
            // 
            this.loadInputImageButton.Location = new System.Drawing.Point(12, 311);
            this.loadInputImageButton.Name = "loadInputImageButton";
            this.loadInputImageButton.Size = new System.Drawing.Size(256, 34);
            this.loadInputImageButton.TabIndex = 33;
            this.loadInputImageButton.Text = "Load edge edge";
            this.loadInputImageButton.UseVisualStyleBackColor = true;
            this.loadInputImageButton.Click += new System.EventHandler(this.loadInputImageButton_Click);
            // 
            // loadMaskButton
            // 
            this.loadMaskButton.Location = new System.Drawing.Point(274, 311);
            this.loadMaskButton.Name = "loadMaskButton";
            this.loadMaskButton.Size = new System.Drawing.Size(256, 34);
            this.loadMaskButton.TabIndex = 32;
            this.loadMaskButton.Text = "Load Mask";
            this.loadMaskButton.UseVisualStyleBackColor = true;
            this.loadMaskButton.Click += new System.EventHandler(this.loadMaskButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Mask";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Selected edge";
            // 
            // maskPictureBox
            // 
            this.maskPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.maskPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.maskPictureBox.Location = new System.Drawing.Point(274, 49);
            this.maskPictureBox.Name = "maskPictureBox";
            this.maskPictureBox.Size = new System.Drawing.Size(256, 256);
            this.maskPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maskPictureBox.TabIndex = 29;
            this.maskPictureBox.TabStop = false;
            // 
            // inputImagePictureBox
            // 
            this.inputImagePictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.inputImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.inputImagePictureBox.Location = new System.Drawing.Point(12, 49);
            this.inputImagePictureBox.Name = "inputImagePictureBox";
            this.inputImagePictureBox.Size = new System.Drawing.Size(256, 256);
            this.inputImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.inputImagePictureBox.TabIndex = 28;
            this.inputImagePictureBox.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(795, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Convolved edge";
            // 
            // convolvedImagePictureBox
            // 
            this.convolvedImagePictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.convolvedImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.convolvedImagePictureBox.Location = new System.Drawing.Point(798, 49);
            this.convolvedImagePictureBox.Name = "convolvedImagePictureBox";
            this.convolvedImagePictureBox.Size = new System.Drawing.Size(256, 256);
            this.convolvedImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.convolvedImagePictureBox.TabIndex = 34;
            this.convolvedImagePictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(536, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 34);
            this.button1.TabIndex = 38;
            this.button1.Text = "Pad";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.padButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(533, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Padded Mask";
            // 
            // paddedMaskPictureBox
            // 
            this.paddedMaskPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.paddedMaskPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.paddedMaskPictureBox.Location = new System.Drawing.Point(536, 49);
            this.paddedMaskPictureBox.Name = "paddedMaskPictureBox";
            this.paddedMaskPictureBox.Size = new System.Drawing.Size(256, 256);
            this.paddedMaskPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.paddedMaskPictureBox.TabIndex = 36;
            this.paddedMaskPictureBox.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(798, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(256, 34);
            this.button2.TabIndex = 39;
            this.button2.Text = "Convolve";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.convolveButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kassWitkinToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 24);
            this.menuStrip1.TabIndex = 40;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kassWitkinToolStripMenuItem
            // 
            this.kassWitkinToolStripMenuItem.Name = "kassWitkinToolStripMenuItem";
            this.kassWitkinToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.kassWitkinToolStripMenuItem.Text = "Kass-Witkin";
            this.kassWitkinToolStripMenuItem.Click += new System.EventHandler(this.kassWitkinToolStripMenuItem_Click);
            // 
            // ConvolutionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 360);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
            this.Name = "ConvolutionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConvolutionForm";
            ((System.ComponentModel.ISupportInitialize)(this.maskPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputImagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.convolvedImagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddedMaskPictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadInputImageButton;
        private System.Windows.Forms.Button loadMaskButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox maskPictureBox;
        private System.Windows.Forms.PictureBox inputImagePictureBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox convolvedImagePictureBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox paddedMaskPictureBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kassWitkinToolStripMenuItem;
    }
}