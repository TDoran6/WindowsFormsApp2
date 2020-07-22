using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Next_Selection_Form : Form
    {
        public Next_Selection_Form()
        {
            InitializeComponent();
            Initialize_Next_Selection_Form(); // Needs to be added to load settings that have been put in
        }  // End Next_Selection_Form
           //Method to load settings
        private void Initialize_Next_Selection_Form()
        {
            this.Height = Properties.Settings.Default.Next_Selection_Form_Height;
            this.Width = Properties.Settings.Default.Next_Selection_Form_Width;
                 // register event handler (Next_Selection_Form_ClosingEventHandler)
            this.FormClosing += Next_Selection_Form_ClosingEventHandler;
            this.StartPosition = FormStartPosition.Manual;
        } // End Initialize_ Next_Selection_Form
          // method to handle the event (upon closing app)
        public void Next_Selection_Form_ClosingEventHandler(object sender, FormClosingEventArgs e)
        {
            //set the settings that were made in the Settings.settings (in projects properties)
            Properties.Settings.Default.Next_Selection_Form_Height = this.Height;
            Properties.Settings.Default.Next_Selection_Form_Width = this.Width;
            Properties.Settings.Default.Save();
        } // End Next_Selection_Form_ClosingEventHandler


        private void acButton_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("This page is still set up for 2020. Modifications coming soon.     -TD");

            Next_AC_Photo_Form nextAc = new Next_AC_Photo_Form();
            nextAc.Show();

            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Next_AC_Photo_Form))
                {
                    form.Activate();
                    return;
                }
                else
                {
                    this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                }
            }



           
        } // End acButton_Click_1
        private void acTimerButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This page is still set up for 2020. Modifications coming soon.     -TD");
            Next_AC_Timed_Form nextAcTimed = new Next_AC_Timed_Form();
            nextAcTimed.Show();
        }  // End acTimerButton_Click
        private void memButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This page is still set up for 2020. Modifications coming soon.     -TD");
            Next_Member_Form nextMem = new Next_Member_Form();
            nextMem.Show();
        }  // End memButton_Click
        private void secButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This page is still set up for 2020. Modifications coming soon.     -TD");
            Next_SEC_Form nextSEC = new Next_SEC_Form();
            nextSEC.Show();
        }  // End secButton_Click
        private void notesButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This page is still set up for 2020. Modifications coming soon.     -TD");
            Next_Notes_Form nextNotes = new Next_Notes_Form();
            nextNotes.Show();
        }  // End notesButton_Click


    } // End Next_Selection_Form : Form

}  // End WindowsFormsApp2
