namespace WindowsFormsApp2
{
    partial class Next_Member_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Next_Member_Form));
            this.batchPrint2DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.batch2CheckButton = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.printGroupBox = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.printerComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.memberSinglePrint = new System.Windows.Forms.Button();
            this.memberPrintPreviewButton = new System.Windows.Forms.Button();
            this.imsaAdminDevDataSet = new WindowsFormsApp2.ImsaAdminDevDataSet();
            this.imsaAdminDevDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imsaAdminDevDataSet1 = new WindowsFormsApp2.ImsaAdminDevDataSet1();
            this.imsaAdminDevDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_HardCard_AllTableAdapter = new WindowsFormsApp2.ImsaAdminDevDataSet7TableAdapters.view_HardCard_AllTableAdapter();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.imsaPictureBox = new System.Windows.Forms.PictureBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.batchUncheckGroupBox = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.batch1CheckButton = new System.Windows.Forms.Button();
            this.sqlDataTableAdapterButton = new System.Windows.Forms.Button();
            this.actionsTxtMembershipNumber = new System.Windows.Forms.TextBox();
            this.viewHardCardAllBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imsaAdminDevDataSet7 = new WindowsFormsApp2.ImsaAdminDevDataSet7();
            this.closeConnectionButton = new System.Windows.Forms.Button();
            this.actionsMembershipNumLabel = new System.Windows.Forms.Label();
            this.actionsSeasonLabel = new System.Windows.Forms.Label();
            this.actionsTxtSeason = new System.Windows.Forms.TextBox();
            this.informationGroupBox = new System.Windows.Forms.GroupBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.cardMemberNumberTextBox = new System.Windows.Forms.TextBox();
            this.cardMemberNameTextBox = new System.Windows.Forms.TextBox();
            this.cardLicenseTypeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.allToolStrip = new System.Windows.Forms.ToolStrip();
            this.allToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameFullDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchPrint1DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.notice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.printGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imsaAdminDevDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imsaAdminDevDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imsaAdminDevDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imsaAdminDevDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imsaPictureBox)).BeginInit();
            this.batchUncheckGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewHardCardAllBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imsaAdminDevDataSet7)).BeginInit();
            this.informationGroupBox.SuspendLayout();
            this.allToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // batchPrint2DataGridViewCheckBoxColumn
            // 
            this.batchPrint2DataGridViewCheckBoxColumn.DataPropertyName = "BatchPrint2";
            this.batchPrint2DataGridViewCheckBoxColumn.HeaderText = "BatchPrint2";
            this.batchPrint2DataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.batchPrint2DataGridViewCheckBoxColumn.Name = "batchPrint2DataGridViewCheckBoxColumn";
            this.batchPrint2DataGridViewCheckBoxColumn.ReadOnly = true;
            this.batchPrint2DataGridViewCheckBoxColumn.Width = 80;
            // 
            // batch2CheckButton
            // 
            this.batch2CheckButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batch2CheckButton.Location = new System.Drawing.Point(307, 115);
            this.batch2CheckButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.batch2CheckButton.Name = "batch2CheckButton";
            this.batch2CheckButton.Size = new System.Drawing.Size(244, 35);
            this.batch2CheckButton.TabIndex = 30;
            this.batch2CheckButton.Text = "Check/Uncheck Batch 2";
            this.batch2CheckButton.UseVisualStyleBackColor = true;
            this.batch2CheckButton.Click += new System.EventHandler(this.batch2CheckButton_Click_1);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(56, 851);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.RowTemplate.Height = 28;
            this.dataGridView3.Size = new System.Drawing.Size(38, 15);
            this.dataGridView3.TabIndex = 45;
            // 
            // printGroupBox
            // 
            this.printGroupBox.Controls.Add(this.label7);
            this.printGroupBox.Controls.Add(this.printerComboBox);
            this.printGroupBox.Controls.Add(this.label4);
            this.printGroupBox.Controls.Add(this.memberSinglePrint);
            this.printGroupBox.Controls.Add(this.memberPrintPreviewButton);
            this.printGroupBox.Location = new System.Drawing.Point(728, 273);
            this.printGroupBox.Name = "printGroupBox";
            this.printGroupBox.Size = new System.Drawing.Size(563, 173);
            this.printGroupBox.TabIndex = 39;
            this.printGroupBox.TabStop = false;
            this.printGroupBox.Text = "Print";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(7, 25);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 25);
            this.label7.TabIndex = 35;
            this.label7.Text = "NOTICE: ";
            // 
            // printerComboBox
            // 
            this.printerComboBox.FormattingEnabled = true;
            this.printerComboBox.Location = new System.Drawing.Point(36, 85);
            this.printerComboBox.Name = "printerComboBox";
            this.printerComboBox.Size = new System.Drawing.Size(484, 28);
            this.printerComboBox.TabIndex = 16;
            this.printerComboBox.Text = "-SELECT A PRINTER-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(541, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Print Member Cards first, AC\'s printed remove the member from Batch.";
            // 
            // memberSinglePrint
            // 
            this.memberSinglePrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberSinglePrint.Location = new System.Drawing.Point(208, 121);
            this.memberSinglePrint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.memberSinglePrint.Name = "memberSinglePrint";
            this.memberSinglePrint.Size = new System.Drawing.Size(311, 35);
            this.memberSinglePrint.TabIndex = 2;
            this.memberSinglePrint.Text = "Print Member Card";
            this.memberSinglePrint.UseVisualStyleBackColor = true;
            this.memberSinglePrint.Click += new System.EventHandler(this.memberSinglePrint_Click);
            // 
            // memberPrintPreviewButton
            // 
            this.memberPrintPreviewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberPrintPreviewButton.Location = new System.Drawing.Point(36, 121);
            this.memberPrintPreviewButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.memberPrintPreviewButton.Name = "memberPrintPreviewButton";
            this.memberPrintPreviewButton.Size = new System.Drawing.Size(164, 35);
            this.memberPrintPreviewButton.TabIndex = 1;
            this.memberPrintPreviewButton.Text = "Print Preview";
            this.memberPrintPreviewButton.UseVisualStyleBackColor = true;
            this.memberPrintPreviewButton.Click += new System.EventHandler(this.memberPrintPreviewButton_Click_1);
            // 
            // imsaAdminDevDataSet
            // 
            this.imsaAdminDevDataSet.DataSetName = "ImsaAdminDevDataSet";
            this.imsaAdminDevDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // imsaAdminDevDataSetBindingSource
            // 
            this.imsaAdminDevDataSetBindingSource.DataSource = this.imsaAdminDevDataSet;
            this.imsaAdminDevDataSetBindingSource.Position = 0;
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
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // imsaPictureBox
            // 
            this.imsaPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imsaPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("imsaPictureBox.Image")));
            this.imsaPictureBox.Location = new System.Drawing.Point(1, -32);
            this.imsaPictureBox.Name = "imsaPictureBox";
            this.imsaPictureBox.Size = new System.Drawing.Size(1309, 219);
            this.imsaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imsaPictureBox.TabIndex = 47;
            this.imsaPictureBox.TabStop = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(29, 863);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(24, 5);
            this.lblStatus.TabIndex = 46;
            this.lblStatus.Text = "(CardStatus)";
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
            this.batchUncheckGroupBox.Location = new System.Drawing.Point(728, 452);
            this.batchUncheckGroupBox.Name = "batchUncheckGroupBox";
            this.batchUncheckGroupBox.Size = new System.Drawing.Size(563, 268);
            this.batchUncheckGroupBox.TabIndex = 40;
            this.batchUncheckGroupBox.TabStop = false;
            this.batchUncheckGroupBox.Text = "Batch Uncheck";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(8, 160);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.Size = new System.Drawing.Size(543, 95);
            this.dataGridView2.TabIndex = 19;
            // 
            // batch1CheckButton
            // 
            this.batch1CheckButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batch1CheckButton.Location = new System.Drawing.Point(307, 70);
            this.batch1CheckButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.batch1CheckButton.Name = "batch1CheckButton";
            this.batch1CheckButton.Size = new System.Drawing.Size(244, 35);
            this.batch1CheckButton.TabIndex = 29;
            this.batch1CheckButton.Text = "Check/Uncheck Batch 1";
            this.batch1CheckButton.UseVisualStyleBackColor = true;
            this.batch1CheckButton.Click += new System.EventHandler(this.batch1CheckButton_Click_1);
            // 
            // sqlDataTableAdapterButton
            // 
            this.sqlDataTableAdapterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqlDataTableAdapterButton.Location = new System.Drawing.Point(7, 65);
            this.sqlDataTableAdapterButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sqlDataTableAdapterButton.Name = "sqlDataTableAdapterButton";
            this.sqlDataTableAdapterButton.Size = new System.Drawing.Size(244, 35);
            this.sqlDataTableAdapterButton.TabIndex = 28;
            this.sqlDataTableAdapterButton.Text = "Connect to Database and Fill Table";
            this.sqlDataTableAdapterButton.UseVisualStyleBackColor = true;
            this.sqlDataTableAdapterButton.Click += new System.EventHandler(this.sqlDataTableAdapterButton_Click_1);
            // 
            // actionsTxtMembershipNumber
            // 
            this.actionsTxtMembershipNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viewHardCardAllBindingSource, "LicID", true));
            this.actionsTxtMembershipNumber.Location = new System.Drawing.Point(424, 31);
            this.actionsTxtMembershipNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.actionsTxtMembershipNumber.Name = "actionsTxtMembershipNumber";
            this.actionsTxtMembershipNumber.Size = new System.Drawing.Size(127, 26);
            this.actionsTxtMembershipNumber.TabIndex = 15;
            this.actionsTxtMembershipNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // closeConnectionButton
            // 
            this.closeConnectionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeConnectionButton.Location = new System.Drawing.Point(8, 110);
            this.closeConnectionButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.closeConnectionButton.Name = "closeConnectionButton";
            this.closeConnectionButton.Size = new System.Drawing.Size(244, 35);
            this.closeConnectionButton.TabIndex = 27;
            this.closeConnectionButton.Text = "Close Connection";
            this.closeConnectionButton.UseVisualStyleBackColor = true;
            this.closeConnectionButton.Click += new System.EventHandler(this.closeConnectionButton_Click_1);
            // 
            // actionsMembershipNumLabel
            // 
            this.actionsMembershipNumLabel.AutoSize = true;
            this.actionsMembershipNumLabel.Location = new System.Drawing.Point(303, 34);
            this.actionsMembershipNumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.actionsMembershipNumLabel.Name = "actionsMembershipNumLabel";
            this.actionsMembershipNumLabel.Size = new System.Drawing.Size(113, 20);
            this.actionsMembershipNumLabel.TabIndex = 14;
            this.actionsMembershipNumLabel.Text = "Membership #:";
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
            this.actionsTxtSeason.Location = new System.Drawing.Point(87, 28);
            this.actionsTxtSeason.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.actionsTxtSeason.Name = "actionsTxtSeason";
            this.actionsTxtSeason.Size = new System.Drawing.Size(165, 26);
            this.actionsTxtSeason.TabIndex = 12;
            this.actionsTxtSeason.Text = "2020";
            this.actionsTxtSeason.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // informationGroupBox
            // 
            this.informationGroupBox.Controls.Add(this.refreshButton);
            this.informationGroupBox.Controls.Add(this.cardMemberNumberTextBox);
            this.informationGroupBox.Controls.Add(this.cardMemberNameTextBox);
            this.informationGroupBox.Controls.Add(this.cardLicenseTypeTextBox);
            this.informationGroupBox.Controls.Add(this.label1);
            this.informationGroupBox.Controls.Add(this.allToolStrip);
            this.informationGroupBox.Controls.Add(this.dataGridView1);
            this.informationGroupBox.Location = new System.Drawing.Point(19, 273);
            this.informationGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.informationGroupBox.Name = "informationGroupBox";
            this.informationGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.informationGroupBox.Size = new System.Drawing.Size(693, 447);
            this.informationGroupBox.TabIndex = 44;
            this.informationGroupBox.TabStop = false;
            this.informationGroupBox.Text = "Information";
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.Location = new System.Drawing.Point(19, 378);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(666, 52);
            this.refreshButton.TabIndex = 13;
            this.refreshButton.Text = "REFRESH\r\n(This may take a moment)";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click_1);
            // 
            // cardMemberNumberTextBox
            // 
            this.cardMemberNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viewHardCardAllBindingSource, "LicID", true));
            this.cardMemberNumberTextBox.Location = new System.Drawing.Point(494, 342);
            this.cardMemberNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cardMemberNumberTextBox.Name = "cardMemberNumberTextBox";
            this.cardMemberNumberTextBox.Size = new System.Drawing.Size(150, 26);
            this.cardMemberNumberTextBox.TabIndex = 16;
            this.cardMemberNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cardMemberNameTextBox
            // 
            this.cardMemberNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viewHardCardAllBindingSource, "NameFull", true));
            this.cardMemberNameTextBox.Location = new System.Drawing.Point(178, 342);
            this.cardMemberNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cardMemberNameTextBox.Name = "cardMemberNameTextBox";
            this.cardMemberNameTextBox.Size = new System.Drawing.Size(150, 26);
            this.cardMemberNameTextBox.TabIndex = 14;
            this.cardMemberNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cardLicenseTypeTextBox
            // 
            this.cardLicenseTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viewHardCardAllBindingSource, "Type", true));
            this.cardLicenseTypeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardLicenseTypeTextBox.Location = new System.Drawing.Point(334, 345);
            this.cardLicenseTypeTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cardLicenseTypeTextBox.Name = "cardLicenseTypeTextBox";
            this.cardLicenseTypeTextBox.Size = new System.Drawing.Size(150, 23);
            this.cardLicenseTypeTextBox.TabIndex = 13;
            this.cardLicenseTypeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Batch Print Options";
            // 
            // allToolStrip
            // 
            this.allToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.allToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.allToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allToolStripButton});
            this.allToolStrip.Location = new System.Drawing.Point(159, 29);
            this.allToolStrip.Name = "allToolStrip";
            this.allToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.allToolStrip.Size = new System.Drawing.Size(55, 34);
            this.allToolStrip.TabIndex = 5;
            this.allToolStrip.Text = "allToolStrip";
            // 
            // allToolStripButton
            // 
            this.allToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.allToolStripButton.Name = "allToolStripButton";
            this.allToolStripButton.Size = new System.Drawing.Size(36, 29);
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
            this.licIDDataGridViewTextBoxColumn,
            this.Type,
            this.batchPrint1DataGridViewCheckBoxColumn,
            this.batchPrint2DataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.viewHardCardAllBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 68);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(660, 264);
            this.dataGridView1.TabIndex = 10;
            // 
            // nameFullDataGridViewTextBoxColumn
            // 
            this.nameFullDataGridViewTextBoxColumn.DataPropertyName = "NameFull";
            this.nameFullDataGridViewTextBoxColumn.HeaderText = "NameFull";
            this.nameFullDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameFullDataGridViewTextBoxColumn.Name = "nameFullDataGridViewTextBoxColumn";
            this.nameFullDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameFullDataGridViewTextBoxColumn.Width = 125;
            // 
            // licIDDataGridViewTextBoxColumn
            // 
            this.licIDDataGridViewTextBoxColumn.DataPropertyName = "LicID";
            this.licIDDataGridViewTextBoxColumn.HeaderText = "LicID";
            this.licIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.licIDDataGridViewTextBoxColumn.Name = "licIDDataGridViewTextBoxColumn";
            this.licIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.licIDDataGridViewTextBoxColumn.Width = 75;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 8;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 150;
            // 
            // batchPrint1DataGridViewCheckBoxColumn
            // 
            this.batchPrint1DataGridViewCheckBoxColumn.DataPropertyName = "BatchPrint1";
            this.batchPrint1DataGridViewCheckBoxColumn.HeaderText = "BatchPrint1";
            this.batchPrint1DataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.batchPrint1DataGridViewCheckBoxColumn.Name = "batchPrint1DataGridViewCheckBoxColumn";
            this.batchPrint1DataGridViewCheckBoxColumn.ReadOnly = true;
            this.batchPrint1DataGridViewCheckBoxColumn.Width = 80;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(212, 230);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(795, 25);
            this.label3.TabIndex = 43;
            this.label3.Text = " to see what printer you have available and make the selection in the drop down t" +
    "o the right.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(161, 197);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1473, 38);
            this.label2.TabIndex = 42;
            this.label2.Text = "For this program to work correctly be sure to select the appropriate printer. Che" +
    "ck in your “Printers and Scanners”";
            // 
            // notice
            // 
            this.notice.AutoSize = true;
            this.notice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notice.ForeColor = System.Drawing.Color.Red;
            this.notice.Location = new System.Drawing.Point(21, 190);
            this.notice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.notice.Name = "notice";
            this.notice.Size = new System.Drawing.Size(143, 32);
            this.notice.TabIndex = 41;
            this.notice.Text = "NOTICE: ";
            // 
            // Next_Member_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 742);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.printGroupBox);
            this.Controls.Add(this.imsaPictureBox);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.batchUncheckGroupBox);
            this.Controls.Add(this.informationGroupBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.notice);
            this.Name = "Next_Member_Form";
            this.Text = "Member Card (2021)";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.printGroupBox.ResumeLayout(false);
            this.printGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imsaAdminDevDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imsaAdminDevDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imsaAdminDevDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imsaAdminDevDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imsaPictureBox)).EndInit();
            this.batchUncheckGroupBox.ResumeLayout(false);
            this.batchUncheckGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewHardCardAllBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imsaAdminDevDataSet7)).EndInit();
            this.informationGroupBox.ResumeLayout(false);
            this.informationGroupBox.PerformLayout();
            this.allToolStrip.ResumeLayout(false);
            this.allToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewCheckBoxColumn batchPrint2DataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button batch2CheckButton;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.GroupBox printGroupBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox printerComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button memberSinglePrint;
        private System.Windows.Forms.Button memberPrintPreviewButton;
        private ImsaAdminDevDataSet imsaAdminDevDataSet;
        private System.Windows.Forms.BindingSource imsaAdminDevDataSetBindingSource;
        private ImsaAdminDevDataSet1 imsaAdminDevDataSet1;
        private System.Windows.Forms.BindingSource imsaAdminDevDataSet1BindingSource;
        private ImsaAdminDevDataSet7TableAdapters.view_HardCard_AllTableAdapter view_HardCard_AllTableAdapter;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PictureBox imsaPictureBox;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox batchUncheckGroupBox;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button batch1CheckButton;
        private System.Windows.Forms.Button sqlDataTableAdapterButton;
        private System.Windows.Forms.TextBox actionsTxtMembershipNumber;
        private System.Windows.Forms.BindingSource viewHardCardAllBindingSource;
        private ImsaAdminDevDataSet7 imsaAdminDevDataSet7;
        private System.Windows.Forms.Button closeConnectionButton;
        private System.Windows.Forms.Label actionsMembershipNumLabel;
        private System.Windows.Forms.Label actionsSeasonLabel;
        private System.Windows.Forms.TextBox actionsTxtSeason;
        private System.Windows.Forms.GroupBox informationGroupBox;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.TextBox cardMemberNumberTextBox;
        private System.Windows.Forms.TextBox cardMemberNameTextBox;
        private System.Windows.Forms.TextBox cardLicenseTypeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip allToolStrip;
        private System.Windows.Forms.ToolStripButton allToolStripButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameFullDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn licIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewCheckBoxColumn batchPrint1DataGridViewCheckBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label notice;
    }
}