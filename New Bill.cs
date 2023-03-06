using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cashier_Dekstop_App
{
    public partial class New_Bill : Form
    {
        private SqlCommand cmd;
        private SqlCommand cmd_header;
        private SqlCommand cmd_row;
        private SqlDataAdapter da;
        private DataTable dt;
        private SqlDataReader dr;

        koneksi sql_Connection = new koneksi();

        public New_Bill()
        {
            InitializeComponent();
            txtBox_DeleUpdate.Visible = false;
        }

        private void New_Bill_Load(object sender, EventArgs e)
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
            loadBillNo();
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
        }

        private void lbl_BillNo_Click(object sender, EventArgs e)
        {

        }

        private void txtBox_BillNo_TextChanged(object sender, EventArgs e)
        {
        }

        private void lbl_ProductName_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count < 1)
            {
                MessageBox.Show("Please add the product");
            }
            else
            {
                //save header data
                SqlConnection myconn = sql_Connection.GetConn();
                myconn.Open();

                string BillNo = txtBox_BillNo.Text;
                string BillDate = dateTimePicker1.Value.ToString("dd-MM-yyyy");
                string BillAmount = txtbox_TotalBill.Text;
                string DiscAmount = txtbox_Discount.Text;
                string NetPay = txtbox_NetPay.Text;
                string header_query = "INSERT INTO TBL_HeaderData VALUES(@BillNo,@BillDate,@BillAmount,@DiscAmount,@NetPay)";

                cmd_header = new SqlCommand(header_query, myconn);
                cmd_header.Parameters.AddWithValue("@BillNo", BillNo);
                cmd_header.Parameters.AddWithValue("@BillDate", BillDate);
                cmd_header.Parameters.AddWithValue("@BillAmount", BillAmount);
                cmd_header.Parameters.AddWithValue("@DiscAmount", DiscAmount);
                cmd_header.Parameters.AddWithValue("@NetPay", NetPay);

                cmd_header.ExecuteNonQuery();

                // Save Row Data
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    string SINo = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    string ProductName = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    string Price = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    string Qty = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    string Amount = dataGridView1.Rows[i].Cells[4].Value.ToString();
                    string BillNO = dataGridView1.Rows[i].Cells[5].Value.ToString();
                    string Date = dataGridView1.Rows[i].Cells[6].Value.ToString();
                    string row_query = "INSERT INTO TBL_RowData(SINo,ProductName,Price,Qty,Amount,BillNo,Date) VALUES(@SINo,@ProductName,@Price,@Qty,@Amount,@BillNO,@Date)";

                    cmd_row = new SqlCommand(row_query, myconn);
                    cmd_row.Parameters.AddWithValue("@SINo", SINo);
                    cmd_row.Parameters.AddWithValue("@ProductName", ProductName);
                    cmd_row.Parameters.AddWithValue("@Price", Price);
                    cmd_row.Parameters.AddWithValue("@Qty", Qty);
                    cmd_row.Parameters.AddWithValue("@Amount", Amount);
                    cmd_row.Parameters.AddWithValue("@BillNO", BillNO);
                    cmd_row.Parameters.AddWithValue("@Date", Date);

                    //SqlCommand cmd1 = new SqlCommand("INSERT INTO TBL_RowData(SINo,ProductName,Price,Qty,Amount,BillNo) VALUES('"+dataGridView1.Rows[i].Cells[0].ToString()+ "','"+dataGridView1.Rows[i].Cells[1].ToString()+ "','"+dataGridView1.Rows[i].Cells[2].ToString()+ "','"+dataGridView1.Rows[i].Cells[3].ToString()+ "','"+dataGridView1.Rows[i].Cells[4].ToString()+ "','"+dataGridView1.Rows[i].Cells[5].Value.ToString()+"')", myconn);

                    cmd_row.ExecuteNonQuery();
                }

                MessageBox.Show("New Bill Saved");
                myconn.Close();

                loadBillNo();
                clearTextBox();
                clearPayBox();

                comboBox1.Select();

            }
        }

        public void loadBillNo()
        {
            // load bill no from database
            int a;
            SqlConnection myconn = sql_Connection.GetConn();
            myconn.Open();

            string query = "SELECT MAX(BillNo) from TBL_HeaderData";
            cmd = new SqlCommand(query, myconn);

            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string val = dr[0].ToString();
                if (val == "")
                {
                    txtBox_BillNo.Text = "1";
                }
                else
                {
                    a = Convert.ToInt32(dr[0].ToString());
                    a++;
                    txtBox_BillNo.Text = a.ToString();
                }
                myconn.Close();
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Product Name is Empty");
            }
            else if (txtBox_ProPrice.Text == "")
            {
                MessageBox.Show("Product Price is Empty");
            }
            else if (txtbox_ProQty.Text == "")
            {
                MessageBox.Show("Product Quantity is Empty");
            }
            else
            {
                // For add the row data in the grid view
                if (txtBox_DeleUpdate.Text == "")
                {
                    int row = 0;
                    dataGridView1.Rows.Add();
                    row = dataGridView1.Rows.Count - 1;
                    dataGridView1["ProductName", row].Value = comboBox1.Text;
                    dataGridView1["Price", row].Value = txtBox_ProPrice.Text;
                    dataGridView1["Qty", row].Value = txtbox_ProQty.Text;
                    dataGridView1["Amount", row].Value = txtbox_ProAmount.Text;
                    dataGridView1["BillNo", row].Value = txtBox_BillNo.Text;
                    dataGridView1["Date", row].Value = dateTimePicker1.Value.ToString("dd-MM-yyyy");

                    dataGridView1.Refresh();
                    comboBox1.Focus();

                    if (dataGridView1.Rows.Count > 0)
                    {
                        dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1];
                    }

                }
                else
                {
                    // Update rows from gridview to textbox and after edit textbox to gridview
                    int i;
                    i = Convert.ToInt32(txtBox_DeleUpdate.Text);
                    DataGridViewRow row = dataGridView1.Rows[i - 1];
                    row.Cells[1].Value = comboBox1.Text;
                    row.Cells[2].Value = txtBox_ProPrice.Text;
                    row.Cells[3].Value = txtbox_ProQty.Text;
                    row.Cells[4].Value = txtbox_ProAmount.Text;

                    btn_Add.Text = "Add";

                }

                clearTextBox();
                CalcAmount();
                gridTotal();

            }
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataGridView1.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        int i;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[i];
            comboBox1.Text = row.Cells[1].Value.ToString();
            txtBox_ProPrice.Text = row.Cells[2].Value.ToString();
            txtbox_ProQty.Text = row.Cells[3].Value.ToString();
            txtbox_ProAmount.Text = row.Cells[4].Value.ToString();

            txtBox_DeleUpdate.Text = row.Cells[0].Value.ToString();

            btn_Add.Text = "Update";
        }

        private void clearTextBox()
        {
            comboBox1.Text = "";
            txtBox_ProPrice.Text = "";
            txtbox_ProQty.Text = "";
            txtbox_ProAmount.Text = "";
            txtBox_DeleUpdate.Text = "";
        }

        private void clearPayBox()
        {
            txtbox_TotalBill.Text = "";
            txtbox_Discount.Text = "";
            txtbox_NetPay.Text = "";
        }

        private void CalcAmount()
        {
            double a1, b1, i;
            double.TryParse(txtBox_ProPrice.Text, out a1);
            double.TryParse(txtbox_ProQty.Text, out b1);
            i = a1 * b1;
            if (i > 0)
            {
                txtbox_ProAmount.Text = i.ToString("C").Remove(0, 1);
            }
        }

        private void gridTotal()
        {
            double sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
            }

            txtbox_TotalBill.Text = sum.ToString();
        }

        private void calcDisc()
        {
            double a2, b2, i;
            double.TryParse(txtbox_TotalBill.Text, out a2);
            double.TryParse(txtbox_Discount.Text, out b2);
            i = a2 - b2; //Bill amount - disc amount
            if (i > 0)
            {
                txtbox_NetPay.Text = i.ToString("C").Remove(0, 1);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (txtBox_DeleUpdate.Text == "")
            {
                MessageBox.Show("Select Product to Delete");
            }
            else
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        dataGridView1.Rows.Remove(row);
                    }
                }

            }
            btn_Add.Text = "Add";

            clearTextBox();
            gridTotal();
        }

        private void txtbox_ProQty_Leave(object sender, EventArgs e)
        {
            CalcAmount();
        }

        private void txtBox_ProPrice_Leave(object sender, EventArgs e)
        {
            CalcAmount();
        }

        private void txtbox_TotalBill_TextChanged(object sender, EventArgs e)
        {
            calcDisc();
        }

        private void txtbox_Discount_Leave(object sender, EventArgs e)
        {
            calcDisc();
        }
    }
}
