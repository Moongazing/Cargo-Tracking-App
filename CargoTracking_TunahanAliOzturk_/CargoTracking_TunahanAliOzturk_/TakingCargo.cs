using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace CargoTracking_TunahanAliOzturk_
{
    public partial class TakingCargo : Form
    {
        public TakingCargo()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=eBA;Integrated Security=True");
        SqlCommand query = new SqlCommand();
        SqlCommand queryUpdate=new SqlCommand();

        private void btnInformation_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtCargoId.Text))
            {
                MessageBox.Show("Can't be blank on cargo id!");
                return;
            }
            connection.Open();
            query.Connection = connection;
            query.CommandType = CommandType.StoredProcedure;
            query.CommandText = "SP_TAKECARGO";
            query.Parameters.Add("cargoId", SqlDbType.NVarChar, 50).Value = txtCargoId.Text;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCargoId.Text) || string.IsNullOrEmpty(txtStatus.Text))
            {
                MessageBox.Show("Can't be blank!", "!");
                return;
            }
            else
            {
                connection.Open();
                queryUpdate.Connection = connection;
                queryUpdate.CommandType = CommandType.StoredProcedure;
                queryUpdate.CommandText = "SP_UpdateStatus";
                queryUpdate.Parameters.Add("cargoId", SqlDbType.NVarChar, 50).Value = txtCargoId.Text;
                queryUpdate.Parameters.Add("cargoStatus", SqlDbType.NVarChar, 50).Value = txtStatus.Text;
                queryUpdate.ExecuteNonQuery();
                connection.Close();
                txtStatus.Text = string.Empty;
                txtCargoId.Text = string.Empty;
                MessageBox.Show("Cargo status been update!");
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(query);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                connection.Close();
            }
        }

        private void TakingCargo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            this.Close();
            homePage.Show();
        }
    }
}
