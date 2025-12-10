using JunX.NETStandard.MySQL;
using JunX.NET8.WinForms;

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
            {
                lblConnectionStatus.Text = "CONNECTED";
                Forms.SetEnabled(ControlHelper<Button>.Extract(this, "btn"), true);
            }
            else
            {
                lblConnectionStatus.Text = "DISCONNECTED";
                Forms.SetEnabled(ControlHelper<Button>.Extract(this, "btn"), false);
            }
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
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while trying to establish connection to database." +
                    $"\nMessage:\n{ex.Message.ToString()}", QB.MBOX_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Error);
                connStat = false;
            }
            Show();

            QB.ConnStatus = connStat;

            lblConnectionStatus.Text = "";
            if (QB.ConnStatus)
            {
                lblConnectionStatus.Text = "CONNECTED";
                Forms.SetEnabled(ControlHelper<Button>.Extract(this, "btn"), true);
            }
            else
            {
                lblConnectionStatus.Text = "DISCONNECTED";
                Forms.SetEnabled(ControlHelper<Button>.Extract(this, "btn"), false);
            }
        }

        private void lblConnectionStatus_TextChanged(object sender, EventArgs e)
        {
            if (QB.ConnStatus)
                lblConnectionStatus.ForeColor = Color.Green;
            else
                lblConnectionStatus.ForeColor = Color.Red;
        }

        private void mnuRefreshConnection_Click(object sender, EventArgs e)
        {
            QB.ConnStatus = false;

            lblConnectionStatus.Text = "REFRESHING...";
            lblConnectionStatus.ForeColor = Color.Goldenrod;
            Forms.SetEnabled(ControlHelper<Button>.Extract(this, "btn"), false);

            QB.DBC.CloseConnection();
            QB.DBC.DisposeAsync();

            QB.DBC = new DBConnect(QB.ConnSTR);
            QB.DBC.Open(out bool stat);
            QB.ConnStatus = stat;

            lblConnectionStatus.Text = "";
            if (QB.ConnStatus)
            {
                lblConnectionStatus.Text = "CONNECTED";
                Forms.SetEnabled(ControlHelper<Button>.Extract(this, "btn"), true);
            }
            else
            {
                lblConnectionStatus.Text = "DISCONNECTED";
                Forms.SetEnabled(ControlHelper<Button>.Extract(this, "btn"), false);
            }
        }

        private void mnuDisconnect_Click(object sender, EventArgs e)
        {
            QB.DBC.CloseConnection();
            QB.DBC.DisposeAsync();

            QB.ConnSTR = "";
            QB.ConnStatus = false;

            lblConnectionStatus.Text = "";
            lblConnectionStatus.Text = "DISCONNECTED";
            Forms.SetEnabled(ControlHelper<Button>.Extract(this, "btn"), false);
        }
    }
}
