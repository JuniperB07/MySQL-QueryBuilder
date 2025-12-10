namespace MySQL_QueryBuilder
{
    partial class MAIN
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MAIN));
            mnuMenu = new MenuStrip();
            mnuServer = new ToolStripMenuItem();
            mnuConnectToServer = new ToolStripMenuItem();
            mnuNewConnection = new ToolStripMenuItem();
            mnuRefreshConnection = new ToolStripMenuItem();
            mnuDisconnect = new ToolStripMenuItem();
            mnuAbout = new ToolStripMenuItem();
            mnu = new ToolStripMenuItem();
            developerToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            lblConnectionStatus = new Label();
            label1 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnManualBuilder = new Button();
            btnExpressBuilder = new Button();
            mnuMenu.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // mnuMenu
            // 
            mnuMenu.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mnuMenu.ImageScalingSize = new Size(20, 20);
            mnuMenu.Items.AddRange(new ToolStripItem[] { mnuServer, mnuAbout });
            mnuMenu.Location = new Point(0, 0);
            mnuMenu.Name = "mnuMenu";
            mnuMenu.Size = new Size(586, 29);
            mnuMenu.TabIndex = 0;
            mnuMenu.Text = "menuStrip1";
            // 
            // mnuServer
            // 
            mnuServer.DropDownItems.AddRange(new ToolStripItem[] { mnuConnectToServer, mnuDisconnect });
            mnuServer.Name = "mnuServer";
            mnuServer.Size = new Size(75, 25);
            mnuServer.Text = "Server";
            // 
            // mnuConnectToServer
            // 
            mnuConnectToServer.DropDownItems.AddRange(new ToolStripItem[] { mnuNewConnection, mnuRefreshConnection });
            mnuConnectToServer.Name = "mnuConnectToServer";
            mnuConnectToServer.Size = new Size(248, 26);
            mnuConnectToServer.Text = "Connect To Server";
            // 
            // mnuNewConnection
            // 
            mnuNewConnection.Name = "mnuNewConnection";
            mnuNewConnection.ShortcutKeys = Keys.Control | Keys.N;
            mnuNewConnection.Size = new Size(298, 26);
            mnuNewConnection.Text = "New Connection";
            mnuNewConnection.Click += mnuNewConnection_Click;
            // 
            // mnuRefreshConnection
            // 
            mnuRefreshConnection.Name = "mnuRefreshConnection";
            mnuRefreshConnection.ShortcutKeys = Keys.F5;
            mnuRefreshConnection.Size = new Size(298, 26);
            mnuRefreshConnection.Text = "Refresh Connection";
            mnuRefreshConnection.Click += mnuRefreshConnection_Click;
            // 
            // mnuDisconnect
            // 
            mnuDisconnect.Name = "mnuDisconnect";
            mnuDisconnect.ShortcutKeys = Keys.Control | Keys.X;
            mnuDisconnect.Size = new Size(248, 26);
            mnuDisconnect.Text = "Disconnect";
            mnuDisconnect.Click += mnuDisconnect_Click;
            // 
            // mnuAbout
            // 
            mnuAbout.DropDownItems.AddRange(new ToolStripItem[] { mnu, developerToolStripMenuItem });
            mnuAbout.Name = "mnuAbout";
            mnuAbout.Size = new Size(77, 25);
            mnuAbout.Text = "About";
            // 
            // mnu
            // 
            mnu.Name = "mnu";
            mnu.Size = new Size(263, 26);
            mnu.Text = "MySQL Query Builder";
            // 
            // developerToolStripMenuItem
            // 
            developerToolStripMenuItem.Name = "developerToolStripMenuItem";
            developerToolStripMenuItem.Size = new Size(263, 26);
            developerToolStripMenuItem.Text = "The Developer";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 29);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 430F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(586, 556);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.MySQL_QB_LOGO_TRANSPARENT;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(580, 424);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58.8868942F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.1131058F));
            tableLayoutPanel2.Controls.Add(lblConnectionStatus, 1, 0);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 433);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(580, 38);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // lblConnectionStatus
            // 
            lblConnectionStatus.AutoSize = true;
            lblConnectionStatus.Dock = DockStyle.Fill;
            lblConnectionStatus.Font = new Font("Consolas", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConnectionStatus.ForeColor = Color.Red;
            lblConnectionStatus.Location = new Point(344, 0);
            lblConnectionStatus.Name = "lblConnectionStatus";
            lblConnectionStatus.Size = new Size(233, 38);
            lblConnectionStatus.TabIndex = 1;
            lblConnectionStatus.Text = "STATUS";
            lblConnectionStatus.TextAlign = ContentAlignment.MiddleLeft;
            lblConnectionStatus.TextChanged += lblConnectionStatus_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(335, 38);
            label1.TabIndex = 0;
            label1.Text = "Connection Status:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(btnManualBuilder, 2, 0);
            tableLayoutPanel3.Controls.Add(btnExpressBuilder, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 487);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(580, 66);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // btnManualBuilder
            // 
            btnManualBuilder.BackColor = Color.DarkBlue;
            btnManualBuilder.Dock = DockStyle.Fill;
            btnManualBuilder.FlatAppearance.BorderSize = 0;
            btnManualBuilder.FlatStyle = FlatStyle.Flat;
            btnManualBuilder.Font = new Font("Century Gothic", 18F, FontStyle.Bold | FontStyle.Underline);
            btnManualBuilder.ForeColor = Color.White;
            btnManualBuilder.Location = new Point(298, 3);
            btnManualBuilder.Name = "btnManualBuilder";
            btnManualBuilder.Size = new Size(279, 60);
            btnManualBuilder.TabIndex = 1;
            btnManualBuilder.Text = "MANUAL BUILDER";
            btnManualBuilder.UseVisualStyleBackColor = false;
            btnManualBuilder.Click += btnManualBuilder_Click;
            // 
            // btnExpressBuilder
            // 
            btnExpressBuilder.BackColor = Color.DarkGreen;
            btnExpressBuilder.Dock = DockStyle.Fill;
            btnExpressBuilder.FlatAppearance.BorderSize = 0;
            btnExpressBuilder.FlatStyle = FlatStyle.Flat;
            btnExpressBuilder.Font = new Font("Century Gothic", 18F, FontStyle.Bold | FontStyle.Underline);
            btnExpressBuilder.ForeColor = Color.White;
            btnExpressBuilder.Location = new Point(3, 3);
            btnExpressBuilder.Name = "btnExpressBuilder";
            btnExpressBuilder.Size = new Size(279, 60);
            btnExpressBuilder.TabIndex = 0;
            btnExpressBuilder.Text = "EXPRESS BUILDER";
            btnExpressBuilder.UseVisualStyleBackColor = false;
            // 
            // MAIN
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(586, 585);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(mnuMenu);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "MAIN";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MySQL QueryBuilder";
            Load += MAIN_Load;
            mnuMenu.ResumeLayout(false);
            mnuMenu.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuMenu;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private ToolStripMenuItem mnuServer;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lblConnectionStatus;
        private Label label1;
        private ToolStripMenuItem mnuConnectToServer;
        private ToolStripMenuItem mnuNewConnection;
        private ToolStripMenuItem mnuRefreshConnection;
        private ToolStripMenuItem mnuDisconnect;
        private ToolStripMenuItem mnuAbout;
        private ToolStripMenuItem mnu;
        private ToolStripMenuItem developerToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnManualBuilder;
        private Button btnExpressBuilder;
    }
}
