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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=eBA;Integrated Security=True");
        SqlCommand query = new SqlCommand();
        DataTable table = new DataTable();
        DataSet ds = new DataSet();
        public void VisibleText()
        {
            txtCargoId.Visible = false; label1.Visible = false;
            txtSenderName.Visible = false; label2.Visible = false;
            txtReceiverName.Visible = false; label3.Visible = false;
            txtSenderPhone.Visible = false; label4.Visible = false;
            txtReceiverPhone.Visible = false; label5.Visible = false;
        }
        public void FiilDataGrid()
        {
            connection.Open();
            DataSet dtst = new DataSet();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT * FROM tbl_CargoTracking ", connection);
            adtr.Fill(dtst, "tbl_CargoTracking");
            dataGridView1.DataSource = dtst.Tables["tbl_CargoTracking"];
            adtr.Dispose();
            connection.Close();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            table.Clear();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT * FROM tbl_CargoTracking WHERE cargoId LIKE '%" + txtCargoId.Text + "%'", connection);
            adtr.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            table.Clear();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT * FROM tbl_CargoTracking WHERE senderName LIKE '%" + txtSenderName.Text + "%'", connection);
            adtr.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            table.Clear();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT * FROM tbl_CargoTracking WHERE receiverName LIKE '%" + txtReceiverName.Text + "%'", connection);
            adtr.Fill(table);
            dataGridView1.DataSource = table;
        }
        private void txtReceiverPhone_TextChanged(object sender, EventArgs e)
        {
            table.Clear();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT * FROM tbl_CargoTracking WHERE receiverPhone LIKE '%" + txtReceiverPhone.Text + "%'", connection);
            adtr.Fill(table);
            dataGridView1.DataSource = table;

        }
        private void txtSenderPhone_TextChanged(object sender, EventArgs e)
        {
            table.Clear();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT * FROM tbl_CargoTracking WHERE senderPhone LIKE '%" + txtSenderPhone.Text + "%'", connection);
            adtr.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void Search_Load(object sender, EventArgs e)
        {
            FiilDataGrid();
            VisibleText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            this.Hide();
            homePage.Show();
        }

        private void cbCargoId_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCargoId.Checked == true)
            {
                txtCargoId.Visible = true;
                label1.Visible = true;
            }
            else
            {
                txtCargoId.Visible = false;
                txtCargoId.Text = string.Empty;
                label1.Visible = false;
            }
        }

        private void cbSenderPhone_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSenderPhone.Checked == true)
            {
                txtSenderPhone.Visible = true;
                label4.Visible = true;
            }
            else
            {
                txtSenderPhone.Visible = false;
                label4.Visible = false;
                txtReceiverPhone.Text = string.Empty;
            }
        }

        private void cbReceiverPhone_CheckedChanged(object sender, EventArgs e)
        {
            if (cbReceiverPhone.Checked == true)
            {
                txtReceiverPhone.Visible = true;
                label5.Visible = true;
            }
            else
            {
                txtReceiverPhone.Visible = false;
                label5.Visible = false;
                txtReceiverPhone.Text = string.Empty;
            }
        }

        private void cbSenderName_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSenderName.Checked == true)
            {
                txtSenderName.Visible = true;
                label2.Visible = true;
            }
            else
            {
                txtSenderName.Visible = false;
                label2.Visible = false;
                txtSenderName.Text = string.Empty;
            }
        }

        private void cbReceiverName_CheckedChanged(object sender, EventArgs e)
        {
            if (cbReceiverName.Checked == true)
            {
                txtReceiverName.Visible = true;
                label3.Visible = true;
            }
            else
            {
                txtReceiverName.Visible = false;
                label3.Visible = false;
                txtReceiverName.Text = string.Empty;
            }
        }

    }
}
