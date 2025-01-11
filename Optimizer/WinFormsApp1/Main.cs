namespace WinFormsApp1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void loadForm(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
            {
                this.mainpanel.Controls.RemoveAt(0);
                Form f = Form as Form;
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                this.mainpanel.Controls.Add(f);
                this.mainpanel.Tag = f;
                f.Show();
            }

        }

        private void btnFps_Click(object sender, EventArgs e)
        {
            loadForm(new Fps());
        }

        private void btnPing_Click(object sender, EventArgs e)
        {
            loadForm(new Ping());
        }

        private void btnOther_Click(object sender, EventArgs e)
        {
            loadForm(new Other());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            loadForm(new Main());
        }
    }
}
