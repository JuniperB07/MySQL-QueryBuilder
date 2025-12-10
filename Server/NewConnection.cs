using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JunX.NET8.WinForms;
using MySql.Data.MySqlClient;

namespace MySQL_QueryBuilder.Server
{
    public partial class NewConnection : Form
    {
        ConnectionStringMetadata newCSM;
        MySqlConnection conn;
        string connSTR;

        public NewConnection()
        {
            InitializeComponent();
        }

        private void NewConnection_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void NewConnection_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void txtServer_TextChanged(object sender, EventArgs e)
        {
            newCSM.Server = txtServer.Text;
            txtConnectionSTR.Text = newCSM.ConnSTR;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            newCSM.User = txtUsername.Text;
            txtConnectionSTR.Text = newCSM.ConnSTR;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            newCSM.Password = txtPassword.Text;
            txtConnectionSTR.Text = newCSM.ConnSTR;
        }

        private void txtDatabase_TextChanged(object sender, EventArgs e)
        {
            newCSM.Database = txtDatabase.Text;
            txtConnectionSTR.Text = newCSM.ConnSTR;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            connSTR = txtConnectionSTR.Text;

            if (FormHelper.HasEmptyField([txtServer, txtUsername, txtDatabase]))
            {
                MessageBox.Show("Please fill all necessary fields.\nRequired fields are marked with an asterisk (*).", "MySQL QueryBuilder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                conn.ConnectionString = connSTR;
                conn.Open();

                MessageBox.Show("Connection successful!", "MySQL QueryBuilder", MessageBoxButtons.OK, MessageBoxIcon.Information);
                QB.ConnSTR = connSTR;
                QB.Database = newCSM.Database;
                QB.Server = newCSM.Server;
                Close();
            }
            catch(Exception ex)
            {
                txtErrors.Text = $"An error occured:\n {ex.Message.ToString()}";
            }
        }
    }
}
