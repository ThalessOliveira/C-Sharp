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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            textBox1.Text = "https://discord.gg/xuwBjsFfwj";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
