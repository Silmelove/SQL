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
    public partial class Fstatistical : Form
    {
        public Fstatistical()
        {
            InitializeComponent();
        }

        private void btn_Invoicestatistics_Click(object sender, EventArgs e)
        {
            FInvoice_statistics finvoi = new FInvoice_statistics();
            finvoi.ShowDialog();
        }
    }
}
