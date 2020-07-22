namespace WindowsFormsApp2
{
    partial class SelectionScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectionScreen));
            this.imsaPictureBox = new System.Windows.Forms.PictureBox();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.welcomeLabel2 = new System.Windows.Forms.Label();
            this.acButton = new System.Windows.Forms.Button();
            this.acTimerButton = new System.Windows.Forms.Button();
            this.memButton = new System.Windows.Forms.Button();
            this.secButton = new System.Windows.Forms.Button();
            this.notesButton = new System.Windows.Forms.Button();
            this.nextSeasonButton = new System.Windows.Forms.Button();
            this.acDescriptionLabel = new System.Windows.Forms.Label();
            this.acTimerDescriptionLabel = new System.Windows.Forms.Label();
            this.memberDescriptionLabel = new System.Windows.Forms.Label();
            this.secDescriptionLabel = new System.Windows.Forms.Label();
            this.notesDescriptionLabel = new System.Windows.Forms.Label();
            this.nextSeasonDescriptionLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imsaPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // imsaPictureBox
            // 
            this.imsaPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imsaPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("imsaPictureBox.Image")));
            this.imsaPictureBox.Location = new System.Drawing.Point(-18, -22);
            this.imsaPictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.imsaPictureBox.Name = "imsaPictureBox";
            this.imsaPictureBox.Size = new System.Drawing.Size(611, 129);
            this.imsaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imsaPictureBox.TabIndex = 0;
            this.imsaPictureBox.TabStop = false;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(164, 146);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(265, 17);
            this.welcomeLabel.TabIndex = 1;
            this.welcomeLabel.Text = "Welcome to the IMSA Hard Card Printer. ";
            // 
            // welcomeLabel2
            // 
            this.welcomeLabel2.AutoSize = true;
            this.welcomeLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel2.Location = new System.Drawing.Point(57, 163);
            this.welcomeLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcomeLabel2.Name = "welcomeLabel2";
            this.welcomeLabel2.Size = new System.Drawing.Size(509, 17);
            this.welcomeLabel2.TabIndex = 2;
            this.welcomeLabel2.Text = "Please make a selection from below for the type of printer you would like to use." +
    "";
            // 
            // acButton
            // 
            this.acButton.BackColor = System.Drawing.Color.Red;
            this.acButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.acButton.Location = new System.Drawing.Point(159, 181);
            this.acButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.acButton.Name = "acButton";
            this.acButton.Size = new System.Drawing.Size(243, 44);
            this.acButton.TabIndex = 3;
            this.acButton.Text = "Annual Credential\r\n(w/ Photo Editor)";
            this.acButton.UseVisualStyleBackColor = false;
            this.acButton.Click += new System.EventHandler(this.acButton_Click);
            // 
            // acTimerButton
            // 
            this.acTimerButton.BackColor = System.Drawing.Color.Red;
            this.acTimerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acTimerButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.acTimerButton.Location = new System.Drawing.Point(159, 252);
            this.acTimerButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.acTimerButton.Name = "acTimerButton";
            this.acTimerButton.Size = new System.Drawing.Size(243, 44);
            this.acTimerButton.TabIndex = 4;
            this.acTimerButton.Text = "Annual Credential \r\n(w/ Timer)";
            this.acTimerButton.UseVisualStyleBackColor = false;
            this.acTimerButton.Click += new System.EventHandler(this.acTimerButton_Click);
            // 
            // memButton
            // 
            this.memButton.BackColor = System.Drawing.Color.Red;
            this.memButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.memButton.Location = new System.Drawing.Point(159, 327);
            this.memButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.memButton.Name = "memButton";
            this.memButton.Size = new System.Drawing.Size(243, 44);
            this.memButton.TabIndex = 5;
            this.memButton.Text = "Member Card";
            this.memButton.UseVisualStyleBackColor = false;
            this.memButton.Click += new System.EventHandler(this.memButton_Click);
            // 
            // secButton
            // 
            this.secButton.BackColor = System.Drawing.Color.Red;
            this.secButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.secButton.Location = new System.Drawing.Point(159, 398);
            this.secButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.secButton.Name = "secButton";
            this.secButton.Size = new System.Drawing.Size(243, 44);
            this.secButton.TabIndex = 6;
            this.secButton.Text = "Single Event Credential";
            this.secButton.UseVisualStyleBackColor = false;
            this.secButton.Click += new System.EventHandler(this.secButton_Click);
            // 
            // notesButton
            // 
            this.notesButton.BackColor = System.Drawing.Color.Red;
            this.notesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.notesButton.Location = new System.Drawing.Point(159, 469);
            this.notesButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.notesButton.Name = "notesButton";
            this.notesButton.Size = new System.Drawing.Size(243, 44);
            this.notesButton.TabIndex = 7;
            this.notesButton.Text = "Notes";
            this.notesButton.UseVisualStyleBackColor = false;
            this.notesButton.Click += new System.EventHandler(this.notesButton_Click);
            // 
            // nextSeasonButton
            // 
            this.nextSeasonButton.BackColor = System.Drawing.Color.Red;
            this.nextSeasonButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextSeasonButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nextSeasonButton.Location = new System.Drawing.Point(159, 543);
            this.nextSeasonButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nextSeasonButton.Name = "nextSeasonButton";
            this.nextSeasonButton.Size = new System.Drawing.Size(243, 44);
            this.nextSeasonButton.TabIndex = 8;
            this.nextSeasonButton.Text = "Next Season Options";
            this.nextSeasonButton.UseVisualStyleBackColor = false;
            this.nextSeasonButton.Click += new System.EventHandler(this.nextSeasonButton_Click);
            // 
            // acDescriptionLabel
            // 
            this.acDescriptionLabel.AutoSize = true;
            this.acDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acDescriptionLabel.Location = new System.Drawing.Point(143, 227);
            this.acDescriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.acDescriptionLabel.Name = "acDescriptionLabel";
            this.acDescriptionLabel.Size = new System.Drawing.Size(281, 15);
            this.acDescriptionLabel.TabIndex = 9;
            this.acDescriptionLabel.Text = "Options to edit photos, print individually, or print all.";
            // 
            // acTimerDescriptionLabel
            // 
            this.acTimerDescriptionLabel.AutoSize = true;
            this.acTimerDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acTimerDescriptionLabel.Location = new System.Drawing.Point(90, 298);
            this.acTimerDescriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.acTimerDescriptionLabel.Name = "acTimerDescriptionLabel";
            this.acTimerDescriptionLabel.Size = new System.Drawing.Size(398, 15);
            this.acTimerDescriptionLabel.TabIndex = 10;
            this.acTimerDescriptionLabel.Text = "Options to print individual, all or timer printing all. (Refresh every 30 sec.)";
            // 
            // memberDescriptionLabel
            // 
            this.memberDescriptionLabel.AutoSize = true;
            this.memberDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberDescriptionLabel.Location = new System.Drawing.Point(131, 372);
            this.memberDescriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.memberDescriptionLabel.Name = "memberDescriptionLabel";
            this.memberDescriptionLabel.Size = new System.Drawing.Size(315, 15);
            this.memberDescriptionLabel.TabIndex = 11;
            this.memberDescriptionLabel.Text = "Print cards individually and leaves the Members in batch.";
            // 
            // secDescriptionLabel
            // 
            this.secDescriptionLabel.AutoSize = true;
            this.secDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secDescriptionLabel.Location = new System.Drawing.Point(100, 443);
            this.secDescriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.secDescriptionLabel.Name = "secDescriptionLabel";
            this.secDescriptionLabel.Size = new System.Drawing.Size(381, 15);
            this.secDescriptionLabel.TabIndex = 12;
            this.secDescriptionLabel.Text = "Option to print individually or timer printing all. (Refresh every 30 sec.)";
            // 
            // notesDescriptionLabel
            // 
            this.notesDescriptionLabel.AutoSize = true;
            this.notesDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesDescriptionLabel.Location = new System.Drawing.Point(143, 514);
            this.notesDescriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.notesDescriptionLabel.Name = "notesDescriptionLabel";
            this.notesDescriptionLabel.Size = new System.Drawing.Size(286, 15);
            this.notesDescriptionLabel.TabIndex = 13;
            this.notesDescriptionLabel.Text = "Update notes, placement, and sequential numbers.";
            // 
            // nextSeasonDescriptionLabel
            // 
            this.nextSeasonDescriptionLabel.AutoSize = true;
            this.nextSeasonDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextSeasonDescriptionLabel.Location = new System.Drawing.Point(131, 588);
            this.nextSeasonDescriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nextSeasonDescriptionLabel.Name = "nextSeasonDescriptionLabel";
            this.nextSeasonDescriptionLabel.Size = new System.Drawing.Size(309, 15);
            this.nextSeasonDescriptionLabel.TabIndex = 14;
            this.nextSeasonDescriptionLabel.Text = "Open the same menu, but for next years season. (2021)";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLabel.ForeColor = System.Drawing.Color.Red;
            this.yearLabel.Location = new System.Drawing.Point(236, 109);
            this.yearLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(0, 37);
            this.yearLabel.TabIndex = 15;
            // 
            // SelectionScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 625);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.nextSeasonDescriptionLabel);
            this.Controls.Add(this.notesDescriptionLabel);
            this.Controls.Add(this.secDescriptionLabel);
            this.Controls.Add(this.memberDescriptionLabel);
            this.Controls.Add(this.acTimerDescriptionLabel);
            this.Controls.Add(this.acDescriptionLabel);
            this.Controls.Add(this.nextSeasonButton);
            this.Controls.Add(this.notesButton);
            this.Controls.Add(this.secButton);
            this.Controls.Add(this.memButton);
            this.Controls.Add(this.acTimerButton);
            this.Controls.Add(this.acButton);
            this.Controls.Add(this.welcomeLabel2);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.imsaPictureBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SelectionScreen";
            this.Text = "IMSA Hard Card Printer";
            this.Load += new System.EventHandler(this.SelectionScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imsaPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imsaPictureBox;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label welcomeLabel2;
        private System.Windows.Forms.Button acButton;
        private System.Windows.Forms.Button acTimerButton;
        private System.Windows.Forms.Button memButton;
        private System.Windows.Forms.Button secButton;
        private System.Windows.Forms.Button notesButton;
        private System.Windows.Forms.Button nextSeasonButton;
        private System.Windows.Forms.Label acDescriptionLabel;
        private System.Windows.Forms.Label acTimerDescriptionLabel;
        private System.Windows.Forms.Label memberDescriptionLabel;
        private System.Windows.Forms.Label secDescriptionLabel;
        private System.Windows.Forms.Label notesDescriptionLabel;
        private System.Windows.Forms.Label nextSeasonDescriptionLabel;
        private System.Windows.Forms.Label yearLabel;
    }
}