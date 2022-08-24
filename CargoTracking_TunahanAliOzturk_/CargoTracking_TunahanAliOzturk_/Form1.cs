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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=eBA;Integrated Security=True");
        SqlCommand query = new SqlCommand();
        SqlDataReader read;

        public string CreateCaptcha()
        {
            Random random = new Random();
            string letter = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZabcçdefgğhıijklmnoöprsştuüvyz0123456789+%&?=";
            string captcha = "";
            for (int i = 0; i < 8; i++)
            {
                captcha += letter[random.Next(letter.Length)];
            }
            return captcha;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUserName.Text) ||
               !string.IsNullOrEmpty(txtPassword.Text) ||
               !string.IsNullOrEmpty(txtCaptcha.Text))
            {
                connection.Open();
                query.Connection = connection;
                query.CommandText = ("SELECT * FROM tbl_Users WHERE userName='" + txtUserName.Text + "'AND userPassword='" + txtPassword.Text + "'");
                read = query.ExecuteReader();
                if (read.Read())
                {
                    if (txtCaptcha.Text == lblCaptcha.Text)
                    {
                        //user name=admin user password=123
                        HomePage homePage = new HomePage();
                        this.Hide();
                        homePage.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Bilgilerinizi Kontrol Edin!");
                    lblCaptcha.Text = CreateCaptcha();
                }
            }
            else
            {
                MessageBox.Show("Can't be blank.");
                lblCaptcha.Text = CreateCaptcha();
            }
            connection.Close();

        }

        private void Login_Load(object sender, EventArgs e)
        {

            lblCaptcha.Text = CreateCaptcha(); 
             txtPassword.UseSystemPasswordChar = true;
        }

        private void cbPassShowHide_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPassShowHide.Checked == false)
            {
                cbPassShowHide.Text = "Show";
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                cbPassShowHide.Text = "Hide";
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            int answer;
            answer = Convert.ToInt32(MessageBox.Show
                ("Are you sure you want to exit?", "ÇIKIŞ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2));
            if (answer == 6)
                Application.Exit();
        }
    }
}
