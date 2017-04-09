/*using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        System.Drawing.Bitmap image;
        System.Random random;
        int start_milliseconds;
        int stop_milliseconds;

        public Form1 ()
        {
            InitializeComponent ();
            image = new System.Drawing.Bitmap (100, 100);
            pictureBox1.Image = image;
            random = new System.Random ();
            start_milliseconds = 0;
            stop_milliseconds = 0;
        }

        private void button1_Click (object sender, EventArgs e)
        {
            start_milliseconds = 0;
            stop_milliseconds = 0;

            start_milliseconds = 1 * System.DateTime.Now.Millisecond;
            start_milliseconds += 1000 * System.DateTime.Now.Second;
            start_milliseconds += 60000 * System.DateTime.Now.Minute;
            start_milliseconds += 600000 * System.DateTime.Now.Hour; //eh... I'll stop at hour. Who will be using this
            //at exactly 24:00? That's what I thought too :)

            button1.Enabled = false;
            button3.Enabled = true;

            this.backgroundWorker1.RunWorkerAsync ();
        }

        private void process_image (BackgroundWorker worker, DoWorkEventArgs e)
        {
            int x_size;
            int y_size;

            int.TryParse (textBox2.Text, out x_size);
            int.TryParse (textBox3.Text, out y_size);
            image = new System.Drawing.Bitmap (x_size, y_size);
            pictureBox1.Image = image;
            System.Drawing.Color pixel_color = System.Drawing.Color.FromArgb (0, 0, 0);
            int[] pixel_intensity = new int[3];
            int super_samples = 1;
            int.TryParse (textBox8.Text, out super_samples);

            image.Dispose ();
            image = (Bitmap)outline_image (x_size, y_size);

            for (int y = 0; y < y_size; y++)
            {
                for (int x = 0; x < x_size; x++)
                {
                    if (this.backgroundWorker1.CancellationPending)
                    {
                        this.backgroundWorker1.CancelAsync ();

                        return;
                    }

                    pixel_intensity[0] = 0;
                    pixel_intensity[1] = 0;
                    pixel_intensity[2] = 0;

                    for (int n = 0; n < super_samples; n++)
                    {
                        pixel_intensity = add_color ((int)(x - 0.5 * x_size), (int)(y - 0.5 * y_size), pixel_intensity);
                    }

                    pixel_color = System.Drawing.Color.FromArgb ((int)((double)pixel_intensity[0] / (double)super_samples),
                                                                 (int)((double)pixel_intensity[1] / (double)super_samples),
                                                                 (int)((double)pixel_intensity[2] / (double)super_samples));

                    image.SetPixel (x, y, pixel_color);
                }

                pictureBox1.Image = image;

                worker.ReportProgress ((int)((double)y / (double)(y_size - 1) * 100));
            }
        }

        private object outline_image (int x_size, int y_size)
        {
            System.Drawing.Bitmap image = new System.Drawing.Bitmap (x_size, y_size);

            for (int i = 0; i < x_size; i++)
            {
                image.SetPixel (i, 0, System.Drawing.Color.FromArgb (255, 0, 0));
                image.SetPixel (i, y_size - 1, System.Drawing.Color.FromArgb (255, 0, 0));
            }

            for (int i = 0; i < y_size; i++)
            {
                image.SetPixel (0, i, System.Drawing.Color.FromArgb (255, 0, 0));
                image.SetPixel (x_size - 1, i, System.Drawing.Color.FromArgb (255, 0, 0));
            }

            return image;
        }

        private int[] add_color (int x, int y, int[] color)
        {
            double zoom = 0;
            double.TryParse (textBox1.Text, out zoom);
            double x_spot = 0;
            double y_spot = 0;
            double.TryParse (textBox6.Text, out x_spot);
            double.TryParse (textBox7.Text, out y_spot);
            double fcimg = y_spot + (y + (random.NextDouble () - 0.5)) * zoom;
            double fcreal = x_spot + (x + (random.NextDouble () - 0.5)) * zoom;
            double fzreal = fcreal;
            double fzimg = fcimg;

            int pixel_depth = 0;

            for (int i = 0; i < 255; i++)
            {
                double fzrealsquared = fzreal * fzreal;
                double fzimgsquared = fzimg * fzimg;

                if (fzrealsquared + fzimgsquared > 4)
                {
                    pixel_depth = i;
                    break;
                }

                fzimg = 2 * fzreal * fzimg + fcimg;
                fzreal = fzrealsquared - fzimgsquared + fcreal;
            }

            for (int i = 0; i < 3; i++)
            {
                color[i] += pixel_depth;
            }

            return color;
        }

        private void button2_Click (object sender, EventArgs e)
        {
            string path;
            path = textBox9.Text;

            image.Save (path);
        }

        private void backgroundWorker1_DoWork (object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bw = sender as BackgroundWorker;

            process_image ((System.ComponentModel.BackgroundWorker)sender, e);

            if (bw.CancellationPending)
            {
                e.Cancel = true;
            }
        }

        private void backgroundWorker1_RunWorkerCompleted (object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar1.Value = 0;

            stop_milliseconds = 1 * System.DateTime.Now.Millisecond;
            stop_milliseconds += 1000 * System.DateTime.Now.Second;
            stop_milliseconds += 60000 * System.DateTime.Now.Minute;
            stop_milliseconds += 600000 * System.DateTime.Now.Hour;

            label10.Text = (stop_milliseconds - start_milliseconds).ToString ();

            button3.Enabled = false;
            button1.Enabled = true;
        }

        private void button3_Click (object sender, EventArgs e)
        {
            this.backgroundWorker1.CancelAsync ();
        }

        private void backgroundWorker1_ProgressChanged (object sender, ProgressChangedEventArgs e)
        {
            this.progressBar1.Value = e.ProgressPercentage;

            stop_milliseconds = 1 * System.DateTime.Now.Millisecond;
            stop_milliseconds += 1000 * System.DateTime.Now.Second;
            stop_milliseconds += 60000 * System.DateTime.Now.Minute;
            stop_milliseconds += 600000 * System.DateTime.Now.Hour;

            label10.Text = (stop_milliseconds - start_milliseconds).ToString ();
        }
    }
}*/