﻿namespace WinFormsApp1
{
    partial class Fps
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
            label3 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(286, 198);
            label3.Name = "label3";
            label3.Size = new Size(40, 23);
            label3.TabIndex = 3;
            label3.Text = "FPS";
            // 
            // Fps
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 60, 60);
            ClientSize = new Size(600, 420);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Fps";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fps";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
    }
}