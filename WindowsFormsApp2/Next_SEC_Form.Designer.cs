namespace WindowsFormsApp2
{
    partial class Next_SEC_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Next_SEC_Form));
            this.refreshButton = new System.Windows.Forms.Button();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.stopTimerButton = new System.Windows.Forms.Button();
            this.secTextBox = new System.Windows.Forms.TextBox();
            this.secSinglePrint = new System.Windows.Forms.Button();
            this.secPrintPreviewButton = new System.Windows.Forms.Button();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.printerComboBox = new System.Windows.Forms.ComboBox();
            this.printSECBox = new System.Windows.Forms.GroupBox();
            this.bindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.lblStatus = new System.Windows.Forms.Label();
            this.startTimerButton = new System.Windows.Forms.Button();
            this.batchUncheckGroupBox = new System.Windows.Forms.GroupBox();
            this.batch1CheckButton = new System.Windows.Forms.Button();
            this.sqlDataTableAdapterButton = new System.Windows.Forms.Button();
            this.closeConnectionButton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idUncheckTextBox = new System.Windows.Forms.TextBox();
            this.actionsMembershipNumLabel = new System.Windows.Forms.Label();
            this.actionsSeasonLabel = new System.Windows.Forms.Label();
            this.actionsTxtSeason = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.notice = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewSecBatchPrintBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.imsaAdminDevDataSet6 = new WindowsFormsApp2.ImsaAdminDevDataSet6();
            this.imsaAdminDevDataSet5 = new WindowsFormsApp2.ImsaAdminDevDataSet5();
            this.viewSecBatchPrintBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_SecBatchPrintTableAdapter = new WindowsFormsApp2.ImsaAdminDevDataSet5TableAdapters.view_SecBatchPrintTableAdapter();
            this.view_SecBatchPrintTableAdapter1 = new WindowsFormsApp2.ImsaAdminDevDataSet6TableAdapters.view_SecBatchPrintTableAdapter();
            this.viewSecBatchPrintBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.view_SecBatchPrintAll = new WindowsFormsApp2.view_SecBatchPrintAll();
            this.view_SecBatchPrintTableAdapter2 = new WindowsFormsApp2.view_SecBatchPrintAllTableAdapters.view_SecBatchPrintTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.printSECBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).BeginInit();
            this.bindingNavigator.SuspendLayout();
            this.batchUncheckGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSecBatchPrintBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imsaAdminDevDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imsaAdminDevDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSecBatchPrintBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSecBatchPrintBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_SecBatchPrintAll)).BeginInit();
            this.SuspendLayout();
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.Location = new System.Drawing.Point(19, 255);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(341, 47);
            this.refreshButton.TabIndex = 30;
            this.refreshButton.Text = "REFRESH (May take a moment)";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click_1);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 33);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(73, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.IMSA_logo_Nav_and_Footer_330x124;
            this.pictureBox1.Location = new System.Drawing.Point(12, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(859, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView1.DataSource = this.viewSecBatchPrintBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(361, 41);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(470, 204);
            this.dataGridView1.TabIndex = 36;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(406, 272);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(89, 30);
            this.textBox1.TabIndex = 55;
            // 
            // stopTimerButton
            // 
            this.stopTimerButton.BackColor = System.Drawing.Color.OrangeRed;
            this.stopTimerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopTimerButton.Location = new System.Drawing.Point(511, 260);
            this.stopTimerButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stopTimerButton.Name = "stopTimerButton";
            this.stopTimerButton.Size = new System.Drawing.Size(183, 51);
            this.stopTimerButton.TabIndex = 54;
            this.stopTimerButton.Text = "Stop Timer";
            this.stopTimerButton.UseVisualStyleBackColor = false;
            this.stopTimerButton.Click += new System.EventHandler(this.stopTimerButton_Click_1);
            // 
            // secTextBox
            // 
            this.secTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viewSecBatchPrintBindingSource1, "DisplayName", true));
            this.secTextBox.Location = new System.Drawing.Point(122, 128);
            this.secTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.secTextBox.Name = "secTextBox";
            this.secTextBox.Size = new System.Drawing.Size(223, 26);
            this.secTextBox.TabIndex = 3;
            // 
            // secSinglePrint
            // 
            this.secSinglePrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secSinglePrint.Location = new System.Drawing.Point(157, 210);
            this.secSinglePrint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.secSinglePrint.Name = "secSinglePrint";
            this.secSinglePrint.Size = new System.Drawing.Size(188, 35);
            this.secSinglePrint.TabIndex = 2;
            this.secSinglePrint.Text = "Print Single Event Credential";
            this.secSinglePrint.UseVisualStyleBackColor = true;
            this.secSinglePrint.Click += new System.EventHandler(this.secSinglePrint_Click_1);
            // 
            // secPrintPreviewButton
            // 
            this.secPrintPreviewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secPrintPreviewButton.Location = new System.Drawing.Point(19, 210);
            this.secPrintPreviewButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.secPrintPreviewButton.Name = "secPrintPreviewButton";
            this.secPrintPreviewButton.Size = new System.Drawing.Size(122, 35);
            this.secPrintPreviewButton.TabIndex = 1;
            this.secPrintPreviewButton.TabStop = false;
            this.secPrintPreviewButton.Text = "Print Preview";
            this.secPrintPreviewButton.UseVisualStyleBackColor = true;
            this.secPrintPreviewButton.Click += new System.EventHandler(this.secPrintPreviewButton_Click_1);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viewSecBatchPrintBindingSource1, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(121, 164);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(223, 26);
            this.idTextBox.TabIndex = 34;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(40, 167);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(43, 20);
            this.idLabel.TabIndex = 33;
            this.idLabel.Text = "ID #:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(44, 133);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(55, 20);
            this.nameLabel.TabIndex = 32;
            this.nameLabel.Text = "Name:";
            // 
            // printerComboBox
            // 
            this.printerComboBox.FormattingEnabled = true;
            this.printerComboBox.Location = new System.Drawing.Point(19, 41);
            this.printerComboBox.Name = "printerComboBox";
            this.printerComboBox.Size = new System.Drawing.Size(325, 28);
            this.printerComboBox.TabIndex = 25;
            this.printerComboBox.Text = "-SELECT A PRINTER-";
            // 
            // printSECBox
            // 
            this.printSECBox.Controls.Add(this.refreshButton);
            this.printSECBox.Controls.Add(this.dataGridView1);
            this.printSECBox.Controls.Add(this.bindingNavigator);
            this.printSECBox.Controls.Add(this.idTextBox);
            this.printSECBox.Controls.Add(this.idLabel);
            this.printSECBox.Controls.Add(this.nameLabel);
            this.printSECBox.Controls.Add(this.secTextBox);
            this.printSECBox.Controls.Add(this.secSinglePrint);
            this.printSECBox.Controls.Add(this.secPrintPreviewButton);
            this.printSECBox.Controls.Add(this.printerComboBox);
            this.printSECBox.Controls.Add(this.lblStatus);
            this.printSECBox.Location = new System.Drawing.Point(18, 310);
            this.printSECBox.Name = "printSECBox";
            this.printSECBox.Size = new System.Drawing.Size(838, 310);
            this.printSECBox.TabIndex = 56;
            this.printSECBox.TabStop = false;
            this.printSECBox.Text = "Single Event Credential";
            // 
            // bindingNavigator
            // 
            this.bindingNavigator.AddNewItem = null;
            this.bindingNavigator.BindingSource = this.viewSecBatchPrintBindingSource1;
            this.bindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator.DeleteItem = null;
            this.bindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bindingNavigator.Location = new System.Drawing.Point(412, 269);
            this.bindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator.Name = "bindingNavigator";
            this.bindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.bindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator.Size = new System.Drawing.Size(304, 38);
            this.bindingNavigator.TabIndex = 35;
            this.bindingNavigator.Text = "bindingNavigator";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(80, 87);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(183, 36);
            this.lblStatus.TabIndex = 31;
            this.lblStatus.Text = "(CardStatus)";
            // 
            // startTimerButton
            // 
            this.startTimerButton.BackColor = System.Drawing.Color.Lime;
            this.startTimerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTimerButton.Location = new System.Drawing.Point(207, 260);
            this.startTimerButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.startTimerButton.Name = "startTimerButton";
            this.startTimerButton.Size = new System.Drawing.Size(183, 51);
            this.startTimerButton.TabIndex = 53;
            this.startTimerButton.Text = "Start Timer";
            this.startTimerButton.UseVisualStyleBackColor = false;
            this.startTimerButton.Click += new System.EventHandler(this.startTimerButton_Click_1);
            // 
            // batchUncheckGroupBox
            // 
            this.batchUncheckGroupBox.Controls.Add(this.batch1CheckButton);
            this.batchUncheckGroupBox.Controls.Add(this.sqlDataTableAdapterButton);
            this.batchUncheckGroupBox.Controls.Add(this.closeConnectionButton);
            this.batchUncheckGroupBox.Controls.Add(this.dataGridView2);
            this.batchUncheckGroupBox.Controls.Add(this.idUncheckTextBox);
            this.batchUncheckGroupBox.Controls.Add(this.actionsMembershipNumLabel);
            this.batchUncheckGroupBox.Controls.Add(this.actionsSeasonLabel);
            this.batchUncheckGroupBox.Controls.Add(this.actionsTxtSeason);
            this.batchUncheckGroupBox.Location = new System.Drawing.Point(64, 626);
            this.batchUncheckGroupBox.Name = "batchUncheckGroupBox";
            this.batchUncheckGroupBox.Size = new System.Drawing.Size(760, 226);
            this.batchUncheckGroupBox.TabIndex = 52;
            this.batchUncheckGroupBox.TabStop = false;
            this.batchUncheckGroupBox.Text = "Batch Uncheck";
            // 
            // batch1CheckButton
            // 
            this.batch1CheckButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batch1CheckButton.Location = new System.Drawing.Point(8, 69);
            this.batch1CheckButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.batch1CheckButton.Name = "batch1CheckButton";
            this.batch1CheckButton.Size = new System.Drawing.Size(329, 35);
            this.batch1CheckButton.TabIndex = 29;
            this.batch1CheckButton.Text = "Check/Uncheck Batch";
            this.batch1CheckButton.UseVisualStyleBackColor = true;
            this.batch1CheckButton.Click += new System.EventHandler(this.batch1CheckButton_Click_1);
            // 
            // sqlDataTableAdapterButton
            // 
            this.sqlDataTableAdapterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqlDataTableAdapterButton.Location = new System.Drawing.Point(353, 24);
            this.sqlDataTableAdapterButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sqlDataTableAdapterButton.Name = "sqlDataTableAdapterButton";
            this.sqlDataTableAdapterButton.Size = new System.Drawing.Size(390, 35);
            this.sqlDataTableAdapterButton.TabIndex = 28;
            this.sqlDataTableAdapterButton.Text = "Connect to Database and Fill Table";
            this.sqlDataTableAdapterButton.UseVisualStyleBackColor = true;
            this.sqlDataTableAdapterButton.Click += new System.EventHandler(this.sqlDataTableAdapterButton_Click_1);
            // 
            // closeConnectionButton
            // 
            this.closeConnectionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeConnectionButton.Location = new System.Drawing.Point(353, 69);
            this.closeConnectionButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.closeConnectionButton.Name = "closeConnectionButton";
            this.closeConnectionButton.Size = new System.Drawing.Size(390, 35);
            this.closeConnectionButton.TabIndex = 27;
            this.closeConnectionButton.Text = "Close Connection";
            this.closeConnectionButton.UseVisualStyleBackColor = true;
            this.closeConnectionButton.Click += new System.EventHandler(this.closeConnectionButton_Click_1);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(7, 114);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.Size = new System.Drawing.Size(736, 95);
            this.dataGridView2.TabIndex = 19;
            // 
            // idUncheckTextBox
            // 
            this.idUncheckTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viewSecBatchPrintBindingSource1, "Id", true));
            this.idUncheckTextBox.Location = new System.Drawing.Point(237, 29);
            this.idUncheckTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.idUncheckTextBox.Name = "idUncheckTextBox";
            this.idUncheckTextBox.Size = new System.Drawing.Size(77, 26);
            this.idUncheckTextBox.TabIndex = 15;
            this.idUncheckTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // actionsMembershipNumLabel
            // 
            this.actionsMembershipNumLabel.AutoSize = true;
            this.actionsMembershipNumLabel.Location = new System.Drawing.Point(186, 32);
            this.actionsMembershipNumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.actionsMembershipNumLabel.Name = "actionsMembershipNumLabel";
            this.actionsMembershipNumLabel.Size = new System.Drawing.Size(43, 20);
            this.actionsMembershipNumLabel.TabIndex = 14;
            this.actionsMembershipNumLabel.Text = "ID #:";
            // 
            // actionsSeasonLabel
            // 
            this.actionsSeasonLabel.AutoSize = true;
            this.actionsSeasonLabel.Location = new System.Drawing.Point(9, 31);
            this.actionsSeasonLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.actionsSeasonLabel.Name = "actionsSeasonLabel";
            this.actionsSeasonLabel.Size = new System.Drawing.Size(68, 20);
            this.actionsSeasonLabel.TabIndex = 13;
            this.actionsSeasonLabel.Text = "Season:";
            // 
            // actionsTxtSeason
            // 
            this.actionsTxtSeason.Location = new System.Drawing.Point(87, 29);
            this.actionsTxtSeason.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.actionsTxtSeason.Name = "actionsTxtSeason";
            this.actionsTxtSeason.Size = new System.Drawing.Size(79, 26);
            this.actionsTxtSeason.TabIndex = 12;
            this.actionsTxtSeason.Text = "2020";
            this.actionsTxtSeason.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 218);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 25);
            this.label1.TabIndex = 62;
            this.label1.Text = "the selection in the drop down to the left. ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 193);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(776, 25);
            this.label3.TabIndex = 61;
            this.label3.Text = "Check in your “Printers and Scanners” to see what printers you have available and" +
    " make";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(160, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(649, 25);
            this.label2.TabIndex = 60;
            this.label2.Text = "For this program to work correctly be sure to select the appropriate printer. ";
            // 
            // notice
            // 
            this.notice.AutoSize = true;
            this.notice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notice.ForeColor = System.Drawing.Color.Red;
            this.notice.Location = new System.Drawing.Point(16, 161);
            this.notice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.notice.Name = "notice";
            this.notice.Size = new System.Drawing.Size(143, 32);
            this.notice.TabIndex = 59;
            this.notice.Text = "NOTICE: ";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DisplayName";
            this.dataGridViewTextBoxColumn1.HeaderText = "DisplayName";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn2.HeaderText = "Id";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "BatchPrint";
            this.dataGridViewCheckBoxColumn1.HeaderText = "BatchPrint";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 8;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Season";
            this.dataGridViewTextBoxColumn3.HeaderText = "Season";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // viewSecBatchPrintBindingSource1
            // 
            this.viewSecBatchPrintBindingSource1.DataMember = "view_SecBatchPrint";
            this.viewSecBatchPrintBindingSource1.DataSource = this.imsaAdminDevDataSet6;
            // 
            // imsaAdminDevDataSet6
            // 
            this.imsaAdminDevDataSet6.DataSetName = "ImsaAdminDevDataSet6";
            this.imsaAdminDevDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // imsaAdminDevDataSet5
            // 
            this.imsaAdminDevDataSet5.DataSetName = "ImsaAdminDevDataSet5";
            this.imsaAdminDevDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewSecBatchPrintBindingSource
            // 
            this.viewSecBatchPrintBindingSource.DataMember = "view_SecBatchPrint";
            this.viewSecBatchPrintBindingSource.DataSource = this.imsaAdminDevDataSet5;
            // 
            // view_SecBatchPrintTableAdapter
            // 
            this.view_SecBatchPrintTableAdapter.ClearBeforeFill = true;
            // 
            // view_SecBatchPrintTableAdapter1
            // 
            this.view_SecBatchPrintTableAdapter1.ClearBeforeFill = true;
            // 
            // viewSecBatchPrintBindingSource2
            // 
            this.viewSecBatchPrintBindingSource2.DataMember = "view_SecBatchPrint";
            this.viewSecBatchPrintBindingSource2.DataSource = this.view_SecBatchPrintAll;
            // 
            // view_SecBatchPrintAll
            // 
            this.view_SecBatchPrintAll.DataSetName = "view_SecBatchPrintAll";
            this.view_SecBatchPrintAll.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_SecBatchPrintTableAdapter2
            // 
            this.view_SecBatchPrintTableAdapter2.ClearBeforeFill = true;
            // 
            // Next_SEC_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 862);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.notice);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.stopTimerButton);
            this.Controls.Add(this.printSECBox);
            this.Controls.Add(this.startTimerButton);
            this.Controls.Add(this.batchUncheckGroupBox);
            this.Name = "Next_SEC_Form";
            this.Text = "Single Event Credentials (2021)";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.printSECBox.ResumeLayout(false);
            this.printSECBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).EndInit();
            this.bindingNavigator.ResumeLayout(false);
            this.bindingNavigator.PerformLayout();
            this.batchUncheckGroupBox.ResumeLayout(false);
            this.batchUncheckGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSecBatchPrintBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imsaAdminDevDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imsaAdminDevDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSecBatchPrintBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSecBatchPrintBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_SecBatchPrintAll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private ImsaAdminDevDataSet5 imsaAdminDevDataSet5;
        private System.Windows.Forms.BindingSource viewSecBatchPrintBindingSource;
        private ImsaAdminDevDataSet5TableAdapters.view_SecBatchPrintTableAdapter view_SecBatchPrintTableAdapter;
        private ImsaAdminDevDataSet6TableAdapters.view_SecBatchPrintTableAdapter view_SecBatchPrintTableAdapter1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.BindingSource viewSecBatchPrintBindingSource2;
        private view_SecBatchPrintAll view_SecBatchPrintAll;
        private view_SecBatchPrintAllTableAdapters.view_SecBatchPrintTableAdapter view_SecBatchPrintTableAdapter2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource viewSecBatchPrintBindingSource1;
        private ImsaAdminDevDataSet6 imsaAdminDevDataSet6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button stopTimerButton;
        private System.Windows.Forms.TextBox secTextBox;
        private System.Windows.Forms.Button secSinglePrint;
        private System.Windows.Forms.Button secPrintPreviewButton;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.ComboBox printerComboBox;
        private System.Windows.Forms.GroupBox printSECBox;
        private System.Windows.Forms.BindingNavigator bindingNavigator;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button startTimerButton;
        private System.Windows.Forms.GroupBox batchUncheckGroupBox;
        private System.Windows.Forms.Button batch1CheckButton;
        private System.Windows.Forms.Button sqlDataTableAdapterButton;
        private System.Windows.Forms.Button closeConnectionButton;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox idUncheckTextBox;
        private System.Windows.Forms.Label actionsMembershipNumLabel;
        private System.Windows.Forms.Label actionsSeasonLabel;
        private System.Windows.Forms.TextBox actionsTxtSeason;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label notice;
    }
}