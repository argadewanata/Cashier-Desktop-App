using System.Data.SqlClient;
using System.Data;

namespace Cashier_Dekstop_App
{
    public partial class LoginForm : Form
    {
        private SqlCommand sql_command;
        private SqlDataAdapter sql_adapter;
        private SqlDataReader sql_reader;
        private DataSet sql_dataset;

        koneksi sql_Connection = new koneksi();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            SqlDataReader reader = null;
            SqlConnection myconn = sql_Connection.GetConn();

            myconn.Open();
            sql_command = new SqlCommand("select * from TBL_Employee where Name='" + txtbox_Username.Text
                + "' and Password='" + txtbox_Password.Text + "'", myconn);
            sql_command.ExecuteNonQuery();
            reader = sql_command.ExecuteReader();
            if (reader.Read())
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username Not Found");
            }
        }
    }
}