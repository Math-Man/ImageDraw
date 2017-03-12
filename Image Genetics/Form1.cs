using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
    Goktug Kayacan (Math-Man)
    This is pretty much and experiment, not that useful but pretty fun to watch.
    Program attempts to draw the same image with given percision. 
    Details on the parameters can be viewed by hovering over the Controls.
    I am planning to adding a "genetic algorithm" on top of this later on, should be easy to do with the ground work done.

    Sorry about the spagetthi code, I had to build this thing under one and a half day becouse midterms...
     */
namespace Image_Genetics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Opens a file dialog to select an image (png file)
        Image original;
        private void bPickImage_Click(object sender, EventArgs e)
        {
            tbImageCompression.Value = 100;
            lbCompression.Text = "100%";
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Select Image";
            dlg.Filter = "png files (*png)|*png";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                //Compress the image by a percantage
                Image selectedImage = Image.FromFile(dlg.FileName);
                Size newSize = new Size(selectedImage.Width * (tbImageCompression.Value / 100), selectedImage.Height * (tbImageCompression.Value / 100));  
                selectedImage = (Image)(new Bitmap(selectedImage, newSize));

                pbImage.Image = selectedImage;
                lbPixelCount.Text = selectedImage.Width * selectedImage.Height + "pixels";
                original = pbImage.Image;
                foreach (Control c in this.Controls)
                {
                    c.Enabled = true;
                }
            }
        }

        //Change image size with scrolling
        private void tbImageCompression_Scroll(object sender, EventArgs e)
        {
            pbImage.Image = original;
            Image newImage = pbImage.Image;
            Size newSize = new Size((int)(newImage.Width * ((double)tbImageCompression.Value / 100)) + 10, (int)(newImage.Height * ((double)tbImageCompression.Value / 100)) + 10);  //Creats a new size with the given compression value
            Console.WriteLine("size: " + (tbImageCompression.Value) + "  " + (int)(newImage.Width * ((double)tbImageCompression.Value / 100)));
            newImage = (Image)(new Bitmap(newImage, newSize));
            pbImage.Image = newImage;

            lbCompression.Text = tbImageCompression.Value + "%";
            lbPixelCount.Text = pbImage.Image.Width * pbImage.Image.Height + "pixels";
            //Remove the old-new image (!) to prevent unccesary memory allocation
            newImage = null;
            GC.Collect();

        }

        //Starts the actual program
        private void bStart_Click(object sender, EventArgs e)
        {
            DrawingForm drawing = new DrawingForm();
            drawing.getpbOriginal().Image = this.pbImage.Image; //Copy the image to the other window's original image box

            //Send Required values and properties
            drawing.getpbDr().Width = (int)udWidth.Value;
            drawing.getpbDr().Height = (int)udHeight.Value;
            drawing.cThreshold = trackBar1.Value;   
            drawing.colorThreshold = tbColorThreshold.Value;
            drawing.randomness = 100 - tbRandomness.Value;
            foreach (Control c in drawing.Controls)
            {
                if (c.Name != "pbDrawing")//Change position of all controls except the drawing box.
                {
                    c.SetBounds(c.Bounds.X + (int)udWidth.Value - 500, c.Bounds.Y, c.Bounds.Width, c.Bounds.Height);
                }
            }
            //Set the window Bounds.
            if (udHeight.Value < 450)
            {
                drawing.SetBounds(drawing.Bounds.X, drawing.Bounds.Y, drawing.Bounds.Width + (int)udWidth.Value - 500, 450);    //Set a minimum size for the window
            }
            else
            {
                drawing.SetBounds(drawing.Bounds.X, drawing.Bounds.Y, drawing.Bounds.Width + (int)udWidth.Value - 500, drawing.Bounds.Height + (int)udHeight.Value - 500);
            }

          


            drawing.Show();


        }


        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lbThresholdC.Text = trackBar1.Value + "%";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AllocConsole(); //Enables console
        }
        [DllImport("kernel32.dll", SetLastError = true)]    //Load dll required to enable console
        [return: MarshalAs(UnmanagedType.Bool)]             //TODO: add option to disable console.
        static extern bool AllocConsole();

        private void tbColorThreshold_Scroll(object sender, EventArgs e)    //Update labels with the track bars
        {
            lbColorThreshold.Text = tbColorThreshold.Value + "%";
        }

        private void tbRandomness_Scroll(object sender, EventArgs e)
        {
            lbRandomness.Text = tbRandomness.Value + "%";
        }
    }
}
