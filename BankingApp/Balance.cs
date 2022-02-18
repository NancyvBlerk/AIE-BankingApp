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
    public partial class Balance : Form
    {
        SqlConnection connect = new SqlConnection
           (@"Data Source=DESKTOP-CD26AIV\SQLEXPRESS;Initial Catalog=BankingApp;Integrated Security=True");
        public Balance()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
                Banking bank = new Banking();
                connect.Open();

            string query = "Select * from UserInformation where Username = " + "'" + (Banking.username) + "'";

            SqlCommand cmd = new SqlCommand(query, connect);
            SqlDataReader DR = cmd.ExecuteReader();

            DataTable Dtable = new DataTable();
            SqlDataAdapter DAdap = new SqlDataAdapter(cmd);

            dataGridView1.DataSource = Dtable;

            connect.Close();

        }
    }
}
