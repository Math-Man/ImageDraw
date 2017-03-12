using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Collections;
using System.Drawing.Imaging;

namespace Image_Genetics
{
    public partial class DrawingForm : Form
    {
        public DrawingForm()
        {
            InitializeComponent();
        }

        //Access to controls
        public PictureBox getpbOriginal() { return pbOriginal; }
        public PictureBox getpbDr() { return pbDrawing; }
        public ProgressBar getCpyPB() { return pbCopy; }    
        public int cThreshold { get; set; }
        public int colorThreshold { get; set; }
        public int randomness { get; set; }


        Graphics pbGraphics;        //TODO: this is extremely hacky, fix this by creating a secondry map
        Graphics pbGraphicsDraw;    //
        Bitmap genericImage;
        private void DrawingForm_Load(object sender, EventArgs e)
        {
            genericImage = new Bitmap(pbDrawing.Width, pbDrawing.Height);   //Setup the generic image, this is what can be saved as a file.
            pbGraphicsDraw = pbDrawing.CreateGraphics();
            pbGraphics = Graphics.FromImage(genericImage);
        }

        private void drawPixel_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            bCopyTest.Enabled = false;
            Console.WriteLine(button1.Enabled);
            var watch = System.Diagnostics.Stopwatch.StartNew();   

            Color c = new Color();
            Pen aPen = new Pen(c);
            pbGraphics = pbDrawing.CreateGraphics();

            Task draw = Task.Run(() =>  //Create a thread to draw.
            {        

                for (int i = 0; i < pbDrawing.Height; i++)
                {
                    for (int j = 0; j < pbDrawing.Width; j++)
                    {

                        drawPixel(Color.FromArgb((2 * i * j) % 255, j % 255, (i * j) % 255), i, j);

                    }
                }

                Invoke((MethodInvoker)delegate  //Reanble buttons after job is done
                {
                    button1.Enabled = true;
                    bCopyTest.Enabled = true;
                });
            });

            watch.Stop();
            var elapsedTime = watch.Elapsed;
            Console.WriteLine("DONE Elapsed time: " + elapsedTime);

        }

        private void CheckColors_Click(object sender, EventArgs e)
        {

            Bitmap colorMap = new Bitmap(pbDrawing.Width, pbDrawing.Height, pbGraphics);   //Create bitmaps
            Bitmap colorMapSecondry = new Bitmap(pbDrawing.Width, pbDrawing.Height, pbGraphicsDraw);
            var watch = System.Diagnostics.Stopwatch.StartNew();                            //TODO: Remove stop watches

            for (int i = 0; i < colorMap.Width; i++)
            {
                for (int j = 0; j < colorMap.Height; j++)
                {
                    Console.WriteLine("Color: " + getPixel(colorMap, i, j) + "x: " + i + " y: " + j);
                }
            }

            watch.Stop();
            var elapsedTime = watch.Elapsed;
            Console.WriteLine("DONE Elapsed time: " + elapsedTime);

        }


        //draw a pixel.
        private void drawPixel(Color c, int x, int y)
        {
            Pen p = new Pen(c);

            pbGraphics.DrawRectangle(p, x, y, 1, 1);
            pbGraphicsDraw.DrawRectangle(p, x, y, 1, 1);
            p = null;

        }

        private Color getPixel(Bitmap bmp, int x, int y)    //returns the color of the pixel at x,y
        {
            return (bmp.GetPixel(x, y));
        }








        class Pixi  //Used in conjunction with trytodraw(), b boolean checks if this point was added or not, this is a struct in class's clothing
        {
            public Point point { get; set; }
            public Boolean isChanged { get; set; }
            public Pixi(Point p) { this.point = p; this.isChanged = false; }
        }



        //both params needs to be below 100 and above 0, its a percantage. Threshold defines how close the color should be to the original color
        private void tryToDraw(Bitmap cpyImage, double threshold, double changeChance)        //This method attempts to draw the base image, not a genetics algorithm just randomly gets values for colors. if the color is "close enough" skips that pixel next time.
        {

            Invoke((MethodInvoker)delegate  //Disable buttons when entering the method
            {
                button1.Enabled = false;
                bCopyTest.Enabled = false;
            });

            ArrayList pixelsToChange = new ArrayList();
            int changedPixels = 0;
            Random rnd = new Random();


            Bitmap cMap = cpyImage;

            for (int i = 0; i < cMap.Width; i++)    //Add all pixels to the list
            {
                for (int j = 0; j < cMap.Height; j++)
                {
                    Point p = new Point(i, j);
                    Pixi pi = new Pixi(p);
                    pixelsToChange.Add(pi);
                }
            }


            Invoke((MethodInvoker)delegate  //Create an invoker to access controls from inside a thread.
            {
                pbCopy.Maximum = (pixelsToChange.Count) - (pixelsToChange.Count * (100 - cThreshold) / 100); // Set the new maxiumum for the progress bar
            });


            //Pixels that needs changing = (pixelsToChange.Count) - (pixelsToChange.Count * (100 -cThreshold)/100)
            while (changedPixels <= (pixelsToChange.Count) - (pixelsToChange.Count * (100 - cThreshold) / 100))   //While changed pixels amount not equal to pixels that needs changing, 2nd part of the equation creates a threshold value which allows program to stop before completing the task
            {
                foreach (Pixi e in pixelsToChange)   //go through every pixel
                {

                    if (!e.isChanged)
                    {
                        if (rnd.Next(0, 100) <= changeChance) //if random chance is ok change it to some random color 
                        {
                            Color cReplace = Color.FromArgb((rnd.Next(255) + 255) % 255, (rnd.Next(255) + 255) % 255, (rnd.Next(255) + 255) % 255);
                            double cDiff = Math.Sqrt(Math.Pow((cReplace.R - getPixel(cMap, e.point.X, e.point.Y).R), 2) + Math.Pow((cReplace.G - getPixel(cMap, e.point.X, e.point.Y).G), 2) + Math.Pow((cReplace.B - getPixel(cMap, e.point.X, e.point.Y).B), 2)); //Distance between colors formula (percantage) Gonna use this alot
                            double cDiffPercant = 100 * cDiff / Math.Sqrt(3 * Math.Pow(255, 2));


                            if (cDiffPercant < threshold) //if the color is good enough add that Point to the other list and draws it!
                            {

                                drawPixel(cReplace, e.point.X, e.point.Y);
                                e.isChanged = true;

                                Invoke((MethodInvoker)delegate  //Create an invoker to access controls from inside a thread.
                                {
                                    pbCopy.Value = changedPixels;   //Updates the progress bar
                                    lbProgressB.Text = "Progress: " + pbCopy.Value + " / " + pbCopy.Maximum;    //Prints out the progress
                                });
                                changedPixels++;

                                if (changedPixels >= (pixelsToChange.Count) - (pixelsToChange.Count * (100 - cThreshold) / 100))//Safe-check to make sure program stops when required threshold is reached!
                                {
                                    Invoke((MethodInvoker)delegate  //Reanble buttons after job is done
                                    {
                                        lbProgressB.Text = "Progress: " + pbCopy.Value + " / " + pbCopy.Maximum + "   !Done!";
                                        button1.Enabled = true;
                                        bCopyTest.Enabled = true;
                                    });

                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void bCopyTest_Click(object sender, EventArgs e)
        {

            //load and resize the bitmap
            Image m = pbOriginal.Image;
            Bitmap bmp1 = (Bitmap)m;
            Bitmap bmp1R = new Bitmap(bmp1, new Size(pbDrawing.Width, pbDrawing.Height));    //Scale it
            Task draw = Task.Run(() => { tryToDraw(bmp1R, colorThreshold, randomness); });  //Threshold: anything below 25 will look good anything above 50 will look like a mish mash of colours, 8 or below is very high percision

        }

        private void bSaveDrawing_Click(object sender, EventArgs e) //Save image at any time
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                genericImage.Save(dialog.FileName + ".png", ImageFormat.Png);
                Console.WriteLine("Saved @: " + dialog.FileName + ".png");
            }
        }


    }

}
