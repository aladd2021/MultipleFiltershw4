
namespace HelloEmgu
{
    partial class Form1
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
            this.emguPictureBox = new System.Windows.Forms.PictureBox();
            this.hFilter = new System.Windows.Forms.PictureBox();
            this.hMax = new System.Windows.Forms.TrackBar();
            this.sFilter = new System.Windows.Forms.PictureBox();
            this.hMin = new System.Windows.Forms.TrackBar();
            this.sMax = new System.Windows.Forms.TrackBar();
            this.sMin = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.Hlbl = new System.Windows.Forms.Label();
            this.Slbl = new System.Windows.Forms.Label();
            this.VLbl = new System.Windows.Forms.Label();
            this.vMin = new System.Windows.Forms.TrackBar();
            this.vMax = new System.Windows.Forms.TrackBar();
            this.vFilter = new System.Windows.Forms.PictureBox();
            this.whiteImage = new System.Windows.Forms.PictureBox();
            this.BinaryLbl = new System.Windows.Forms.Label();
            this.redLbl = new System.Windows.Forms.Label();
            this.redImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.emguPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.whiteImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redImage)).BeginInit();
            this.SuspendLayout();
            // 
            // emguPictureBox
            // 
            this.emguPictureBox.Location = new System.Drawing.Point(12, 34);
            this.emguPictureBox.Name = "emguPictureBox";
            this.emguPictureBox.Size = new System.Drawing.Size(110, 126);
            this.emguPictureBox.TabIndex = 0;
            this.emguPictureBox.TabStop = false;
            // 
            // hFilter
            // 
            this.hFilter.Location = new System.Drawing.Point(153, 34);
            this.hFilter.Name = "hFilter";
            this.hFilter.Size = new System.Drawing.Size(110, 126);
            this.hFilter.TabIndex = 1;
            this.hFilter.TabStop = false;
            // 
            // hMax
            // 
            this.hMax.Location = new System.Drawing.Point(153, 176);
            this.hMax.Maximum = 255;
            this.hMax.Minimum = 1;
            this.hMax.Name = "hMax";
            this.hMax.Size = new System.Drawing.Size(110, 69);
            this.hMax.TabIndex = 2;
            this.hMax.Value = 1;
            this.hMax.Scroll += new System.EventHandler(this.hMax_Scroll);
            // 
            // sFilter
            // 
            this.sFilter.Location = new System.Drawing.Point(294, 34);
            this.sFilter.Name = "sFilter";
            this.sFilter.Size = new System.Drawing.Size(115, 126);
            this.sFilter.TabIndex = 8;
            this.sFilter.TabStop = false;
            // 
            // hMin
            // 
            this.hMin.Location = new System.Drawing.Point(153, 237);
            this.hMin.Maximum = 255;
            this.hMin.Minimum = 1;
            this.hMin.Name = "hMin";
            this.hMin.Size = new System.Drawing.Size(110, 69);
            this.hMin.TabIndex = 9;
            this.hMin.Value = 1;
            this.hMin.Scroll += new System.EventHandler(this.hMin_Scroll);
            // 
            // sMax
            // 
            this.sMax.Location = new System.Drawing.Point(294, 176);
            this.sMax.Maximum = 255;
            this.sMax.Minimum = 1;
            this.sMax.Name = "sMax";
            this.sMax.Size = new System.Drawing.Size(115, 69);
            this.sMax.TabIndex = 10;
            this.sMax.Value = 1;
            this.sMax.Scroll += new System.EventHandler(this.sMax_Scroll);
            // 
            // sMin
            // 
            this.sMin.Location = new System.Drawing.Point(294, 237);
            this.sMin.Maximum = 255;
            this.sMin.Minimum = 1;
            this.sMin.Name = "sMin";
            this.sMin.Size = new System.Drawing.Size(115, 69);
            this.sMin.TabIndex = 11;
            this.sMin.Value = 1;
            this.sMin.Scroll += new System.EventHandler(this.sMin_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Normal";
            // 
            // Hlbl
            // 
            this.Hlbl.AutoSize = true;
            this.Hlbl.Location = new System.Drawing.Point(153, 11);
            this.Hlbl.Name = "Hlbl";
            this.Hlbl.Size = new System.Drawing.Size(21, 20);
            this.Hlbl.TabIndex = 13;
            this.Hlbl.Text = "H";
            // 
            // Slbl
            // 
            this.Slbl.AutoSize = true;
            this.Slbl.Location = new System.Drawing.Point(294, 6);
            this.Slbl.Name = "Slbl";
            this.Slbl.Size = new System.Drawing.Size(20, 20);
            this.Slbl.TabIndex = 14;
            this.Slbl.Text = "S";
            // 
            // VLbl
            // 
            this.VLbl.AutoSize = true;
            this.VLbl.Location = new System.Drawing.Point(442, 6);
            this.VLbl.Name = "VLbl";
            this.VLbl.Size = new System.Drawing.Size(20, 20);
            this.VLbl.TabIndex = 18;
            this.VLbl.Text = "V";
            // 
            // vMin
            // 
            this.vMin.Location = new System.Drawing.Point(442, 237);
            this.vMin.Maximum = 255;
            this.vMin.Minimum = 1;
            this.vMin.Name = "vMin";
            this.vMin.Size = new System.Drawing.Size(115, 69);
            this.vMin.TabIndex = 17;
            this.vMin.Value = 1;
            this.vMin.Scroll += new System.EventHandler(this.vMin_Scroll);
            // 
            // vMax
            // 
            this.vMax.Location = new System.Drawing.Point(442, 176);
            this.vMax.Maximum = 255;
            this.vMax.Minimum = 1;
            this.vMax.Name = "vMax";
            this.vMax.Size = new System.Drawing.Size(115, 69);
            this.vMax.TabIndex = 16;
            this.vMax.Value = 1;
            this.vMax.Scroll += new System.EventHandler(this.vMax_Scroll);
            // 
            // vFilter
            // 
            this.vFilter.Location = new System.Drawing.Point(442, 34);
            this.vFilter.Name = "vFilter";
            this.vFilter.Size = new System.Drawing.Size(115, 126);
            this.vFilter.TabIndex = 15;
            this.vFilter.TabStop = false;
            // 
            // whiteImage
            // 
            this.whiteImage.Location = new System.Drawing.Point(585, 34);
            this.whiteImage.Name = "whiteImage";
            this.whiteImage.Size = new System.Drawing.Size(110, 126);
            this.whiteImage.TabIndex = 19;
            this.whiteImage.TabStop = false;
            // 
            // BinaryLbl
            // 
            this.BinaryLbl.AutoSize = true;
            this.BinaryLbl.Location = new System.Drawing.Point(581, 6);
            this.BinaryLbl.Name = "BinaryLbl";
            this.BinaryLbl.Size = new System.Drawing.Size(50, 20);
            this.BinaryLbl.TabIndex = 20;
            this.BinaryLbl.Text = "White";
            // 
            // redLbl
            // 
            this.redLbl.AutoSize = true;
            this.redLbl.Location = new System.Drawing.Point(581, 192);
            this.redLbl.Name = "redLbl";
            this.redLbl.Size = new System.Drawing.Size(39, 20);
            this.redLbl.TabIndex = 22;
            this.redLbl.Text = "Red";
            // 
            // redImage
            // 
            this.redImage.Location = new System.Drawing.Point(585, 220);
            this.redImage.Name = "redImage";
            this.redImage.Size = new System.Drawing.Size(110, 126);
            this.redImage.TabIndex = 21;
            this.redImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.redLbl);
            this.Controls.Add(this.redImage);
            this.Controls.Add(this.BinaryLbl);
            this.Controls.Add(this.whiteImage);
            this.Controls.Add(this.VLbl);
            this.Controls.Add(this.vMin);
            this.Controls.Add(this.vMax);
            this.Controls.Add(this.vFilter);
            this.Controls.Add(this.Slbl);
            this.Controls.Add(this.Hlbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sMin);
            this.Controls.Add(this.sMax);
            this.Controls.Add(this.hMin);
            this.Controls.Add(this.sFilter);
            this.Controls.Add(this.hMax);
            this.Controls.Add(this.hFilter);
            this.Controls.Add(this.emguPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.emguPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.whiteImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox emguPictureBox;
        private System.Windows.Forms.PictureBox hFilter;
        private System.Windows.Forms.TrackBar hMax;
        private System.Windows.Forms.PictureBox sFilter;
        private System.Windows.Forms.TrackBar hMin;
        private System.Windows.Forms.TrackBar sMax;
        private System.Windows.Forms.TrackBar sMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Hlbl;
        private System.Windows.Forms.Label Slbl;
        private System.Windows.Forms.Label VLbl;
        private System.Windows.Forms.TrackBar vMin;
        private System.Windows.Forms.TrackBar vMax;
        private System.Windows.Forms.PictureBox vFilter;
        private System.Windows.Forms.PictureBox whiteImage;
        private System.Windows.Forms.Label BinaryLbl;
        private System.Windows.Forms.Label redLbl;
        private System.Windows.Forms.PictureBox redImage;
    }
}

