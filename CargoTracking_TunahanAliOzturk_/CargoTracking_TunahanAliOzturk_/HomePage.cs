using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CargoTracking_TunahanAliOzturk_
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btnSending_Click(object sender, EventArgs e)
        {
            SendingCargo sendingCargo = new SendingCargo();
            this.Hide();
            sendingCargo.Show();
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            UpdateStatus updateStatus = new UpdateStatus();
            this.Hide();
            updateStatus.Show();
        }

        private void btnTaking_Click(object sender, EventArgs e)
        {
            TakingCargo takingCargo = new TakingCargo();
            this.Hide();
            takingCargo.ShowDialog();

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            this.Hide();
            frm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            int answer;
            answer = Convert.ToInt32(MessageBox.Show
                ("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2));
            if (answer == 6)
                Application.Exit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteCargo deleteCargo = new DeleteCargo();
            this.Hide();
            deleteCargo.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            this.Hide();
            search.Show();
        }
    }
}
