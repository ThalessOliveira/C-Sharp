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
    public partial class Fps : Form
    {
        public Fps()
        {
            InitializeComponent();
        }

        private void cboRam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboRam.SelectedIndex >= 0)
            {
                label1.Text = string.Empty;
            }
        }

        private void cboWindows_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboWindows.SelectedIndex >= 0)
            {
                label2.Text = string.Empty;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        }
    }
}
