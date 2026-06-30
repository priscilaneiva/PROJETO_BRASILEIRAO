namespace AppGestaoBrasileirao
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmTelaConsultar ftc = new frmTelaConsultar();
            ftc.Show();
        }
    }
}
