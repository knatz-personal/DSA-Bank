namespace BankManager
{
    partial class TransactionHistoryForm
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
            System.Windows.Forms.Label dateIssuedLabel;
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label remarksLabel;
            System.Windows.Forms.Label typeIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionHistoryForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appoinmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eventsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.errorsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.transactionDataGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.accountToIDTextBox = new System.Windows.Forms.TextBox();
            this.accountFromIDTextBox = new System.Windows.Forms.TextBox();
            this.dateIssuedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.currencyComboBox = new System.Windows.Forms.ComboBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.typeIDComboBox = new System.Windows.Forms.ComboBox();
            this.remarksTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.bttnLoadRecords = new System.Windows.Forms.Button();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAcoountNo = new System.Windows.Forms.TextBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            accountFromIDLabel = new System.Windows.Forms.Label();
            accountToIDLabel = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            currencyLabel = new System.Windows.Forms.Label();
            dateIssuedLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            remarksLabel = new System.Windows.Forms.Label();
            typeIDLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // accountFromIDLabel
            // 
            accountFromIDLabel.AutoSize = true;
            accountFromIDLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            accountFromIDLabel.Location = new System.Drawing.Point(3, 64);
            accountFromIDLabel.Name = "accountFromIDLabel";
            accountFromIDLabel.Size = new System.Drawing.Size(60, 35);
            accountFromIDLabel.TabIndex = 0;
            accountFromIDLabel.Text = "Account From:";
            accountFromIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // accountToIDLabel
            // 
            accountToIDLabel.AutoSize = true;
            accountToIDLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            accountToIDLabel.Location = new System.Drawing.Point(3, 99);
            accountToIDLabel.Name = "accountToIDLabel";
            accountToIDLabel.Size = new System.Drawing.Size(60, 32);
            accountToIDLabel.TabIndex = 2;
            accountToIDLabel.Text = "Account To:";
            accountToIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            amountLabel.Location = new System.Drawing.Point(3, 167);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(60, 33);
            amountLabel.TabIndex = 4;
            amountLabel.Text = "Amount:";
            amountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // currencyLabel
            // 
            currencyLabel.AutoSize = true;
            currencyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            currencyLabel.Location = new System.Drawing.Point(3, 131);
            currencyLabel.Name = "currencyLabel";
            currencyLabel.Size = new System.Drawing.Size(60, 36);
            currencyLabel.TabIndex = 6;
            currencyLabel.Text = "Currency:";
            currencyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateIssuedLabel
            // 
            dateIssuedLabel.AutoSize = true;
            dateIssuedLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            dateIssuedLabel.Location = new System.Drawing.Point(3, 32);
            dateIssuedLabel.Name = "dateIssuedLabel";
            dateIssuedLabel.Size = new System.Drawing.Size(60, 32);
            dateIssuedLabel.TabIndex = 8;
            dateIssuedLabel.Text = "Date Issued:";
            dateIssuedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            iDLabel.Location = new System.Drawing.Point(3, 0);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(60, 32);
            iDLabel.TabIndex = 10;
            iDLabel.Text = "ID:";
            iDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // remarksLabel
            // 
            remarksLabel.AutoSize = true;
            remarksLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            remarksLabel.Location = new System.Drawing.Point(3, 234);
            remarksLabel.Name = "remarksLabel";
            remarksLabel.Size = new System.Drawing.Size(60, 246);
            remarksLabel.TabIndex = 12;
            remarksLabel.Text = "Remarks:";
            // 
            // typeIDLabel
            // 
            typeIDLabel.AutoSize = true;
            typeIDLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            typeIDLabel.Location = new System.Drawing.Point(3, 200);
            typeIDLabel.Name = "typeIDLabel";
            typeIDLabel.Size = new System.Drawing.Size(60, 34);
            typeIDLabel.TabIndex = 14;
            typeIDLabel.Text = "Type:";
            typeIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 0;
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
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appoinmentsToolStripMenuItem,
            this.logsToolStripMenuItem1});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // appoinmentsToolStripMenuItem
            // 
            this.appoinmentsToolStripMenuItem.Name = "appoinmentsToolStripMenuItem";
            this.appoinmentsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.appoinmentsToolStripMenuItem.Text = "Appoinments";
            this.appoinmentsToolStripMenuItem.Click += new System.EventHandler(this.appoinmentsToolStripMenuItem_Click);
            // 
            // logsToolStripMenuItem1
            // 
            this.logsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eventsToolStripMenuItem1,
            this.errorsToolStripMenuItem1});
            this.logsToolStripMenuItem1.Name = "logsToolStripMenuItem1";
            this.logsToolStripMenuItem1.Size = new System.Drawing.Size(146, 22);
            this.logsToolStripMenuItem1.Text = "Logs";
            // 
            // eventsToolStripMenuItem1
            // 
            this.eventsToolStripMenuItem1.Name = "eventsToolStripMenuItem1";
            this.eventsToolStripMenuItem1.Size = new System.Drawing.Size(108, 22);
            this.eventsToolStripMenuItem1.Text = "Events";
            // 
            // errorsToolStripMenuItem1
            // 
            this.errorsToolStripMenuItem1.Name = "errorsToolStripMenuItem1";
            this.errorsToolStripMenuItem1.Size = new System.Drawing.Size(108, 22);
            this.errorsToolStripMenuItem1.Text = "Errors";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.62601F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.37398F));
            this.tableLayoutPanel1.Controls.Add(this.transactionDataGrid, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.bindingNavigator1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.517691F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.48231F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(984, 537);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // transactionDataGrid
            // 
            this.transactionDataGrid.AllowUserToAddRows = false;
            this.transactionDataGrid.AutoGenerateColumns = false;
            this.transactionDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn7});
            this.transactionDataGrid.DataSource = this.transactionBindingSource;
            this.transactionDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transactionDataGrid.Location = new System.Drawing.Point(3, 38);
            this.transactionDataGrid.Name = "transactionDataGrid";
            this.transactionDataGrid.ReadOnly = true;
            this.transactionDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.transactionDataGrid.Size = new System.Drawing.Size(748, 496);
            this.transactionDataGrid.TabIndex = 1;
            this.transactionDataGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.transactionViewDataGrid_KeyDown);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn6.HeaderText = "ID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DateIssued";
            this.dataGridViewTextBoxColumn5.HeaderText = "Date";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "TypeID";
            this.dataGridViewTextBoxColumn8.HeaderText = "TypeID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "TypeName";
            this.dataGridViewTextBoxColumn9.HeaderText = "Type";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AccountFromID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Account From";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "AccountToID";
            this.dataGridViewTextBoxColumn2.HeaderText = "Account To";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Currency";
            this.dataGridViewTextBoxColumn4.HeaderText = "Currency";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn3.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Remarks";
            this.dataGridViewTextBoxColumn7.HeaderText = "Remarks";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // transactionBindingSource
            // 
            this.transactionBindingSource.DataSource = typeof(BankManager.BankTransactionServices.TransactionView);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoScroll = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.60894F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.39106F));
            this.tableLayoutPanel2.Controls.Add(iDLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.iDTextBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(accountToIDLabel, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.accountToIDTextBox, 1, 3);
            this.tableLayoutPanel2.Controls.Add(accountFromIDLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.accountFromIDTextBox, 1, 2);
            this.tableLayoutPanel2.Controls.Add(dateIssuedLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.dateIssuedDateTimePicker, 1, 1);
            this.tableLayoutPanel2.Controls.Add(currencyLabel, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.currencyComboBox, 1, 4);
            this.tableLayoutPanel2.Controls.Add(amountLabel, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.amountTextBox, 1, 5);
            this.tableLayoutPanel2.Controls.Add(typeIDLabel, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.typeIDComboBox, 1, 6);
            this.tableLayoutPanel2.Controls.Add(remarksLabel, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.remarksTextBox, 1, 7);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(757, 38);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 9;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.696429F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.696429F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.366071F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.696429F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.589286F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.919643F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.126949F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.00223F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(224, 496);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transactionBindingSource, "ID", true));
            this.iDTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iDTextBox.Location = new System.Drawing.Point(69, 3);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.ReadOnly = true;
            this.iDTextBox.Size = new System.Drawing.Size(152, 20);
            this.iDTextBox.TabIndex = 11;
            // 
            // accountToIDTextBox
            // 
            this.accountToIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transactionBindingSource, "AccountToID", true));
            this.accountToIDTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accountToIDTextBox.Location = new System.Drawing.Point(69, 102);
            this.accountToIDTextBox.Name = "accountToIDTextBox";
            this.accountToIDTextBox.ReadOnly = true;
            this.accountToIDTextBox.Size = new System.Drawing.Size(152, 20);
            this.accountToIDTextBox.TabIndex = 3;
            // 
            // accountFromIDTextBox
            // 
            this.accountFromIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transactionBindingSource, "AccountFromID", true));
            this.accountFromIDTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accountFromIDTextBox.Location = new System.Drawing.Point(69, 67);
            this.accountFromIDTextBox.Name = "accountFromIDTextBox";
            this.accountFromIDTextBox.ReadOnly = true;
            this.accountFromIDTextBox.Size = new System.Drawing.Size(152, 20);
            this.accountFromIDTextBox.TabIndex = 1;
            // 
            // dateIssuedDateTimePicker
            // 
            this.dateIssuedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.transactionBindingSource, "DateIssued", true));
            this.dateIssuedDateTimePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateIssuedDateTimePicker.Enabled = false;
            this.dateIssuedDateTimePicker.Location = new System.Drawing.Point(69, 35);
            this.dateIssuedDateTimePicker.Name = "dateIssuedDateTimePicker";
            this.dateIssuedDateTimePicker.Size = new System.Drawing.Size(152, 20);
            this.dateIssuedDateTimePicker.TabIndex = 9;
            // 
            // currencyComboBox
            // 
            this.currencyComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transactionBindingSource, "Currency", true));
            this.currencyComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currencyComboBox.Enabled = false;
            this.currencyComboBox.FormattingEnabled = true;
            this.currencyComboBox.Location = new System.Drawing.Point(69, 134);
            this.currencyComboBox.Name = "currencyComboBox";
            this.currencyComboBox.Size = new System.Drawing.Size(152, 21);
            this.currencyComboBox.TabIndex = 7;
            // 
            // amountTextBox
            // 
            this.amountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transactionBindingSource, "Amount", true));
            this.amountTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.amountTextBox.Location = new System.Drawing.Point(69, 170);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.ReadOnly = true;
            this.amountTextBox.Size = new System.Drawing.Size(152, 20);
            this.amountTextBox.TabIndex = 5;
            // 
            // typeIDComboBox
            // 
            this.typeIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transactionBindingSource, "TypeID", true));
            this.typeIDComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typeIDComboBox.Enabled = false;
            this.typeIDComboBox.FormattingEnabled = true;
            this.typeIDComboBox.Location = new System.Drawing.Point(69, 203);
            this.typeIDComboBox.Name = "typeIDComboBox";
            this.typeIDComboBox.Size = new System.Drawing.Size(152, 21);
            this.typeIDComboBox.TabIndex = 15;
            // 
            // remarksTextBox
            // 
            this.remarksTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transactionBindingSource, "Remarks", true));
            this.remarksTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.remarksTextBox.Location = new System.Drawing.Point(69, 237);
            this.remarksTextBox.Multiline = true;
            this.remarksTextBox.Name = "remarksTextBox";
            this.remarksTextBox.ReadOnly = true;
            this.remarksTextBox.Size = new System.Drawing.Size(152, 240);
            this.remarksTextBox.TabIndex = 13;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 7;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.67068F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.46586F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.835341F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.60777F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.630522F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.81258F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.6575F));
            this.tableLayoutPanel3.Controls.Add(this.txtUsername, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.bttnLoadRecords, 6, 0);
            this.tableLayoutPanel3.Controls.Add(this.dateTimePickerEnd, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.label2, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.dateTimePickerStart, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtAcoountNo, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(748, 29);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.Location = new System.Drawing.Point(3, 5);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(126, 20);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Text = "Username";
            // 
            // bttnLoadRecords
            // 
            this.bttnLoadRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnLoadRecords.Location = new System.Drawing.Point(668, 3);
            this.bttnLoadRecords.Name = "bttnLoadRecords";
            this.bttnLoadRecords.Size = new System.Drawing.Size(77, 24);
            this.bttnLoadRecords.TabIndex = 1;
            this.bttnLoadRecords.Text = "Load";
            this.bttnLoadRecords.UseVisualStyleBackColor = true;
            this.bttnLoadRecords.Click += new System.EventHandler(this.bttnLoadRecords_Click);
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerEnd.Location = new System.Drawing.Point(520, 5);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(142, 20);
            this.dateTimePickerEnd.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(463, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "To Date:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerStart.Location = new System.Drawing.Point(324, 5);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(133, 20);
            this.dateTimePickerStart.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(258, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "From Date:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAcoountNo
            // 
            this.txtAcoountNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAcoountNo.Location = new System.Drawing.Point(135, 5);
            this.txtAcoountNo.Name = "txtAcoountNo";
            this.txtAcoountNo.Size = new System.Drawing.Size(117, 20);
            this.txtAcoountNo.TabIndex = 6;
            this.txtAcoountNo.Text = "Account No";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.transactionBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bindingNavigator1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.saveToolStripButton});
            this.bindingNavigator1.Location = new System.Drawing.Point(754, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.bindingNavigator1.Size = new System.Drawing.Size(230, 35);
            this.bindingNavigator1.TabIndex = 3;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 32);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 32);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 32);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 35);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 32);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 32);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 35);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 20);
            this.saveToolStripButton.Text = "&Save";
            // 
            // TransactionHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "TransactionHistoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaction History";
            this.Load += new System.EventHandler(this.TransactionHistoryForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView transactionDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.BindingSource transactionBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox typeIDComboBox;
        private System.Windows.Forms.TextBox accountFromIDTextBox;
        private System.Windows.Forms.DateTimePicker dateIssuedDateTimePicker;
        private System.Windows.Forms.TextBox remarksTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.ComboBox currencyComboBox;
        private System.Windows.Forms.TextBox accountToIDTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button bttnLoadRecords;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appoinmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eventsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem errorsToolStripMenuItem1;
        private System.Windows.Forms.TextBox txtAcoountNo;
    }
}