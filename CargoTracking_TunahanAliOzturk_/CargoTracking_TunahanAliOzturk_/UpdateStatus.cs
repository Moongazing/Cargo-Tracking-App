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
using System.Data.Sql;

namespace CargoTracking_TunahanAliOzturk_
{
    public partial class UpdateStatus : Form
    {
        public UpdateStatus()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=eBA;Integrated Security=True");
        SqlCommand query = new SqlCommand();
       

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtCargoId.Text) || string.IsNullOrEmpty(txtStatus.Text))
            {
                MessageBox.Show("Can't be blank!", "!");
                return;
            }
            else
            { 
                    connection.Open();
                    query.Connection = connection;
                    query.CommandType = CommandType.StoredProcedure;
                    query.CommandText = "SP_UpdateStatus";
                    query.Parameters.Add("cargoId", SqlDbType.NVarChar, 50).Value = txtCargoId.Text;
                    query.Parameters.Add("cargoStatus", SqlDbType.NVarChar, 50).Value = txtStatus.Text;
                    query.ExecuteNonQuery();
                    connection.Close();
                    txtStatus.Text = string.Empty;
                    txtCargoId.Text = string.Empty;
                    MessageBox.Show("Cargo status been update!");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            this.Hide();
            homePage.Show();
        }
    }
}
