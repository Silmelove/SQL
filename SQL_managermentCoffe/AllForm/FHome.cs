using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_managermentCoffe.AllForm
{
    public partial class FHome : Form
    {
        public FHome()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Flogin flogin = new Flogin();
            flogin.Show();

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            FChange_user_account fchange = new FChange_user_account();
            fchange.ShowDialog();
        }
    }
}
