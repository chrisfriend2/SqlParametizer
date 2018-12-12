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

namespace SqlCommandBuilder
{
    public partial class ConnectWindow : Form
    {
        public ConnectWindow()
        {
            InitializeComponent();
            this.Focus();
        }

        private void btnConenct_Click(object sender, EventArgs e)
        {
            String connectionString = "Server=" + txtServer.Text + "; Database=" + txtDatabase.Text + "; User Id=" + txtUsername.Text + "; Password=" + txtPassword.Text + ";";
            SqlConnection conn;

            try
            {
                conn = new SqlConnection(connectionString);
                SqlCommand testCmd = new SqlCommand("SELECT 1", conn);
                conn.Open();
                if((int)testCmd.ExecuteScalar() == 1)
                {
                    Form1.connString = connectionString;
                    Form1.goodConn = true;
                }
                else
                {
                    throw new Exception("Failed to connect to server");
                }
                this.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConnString_Click(object sender, EventArgs e)
        {
            String connectionString = txtConnString.Text;
            SqlConnection conn;
            try
            {
                conn = new SqlConnection(connectionString);
                SqlCommand testCmd = new SqlCommand("SELECT 1", conn);
                conn.Open();
                if ((int)testCmd.ExecuteScalar() == 1)
                {
                    Form1.connString = connectionString;
                    Form1.goodConn = true;
                }
                else
                {
                    throw new Exception("Failed to connect to server");
                }
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
