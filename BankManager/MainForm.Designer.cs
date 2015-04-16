namespace BankManager
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label accountFromIDLabel;
            System.Windows.Forms.Label accountToIDLabel;
            System.Windows.Forms.Label amountLabel;
            System.Windows.Forms.Label currencyLabel;
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label remarksLabel;
            System.Windows.Forms.Label typeIDLabel;
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siteAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bankAccountTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gendersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bttnLoadTable = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.bttnFilter = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.accountFromIDTextBox = new System.Windows.Forms.TextBox();
            this.accountToIDTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.remarksTextBox = new System.Windows.Forms.TextBox();
            this.typeIDTextBox = new System.Windows.Forms.TextBox();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateIssued = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountFromIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountToIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencyComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            accountFromIDLabel = new System.Windows.Forms.Label();
            accountToIDLabel = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            currencyLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            remarksLabel = new System.Windows.Forms.Label();
            typeIDLabel = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionViewBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Status";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.siteAdminToolStripMenuItem,
            this.logsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // siteAdminToolStripMenuItem
            // 
            this.siteAdminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userTypesToolStripMenuItem,
            this.transactionTypesToolStripMenuItem,
            this.bankAccountTypesToolStripMenuItem,
            this.gendersToolStripMenuItem});
            this.siteAdminToolStripMenuItem.Name = "siteAdminToolStripMenuItem";
            this.siteAdminToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.siteAdminToolStripMenuItem.Text = "Site Admin";
            // 
            // userTypesToolStripMenuItem
            // 
            this.userTypesToolStripMenuItem.Name = "userTypesToolStripMenuItem";
            this.userTypesToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.userTypesToolStripMenuItem.Text = "User Types";
            // 
            // transactionTypesToolStripMenuItem
            // 
            this.transactionTypesToolStripMenuItem.Name = "transactionTypesToolStripMenuItem";
            this.transactionTypesToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.transactionTypesToolStripMenuItem.Text = "Transaction Types";
            // 
            // bankAccountTypesToolStripMenuItem
            // 
            this.bankAccountTypesToolStripMenuItem.Name = "bankAccountTypesToolStripMenuItem";
            this.bankAccountTypesToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.bankAccountTypesToolStripMenuItem.Text = "Bank Account Types";
            // 
            // gendersToolStripMenuItem
            // 
            this.gendersToolStripMenuItem.Name = "gendersToolStripMenuItem";
            this.gendersToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.gendersToolStripMenuItem.Text = "Genders";
            // 
            // logsToolStripMenuItem
            // 
            this.logsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eventsToolStripMenuItem,
            this.errorsToolStripMenuItem});
            this.logsToolStripMenuItem.Name = "logsToolStripMenuItem";
            this.logsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.logsToolStripMenuItem.Text = "Logs";
            // 
            // eventsToolStripMenuItem
            // 
            this.eventsToolStripMenuItem.Name = "eventsToolStripMenuItem";
            this.eventsToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.eventsToolStripMenuItem.Text = "Events";
            // 
            // errorsToolStripMenuItem
            // 
            this.errorsToolStripMenuItem.Name = "errorsToolStripMenuItem";
            this.errorsToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.errorsToolStripMenuItem.Text = "Errors";
            // 
            // transactionViewBindingSource
            // 
            this.transactionViewBindingSource.DataSource = typeof(BankManager.BankTransactionServices.TransactionView);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.572815F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.42719F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 515);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.comboBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.bttnLoadTable, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.dateTimePicker1, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.dateTimePicker2, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.bttnFilter, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(778, 32);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Transactions",
            "Appointments"});
            this.comboBox1.Location = new System.Drawing.Point(3, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // bttnLoadTable
            // 
            this.bttnLoadTable.Location = new System.Drawing.Point(158, 3);
            this.bttnLoadTable.Name = "bttnLoadTable";
            this.bttnLoadTable.Size = new System.Drawing.Size(75, 23);
            this.bttnLoadTable.TabIndex = 1;
            this.bttnLoadTable.Text = "Load";
            this.bttnLoadTable.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(313, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(149, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(468, 3);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(149, 20);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // bttnFilter
            // 
            this.bttnFilter.Location = new System.Drawing.Point(623, 3);
            this.bttnFilter.Name = "bttnFilter";
            this.bttnFilter.Size = new System.Drawing.Size(75, 23);
            this.bttnFilter.TabIndex = 4;
            this.bttnFilter.Text = "Filter";
            this.bttnFilter.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.63496F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.36504F));
            this.tableLayoutPanel3.Controls.Add(this.dataGridView1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 41);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(778, 471);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.typeIDDataGridViewTextBoxColumn,
            this.DateIssued,
            this.remarksDataGridViewTextBoxColumn,
            this.accountFromIDDataGridViewTextBoxColumn,
            this.accountToIDDataGridViewTextBoxColumn,
            this.currencyDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.transactionViewBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(218, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(557, 465);
            this.dataGridView1.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.currencyComboBox, 0, 7);
            this.tableLayoutPanel4.Controls.Add(accountFromIDLabel, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.accountFromIDTextBox, 0, 1);
            this.tableLayoutPanel4.Controls.Add(accountToIDLabel, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.accountToIDTextBox, 0, 3);
            this.tableLayoutPanel4.Controls.Add(amountLabel, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.amountTextBox, 0, 5);
            this.tableLayoutPanel4.Controls.Add(currencyLabel, 0, 6);
            this.tableLayoutPanel4.Controls.Add(iDLabel, 0, 8);
            this.tableLayoutPanel4.Controls.Add(this.iDTextBox, 0, 9);
            this.tableLayoutPanel4.Controls.Add(remarksLabel, 0, 10);
            this.tableLayoutPanel4.Controls.Add(this.remarksTextBox, 0, 11);
            this.tableLayoutPanel4.Controls.Add(typeIDLabel, 0, 12);
            this.tableLayoutPanel4.Controls.Add(this.typeIDTextBox, 0, 13);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 14);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 15;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.12844F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.110092F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.576659F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.322654F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.79452F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.392694F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.01139F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.972665F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.46697F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.833713F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.555809F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.090909F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(209, 465);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // accountFromIDLabel
            // 
            accountFromIDLabel.AutoSize = true;
            accountFromIDLabel.Location = new System.Drawing.Point(3, 0);
            accountFromIDLabel.Name = "accountFromIDLabel";
            accountFromIDLabel.Size = new System.Drawing.Size(76, 13);
            accountFromIDLabel.TabIndex = 0;
            accountFromIDLabel.Text = "Account From:";
            // 
            // accountFromIDTextBox
            // 
            this.accountFromIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transactionViewBindingSource, "AccountFromID", true));
            this.accountFromIDTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accountFromIDTextBox.Location = new System.Drawing.Point(3, 21);
            this.accountFromIDTextBox.Name = "accountFromIDTextBox";
            this.accountFromIDTextBox.Size = new System.Drawing.Size(203, 20);
            this.accountFromIDTextBox.TabIndex = 1;
            // 
            // accountToIDLabel
            // 
            accountToIDLabel.AutoSize = true;
            accountToIDLabel.Location = new System.Drawing.Point(3, 49);
            accountToIDLabel.Name = "accountToIDLabel";
            accountToIDLabel.Size = new System.Drawing.Size(66, 13);
            accountToIDLabel.TabIndex = 2;
            accountToIDLabel.Text = "Account To:";
            // 
            // accountToIDTextBox
            // 
            this.accountToIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transactionViewBindingSource, "AccountToID", true));
            this.accountToIDTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accountToIDTextBox.Location = new System.Drawing.Point(3, 72);
            this.accountToIDTextBox.Name = "accountToIDTextBox";
            this.accountToIDTextBox.Size = new System.Drawing.Size(203, 20);
            this.accountToIDTextBox.TabIndex = 3;
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(3, 101);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(46, 13);
            amountLabel.TabIndex = 4;
            amountLabel.Text = "Amount:";
            // 
            // amountTextBox
            // 
            this.amountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transactionViewBindingSource, "Amount", true));
            this.amountTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.amountTextBox.Location = new System.Drawing.Point(3, 125);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(203, 20);
            this.amountTextBox.TabIndex = 5;
            // 
            // currencyLabel
            // 
            currencyLabel.AutoSize = true;
            currencyLabel.Location = new System.Drawing.Point(3, 150);
            currencyLabel.Name = "currencyLabel";
            currencyLabel.Size = new System.Drawing.Size(52, 13);
            currencyLabel.TabIndex = 6;
            currencyLabel.Text = "Currency:";
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(3, 207);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 10;
            iDLabel.Text = "ID:";
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transactionViewBindingSource, "ID", true));
            this.iDTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iDTextBox.Location = new System.Drawing.Point(3, 234);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.ReadOnly = true;
            this.iDTextBox.Size = new System.Drawing.Size(203, 20);
            this.iDTextBox.TabIndex = 11;
            // 
            // remarksLabel
            // 
            remarksLabel.AutoSize = true;
            remarksLabel.Location = new System.Drawing.Point(3, 261);
            remarksLabel.Name = "remarksLabel";
            remarksLabel.Size = new System.Drawing.Size(52, 13);
            remarksLabel.TabIndex = 12;
            remarksLabel.Text = "Remarks:";
            // 
            // remarksTextBox
            // 
            this.remarksTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transactionViewBindingSource, "Remarks", true));
            this.remarksTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.remarksTextBox.Location = new System.Drawing.Point(3, 284);
            this.remarksTextBox.Multiline = true;
            this.remarksTextBox.Name = "remarksTextBox";
            this.remarksTextBox.Size = new System.Drawing.Size(203, 104);
            this.remarksTextBox.TabIndex = 13;
            // 
            // typeIDLabel
            // 
            typeIDLabel.AutoSize = true;
            typeIDLabel.Location = new System.Drawing.Point(3, 391);
            typeIDLabel.Name = "typeIDLabel";
            typeIDLabel.Size = new System.Drawing.Size(48, 13);
            typeIDLabel.TabIndex = 14;
            typeIDLabel.Text = "Type ID:";
            // 
            // typeIDTextBox
            // 
            this.typeIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transactionViewBindingSource, "TypeID", true));
            this.typeIDTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typeIDTextBox.Location = new System.Drawing.Point(3, 412);
            this.typeIDTextBox.Name = "typeIDTextBox";
            this.typeIDTextBox.Size = new System.Drawing.Size(203, 20);
            this.typeIDTextBox.TabIndex = 15;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // typeIDDataGridViewTextBoxColumn
            // 
            this.typeIDDataGridViewTextBoxColumn.DataPropertyName = "TypeID";
            this.typeIDDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeIDDataGridViewTextBoxColumn.Name = "typeIDDataGridViewTextBoxColumn";
            // 
            // DateIssued
            // 
            this.DateIssued.DataPropertyName = "DateIssued";
            this.DateIssued.HeaderText = "Date";
            this.DateIssued.Name = "DateIssued";
            this.DateIssued.ReadOnly = true;
            // 
            // remarksDataGridViewTextBoxColumn
            // 
            this.remarksDataGridViewTextBoxColumn.DataPropertyName = "Remarks";
            this.remarksDataGridViewTextBoxColumn.HeaderText = "Remarks";
            this.remarksDataGridViewTextBoxColumn.Name = "remarksDataGridViewTextBoxColumn";
            // 
            // accountFromIDDataGridViewTextBoxColumn
            // 
            this.accountFromIDDataGridViewTextBoxColumn.DataPropertyName = "AccountFromID";
            this.accountFromIDDataGridViewTextBoxColumn.HeaderText = "Acc From";
            this.accountFromIDDataGridViewTextBoxColumn.Name = "accountFromIDDataGridViewTextBoxColumn";
            // 
            // accountToIDDataGridViewTextBoxColumn
            // 
            this.accountToIDDataGridViewTextBoxColumn.DataPropertyName = "AccountToID";
            this.accountToIDDataGridViewTextBoxColumn.HeaderText = "Acc To";
            this.accountToIDDataGridViewTextBoxColumn.Name = "accountToIDDataGridViewTextBoxColumn";
            // 
            // currencyDataGridViewTextBoxColumn
            // 
            this.currencyDataGridViewTextBoxColumn.DataPropertyName = "Currency";
            this.currencyDataGridViewTextBoxColumn.HeaderText = "Currency";
            this.currencyDataGridViewTextBoxColumn.Name = "currencyDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // currencyComboBox
            // 
            this.currencyComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transactionViewBindingSource, "Currency", true));
            this.currencyComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currencyComboBox.FormattingEnabled = true;
            this.currencyComboBox.Items.AddRange(new object[] {
            "Eur"});
            this.currencyComboBox.Location = new System.Drawing.Point(3, 175);
            this.currencyComboBox.Name = "currencyComboBox";
            this.currencyComboBox.Size = new System.Drawing.Size(203, 21);
            this.currencyComboBox.TabIndex = 16;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 443);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(200, 19);
            this.tableLayoutPanel5.TabIndex = 17;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionViewBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.BindingSource transactionViewBindingSource;
        private System.Windows.Forms.ToolStripMenuItem siteAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bankAccountTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gendersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem errorsToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button bttnLoadTable;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button bttnFilter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox accountFromIDTextBox;
        private System.Windows.Forms.TextBox accountToIDTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox remarksTextBox;
        private System.Windows.Forms.TextBox typeIDTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateIssued;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountFromIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountToIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox currencyComboBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;

    }
}