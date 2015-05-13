namespace BankManager
{
    partial class EventLogForm
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
            System.Windows.Forms.Label dateModifiedLabel;
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label messageLabel;
            System.Windows.Forms.Label modifiedByLabel;
            System.Windows.Forms.Label sourceTableLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventLogForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appointmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bttnLoad = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.eventViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateModifiedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.modifiedByTextBox = new System.Windows.Forms.TextBox();
            this.sourceTableTextBox = new System.Windows.Forms.TextBox();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.eventDataGrid = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.appointmentViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifiedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateModifiedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceTableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dateModifiedLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            messageLabel = new System.Windows.Forms.Label();
            modifiedByLabel = new System.Windows.Forms.Label();
            sourceTableLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventDataGrid)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateModifiedLabel
            // 
            dateModifiedLabel.AutoSize = true;
            dateModifiedLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            dateModifiedLabel.Location = new System.Drawing.Point(3, 30);
            dateModifiedLabel.Name = "dateModifiedLabel";
            dateModifiedLabel.Size = new System.Drawing.Size(99, 28);
            dateModifiedLabel.TabIndex = 0;
            dateModifiedLabel.Text = "Date Modified:";
            dateModifiedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            iDLabel.Location = new System.Drawing.Point(3, 0);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(99, 30);
            iDLabel.TabIndex = 2;
            iDLabel.Text = "ID:";
            iDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            messageLabel.Location = new System.Drawing.Point(3, 113);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new System.Drawing.Size(99, 259);
            messageLabel.TabIndex = 4;
            messageLabel.Text = "Message:";
            messageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // modifiedByLabel
            // 
            modifiedByLabel.AutoSize = true;
            modifiedByLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            modifiedByLabel.Location = new System.Drawing.Point(3, 58);
            modifiedByLabel.Name = "modifiedByLabel";
            modifiedByLabel.Size = new System.Drawing.Size(99, 28);
            modifiedByLabel.TabIndex = 6;
            modifiedByLabel.Text = "Modified By:";
            modifiedByLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sourceTableLabel
            // 
            sourceTableLabel.AutoSize = true;
            sourceTableLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            sourceTableLabel.Location = new System.Drawing.Point(3, 86);
            sourceTableLabel.Name = "sourceTableLabel";
            sourceTableLabel.Size = new System.Drawing.Size(99, 27);
            sourceTableLabel.TabIndex = 8;
            sourceTableLabel.Text = "Source Table:";
            sourceTableLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.transactionHistoryToolStripMenuItem,
            this.appointmentsToolStripMenuItem,
            this.errorLogToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // transactionHistoryToolStripMenuItem
            // 
            this.transactionHistoryToolStripMenuItem.Name = "transactionHistoryToolStripMenuItem";
            this.transactionHistoryToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.transactionHistoryToolStripMenuItem.Text = "Transaction History";
            this.transactionHistoryToolStripMenuItem.Click += new System.EventHandler(this.transactionHistoryToolStripMenuItem_Click);
            // 
            // appointmentsToolStripMenuItem
            // 
            this.appointmentsToolStripMenuItem.Name = "appointmentsToolStripMenuItem";
            this.appointmentsToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.appointmentsToolStripMenuItem.Text = "Appointments";
            this.appointmentsToolStripMenuItem.Click += new System.EventHandler(this.appointmentsToolStripMenuItem_Click);
            // 
            // errorLogToolStripMenuItem
            // 
            this.errorLogToolStripMenuItem.Name = "errorLogToolStripMenuItem";
            this.errorLogToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.errorLogToolStripMenuItem.Text = "Error Log";
            this.errorLogToolStripMenuItem.Click += new System.EventHandler(this.errorLogToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.39171F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.6083F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.eventDataGrid, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.07635F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.92365F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(984, 537);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.76687F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.384459F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.03885F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.339468F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.47035F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel2.Controls.Add(this.comboBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dateTimePicker1, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.dateTimePicker2, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.bttnLoad, 5, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(686, 32);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(146, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Location = new System.Drawing.Point(204, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(166, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker2.Location = new System.Drawing.Point(413, 6);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(174, 20);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(155, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "From";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(376, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "To";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bttnLoad
            // 
            this.bttnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnLoad.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttnLoad.Location = new System.Drawing.Point(593, 3);
            this.bttnLoad.Name = "bttnLoad";
            this.bttnLoad.Size = new System.Drawing.Size(90, 26);
            this.bttnLoad.TabIndex = 5;
            this.bttnLoad.Text = "Load";
            this.bttnLoad.UseVisualStyleBackColor = false;
            this.bttnLoad.Click += new System.EventHandler(this.bttnLoad_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.00441F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.99559F));
            this.tableLayoutPanel3.Controls.Add(iDLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.iDTextBox, 1, 0);
            this.tableLayoutPanel3.Controls.Add(dateModifiedLabel, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.dateModifiedDateTimePicker, 1, 1);
            this.tableLayoutPanel3.Controls.Add(modifiedByLabel, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.modifiedByTextBox, 1, 2);
            this.tableLayoutPanel3.Controls.Add(sourceTableLabel, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.sourceTableTextBox, 1, 3);
            this.tableLayoutPanel3.Controls.Add(messageLabel, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.messageTextBox, 1, 4);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(695, 41);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 259F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(286, 493);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // iDTextBox
            // 
            this.iDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.iDTextBox.BackColor = System.Drawing.Color.White;
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventViewBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(108, 5);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.ReadOnly = true;
            this.iDTextBox.Size = new System.Drawing.Size(175, 20);
            this.iDTextBox.TabIndex = 3;
            // 
            // eventViewBindingSource
            // 
            this.eventViewBindingSource.DataSource = typeof(BankManager.LogServices.EventView);
            this.eventViewBindingSource.Sort = "DateModified";
            // 
            // dateModifiedDateTimePicker
            // 
            this.dateModifiedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventViewBindingSource, "DateModified", true));
            this.dateModifiedDateTimePicker.Enabled = false;
            this.dateModifiedDateTimePicker.Location = new System.Drawing.Point(108, 33);
            this.dateModifiedDateTimePicker.Name = "dateModifiedDateTimePicker";
            this.dateModifiedDateTimePicker.Size = new System.Drawing.Size(137, 20);
            this.dateModifiedDateTimePicker.TabIndex = 1;
            // 
            // modifiedByTextBox
            // 
            this.modifiedByTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.modifiedByTextBox.BackColor = System.Drawing.Color.White;
            this.modifiedByTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventViewBindingSource, "ModifiedBy", true));
            this.modifiedByTextBox.Location = new System.Drawing.Point(108, 62);
            this.modifiedByTextBox.Name = "modifiedByTextBox";
            this.modifiedByTextBox.ReadOnly = true;
            this.modifiedByTextBox.Size = new System.Drawing.Size(175, 20);
            this.modifiedByTextBox.TabIndex = 7;
            // 
            // sourceTableTextBox
            // 
            this.sourceTableTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.sourceTableTextBox.BackColor = System.Drawing.Color.White;
            this.sourceTableTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventViewBindingSource, "SourceTable", true));
            this.sourceTableTextBox.Location = new System.Drawing.Point(108, 89);
            this.sourceTableTextBox.Name = "sourceTableTextBox";
            this.sourceTableTextBox.ReadOnly = true;
            this.sourceTableTextBox.Size = new System.Drawing.Size(175, 20);
            this.sourceTableTextBox.TabIndex = 9;
            // 
            // messageTextBox
            // 
            this.messageTextBox.BackColor = System.Drawing.Color.White;
            this.messageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventViewBindingSource, "Message", true));
            this.messageTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageTextBox.Location = new System.Drawing.Point(108, 116);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.ReadOnly = true;
            this.messageTextBox.Size = new System.Drawing.Size(175, 253);
            this.messageTextBox.TabIndex = 5;
            // 
            // eventDataGrid
            // 
            this.eventDataGrid.AllowUserToAddRows = false;
            this.eventDataGrid.AutoGenerateColumns = false;
            this.eventDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.modifiedByDataGridViewTextBoxColumn,
            this.dateModifiedDataGridViewTextBoxColumn,
            this.sourceTableDataGridViewTextBoxColumn,
            this.messageDataGridViewTextBoxColumn});
            this.eventDataGrid.DataSource = this.eventViewBindingSource;
            this.eventDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eventDataGrid.Location = new System.Drawing.Point(3, 41);
            this.eventDataGrid.Name = "eventDataGrid";
            this.eventDataGrid.ReadOnly = true;
            this.eventDataGrid.Size = new System.Drawing.Size(686, 493);
            this.eventDataGrid.TabIndex = 2;
            this.eventDataGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.eventDataGridView_KeyDown);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.bindingNavigator1, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(695, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.54054F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(286, 32);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bindingNavigator1.BindingSource = this.eventViewBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
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
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 3);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.bindingNavigator1.Size = new System.Drawing.Size(286, 25);
            this.bindingNavigator1.TabIndex = 4;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // appointmentViewBindingSource
            // 
            this.appointmentViewBindingSource.DataSource = typeof(BankManager.AppointmentServices.AppointmentView);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // modifiedByDataGridViewTextBoxColumn
            // 
            this.modifiedByDataGridViewTextBoxColumn.DataPropertyName = "ModifiedBy";
            this.modifiedByDataGridViewTextBoxColumn.HeaderText = "ModifiedBy";
            this.modifiedByDataGridViewTextBoxColumn.Name = "modifiedByDataGridViewTextBoxColumn";
            this.modifiedByDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateModifiedDataGridViewTextBoxColumn
            // 
            this.dateModifiedDataGridViewTextBoxColumn.DataPropertyName = "DateModified";
            this.dateModifiedDataGridViewTextBoxColumn.HeaderText = "Date Modified";
            this.dateModifiedDataGridViewTextBoxColumn.Name = "dateModifiedDataGridViewTextBoxColumn";
            this.dateModifiedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sourceTableDataGridViewTextBoxColumn
            // 
            this.sourceTableDataGridViewTextBoxColumn.DataPropertyName = "Source Table";
            this.sourceTableDataGridViewTextBoxColumn.HeaderText = "SourceTable";
            this.sourceTableDataGridViewTextBoxColumn.Name = "sourceTableDataGridViewTextBoxColumn";
            this.sourceTableDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // messageDataGridViewTextBoxColumn
            // 
            this.messageDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.messageDataGridViewTextBoxColumn.DataPropertyName = "Message";
            this.messageDataGridViewTextBoxColumn.HeaderText = "Message";
            this.messageDataGridViewTextBoxColumn.Name = "messageDataGridViewTextBoxColumn";
            this.messageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // EventLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "EventLogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event Logs";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventDataGrid)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentViewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appointmentsToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.BindingSource appointmentViewBindingSource;
        private System.Windows.Forms.DataGridView eventDataGrid;
        private System.Windows.Forms.BindingSource eventViewBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttnLoad;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.DateTimePicker dateModifiedDateTimePicker;
        private System.Windows.Forms.TextBox modifiedByTextBox;
        private System.Windows.Forms.TextBox sourceTableTextBox;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
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
        private System.Windows.Forms.ToolStripMenuItem errorLogToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifiedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateModifiedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sourceTableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageDataGridViewTextBoxColumn;
    }
}