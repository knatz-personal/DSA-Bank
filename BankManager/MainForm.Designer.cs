using WcfServiceDSABank;

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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label suggestedDateLabel;
            System.Windows.Forms.Label suggestedTimeLabel;
            System.Windows.Forms.Label durationLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label isAcceptedLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eventMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.appointmentDataGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.isAcceptedCheckBox = new System.Windows.Forms.CheckBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.durationTextBox = new System.Windows.Forms.TextBox();
            this.suggestedTimeTextBox = new System.Windows.Forms.TextBox();
            this.suggestedDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.drpAppointmentState = new System.Windows.Forms.ComboBox();
            this.bttnLoadRecords = new System.Windows.Forms.Button();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.appointmentViewBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            iDLabel = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            suggestedDateLabel = new System.Windows.Forms.Label();
            suggestedTimeLabel = new System.Windows.Forms.Label();
            durationLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            isAcceptedLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentViewBindingSource)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentViewBindingNavigator)).BeginInit();
            this.appointmentViewBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            iDLabel.Location = new System.Drawing.Point(3, 0);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(93, 22);
            iDLabel.TabIndex = 14;
            iDLabel.Text = "ID:";
            iDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            usernameLabel.Location = new System.Drawing.Point(3, 22);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(93, 27);
            usernameLabel.TabIndex = 15;
            usernameLabel.Text = "Username:";
            usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // suggestedDateLabel
            // 
            suggestedDateLabel.AutoSize = true;
            suggestedDateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            suggestedDateLabel.Location = new System.Drawing.Point(3, 49);
            suggestedDateLabel.Name = "suggestedDateLabel";
            suggestedDateLabel.Size = new System.Drawing.Size(93, 27);
            suggestedDateLabel.TabIndex = 16;
            suggestedDateLabel.Text = "Suggested Date:";
            suggestedDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // suggestedTimeLabel
            // 
            suggestedTimeLabel.AutoSize = true;
            suggestedTimeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            suggestedTimeLabel.Location = new System.Drawing.Point(3, 76);
            suggestedTimeLabel.Name = "suggestedTimeLabel";
            suggestedTimeLabel.Size = new System.Drawing.Size(93, 27);
            suggestedTimeLabel.TabIndex = 17;
            suggestedTimeLabel.Text = "Suggested Time:";
            suggestedTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            durationLabel.Location = new System.Drawing.Point(3, 103);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new System.Drawing.Size(93, 25);
            durationLabel.TabIndex = 18;
            durationLabel.Text = "Duration:";
            durationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            descriptionLabel.Location = new System.Drawing.Point(3, 128);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(93, 315);
            descriptionLabel.TabIndex = 19;
            descriptionLabel.Text = "Description:";
            descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // isAcceptedLabel
            // 
            isAcceptedLabel.AutoSize = true;
            isAcceptedLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            isAcceptedLabel.Location = new System.Drawing.Point(3, 443);
            isAcceptedLabel.Name = "isAcceptedLabel";
            isAcceptedLabel.Size = new System.Drawing.Size(93, 27);
            isAcceptedLabel.TabIndex = 20;
            isAcceptedLabel.Text = "Accept:";
            isAcceptedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
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
            this.logsToolStripMenuItem1});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // transactionHistoryToolStripMenuItem
            // 
            this.transactionHistoryToolStripMenuItem.Name = "transactionHistoryToolStripMenuItem";
            this.transactionHistoryToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.transactionHistoryToolStripMenuItem.Text = "Transaction History";
            this.transactionHistoryToolStripMenuItem.Click += new System.EventHandler(this.transactionHistoryMenuItem_Click);
            // 
            // logsToolStripMenuItem1
            // 
            this.logsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eventMenuItem,
            this.errorMenuItem});
            this.logsToolStripMenuItem1.Name = "logsToolStripMenuItem1";
            this.logsToolStripMenuItem1.Size = new System.Drawing.Size(177, 22);
            this.logsToolStripMenuItem1.Text = "Logs";
            // 
            // eventMenuItem
            // 
            this.eventMenuItem.Name = "eventMenuItem";
            this.eventMenuItem.Size = new System.Drawing.Size(103, 22);
            this.eventMenuItem.Text = "Event";
            this.eventMenuItem.Click += new System.EventHandler(this.eventMenuItem_Click);
            // 
            // errorMenuItem
            // 
            this.errorMenuItem.Name = "errorMenuItem";
            this.errorMenuItem.Size = new System.Drawing.Size(103, 22);
            this.errorMenuItem.Text = "Error";
            this.errorMenuItem.Click += new System.EventHandler(this.errorMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 356F));
            this.tableLayoutPanel1.Controls.Add(this.appointmentDataGrid, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 478F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(984, 537);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // appointmentDataGrid
            // 
            this.appointmentDataGrid.AllowUserToAddRows = false;
            this.appointmentDataGrid.AutoGenerateColumns = false;
            this.appointmentDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4});
            this.appointmentDataGrid.DataSource = this.appointmentViewBindingSource;
            this.appointmentDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appointmentDataGrid.Location = new System.Drawing.Point(3, 40);
            this.appointmentDataGrid.Name = "appointmentDataGrid";
            this.appointmentDataGrid.ReadOnly = true;
            this.appointmentDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.appointmentDataGrid.Size = new System.Drawing.Size(622, 494);
            this.appointmentDataGrid.TabIndex = 8;
            this.appointmentDataGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.appointmentDataGrid_KeyDown);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Username";
            this.dataGridViewTextBoxColumn7.HeaderText = "Username";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn1.HeaderText = "Description";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SuggestedDate";
            dataGridViewCellStyle1.Format = "D";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn5.HeaderText = "Date";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "SuggestedTime";
            dataGridViewCellStyle2.Format = "t";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn6.HeaderText = "Time";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Duration";
            this.dataGridViewTextBoxColumn2.HeaderText = "Duration";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IsAccepted";
            dataGridViewCellStyle3.NullValue = "Pending";
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn4.HeaderText = "Accepted";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // appointmentViewBindingSource
            // 
            this.appointmentViewBindingSource.DataSource = typeof(AppointmentView);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoScroll = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.36257F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.63743F));
            this.tableLayoutPanel2.Controls.Add(isAcceptedLabel, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.isAcceptedCheckBox, 1, 6);
            this.tableLayoutPanel2.Controls.Add(descriptionLabel, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.descriptionTextBox, 1, 5);
            this.tableLayoutPanel2.Controls.Add(durationLabel, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.durationTextBox, 1, 4);
            this.tableLayoutPanel2.Controls.Add(suggestedTimeLabel, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.suggestedTimeTextBox, 1, 3);
            this.tableLayoutPanel2.Controls.Add(suggestedDateLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.suggestedDateDateTimePicker, 1, 2);
            this.tableLayoutPanel2.Controls.Add(usernameLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.usernameTextBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(iDLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.iDTextBox, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(631, 40);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.077263F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.181015F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.181015F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.181015F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.739514F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.64017F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(350, 494);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // isAcceptedCheckBox
            // 
            this.isAcceptedCheckBox.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.isAcceptedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.appointmentViewBindingSource, "IsAccepted", true));
            this.isAcceptedCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.isAcceptedCheckBox.Location = new System.Drawing.Point(102, 446);
            this.isAcceptedCheckBox.Name = "isAcceptedCheckBox";
            this.isAcceptedCheckBox.Size = new System.Drawing.Size(245, 21);
            this.isAcceptedCheckBox.TabIndex = 21;
            this.isAcceptedCheckBox.UseVisualStyleBackColor = true;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.Color.White;
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentViewBindingSource, "Description", true));
            this.descriptionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionTextBox.Location = new System.Drawing.Point(102, 131);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.Size = new System.Drawing.Size(245, 309);
            this.descriptionTextBox.TabIndex = 20;
            // 
            // durationTextBox
            // 
            this.durationTextBox.BackColor = System.Drawing.Color.White;
            this.durationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentViewBindingSource, "Duration", true));
            this.durationTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.durationTextBox.Location = new System.Drawing.Point(102, 106);
            this.durationTextBox.Name = "durationTextBox";
            this.durationTextBox.ReadOnly = true;
            this.durationTextBox.Size = new System.Drawing.Size(245, 20);
            this.durationTextBox.TabIndex = 19;
            // 
            // suggestedTimeTextBox
            // 
            this.suggestedTimeTextBox.BackColor = System.Drawing.Color.White;
            this.suggestedTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentViewBindingSource, "SuggestedTime", true));
            this.suggestedTimeTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.suggestedTimeTextBox.Location = new System.Drawing.Point(102, 79);
            this.suggestedTimeTextBox.Name = "suggestedTimeTextBox";
            this.suggestedTimeTextBox.ReadOnly = true;
            this.suggestedTimeTextBox.Size = new System.Drawing.Size(245, 20);
            this.suggestedTimeTextBox.TabIndex = 18;
            // 
            // suggestedDateDateTimePicker
            // 
            this.suggestedDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.appointmentViewBindingSource, "SuggestedDate", true));
            this.suggestedDateDateTimePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.suggestedDateDateTimePicker.Enabled = false;
            this.suggestedDateDateTimePicker.Location = new System.Drawing.Point(102, 52);
            this.suggestedDateDateTimePicker.Name = "suggestedDateDateTimePicker";
            this.suggestedDateDateTimePicker.Size = new System.Drawing.Size(245, 20);
            this.suggestedDateDateTimePicker.TabIndex = 17;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = System.Drawing.Color.White;
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentViewBindingSource, "Username", true));
            this.usernameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usernameTextBox.Location = new System.Drawing.Point(102, 25);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.ReadOnly = true;
            this.usernameTextBox.Size = new System.Drawing.Size(245, 20);
            this.usernameTextBox.TabIndex = 16;
            // 
            // iDTextBox
            // 
            this.iDTextBox.BackColor = System.Drawing.Color.White;
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentViewBindingSource, "ID", true));
            this.iDTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iDTextBox.Location = new System.Drawing.Point(102, 3);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.ReadOnly = true;
            this.iDTextBox.Size = new System.Drawing.Size(245, 20);
            this.iDTextBox.TabIndex = 15;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.08759F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.36496F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.14598F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.197081F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.41606F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.Controls.Add(this.drpAppointmentState, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.bttnLoadRecords, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.dateTimePickerEnd, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.dateTimePickerStart, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(622, 31);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // drpAppointmentState
            // 
            this.drpAppointmentState.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.drpAppointmentState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpAppointmentState.FormattingEnabled = true;
            this.drpAppointmentState.Location = new System.Drawing.Point(3, 5);
            this.drpAppointmentState.Name = "drpAppointmentState";
            this.drpAppointmentState.Size = new System.Drawing.Size(144, 21);
            this.drpAppointmentState.TabIndex = 8;
            // 
            // bttnLoadRecords
            // 
            this.bttnLoadRecords.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bttnLoadRecords.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttnLoadRecords.Location = new System.Drawing.Point(519, 3);
            this.bttnLoadRecords.Name = "bttnLoadRecords";
            this.bttnLoadRecords.Size = new System.Drawing.Size(100, 25);
            this.bttnLoadRecords.TabIndex = 9;
            this.bttnLoadRecords.Text = "Load";
            this.bttnLoadRecords.UseVisualStyleBackColor = false;
            this.bttnLoadRecords.Click += new System.EventHandler(this.bttnLoadRecords_Click);
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(399, 5);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(114, 20);
            this.dateTimePickerEnd.TabIndex = 6;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePickerStart.Location = new System.Drawing.Point(217, 5);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(119, 20);
            this.dateTimePickerStart.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(342, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "To";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(153, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 31);
            this.label2.TabIndex = 11;
            this.label2.Text = "From";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.appointmentViewBindingNavigator);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(631, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(350, 31);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // appointmentViewBindingNavigator
            // 
            this.appointmentViewBindingNavigator.AddNewItem = null;
            this.appointmentViewBindingNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.appointmentViewBindingNavigator.BindingSource = this.appointmentViewBindingSource;
            this.appointmentViewBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.appointmentViewBindingNavigator.DeleteItem = null;
            this.appointmentViewBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.appointmentViewBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.appointmentViewBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorDeleteItem,
            this.saveToolStripButton});
            this.appointmentViewBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.appointmentViewBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.appointmentViewBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.appointmentViewBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.appointmentViewBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.appointmentViewBindingNavigator.Name = "appointmentViewBindingNavigator";
            this.appointmentViewBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.appointmentViewBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.appointmentViewBindingNavigator.Size = new System.Drawing.Size(246, 25);
            this.appointmentViewBindingNavigator.Stretch = true;
            this.appointmentViewBindingNavigator.TabIndex = 10;
            this.appointmentViewBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.deleteItem_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointments";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentViewBindingSource)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentViewBindingNavigator)).EndInit();
            this.appointmentViewBindingNavigator.ResumeLayout(false);
            this.appointmentViewBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.ComboBox drpAppointmentState;
        private System.Windows.Forms.Button bttnLoadRecords;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eventMenuItem;
        private System.Windows.Forms.ToolStripMenuItem errorMenuItem;
        private System.Windows.Forms.DataGridView appointmentDataGrid;
        private System.Windows.Forms.BindingSource appointmentViewBindingSource;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.BindingNavigator appointmentViewBindingNavigator;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.CheckBox isAcceptedCheckBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox durationTextBox;
        private System.Windows.Forms.TextBox suggestedTimeTextBox;
        private System.Windows.Forms.DateTimePicker suggestedDateDateTimePicker;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

    }
}