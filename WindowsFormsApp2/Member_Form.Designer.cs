namespace WindowsFormsApp2
{
    partial class Member_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Member_Form));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.notice = new System.Windows.Forms.Label();
            this.informationGroupBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            this.cardMemberNumberTextBox = new System.Windows.Forms.TextBox();
            this.viewHardCardAllBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.imsaAdminDevDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imsaAdminDevDataSet = new WindowsFormsApp2.ImsaAdminDevDataSet();
            this.cardMemberNameTextBox = new System.Windows.Forms.TextBox();
            this.cardLicenseTypeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.allToolStrip = new System.Windows.Forms.ToolStrip();
            this.allToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.viewHardCardAllBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.viewHardCardAllBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imsaAdminDevDataSet7 = new WindowsFormsApp2.ImsaAdminDevDataSet7();
            this.batchUncheckGroupBox = new System.Windows.Forms.GroupBox();
            this.batch2CheckButton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.batch1CheckButton = new System.Windows.Forms.Button();
            this.sqlDataTableAdapterButton = new System.Windows.Forms.Button();
            this.actionsTxtMembershipNumber = new System.Windows.Forms.TextBox();
            this.closeConnectionButton = new System.Windows.Forms.Button();
            this.actionsMembershipNumLabel = new System.Windows.Forms.Label();
            this.actionsSeasonLabel = new System.Windows.Forms.Label();
            this.actionsTxtSeason = new System.Windows.Forms.TextBox();
            this.printGroupBox = new System.Windows.Forms.GroupBox();
            this.annualPrintAndClearAllButton = new System.Windows.Forms.Button();
            this.printerComboBox = new System.Windows.Forms.ComboBox();
            this.memberSinglePrint = new System.Windows.Forms.Button();
            this.memberPrintPreviewButton = new System.Windows.Forms.Button();
            this.imsaAdminDevDataSet1 = new WindowsFormsApp2.ImsaAdminDevDataSet1();
            this.imsaAdminDevDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_HardCard_AllTableAdapter = new WindowsFormsApp2.ImsaAdminDevDataSet7TableAdapters.view_HardCard_AllTableAdapter();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.lblStatus = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.imsaPictureBox = new System.Windows.Forms.PictureBox();
            this.view_HardCard_AllTableAdapter1 = new WindowsFormsApp2.ImsaAdminDevDataSetTableAdapters.view_HardCard_AllTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.stopTimerButton = new System.Windows.Forms.Button();
            this.startTimerButton = new System.Windows.Forms.Button();
            this.nameFullDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchPrint2DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.batchPrint1DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.informationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewHardCardAllBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imsaAdminDevDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imsaAdminDevDataSet)).BeginInit();
            this.allToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewHardCardAllBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewHardCardAllBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imsaAdminDevDataSet7)).BeginInit();
            this.batchUncheckGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.printGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imsaAdminDevDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imsaAdminDevDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imsaPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(124, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(593, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = " to see what printers you have available and make the selection in the drop down " +
    "to the right.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(727, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "For this program to work correctly be sure to select the appropriate printer. Che" +
    "ck in your “Printers and Scanners” ";
            // 
            // notice
            // 
            this.notice.AutoSize = true;
            this.notice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notice.ForeColor = System.Drawing.Color.Red;
            this.notice.Location = new System.Drawing.Point(3, 97);
            this.notice.Name = "notice";
            this.notice.Size = new System.Drawing.Size(99, 24);
            this.notice.TabIndex = 16;
            this.notice.Text = "NOTICE: ";
            // 
            // informationGroupBox
            // 
            this.informationGroupBox.Controls.Add(this.textBox1);
            this.informationGroupBox.Controls.Add(this.label5);
            this.informationGroupBox.Controls.Add(this.stopTimerButton);
            this.informationGroupBox.Controls.Add(this.refreshButton);
            this.informationGroupBox.Controls.Add(this.startTimerButton);
            this.informationGroupBox.Controls.Add(this.cardMemberNumberTextBox);
            this.informationGroupBox.Controls.Add(this.cardMemberNameTextBox);
            this.informationGroupBox.Controls.Add(this.cardLicenseTypeTextBox);
            this.informationGroupBox.Controls.Add(this.label1);
            this.informationGroupBox.Controls.Add(this.allToolStrip);
            this.informationGroupBox.Controls.Add(this.dataGridView1);
            this.informationGroupBox.Location = new System.Drawing.Point(8, 147);
            this.informationGroupBox.Name = "informationGroupBox";
            this.informationGroupBox.Size = new System.Drawing.Size(462, 320);
            this.informationGroupBox.TabIndex = 19;
            this.informationGroupBox.TabStop = false;
            this.informationGroupBox.Text = "Information";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 260);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Text for Card:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.Location = new System.Drawing.Point(12, 280);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(444, 34);
            this.refreshButton.TabIndex = 13;
            this.refreshButton.Text = "REFRESH\r\n(This may take a moment)";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // cardMemberNumberTextBox
            // 
            this.cardMemberNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viewHardCardAllBindingSource, "LicID", true));
            this.cardMemberNumberTextBox.Location = new System.Drawing.Point(328, 256);
            this.cardMemberNumberTextBox.Name = "cardMemberNumberTextBox";
            this.cardMemberNumberTextBox.Size = new System.Drawing.Size(101, 20);
            this.cardMemberNumberTextBox.TabIndex = 16;
            this.cardMemberNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // viewHardCardAllBindingSource1
            // 
            this.viewHardCardAllBindingSource1.DataMember = "view_HardCard_All";
            this.viewHardCardAllBindingSource1.DataSource = this.imsaAdminDevDataSetBindingSource;
            // 
            // imsaAdminDevDataSetBindingSource
            // 
            this.imsaAdminDevDataSetBindingSource.DataSource = this.imsaAdminDevDataSet;
            this.imsaAdminDevDataSetBindingSource.Position = 0;
            // 
            // imsaAdminDevDataSet
            // 
            this.imsaAdminDevDataSet.DataSetName = "ImsaAdminDevDataSet";
            this.imsaAdminDevDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cardMemberNameTextBox
            // 
            this.cardMemberNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viewHardCardAllBindingSource, "NameFull", true));
            this.cardMemberNameTextBox.Location = new System.Drawing.Point(118, 256);
            this.cardMemberNameTextBox.Name = "cardMemberNameTextBox";
            this.cardMemberNameTextBox.Size = new System.Drawing.Size(101, 20);
            this.cardMemberNameTextBox.TabIndex = 14;
            this.cardMemberNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cardLicenseTypeTextBox
            // 
            this.cardLicenseTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viewHardCardAllBindingSource, "Type", true));
            this.cardLicenseTypeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardLicenseTypeTextBox.Location = new System.Drawing.Point(222, 258);
            this.cardLicenseTypeTextBox.Name = "cardLicenseTypeTextBox";
            this.cardLicenseTypeTextBox.Size = new System.Drawing.Size(101, 18);
            this.cardLicenseTypeTextBox.TabIndex = 13;
            this.cardLicenseTypeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Batch Print Options";
            // 
            // allToolStrip
            // 
            this.allToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.allToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.allToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allToolStripButton});
            this.allToolStrip.Location = new System.Drawing.Point(109, 55);
            this.allToolStrip.Name = "allToolStrip";
            this.allToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.allToolStrip.Size = new System.Drawing.Size(38, 25);
            this.allToolStrip.TabIndex = 5;
            this.allToolStrip.Text = "allToolStrip";
            // 
            // allToolStripButton
            // 
            this.allToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.allToolStripButton.Name = "allToolStripButton";
            this.allToolStripButton.Size = new System.Drawing.Size(25, 22);
            this.allToolStripButton.Text = "All";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameFullDataGridViewTextBoxColumn,
            this.Type,
            this.licIDDataGridViewTextBoxColumn,
            this.batchPrint2DataGridViewCheckBoxColumn,
            this.batchPrint1DataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.viewHardCardAllBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(440, 172);
            this.dataGridView1.TabIndex = 10;
            // 
            // viewHardCardAllBindingSource2
            // 
            this.viewHardCardAllBindingSource2.DataMember = "view_HardCard_All";
            this.viewHardCardAllBindingSource2.DataSource = this.imsaAdminDevDataSetBindingSource;
            // 
            // viewHardCardAllBindingSource
            // 
            this.viewHardCardAllBindingSource.DataMember = "view_HardCard_All";
            this.viewHardCardAllBindingSource.DataSource = this.imsaAdminDevDataSet7;
            // 
            // imsaAdminDevDataSet7
            // 
            this.imsaAdminDevDataSet7.DataSetName = "ImsaAdminDevDataSet7";
            this.imsaAdminDevDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // batchUncheckGroupBox
            // 
            this.batchUncheckGroupBox.Controls.Add(this.batch2CheckButton);
            this.batchUncheckGroupBox.Controls.Add(this.dataGridView2);
            this.batchUncheckGroupBox.Controls.Add(this.batch1CheckButton);
            this.batchUncheckGroupBox.Controls.Add(this.sqlDataTableAdapterButton);
            this.batchUncheckGroupBox.Controls.Add(this.actionsTxtMembershipNumber);
            this.batchUncheckGroupBox.Controls.Add(this.closeConnectionButton);
            this.batchUncheckGroupBox.Controls.Add(this.actionsMembershipNumLabel);
            this.batchUncheckGroupBox.Controls.Add(this.actionsSeasonLabel);
            this.batchUncheckGroupBox.Controls.Add(this.actionsTxtSeason);
            this.batchUncheckGroupBox.Location = new System.Drawing.Point(481, 292);
            this.batchUncheckGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.batchUncheckGroupBox.Name = "batchUncheckGroupBox";
            this.batchUncheckGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.batchUncheckGroupBox.Size = new System.Drawing.Size(375, 174);
            this.batchUncheckGroupBox.TabIndex = 3;
            this.batchUncheckGroupBox.TabStop = false;
            this.batchUncheckGroupBox.Text = "Batch Uncheck";
            // 
            // batch2CheckButton
            // 
            this.batch2CheckButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batch2CheckButton.Location = new System.Drawing.Point(205, 75);
            this.batch2CheckButton.Name = "batch2CheckButton";
            this.batch2CheckButton.Size = new System.Drawing.Size(163, 23);
            this.batch2CheckButton.TabIndex = 30;
            this.batch2CheckButton.Text = "Check/Uncheck Batch 2";
            this.batch2CheckButton.UseVisualStyleBackColor = true;
            this.batch2CheckButton.Click += new System.EventHandler(this.batch2CheckButton_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(5, 104);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.Size = new System.Drawing.Size(362, 62);
            this.dataGridView2.TabIndex = 19;
            // 
            // batch1CheckButton
            // 
            this.batch1CheckButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batch1CheckButton.Location = new System.Drawing.Point(205, 45);
            this.batch1CheckButton.Name = "batch1CheckButton";
            this.batch1CheckButton.Size = new System.Drawing.Size(163, 23);
            this.batch1CheckButton.TabIndex = 29;
            this.batch1CheckButton.Text = "Check/Uncheck Batch 1";
            this.batch1CheckButton.UseVisualStyleBackColor = true;
            this.batch1CheckButton.Click += new System.EventHandler(this.batch1CheckButton_Click);
            // 
            // sqlDataTableAdapterButton
            // 
            this.sqlDataTableAdapterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqlDataTableAdapterButton.Location = new System.Drawing.Point(5, 42);
            this.sqlDataTableAdapterButton.Name = "sqlDataTableAdapterButton";
            this.sqlDataTableAdapterButton.Size = new System.Drawing.Size(163, 23);
            this.sqlDataTableAdapterButton.TabIndex = 28;
            this.sqlDataTableAdapterButton.Text = "Connect to Database and Fill Table";
            this.sqlDataTableAdapterButton.UseVisualStyleBackColor = true;
            this.sqlDataTableAdapterButton.Click += new System.EventHandler(this.sqlDataTableAdapterButton_Click);
            // 
            // actionsTxtMembershipNumber
            // 
            this.actionsTxtMembershipNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viewHardCardAllBindingSource, "LicID", true));
            this.actionsTxtMembershipNumber.Location = new System.Drawing.Point(283, 20);
            this.actionsTxtMembershipNumber.Name = "actionsTxtMembershipNumber";
            this.actionsTxtMembershipNumber.Size = new System.Drawing.Size(86, 20);
            this.actionsTxtMembershipNumber.TabIndex = 15;
            this.actionsTxtMembershipNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // closeConnectionButton
            // 
            this.closeConnectionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeConnectionButton.Location = new System.Drawing.Point(5, 71);
            this.closeConnectionButton.Name = "closeConnectionButton";
            this.closeConnectionButton.Size = new System.Drawing.Size(163, 23);
            this.closeConnectionButton.TabIndex = 27;
            this.closeConnectionButton.Text = "Close Connection";
            this.closeConnectionButton.UseVisualStyleBackColor = true;
            this.closeConnectionButton.Click += new System.EventHandler(this.closeConnectionButton_Click);
            // 
            // actionsMembershipNumLabel
            // 
            this.actionsMembershipNumLabel.AutoSize = true;
            this.actionsMembershipNumLabel.Location = new System.Drawing.Point(202, 22);
            this.actionsMembershipNumLabel.Name = "actionsMembershipNumLabel";
            this.actionsMembershipNumLabel.Size = new System.Drawing.Size(77, 13);
            this.actionsMembershipNumLabel.TabIndex = 14;
            this.actionsMembershipNumLabel.Text = "Membership #:";
            // 
            // actionsSeasonLabel
            // 
            this.actionsSeasonLabel.AutoSize = true;
            this.actionsSeasonLabel.Location = new System.Drawing.Point(6, 20);
            this.actionsSeasonLabel.Name = "actionsSeasonLabel";
            this.actionsSeasonLabel.Size = new System.Drawing.Size(46, 13);
            this.actionsSeasonLabel.TabIndex = 13;
            this.actionsSeasonLabel.Text = "Season:";
            // 
            // actionsTxtSeason
            // 
            this.actionsTxtSeason.Location = new System.Drawing.Point(58, 18);
            this.actionsTxtSeason.Name = "actionsTxtSeason";
            this.actionsTxtSeason.Size = new System.Drawing.Size(111, 20);
            this.actionsTxtSeason.TabIndex = 12;
            this.actionsTxtSeason.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // printGroupBox
            // 
            this.printGroupBox.Controls.Add(this.annualPrintAndClearAllButton);
            this.printGroupBox.Controls.Add(this.printerComboBox);
            this.printGroupBox.Controls.Add(this.memberSinglePrint);
            this.printGroupBox.Controls.Add(this.memberPrintPreviewButton);
            this.printGroupBox.Location = new System.Drawing.Point(481, 147);
            this.printGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.printGroupBox.Name = "printGroupBox";
            this.printGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.printGroupBox.Size = new System.Drawing.Size(375, 141);
            this.printGroupBox.TabIndex = 2;
            this.printGroupBox.TabStop = false;
            this.printGroupBox.Text = "Print";
            // 
            // annualPrintAndClearAllButton
            // 
            this.annualPrintAndClearAllButton.BackColor = System.Drawing.Color.OrangeRed;
            this.annualPrintAndClearAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annualPrintAndClearAllButton.Location = new System.Drawing.Point(24, 69);
            this.annualPrintAndClearAllButton.Name = "annualPrintAndClearAllButton";
            this.annualPrintAndClearAllButton.Size = new System.Drawing.Size(322, 29);
            this.annualPrintAndClearAllButton.TabIndex = 38;
            this.annualPrintAndClearAllButton.Text = "PRINT ALL";
            this.annualPrintAndClearAllButton.UseVisualStyleBackColor = false;
            this.annualPrintAndClearAllButton.Click += new System.EventHandler(this.annualPrintAndClearAllButton_Click);
            // 
            // printerComboBox
            // 
            this.printerComboBox.FormattingEnabled = true;
            this.printerComboBox.Location = new System.Drawing.Point(24, 16);
            this.printerComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.printerComboBox.Name = "printerComboBox";
            this.printerComboBox.Size = new System.Drawing.Size(324, 21);
            this.printerComboBox.TabIndex = 16;
            this.printerComboBox.Text = "-SELECT A PRINTER-";
            this.printerComboBox.SelectedIndexChanged += new System.EventHandler(this.printerComboBox_SelectedIndexChanged);
            // 
            // memberSinglePrint
            // 
            this.memberSinglePrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberSinglePrint.Location = new System.Drawing.Point(139, 40);
            this.memberSinglePrint.Name = "memberSinglePrint";
            this.memberSinglePrint.Size = new System.Drawing.Size(207, 23);
            this.memberSinglePrint.TabIndex = 2;
            this.memberSinglePrint.Text = "Print Member Card";
            this.memberSinglePrint.UseVisualStyleBackColor = true;
            this.memberSinglePrint.Click += new System.EventHandler(this.memberSinglePrint_Click);
            // 
            // memberPrintPreviewButton
            // 
            this.memberPrintPreviewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberPrintPreviewButton.Location = new System.Drawing.Point(24, 40);
            this.memberPrintPreviewButton.Name = "memberPrintPreviewButton";
            this.memberPrintPreviewButton.Size = new System.Drawing.Size(109, 23);
            this.memberPrintPreviewButton.TabIndex = 1;
            this.memberPrintPreviewButton.Text = "Print Preview";
            this.memberPrintPreviewButton.UseVisualStyleBackColor = true;
            this.memberPrintPreviewButton.Click += new System.EventHandler(this.memberPrintPreviewButton_Click);
            // 
            // imsaAdminDevDataSet1
            // 
            this.imsaAdminDevDataSet1.DataSetName = "ImsaAdminDevDataSet1";
            this.imsaAdminDevDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // imsaAdminDevDataSet1BindingSource
            // 
            this.imsaAdminDevDataSet1BindingSource.DataSource = this.imsaAdminDevDataSet1;
            this.imsaAdminDevDataSet1BindingSource.Position = 0;
            // 
            // view_HardCard_AllTableAdapter
            // 
            this.view_HardCard_AllTableAdapter.ClearBeforeFill = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(15, 560);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(22, 4);
            this.lblStatus.TabIndex = 27;
            this.lblStatus.Text = "(CardStatus)";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(33, 552);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.RowTemplate.Height = 28;
            this.dataGridView3.Size = new System.Drawing.Size(25, 10);
            this.dataGridView3.TabIndex = 20;
            // 
            // imsaPictureBox
            // 
            this.imsaPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imsaPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("imsaPictureBox.Image")));
            this.imsaPictureBox.Location = new System.Drawing.Point(-6, -21);
            this.imsaPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.imsaPictureBox.Name = "imsaPictureBox";
            this.imsaPictureBox.Size = new System.Drawing.Size(873, 115);
            this.imsaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imsaPictureBox.TabIndex = 38;
            this.imsaPictureBox.TabStop = false;
            // 
            // view_HardCard_AllTableAdapter1
            // 
            this.view_HardCard_AllTableAdapter1.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(200, 21);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(61, 23);
            this.textBox1.TabIndex = 45;
            // 
            // stopTimerButton
            // 
            this.stopTimerButton.BackColor = System.Drawing.Color.OrangeRed;
            this.stopTimerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopTimerButton.Location = new System.Drawing.Point(266, 16);
            this.stopTimerButton.Name = "stopTimerButton";
            this.stopTimerButton.Size = new System.Drawing.Size(122, 33);
            this.stopTimerButton.TabIndex = 44;
            this.stopTimerButton.Text = "Stop Timer";
            this.stopTimerButton.UseVisualStyleBackColor = false;
            this.stopTimerButton.Click += new System.EventHandler(this.stopTimerButton_Click);
            // 
            // startTimerButton
            // 
            this.startTimerButton.BackColor = System.Drawing.Color.Lime;
            this.startTimerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTimerButton.Location = new System.Drawing.Point(73, 16);
            this.startTimerButton.Name = "startTimerButton";
            this.startTimerButton.Size = new System.Drawing.Size(122, 33);
            this.startTimerButton.TabIndex = 43;
            this.startTimerButton.Text = "Start Timer";
            this.startTimerButton.UseVisualStyleBackColor = false;
            this.startTimerButton.Click += new System.EventHandler(this.startTimerButton_Click);
            // 
            // nameFullDataGridViewTextBoxColumn
            // 
            this.nameFullDataGridViewTextBoxColumn.DataPropertyName = "NameFull";
            this.nameFullDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameFullDataGridViewTextBoxColumn.Name = "nameFullDataGridViewTextBoxColumn";
            this.nameFullDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // licIDDataGridViewTextBoxColumn
            // 
            this.licIDDataGridViewTextBoxColumn.DataPropertyName = "LicID";
            this.licIDDataGridViewTextBoxColumn.HeaderText = "LicID";
            this.licIDDataGridViewTextBoxColumn.Name = "licIDDataGridViewTextBoxColumn";
            this.licIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // batchPrint2DataGridViewCheckBoxColumn
            // 
            this.batchPrint2DataGridViewCheckBoxColumn.DataPropertyName = "BatchPrint2";
            this.batchPrint2DataGridViewCheckBoxColumn.HeaderText = "Batch 2";
            this.batchPrint2DataGridViewCheckBoxColumn.Name = "batchPrint2DataGridViewCheckBoxColumn";
            this.batchPrint2DataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // batchPrint1DataGridViewCheckBoxColumn
            // 
            this.batchPrint1DataGridViewCheckBoxColumn.DataPropertyName = "BatchPrint1";
            this.batchPrint1DataGridViewCheckBoxColumn.HeaderText = "Batch 1";
            this.batchPrint1DataGridViewCheckBoxColumn.Name = "batchPrint1DataGridViewCheckBoxColumn";
            this.batchPrint1DataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // Member_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 482);
            this.Controls.Add(this.imsaPictureBox);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.printGroupBox);
            this.Controls.Add(this.batchUncheckGroupBox);
            this.Controls.Add(this.informationGroupBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.notice);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Member_Form";
            this.Text = "Member Card";
            this.Load += new System.EventHandler(this.MemberCardForm_Load);
            this.informationGroupBox.ResumeLayout(false);
            this.informationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewHardCardAllBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imsaAdminDevDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imsaAdminDevDataSet)).EndInit();
            this.allToolStrip.ResumeLayout(false);
            this.allToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewHardCardAllBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewHardCardAllBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imsaAdminDevDataSet7)).EndInit();
            this.batchUncheckGroupBox.ResumeLayout(false);
            this.batchUncheckGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.printGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imsaAdminDevDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imsaAdminDevDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imsaPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label notice;
        private System.Windows.Forms.GroupBox informationGroupBox;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.GroupBox batchUncheckGroupBox;
        private System.Windows.Forms.Button batch2CheckButton;
        private System.Windows.Forms.Button batch1CheckButton;
        private System.Windows.Forms.Button sqlDataTableAdapterButton;
        private System.Windows.Forms.Button closeConnectionButton;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox actionsTxtMembershipNumber;
        private System.Windows.Forms.Label actionsMembershipNumLabel;
        private System.Windows.Forms.Label actionsSeasonLabel;
        private System.Windows.Forms.TextBox actionsTxtSeason;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip allToolStrip;
        private System.Windows.Forms.ToolStripButton allToolStripButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox printGroupBox;
        private System.Windows.Forms.ComboBox printerComboBox;
        private System.Windows.Forms.Button memberSinglePrint;
        private System.Windows.Forms.Button memberPrintPreviewButton;
        private System.Windows.Forms.BindingSource imsaAdminDevDataSetBindingSource;
        private ImsaAdminDevDataSet imsaAdminDevDataSet;
        private System.Windows.Forms.BindingSource imsaAdminDevDataSet1BindingSource;
        private ImsaAdminDevDataSet1 imsaAdminDevDataSet1;
        private ImsaAdminDevDataSet7 imsaAdminDevDataSet7;
        private System.Windows.Forms.BindingSource viewHardCardAllBindingSource;
        private ImsaAdminDevDataSet7TableAdapters.view_HardCard_AllTableAdapter view_HardCard_AllTableAdapter;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox cardMemberNumberTextBox;
        private System.Windows.Forms.TextBox cardMemberNameTextBox;
        private System.Windows.Forms.TextBox cardLicenseTypeTextBox;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.PictureBox imsaPictureBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button annualPrintAndClearAllButton;
        private System.Windows.Forms.BindingSource viewHardCardAllBindingSource1;
        private ImsaAdminDevDataSetTableAdapters.view_HardCard_AllTableAdapter view_HardCard_AllTableAdapter1;
        private System.Windows.Forms.BindingSource viewHardCardAllBindingSource2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button stopTimerButton;
        private System.Windows.Forms.Button startTimerButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameFullDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn licIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn batchPrint2DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn batchPrint1DataGridViewCheckBoxColumn;
    }
}