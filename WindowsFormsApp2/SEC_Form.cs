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
using System.Data.SqlClient;            //For updating IRIS
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


namespace WindowsFormsApp2
{
    public partial class SEC_Form : Form
    {
                // 30 seconds starting countdown
        int duration = 30;			
        Boolean Active = false;
        public SEC_Form()
        {
            InitializeComponent();
            Initialize_SEC_Form(); // Needs to be added to load settings that have been put in 
        } //End SEC_Form()
                //Method to load settings
        private void Initialize_SEC_Form()
        {
            this.Height = Properties.Settings.Default.SEC_Form_Height; 
            this.Width = Properties.Settings.Default.SEC_Form_Width;
                    // register event handler (SEC_Form_ClosingEventHandler)
            this.FormClosing += SEC_Form_ClosingEventHandler;
            this.StartPosition = FormStartPosition.Manual;
        } // End Initialize_SEC_Form
                // method to handle the event (upon closing app)
        public void SEC_Form_ClosingEventHandler(object sender, FormClosingEventArgs e)
        {
                    //set the values that were made in the Settings.settings
            Properties.Settings.Default.SEC_Form_Height = this.Height;
            Properties.Settings.Default.SEC_Form_Width = this.Width;
            Properties.Settings.Default.Save();
        } // End SEC_Form_ClosingEventHandler
        private void SecForm_Load(object sender, EventArgs e)
        {
                    // TODO: This line of code loads data into the 'view_SecBatchPrintAll.view_SecBatchPrint' table. You can move, or remove it, as needed.
            //this.view_SecBatchPrintTableAdapter2.Fill(this.view_SecBatchPrintAll.view_SecBatchPrint);
                    // TODO: This line of code loads data into the 'imsaAdminDevDataSet6.view_SecBatchPrint' table. You can move, or remove it, as needed.
            this.view_SecBatchPrintTableAdapter1.Fill(this.imsaAdminDevDataSet6.view_SecBatchPrint);
                    //List available Printers
            foreach (string printer in PrinterSettings.InstalledPrinters)
                printerComboBox.Items.Add(printer);
            actionsTxtSeason.Text = Properties.Settings.Default.Season;
        } //End SecForm_Load
                        //
                        //
                        //  Below is code related to connecting to the DB (IRIS)
                        //
                        //
        SqlConnection IrisConnection = new SqlConnection();
        SqlDataAdapter IrisDataAdapter = new SqlDataAdapter();
        SqlDataAdapter IrisDataAdapter4 = new SqlDataAdapter();
        DataTable IrisDataTable = new DataTable();
        DataTable IrisDataTable3 = new DataTable();
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
        } //End SqlConnect
                        //
                        //
                        //  Below is code related to filling the tables with info from the DB
                        //
                        //
        public void CreateSECDataAdapter()
        {
                    // Create new DataAdapter
            try
            {
                String strSelect = "SELECT DisplayName, Id, Season, BatchPrint FROM view_SecBatchPrint WHERE Id = " + idTextBox.Text;
                IrisDataAdapter = new SqlDataAdapter(strSelect, IrisConnection); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } //End CreateSECDataAdapter
        public void FillSECTableAdapter()
        {
            IrisDataTable = new DataTable();
                    // Use DataAdapter to fill DataTable
            IrisDataAdapter.Fill(IrisDataTable);
            dataGridView2.DataSource = IrisDataTable;         
        } //End FillSECTableAdapter
                        //
                        //
                        //  Below is code related to unchecking from the batch
                        //
                        //
        private void sqlDataTableAdapterButton_Click(object sender, EventArgs e)
        {
            SqlConnect();
            CreateSECDataAdapter();
            FillSECTableAdapter();
        }// End sqlDataTableAdapterButton_Click
        private void batch1CheckButton_Click(object sender, EventArgs e)
        {
            BatchPrintUncheck();
        }// End batch1CheckButton_Click
        private void closeConnectionButton_Click(object sender, EventArgs e)
        {
            IrisConnection.Close();
        }// End closeConnectionButton_Click
        public void BatchPrintUncheck()
        {
            if (IrisDataTable.Rows.Count == 1)  //Should only be one, if not don't do anything
            {
                IrisDataTable.Rows[0].BeginEdit();
                if (Convert.ToBoolean(IrisDataTable.Rows[0]["BatchPrint"]))
                {
                    IrisDataTable.Rows[0]["BatchPrint"] = false;
                }
                else
                {
                    IrisDataTable.Rows[0]["BatchPrint"] = true;
                }
                IrisDataTable.Rows[0].EndEdit();
                SqlCommandBuilder myBuilder = new SqlCommandBuilder(IrisDataAdapter);
                IrisDataAdapter.Update(IrisDataTable);
            }
        } //End BatchPrintUncheck
                        //
                        //
                        //  Below is code related to refreshing the form
                        //
                        //
        public void MyRefresh()
        {
            SecForm_LoadData();
            MessageBox.Show("Your update(s) have been made", "Thank you for your patience.");
        } //End MyRefresh
        public void MyRefreshAll()
        {
            SecForm_LoadData();
        } //End MyRefreshAll
        private void refreshButton_Click(object sender, EventArgs e)
        {
            MyRefresh();
        } //End refreshButton_Click
        public void SecForm_LoadData()
        {
                    // TODO: This line of code loads data into the 'imsaAdminDevDataSet6.view_SecBatchPrint' table. You can move, or remove it, as needed.
            this.view_SecBatchPrintTableAdapter1.Fill(this.imsaAdminDevDataSet6.view_SecBatchPrint);
            actionsTxtSeason.Text = "2020";
        } //End SecForm_LoadData()
                        //
                        //
                        //  Below is code related to printing and the printer.
                        //
                        //
        private void printClearAllSEC()
        {
            printDocument2.PrinterSettings.PrinterName = printerComboBox.Text;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                            //UNCOMMENT OUT WHEN TESTING AND COMMENT OUT WHEN DONE TESTING
                    //printPreviewDialog.Document = printDocument2;
                    //printPreviewDialog.ShowDialog();
                            //COMMENT OUT WHEN TESTING AND UNCOMMENT OUT WHEN DONE TESTING
                    printDocument2.Print();
                    //FargoCardStatus();
                    SqlConnect();
                    CreateSECDataAdapter();
                    FillSECTableAdapter();
                    IrisConnection.Close();
                    SqlConnect();
                    BatchPrintUncheck();
                    IrisConnection.Close();
                    MyRefreshAll();
                    if (idTextBox.Text == "")
                        break;
                } //End foreach (DataGridViewCell cell in row.Cells)
                if (idTextBox.Text == "")
                    break;
            } //End foreach (DataGridViewRow row in dataGridView1.Rows)               
        } // End printClearAllSEC
        private void secPrintPreviewButton_Click(object sender, EventArgs e)
        {
            if (printerComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a printer.");
                return;
            }
            else
            {
                printPreviewDialog.Document = printDocument2;
                printPreviewDialog.ShowDialog();
            }
        } //End secPrintPreviewButton_Click
        private void printDocument2_PrintPage(object sender, PrintPageEventArgs e)
        {
            printDocument2.PrinterSettings.PrinterName = printerComboBox.Text;
            Graphics graphics;
            graphics = this.CreateGraphics(); ;
                    //text
            string text1 = secTextBox.Text;
                    // string converted to Upper case 
            string uppertext1 = text1.ToUpper();
                   //create the font and rectangle text will fill in
            using (Font font1 = new Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Pixel))
            {
                        // Create Rectangle that info. will be drawn in
                Rectangle rect1 = Properties.Settings.Default.SEC_Name_rect;
                        // Hard code option
                //Rectangle rect1 = new Rectangle(10, 270, 197, 17);
                        // Create a StringFormat object for each line of text, and the block of text centered on the page.
                StringFormat stringFormat = new StringFormat();
                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;
                graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
                        //using Font FindFont to format text to autosize long strings
                Font goodFont1 = FindFont(graphics, text1, rect1.Size, font1);
                        // Draw the text 
                e.Graphics.DrawString(uppertext1, goodFont1, Brushes.Black, rect1, stringFormat);
            } // end using
        } //End printDocument2_PrintPage
        private void printPreviewDialog_Load(object sender, EventArgs e)
        {
            printPreviewDialog.Document = printDocument2;

        } //End printPreviewDialog_Load
        private void printerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            secSinglePrint.Enabled = (printerComboBox.SelectedIndex > -1);
        } //EndprinterComboBox_SelectedIndexChanged
        private void secSinglePrint_Click(object sender, EventArgs e)
        {
            if (printerComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a printer.");
                return;
            }
            else
            {
                try
                {
                    printDocument2.PrinterSettings.PrinterName = printerComboBox.Text;
                            //UNCOMMENT OUT WHEN TESTING AND COMMENT OUT WHEN DONE TESTING
                    //printPreviewDialog.Document = printDocument2;
                    //printPreviewDialog.ShowDialog();
                            //COMMENT OUT WHEN TESTING AND UNCOMMENT OUT WHEN DONE TESTING
                    printDocument2.Print();
                    //FargoCardStatus();
                    SqlConnect();
                    CreateSECDataAdapter();
                    FillSECTableAdapter();
                    BatchPrintUncheck();
                            //COMMENT OUT WHEN TESTING AND UNCOMMENT OUT WHEN DONE TESTING
                    MyRefreshAll();
                    MessageBox.Show("Card has been printed.");
                }
                catch (Exception)
                {
                    MessageBox.Show("An Error Occured.");
                }
            }
        } //End secPrintPreviewButton_Click
        public void FargoCardStatus()
        {
                    // code below is modified from HID- Fargo SDK
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
            m_selectedPrinter = printerComboBox.Text;
        } //End FargoCardStatus
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
        } //End Font FindFont
        public void MySmartCardManager()
        {
            // code from HID- Fargo SDK
            // Create the Smart Card Resource Manager object.
            m_smartCardManager = new SmartCardManager.SmartCardManager();
        } //End MySmartCardManager
                         //
                         //
                         //  Below is code for the timer.
                         //
                         //
        private void timer1_Tick(object sender, EventArgs e)
        {
            duration--; //increment timer to count down by 1 sec (Set to 1000 in design view)
            textBox1.Text = duration.ToString();

            if (duration > 0)
            {
                printClearAllSEC();
            } // End if (duration
            else
            {
                timer1.Stop();
                MyRefreshAll();
                duration = 30;
                Active = false;
                timer1.Start();
            }
        } //end timer1_Tick
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
        } // End startTimerButton_Click
        private void stopTimerButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            MyRefreshAll();
            duration = 30;
        } // End stopTimerButton_Click
                         //
                         //
                         //  Below is code from HID- Fargo SDK
                         //
                         //
        private int m_iPageNumber;
        private int m_iNumPages = 1;
        private SmartCardManager.SmartCardManager m_smartCardManager;
        private string m_selectedPrinter;
                // Station to be used for the operation
        private Station m_station;
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
            printDocument2.PrintPage += new PrintPageEventHandler(printDocument2_PrintPage);



            // Use selected printer.
            printDocument2.PrinterSettings.PrinterName = m_selectedPrinter;

            //// To allow to change printer instance
            //// Pass the PrintDocument object in so that the dialog can update the printer name
            //// and devmode for this job.
            //PrintDialog dlgSettings = new PrintDialog();
            //dlgSettings.Document = m_printDocument;
            //dlgSettings.ShowDialog();


            m_iPageNumber = 1;
            m_iNumPages = 2;



            printDocument2.QueryPageSettings += new QueryPageSettingsEventHandler(printDocument_QueryPageSettings);

            printDocument2.PrinterSettings.Copies = 1;
            printDocument2.PrintController = spController;

            m_iPageNumber = 0;



            // Calling this method starts the printing process for this document
            printDocument2.Print();


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
        private void bindingNavigator_RefreshItems(object sender, EventArgs e)
        {


        }// End bindingNavigator_RefreshItems


    } // End SEC_Form : Form

} // End Namespace







   


