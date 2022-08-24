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
    public partial class DeleteCargo : Form
    {
        public DeleteCargo()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=eBA;Integrated Security=True");
        SqlCommand query = new SqlCommand();
        SqlCommand queryDeleting = new SqlCommand();
        SqlCommand queryUpdate = new SqlCommand();

        public void ClearText()
        {
            label19.Text = "0000";
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }

            }
        }
        public void FiilDataGrid()
        {
            connection.Open();
            DataSet dtst = new DataSet();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT * FROM tbl_cargoTrackingTrash ", connection);
            adtr.Fill(dtst, "tbl_cargoTrackingTrash");
            dataGridView1.DataSource = dtst.Tables["tbl_cargoTrackingTrash"];
            adtr.Dispose();
            connection.Close();
        }

        private void DeleteCargo_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            FiilDataGrid();
            this.AutoScroll = true;
            this.HorizontalScroll.Enabled = true;
            this.HorizontalScroll.Visible = true;
            this.VerticalScroll.Enabled = true;
            this.VerticalScroll.Visible = true;

        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            string get = txtGetCargoId.Text;
            if (string.IsNullOrEmpty(txtGetCargoId.Text))
            {
                MessageBox.Show("Can't be blank on cargo id!");
                return;
            }
            else
            {
                connection.Open();
                query.Connection = connection;
                query.CommandText = "SELECT * FROM tbl_cargoTracking WHERE cargoId='" + txtGetCargoId.Text + "'";
                SqlDataReader dr = query.ExecuteReader();
                
                if(dr.Read())
                {
                    //fiil the textbox with pk
                    txtSenderName.Text = dr["senderName"].ToString();
                    txtSenderSurname.Text = dr["senderSurname"].ToString();
                    txtSenderNumber.Text = dr["senderPhone"].ToString();
                    txtSenderAddress.Text = dr["senderAddress"].ToString();
                    txtReceiverName.Text = dr["receiverName"].ToString();
                    txtReceiverSurname.Text = dr["receiverSurname"].ToString();
                    txtReceiverNumber.Text = dr["receiverPhone"].ToString();
                    txtReceiverAddress.Text = dr["receiverAddress"].ToString();
                    txtCargoCm.Text = dr["cargoCm"].ToString();
                    txtCargoKg.Text = dr["cargoKg"].ToString();
                    txtCargoStatus.Text = dr["cargoStatus"].ToString();
                    txtCargoId.Text = dr["cargoId"].ToString();
                    label19.Text = dr["amount"].ToString();
                    txtDate.Text = dr["date"].ToString();
                    
                    btnDelete.Enabled = true;
                    connection.Close();
                    
                }
                else
                {
                    MessageBox.Show("Check cargo id!");
                    connection.Close();

                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Adding cargo to tbl_CargoTrackingTrash so we can check the deleted cargos
            if(cbTrash.Checked==true)
            { 
                connection.Open();
                query.Connection = connection;
                query.CommandType = CommandType.StoredProcedure;
                query.CommandText = "SP_TRASH";
                query.Parameters.Add("cargoId", SqlDbType.NVarChar, 50).Value = txtCargoId.Text;
                query.Parameters.Add("cargoStatus", SqlDbType.NVarChar, 50).Value = txtCargoStatus.Text;
                query.Parameters.Add("cargoCm", SqlDbType.Float).Value = txtCargoCm.Text;
                query.Parameters.Add("cargoKg", SqlDbType.Float).Value = txtCargoKg.Text;
                query.Parameters.Add("amount", SqlDbType.Float).Value = label19.Text;
                query.Parameters.Add("senderName", SqlDbType.NVarChar, 50).Value = txtSenderName.Text;
                query.Parameters.Add("senderSurname", SqlDbType.NVarChar, 50).Value = txtSenderSurname.Text;
                query.Parameters.Add("senderPhone", SqlDbType.NVarChar, 50).Value = txtSenderNumber.Text;
                query.Parameters.Add("senderAdress", SqlDbType.NVarChar, 50).Value = txtSenderAddress.Text;
                query.Parameters.Add("receiverName", SqlDbType.NVarChar, 50).Value = txtReceiverName.Text;
                query.Parameters.Add("receiverSurname", SqlDbType.NVarChar, 50).Value = txtReceiverSurname.Text;
                query.Parameters.Add("receiverPhone", SqlDbType.NVarChar, 50).Value = txtReceiverNumber.Text;
                query.Parameters.Add("receiverAddress", SqlDbType.NVarChar, 50).Value = txtReceiverAddress.Text;
                query.Parameters.Add("date", SqlDbType.DateTime).Value = Convert.ToDateTime(txtDate.Text);
                query.Parameters.Add("deletingDate", SqlDbType.DateTime).Value = DateTime.Now.ToString();
                query.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Cargo added trash!");
                ClearText();

            }
            

            
            //Update Cargo Status
            connection.Open();
            queryUpdate.CommandType = CommandType.StoredProcedure;
            queryUpdate.CommandText = "SP_UPDATESTATUSDELETING";
            queryUpdate.Parameters.Add("cargoId", SqlDbType.NVarChar, 50).Value = txtCargoId.Text;
            query.ExecuteNonQuery();
            connection.Close();


            //Deleting cargo 
            connection.Open();
            queryDeleting.Connection = connection;
            queryDeleting.CommandType = CommandType.StoredProcedure;
            queryDeleting.CommandText = "SP_DELETECARGO";
            queryDeleting.Parameters.Add("cargoId", SqlDbType.NVarChar, 50).Value = txtCargoId.Text;
            queryDeleting.ExecuteNonQuery();
            MessageBox.Show("Cargo deleted!");
            connection.Close();

            FiilDataGrid();
            btnDelete.Enabled = false;

            //}
            /* else
             {
                 MessageBox.Show("Can't found cargo id!");
                 connection.Close();
                 return;
             }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            this.Hide();
            homePage.Show();
        }

       
    }
}
