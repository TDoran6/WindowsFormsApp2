///Programmed by Tucker Doran
///Contact: E-Mail- TDoran@NASCAR.com       Cell:(386) 405-9767
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace WindowsFormsApp2
{
    public partial class SelectionScreen : Form
    {
        public SelectionScreen()
        {
            InitializeComponent();
            Initialize_Selection_Form(); //load settings that have been put entered
        } // End SelectionScreen
                //Method to load settings
        private void Initialize_Selection_Form()
        {
            this.Height = Properties.Settings.Default.Selection_Form_Height;
            this.Width = Properties.Settings.Default.Selection_Form_Width;
                    // register event handler (Selection_Form_ClosingEventHandler)
            this.FormClosing += Selection_Form_ClosingEventHandler;
            this.StartPosition = FormStartPosition.Manual;
            yearLabel.Text = Properties.Settings.Default.Season;
        } // End Initialize_Selection_Form
                // method to handle the event (upon closing app)
        public void Selection_Form_ClosingEventHandler(object sender, FormClosingEventArgs e)
        {
                    //set the values that were made in the Settings.settings 
            Properties.Settings.Default.Selection_Form_Height = this.Height;
            Properties.Settings.Default.Selection_Form_Width = this.Width;
            Properties.Settings.Default.Save();
        } // End Selection_Form_ClosingEventHandler
        private void acButton_Click(object sender, EventArgs e)
        {
            AC_Photo_Form ac = new AC_Photo_Form();
            ac.Show();
        } //End acButton_Click
        private void acTimerButton_Click(object sender, EventArgs e)
        {
            AC_Timed_Form acTimed = new AC_Timed_Form();
            acTimed.Show();
        } //End acTimerButton_Click
        private void memButton_Click(object sender, EventArgs e)
        {
            Member_Form mem = new Member_Form();
            mem.Show();
        } //End memButton_Click
        private void secButton_Click(object sender, EventArgs e)
        {
            SEC_Form sec = new SEC_Form();
            sec.Show();
        } //End secButton_Click
        private void notesButton_Click(object sender, EventArgs e)
        {
            Notes_Form notes = new Notes_Form();
            notes.Show();
        } //End notesButton_Click
        private void nextSeasonButton_Click(object sender, EventArgs e)
        {
            Next_Selection_Form nextSeason = new Next_Selection_Form();
            nextSeason.Show();
        } //End nextSeasonButton_Click
        private void SelectionScreen_Load(object sender, EventArgs e)
        {

        } //End SelectionScreen_Load

    } // End SelectionScreen : Form

} // End WindowsFormsApp2
