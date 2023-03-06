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
using System.Diagnostics;

namespace Cashier_Dekstop_App
{

    public partial class ViewBill : Form
    {
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private DataTable dt;
        private SqlDataReader dr;

        koneksi sql_Connection = new koneksi();

        public ViewBill()
        {
            InitializeComponent();
        }

        private void lbl_FromDate_Click(object sender, EventArgs e)
        {

        }

        private void ViewBill_Load(object sender, EventArgs e)
        {
            fillGrid();
            totalBillSales();
        }

        private void btn_ViewBills_Click(object sender, EventArgs e)
        {
            SqlConnection myconn = sql_Connection.GetConn();
            myconn.Open();

            da = new SqlDataAdapter("SELECT * FROM TBL_HeaderData WHERE BillDate BETWEEN '" + dateTimePickerFrom.Value.ToString("MM/dd/yyyy") + "' AND '" + dateTimePickerTo.Value.ToString("MM/dd/yyyy") + "'", myconn);

            DataSet ds = new DataSet();

            da.Fill(ds, "TBL_HeaderData");
            dataGridView1.DataSource = ds.Tables["TBL_HeaderData"];
            Debug.WriteLine(da.ToString());
            Debug.WriteLine(ds.ToString());
            myconn.Close();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            txtbox_Flag.Text = dr.Cells[0].Value.ToString();
        }

        private void bnt_DeleteBills_Click(object sender, EventArgs e)
        {
            if (txtbox_Flag.Text == "")
            {
                MessageBox.Show("Please select the bill");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure?", "Deleting Selected Bill", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SqlCommand cmd_header = new SqlCommand();
                    SqlCommand cmd_row = new SqlCommand();
                    SqlConnection myconn = sql_Connection.GetConn();
                    myconn.Open();

                    string BillNo = txtbox_Flag.Text;
                    string header_query = "DELETE FROM TBL_HeaderData WHERE BillNo = @BillNo";
                    string row_query = "DELETE FROM TBL_RowData WHERE BillNo = @BillNo";

                    cmd_header = new SqlCommand(header_query, myconn);
                    cmd_row = new SqlCommand(row_query, myconn);
                    cmd_header.Parameters.AddWithValue("@BillNo", BillNo);
                    cmd_row.Parameters.AddWithValue("@BillNo", BillNo);

                    cmd_header.ExecuteNonQuery();
                    cmd_row.ExecuteNonQuery();

                    myconn.Close();
                    fillGrid();
                    totalBillSales();

                }
                else
                {

                }
            }
        }

        private void fillGrid()
        {
            SqlConnection myconn = sql_Connection.GetConn();
            myconn.Open();
            da = new SqlDataAdapter("SELECT * FROM TBL_HeaderData ORDER BY BillNo ASC", myconn);
            myconn.Close();
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void totalBillSales()
        {
            txtbox_TotalBills.Text = dataGridView1.Rows.Count.ToString();

            double sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
            }

            txtbox_TotalSales.Text = sum.ToString();

        }

        private void txtbox_TotalBills_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateBill ub = new UpdateBill();
            ub.txtBox_BillNo.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            ub.txtbox_TotalBill.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            ub.txtbox_Discount.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            ub.txtbox_NetPay.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();

            ub.Show(); // Show the form
            this.Hide(); // hide the view bill

        }
    }
}
