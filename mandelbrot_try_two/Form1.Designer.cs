namespace mandelbrot_try_two
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
        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox ();
            this.label2 = new System.Windows.Forms.Label ();
            this.label1 = new System.Windows.Forms.Label ();
            this.label3 = new System.Windows.Forms.Label ();
            this.text_box_image_width = new System.Windows.Forms.TextBox ();
            this.text_box_image_height = new System.Windows.Forms.TextBox ();
            this.text_box_samples = new System.Windows.Forms.TextBox ();
            this.label7 = new System.Windows.Forms.Label ();
            this.button_render = new System.Windows.Forms.Button ();
            this.button_save = new System.Windows.Forms.Button ();
            this.button_browse = new System.Windows.Forms.Button ();
            this.text_box_output_path = new System.Windows.Forms.TextBox ();
            this.label8 = new System.Windows.Forms.Label ();
            this.label_time = new System.Windows.Forms.Label ();
            this.text_box_iterations = new System.Windows.Forms.TextBox ();
            this.label9 = new System.Windows.Forms.Label ();
            this.button_zoom_in = new System.Windows.Forms.Button ();
            this.button_zoom_out = new System.Windows.Forms.Button ();
            this.label4 = new System.Windows.Forms.Label ();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit ();
            this.SuspendLayout ();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point (12, 195);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size (472, 241);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler (this.pictureBox1_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font ("Enter Sansman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point (8, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size (104, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Settings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font ("Enter Sansman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point (9, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size (101, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Image Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font ("Enter Sansman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point (9, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size (106, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Image Height";
            // 
            // text_box_image_width
            // 
            this.text_box_image_width.Font = new System.Drawing.Font ("Enter Sansman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_box_image_width.Location = new System.Drawing.Point (121, 41);
            this.text_box_image_width.Name = "text_box_image_width";
            this.text_box_image_width.Size = new System.Drawing.Size (80, 23);
            this.text_box_image_width.TabIndex = 5;
            this.text_box_image_width.Text = "400";
            this.text_box_image_width.TextChanged += new System.EventHandler (this.text_box_image_width_TextChanged);
            // 
            // text_box_image_height
            // 
            this.text_box_image_height.Font = new System.Drawing.Font ("Enter Sansman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_box_image_height.Location = new System.Drawing.Point (121, 70);
            this.text_box_image_height.Name = "text_box_image_height";
            this.text_box_image_height.Size = new System.Drawing.Size (80, 23);
            this.text_box_image_height.TabIndex = 7;
            this.text_box_image_height.Text = "200";
            this.text_box_image_height.TextChanged += new System.EventHandler (this.text_box_image_height_TextChanged);
            // 
            // text_box_samples
            // 
            this.text_box_samples.Font = new System.Drawing.Font ("Enter Sansman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_box_samples.Location = new System.Drawing.Point (121, 128);
            this.text_box_samples.Name = "text_box_samples";
            this.text_box_samples.Size = new System.Drawing.Size (80, 23);
            this.text_box_samples.TabIndex = 14;
            this.text_box_samples.Text = "1";
            this.text_box_samples.TextChanged += new System.EventHandler (this.text_box_samples_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font ("Enter Sansman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point (9, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size (69, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Samples";
            // 
            // button_render
            // 
            this.button_render.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.button_render.Font = new System.Drawing.Font ("Demonized", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_render.Location = new System.Drawing.Point (207, 41);
            this.button_render.Name = "button_render";
            this.button_render.Size = new System.Drawing.Size (265, 52);
            this.button_render.TabIndex = 16;
            this.button_render.Text = "Render";
            this.button_render.UseVisualStyleBackColor = true;
            this.button_render.Click += new System.EventHandler (this.button_process_Click);
            // 
            // button_save
            // 
            this.button_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_save.Font = new System.Drawing.Font ("Enter Sansman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.Location = new System.Drawing.Point (409, 157);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size (63, 23);
            this.button_save.TabIndex = 17;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler (this.button_save_Click);
            // 
            // button_browse
            // 
            this.button_browse.Font = new System.Drawing.Font ("Enter Sansman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_browse.Location = new System.Drawing.Point (12, 157);
            this.button_browse.Name = "button_browse";
            this.button_browse.Size = new System.Drawing.Size (98, 23);
            this.button_browse.TabIndex = 18;
            this.button_browse.Text = "Browse";
            this.button_browse.UseVisualStyleBackColor = true;
            this.button_browse.Click += new System.EventHandler (this.button_browse_Click);
            // 
            // text_box_output_path
            // 
            this.text_box_output_path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.text_box_output_path.Font = new System.Drawing.Font ("Enter Sansman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_box_output_path.Location = new System.Drawing.Point (121, 157);
            this.text_box_output_path.Name = "text_box_output_path";
            this.text_box_output_path.Size = new System.Drawing.Size (282, 23);
            this.text_box_output_path.TabIndex = 19;
            this.text_box_output_path.TextChanged += new System.EventHandler (this.text_box_output_path_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font ("Enter Sansman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point (207, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size (146, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "Last Render Time:";
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Font = new System.Drawing.Font ("Enter Sansman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_time.Location = new System.Drawing.Point (359, 131);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size (86, 15);
            this.label_time.TabIndex = 21;
            this.label_time.Text = "0 seconds";
            // 
            // text_box_iterations
            // 
            this.text_box_iterations.Font = new System.Drawing.Font ("Enter Sansman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_box_iterations.Location = new System.Drawing.Point (121, 99);
            this.text_box_iterations.Name = "text_box_iterations";
            this.text_box_iterations.Size = new System.Drawing.Size (80, 23);
            this.text_box_iterations.TabIndex = 22;
            this.text_box_iterations.Text = "100";
            this.text_box_iterations.TextChanged += new System.EventHandler (this.text_box_iterations_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font ("Enter Sansman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point (9, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size (81, 15);
            this.label9.TabIndex = 23;
            this.label9.Text = "Iterations";
            // 
            // button_zoom_in
            // 
            this.button_zoom_in.Font = new System.Drawing.Font ("Enter Sansman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_zoom_in.Location = new System.Drawing.Point (207, 99);
            this.button_zoom_in.Name = "button_zoom_in";
            this.button_zoom_in.Size = new System.Drawing.Size (126, 23);
            this.button_zoom_in.TabIndex = 24;
            this.button_zoom_in.Text = "Zoom In";
            this.button_zoom_in.UseVisualStyleBackColor = true;
            this.button_zoom_in.Click += new System.EventHandler (this.button_zoom_in_Click);
            // 
            // button_zoom_out
            // 
            this.button_zoom_out.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_zoom_out.Font = new System.Drawing.Font ("Enter Sansman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_zoom_out.Location = new System.Drawing.Point (346, 99);
            this.button_zoom_out.Name = "button_zoom_out";
            this.button_zoom_out.Size = new System.Drawing.Size (126, 23);
            this.button_zoom_out.TabIndex = 25;
            this.button_zoom_out.Text = "Zoom Out";
            this.button_zoom_out.UseVisualStyleBackColor = true;
            this.button_zoom_out.Click += new System.EventHandler (this.button_zoom_out_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font ("Enter Sansman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point (207, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size (126, 22);
            this.label4.TabIndex = 26;
            this.label4.Text = "Commands";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size (484, 409);
            this.Controls.Add (this.label4);
            this.Controls.Add (this.button_zoom_out);
            this.Controls.Add (this.button_zoom_in);
            this.Controls.Add (this.label9);
            this.Controls.Add (this.text_box_iterations);
            this.Controls.Add (this.label_time);
            this.Controls.Add (this.label8);
            this.Controls.Add (this.text_box_output_path);
            this.Controls.Add (this.button_browse);
            this.Controls.Add (this.button_save);
            this.Controls.Add (this.button_render);
            this.Controls.Add (this.label7);
            this.Controls.Add (this.text_box_samples);
            this.Controls.Add (this.text_box_image_height);
            this.Controls.Add (this.text_box_image_width);
            this.Controls.Add (this.label3);
            this.Controls.Add (this.label1);
            this.Controls.Add (this.label2);
            this.Controls.Add (this.pictureBox1);
            this.Font = new System.Drawing.Font ("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Mandelbrot Fractal Generator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit ();
            this.ResumeLayout (false);
            this.PerformLayout ();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_box_image_width;
        private System.Windows.Forms.TextBox text_box_image_height;
        private System.Windows.Forms.TextBox text_box_samples;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_render;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_browse;
        private System.Windows.Forms.TextBox text_box_output_path;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.TextBox text_box_iterations;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_zoom_in;
        private System.Windows.Forms.Button button_zoom_out;
        private System.Windows.Forms.Label label4;
    }
}

