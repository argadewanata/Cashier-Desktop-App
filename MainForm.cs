using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cashier_Dekstop_App
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void productsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ProductsForm p = new ProductsForm();
            p.MdiParent = this;
            p.Show();
        }

        private void newBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_Bill nb = new New_Bill();
            nb.MdiParent = this;
            nb.Show();
        }

        private void billToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewBill view_bill = new ViewBill();
            view_bill.MdiParent = this;
            view_bill.Show();
        }
    }
}
