using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Ping : Form
    {
        public Ping()
        {
            InitializeComponent();
        }

        private void Ping_Load(object sender, EventArgs e)
        {

        }

        private void trkPing_Scroll(object sender, EventArgs e)
        {
            lbl_ping.Text = trkPing.Value.ToString();
        }

        private void trkMtu_Scroll(object sender, EventArgs e)
        {
            lblMtu.Text = trkMtu.Value.ToString();
        }

        private void btnDefaultMtu_Click(object sender, EventArgs e)
        {
            lblMtu.Text = 1500.ToString();
            trkMtu.Value = 1500;
        }
    }
}
