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
using Timer = System.Threading.Timer;

namespace WindowsFormsApp2
{
    public partial class Next_AC_Timed_Form : Form
    {
        int duration = 30;                                         // 30 seconds starting countdown			
        Boolean Active = false;
        public Next_AC_Timed_Form()
        {
            InitializeComponent();
            Initialize_Next_AC_Timed_Form(); // Needs to be added to load settings that have been put in 
            LoadData();
            Barcode();
            MySmartCardManager();
            //List available Printers
            foreach (string printer in PrinterSettings.InstalledPrinters)
                printerComboBox.Items.Add(printer);
        } // End NextAnnualCredentialTimedForm
          //Method to load settings
        private void Initialize_Next_AC_Timed_Form()
        {
            this.Height = Properties.Settings.Default.Next_AC_Timed_Form_Height;
            this.Width = Properties.Settings.Default.Next_AC_Timed_Form_Width;

            // register event handler (Next_AC_Timed_Form_ClosingEventHandler)
            this.FormClosing += Next_AC_Timed_Form_ClosingEventHandler;
            this.StartPosition = FormStartPosition.Manual;
        } // End Initialize_Next_AC_Timed_Form

        // method to handle the event (upon closing app)
        public void Next_AC_Timed_Form_ClosingEventHandler(object sender, FormClosingEventArgs e)
        {
            //set the settings that were made in the Settings.settings (in projects properties)
            Properties.Settings.Default.Next_AC_Timed_Form_Height = this.Height;
            Properties.Settings.Default.Next_AC_Timed_Form_Width = this.Width;
            Properties.Settings.Default.Save();
        } // End Next_AC_Timed_Form_ClosingEventHandler
          // Enable the Print button if a printer is selected.
        private void printerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            annualBatch1SinglePrintButton.Enabled = (printerComboBox.SelectedIndex > -1);
            annualBatch2SinglePrintButton.Enabled = (printerComboBox.SelectedIndex > -1);
            annualPrintAndClearAllButton.Enabled = (printerComboBox.SelectedIndex > -1);
            startTimerButton.Enabled = (printerComboBox.SelectedIndex > -1);
        } //End printerComboBox_SelectedIndexChanged
        private void timer1_Tick_1(object sender, EventArgs e)
        {

            duration--; //increment timer to count down by 1 sec
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

        } //end timer1_Tick
        private void startTimerButton_Click_1(object sender, EventArgs e)
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


        } // End startTimerButton_Click_1
        private void stopTimerButton_Click_1(object sender, EventArgs e)
        {
            timer1.Stop();
            MyRefreshAll();
            duration = 30;
        } // End stopTimerButton_Click_1
                          //
                          //
                          //      Below is code to connect to IRIS
                          //
                          //
        SqlConnection IrisConnection = new SqlConnection();
        SqlDataAdapter IrisDataAdapter = new SqlDataAdapter();
        SqlDataAdapter IrisDataAdapter2 = new SqlDataAdapter();
        SqlDataAdapter IrisDataAdapter3 = new SqlDataAdapter();
        SqlDataAdapter IrisDataAdapter4 = new SqlDataAdapter();
        DataTable IrisDataTable = new DataTable();
        DataTable IrisDataTable2 = new DataTable();
        DataTable IrisDataTable3 = new DataTable();
        string Connection = "Data Source=imsaregistration.database.windows.net;Initial Catalog=ImsaAdminDev;Integrated Security=False;User ID=imsaAdmin;Password=UHEvB2HCazSx; Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
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
                        // Below is code to load necessary info. and to use the Tool Strip for dataGridView1
                        //
                        //
                //Create the barcode for display and print.
        public void Barcode()
        {
            // creates barcode for member #
            string barCode = cardMemberNumberTextBox.Text;
            try
            {
                Zen.Barcode.Code39BarcodeDraw brCode = Zen.Barcode.BarcodeDrawFactory.Code39WithoutChecksum;
                cardMemberNumberPictureBox.Image = brCode.Draw(barCode, 240);
            }
            catch (Exception)
            {

            }
        } //end Barcode
        public void MySmartCardManager()
        {
            // code from HID- Fargo SDK
            // Create the Smart Card Resource Manager object.
            m_smartCardManager = new SmartCardManager.SmartCardManager();
        } //End MySmartCardManager
        public void LoadData()
        {
            // loads data into the 'imsaAdminDevDataSet1.view_HardCard_All' table. You can move, or remove it, as needed.
            this.view_HardCard_AllTableAdapter.Fill(this.imsaAdminDevDataSet.view_HardCard_All);
        } //End LoadData
                          //
                          //
                          // Below is code for the tool strip used on dateGridView1
                          //
                          //
        private void allToolStripButton_Click_1(object sender, EventArgs e)
        {
            Barcode();
            try
            {
                this.view_HardCard_AllTableAdapter.All(this.imsaAdminDevDataSet.view_HardCard_All);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        } // End allToolStripButton_Click_1
        private void batch1ToolStripButton_Click_1(object sender, EventArgs e)
        {
            Barcode();
            try
            {
                this.view_HardCard_AllTableAdapter.Batch1(this.imsaAdminDevDataSet.view_HardCard_All);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        } // End batch1ToolStripButton_Click_1
        private void batch2ToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.view_HardCard_AllTableAdapter.Batch2(this.imsaAdminDevDataSet.view_HardCard_All);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        } // End batch2ToolStripButton_Click_1
                              //
                              //
                              //  Below is code for Batch Check/Uncheck
                              //
                              //
        public void SqlConnect()
        {

            try
            {
                // 1
                // Open connection
                string Connection = "Data Source=imsaregistration.database.windows.net;Initial Catalog=ImsaAdminDev;Integrated Security=False;User ID=imsaAdmin;Password=UHEvB2HCazSx; Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                IrisConnection = new SqlConnection(Connection);
                IrisConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection not made with IRIS.");

            }

        } // end SqlConnect
        public void CreateDataAdapter()
        {
            // 2
            // Create new DataAdapter
            try
            {
                String strSelect = "SELECT BatchPrint1 as 'Batch 1', BatchPrint2 as 'Batch 2', NameFull as Name, LicID as 'Membership #', Id, Season as 'Season' FROM Member Where  LicID = " + actionsTxtMembershipNumber.Text + " And Season = " + actionsTxtSeason.Text;
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
        private void sqlDataTableAdapterButton_Click(object sender, EventArgs e)
        {
            SqlConnect();
            CreateDataAdapter();
            FillTableAdapter();
        } // End sqlDataTableAdapterButton_Click
        private void batch1CheckButton_Click_1(object sender, EventArgs e)
        {
            BatchPrint1();
        }  // End batch1CheckButton_Click_1
        private void batch2CheckButton_Click_1(object sender, EventArgs e)
        {
            BatchPrint2();
        }  // End batch2CheckButton_Click_1
        private void closeConnectionButton_Click_1(object sender, EventArgs e)
        {
            IrisConnection.Close();
        } // End closeConnectionButton_Click_1
                        //
                        //
                        //  Below is code for Refresh of DataGrid 1 after actions performed
                        //
                        //
        private void refreshButton_Click(object sender, EventArgs e)
        {
            MyRefresh();
        } // End refreshButton_Click
        public void MyRefresh()
        {
            LoadData();
            // Message to user
            MessageBox.Show("Your update(s) have been made", "Thank you for your patience.");
            Barcode();
        } //End MyRefresh
        public void MyRefreshAll()
        {
            LoadData();
            Barcode();
        } //End MyRefreshAll
                          //
                          //
                          //  Below is code to Update Notes and Sequential number
                          //
                          //
        public void CreateDataAdapter2()
        {
            // 2
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
        }//End FillTableAdapter2
        public void CardPrintedNote()
        {
            CreateDataAdapter2();
            FillTableAdapter2();

            cmd = new SqlCommand("SELECT Member.Id, Member.LicID, Member.Season, MemberNotes.fkMemberId, MemberNotes.Note, MemberNotes.LastUpdate, MemberNotes.Username FROM Member, MemberNotes WHERE Member.LicID = cardMemberNumberTextBox.Text AND Member.Id = MemberNotes.fkMemberId AND Member.Season = actionsTxtSeason.Text", IrisConnection);
            cmd.CommandText = "INSERT INTO MemberNotes (fkMemberId, Note, LastUpdate, Username) VALUES (@fkMemberId, @Note, @LastUpdate, @Username)";
            cmd.Parameters.AddWithValue("@fkMemberId", IrisDataTable2.Rows[0]["MemID"]);
            cmd.Parameters.AddWithValue("@Note", "Annual Credential Printed");
            cmd.Parameters.AddWithValue("@LastUpdate", DateTime.Now);
            cmd.Parameters.AddWithValue("@Username", "Hard Card Printer");
            cmd.ExecuteNonQuery();
        } //End CardPrintedNote
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
            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);



            // Use selected printer.
            printDocument.PrinterSettings.PrinterName = m_selectedPrinter;

            //// To allow to change printer instance
            //// Pass the PrintDocument object in so that the dialog can update the printer name
            //// and devmode for this job.
            //PrintDialog dlgSettings = new PrintDialog();
            //dlgSettings.Document = m_printDocument;
            //dlgSettings.ShowDialog();


            m_iPageNumber = 1;
            m_iNumPages = 2;



            printDocument.QueryPageSettings += new QueryPageSettingsEventHandler(printDocument_QueryPageSettings);

            printDocument.PrinterSettings.Copies = 1;
            printDocument.PrintController = spController;

            m_iPageNumber = 0;

            printDocument.DocumentName = cardMemberNameTextBox.Text;

            // Calling this method starts the printing process for this document
            printDocument.Print();


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
                        //  Below is code for printing
                        //
                        //
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
        private void annualPrintAndClearAllButton_Click_1(object sender, EventArgs e)
        {
            if (printerComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a printer.");
                return;
            }

            else
            {
                printDocument.PrinterSettings.PrinterName = printerComboBox.Text;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        //UNCOMMENT OUT WHEN TESTING AND COMMENT OUT WHEN DONE TESTING
                        printPreviewDialog.Document = printDocument;
                        printPreviewDialog.ShowDialog();
                        //COMMENT OUT WHEN TESTING AND UNCOMMENT OUT WHEN DONE TESTING
                        //printDocument.Print();
                        //COMMENT OUT WHEN TESTING AND UNCOMMENT OUT WHEN DONE TESTING
                        //FargoCardStatus();
                        SqlConnect();
                        CreateDataAdapter();
                        FillTableAdapter();
                        //If item came from batch1, remove from batch
                        if (Convert.ToBoolean(IrisDataTable.Rows[0]["Batch 1"]))
                        {
                            BatchPrint1();
                            IrisConnection.Close();
                            //Connect to IRIS and fill in Note that Card is Printed.
                            SqlConnect();
                            //CreateDataAdapter2();
                            //FillTableAdapter2();
                            //CardPrintedNote();
                            MyRefreshAll();
                        }
                        //If item came from batch2, remove from batch
                        else if (Convert.ToBoolean(IrisDataTable.Rows[0]["Batch 2"]))
                        {
                            BatchPrint2();
                            IrisConnection.Close();
                            //Connect to IRIS and fill in Note that Card is Printed.
                            SqlConnect();
                            //CreateDataAdapter2();
                            //FillTableAdapter2();
                            //CardPrintedNote();
                            MyRefreshAll();
                        }
                        //If the item doesn't contain a picture, stop printing
                        if (pictureBox.Image == null)
                            break;
                    } //End foreach (DataGridViewCell cell in row.Cells)

                } //End foreach (DataGridViewRow row in dataGridView1.Rows)
            }//End else

        } // End annualPrintAndClearAllButton_Click_1
        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bitmap = new Bitmap(197, 20);

            //images (picture and barcode)
            e.Graphics.DrawImage(pictureBox.Image, 62, 73, 103, 120);
            e.Graphics.DrawImage(cardMemberNumberPictureBox.Image, 26, 278, 165, 20);

            //text
            string text1 = cardLicenseTypeTextBox.Text;
            string text2 = cardMemberNameTextBox.Text;
            string text3 = cardAssociationTextBox.Text;
            string text4 = cardMemberNumberTextBox.Text;

            // string converted to Upper case 
            string uppertext1 = text1.ToUpper();
            string uppertext2 = text2.ToUpper();

            //create the font and rectangle text will fill in
            using (System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(bitmap))
            using (Font font1 = new Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Pixel))
            {
                // Create Rectangle that info. will be drawn in
                Rectangle rect1 = new Rectangle(10, 216, 197, 17);
                Rectangle rect2 = new Rectangle(10, 242, 197, 17);
                Rectangle rect3 = new Rectangle(10, 260, 197, 17);
                Rectangle rect4 = new Rectangle(10, 309, 197, 17);

                // Create a StringFormat object for each line of text, and the block of text centered on the page.
                StringFormat stringFormat = new StringFormat();
                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;
                graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                //using Font FindFont to format text to autosize long strings
                Font goodFont1 = FindFont(graphics, text1, rect1.Size, font1);
                Font goodFont2 = FindFont(graphics, text2, rect2.Size, font1);
                Font goodFont3 = FindFont(graphics, text3, rect3.Size, font1);
                Font goodFont4 = FindFont(graphics, text4, rect4.Size, font1);

                // Draw the text 
                e.Graphics.DrawString(uppertext1, goodFont1, Brushes.Black, rect1, stringFormat);
                e.Graphics.DrawString(uppertext2, goodFont2, Brushes.Black, rect2, stringFormat);
                e.Graphics.DrawString(text3, goodFont3, Brushes.Black, rect3, stringFormat);
                e.Graphics.DrawString(text4, goodFont4, Brushes.Black, rect4, stringFormat);

            } // end using
        } //end printDocument_PrintPage
        private void printClearAll()
        {
            printDocument.PrinterSettings.PrinterName = printerComboBox.Text;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    //UNCOMMENT OUT WHEN TESTING AND COMMENT OUT WHEN DONE TESTING
                    printPreviewDialog.Document = printDocument;
                    //printPreviewDialog.ShowDialog();
                    //COMMENT OUT WHEN TESTING AND UNCOMMENT OUT WHEN DONE TESTING
                    //printDocument.Print();
                    //COMMENT OUT WHEN TESTING AND UNCOMMENT OUT WHEN DONE TESTING
                    //FargoCardStatus();
                    SqlConnect();
                    CreateDataAdapter();
                    FillTableAdapter();
                    //If item came from batch1, remove from batch
                    if (Convert.ToBoolean(IrisDataTable.Rows[0]["Batch 1"]))
                    {
                        BatchPrint1();
                        IrisConnection.Close();
                        //Connect to IRIS and fill in Note that Card is Printed.
                        SqlConnect();
                        //CreateDataAdapter2();
                        //FillTableAdapter2();
                        CardPrintedNote();
                        MyRefreshAll();
                    }
                    //If item came from batch2, remove from batch
                    else if (Convert.ToBoolean(IrisDataTable.Rows[0]["Batch 2"]))
                    {
                        BatchPrint2();
                        IrisConnection.Close();
                        //Connect to IRIS and fill in Note that Card is Printed.
                        SqlConnect();
                        //CreateDataAdapter2();
                        //FillTableAdapter2();
                        CardPrintedNote();
                        MyRefreshAll();
                    }
                    //If the item doesn't contain a picture, stop printing
                    if (pictureBox.Image == null)
                        break;
                } //End foreach (DataGridViewCell cell in row.Cells)

            } //End foreach (DataGridViewRow row in dataGridView1.Rows)

        } // End printClearAll
        private void annualBatch1SinglePrintButton_Click_1(object sender, EventArgs e)
        {
            if (printerComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a printer.");
                return;
            }
            else
            {
                printDocument.PrinterSettings.PrinterName = printerComboBox.Text;
                try
                {
                    //UNCOMMENT OUT WHEN TESTING AND UNCOMMENT OUT WHEN DONE TESTING
                    printPreviewDialog.Document = printDocument;
                    printPreviewDialog.ShowDialog();
                    //COMMENT OUT WHEN TESTING AND UNCOMMENT OUT WHEN DONE TESTING
                    //printdocument.print();
                    //COMMENT OUT WHEN TESTING AND UNCOMMENT OUT WHEN DONE TESTING
                    //FargoCardStatus();
                    SqlConnect();
                    CreateDataAdapter();
                    FillTableAdapter();
                    //Remove from Batch Print1, if it is from Batch1
                    if (Convert.ToBoolean(IrisDataTable.Rows[0]["Batch 1"]))
                        BatchPrint1();
                    //If item came from batch2, alert user to select corresponding button
                    else if (Convert.ToBoolean(IrisDataTable.Rows[0]["Batch 2"]))
                        MessageBox.Show("Please Select the Corresponding Batch");
                    IrisConnection.Close();
                    //Connect to IRIS and fill in Note that Card is Printed.
                    SqlConnect();
                    CreateDataAdapter2();
                    FillTableAdapter2();
                    CardPrintedNote();
                    //refresh dataGridView1 to move next item to the top of the list
                    MyRefresh();
                }
                catch (Exception)
                {
                    MessageBox.Show("Select the appropriate Batch.");
                }

            } //End else
        } // End annualBatch1SinglePrintButton_Click_1
        private void annualBatch2SinglePrintButton_Click_1(object sender, EventArgs e)
        {
            if (printerComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a printer.");
                return;
            }

            else
            {

                printDocument.PrinterSettings.PrinterName = printerComboBox.Text;
                try
                {
                    //UNCOMMENT OUT WHEN TESTING AND UNCOMMENT OUT WHEN DONE TESTING
                    printPreviewDialog.Document = printDocument;
                    printPreviewDialog.ShowDialog();
                    //COMMENT OUT WHEN TESTING AND UNCOMMENT OUT WHEN DONE TESTING
                    //printDocument.Print();
                    //COMMENT OUT WHEN TESTING AND UNCOMMENT OUT WHEN DONE TESTING
                    //FargoCardStatus();
                    SqlConnect();
                    CreateDataAdapter();
                    FillTableAdapter();
                    //Remove from Batch Print2, if it is from Batch2
                    if (Convert.ToBoolean(IrisDataTable.Rows[0]["Batch 2"]))
                        BatchPrint2();
                    //If item came from batch1, alert user to select corresponding button
                    else if (Convert.ToBoolean(IrisDataTable.Rows[0]["Batch 1"]))
                        MessageBox.Show("Please Select the Corresponding Batch");
                    IrisConnection.Close();
                    //Connect to IRIS and fill in Note that Card is Printed.
                    SqlConnect();
                    CreateDataAdapter2();
                    FillTableAdapter2();
                    CardPrintedNote();
                    //refresh dataGridView1 to move next item to the top of the list
                    MyRefresh();
                }
                catch (Exception)
                {
                    MessageBox.Show("Select the appropriate Batch.");
                }
            } //End else
        } // End annualBatch2SinglePrintButton_Click_1
        private void printPreviewDialog_Load(object sender, EventArgs e)
        {
            printPreviewDialog.Document = printDocument;
        } //End printPreviewDialog_Load

        
    } // End  NextAnnualCredentialTimedForm : Form

} // End WindowsFormsApp2
