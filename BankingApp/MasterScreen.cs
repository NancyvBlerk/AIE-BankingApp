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

namespace BankingApp
{   
    public partial class MasterScreen : Form
    {
        SqlConnection con = new SqlConnection
          (@"Data Source=DESKTOP-53IRMN3;Initial Catalog=BankingApp;Integrated Security=True");
        public MasterScreen()
        {
            InitializeComponent();
            labusername.Text = Banking.username;
        }
        private void butLogout_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();

        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            Withdrawal WD = new Withdrawal();
            WD.Show();
            this.Hide();
        }

        private void btnCB_Click(object sender, EventArgs e)
        {
            Balance CB = new Balance();
            CB.Show();
            this.Hide();
        }
    }
}
