namespace SQL_managermentCoffe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txb_login_Click(object sender, EventArgs e)
        {
            Fmanagerment fm = new Fmanagerment();
            fm.Show();
            this.Hide();
        }
    }
}
