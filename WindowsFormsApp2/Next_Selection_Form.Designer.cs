namespace WindowsFormsApp2
{
    partial class Next_Selection_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Next_Selection_Form));
            this.imsaPictureBox = new System.Windows.Forms.PictureBox();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.welcomeLabel2 = new System.Windows.Forms.Label();
            this.memButton = new System.Windows.Forms.Button();
            this.secButton = new System.Windows.Forms.Button();
            this.notesButton = new System.Windows.Forms.Button();
            this.notesDescriptionLabel = new System.Windows.Forms.Label();
            this.label2021 = new System.Windows.Forms.Label();
            this.acDescriptionLabel = new System.Windows.Forms.Label();
            this.acButton = new System.Windows.Forms.Button();
            this.acTimerButton = new System.Windows.Forms.Button();
            this.acTimerDescriptionLabel = new System.Windows.Forms.Label();
            this.memberDescriptionLabel = new System.Windows.Forms.Label();
            this.secDescriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imsaPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // imsaPictureBox
            // 
            this.imsaPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imsaPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("imsaPictureBox.Image")));
            this.imsaPictureBox.Location = new System.Drawing.Point(-25, -25);
            this.imsaPictureBox.Name = "imsaPictureBox";
            this.imsaPictureBox.Size = new System.Drawing.Size(916, 208);
            this.imsaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imsaPictureBox.TabIndex = 15;
            this.imsaPictureBox.TabStop = false;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(230, 257);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(369, 25);
            this.welcomeLabel.TabIndex = 16;
            this.welcomeLabel.Text = "Welcome to the IMSA Hard Card Printer. ";
            // 
            // welcomeLabel2
            // 
            this.welcomeLabel2.AutoSize = true;
            this.welcomeLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel2.Location = new System.Drawing.Point(76, 282);
            this.welcomeLabel2.Name = "welcomeLabel2";
            this.welcomeLabel2.Size = new System.Drawing.Size(693, 25);
            this.welcomeLabel2.TabIndex = 17;
            this.welcomeLabel2.Text = "Please make a selection from below for the type of printer you would like to use." +
    "";
            // 
            // memButton
            // 
            this.memButton.BackColor = System.Drawing.Color.Red;
            this.memButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.memButton.Location = new System.Drawing.Point(235, 550);
            this.memButton.Name = "memButton";
            this.memButton.Size = new System.Drawing.Size(364, 67);
            this.memButton.TabIndex = 20;
            this.memButton.Text = "Member Card";
            this.memButton.UseVisualStyleBackColor = false;
            this.memButton.Click += new System.EventHandler(this.memButton_Click);
            // 
            // secButton
            // 
            this.secButton.BackColor = System.Drawing.Color.Red;
            this.secButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.secButton.Location = new System.Drawing.Point(235, 659);
            this.secButton.Name = "secButton";
            this.secButton.Size = new System.Drawing.Size(364, 67);
            this.secButton.TabIndex = 21;
            this.secButton.Text = "Single Event Credential";
            this.secButton.UseVisualStyleBackColor = false;
            this.secButton.Click += new System.EventHandler(this.secButton_Click);
            // 
            // notesButton
            // 
            this.notesButton.BackColor = System.Drawing.Color.Red;
            this.notesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.notesButton.Location = new System.Drawing.Point(235, 768);
            this.notesButton.Name = "notesButton";
            this.notesButton.Size = new System.Drawing.Size(364, 67);
            this.notesButton.TabIndex = 22;
            this.notesButton.Text = "Notes";
            this.notesButton.UseVisualStyleBackColor = false;
            this.notesButton.Click += new System.EventHandler(this.notesButton_Click);
            // 
            // notesDescriptionLabel
            // 
            this.notesDescriptionLabel.AutoSize = true;
            this.notesDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesDescriptionLabel.Location = new System.Drawing.Point(212, 838);
            this.notesDescriptionLabel.Name = "notesDescriptionLabel";
            this.notesDescriptionLabel.Size = new System.Drawing.Size(415, 22);
            this.notesDescriptionLabel.TabIndex = 28;
            this.notesDescriptionLabel.Text = "Update notes, placement, and sequential numbers.";
            // 
            // label2021
            // 
            this.label2021.AutoSize = true;
            this.label2021.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2021.ForeColor = System.Drawing.Color.Red;
            this.label2021.Location = new System.Drawing.Point(346, 188);
            this.label2021.Name = "label2021";
            this.label2021.Size = new System.Drawing.Size(166, 69);
            this.label2021.TabIndex = 29;
            this.label2021.Text = "2021";
            // 
            // acDescriptionLabel
            // 
            this.acDescriptionLabel.AutoSize = true;
            this.acDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acDescriptionLabel.Location = new System.Drawing.Point(214, 396);
            this.acDescriptionLabel.Name = "acDescriptionLabel";
            this.acDescriptionLabel.Size = new System.Drawing.Size(417, 22);
            this.acDescriptionLabel.TabIndex = 30;
            this.acDescriptionLabel.Text = "Options to edit photos, print individually, or print all.";
            // 
            // acButton
            // 
            this.acButton.BackColor = System.Drawing.Color.Red;
            this.acButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.acButton.Location = new System.Drawing.Point(235, 326);
            this.acButton.Name = "acButton";
            this.acButton.Size = new System.Drawing.Size(364, 67);
            this.acButton.TabIndex = 31;
            this.acButton.Text = "Annual Credential\r\n(w/ Photo Editor)";
            this.acButton.UseVisualStyleBackColor = false;
            this.acButton.Click += new System.EventHandler(this.acButton_Click_1);
            // 
            // acTimerButton
            // 
            this.acTimerButton.BackColor = System.Drawing.Color.Red;
            this.acTimerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acTimerButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.acTimerButton.Location = new System.Drawing.Point(235, 435);
            this.acTimerButton.Name = "acTimerButton";
            this.acTimerButton.Size = new System.Drawing.Size(364, 67);
            this.acTimerButton.TabIndex = 32;
            this.acTimerButton.Text = "Annual Credential \r\n(w/ Timer)";
            this.acTimerButton.UseVisualStyleBackColor = false;
            this.acTimerButton.Click += new System.EventHandler(this.acTimerButton_Click);
            // 
            // acTimerDescriptionLabel
            // 
            this.acTimerDescriptionLabel.AutoSize = true;
            this.acTimerDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acTimerDescriptionLabel.Location = new System.Drawing.Point(132, 505);
            this.acTimerDescriptionLabel.Name = "acTimerDescriptionLabel";
            this.acTimerDescriptionLabel.Size = new System.Drawing.Size(589, 22);
            this.acTimerDescriptionLabel.TabIndex = 33;
            this.acTimerDescriptionLabel.Text = "Options to print individual, all or timer printing all. (Refresh every 30 sec.)";
            // 
            // memberDescriptionLabel
            // 
            this.memberDescriptionLabel.AutoSize = true;
            this.memberDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberDescriptionLabel.Location = new System.Drawing.Point(183, 620);
            this.memberDescriptionLabel.Name = "memberDescriptionLabel";
            this.memberDescriptionLabel.Size = new System.Drawing.Size(462, 22);
            this.memberDescriptionLabel.TabIndex = 34;
            this.memberDescriptionLabel.Text = "Print cards individually and leaves the Members in batch.";
            // 
            // secDescriptionLabel
            // 
            this.secDescriptionLabel.AutoSize = true;
            this.secDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secDescriptionLabel.Location = new System.Drawing.Point(132, 729);
            this.secDescriptionLabel.Name = "secDescriptionLabel";
            this.secDescriptionLabel.Size = new System.Drawing.Size(565, 22);
            this.secDescriptionLabel.TabIndex = 35;
            this.secDescriptionLabel.Text = "Option to print individually or timer printing all. (Refresh every 30 sec.)";
            // 
            // Next_Selection_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 962);
            this.Controls.Add(this.secDescriptionLabel);
            this.Controls.Add(this.memberDescriptionLabel);
            this.Controls.Add(this.acTimerDescriptionLabel);
            this.Controls.Add(this.acTimerButton);
            this.Controls.Add(this.acButton);
            this.Controls.Add(this.acDescriptionLabel);
            this.Controls.Add(this.label2021);
            this.Controls.Add(this.notesDescriptionLabel);
            this.Controls.Add(this.notesButton);
            this.Controls.Add(this.secButton);
            this.Controls.Add(this.memButton);
            this.Controls.Add(this.welcomeLabel2);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.imsaPictureBox);
            this.Name = "Next_Selection_Form";
            this.Text = "IMSA Hard Card Printer (2021)";
            ((System.ComponentModel.ISupportInitialize)(this.imsaPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imsaPictureBox;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label welcomeLabel2;
        private System.Windows.Forms.Button memButton;
        private System.Windows.Forms.Button secButton;
        private System.Windows.Forms.Button notesButton;
        private System.Windows.Forms.Label notesDescriptionLabel;
        private System.Windows.Forms.Label label2021;
        private System.Windows.Forms.Label acDescriptionLabel;
        private System.Windows.Forms.Button acButton;
        private System.Windows.Forms.Button acTimerButton;
        private System.Windows.Forms.Label acTimerDescriptionLabel;
        private System.Windows.Forms.Label memberDescriptionLabel;
        private System.Windows.Forms.Label secDescriptionLabel;
    }
}