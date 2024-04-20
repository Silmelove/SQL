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
    public partial class FBill : Form
    {
        public FBill()
        {
            InitializeComponent();
        }
        private void btn_Detailedinvoice_Click(object sender, EventArgs e)
        {
            FDetailed_invoice fDetailed_Invoice=new FDetailed_invoice();
            fDetailed_Invoice.ShowDialog();
        }
    }
}
