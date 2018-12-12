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
    public partial class Form1 : Form
    {
        public static bool goodConn;
        public static String connString;
        private SqlConnection conn;
        public Form1()
        {
            InitializeComponent();
            ConnectWindow cw = new ConnectWindow();
            cw.Show();
            txtResult.Multiline = true;
            txtResult.ScrollBars = ScrollBars.Horizontal;
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectWindow cw = new ConnectWindow();
            cw.Show();
        }

        public void getSchema()
        {
            conn = new SqlConnection(connString);
            //SqlCommand getTableSchema = new SqlCommand("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES");
            conn.Open();
            DataTable dtSchema = conn.GetSchema("Columns");
            DataTable dtTables = conn.GetSchema("Tables");
            conn.Close();
            grdMain.DataSource = dtSchema;
            cmbTables.DataSource = dtTables;
            cmbTables.DisplayMember = "TABLE_NAME";
        }

        private void schemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (goodConn)
            {
                getSchema();
            }
            else
            {
                MessageBox.Show("Select a valid database first.");
            }
        }

        private void getData_Click(object sender, EventArgs e)
        {
            if (goodConn)
            {
                getSchema();
                lblCurrentDb.Text = conn.Database;
            }
            else
            {
                MessageBox.Show("Select a valid database first.");
            }
        }
        private void currentConnectionStringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(connString);
        }

        private void getInsert_Click(object sender, EventArgs e)
        {
            String statement = "SqlCommand " + txtCmdName.Text + " = new SqlCommand(\"INSERT INTO " + cmbTables.Text + " (";
            SqlCommand getTableFields = new SqlCommand("SELECT * FROM sys.columns WHERE object_id = object_id(@tblname) AND is_identity = 0", conn);
            getTableFields.Parameters.AddWithValue("@tblname", cmbTables.Text);
            DataTable dtTF = new DataTable();
            SqlDataAdapter daTF = new SqlDataAdapter(getTableFields);

            conn.Open();
            daTF.Fill(dtTF);
            conn.Close();

            for(int i = 0; i < dtTF.Rows.Count; i++)
            {
                statement += dtTF.Rows[i][1] + ", ";
            }
            statement = statement.Substring(0, statement.Length - 2) + ") VALUES (";

            for(int i = 0; i < dtTF.Rows.Count; i++)
            {
                statement += "@" + ((string)dtTF.Rows[i][1]).ToLower() + ", ";
            }
            statement = statement.Substring(0, statement.Length - 2) + ")\", "+ txtConnName.Text + ");\r\n";

            for (int i = 0; i < dtTF.Rows.Count; i++)
            {
                statement += txtCmdName.Text + ".Parameters.AddWithValue(\"@" + ((string)dtTF.Rows[i][1]).ToLower() + "\", <paramName>);\r\n";
            }

            //MessageBox.Show(statement);
            txtResult.Text = statement;
        }
        private void btnLoadTable_Click(object sender, EventArgs e)
        {
            if (goodConn)
            {
                SqlCommand getColumns = new SqlCommand("SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = @tblname", conn);
                getColumns.Parameters.AddWithValue("@tblname", cmbTables.Text);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(getColumns);

                conn.Open();
                da.Fill(dt);
                conn.Close();

                grdMain.DataSource = dt;
                grdMain.Refresh();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String statement = "SqlCommand " + txtCmdName.Text + " = new SqlCommand(\"UPDATE " + cmbTables.Text + " SET ";
            SqlCommand getTableFields = new SqlCommand("SELECT * FROM sys.columns WHERE object_id = object_id(@tblname) AND is_identity = 0", conn);
            getTableFields.Parameters.AddWithValue("@tblname", cmbTables.Text);
            DataTable dtTF = new DataTable();
            SqlDataAdapter daTF = new SqlDataAdapter(getTableFields);

            conn.Open();
            daTF.Fill(dtTF);
            conn.Close();

            for(int i = 0; i < dtTF.Rows.Count; i++)
            {
                statement += dtTF.Rows[i][1] + " = " + "@" + ((string)dtTF.Rows[i][1]).ToLower() + ", ";
            }
            statement = statement.Substring(0, statement.Length - 2) + " WHERE " + txtConditions.Text + "\", " + txtConnName.Text + ");\r\n";

            for (int i = 0; i < dtTF.Rows.Count; i++)
            {
                statement += txtCmdName.Text + ".Parameters.AddWithValue(\"@" + ((string)dtTF.Rows[i][1]).ToLower() + "\", <paramName>);\r\n";
            }

            txtResult.Text = statement;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtResult.Text);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
