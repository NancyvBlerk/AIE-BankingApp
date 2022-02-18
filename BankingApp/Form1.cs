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
    public partial class Form1 : Form
    {
        SqlConnection connect = new SqlConnection
            (@"Data Source=DESKTOP-53IRMN3;Initial Catalog=BankingApp;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }
            private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();

                var query = "Select * from UserInformation where Username = @username and UserPassword = @password";
                var command = new SqlCommand(query, connect);
                command.Parameters.AddWithValue("@username", txtUsername.Text);
                command.Parameters.AddWithValue("@password", txtPassword.Text);

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable DT = new DataTable();
                da.Fill(DT);

                if (DT.Rows.Count == 1)
                {
                    Banking.username = txtUsername.Text;
                    MasterScreen MS = new MasterScreen();
                    MS.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Username or password is incorrect");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.UseSystemPasswordChar = true;
                var checkbox = (CheckBox)sender;
                checkbox.Text = "view";
            }
            else 
            {
                txtPassword.UseSystemPasswordChar = true;
                var checkbox = (CheckBox)sender;
                checkbox.Text = "Hide";
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
