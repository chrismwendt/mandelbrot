//usings (reduce the amount of code needed to be typed; so instead of "System.Console.Write", the code is "Console.Write")
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

//namespace (tells windows that variables inside of the braces {} are not windows' variables)
namespace mandelbrot_try_two
{
    //class (holds variables and methods)
    public partial class Form1 : Form
    {
        //declare variables (to be used later)
        int setting_image_width;
        int setting_image_height;
        double setting_zoom;
        double setting_position_x;
        double setting_position_y;
        int setting_sample_count;
        int setting_iteration_count;
        string output_file;
        int start_milliseconds;
        int stop_milliseconds;

        System.Windows.Forms.SaveFileDialog dialog_save_file;
        System.Drawing.Bitmap output_image;

        System.Random random;

        //constructor (a method that is called when the form is created)
        public Form1 ()
        {
            //gets the form ready to use
            InitializeComponent ();

            //initialize variables (make them something besides "null")
            setting_image_width = int.Parse (text_box_image_width.Text);
            setting_image_height = int.Parse (text_box_image_height.Text);
            setting_zoom = 0.025;
            setting_position_x = -0.5;
            setting_position_y = 0;
            setting_sample_count = int.Parse (text_box_samples.Text);
            setting_iteration_count = int.Parse (text_box_iterations.Text);
            output_file = text_box_output_path.Text;

            output_image = new System.Drawing.Bitmap (setting_image_width, setting_image_height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);

            dialog_save_file = new System.Windows.Forms.SaveFileDialog ();
            dialog_save_file.InitialDirectory = System.Environment.CurrentDirectory;
            dialog_save_file.AddExtension = true;
            dialog_save_file.Filter = ".png|*.png|.jpg|*.jpg|.bmp|*.bmp|.gif|*.gif";

            stop_milliseconds = 0;
            start_milliseconds = 0;

            //allows random numbers to be generated
            random = new System.Random ();
        }

        //event handler (the code in the braces {} runs when the button gets clicked)
        private void button_process_Click (object sender, EventArgs e)
        {
            button_render.Enabled = false;

            start_milliseconds = set_milliseconds_now (start_milliseconds);

            //calls "render" and overwrites the image
            output_image = render (output_image);

            stop_milliseconds = set_milliseconds_now (stop_milliseconds);

            //set the image to display in the picture box
            pictureBox1.Image = output_image;

            label_time.Text = (((double)stop_milliseconds - (double)start_milliseconds) / 1000).ToString () + " seconds";

            button_render.Enabled = true;
        }

        //a method (code in the braces {} runs when "render ();" is called)
        private Bitmap render (Bitmap output_image) //inside of the parentheses () is what's called an "argument" or "parameter".
                                                    // It is passed into the method so that the method can use this variable.
        {
            double pixel_intensity;
            pixel_intensity = 0;

            //sets up the image to be written to manually
            System.Drawing.Imaging.BitmapData bitmap_data = output_image.LockBits (new System.Drawing.Rectangle (0, 0, output_image.Width, output_image.Height),
                                                                                   System.Drawing.Imaging.ImageLockMode.ReadWrite,
                                                                                   output_image.PixelFormat);

            //necessary variables for "System.Runtime.InteropServices.Marshal.Copy"
            IntPtr pointer;
            pointer = bitmap_data.Scan0;
            int bytes;
            bytes = 3 * output_image.Width * output_image.Height;
            byte[] image_data = new byte[bytes];
            int i = 0;

            //iterates through each row
            for (int y = 0; y < output_image.Height; y++)
            {
                //iterates through each column
                for (int x = 0; x < output_image.Width; x++)
                {
                    //"get_intensity" returns a variable from 0 to 1 that represents black to white
                    pixel_intensity = get_intensity (x, y, setting_sample_count);

                    //makes sure that index is not out of bounds
                    if (i + 3 < image_data.GetLength (0))
                    {
                        //iterates through each pixel component (red, green, blue)
                        for (int n = 0; n < 3; n++)
                        {
                            //"image_data[i + n]" is the individual byte that is being written to
                            image_data[i + n] = (byte)(255 * pixel_intensity); //turn "pixel_intensity" from a double to byte variable so it is compatible.
                        }
                    }

                    //move on to the next pixel
                    i += 3;
                }

                //padding for the alpha byte
                i += output_image.Width % 4;
            }

            //puts the bytes into the image
            System.Runtime.InteropServices.Marshal.Copy (image_data, 0, pointer, image_data.Length);

            output_image.UnlockBits (bitmap_data);

            //sends the rendered image back
            return output_image;
        }

        //"x", "y", and "setting_samples" are arguments that can be used within the method
        private double get_intensity (int x, int y, int setting_samples)
        {
            double intensity;
            intensity = 0;

            //this is for a higher quality image
            for (int i = 0; i < setting_samples; i++)
            {
                //average a sample into the intensity (more samples = better quality)
                intensity += add_sample ((int)(x - 0.5 * output_image.Width), (int)(y - 0.5 * output_image.Height), setting_iteration_count);
            }

            if (setting_samples != 0)
            {
                intensity = intensity / setting_samples;
            }
            else
            {
                intensity = 0;
            }

            return intensity;
        }

        //this method holds the actual algorithm to determine the intensity of a sample
        private double add_sample (int x, int y, int fractal_iterations)
        {
            double fcimg = setting_position_y + (y + (random.NextDouble () - 0.5)) * setting_zoom;
            double fcreal = setting_position_x + (x + (random.NextDouble () - 0.5)) * setting_zoom;
            double fzreal = fcreal;
            double fzimg = fcimg;

            int pixel_iterations = 0;

            for (int i = 0; i < fractal_iterations; i++)
            {
                double fzrealsquared = fzreal * fzreal;
                double fzimgsquared = fzimg * fzimg;

                if (fzrealsquared + fzimgsquared > 4)
                {
                    pixel_iterations = i;
                    break;
                }

                fzimg = 2 * fzreal * fzimg + fcimg;
                fzreal = fzrealsquared - fzimgsquared + fcreal;
            }

            if (fractal_iterations != 0)
            {
                return (double)pixel_iterations / (double)fractal_iterations;
            }
            else
            {
                return 0;
            }
        }

        //method
        private int set_milliseconds_now (int milliseconds)
        {
            milliseconds = 1 * System.DateTime.Now.Millisecond;
            milliseconds += 1000 * System.DateTime.Now.Second;
            milliseconds += 60000 * System.DateTime.Now.Minute;
            milliseconds += 3600000 * System.DateTime.Now.Hour;

            return milliseconds;
        }

        private void button_browse_Click (object sender, EventArgs e)
        {
            dialog_save_file.ShowDialog ();
            text_box_output_path.Text = dialog_save_file.FileName;
        }

        private void button_save_Click (object sender, EventArgs e)
        {
            output_image.Save (output_file);
        }

        //the rest of the methods update variables as the text boxes update
        private void text_box_image_width_TextChanged (object sender, EventArgs e)
        {
            if (text_box_image_width.Text != "")
            {
                setting_image_width = int.Parse (text_box_image_width.Text);
            }

            if (setting_image_width > 0)
            {
                output_image = new System.Drawing.Bitmap (setting_image_width, setting_image_height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            }
            else
            {
                output_image = new System.Drawing.Bitmap (1, setting_image_height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            }
        }

        private void text_box_image_height_TextChanged (object sender, EventArgs e)
        {
            if (text_box_image_height.Text != "")
            {
                setting_image_height = int.Parse (text_box_image_height.Text);
            }

            if (setting_image_height > 0)
            {
                output_image = new System.Drawing.Bitmap (setting_image_width, setting_image_height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            }
            else
            {
                output_image = new System.Drawing.Bitmap (setting_image_width, 1, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            }
        }

        private void text_box_samples_TextChanged (object sender, EventArgs e)
        {
            if (text_box_samples.Text != "")
            {
                setting_sample_count = int.Parse (text_box_samples.Text);
            }
        }

        private void text_box_output_path_TextChanged (object sender, EventArgs e)
        {
            output_file = text_box_output_path.Text;
        }

        private void text_box_iterations_TextChanged (object sender, EventArgs e)
        {
            if (text_box_iterations.Text != "")
            {
                setting_iteration_count = int.Parse (text_box_iterations.Text);
            }
        }

        private void button_zoom_in_Click (object sender, EventArgs e)
        {
            setting_zoom = setting_zoom / 2;

            button_process_Click (sender, e);
        }

        private void button_zoom_out_Click (object sender, EventArgs e)
        {
            setting_zoom = setting_zoom * 2;

            button_process_Click (sender, e);
        }

        //event handler (draw crosshair where mouse is pushed)
        private void pictureBox1_MouseDown (object sender, MouseEventArgs e)
        {
            if (e.Location.X < output_image.Width
             && e.Location.X > 0
             && e.Location.Y < output_image.Height
             && e.Location.Y > 0)
            {
                if (MouseButtons == MouseButtons.Left)
                {
                    setting_position_x = (e.Location.X - (double)output_image.Width / 2.0) * setting_zoom + setting_position_x;
                    setting_position_y = (e.Location.Y - (double)output_image.Height / 2.0) * setting_zoom + setting_position_y;
                }

                button_process_Click (sender, e);
            }
        }
    }
}