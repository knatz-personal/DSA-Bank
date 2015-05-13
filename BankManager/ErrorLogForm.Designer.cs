namespace BankManager
{
    partial class ErrorLogForm
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
            System.Windows.Forms.Label dateTriggeredLabel;
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label innerExceptionLabel;
            System.Windows.Forms.Label messageLabel;
            System.Windows.Forms.Label usernameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorLogForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appointmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.errorDataGrid = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.dateTriggeredDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.innerExceptionTextBox = new System.Windows.Forms.TextBox();
            this.messageTextBox = new System.Windows.Forms.TextBox();
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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bttnLoad = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.appointmentViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTriggeredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.innerExceptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dateTriggeredLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            innerExceptionLabel = new System.Windows.Forms.Label();
            messageLabel = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorDataGrid)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTriggeredLabel
            // 
            dateTriggeredLabel.AutoSize = true;
            dateTriggeredLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            dateTriggeredLabel.Location = new System.Drawing.Point(3, 58);
            dateTriggeredLabel.Name = "dateTriggeredLabel";
            dateTriggeredLabel.Size = new System.Drawing.Size(87, 31);
            dateTriggeredLabel.TabIndex = 0;
            dateTriggeredLabel.Text = "Date Triggered:";
            dateTriggeredLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            iDLabel.Location = new System.Drawing.Point(3, 0);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(87, 28);
            iDLabel.TabIndex = 2;
            iDLabel.Text = "ID:";
            iDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // innerExceptionLabel
            // 
            innerExceptionLabel.AutoSize = true;
            innerExceptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            innerExceptionLabel.Location = new System.Drawing.Point(3, 89);
            innerExceptionLabel.Name = "innerExceptionLabel";
            innerExceptionLabel.Size = new System.Drawing.Size(87, 120);
            innerExceptionLabel.TabIndex = 4;
            innerExceptionLabel.Text = "Inner Exception:";
            innerExceptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            messageLabel.Location = new System.Drawing.Point(3, 209);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new System.Drawing.Size(87, 261);
            messageLabel.TabIndex = 6;
            messageLabel.Text = "Message:";
            messageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            usernameLabel.Location = new System.Drawing.Point(3, 28);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(87, 30);
            usernameLabel.TabIndex = 8;
            usernameLabel.Text = "Username:";
            usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.eventLogToolStripMenuItem});
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
            // eventLogToolStripMenuItem
            // 
            this.eventLogToolStripMenuItem.Name = "eventLogToolStripMenuItem";
            this.eventLogToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.eventLogToolStripMenuItem.Text = "Event Log";
            this.eventLogToolStripMenuItem.Click += new System.EventHandler(this.eventLogToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.39171F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.6083F));
            this.tableLayoutPanel1.Controls.Add(this.errorDataGrid, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.bindingNavigator1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.44879F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.55121F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(984, 537);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // errorDataGrid
            // 
            this.errorDataGrid.AllowUserToAddRows = false;
            this.errorDataGrid.AutoGenerateColumns = false;
            this.errorDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.errorDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.dateTriggeredDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.innerExceptionDataGridViewTextBoxColumn,
            this.messageDataGridViewTextBoxColumn});
            this.errorDataGrid.DataSource = this.errorViewBindingSource;
            this.errorDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.errorDataGrid.Location = new System.Drawing.Point(3, 43);
            this.errorDataGrid.Name = "errorDataGrid";
            this.errorDataGrid.ReadOnly = true;
            this.errorDataGrid.Size = new System.Drawing.Size(686, 491);
            this.errorDataGrid.TabIndex = 0;
            this.errorDataGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.errorDataGrid_KeyDown);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.51748F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.48252F));
            this.tableLayoutPanel2.Controls.Add(iDLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.iDTextBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(usernameLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.usernameTextBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(dateTriggeredLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.dateTriggeredDateTimePicker, 1, 2);
            this.tableLayoutPanel2.Controls.Add(innerExceptionLabel, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.innerExceptionTextBox, 1, 3);
            this.tableLayoutPanel2.Controls.Add(messageLabel, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.messageTextBox, 1, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(695, 43);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.991735F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.404959F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.61157F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.56701F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.46392F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(286, 491);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // iDTextBox
            // 
            this.iDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.iDTextBox.BackColor = System.Drawing.Color.White;
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.errorViewBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(96, 4);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.ReadOnly = true;
            this.iDTextBox.Size = new System.Drawing.Size(187, 20);
            this.iDTextBox.TabIndex = 3;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameTextBox.BackColor = System.Drawing.Color.White;
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.errorViewBindingSource, "Username", true));
            this.usernameTextBox.Location = new System.Drawing.Point(96, 33);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.ReadOnly = true;
            this.usernameTextBox.Size = new System.Drawing.Size(187, 20);
            this.usernameTextBox.TabIndex = 9;
            // 
            // dateTriggeredDateTimePicker
            // 
            this.dateTriggeredDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTriggeredDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.errorViewBindingSource, "DateTriggered", true));
            this.dateTriggeredDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.errorViewBindingSource, "DateTriggered", true));
            this.dateTriggeredDateTimePicker.Enabled = false;
            this.dateTriggeredDateTimePicker.Location = new System.Drawing.Point(96, 63);
            this.dateTriggeredDateTimePicker.Name = "dateTriggeredDateTimePicker";
            this.dateTriggeredDateTimePicker.Size = new System.Drawing.Size(187, 20);
            this.dateTriggeredDateTimePicker.TabIndex = 1;
            // 
            // innerExceptionTextBox
            // 
            this.innerExceptionTextBox.BackColor = System.Drawing.Color.White;
            this.innerExceptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.errorViewBindingSource, "InnerException", true));
            this.innerExceptionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.innerExceptionTextBox.Location = new System.Drawing.Point(96, 92);
            this.innerExceptionTextBox.Multiline = true;
            this.innerExceptionTextBox.Name = "innerExceptionTextBox";
            this.innerExceptionTextBox.ReadOnly = true;
            this.innerExceptionTextBox.Size = new System.Drawing.Size(187, 114);
            this.innerExceptionTextBox.TabIndex = 5;
            // 
            // messageTextBox
            // 
            this.messageTextBox.BackColor = System.Drawing.Color.White;
            this.messageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.errorViewBindingSource, "Message", true));
            this.messageTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageTextBox.Location = new System.Drawing.Point(96, 212);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.ReadOnly = true;
            this.messageTextBox.Size = new System.Drawing.Size(187, 255);
            this.messageTextBox.TabIndex = 7;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
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
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(692, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.bindingNavigator1.Size = new System.Drawing.Size(292, 40);
            this.bindingNavigator1.TabIndex = 2;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 37);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 37);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 37);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 37);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 40);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 40);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 37);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 37);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 40);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.84768F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.960265F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.50993F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.463576F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.51656F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.53642F));
            this.tableLayoutPanel3.Controls.Add(this.comboBox1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.bttnLoad, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.dateTimePicker2, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.dateTimePicker1, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(686, 34);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // bttnLoad
            // 
            this.bttnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnLoad.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttnLoad.Location = new System.Drawing.Point(551, 3);
            this.bttnLoad.Name = "bttnLoad";
            this.bttnLoad.Size = new System.Drawing.Size(132, 28);
            this.bttnLoad.TabIndex = 3;
            this.bttnLoad.Text = "Load";
            this.bttnLoad.UseVisualStyleBackColor = false;
            this.bttnLoad.Click += new System.EventHandler(this.bttnLoad_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker2.Location = new System.Drawing.Point(397, 7);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(148, 20);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Location = new System.Drawing.Point(199, 7);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(155, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(360, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "To";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(159, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 34);
            this.label2.TabIndex = 5;
            this.label2.Text = "From";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // appointmentViewBindingSource
            // 
            this.appointmentViewBindingSource.DataSource = typeof(BankManager.AppointmentServices.AppointmentView);
            // 
            // errorViewBindingSource
            // 
            this.errorViewBindingSource.DataSource = typeof(BankManager.LogServices.ErrorView);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateTriggeredDataGridViewTextBoxColumn
            // 
            this.dateTriggeredDataGridViewTextBoxColumn.DataPropertyName = "DateTriggered";
            this.dateTriggeredDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateTriggeredDataGridViewTextBoxColumn.Name = "dateTriggeredDataGridViewTextBoxColumn";
            this.dateTriggeredDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // innerExceptionDataGridViewTextBoxColumn
            // 
            this.innerExceptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.innerExceptionDataGridViewTextBoxColumn.DataPropertyName = "InnerException";
            this.innerExceptionDataGridViewTextBoxColumn.HeaderText = "Inner Exception";
            this.innerExceptionDataGridViewTextBoxColumn.Name = "innerExceptionDataGridViewTextBoxColumn";
            this.innerExceptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // messageDataGridViewTextBoxColumn
            // 
            this.messageDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.messageDataGridViewTextBoxColumn.DataPropertyName = "Message";
            this.messageDataGridViewTextBoxColumn.HeaderText = "Message";
            this.messageDataGridViewTextBoxColumn.Name = "messageDataGridViewTextBoxColumn";
            this.messageDataGridViewTextBoxColumn.ReadOnly = true;
            this.messageDataGridViewTextBoxColumn.Visible = false;
            // 
            // ErrorLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "ErrorLogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Error Logs";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorDataGrid)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorViewBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridView errorDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DateTimePicker dateTriggeredDateTimePicker;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox innerExceptionTextBox;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button bttnLoad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem eventLogToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTriggeredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn innerExceptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource errorViewBindingSource;
    }
}