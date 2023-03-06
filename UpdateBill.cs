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
    }
}
