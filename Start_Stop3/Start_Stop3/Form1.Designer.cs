namespace Start_Stop3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            start = new Button();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            stop = new Button();
            exit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // start
            // 
            start.Location = new Point(84, 239);
            start.Name = "start";
            start.Size = new Size(75, 23);
            start.TabIndex = 0;
            start.Text = "Start";
            start.UseVisualStyleBackColor = true;
            start.Click += start_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ON1;
            pictureBox1.Location = new Point(84, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 178);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(exit);
            groupBox1.Controls.Add(stop);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(start);
            groupBox1.Location = new Point(123, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(369, 354);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // stop
            // 
            stop.Location = new Point(192, 239);
            stop.Name = "stop";
            stop.Size = new Size(75, 23);
            stop.TabIndex = 2;
            stop.Text = "Stop";
            stop.UseVisualStyleBackColor = true;
            stop.Click += stop_Click;
            // 
            // exit
            // 
            exit.Location = new Point(137, 268);
            exit.Name = "exit";
            exit.Size = new Size(75, 23);
            exit.TabIndex = 3;
            exit.Text = "Exit";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Button start;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Button exit;
        private Button stop;
    }
}
