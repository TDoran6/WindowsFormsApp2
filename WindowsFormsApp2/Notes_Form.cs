///Programmed by Tucker Doran
///Contact: E-Mail- TDoran@NASCAR.com       Cell:(386) 405-9767
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;                   // For Bitmap
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Printing;          // For PrintDocument
using System.Management;
using System.Diagnostics;               // For Debug
using System.Collections;               // For ArrayList
using System.Threading;                 // For Thread
using Fargo.PrinterSDK;                 // For Movement, PrinterInfo, PrinterError, CurrentActivity, StationStatus
using SmartCardManager;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;         //For cropping image
using System.Data;                      //For updating IRIS
using System.Data.SqlClient;            //For updating IRIS


namespace WindowsFormsApp2
{
    public partial class Notes_Form : Form
    {
        public Notes_Form()
        {
            InitializeComponent();
            Initialize_Notes_Form(); // Needs to be added to load settings that have been put in 
        } //End Notes_Form()
                //Method to load settings
        private void Initialize_Notes_Form()
        {
            this.Height = Properties.Settings.Default.Notes_Form_Height;
            this.Width = Properties.Settings.Default.Notes_Form_Width;
                    // register event handler (Notes_Form_ClosingEventHandler)
            this.FormClosing += Notes_Form_ClosingEventHandler;
            this.StartPosition = FormStartPosition.Manual;
        } // End Initialize_Notes_Form
                // method to handle the event (upon closing app)
        public void Notes_Form_ClosingEventHandler(object sender, FormClosingEventArgs e)
        {
                    //set the values that were made in the Settings.settings
            Properties.Settings.Default.Notes_Form_Height = this.Height;
            Properties.Settings.Default.Notes_Form_Width = this.Width;
            Properties.Settings.Default.Save();
        } // End Notes_Form_ClosingEventHandler
                        //
                        //
                        //  Below is code to connect to IRIS
                        //
                        //
        SqlConnection IrisConnection = new SqlConnection();
        SqlDataAdapter IrisDataAdapter3 = new SqlDataAdapter();
        DataTable IrisDataTable2 = new DataTable();
        private SqlCommand cmd;
        public void SqlConnect()
        {
            try
            {
                string Connection = Properties.Settings.Default.Connection_String;
                IrisConnection = new SqlConnection(Connection);
                IrisConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection not made with IRIS.");
            }
        } // End SqlConnect
                        //
                        //
                        //  Below is code to fill the table
                        //
                        //
        public void CreateDataAdapter3()
        {
            try
            {
                String strSelect = "SELECT Member.NameFull as 'Name', Member.Id as 'MemID', Member.LicID as 'LicID', MemberNotes.fkMemberId as 'MemNotesID', Member.Season as 'Season',  MemberNotes.Note as 'Note' FROM Member, MemberNotes WHERE Member.LicID = " + membershipText.Text + " AND Member.Id = MemberNotes.fkMemberId  AND Member.Season = 2020";
                IrisDataAdapter3 = new SqlDataAdapter(strSelect, IrisConnection);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } //End CreateDataAdapter3
        public void FillTableAdapter3()
        {
            try
            {
                IrisDataTable2 = new DataTable();
                        // Use DataAdapter to fill DataTable
                IrisDataAdapter3.Fill(IrisDataTable2);
                dataGridView3.DataSource = IrisDataTable2;
            }
            catch
            {
                MessageBox.Show("Either there is no number in the field to the left, or you are not connected to the Database.");
            }
        } //End FillTableAdapter3
                        //
                        //
                        //  Below is code for updating/inserting notes/sequential number
                        //
                        //
        public void CardPlacedNote()
        {
            cmd = new SqlCommand("SELECT Member.Id, Member.LicID, Member.Season, MemberNotes.fkMemberId, MemberNotes.Note, MemberNotes.LastUpdate, MemberNotes.Username FROM Member, MemberNotes WHERE Member.LicID = cardMemberNumberTextBox.Text AND Member.Id = MemberNotes.fkMemberId AND Member.Season = actionsTxtSeason.Text", IrisConnection);
            cmd.CommandText = "INSERT INTO MemberNotes (fkMemberId, Note, LastUpdate, Username) VALUES (@fkMemberId, @Note, @LastUpdate, @Username)";
            cmd.Parameters.AddWithValue("@fkMemberId", IrisDataTable2.Rows[0]["MemID"]);
            cmd.Parameters.AddWithValue("@Note", noteComboBox.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@LastUpdate", DateTime.Now);
            cmd.Parameters.AddWithValue("@Username", "Hard Card Printer");
            cmd.ExecuteNonQuery();
        } //End CardPlacedNote
        public void UpdateSequentialNumber()
        {
            cmd = new SqlCommand("SELECT Member.Id,  Credentials.Number FROM Member, Credentials WHERE MemberId = @MemberId ", IrisConnection);
            cmd.CommandText = "UPDATE Credentials SET Number = @Number WHERE MemberId = @MemberId ";
            cmd.Parameters.AddWithValue("@MemberId", IrisDataTable2.Rows[0]["MemID"]);
            cmd.Parameters.AddWithValue("@Number", sequentialText.Text);
            cmd.ExecuteNonQuery();
        } // End UpdateSequentialNumber
        private void sqlDataTableAdapter3_Click(object sender, EventArgs e)
        {
            SqlConnect();
            CreateDataAdapter3();
            FillTableAdapter3();
        } // End sqlDataTableAdapter3_Click
        private void insertNoteButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to enter this note in IRIS?", "Please Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string getNote = noteComboBox.SelectedItem.ToString();
                    CardPlacedNote();
                    MessageBox.Show("You selected ' " + getNote + " ' and the note has been made.");
                }
                else if (dialogResult == DialogResult.No)
                {
                    //nothing
                }
            }
            catch
            {
                MessageBox.Show("Make sure you have a chosen License ID Number");
            }
        } //End insertNoteButton_Click
        private void updateSequentialButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to update the Sequential Number?", "Please Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    UpdateSequentialNumber();
                    MessageBox.Show("You entered ' " + sequentialText.Text + " ' and the number has been updated in IRIS.");
                }
                else if (dialogResult == DialogResult.No)
                {
                    //nothing
                }
            }
            catch
            {
                MessageBox.Show("There is no number in the field to the left");
            }
        } // End updateSequentialButton_Click
        private void updateNoteAndSequentialButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to enter Note: ' " + noteComboBox.SelectedItem.ToString() + " ' and Sequential Number: ' " + sequentialText.Text + " ' in IRIS?", "Please Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string getNote = noteComboBox.SelectedItem.ToString();
                    CardPlacedNote();
                    UpdateSequentialNumber();
                    MessageBox.Show("Both have been updated in IRIS.");
                }
                else if (dialogResult == DialogResult.No)
                {
                    //nothing
                }
            }
            catch
            {
                MessageBox.Show("Make sure you have a Member connected and all fields are filled in properly.");
            }
        } // End updateNoteAndSequentialButton_Click
        public void TypedNote()
        {
            cmd = new SqlCommand("SELECT Member.Id, Member.LicID, Member.Season, MemberNotes.fkMemberId, MemberNotes.Note, MemberNotes.LastUpdate, MemberNotes.Username FROM Member, MemberNotes WHERE Member.LicID = cardMemberNumberTextBox.Text AND Member.Id = MemberNotes.fkMemberId AND Member.Season = actionsTxtSeason.Text", IrisConnection);
            cmd.CommandText = "INSERT INTO MemberNotes (fkMemberId, Note, LastUpdate, Username) VALUES (@fkMemberId, @Note, @LastUpdate, @Username)";
            cmd.Parameters.AddWithValue("@fkMemberId", IrisDataTable2.Rows[0]["MemID"]);
            cmd.Parameters.AddWithValue("@Note", typedTextBox.Text);
            cmd.Parameters.AddWithValue("@LastUpdate", DateTime.Now);
            cmd.Parameters.AddWithValue("@Username", "Hard Card Printer");
            cmd.ExecuteNonQuery();
        } // End TypedNote
        private void typedNoteButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to enter this note in IRIS?", "Please Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    TypedNote();
                    MessageBox.Show("You typed ' " + typedTextBox.Text + " ' and the note has been made.");
                }
                else if (dialogResult == DialogResult.No)
                {
                    //nothing
                }
            }
            catch
            {
                MessageBox.Show("Make sure you have a chosen License ID Number");
            }
        } // End typedNoteButton_Click
        private void Notes_Form_Load(object sender, EventArgs e)
        {
            actionsTxtSeason.Text = Properties.Settings.Default.Season;
        } //End Notes_Form_Load

    } // End Notes_Form : Form

} // End WindowsFormsApp2
