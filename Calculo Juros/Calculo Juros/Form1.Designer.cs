namespace Calculo_Juros
{
    partial class frmCalcJuros
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
            txtValPM = new TextBox();
            btnCalcular = new Button();
            txtMeses = new TextBox();
            txtJuros = new TextBox();
            lblResultado = new Label();
            lblMeses = new Label();
            label1 = new Label();
            cbxMode = new ComboBox();
            lblInvestido = new Label();
            panel1 = new Panel();
            btnClose = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtValPM
            // 
            txtValPM.Font = new Font("MS UI Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtValPM.Location = new Point(50, 120);
            txtValPM.Name = "txtValPM";
            txtValPM.PlaceholderText = "Valor";
            txtValPM.Size = new Size(300, 26);
            txtValPM.TabIndex = 2;
            txtValPM.KeyPress += txtValPM_KeyPress;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.FromArgb(0, 64, 0);
            btnCalcular.FlatAppearance.BorderSize = 0;
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.Font = new Font("MS UI Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalcular.ForeColor = Color.White;
            btnCalcular.Location = new Point(100, 270);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(200, 50);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtMeses
            // 
            txtMeses.Font = new Font("MS UI Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtMeses.Location = new Point(50, 170);
            txtMeses.Name = "txtMeses";
            txtMeses.PlaceholderText = "Meses";
            txtMeses.Size = new Size(300, 26);
            txtMeses.TabIndex = 3;
            txtMeses.KeyPress += txtMeses_KeyPress;
            // 
            // txtJuros
            // 
            txtJuros.Font = new Font("MS UI Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtJuros.Location = new Point(50, 220);
            txtJuros.Name = "txtJuros";
            txtJuros.PlaceholderText = "% de Juros";
            txtJuros.Size = new Size(300, 26);
            txtJuros.TabIndex = 4;
            txtJuros.KeyPress += txtJuros_KeyPress;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("MS UI Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultado.Location = new Point(50, 401);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(331, 19);
            lblResultado.TabIndex = 6;
            lblResultado.Text = "Dinamic: Valor adicionado mensalmente.";
            // 
            // lblMeses
            // 
            lblMeses.AutoSize = true;
            lblMeses.Font = new Font("MS UI Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblMeses.Location = new Point(50, 358);
            lblMeses.Name = "lblMeses";
            lblMeses.Size = new Size(321, 19);
            lblMeses.TabIndex = 7;
            lblMeses.Text = "Static: Não é adicionado mensalmente.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(50, 83);
            label1.Name = "label1";
            label1.Size = new Size(153, 24);
            label1.TabIndex = 8;
            label1.Text = "Calcular Juros";
            // 
            // cbxMode
            // 
            cbxMode.BackColor = Color.FromArgb(192, 255, 192);
            cbxMode.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxMode.FlatStyle = FlatStyle.Flat;
            cbxMode.Font = new Font("MS UI Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbxMode.FormattingEnabled = true;
            cbxMode.Items.AddRange(new object[] { "static", "dinamic" });
            cbxMode.Location = new Point(220, 83);
            cbxMode.Name = "cbxMode";
            cbxMode.Size = new Size(130, 27);
            cbxMode.TabIndex = 1;
            // 
            // lblInvestido
            // 
            lblInvestido.AutoSize = true;
            lblInvestido.Font = new Font("MS UI Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblInvestido.Location = new Point(50, 447);
            lblInvestido.Name = "lblInvestido";
            lblInvestido.Size = new Size(0, 19);
            lblInvestido.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 31);
            panel1.TabIndex = 11;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.DarkRed;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("MS UI Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(357, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(43, 31);
            btnClose.TabIndex = 0;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // frmCalcJuros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(400, 500);
            Controls.Add(panel1);
            Controls.Add(lblInvestido);
            Controls.Add(cbxMode);
            Controls.Add(label1);
            Controls.Add(lblMeses);
            Controls.Add(lblResultado);
            Controls.Add(txtJuros);
            Controls.Add(txtMeses);
            Controls.Add(btnCalcular);
            Controls.Add(txtValPM);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCalcJuros";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculo Juros";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtValPM;
        private Button btnCalcular;
        private TextBox txtMeses;
        private TextBox txtJuros;
        private Label lblResultado;
        private Label lblMeses;
        private Label label1;
        private ComboBox cbxMode;
        private Label lblInvestido;
        private Panel panel1;
        private Button btnClose;
    }
}
