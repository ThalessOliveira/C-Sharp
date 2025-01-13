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
            label4 = new Label();
            trkPing = new TrackBar();
            lbl_ping = new Label();
            lblMtu = new Label();
            trkMtu = new TrackBar();
            label6 = new Label();
            btnDefaultMtu = new Button();
            rbtYes = new RadioButton();
            rbtNo = new RadioButton();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)trkPing).BeginInit();
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
            label1.Location = new Point(284, 66);
            label1.Name = "label1";
            label1.Size = new Size(188, 23);
            label1.TabIndex = 22;
            label1.Text = "Is your ping stable?";
            // 
            // btnApplyPing
            // 
            btnApplyPing.FlatStyle = FlatStyle.Flat;
            btnApplyPing.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            btnApplyPing.ForeColor = Color.White;
            btnApplyPing.Location = new Point(281, 287);
            btnApplyPing.Name = "btnApplyPing";
            btnApplyPing.Size = new Size(220, 55);
            btnApplyPing.TabIndex = 18;
            btnApplyPing.Text = "Apply Settings";
            btnApplyPing.UseVisualStyleBackColor = true;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(21, 156);
            label4.Name = "label4";
            label4.Size = new Size(103, 23);
            label4.TabIndex = 27;
            label4.Text = "Your ping:";
            // 
            // trkPing
            // 
            trkPing.LargeChange = 10;
            trkPing.Location = new Point(24, 200);
            trkPing.Maximum = 250;
            trkPing.Minimum = 1;
            trkPing.Name = "trkPing";
            trkPing.Size = new Size(217, 45);
            trkPing.TabIndex = 28;
            trkPing.TickStyle = TickStyle.None;
            trkPing.Value = 1;
            trkPing.Scroll += trkPing_Scroll;
            // 
            // lbl_ping
            // 
            lbl_ping.AutoSize = true;
            lbl_ping.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            lbl_ping.ForeColor = Color.White;
            lbl_ping.Location = new Point(141, 156);
            lbl_ping.Name = "lbl_ping";
            lbl_ping.Size = new Size(34, 23);
            lbl_ping.TabIndex = 29;
            lbl_ping.Text = "---";
            // 
            // lblMtu
            // 
            lblMtu.AutoSize = true;
            lblMtu.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            lblMtu.ForeColor = Color.White;
            lblMtu.Location = new Point(332, 156);
            lblMtu.Name = "lblMtu";
            lblMtu.Size = new Size(34, 23);
            lblMtu.TabIndex = 32;
            lblMtu.Text = "---";
            // 
            // trkMtu
            // 
            trkMtu.LargeChange = 10;
            trkMtu.Location = new Point(284, 200);
            trkMtu.Maximum = 9216;
            trkMtu.Minimum = 1300;
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
            label6.Location = new Point(281, 156);
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
            btnDefaultMtu.Location = new Point(406, 157);
            btnDefaultMtu.Name = "btnDefaultMtu";
            btnDefaultMtu.Size = new Size(95, 26);
            btnDefaultMtu.TabIndex = 33;
            btnDefaultMtu.Text = "Default mtu";
            btnDefaultMtu.UseVisualStyleBackColor = true;
            btnDefaultMtu.Click += btnDefaultMtu_Click;
            // 
            // rbtYes
            // 
            rbtYes.AutoSize = true;
            rbtYes.FlatStyle = FlatStyle.Flat;
            rbtYes.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            rbtYes.ForeColor = Color.White;
            rbtYes.Location = new Point(284, 96);
            rbtYes.Name = "rbtYes";
            rbtYes.Size = new Size(59, 27);
            rbtYes.TabIndex = 34;
            rbtYes.TabStop = true;
            rbtYes.Text = "Yes";
            rbtYes.UseVisualStyleBackColor = true;
            // 
            // rbtNo
            // 
            rbtNo.AutoSize = true;
            rbtNo.FlatStyle = FlatStyle.Flat;
            rbtNo.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            rbtNo.ForeColor = Color.White;
            rbtNo.Location = new Point(365, 96);
            rbtNo.Name = "rbtNo";
            rbtNo.Size = new Size(53, 27);
            rbtNo.TabIndex = 35;
            rbtNo.TabStop = true;
            rbtNo.Text = "No";
            rbtNo.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(24, 261);
            label5.Name = "label5";
            label5.Size = new Size(89, 23);
            label5.TabIndex = 36;
            label5.Text = "Best DNS";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(24, 287);
            button1.Name = "button1";
            button1.Size = new Size(143, 49);
            button1.TabIndex = 37;
            button1.Text = "Search DNS";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(24, 342);
            button2.Name = "button2";
            button2.Size = new Size(143, 49);
            button2.TabIndex = 38;
            button2.Text = "Flush DNS";
            button2.UseVisualStyleBackColor = true;
            // 
            // Ping
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 60, 60);
            ClientSize = new Size(600, 420);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(rbtNo);
            Controls.Add(rbtYes);
            Controls.Add(btnDefaultMtu);
            Controls.Add(lblMtu);
            Controls.Add(trkMtu);
            Controls.Add(label6);
            Controls.Add(lbl_ping);
            Controls.Add(trkPing);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnApplyPing);
            Controls.Add(cboConectionType);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Ping";
            Text = "Ping";
            Load += Ping_Load;
            ((System.ComponentModel.ISupportInitialize)trkPing).EndInit();
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
        private Label label4;
        private TrackBar trkPing;
        private Label lbl_ping;
        private Label lblMtu;
        private TrackBar trkMtu;
        private Label label6;
        private Button btnDefaultMtu;
        private RadioButton rbtYes;
        private RadioButton rbtNo;
        private Label label5;
        private Button button1;
        private Button button2;
    }
}