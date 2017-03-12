namespace Image_Genetics
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.bPickImage = new System.Windows.Forms.Button();
            this.bStart = new System.Windows.Forms.Button();
            this.tbImageCompression = new System.Windows.Forms.TrackBar();
            this.lbIMGCompInfo = new System.Windows.Forms.Label();
            this.lbCompression = new System.Windows.Forms.Label();
            this.lbPixelCount = new System.Windows.Forms.Label();
            this.lbPixelCountInfo = new System.Windows.Forms.Label();
            this.lbWidth = new System.Windows.Forms.Label();
            this.lbHeight = new System.Windows.Forms.Label();
            this.udWidth = new System.Windows.Forms.NumericUpDown();
            this.udHeight = new System.Windows.Forms.NumericUpDown();
            this.lbcompletion = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lbThresholdC = new System.Windows.Forms.Label();
            this.tbColorThreshold = new System.Windows.Forms.TrackBar();
            this.tbRandomness = new System.Windows.Forms.TrackBar();
            this.lbColorThreshold = new System.Windows.Forms.Label();
            this.lbRandomness = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbImageCompression)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbColorThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRandomness)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImage
            // 
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Location = new System.Drawing.Point(13, 12);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(359, 303);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // bPickImage
            // 
            this.bPickImage.Location = new System.Drawing.Point(127, 321);
            this.bPickImage.Name = "bPickImage";
            this.bPickImage.Size = new System.Drawing.Size(109, 23);
            this.bPickImage.TabIndex = 1;
            this.bPickImage.Text = "Select Image";
            this.toolTip1.SetToolTip(this.bPickImage, "Select Image from file");
            this.bPickImage.UseVisualStyleBackColor = true;
            this.bPickImage.Click += new System.EventHandler(this.bPickImage_Click);
            // 
            // bStart
            // 
            this.bStart.Enabled = false;
            this.bStart.Location = new System.Drawing.Point(127, 618);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(109, 56);
            this.bStart.TabIndex = 2;
            this.bStart.Text = "Start";
            this.toolTip1.SetToolTip(this.bStart, "Start with these settings");
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // tbImageCompression
            // 
            this.tbImageCompression.Enabled = false;
            this.tbImageCompression.Location = new System.Drawing.Point(88, 542);
            this.tbImageCompression.Maximum = 100;
            this.tbImageCompression.Minimum = 5;
            this.tbImageCompression.Name = "tbImageCompression";
            this.tbImageCompression.Size = new System.Drawing.Size(246, 45);
            this.tbImageCompression.TabIndex = 6;
            this.toolTip1.SetToolTip(this.tbImageCompression, "Change Image resolution");
            this.tbImageCompression.Value = 100;
            this.tbImageCompression.Scroll += new System.EventHandler(this.tbImageCompression_Scroll);
            // 
            // lbIMGCompInfo
            // 
            this.lbIMGCompInfo.AutoSize = true;
            this.lbIMGCompInfo.Location = new System.Drawing.Point(21, 542);
            this.lbIMGCompInfo.Name = "lbIMGCompInfo";
            this.lbIMGCompInfo.Size = new System.Drawing.Size(67, 13);
            this.lbIMGCompInfo.TabIndex = 7;
            this.lbIMGCompInfo.Text = "Compression";
            // 
            // lbCompression
            // 
            this.lbCompression.AutoSize = true;
            this.lbCompression.Location = new System.Drawing.Point(339, 542);
            this.lbCompression.Name = "lbCompression";
            this.lbCompression.Size = new System.Drawing.Size(33, 13);
            this.lbCompression.TabIndex = 8;
            this.lbCompression.Text = "100%";
            // 
            // lbPixelCount
            // 
            this.lbPixelCount.AutoSize = true;
            this.lbPixelCount.Location = new System.Drawing.Point(193, 590);
            this.lbPixelCount.Name = "lbPixelCount";
            this.lbPixelCount.Size = new System.Drawing.Size(42, 13);
            this.lbPixelCount.TabIndex = 9;
            this.lbPixelCount.Text = "0 pixels";
            this.toolTip1.SetToolTip(this.lbPixelCount, "Total amount of pixels in the image");
            // 
            // lbPixelCountInfo
            // 
            this.lbPixelCountInfo.AutoSize = true;
            this.lbPixelCountInfo.Location = new System.Drawing.Point(124, 590);
            this.lbPixelCountInfo.Name = "lbPixelCountInfo";
            this.lbPixelCountInfo.Size = new System.Drawing.Size(63, 13);
            this.lbPixelCountInfo.TabIndex = 10;
            this.lbPixelCountInfo.Text = "Pixel Count:";
            this.toolTip1.SetToolTip(this.lbPixelCountInfo, "Total amount of pixels in the image");
            // 
            // lbWidth
            // 
            this.lbWidth.AutoSize = true;
            this.lbWidth.Location = new System.Drawing.Point(16, 353);
            this.lbWidth.Name = "lbWidth";
            this.lbWidth.Size = new System.Drawing.Size(77, 13);
            this.lbWidth.TabIndex = 13;
            this.lbWidth.Text = "Drawing Width";
            // 
            // lbHeight
            // 
            this.lbHeight.AutoSize = true;
            this.lbHeight.Location = new System.Drawing.Point(16, 379);
            this.lbHeight.Name = "lbHeight";
            this.lbHeight.Size = new System.Drawing.Size(80, 13);
            this.lbHeight.TabIndex = 14;
            this.lbHeight.Text = "Drawing Height";
            // 
            // udWidth
            // 
            this.udWidth.Enabled = false;
            this.udWidth.Location = new System.Drawing.Point(99, 353);
            this.udWidth.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.udWidth.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.udWidth.Name = "udWidth";
            this.udWidth.Size = new System.Drawing.Size(120, 20);
            this.udWidth.TabIndex = 15;
            this.toolTip1.SetToolTip(this.udWidth, "Width of the drawing box.");
            this.udWidth.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // udHeight
            // 
            this.udHeight.Enabled = false;
            this.udHeight.Location = new System.Drawing.Point(99, 379);
            this.udHeight.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.udHeight.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.udHeight.Name = "udHeight";
            this.udHeight.Size = new System.Drawing.Size(120, 20);
            this.udHeight.TabIndex = 16;
            this.toolTip1.SetToolTip(this.udHeight, "Height of the drawing box.");
            this.udHeight.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // lbcompletion
            // 
            this.lbcompletion.AutoSize = true;
            this.lbcompletion.Location = new System.Drawing.Point(23, 412);
            this.lbcompletion.Name = "lbcompletion";
            this.lbcompletion.Size = new System.Drawing.Size(65, 13);
            this.lbcompletion.TabIndex = 18;
            this.lbcompletion.Text = "% Threshold";
            // 
            // trackBar1
            // 
            this.trackBar1.Enabled = false;
            this.trackBar1.Location = new System.Drawing.Point(92, 405);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = 20;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(241, 45);
            this.trackBar1.TabIndex = 19;
            this.toolTip1.SetToolTip(this.trackBar1, "What percantage of the image should be completed before the program stops.\r\nLow t" +
        "hresholds will cause incomplete images.\r\nAnything above 90% can take a very long" +
        " time.\r\n");
            this.trackBar1.Value = 100;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // lbThresholdC
            // 
            this.lbThresholdC.AutoSize = true;
            this.lbThresholdC.Location = new System.Drawing.Point(339, 412);
            this.lbThresholdC.Name = "lbThresholdC";
            this.lbThresholdC.Size = new System.Drawing.Size(33, 13);
            this.lbThresholdC.TabIndex = 20;
            this.lbThresholdC.Text = "100%";
            // 
            // tbColorThreshold
            // 
            this.tbColorThreshold.Enabled = false;
            this.tbColorThreshold.Location = new System.Drawing.Point(92, 450);
            this.tbColorThreshold.Maximum = 100;
            this.tbColorThreshold.Minimum = 1;
            this.tbColorThreshold.Name = "tbColorThreshold";
            this.tbColorThreshold.Size = new System.Drawing.Size(241, 45);
            this.tbColorThreshold.TabIndex = 21;
            this.toolTip1.SetToolTip(this.tbColorThreshold, resources.GetString("tbColorThreshold.ToolTip"));
            this.tbColorThreshold.Value = 5;
            this.tbColorThreshold.Scroll += new System.EventHandler(this.tbColorThreshold_Scroll);
            // 
            // tbRandomness
            // 
            this.tbRandomness.Enabled = false;
            this.tbRandomness.Location = new System.Drawing.Point(92, 491);
            this.tbRandomness.Maximum = 90;
            this.tbRandomness.Name = "tbRandomness";
            this.tbRandomness.Size = new System.Drawing.Size(241, 45);
            this.tbRandomness.TabIndex = 22;
            this.toolTip1.SetToolTip(this.tbRandomness, "Percantage chance of skipping a pixel\r\nLower, faster and slightly less accurate");
            this.tbRandomness.Scroll += new System.EventHandler(this.tbRandomness_Scroll);
            // 
            // lbColorThreshold
            // 
            this.lbColorThreshold.AutoSize = true;
            this.lbColorThreshold.Location = new System.Drawing.Point(339, 450);
            this.lbColorThreshold.Name = "lbColorThreshold";
            this.lbColorThreshold.Size = new System.Drawing.Size(21, 13);
            this.lbColorThreshold.TabIndex = 23;
            this.lbColorThreshold.Text = "5%";
            // 
            // lbRandomness
            // 
            this.lbRandomness.AutoSize = true;
            this.lbRandomness.Location = new System.Drawing.Point(339, 501);
            this.lbRandomness.Name = "lbRandomness";
            this.lbRandomness.Size = new System.Drawing.Size(21, 13);
            this.lbRandomness.TabIndex = 24;
            this.lbRandomness.Text = "0%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 450);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Color Threshold";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 501);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Randomness";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 686);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbRandomness);
            this.Controls.Add(this.lbColorThreshold);
            this.Controls.Add(this.tbRandomness);
            this.Controls.Add(this.tbColorThreshold);
            this.Controls.Add(this.lbThresholdC);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.lbcompletion);
            this.Controls.Add(this.udHeight);
            this.Controls.Add(this.udWidth);
            this.Controls.Add(this.lbHeight);
            this.Controls.Add(this.lbWidth);
            this.Controls.Add(this.lbPixelCountInfo);
            this.Controls.Add(this.lbPixelCount);
            this.Controls.Add(this.lbCompression);
            this.Controls.Add(this.lbIMGCompInfo);
            this.Controls.Add(this.tbImageCompression);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.bPickImage);
            this.Controls.Add(this.pbImage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbImageCompression)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbColorThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRandomness)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button bPickImage;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.TrackBar tbImageCompression;
        private System.Windows.Forms.Label lbIMGCompInfo;
        private System.Windows.Forms.Label lbCompression;
        private System.Windows.Forms.Label lbPixelCount;
        private System.Windows.Forms.Label lbPixelCountInfo;
        private System.Windows.Forms.Label lbWidth;
        private System.Windows.Forms.Label lbHeight;
        private System.Windows.Forms.NumericUpDown udWidth;
        private System.Windows.Forms.NumericUpDown udHeight;
        private System.Windows.Forms.Label lbcompletion;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label lbThresholdC;
        private System.Windows.Forms.TrackBar tbColorThreshold;
        private System.Windows.Forms.TrackBar tbRandomness;
        private System.Windows.Forms.Label lbColorThreshold;
        private System.Windows.Forms.Label lbRandomness;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

