using System.Drawing.Text;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace Calculo_Juros
{
    public partial class frmCalcJuros : Form
    {
        public frmCalcJuros()
        {
            InitializeComponent();
            cbxMode.SelectedIndex = 0;
        }

        public void limparCampos()
        {
            txtValPM.Text = string.Empty;
            txtMeses.Text = string.Empty;
            txtJuros.Text = string.Empty;
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtJuros.Text == string.Empty || txtMeses.Text == string.Empty || txtValPM.Text == string.Empty)
            {
                frmMessageBox form = new frmMessageBox();
                form.ShowDialog();
                return;
            }

            double valor = double.Parse(txtValPM.Text);
            double meses = double.Parse(txtMeses.Text);
            double juros = double.Parse(txtJuros.Text);

            int i;
            double ganho;
            double valorreal;
            double investido;

            valorreal = valor;

            if (cbxMode.Text == "static")
            {
                investido = valorreal;

                for (i = 1; i <= meses; i++)
                {
                    ganho = valor * juros;
                    ganho = ganho / 100;
                    valor = valor + ganho;
                }

                lblInvestido.Text = "Valor Investido foi de " + investido.ToString("N2");
                lblMeses.Text = "Em " + meses.ToString() + " Meses";
                lblResultado.Text = "Você receberá " + valor.ToString("N2");
            }
            else
            {
                investido = valorreal * meses;
                for (i = 1; i <= meses; i++)
                {
                    ganho = valor * juros;
                    ganho = ganho / 100;
                    valor = valor + ganho;
                    if (i >= 2)
                    {
                        valor = valor + valorreal;
                    }
                }

                lblInvestido.Text = "Valor Investido foi de " + investido.ToString("N2");
                lblMeses.Text = "Em " + meses.ToString() + " Meses";
                lblResultado.Text = "Você receberá " + valor.ToString("N2");
            }
            limparCampos();
        }

        private void txtJuros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                frmMsgBoxCampos frm = new frmMsgBoxCampos();
                frm.ShowDialog();
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                frmMsgBoxCampos frm = new frmMsgBoxCampos();
                frm.ShowDialog();
            }
        }

        private void txtValPM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                frmMsgBoxCampos frm = new frmMsgBoxCampos();
                frm.ShowDialog();
            }
        }

        private void txtMeses_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                frmMsgBoxCampos frm = new frmMsgBoxCampos();
                frm.ShowDialog();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
