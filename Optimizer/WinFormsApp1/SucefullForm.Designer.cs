﻿namespace WinFormsApp1
{
    partial class SucefullForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SucefullForm));
            panel1 = new Panel();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtSucefullMessage = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 192, 0);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 30);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(370, 0);
            button1.Name = "button1";
            button1.Size = new Size(30, 30);
            button1.TabIndex = 2;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(25, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 192, 0);
            label1.Location = new Point(136, 62);
            label1.Name = "label1";
            label1.Size = new Size(230, 23);
            label1.TabIndex = 4;
            label1.Text = "Successful applications!";
            // 
            // txtSucefullMessage
            // 
            txtSucefullMessage.BackColor = Color.FromArgb(40, 40, 40);
            txtSucefullMessage.BorderStyle = BorderStyle.None;
            txtSucefullMessage.Font = new Font("Century Gothic", 11F);
            txtSucefullMessage.ForeColor = Color.White;
            txtSucefullMessage.Location = new Point(136, 104);
            txtSucefullMessage.Multiline = true;
            txtSucefullMessage.Name = "txtSucefullMessage";
            txtSucefullMessage.ReadOnly = true;
            txtSucefullMessage.Size = new Size(242, 117);
            txtSucefullMessage.TabIndex = 5;
            // 
            // SucefullForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 20);
            ClientSize = new Size(400, 250);
            Controls.Add(txtSucefullMessage);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SucefullForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SucefullForm";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtSucefullMessage;
    }
}