using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySQL_QueryBuilder.ManualBuilder
{
    public partial class ManualBuilder : Form
    {
        public ManualBuilder()
        {
            InitializeComponent();
        }

        private void ManualBuilder_Load(object sender, EventArgs e)
        {
            lblServerDatabase.Text = $"Current Server: {QB.Server}; Current Database: {QB.Database};";
            txtQuery.Text = "";
            rtxtNotifs.Text = "";
            dgvResults.DataSource = null;
        }

        private void ManualBuilder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnClear.PerformClick();
            else if (e.KeyCode == Keys.F5)
                btnExecute.PerformClick();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ManualBuilder_Load(this, EventArgs.Empty);
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtQuery.Text))
            {
                MessageBox.Show("Query field cannot be empty.", QB.MBOX_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            rtxtNotifs.Text = "Executing query...";

            QB.DBC.CommandText = txtQuery.Text;
            dgvResults.DataSource = null;

            try
            {
                if(QB.DBC.CommandText.Contains("SELECT", StringComparison.OrdinalIgnoreCase))
                {
                    QB.DBC.ExecuteDataSet();
                    dgvResults.DataSource = QB.DBC.DataSet.Tables[0];
                }
                else
                    QB.DBC.ExecuteNonQuery();

                rtxtNotifs.Text = "Query execution successful!";
            }
            catch(Exception ex)
            {
                dgvResults.DataSource = null;
                rtxtNotifs.Text = ex.Message;
            }
        }
    }
}
