namespace WindowsFormsApp2
{
    partial class Notes_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notes_Form));
            this.updateNoteAndSequentialButton = new System.Windows.Forms.Button();
            this.updateSequentialButton = new System.Windows.Forms.Button();
            this.sequentialText = new System.Windows.Forms.TextBox();
            this.sequentialLabel = new System.Windows.Forms.Label();
            this.sqlDataTableAdapter3 = new System.Windows.Forms.Button();
            this.membershipText = new System.Windows.Forms.TextBox();
            this.insertNoteButton = new System.Windows.Forms.Button();
            this.membershipLabel = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.noteComboBox = new System.Windows.Forms.ComboBox();
            this.typedNoteButton = new System.Windows.Forms.Button();
            this.typedTextBox = new System.Windows.Forms.TextBox();
            this.imsaPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.seasonLabel = new System.Windows.Forms.Label();
            this.actionsTxtSeason = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imsaPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // updateNoteAndSequentialButton
            // 
            this.updateNoteAndSequentialButton.AllowDrop = true;
            this.updateNoteAndSequentialButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateNoteAndSequentialButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.updateNoteAndSequentialButton.Location = new System.Drawing.Point(18, 480);
            this.updateNoteAndSequentialButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updateNoteAndSequentialButton.Name = "updateNoteAndSequentialButton";
            this.updateNoteAndSequentialButton.Size = new System.Drawing.Size(645, 35);
            this.updateNoteAndSequentialButton.TabIndex = 35;
            this.updateNoteAndSequentialButton.Text = "Update \'Selected\' Note and Sequential Number";
            this.updateNoteAndSequentialButton.UseVisualStyleBackColor = true;
            this.updateNoteAndSequentialButton.Click += new System.EventHandler(this.updateNoteAndSequentialButton_Click);
            // 
            // updateSequentialButton
            // 
            this.updateSequentialButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateSequentialButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.updateSequentialButton.Location = new System.Drawing.Point(317, 438);
            this.updateSequentialButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updateSequentialButton.Name = "updateSequentialButton";
            this.updateSequentialButton.Size = new System.Drawing.Size(345, 35);
            this.updateSequentialButton.TabIndex = 34;
            this.updateSequentialButton.Text = "Update Sequential Number";
            this.updateSequentialButton.UseVisualStyleBackColor = true;
            this.updateSequentialButton.Click += new System.EventHandler(this.updateSequentialButton_Click);
            // 
            // sequentialText
            // 
            this.sequentialText.Location = new System.Drawing.Point(133, 441);
            this.sequentialText.Name = "sequentialText";
            this.sequentialText.Size = new System.Drawing.Size(172, 26);
            this.sequentialText.TabIndex = 33;
            // 
            // sequentialLabel
            // 
            this.sequentialLabel.AutoSize = true;
            this.sequentialLabel.Location = new System.Drawing.Point(18, 447);
            this.sequentialLabel.Name = "sequentialLabel";
            this.sequentialLabel.Size = new System.Drawing.Size(102, 20);
            this.sequentialLabel.TabIndex = 32;
            this.sequentialLabel.Text = "Sequential #:";
            // 
            // sqlDataTableAdapter3
            // 
            this.sqlDataTableAdapter3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqlDataTableAdapter3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sqlDataTableAdapter3.Location = new System.Drawing.Point(317, 355);
            this.sqlDataTableAdapter3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sqlDataTableAdapter3.Name = "sqlDataTableAdapter3";
            this.sqlDataTableAdapter3.Size = new System.Drawing.Size(345, 35);
            this.sqlDataTableAdapter3.TabIndex = 31;
            this.sqlDataTableAdapter3.Text = "Connect Member";
            this.sqlDataTableAdapter3.UseVisualStyleBackColor = true;
            this.sqlDataTableAdapter3.Click += new System.EventHandler(this.sqlDataTableAdapter3_Click);
            // 
            // membershipText
            // 
            this.membershipText.Location = new System.Drawing.Point(137, 361);
            this.membershipText.Name = "membershipText";
            this.membershipText.Size = new System.Drawing.Size(170, 26);
            this.membershipText.TabIndex = 30;
            // 
            // insertNoteButton
            // 
            this.insertNoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertNoteButton.Location = new System.Drawing.Point(317, 396);
            this.insertNoteButton.Name = "insertNoteButton";
            this.insertNoteButton.Size = new System.Drawing.Size(345, 34);
            this.insertNoteButton.TabIndex = 28;
            this.insertNoteButton.Text = "Insert Selected Note";
            this.insertNoteButton.UseVisualStyleBackColor = true;
            this.insertNoteButton.Click += new System.EventHandler(this.insertNoteButton_Click);
            // 
            // membershipLabel
            // 
            this.membershipLabel.AutoSize = true;
            this.membershipLabel.Location = new System.Drawing.Point(14, 364);
            this.membershipLabel.Name = "membershipLabel";
            this.membershipLabel.Size = new System.Drawing.Size(113, 20);
            this.membershipLabel.TabIndex = 29;
            this.membershipLabel.Text = "Membership #:";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(17, 170);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.RowTemplate.Height = 28;
            this.dataGridView3.Size = new System.Drawing.Size(645, 177);
            this.dataGridView3.TabIndex = 1;
            // 
            // noteComboBox
            // 
            this.noteComboBox.FormattingEnabled = true;
            this.noteComboBox.Items.AddRange(new object[] {
            "Credential Box",
            "Driver Box",
            "Industry Support Envelope",
            "Mailed",
            "Media Box",
            "Partner Envelope",
            "Picked up at Registration",
            "Promoter Envelope",
            "Team Box (to be mailed)",
            "Team Envelope (to be picked up)",
            "Vendor Envelope"});
            this.noteComboBox.Location = new System.Drawing.Point(18, 400);
            this.noteComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.noteComboBox.Name = "noteComboBox";
            this.noteComboBox.Size = new System.Drawing.Size(280, 28);
            this.noteComboBox.TabIndex = 0;
            this.noteComboBox.Text = "-Select Note-";
            // 
            // typedNoteButton
            // 
            this.typedNoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typedNoteButton.Location = new System.Drawing.Point(317, 559);
            this.typedNoteButton.Name = "typedNoteButton";
            this.typedNoteButton.Size = new System.Drawing.Size(345, 34);
            this.typedNoteButton.TabIndex = 36;
            this.typedNoteButton.Text = "Insert Typed Note";
            this.typedNoteButton.UseVisualStyleBackColor = true;
            this.typedNoteButton.Click += new System.EventHandler(this.typedNoteButton_Click);
            // 
            // typedTextBox
            // 
            this.typedTextBox.Location = new System.Drawing.Point(26, 559);
            this.typedTextBox.Name = "typedTextBox";
            this.typedTextBox.Size = new System.Drawing.Size(285, 26);
            this.typedTextBox.TabIndex = 36;
            // 
            // imsaPictureBox
            // 
            this.imsaPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imsaPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("imsaPictureBox.Image")));
            this.imsaPictureBox.Location = new System.Drawing.Point(8, -17);
            this.imsaPictureBox.Name = "imsaPictureBox";
            this.imsaPictureBox.Size = new System.Drawing.Size(655, 152);
            this.imsaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imsaPictureBox.TabIndex = 37;
            this.imsaPictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(7, 520);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(593, 25);
            this.label1.TabIndex = 38;
            this.label1.Text = "If the note you want  is not in the drop down, you can type one here:";
            // 
            // seasonLabel
            // 
            this.seasonLabel.AutoSize = true;
            this.seasonLabel.Location = new System.Drawing.Point(243, 138);
            this.seasonLabel.Name = "seasonLabel";
            this.seasonLabel.Size = new System.Drawing.Size(68, 20);
            this.seasonLabel.TabIndex = 39;
            this.seasonLabel.Text = "Season:";
            this.seasonLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // actionsTxtSeason
            // 
            this.actionsTxtSeason.Location = new System.Drawing.Point(326, 135);
            this.actionsTxtSeason.Name = "actionsTxtSeason";
            this.actionsTxtSeason.Size = new System.Drawing.Size(93, 26);
            this.actionsTxtSeason.TabIndex = 40;
            this.actionsTxtSeason.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Notes_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 630);
            this.Controls.Add(this.seasonLabel);
            this.Controls.Add(this.actionsTxtSeason);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imsaPictureBox);
            this.Controls.Add(this.typedNoteButton);
            this.Controls.Add(this.typedTextBox);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.updateNoteAndSequentialButton);
            this.Controls.Add(this.noteComboBox);
            this.Controls.Add(this.updateSequentialButton);
            this.Controls.Add(this.membershipLabel);
            this.Controls.Add(this.sequentialText);
            this.Controls.Add(this.insertNoteButton);
            this.Controls.Add(this.sequentialLabel);
            this.Controls.Add(this.membershipText);
            this.Controls.Add(this.sqlDataTableAdapter3);
            this.Name = "Notes_Form";
            this.Text = "Notes";
            this.Load += new System.EventHandler(this.Notes_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imsaPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button updateNoteAndSequentialButton;
        private System.Windows.Forms.Button updateSequentialButton;
        private System.Windows.Forms.TextBox sequentialText;
        private System.Windows.Forms.Label sequentialLabel;
        private System.Windows.Forms.Button sqlDataTableAdapter3;
        private System.Windows.Forms.TextBox membershipText;
        private System.Windows.Forms.Button insertNoteButton;
        private System.Windows.Forms.Label membershipLabel;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.ComboBox noteComboBox;
        private System.Windows.Forms.Button typedNoteButton;
        private System.Windows.Forms.TextBox typedTextBox;
        private System.Windows.Forms.PictureBox imsaPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label seasonLabel;
        private System.Windows.Forms.TextBox actionsTxtSeason;
    }
}