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
    public partial class SendingCargo : Form
    {
        public SendingCargo()
        {
            InitializeComponent();
        }


        SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=eBA;Integrated Security=True");
        SqlCommand query = new SqlCommand();
        SqlCommand queryCheckCargoId = new SqlCommand();
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
        public bool Calculate()
        {
            if (!string.IsNullOrEmpty(txtCargoCm.Text) && !string.IsNullOrEmpty(txtCargoKg.Text)) return true;
            else return false;   
        }
        public bool CheckText()
        {
            if (!string.IsNullOrEmpty(txtSenderName.Text) && !string.IsNullOrEmpty(txtSenderSurname.Text) &&
                !string.IsNullOrEmpty(txtSenderNumber.Text) && !string.IsNullOrEmpty(txtSenderAddress.Text) &&
                !string.IsNullOrEmpty(txtReceiverName.Text) && !string.IsNullOrEmpty(txtReceiverSurname.Text) &&
                !string.IsNullOrEmpty(txtReceiverNumber.Text) && !string.IsNullOrEmpty(txtReceiverAddress.Text) &&
                !string.IsNullOrEmpty(txtCargoId.Text) && !string.IsNullOrEmpty(txtCargoStatus.Text))
            {
                return true;
            }
            else
                return false;
             
        }
     

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckText() == true)
            {
                connection.Open();
                query.Connection = connection;
                query.CommandType = CommandType.StoredProcedure;
                query.CommandText = "SP_SendingCargo";
                
                
                    query.Parameters.Add("cargoId", SqlDbType.NVarChar, 50).Value = txtCargoId.Text;
                    query.Parameters.Add("cargoStatus", SqlDbType.NVarChar, 50).Value = txtCargoStatus.Text;
                    query.Parameters.Add("cargoCm", SqlDbType.Float).Value = txtCargoCm.Text;
                    query.Parameters.Add("cargoKg", SqlDbType.Float).Value = txtCargoKg.Text;
                    query.Parameters.Add("amount", SqlDbType.Float).Value = label19.Text;
                    query.Parameters.Add("senderName", SqlDbType.NVarChar, 50).Value = txtSenderName.Text;
                    query.Parameters.Add("senderSurname", SqlDbType.NVarChar, 50).Value = txtSenderSurname.Text;
                    query.Parameters.Add("senderPhone", SqlDbType.NVarChar, 50).Value = txtSenderNumber.Text;
                    query.Parameters.Add("senderAddress", SqlDbType.NVarChar, 50).Value = txtSenderAddress.Text;
                    query.Parameters.Add("receiverName", SqlDbType.NVarChar, 50).Value = txtReceiverName.Text;
                    query.Parameters.Add("receiverSurname", SqlDbType.NVarChar, 50).Value = txtReceiverSurname.Text;
                    query.Parameters.Add("receiverPhone", SqlDbType.NVarChar, 50).Value = txtReceiverNumber.Text;
                    query.Parameters.Add("receiverAddress", SqlDbType.NVarChar, 50).Value = txtReceiverAddress.Text;
                    query.Parameters.Add("date", SqlDbType.DateTime).Value = DateTime.Now.ToString();
                    query.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Cargo will be send!");
                    ClearText();


            }
            else if (CheckText() == false)
            {
                MessageBox.Show("Can't be blank.", "!");
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            if (Calculate() == true)
            {
                double cargoCm = Convert.ToDouble(txtCargoCm.Text);
                double cargoKg = Convert.ToDouble(txtCargoKg.Text);
                double amount = 0;
                if (cargoCm >= 50)
                    amount = 5 * (cargoKg + cargoCm);
                else if(cargoCm<=30)
                    amount = 3*(cargoKg + cargoCm);
                label19.Text = amount.ToString();
            }
            else if (Calculate() == false)
            {
                MessageBox.Show("Can't be blank!", "!");
                return;
            }
        }
        
        private void btnCargoIdCreate_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            string letter = "ABCDEFGHIJKLMNOPRSTYVZ1234567890";
            string cargoId = "";
            for (int i = 0; i < 8; i++)
            {
                cargoId += letter[random.Next(letter.Length)];
            }
            txtCargoId.Text = cargoId.PadLeft(4,'0');


        }

        private void SendingCargo_Load(object sender, EventArgs e)
        {
            txtCargoId.Enabled = false;
            this.AutoScroll = true;
            this.HorizontalScroll.Enabled = true;
            this.HorizontalScroll.Visible = true;
            this.VerticalScroll.Enabled = true;
            this.VerticalScroll.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            this.Hide();
            homePage.Show();
        }
    }
}
