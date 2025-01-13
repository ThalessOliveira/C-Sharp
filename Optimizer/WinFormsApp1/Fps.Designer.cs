namespace WinFormsApp1
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
            cboRam = new ComboBox();
            cboWindows = new ComboBox();
            btnApply = new Button();
            chkboxTemporaryFiles = new CheckBox();
            chkboxWindows = new CheckBox();
            chkboxEnergy = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(21, 20);
            label3.Name = "label3";
            label3.Size = new Size(164, 23);
            label3.TabIndex = 3;
            label3.Text = "FPS Optimization";
            // 
            // cboRam
            // 
            cboRam.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRam.FlatStyle = FlatStyle.Flat;
            cboRam.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            cboRam.FormattingEnabled = true;
            cboRam.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8 or more..." });
            cboRam.Location = new Point(23, 169);
            cboRam.Name = "cboRam";
            cboRam.Size = new Size(220, 31);
            cboRam.TabIndex = 7;
            cboRam.SelectedIndexChanged += cboRam_SelectedIndexChanged;
            // 
            // cboWindows
            // 
            cboWindows.DropDownStyle = ComboBoxStyle.DropDownList;
            cboWindows.FlatStyle = FlatStyle.Flat;
            cboWindows.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            cboWindows.FormattingEnabled = true;
            cboWindows.Items.AddRange(new object[] { "Windows 10" });
            cboWindows.Location = new Point(271, 169);
            cboWindows.Name = "cboWindows";
            cboWindows.Size = new Size(220, 31);
            cboWindows.TabIndex = 8;
            cboWindows.SelectedIndexChanged += cboWindows_SelectedIndexChanged;
            // 
            // btnApply
            // 
            btnApply.FlatStyle = FlatStyle.Flat;
            btnApply.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            btnApply.ForeColor = Color.White;
            btnApply.Location = new Point(21, 280);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(220, 55);
            btnApply.TabIndex = 9;
            btnApply.Text = "Apply Settings";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // chkboxTemporaryFiles
            // 
            chkboxTemporaryFiles.AutoSize = true;
            chkboxTemporaryFiles.FlatStyle = FlatStyle.Flat;
            chkboxTemporaryFiles.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            chkboxTemporaryFiles.ForeColor = Color.White;
            chkboxTemporaryFiles.Location = new Point(22, 66);
            chkboxTemporaryFiles.Name = "chkboxTemporaryFiles";
            chkboxTemporaryFiles.Size = new Size(219, 27);
            chkboxTemporaryFiles.TabIndex = 10;
            chkboxTemporaryFiles.Text = "Clear temporary files";
            chkboxTemporaryFiles.UseVisualStyleBackColor = true;
            // 
            // chkboxWindows
            // 
            chkboxWindows.AutoSize = true;
            chkboxWindows.FlatStyle = FlatStyle.Flat;
            chkboxWindows.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            chkboxWindows.ForeColor = Color.White;
            chkboxWindows.Location = new Point(22, 112);
            chkboxWindows.Name = "chkboxWindows";
            chkboxWindows.Size = new Size(196, 27);
            chkboxWindows.TabIndex = 11;
            chkboxWindows.Text = "Optimize Windows";
            chkboxWindows.UseVisualStyleBackColor = true;
            // 
            // chkboxEnergy
            // 
            chkboxEnergy.AutoSize = true;
            chkboxEnergy.FlatStyle = FlatStyle.Flat;
            chkboxEnergy.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            chkboxEnergy.ForeColor = Color.White;
            chkboxEnergy.Location = new Point(271, 66);
            chkboxEnergy.Name = "chkboxEnergy";
            chkboxEnergy.Size = new Size(207, 27);
            chkboxEnergy.TabIndex = 12;
            chkboxEnergy.Text = "Best Energy Settings";
            chkboxEnergy.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(22, 203);
            label1.Name = "label1";
            label1.Size = new Size(176, 23);
            label1.TabIndex = 13;
            label1.Text = "Set your RAM here";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(271, 203);
            label2.Name = "label2";
            label2.Size = new Size(198, 23);
            label2.TabIndex = 14;
            label2.Text = "Select your Windows";
            // 
            // Fps
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 60, 60);
            ClientSize = new Size(600, 420);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(chkboxEnergy);
            Controls.Add(chkboxWindows);
            Controls.Add(chkboxTemporaryFiles);
            Controls.Add(btnApply);
            Controls.Add(cboWindows);
            Controls.Add(cboRam);
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
        private ComboBox cboRam;
        private ComboBox cboWindows;
        private Button btnApply;
        private CheckBox chkboxTemporaryFiles;
        private CheckBox chkboxWindows;
        private CheckBox chkboxEnergy;
        private Label label1;
        private Label label2;
    }
}