using JunX.NETStandard.MySQL;

namespace MySQL_QueryBuilder
{
    public partial class MAIN : Form
    {
        public MAIN()
        {
            InitializeComponent();
        }

        private void MAIN_Load(object sender, EventArgs e)
        {
            lblConnectionStatus.Text = "";
            if (QB.ConnStatus)
                lblConnectionStatus.Text = "CONNECTED";
            else
                lblConnectionStatus.Text = "DISCONNECTED";
        }

        private void mnuNewConnection_Click(object sender, EventArgs e)
        {
            bool connStat = false;

            Hide();
            Server.NewConnection NC = new Server.NewConnection();
            NC.ShowDialog();

            QB.DBC = new DBConnect(QB.ConnSTR);

            try
            {
                QB.DBC.Open(out connStat);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"An error occurred while trying to establish connection to database." +
                    $"\nMessage:\n{ex.Message.ToString()}", QB.MBOX_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Error);
                connStat = false;
            }
            Show();

            QB.ConnStatus = connStat;

            lblConnectionStatus.Text = "";
            if (QB.ConnStatus)
                lblConnectionStatus.Text = "CONNECTED";
            else
                lblConnectionStatus.Text = "DISCONNECTED";
        }

        private void lblConnectionStatus_TextChanged(object sender, EventArgs e)
        {
            if (QB.ConnStatus)
                lblConnectionStatus.ForeColor = Color.Green;
            else
                lblConnectionStatus.ForeColor = Color.Red;
        }
    }
}
