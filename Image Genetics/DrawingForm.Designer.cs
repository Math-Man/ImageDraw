namespace Image_Genetics
{
    partial class DrawingForm
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
            this.pbDrawing = new System.Windows.Forms.PictureBox();
            this.pbOriginal = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bCopyTest = new System.Windows.Forms.Button();
            this.pbCopy = new System.Windows.Forms.ProgressBar();
            this.lbProgressB = new System.Windows.Forms.Label();
            this.bSaveDrawing = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbDrawing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginal)).BeginInit();
            this.SuspendLayout();
            // 
            // pbDrawing
            // 
            this.pbDrawing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDrawing.Location = new System.Drawing.Point(12, 12);
            this.pbDrawing.Name = "pbDrawing";
            this.pbDrawing.Size = new System.Drawing.Size(500, 500);
            this.pbDrawing.TabIndex = 0;
            this.pbDrawing.TabStop = false;
            // 
            // pbOriginal
            // 
            this.pbOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbOriginal.Location = new System.Drawing.Point(546, 12);
            this.pbOriginal.Name = "pbOriginal";
            this.pbOriginal.Size = new System.Drawing.Size(255, 255);
            this.pbOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOriginal.TabIndex = 1;
            this.pbOriginal.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(630, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Test Draw";
            this.toolTip1.SetToolTip(this.button1, "Draw Test Image");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.drawPixel_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(723, 273);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Test Read";
            this.toolTip1.SetToolTip(this.button2, "Read Pixels of the original image and print to console");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.CheckColors_Click);
            // 
            // bCopyTest
            // 
            this.bCopyTest.Location = new System.Drawing.Point(537, 273);
            this.bCopyTest.Name = "bCopyTest";
            this.bCopyTest.Size = new System.Drawing.Size(87, 23);
            this.bCopyTest.TabIndex = 4;
            this.bCopyTest.Text = "Draw!";
            this.toolTip1.SetToolTip(this.bCopyTest, "Attempt to draw original image.");
            this.bCopyTest.UseVisualStyleBackColor = true;
            this.bCopyTest.Click += new System.EventHandler(this.bCopyTest_Click);
            // 
            // pbCopy
            // 
            this.pbCopy.Location = new System.Drawing.Point(537, 319);
            this.pbCopy.Name = "pbCopy";
            this.pbCopy.Size = new System.Drawing.Size(264, 23);
            this.pbCopy.TabIndex = 5;
            // 
            // lbProgressB
            // 
            this.lbProgressB.AutoSize = true;
            this.lbProgressB.Location = new System.Drawing.Point(543, 303);
            this.lbProgressB.Name = "lbProgressB";
            this.lbProgressB.Size = new System.Drawing.Size(10, 13);
            this.lbProgressB.TabIndex = 6;
            this.lbProgressB.Text = " ";
            // 
            // bSaveDrawing
            // 
            this.bSaveDrawing.Location = new System.Drawing.Point(615, 348);
            this.bSaveDrawing.Name = "bSaveDrawing";
            this.bSaveDrawing.Size = new System.Drawing.Size(114, 28);
            this.bSaveDrawing.TabIndex = 7;
            this.bSaveDrawing.Text = "Save Image";
            this.toolTip1.SetToolTip(this.bSaveDrawing, "Save the current image that is drawn.\r\nCan be used at any time.\r\n");
            this.bSaveDrawing.UseVisualStyleBackColor = true;
            this.bSaveDrawing.Click += new System.EventHandler(this.bSaveDrawing_Click);
            // 
            // DrawingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 533);
            this.Controls.Add(this.bSaveDrawing);
            this.Controls.Add(this.lbProgressB);
            this.Controls.Add(this.pbCopy);
            this.Controls.Add(this.bCopyTest);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbOriginal);
            this.Controls.Add(this.pbDrawing);
            this.Name = "DrawingForm";
            this.Text = "DrawingForm";
            this.Load += new System.EventHandler(this.DrawingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbDrawing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbDrawing;
        private System.Windows.Forms.PictureBox pbOriginal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bCopyTest;
        private System.Windows.Forms.ProgressBar pbCopy;
        private System.Windows.Forms.Label lbProgressB;
        private System.Windows.Forms.Button bSaveDrawing;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}