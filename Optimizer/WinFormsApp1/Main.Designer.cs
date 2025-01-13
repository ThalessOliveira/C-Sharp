namespace WinFormsApp1
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            panelside = new Panel();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            btnOther = new Button();
            btnPing = new Button();
            btnFps = new Button();
            panelheader = new Panel();
            label1 = new Label();
            btnHome = new Button();
            button5 = new Button();
            button4 = new Button();
            mainpanel = new Panel();
            panelside.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelheader.SuspendLayout();
            SuspendLayout();
            // 
            // panelside
            // 
            panelside.BackColor = Color.FromArgb(40, 40, 40);
            panelside.Controls.Add(button1);
            panelside.Controls.Add(pictureBox1);
            panelside.Controls.Add(btnOther);
            panelside.Controls.Add(btnPing);
            panelside.Controls.Add(btnFps);
            panelside.Dock = DockStyle.Left;
            panelside.Location = new Point(0, 30);
            panelside.Name = "panelside";
            panelside.Size = new Size(200, 420);
            panelside.TabIndex = 0;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(137, 384);
            button1.Name = "button1";
            button1.Size = new Size(63, 36);
            button1.TabIndex = 4;
            button1.Text = "More";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(58, 298);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btnOther
            // 
            btnOther.FlatAppearance.BorderSize = 0;
            btnOther.FlatStyle = FlatStyle.Flat;
            btnOther.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOther.ForeColor = Color.White;
            btnOther.Location = new Point(0, 194);
            btnOther.Name = "btnOther";
            btnOther.Size = new Size(200, 60);
            btnOther.TabIndex = 2;
            btnOther.Text = "Game";
            btnOther.UseVisualStyleBackColor = true;
            btnOther.Click += btnOther_Click;
            // 
            // btnPing
            // 
            btnPing.FlatAppearance.BorderSize = 0;
            btnPing.FlatStyle = FlatStyle.Flat;
            btnPing.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPing.ForeColor = Color.White;
            btnPing.Location = new Point(0, 129);
            btnPing.Name = "btnPing";
            btnPing.Size = new Size(200, 60);
            btnPing.TabIndex = 1;
            btnPing.Text = "Ping";
            btnPing.UseVisualStyleBackColor = true;
            btnPing.Click += btnPing_Click;
            // 
            // btnFps
            // 
            btnFps.FlatAppearance.BorderSize = 0;
            btnFps.FlatStyle = FlatStyle.Flat;
            btnFps.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFps.ForeColor = Color.White;
            btnFps.Location = new Point(0, 63);
            btnFps.Name = "btnFps";
            btnFps.Size = new Size(200, 60);
            btnFps.TabIndex = 0;
            btnFps.Text = "FPS Optmizer";
            btnFps.UseVisualStyleBackColor = true;
            btnFps.Click += btnFps_Click;
            // 
            // panelheader
            // 
            panelheader.BackColor = Color.FromArgb(40, 40, 40);
            panelheader.Controls.Add(label1);
            panelheader.Controls.Add(btnHome);
            panelheader.Controls.Add(button5);
            panelheader.Controls.Add(button4);
            panelheader.Dock = DockStyle.Top;
            panelheader.Location = new Point(0, 0);
            panelheader.Name = "panelheader";
            panelheader.Size = new Size(800, 30);
            panelheader.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(36, 4);
            label1.Name = "label1";
            label1.Size = new Size(211, 23);
            label1.TabIndex = 7;
            label1.Text = "BeeBoost FREE Version";
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(40, 40, 40);
            btnHome.BackgroundImage = (Image)resources.GetObject("btnHome.BackgroundImage");
            btnHome.BackgroundImageLayout = ImageLayout.Stretch;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(0, 0);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(30, 30);
            btnHome.TabIndex = 6;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Gray;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(734, 0);
            button5.Name = "button5";
            button5.Size = new Size(30, 30);
            button5.TabIndex = 5;
            button5.Text = "_";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(140, 48, 65);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(770, 0);
            button4.Name = "button4";
            button4.Size = new Size(30, 30);
            button4.TabIndex = 4;
            button4.Text = "X";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // mainpanel
            // 
            mainpanel.Dock = DockStyle.Fill;
            mainpanel.Location = new Point(200, 30);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(600, 420);
            mainpanel.TabIndex = 2;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 60, 60);
            ClientSize = new Size(800, 450);
            Controls.Add(mainpanel);
            Controls.Add(panelside);
            Controls.Add(panelheader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panelside.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelheader.ResumeLayout(false);
            panelheader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelside;
        private Panel panelheader;
        private Button btnPing;
        private Button btnFps;
        private Panel mainpanel;
        private PictureBox pictureBox1;
        private Button btnOther;
        private Button button4;
        private Button button5;
        private Button btnHome;
        private Label label1;
        private Button button1;
    }
}
