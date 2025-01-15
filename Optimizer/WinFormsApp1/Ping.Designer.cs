namespace WinFormsApp1
{
    partial class Ping
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
            label2 = new Label();
            label1 = new Label();
            btnApplyPing = new Button();
            cboConectionType = new ComboBox();
            label3 = new Label();
            lblMtu = new Label();
            trkMtu = new TrackBar();
            label6 = new Label();
            btnDefaultMtu = new Button();
            label5 = new Label();
            btnSeachDns = new Button();
            btnFlushDns = new Button();
            btnBestMtu = new Button();
            lblDns = new Label();
            ((System.ComponentModel.ISupportInitialize)trkMtu).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(21, 66);
            label2.Name = "label2";
            label2.Size = new Size(153, 23);
            label2.TabIndex = 23;
            label2.Text = "Conection type";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(361, 66);
            label1.Name = "label1";
            label1.Size = new Size(96, 23);
            label1.TabIndex = 22;
            label1.Text = "Flush Dns:";
            // 
            // btnApplyPing
            // 
            btnApplyPing.FlatStyle = FlatStyle.Flat;
            btnApplyPing.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            btnApplyPing.ForeColor = Color.White;
            btnApplyPing.Location = new Point(24, 246);
            btnApplyPing.Name = "btnApplyPing";
            btnApplyPing.Size = new Size(171, 55);
            btnApplyPing.TabIndex = 18;
            btnApplyPing.Text = "Apply Settings";
            btnApplyPing.UseVisualStyleBackColor = true;
            btnApplyPing.Click += btnApplyPing_Click;
            // 
            // cboConectionType
            // 
            cboConectionType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboConectionType.FlatStyle = FlatStyle.Flat;
            cboConectionType.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            cboConectionType.FormattingEnabled = true;
            cboConectionType.Items.AddRange(new object[] { "Cabble", "Wifi" });
            cboConectionType.Location = new Point(21, 92);
            cboConectionType.Name = "cboConectionType";
            cboConectionType.Size = new Size(220, 31);
            cboConectionType.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(21, 20);
            label3.Name = "label3";
            label3.Size = new Size(174, 23);
            label3.TabIndex = 15;
            label3.Text = "Ping Optimization";
            // 
            // lblMtu
            // 
            lblMtu.AutoSize = true;
            lblMtu.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            lblMtu.ForeColor = Color.White;
            lblMtu.Location = new Point(247, 195);
            lblMtu.Name = "lblMtu";
            lblMtu.Size = new Size(34, 23);
            lblMtu.TabIndex = 32;
            lblMtu.Text = "---";
            // 
            // trkMtu
            // 
            trkMtu.LargeChange = 10;
            trkMtu.Location = new Point(24, 195);
            trkMtu.Maximum = 1500;
            trkMtu.Minimum = 576;
            trkMtu.Name = "trkMtu";
            trkMtu.Size = new Size(217, 45);
            trkMtu.TabIndex = 31;
            trkMtu.TickStyle = TickStyle.None;
            trkMtu.Value = 1300;
            trkMtu.Scroll += trkMtu_Scroll;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(24, 156);
            label6.Name = "label6";
            label6.Size = new Size(45, 23);
            label6.TabIndex = 30;
            label6.Text = "mtu";
            // 
            // btnDefaultMtu
            // 
            btnDefaultMtu.FlatStyle = FlatStyle.Flat;
            btnDefaultMtu.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDefaultMtu.ForeColor = Color.White;
            btnDefaultMtu.Location = new Point(75, 157);
            btnDefaultMtu.Name = "btnDefaultMtu";
            btnDefaultMtu.Size = new Size(95, 26);
            btnDefaultMtu.TabIndex = 33;
            btnDefaultMtu.Text = "Default mtu";
            btnDefaultMtu.UseVisualStyleBackColor = true;
            btnDefaultMtu.Click += btnDefaultMtu_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(361, 195);
            label5.Name = "label5";
            label5.Size = new Size(89, 23);
            label5.TabIndex = 36;
            label5.Text = "Best DNS";
            // 
            // btnSeachDns
            // 
            btnSeachDns.FlatStyle = FlatStyle.Flat;
            btnSeachDns.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            btnSeachDns.ForeColor = Color.White;
            btnSeachDns.Location = new Point(361, 246);
            btnSeachDns.Name = "btnSeachDns";
            btnSeachDns.Size = new Size(171, 55);
            btnSeachDns.TabIndex = 37;
            btnSeachDns.Text = "Search DNS";
            btnSeachDns.UseVisualStyleBackColor = true;
            btnSeachDns.Click += btnSeachDns_Click;
            // 
            // btnFlushDns
            // 
            btnFlushDns.FlatStyle = FlatStyle.Flat;
            btnFlushDns.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            btnFlushDns.ForeColor = Color.White;
            btnFlushDns.Location = new Point(361, 107);
            btnFlushDns.Name = "btnFlushDns";
            btnFlushDns.Size = new Size(171, 49);
            btnFlushDns.TabIndex = 38;
            btnFlushDns.Text = "Flush DNS";
            btnFlushDns.UseVisualStyleBackColor = true;
            btnFlushDns.Click += btnFlushDns_Click;
            // 
            // btnBestMtu
            // 
            btnBestMtu.FlatStyle = FlatStyle.Flat;
            btnBestMtu.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBestMtu.ForeColor = Color.White;
            btnBestMtu.Location = new Point(197, 157);
            btnBestMtu.Name = "btnBestMtu";
            btnBestMtu.Size = new Size(95, 26);
            btnBestMtu.TabIndex = 39;
            btnBestMtu.Text = "Best mtu";
            btnBestMtu.UseVisualStyleBackColor = true;
            btnBestMtu.Click += button3_Click;
            // 
            // lblDns
            // 
            lblDns.AutoSize = true;
            lblDns.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            lblDns.ForeColor = Color.White;
            lblDns.Location = new Point(24, 358);
            lblDns.Name = "lblDns";
            lblDns.Size = new Size(0, 23);
            lblDns.TabIndex = 40;
            // 
            // Ping
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 60, 60);
            ClientSize = new Size(600, 420);
            Controls.Add(lblDns);
            Controls.Add(btnBestMtu);
            Controls.Add(btnFlushDns);
            Controls.Add(btnSeachDns);
            Controls.Add(label5);
            Controls.Add(btnDefaultMtu);
            Controls.Add(lblMtu);
            Controls.Add(trkMtu);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnApplyPing);
            Controls.Add(cboConectionType);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Ping";
            Text = "Ping";
            Load += Ping_Load;
            ((System.ComponentModel.ISupportInitialize)trkMtu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button btnApplyPing;
        private ComboBox cboConectionType;
        private Label label3;
        private CheckBox chkboxYes;
        private CheckBox chkboxNo;
        private Label lblMtu;
        private TrackBar trkMtu;
        private Label label6;
        private Button btnDefaultMtu;
        private RadioButton rbtYes;
        private RadioButton rbtNo;
        private Label label5;
        private Button btnSeachDns;
        private Button btnFlushDns;
        private Button btnBestMtu;
        private Label lblDns;
    }
}