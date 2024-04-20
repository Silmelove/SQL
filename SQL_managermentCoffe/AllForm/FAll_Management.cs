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
    public partial class FAll_Management : Form
    {
        public FAll_Management()
        {
            InitializeComponent();
        }
        public void Addcontrol_1(Form fs)
        {
            ControlsPanel_1.Controls.Clear();
            fs.Dock = DockStyle.Fill;
            fs.TopLevel = false;
            ControlsPanel_1.Controls.Add(fs);
            fs.Show();
        }
        private void btn_managerment_Click(object sender, EventArgs e)
        {
            Addcontrol_1(new Femployee_manager());
        }
        private void btn_product_Click(object sender, EventArgs e)
        {
            Addcontrol_1(new FProduct());
        }

        private void btn_statistical_Click(object sender, EventArgs e)
        {
            Addcontrol_1(new Fstatistical());
        }

        private void btn_Bill_Click(object sender, EventArgs e)
        {
            Addcontrol_1(new FBill());
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            Addcontrol_1(new Fhelp());
        }
    }
}
