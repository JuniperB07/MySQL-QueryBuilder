namespace MySQL_QueryBuilder.Server
{
    partial class NewConnection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewConnection));
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            txtDatabase = new TextBox();
            label5 = new Label();
            label2 = new Label();
            labelll = new Label();
            label4 = new Label();
            txtServer = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            txtErrors = new TextBox();
            txtConnectionSTR = new TextBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            btnConnect = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 47.8971977F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 52.1028023F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tableLayoutPanel1.Size = new Size(545, 522);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(539, 43);
            label1.TabIndex = 0;
            label1.Text = "CONNECT TO SERVER && DATABASE";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel2.Controls.Add(txtDatabase, 2, 7);
            tableLayoutPanel2.Controls.Add(label5, 0, 7);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(labelll, 0, 3);
            tableLayoutPanel2.Controls.Add(label4, 0, 5);
            tableLayoutPanel2.Controls.Add(txtServer, 2, 1);
            tableLayoutPanel2.Controls.Add(txtUsername, 2, 3);
            tableLayoutPanel2.Controls.Add(txtPassword, 2, 5);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 46);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 9;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel2.Size = new Size(539, 196);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // txtDatabase
            // 
            txtDatabase.BorderStyle = BorderStyle.FixedSingle;
            txtDatabase.Dock = DockStyle.Fill;
            txtDatabase.Location = new Point(224, 151);
            txtDatabase.Name = "txtDatabase";
            txtDatabase.Size = new Size(312, 32);
            txtDatabase.TabIndex = 7;
            txtDatabase.TextChanged += txtDatabase_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Right;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label5.Location = new Point(89, 148);
            label5.Name = "label5";
            label5.Size = new Size(119, 36);
            label5.TabIndex = 6;
            label5.Text = "*Database:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Right;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label2.Location = new Point(124, 10);
            label2.Name = "label2";
            label2.Size = new Size(84, 36);
            label2.TabIndex = 0;
            label2.Text = "*Server:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelll
            // 
            labelll.AutoSize = true;
            labelll.Dock = DockStyle.Right;
            labelll.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            labelll.Location = new Point(85, 56);
            labelll.Name = "labelll";
            labelll.Size = new Size(123, 36);
            labelll.TabIndex = 1;
            labelll.Text = "*Username:";
            labelll.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Right;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label4.Location = new Point(102, 102);
            label4.Name = "label4";
            label4.Size = new Size(106, 36);
            label4.TabIndex = 2;
            label4.Text = "Password:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtServer
            // 
            txtServer.BorderStyle = BorderStyle.FixedSingle;
            txtServer.Dock = DockStyle.Fill;
            txtServer.Location = new Point(224, 13);
            txtServer.Name = "txtServer";
            txtServer.Size = new Size(312, 32);
            txtServer.TabIndex = 3;
            txtServer.TextChanged += txtServer_TextChanged;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Dock = DockStyle.Fill;
            txtUsername.Location = new Point(224, 59);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(312, 32);
            txtUsername.TabIndex = 4;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Dock = DockStyle.Fill;
            txtPassword.Location = new Point(224, 105);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(312, 32);
            txtPassword.TabIndex = 5;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(txtErrors, 0, 1);
            tableLayoutPanel3.Controls.Add(txtConnectionSTR, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 248);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 67.765564F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 32.2344322F));
            tableLayoutPanel3.Size = new Size(539, 214);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // txtErrors
            // 
            txtErrors.BorderStyle = BorderStyle.FixedSingle;
            txtErrors.Dock = DockStyle.Fill;
            txtErrors.Font = new Font("Consolas", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtErrors.ForeColor = Color.Red;
            txtErrors.Location = new Point(3, 148);
            txtErrors.Multiline = true;
            txtErrors.Name = "txtErrors";
            txtErrors.PlaceholderText = "Errors";
            txtErrors.ReadOnly = true;
            txtErrors.Size = new Size(533, 63);
            txtErrors.TabIndex = 1;
            // 
            // txtConnectionSTR
            // 
            txtConnectionSTR.BorderStyle = BorderStyle.FixedSingle;
            txtConnectionSTR.Dock = DockStyle.Fill;
            txtConnectionSTR.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConnectionSTR.Location = new Point(3, 3);
            txtConnectionSTR.Multiline = true;
            txtConnectionSTR.Name = "txtConnectionSTR";
            txtConnectionSTR.PlaceholderText = "Connection string...";
            txtConnectionSTR.Size = new Size(533, 139);
            txtConnectionSTR.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel4.Controls.Add(btnConnect, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 468);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(539, 51);
            tableLayoutPanel4.TabIndex = 3;
            // 
            // btnConnect
            // 
            btnConnect.BackColor = Color.DarkGreen;
            btnConnect.Dock = DockStyle.Fill;
            btnConnect.FlatAppearance.BorderSize = 0;
            btnConnect.FlatStyle = FlatStyle.Flat;
            btnConnect.Font = new Font("Century Gothic", 14F, FontStyle.Bold | FontStyle.Underline);
            btnConnect.ForeColor = Color.White;
            btnConnect.Location = new Point(164, 3);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(209, 45);
            btnConnect.TabIndex = 1;
            btnConnect.Text = "CONNECT";
            btnConnect.UseVisualStyleBackColor = false;
            btnConnect.Click += btnConnect_Click;
            // 
            // NewConnection
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(545, 522);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "NewConnection";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Start New Connection";
            FormClosed += NewConnection_FormClosed;
            Load += NewConnection_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label5;
        private Label label2;
        private Label labelll;
        private Label label4;
        private TextBox txtServer;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox txtDatabase;
        private TextBox txtErrors;
        private TextBox txtConnectionSTR;
        private TableLayoutPanel tableLayoutPanel4;
        private Button btnConnect;
    }
}