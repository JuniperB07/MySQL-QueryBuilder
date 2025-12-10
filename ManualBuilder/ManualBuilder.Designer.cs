namespace MySQL_QueryBuilder.ManualBuilder
{
    partial class ManualBuilder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManualBuilder));
            tableLayoutPanel1 = new TableLayoutPanel();
            lblServerDatabase = new Label();
            groupBox1 = new GroupBox();
            btnClear = new Button();
            btnExecute = new Button();
            txtQuery = new TextBox();
            groupBox2 = new GroupBox();
            rtxtNotifs = new RichTextBox();
            groupBox3 = new GroupBox();
            dgvResults = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResults).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lblServerDatabase, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 1);
            tableLayoutPanel1.Controls.Add(groupBox2, 0, 2);
            tableLayoutPanel1.Controls.Add(groupBox3, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(800, 708);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblServerDatabase
            // 
            lblServerDatabase.AutoSize = true;
            lblServerDatabase.Dock = DockStyle.Left;
            lblServerDatabase.Location = new Point(3, 0);
            lblServerDatabase.Name = "lblServerDatabase";
            lblServerDatabase.Size = new Size(72, 40);
            lblServerDatabase.TabIndex = 0;
            lblServerDatabase.Text = "label1";
            lblServerDatabase.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnExecute);
            groupBox1.Controls.Add(txtQuery);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(794, 194);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "SQL Query:";
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnClear.BackColor = Color.DarkRed;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(9, 146);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(208, 42);
            btnClear.TabIndex = 2;
            btnClear.Text = "CLEAR (Esc)";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnExecute
            // 
            btnExecute.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExecute.BackColor = Color.DarkGreen;
            btnExecute.FlatAppearance.BorderSize = 0;
            btnExecute.FlatStyle = FlatStyle.Flat;
            btnExecute.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            btnExecute.ForeColor = Color.White;
            btnExecute.Location = new Point(577, 146);
            btnExecute.Name = "btnExecute";
            btnExecute.Size = new Size(208, 42);
            btnExecute.TabIndex = 1;
            btnExecute.Text = "EXECUTE (Ent)";
            btnExecute.UseVisualStyleBackColor = false;
            btnExecute.Click += btnExecute_Click;
            // 
            // txtQuery
            // 
            txtQuery.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtQuery.BorderStyle = BorderStyle.FixedSingle;
            txtQuery.Location = new Point(9, 31);
            txtQuery.Multiline = true;
            txtQuery.Name = "txtQuery";
            txtQuery.Size = new Size(776, 109);
            txtQuery.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rtxtNotifs);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(3, 243);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(794, 127);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Notifications:";
            // 
            // rtxtNotifs
            // 
            rtxtNotifs.BorderStyle = BorderStyle.FixedSingle;
            rtxtNotifs.Dock = DockStyle.Fill;
            rtxtNotifs.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtxtNotifs.Location = new Point(3, 28);
            rtxtNotifs.Name = "rtxtNotifs";
            rtxtNotifs.ReadOnly = true;
            rtxtNotifs.Size = new Size(788, 96);
            rtxtNotifs.TabIndex = 0;
            rtxtNotifs.Text = "";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvResults);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(3, 376);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(794, 329);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Results:";
            // 
            // dgvResults
            // 
            dgvResults.AllowUserToAddRows = false;
            dgvResults.AllowUserToDeleteRows = false;
            dgvResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvResults.BackgroundColor = Color.White;
            dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResults.Dock = DockStyle.Fill;
            dgvResults.GridColor = Color.Gainsboro;
            dgvResults.Location = new Point(3, 28);
            dgvResults.Name = "dgvResults";
            dgvResults.ReadOnly = true;
            dgvResults.RowHeadersWidth = 51;
            dgvResults.Size = new Size(788, 298);
            dgvResults.TabIndex = 0;
            // 
            // ManualBuilder
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 708);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "ManualBuilder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manual Query Builder";
            WindowState = FormWindowState.Maximized;
            Load += ManualBuilder_Load;
            KeyDown += ManualBuilder_KeyDown;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvResults).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblServerDatabase;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btnExecute;
        private RichTextBox rtxtNotifs;
        private DataGridView dgvResults;
        private TextBox txtQuery;
        private Button btnClear;
    }
}