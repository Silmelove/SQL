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
    public partial class Flogin : Form
    {
        public Flogin()
        {
            InitializeComponent();
        }

        private void Flogin_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            FAll_Management fall = new FAll_Management();
            fall.ShowDialog();
            this.Hide();
        }
    }
}
