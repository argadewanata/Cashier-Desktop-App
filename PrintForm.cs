using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Printing;

namespace Cashier_Dekstop_App
{
    public partial class PrintForm : Form
    {
        public string DataBillNo, DataDate, DataTotalBill, DataDiscount, DataNetPay;

        private SqlCommand cmd;
        private SqlDataAdapter da;
        private DataTable dt;
        private SqlDataReader dr;

        koneksi sql_Connection = new koneksi();

        public PrintForm()
        {
            InitializeComponent();
        }
        private void PrintForm_Load(object sender, EventArgs e)
        {
            lbl_DataBillNo.Text = DataBillNo.ToString();
            lbl_DataDate.Text = DataDate.ToString();
            lbl_DataTotalBill.Text = DataTotalBill.ToString();
            lbl_DataDiscount.Text = DataDiscount.ToString();
            lbl_DataNetPay.Text = DataNetPay.ToString();

            SqlConnection myconn = sql_Connection.GetConn();
            myconn.Open();

            cmd = myconn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM TBL_RowData WHERE BillNo LIKE('" + lbl_DataBillNo.Text + "%' )";
            cmd.ExecuteNonQuery();

            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            myconn.Close();
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;

            fillProductForm();

        }

        private void lbl_Area_Click(object sender, EventArgs e)
        {
        }

        private void fillProductForm()
        {
            comboBox1.Select();
            comboBox1.Items.Clear(); // Clear combo box before load form

            SqlConnection myconn = sql_Connection.GetConn();
            myconn.Open();
            cmd = myconn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT ProName from TBL_Products ORDER BY ProName ASC";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["ProName"].ToString());
            }
            myconn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            LoadSerialNo();
        }

        private void LoadSerialNo()
        {
            int i = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells[0].Value = i;
                i++;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            print(this.panelPrint);
        }

        private void print(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            panelPrint = pnl;
            getPrintArea(pnl);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryimg, (pagearea.Width / 2) - (this.panelPrint.Width / 2), this.panelPrint.Location.Y);
        }

        private Bitmap memoryimg;

        private void getPrintArea(Panel pnl)
        {
            memoryimg = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memoryimg, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }

    }
}
