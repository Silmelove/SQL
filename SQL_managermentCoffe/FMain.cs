using SQL_managermentCoffe.AllForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_managermentCoffe
{
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
        }
        public void Addcontrol(Form fs)
        {
            ControlsPanel.Controls.Clear();
            fs.Dock = DockStyle.Fill;
            fs.TopLevel = false;
            ControlsPanel.Controls.Add(fs);
            fs.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Addcontrol(new FHome());
        }

       /* private void btn_managerment_Click(object sender, EventArgs e)
        {
            Addcontrol(new Femployee_manager());
        }
        private void btn_product_Click(object sender, EventArgs e)
        {
            Addcontrol(new FProduct());
        }

        private void btn_statistical_Click(object sender, EventArgs e)
        {

        }

        private void btn_Bill_Click(object sender, EventArgs e)
        {
            Addcontrol(new FBill());
        }

        private void btn_detailedinvoice_Click(object sender, EventArgs e)
        {
            Addcontrol(new FDetailed_invoice());
        }*/
    }
}
