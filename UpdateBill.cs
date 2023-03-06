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

namespace Cashier_Dekstop_App
{
    public partial class UpdateBill : Form
    {
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private DataTable dt;
        private SqlDataReader dr;

        koneksi sql_Connection = new koneksi();

        public UpdateBill()
        {
            InitializeComponent();
        }

        private void UpdateBill_Load(object sender, EventArgs e)
        {
            SqlConnection myconn = sql_Connection.GetConn();
            myconn.Open();

            cmd = myconn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM TBL_RowData WHERE BillNo LIKE('" + txtBox_BillNo.Text + "%' )";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void txtBox_ProPrice_Leave(object sender, EventArgs e)
        {
            CalcAmount();
        }

        private void txtbox_ProQty_Leave(object sender, EventArgs e)
        {
            CalcAmount();
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            LoadSerialNo();
        }

        int i;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[i];
            txtBox_DeleUpdate.Text = row.Cells[0].Value.ToString();
            comboBox1.Text = row.Cells[1].Value.ToString();
            txtBox_ProPrice.Text = row.Cells[2].Value.ToString();
            txtbox_ProQty.Text = row.Cells[3].Value.ToString();
            txtbox_ProAmount.Text = row.Cells[4].Value.ToString();

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (!row.IsNewRow)
                {
                    dataGridView1.Rows.Remove(row);
                }

                LoadSerialNo();
            }

            clearText();
            gridTotal();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txtBox_DeleUpdate.Text == "")
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows[1].Cells[0].Value = (i + 1).ToString();
                }

                DataTable dt = dataGridView1.DataSource as DataTable;

                DataRow row1 = dt.NewRow();
                row1[1] = comboBox1.Text.ToString();
                row1[2] = txtBox_ProPrice.Text.ToString();
                row1[3] = txtbox_ProQty.Text.ToString();
                row1[4] = txtbox_ProAmount.Text.ToString();
                row1[5] = txtBox_BillNo.Text.ToString();
                row1[6] = dateTimePicker2.Value.ToString("MM-dd-yyyy");

                comboBox1.Focus();
                dt.Rows.Add(row1);
            }
            else
            {
                DataGridViewRow row = dataGridView1.Rows[i];
                row.Cells[1].Value = comboBox1.Text;
                row.Cells[2].Value = txtBox_ProPrice.Text;
                row.Cells[3].Value = txtbox_ProQty.Text;
                row.Cells[4].Value = txtbox_ProAmount.Text;
                row.Cells[5].Value = txtBox_BillNo.Text;
                row.Cells[6].Value = dateTimePicker2.Value.ToString("MM-dd-yyyy");
            }

            clearText();
            gridTotal();
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

        private void LoadSerialNo()
        {
            int i = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells[0].Value = i;
                i++;
            }
        }

        private void clearText()
        {
            comboBox1.Text = "";
            txtBox_ProPrice.Text = "";
            txtbox_ProQty.Text = "";
            txtbox_ProAmount.Text = "";
            txtBox_DeleUpdate.Text = "";
        }

        private void txtbox_TotalBill_TextChanged(object sender, EventArgs e)
        {
            calcDisc();
        }

        private void txtbox_Discount_Leave(object sender, EventArgs e)
        {
            calcDisc();
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

        private void btn_Save_Click(object sender, EventArgs e)
        {
            // Delete old entry
            try
            {
                SqlConnection myconn = sql_Connection.GetConn();
                myconn.Open();

                cmd = new SqlCommand("DELETE FROM TBL_RowData WHERE BillNo='" + txtBox_BillNo.Text + "' ", myconn);
                cmd.ExecuteNonQuery();
                myconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Input the new entry
            try
            {
                SqlConnection myconn = sql_Connection.GetConn();
                myconn.Open();

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

                    cmd = new SqlCommand(row_query, myconn);
                    cmd.Parameters.AddWithValue("@SINo", SINo);
                    cmd.Parameters.AddWithValue("@ProductName", ProductName);
                    cmd.Parameters.AddWithValue("@Price", Price);
                    cmd.Parameters.AddWithValue("@Qty", Qty);
                    cmd.Parameters.AddWithValue("@Amount", Amount);
                    cmd.Parameters.AddWithValue("@BillNO", BillNO);
                    cmd.Parameters.AddWithValue("@Date", Date);

                    cmd.ExecuteNonQuery();
                }
                myconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Update header Data
            try
            {
                SqlConnection myconn = sql_Connection.GetConn();
                myconn.Open();

                string BillNo = txtBox_BillNo.Text;
                string BillDate = dateTimePicker1.Value.ToString("MM-dd-yyyy");
                string BillAmount = txtbox_TotalBill.Text;
                string DiscAmount = txtbox_Discount.Text;
                string NetPay = txtbox_NetPay.Text;
                string header_query = "UPDATE TBL_HeaderData set BillDate = @BillDate, BillAmount = @BillAmount, DiscAmount = @DiscAmount, NetPay = @NetPay WHERE BillNo = @BillNo";

                cmd = new SqlCommand(header_query, myconn);
                cmd.Parameters.AddWithValue("@BillNo", BillNo);
                cmd.Parameters.AddWithValue("@BillDate", BillDate);
                cmd.Parameters.AddWithValue("@BillAmount", BillAmount);
                cmd.Parameters.AddWithValue("@DiscAmount", DiscAmount);
                cmd.Parameters.AddWithValue("@NetPay", NetPay);

                cmd.ExecuteNonQuery();
                myconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("Bill Updated");
            clearText();
            clearPayBox();
            CalcAmount();
            calcDisc();
            this.Hide();

        }

        private void clearPayBox()
        {
            txtbox_TotalBill.Text = "";
            txtbox_Discount.Text = "";
            txtbox_NetPay.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection myconn = sql_Connection.GetConn();
            myconn.Open();

            cmd = new SqlCommand("SELECT * FROM TBL_Products WHERE ProName = '" + comboBox1.Text + "' ", myconn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtBox_ProPrice.Text = dr[2].ToString();
            }

            myconn.Close();
        }
    }
}
