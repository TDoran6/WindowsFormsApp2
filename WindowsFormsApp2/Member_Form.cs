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
using Timer = System.Threading.Timer;

namespace WindowsFormsApp2
{
    public partial class Member_Form : Form
    {
        //30 seconds starting countdown
        int duration = 30;
        Boolean Active = false;
        public Member_Form()
        {
            InitializeComponent();
            Initialize_Member_Form(); // Needs to be added to load settings that have been put in 
        } //End MemberCardForm
                //Method to load settings
        private void Initialize_Member_Form()
        {
            this.Height = Properties.Settings.Default.Member_Form_Height;
            this.Width = Properties.Settings.Default.Member_Form_Width;
                    // register event handler (Member_Form_ClosingEventHandler)
            this.FormClosing += Member_Form_ClosingEventHandler;
            this.StartPosition = FormStartPosition.Manual;
        } // End Initialize_Member_Form
                // method to handle the event (upon closing app)
        public void Member_Form_ClosingEventHandler(object sender, FormClosingEventArgs e)
        {
                    //set the values that were made in the Settings.settings
            Properties.Settings.Default.Member_Form_Height = this.Height;
            Properties.Settings.Default.Member_Form_Width = this.Width;
            Properties.Settings.Default.Save();
        } // End Member_Form_ClosingEventHandler
                          //
                          //
                          //  Below is code for loading data from IRIS
                          //
                          //
        private void MemberCardForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'imsaAdminDevDataSet.view_HardCard_All' table. You can move, or remove it, as needed.
            this.view_HardCard_AllTableAdapter1.Fill(this.imsaAdminDevDataSet.view_HardCard_All);
            // TODO: This line of code loads data into the 'imsaAdminDevDataSet7.view_HardCard_All' table. You can move, or remove it, as needed.
            this.view_HardCard_AllTableAdapter.Fill(this.imsaAdminDevDataSet7.view_HardCard_All);
                    //List available Printers
            foreach (string printer in PrinterSettings.InstalledPrinters)
                printerComboBox.Items.Add(printer);
            actionsTxtSeason.Text = Properties.Settings.Default.Season;
        } //End  MemberCardForm_Load
        private void MemberCardForm_LoadData()
        {
                    // TODO: This line of code loads data into the 'imsaAdminDevDataSet7.view_HardCard_All' table. You can move, or remove it, as needed.
            this.view_HardCard_AllTableAdapter.Fill(this.imsaAdminDevDataSet7.view_HardCard_All);
        } //End MemberCardForm_LoadData
        private void refreshButton_Click(object sender, EventArgs e)
        {
            MemberCardForm_LoadData();
            MessageBox.Show("Your Updates have been made.");
        } //End refreshButton_Click
        public void MyRefresh()
        {
            MemberCardForm_LoadData();
            MessageBox.Show("Your update(s) have been made", "Thank you for your patience.");
        } //End MyRefresh
        public void MyRefreshAll()
        {
            MemberCardForm_LoadData();
        } //End MyRefreshAll
                            //
                            //
                            //      Below is code to connect to IRIS
                            //
                            //
        SqlConnection IrisConnection = new SqlConnection();
        SqlDataAdapter IrisDataAdapter = new SqlDataAdapter();
        SqlDataAdapter IrisDataAdapter2 = new SqlDataAdapter();
        DataTable IrisDataTable = new DataTable();
        DataTable IrisDataTable2 = new DataTable();
        private SqlCommand cmd;
                // code from HID- Fargo SDK
        private int m_iPageNumber;
        private int m_iNumPages = 1;
        private SmartCardManager.SmartCardManager m_smartCardManager;
        private string m_selectedPrinter;
                // Station to be used for the operation
        private Station m_station;
                        //
                        //
                        //  Below is code for Printing
                        //
                        //
        private void printerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            memberSinglePrint.Enabled = (printerComboBox.SelectedIndex > -1);
        } //End printerComboBox_SelectedIndexChanged
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphics;
            graphics = this.CreateGraphics();
                    //text
            string text1 = cardLicenseTypeTextBox.Text;
            string text2 = cardMemberNameTextBox.Text;
            string text4 = cardMemberNumberTextBox.Text;
                    // string converted to Upper case 
            string uppertext1 = text1.ToUpper();
            string uppertext2 = text2.ToUpper();
                    //create the font and rectangle text will fill in
            using (Font font1 = new Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Pixel))
            {
                        // Create Rectangle that info. will be drawn in
                Pen blackPen = new Pen(Color.FromArgb(255, 0, 0, 0), 5);
                Rectangle rect1 = Properties.Settings.Default.Member_License_Type_rect1;
                Rectangle rect2 = Properties.Settings.Default.Member_Name_rect2;
                Rectangle rect4 = Properties.Settings.Default.Member_Member_Number_rect4;
                        //Hard code option
                //Rectangle rect1 = new Rectangle(-325, 122, 315, 17);
                //Rectangle rect2 = new Rectangle(-325, 110, 315, 17);
                //Rectangle rect4 = new Rectangle(-325, 140, 315, 17);
                        // Create a StringFormat object for each line of text, and the block of text centered on the page.
                StringFormat stringFormat = new StringFormat();
                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;
                graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
                        //using Font FindFont to format text to autosize long strings
                Font goodFont1 = FindFont(graphics, text1, rect1.Size, font1);
                Font goodFont2 = FindFont(graphics, text2, rect2.Size, font1);
                Font goodFont4 = FindFont(graphics, text4, rect4.Size, font1);
                        // Draw the text 
                e.Graphics.RotateTransform(270);                                                    //Flips card on its axis
                e.Graphics.DrawString(uppertext1, goodFont1, Brushes.Black, rect1, stringFormat);
                e.Graphics.DrawString(uppertext2, goodFont2, Brushes.Black, rect2, stringFormat);
                e.Graphics.DrawString(text4, goodFont4, Brushes.Black, rect4, stringFormat);
            } // end using 
        } //End printDocument1_PrintPage
        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
        } // End printPreviewDialog1_Load
        private void memberPrintPreviewButton_Click(object sender, EventArgs e)
        {
            if (printerComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a printer.");
                return;
            }
            else
            {
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }
        } // End memberPrintPreviewButton_Click
        private void memberSinglePrint_Click(object sender, EventArgs e)
        {
            if (printerComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a printer.");
                return;
            }
            else
            {
                printDocument1.PrinterSettings.PrinterName = printerComboBox.Text;
                try
                {
                            //UNCOMMENT OUT WHEN TESTING AND COMMENT OUT WHEN DONE TESTING
                    //printPreviewDialog1.Document = printDocument1;
                    //printPreviewDialog1.ShowDialog();
                            //COMMENT OUT WHEN TESTING AND UNCOMMENT OUT WHEN DONE TESTING
                    printDocument1.Print();
                    SqlConnect();
                    CreateDataAdapter();
                    FillTableAdapter();
                    MemberCardPrintedNote();
                    BatchPrint2();
                    IrisConnection.Close();
                    MyRefresh();
                }
                catch
                {
                    MessageBox.Show("An Error Occured.");
                }
            } //end else
        }// End memberSinglePrint_Click}
        private void printClearAll()
        {
            if (printerComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a printer.");
                return;
            }
            else
            {
                printDocument1.PrinterSettings.PrinterName = printerComboBox.Text;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        //UNCOMMENT OUT WHEN TESTING AND COMMENT OUT WHEN DONE TESTING
                        //printPreviewDialog.Document = printDocument;
                        //printPreviewDialog.ShowDialog();
                        //COMMENT OUT WHEN TESTING AND UNCOMMENT OUT WHEN DONE TESTING
                        printDocument1.Print();
                        SqlConnect();
                        CreateDataAdapter();
                        FillTableAdapter();
                        //If item came from batch1, remove from batch
                        if (Convert.ToBoolean(IrisDataTable.Rows[0]["Batch 1"]))
                        {
                            //If item came from batch1, remove from batch
                            if (Convert.ToBoolean(IrisDataTable.Rows[0]["Batch 1"]))
                            {
                                if (Convert.ToBoolean(IrisDataTable.Rows[0]["Batch 1"]))
                                    BatchPrint1();
                                IrisConnection.Close();
                                //Connect to IRIS and fill in Note that Card is Printed.
                                SqlConnect();
                                CreateDataAdapter2();
                                FillTableAdapter2();
                                MemberCardPrintedNote();
                                MyRefreshAll();
                            }
                        }
                        //If item came from batch2, remove from batch
                        else if (Convert.ToBoolean(IrisDataTable.Rows[0]["Batch 2"]))
                        {
                            BatchPrint2();
                            IrisConnection.Close();
                            //Connect to IRIS and fill in Note that Card is Printed.
                            SqlConnect();
                            CreateDataAdapter2();
                            FillTableAdapter2();
                            MemberCardPrintedNote();
                            MyRefreshAll();
                        }
                        //If the item doesn't contain a picture, stop printing
                        if (cardMemberNameTextBox.Text == "")
                            break;
                    } //End foreach (DataGridViewCell cell in row.Cells)
                } //End foreach (DataGridViewRow row in dataGridView1.Rows)
            }//End else
        } // End printClearAll
        private void annualPrintAndClearAllButton_Click(object sender, EventArgs e)
        {
            if (printerComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a printer.");
                return;
            }
            else
            {
                printDocument1.PrinterSettings.PrinterName = printerComboBox.Text;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        //UNCOMMENT OUT WHEN TESTING AND COMMENT OUT WHEN DONE TESTING
                        //printPreviewDialog.Document = printDocument;
                        //printPreviewDialog.ShowDialog();
                        //COMMENT OUT WHEN TESTING AND UNCOMMENT OUT WHEN DONE TESTING
                        printDocument1.Print();
                        SqlConnect();
                        CreateDataAdapter();
                        FillTableAdapter();
                        //If item came from batch1, remove from batch
                        if (Convert.ToBoolean(IrisDataTable.Rows[0]["Batch 1"]))
                        {
                            //If item came from batch1, remove from batch
                            if (Convert.ToBoolean(IrisDataTable.Rows[0]["Batch 1"]))
                            {
                                if (Convert.ToBoolean(IrisDataTable.Rows[0]["Batch 1"]))
                                    BatchPrint1();
                                IrisConnection.Close();
                                //Connect to IRIS and fill in Note that Card is Printed.
                                SqlConnect();
                                CreateDataAdapter2();
                                FillTableAdapter2();
                                MemberCardPrintedNote();
                                MyRefreshAll();
                            }
                        }
                        //If item came from batch2, remove from batch
                        else if (Convert.ToBoolean(IrisDataTable.Rows[0]["Batch 2"]))
                        {
                            BatchPrint2();
                            IrisConnection.Close();
                            //Connect to IRIS and fill in Note that Card is Printed.
                            SqlConnect();
                            CreateDataAdapter2();
                            FillTableAdapter2();
                            MemberCardPrintedNote();
                            MyRefreshAll();
                        }
                        //If the item doesn't contain a picture, stop printing
                        if (cardMemberNameTextBox.Text == "")
                            break;
                    } //End foreach (DataGridViewCell cell in row.Cells)
                } //End foreach (DataGridViewRow row in dataGridView1.Rows)
            }//End else
        } // End annualPrintAndClearAllButton_Click
                //Insert in IRIS Card was printed.
        public void MemberCardPrintedNote()
        {
            CreateDataAdapter2();
            FillTableAdapter2();
            cmd = new SqlCommand("SELECT Member.Id, Member.LicID, Member.Season, MemberNotes.fkMemberId, MemberNotes.Note, MemberNotes.LastUpdate, MemberNotes.Username FROM Member, MemberNotes WHERE Member.LicID = cardMemberNumberTextBox.Text AND Member.Id = MemberNotes.fkMemberId AND Member.Season = actionsTxtSeason.Text", IrisConnection);
            cmd.CommandText = "INSERT INTO MemberNotes (fkMemberId, Note, LastUpdate, Username) VALUES (@fkMemberId, @Note, @LastUpdate, @Username)";
            cmd.Parameters.AddWithValue("@fkMemberId", IrisDataTable2.Rows[0]["MemID"]);
            cmd.Parameters.AddWithValue("@Note", "Member Card Printed");
            cmd.Parameters.AddWithValue("@LastUpdate", DateTime.Now);
            cmd.Parameters.AddWithValue("@Username", "Hard Card Printer");
            cmd.ExecuteNonQuery();
        } //End MemberCardPrintedNote
        public void CreateDataAdapter2()
        {
                    // Create new DataAdapter
            try
            {
                String strSelect = "SELECT Member.NameFull as 'Name', Member.Id as 'MemID',  MemberNotes.fkMemberId as 'MemNotesID', Member.LicID as 'LicID', Member.Season as 'Season', MemberNotes.Note as 'Note' FROM Member, MemberNotes WHERE Member.LicID = " + cardMemberNumberTextBox.Text + " AND Member.Id = MemberNotes.fkMemberId  AND Member.Season = " + actionsTxtSeason.Text;
                IrisDataAdapter2 = new SqlDataAdapter(strSelect, IrisConnection);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } //End CreateDataAdapter2
        public void FillTableAdapter2()
        {
            IrisDataTable2 = new DataTable();
                    // Use DataAdapter to fill DataTable
            IrisDataAdapter2.Fill(IrisDataTable2);
            dataGridView3.DataSource = IrisDataTable2;
        } //End FillTableAdapter2
                //Create font for Card
        private Font FindFont(System.Drawing.Graphics g, string longString, Size Room, Font PreferedFont)
        {
                    //Shrinks text to fit on card
            if (longString == "")
            {
                return new Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Pixel);
            }
                    // Perform some scale functions
            SizeF RealSize = g.MeasureString(longString, PreferedFont);
            float HeightScaleRatio = Room.Height / RealSize.Height;
            float WidthScaleRatio = Room.Width / RealSize.Width;
            float ScaleRatio = Math.Min(HeightScaleRatio, WidthScaleRatio);
            float ScaleFontSize = PreferedFont.Size * ScaleRatio;
            return new Font(PreferedFont.FontFamily, ScaleFontSize, PreferedFont.Style, GraphicsUnit.Pixel);

        } // end Font FindFont
                //Update status of printer
        public void FargoCardStatus()
        {
                    // code below is from HID- Fargo SDK
            CardStatus cardStatus;
            cardStatus = CardStatus.CardFeeding;
            updateCardStatus(cardStatus);

            if (m_selectedPrinter == "DTC4500e Card Printer")
            {
                cardStatus = CardStatus.CardFeeding;
                updateCardStatus(cardStatus);
                PrintAndUpdateStatus(m_selectedPrinter);
            }
            else if (m_selectedPrinter == "DTC4500e Card Printer (Copy 1)")
            {
                cardStatus = CardStatus.CardFeeding;
                updateCardStatus(cardStatus);
                PrintAndUpdateStatus(m_selectedPrinter);
            }
            else if (m_selectedPrinter == "DTC4500e Card Printer (Copy 2)")
            {
                cardStatus = CardStatus.CardFeeding;
                updateCardStatus(cardStatus);
                PrintAndUpdateStatus(m_selectedPrinter);
            }
            else if (m_selectedPrinter == "DTC4500e Card Printer (Copy 3)")
            {
                cardStatus = CardStatus.CardFeeding;
                updateCardStatus(cardStatus);
                PrintAndUpdateStatus(m_selectedPrinter);
            }
            else if (m_selectedPrinter == "DTC4500e Card Printer (Copy 4)")
            {
                cardStatus = CardStatus.CardFeeding;
                updateCardStatus(cardStatus);
                PrintAndUpdateStatus(m_selectedPrinter);
            }
            else if (m_selectedPrinter == "DTC4500e Card Printer (Copy 5)")
            {
                cardStatus = CardStatus.CardFeeding;
                updateCardStatus(cardStatus);
                PrintAndUpdateStatus(m_selectedPrinter);
            }
            else if (m_selectedPrinter == "DTC4500e Card Printer (Copy 6)")
            {
                cardStatus = CardStatus.CardFeeding;
                updateCardStatus(cardStatus);
                PrintAndUpdateStatus(m_selectedPrinter);
            }
            else if (m_selectedPrinter == "DTC4500e Card Printer (Copy 7)")
            {
                cardStatus = CardStatus.CardFeeding;
                updateCardStatus(cardStatus);
                PrintAndUpdateStatus(m_selectedPrinter);
            }
            else if (m_selectedPrinter == "DTC4500e Card Printer (Copy 8)")
            {
                cardStatus = CardStatus.CardFeeding;
                updateCardStatus(cardStatus);
                PrintAndUpdateStatus(m_selectedPrinter);
            }
            else if (m_selectedPrinter == "DTC4500e Card Printer (Copy 9)")
            {
                cardStatus = CardStatus.CardFeeding;
                updateCardStatus(cardStatus);
                PrintAndUpdateStatus(m_selectedPrinter);
            }
            else if (m_selectedPrinter == "DTC4500e Card Printer (Copy 10)")
            {
                cardStatus = CardStatus.CardFeeding;
                updateCardStatus(cardStatus);
                PrintAndUpdateStatus(m_selectedPrinter);
            }
            m_selectedPrinter = printerComboBox.Text;
        } // End FargoCardStatus
                        //
                        //
                        //  Below is code for Batch Check/Uncheck
                        //
                        //
        public void SqlConnect()
        {
            try
            {
                string Connection = Properties.Settings.Default.Connection_String;
                IrisConnection = new SqlConnection(Connection);
                IrisConnection.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Connection not made with IRIS.");
            }
        } // end SqlConnect
        public void CreateDataAdapter()
        {
                    // Create new DataAdapter
            try
            {
                String strSelect = "SELECT BatchPrint1 as 'Batch 1', BatchPrint2 as 'Batch 2', NameFull as Name, LicID as 'Membership #', Id, Season as 'Season' FROM Member Where  LicID = " + actionsTxtMembershipNumber.Text + " AND Season = " + actionsTxtSeason.Text;
                IrisDataAdapter = new SqlDataAdapter(strSelect, IrisConnection);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } //End CreateDataAdapter
        public void FillTableAdapter()
        {
            IrisDataTable = new DataTable();
                    // Use DataAdapter to fill DataTable
            IrisDataAdapter.Fill(IrisDataTable);
            dataGridView2.DataSource = IrisDataTable;
        } //End FillTableAdapter
        public void BatchPrint1()
        {
            if (IrisDataTable.Rows.Count == 1)  //Should only be one, if not don't do anything
            {
                IrisDataTable.Rows[0].BeginEdit();
                if (Convert.ToBoolean(IrisDataTable.Rows[0]["Batch 1"]))
                {
                    IrisDataTable.Rows[0]["Batch 1"] = false;
                }
                else
                {
                    IrisDataTable.Rows[0]["Batch 1"] = true;
                }
                IrisDataTable.Rows[0].EndEdit();
                SqlCommandBuilder myBuilder = new SqlCommandBuilder(IrisDataAdapter);
                IrisDataAdapter.Update(IrisDataTable);
            }
        } //End BatchPrint1
        public void BatchPrint2()
        {
            if (IrisDataTable.Rows.Count == 1)  //Should only be one, if not don't do anything
            {
                IrisDataTable.Rows[0].BeginEdit();

                if (Convert.ToBoolean(IrisDataTable.Rows[0]["Batch 2"]))
                {
                    IrisDataTable.Rows[0]["Batch 2"] = false;
                }
                else
                {
                    IrisDataTable.Rows[0]["Batch 2"] = true;
                }
                IrisDataTable.Rows[0].EndEdit();
                SqlCommandBuilder myBuilder = new SqlCommandBuilder(IrisDataAdapter);
                IrisDataAdapter.Update(IrisDataTable);
            }
        } // End BatchPrint2()
                // Batch Uncheck Buttons
        private void sqlDataTableAdapterButton_Click(object sender, EventArgs e)
        {
            SqlConnect();
            CreateDataAdapter();
            FillTableAdapter();
        } // End sqlDataTableAdapterButton_Click
        private void closeConnectionButton_Click(object sender, EventArgs e)
        {
            IrisConnection.Close();
        } // End closeConnectionButton_Click
        private void batch1CheckButton_Click(object sender, EventArgs e)
        {
            BatchPrint1();
        } // End batch1CheckButton_Click
        private void batch2CheckButton_Click(object sender, EventArgs e)
        {
            BatchPrint2();
        } // End batch2CheckButton_Click
                        //
                        //
                        //  Below is code from HID- Fargo SDK
                        //
                        //
        enum CardStatus
        {
            NoCardInPrinter = 0,
            CardFeeding,
            CardDockedOk,
            CardConnecting,
            CardConnected,
            CardDisconnecting,
            CardDisconnected,
            CardEjecting,
            CardHasError,
            CardFeedError,
            CardPrinting,
        }; // End CardStatus
        private void updateCardStatus(CardStatus currentStatus)
        {
            switch (currentStatus)
            {
                case CardStatus.NoCardInPrinter:
                    lblStatus.Text = "Printer Empty";
                    break;
                case CardStatus.CardFeeding:
                    lblStatus.Text = "Card Feeding";
                    break;
                case CardStatus.CardDockedOk:
                    lblStatus.Text = "Card Docked";
                    break;
                case CardStatus.CardConnecting:
                    lblStatus.Text = "Card Connecting";
                    break;
                case CardStatus.CardConnected:
                    lblStatus.Text = "Card Connected";
                    break;
                case CardStatus.CardDisconnecting:
                    lblStatus.Text = "Card Disconnecting";
                    break;
                case CardStatus.CardDisconnected:
                    lblStatus.Text = "Card Disconnected";
                    break;
                case CardStatus.CardEjecting:
                    lblStatus.Text = "Card Ejecting";
                    break;
                case CardStatus.CardHasError:
                    lblStatus.Text = "Card Error";
                    break;
                case CardStatus.CardFeedError:
                    lblStatus.Text = "Card Feed Error";
                    break;
                case CardStatus.CardPrinting:
                    lblStatus.Text = "Card Printing";
                    break;
                default:
                    lblStatus.Text = "(Unknown)";
                    break;
            }
            lblStatus.Refresh();
        } // End updateCardStatus
        private void PrintAndUpdateStatus(string printerName)
        {
            Boolean cardIsOk;
            CardStatus cardStatus;
            PrinterInfo printerInfo;

            printerInfo = new PrinterInfo(printerName);
            string ribbonSerialNumber = printerInfo.RibbonSerialNumber;
            string filmSerialNumber = printerInfo.FilmSerialNumber;
            string lam1SerialNumber = printerInfo.LaminateSerialNumber(0);

            //Start the print Job
            //PrintCard();

            // Poll for it to start printing.
            cardIsOk = PollForPrinterPrinting(printerName);

            if (cardIsOk)
            {
                cardStatus = CardStatus.CardPrinting;
            }
            else
            {
                cardStatus = CardStatus.CardFeedError;
            }
            updateCardStatus(cardStatus);

            // Poll for the printer to go back to ready.
            cardIsOk = PollForPrinterReady(printerName);
            if (cardIsOk)
            {
                cardStatus = CardStatus.NoCardInPrinter;
            }
            else
            {
                cardStatus = CardStatus.CardFeedError;
            }
            updateCardStatus(cardStatus);
        } // End PrintAndUpdateStatus
        private Boolean DockAndUpdateStatus(string printerName)
        {
            Boolean cardWasDockedOk;
            CardStatus cardStatus;

            cardStatus = CardStatus.CardFeeding;
            updateCardStatus(cardStatus);

            cardWasDockedOk = DockTheCard(printerName);

            if (cardWasDockedOk)
            {
                cardStatus = CardStatus.CardDockedOk;
            }
            else
            {
                cardStatus = CardStatus.CardFeedError;
            }
            updateCardStatus(cardStatus);

            return (cardWasDockedOk);
        } // End DockAndUpdateStatu
        private Boolean DockTheCard(string printerName)
        {
            Boolean returnCode;
            //Station targetStation;
            int inputHopper;

            Movement objMove = new Movement(printerName);
            PrinterInfo printerInfo = new PrinterInfo(printerName);

            //// Move the hopper to attempt first to the specified one.
            //

            //switch (inputHopper)
            //{
            //    // First Available
            //    case 0:
            //        printerInfo.SendAPDU(11, 4, 0, 0, 0, null);
            //        break;
            //    // Top
            //    case 1:
            //        printerInfo.SendAPDU(11, 4, 0, 0, 0, null);
            //        break;
            //    // Bottom
            //    case 2:
            //        printerInfo.SendAPDU(11, 4, 1, 0, 0, null);
            //        break;
            //    // Kiosk.
            //    case 3:
            //        printerInfo.SendAPDU(11, 4, 3, 0, 0, null);
            //        break;
            //}


            returnCode = false;


            if (m_station == Station.Magnetic)
            {
                // Wait until "Holding" appears
                returnCode = true;
            }
            else
            {

                // Wait for LCD to indicate encoding

                // Assume will not be ok

                CurrentActivity currentActivity;

                int iStatusTries = 100;

                //
                // DTC1000/4000/4500
                //
                // DTC1000/4000/4500 does not support LCDInfo property
                if (printerName.Contains("DTC"))
                {
                    do
                    {
                        System.Threading.Thread.Sleep(1000);
                        currentActivity = printerInfo.CurrentActivity();
                        iStatusTries--;
                    } while (
                             (currentActivity != CurrentActivity.CurrentActivityException) &&
                             (currentActivity != CurrentActivity.CurrentActivityEncodeContact) &&
                             (currentActivity != CurrentActivity.CurrentActivityEncodeContactless) &&
                             (iStatusTries > 0)
                             );


                } // end if Neo


                // Check for HDP5000/HDPii
                else if (printerName.Contains("HDP"))
                {
                    returnCode = false;                 // Default to error
                    StationStatus stationStatus;
                    do
                    {
                        System.Threading.Thread.Sleep(1000);
                        stationStatus = printerInfo.StationStatus(/*targetStation*/ m_station);
                        currentActivity = printerInfo.CurrentActivity();

                        Debug.WriteLine("DockTheCard: Station Status " + stationStatus.ToString());
                        Debug.WriteLine("DockTheCard: Current Activity " + currentActivity.ToString());
                        iStatusTries--;
                    } while (
                            (currentActivity != CurrentActivity.CurrentActivityException) &&
                            (stationStatus != StationStatus.CardPresent) &&
                            (iStatusTries > 0)
                            );


                    //// Card DID make it to encoder in reasonable time.
                    //if ((iStatusTries != 0) && (currentActivity != CurrentActivity.CurrentActivityException))
                    //{
                    //    Debug.WriteLine("Card Docked OK");
                    //    returnCode = true;
                    //}
                }
                // Unknown printer type
                else
                {
                    currentActivity = CurrentActivity.CurrentActivityException;
                }

                if ((iStatusTries != 0) && (currentActivity != CurrentActivity.CurrentActivityException))
                {
                    Debug.WriteLine("DockTheCard: Card Docked OK");
                    returnCode = true;
                }
                else
                {
                    Debug.WriteLine("DockTheCard: Card NOT Docked");
                }

            }


            return (returnCode);
        } // End DockTheCard
        private void PrintCard()
        {
            StandardPrintController spController = new StandardPrintController();



            // Subscribe to the print event
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);



            // Use selected printer.
            printDocument1.PrinterSettings.PrinterName = m_selectedPrinter;

            //// To allow to change printer instance
            //// Pass the PrintDocument object in so that the dialog can update the printer name
            //// and devmode for this job.
            //PrintDialog dlgSettings = new PrintDialog();
            //dlgSettings.Document = m_printDocument;
            //dlgSettings.ShowDialog();


            m_iPageNumber = 1;
            m_iNumPages = 2;



            printDocument1.QueryPageSettings += new QueryPageSettingsEventHandler(printDocument_QueryPageSettings);

            printDocument1.PrinterSettings.Copies = 1;
            printDocument1.PrintController = spController;

            m_iPageNumber = 0;

            printDocument1.DocumentName = cardMemberNameTextBox.Text;

            // Calling this method starts the printing process for this document
            printDocument1.Print();


            //PrinterSettings printerSettings = new PrinterSettings();
            //printerSettings.GetHdevmode();
        }  // End PrintCard
        void printDocument_QueryPageSettings(object sender, QueryPageSettingsEventArgs e)
        {
            //e.PageSettings.PrinterSettings.
        }  // End printDocument_QueryPageSettings
        private Boolean PollForPrinterPrinting(string printerName)
        {
            Boolean returnCode;
            PrinterInfo printerInfo = new PrinterInfo(printerName);

            // Assume will work ok
            returnCode = true;

            int iStatusTries = 100;
            CurrentActivity currentActivity;

            do
            {
                System.Threading.Thread.Sleep(1000);
                currentActivity = printerInfo.CurrentActivity();
                iStatusTries--;
            } while ((currentActivity != CurrentActivity.CurrentActivityPrinting) &&
                     (iStatusTries > 0)
                     );


            // Card did not make it to encoder in reasonable time.
            if (iStatusTries == 0)
            {
                returnCode = false;
            }

            return (returnCode);
        } // End  PollForPrinterPrinting
        private Boolean PollForPrinterReady(string printerName)
        {
            Boolean returnCode;
            PrinterInfo printerInfo = new PrinterInfo(printerName);

            // Assume will work ok
            returnCode = true;

            int iStatusTries = 100;
            CurrentActivity currentActivity;

            do
            {
                System.Threading.Thread.Sleep(1000);
                currentActivity = printerInfo.CurrentActivity();
                iStatusTries--;
            } while ((currentActivity != CurrentActivity.CurrentActivityReady) &&
                     (iStatusTries > 0)
                     );


            // Card did not make it to encoder in reasonable time.
            if (iStatusTries == 0)
            {
                returnCode = false;
            }

            return (returnCode);
        } // End PollForPrinterReady
        private Boolean EjectTheCard(string printerName)
        {
            Boolean returnCode;
            Movement objMove = new Movement(printerName);

            // Eject the card to the last hopper.  Currently only HDP8500 has dual output hopper.
            objMove.MoveTo(Station.Eject, 0);

            // Wait for it to return to ready
            returnCode = PollForPrinterReady(printerName);
            return (returnCode);
        } // End EjectTheCard
        public ArrayList getReaderList()
        {
            ArrayList arrrayListRet = new ArrayList();


            // Obtain the list of installed readers
            try
            {
                // Establish the context of the reader to System.
                m_smartCardManager.EstablishContext(SmartCardManager.SCardContextScope.System);

                // Attempt to read the list (returns number of readers in the list)
                m_smartCardManager.ListReaders(arrrayListRet);

                // Release context
                m_smartCardManager.ReleaseContext();
            }
            catch (InvalidOperationException)
            {
            }

            // Return the list of readers
            return arrrayListRet;
        }  // End getReaderList
                        //                    
                        //
                        //Bellow is code for Timer
                        //
                        //
        private void timer1_Tick(object sender, EventArgs e)
        {
            duration--;
            textBox1.Text = duration.ToString();
            if (duration > 0)
            {
                printClearAll();
            }
            else
            {
                timer1.Stop();
                MyRefreshAll();
                duration = 30;
                Active = false;
                timer1.Start();
            }
        } //End timer1_Tick
        private void startTimerButton_Click(object sender, EventArgs e)
        {
            if (printerComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a printer.");
                return;
            }
            else
            {
                timer1.Enabled = true;
                timer1.Start();
            }
        } //End startTimerButton_Click
        private void stopTimerButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            MyRefreshAll();
            duration = 30;
        } //End stopTimerButton_Click
       


    }// End Member_Form : Form

}// End WindowsFormsApp2
