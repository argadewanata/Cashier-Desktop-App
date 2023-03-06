using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Cashier_Dekstop_App
{
    public partial class ProductsForm : Form
    {

        private SqlCommand cmd;
        private SqlDataAdapter da;
        private DataTable dt;

        koneksi sql_Connection = new koneksi();

        public ProductsForm()
        {
            InitializeComponent();
        }


        private void lbl_Product_Click(object sender, EventArgs e)
        {
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            fillGrid();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void lbl_ProductName_Click(object sender, EventArgs e)
        {
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            // Save Product information
            try
            {
                if (txtbox_ProductName.Text == "" || txtbox_ProductID.Text == "")
                {
                    MessageBox.Show("Please complete the product identity");
                }
                else
                {
                    SqlConnection myconn = sql_Connection.GetConn();
                    myconn.Open();

                    string ProID = txtbox_ProductID.Text;
                    string ProName = txtbox_ProductName.Text;

                    string insertquery = "INSERT INTO TBL_Products(ProID,ProName) VALUES (@ProID,@ProName)";
                    SqlCommand cmd = new SqlCommand(insertquery, myconn);
                    cmd.Parameters.AddWithValue("@ProID", ProID);
                    cmd.Parameters.AddWithValue("@ProName", ProName);
                    cmd.ExecuteNonQuery();
                    myconn.Close();

                    MessageBox.Show("New Product Saved...");
                    // Fill the data grid again
                    fillGrid();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
        }

        public void fillGrid()
        {
            // FIll the data gridview from Database
            SqlConnection myconn = sql_Connection.GetConn();
            myconn.Open();
            da = new SqlDataAdapter("select * from TBL_Products order by ProID asc", myconn);
            myconn.Close();
            SqlCommandBuilder cd = new SqlCommandBuilder(da);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
