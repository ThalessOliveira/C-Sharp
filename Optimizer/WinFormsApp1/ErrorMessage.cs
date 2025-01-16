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
    public partial class ErrorMessage : Form
    {
        public ErrorMessage(string errorMessage)
        {
            InitializeComponent();
            textBox1.Text = errorMessage;
            textBox2.Text = "https://discord.gg/xuwBjsFfwj";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
