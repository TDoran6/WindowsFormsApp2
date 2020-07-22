using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.InteropServices;               // For Marshal
using System.Collections;                           // For IList
using System.Diagnostics;                           // For Debug



namespace SmartCardManager
{
    /// <summary>
    /// Smart Card Reader contexts
    /// </summary>
    public enum SCardContextScope
    {
        /// <summary>
        /// Database operations are performed within the domain of the system. The calling application must have appropriate access permissions for any database actions.
        /// </summary>
        System = 2,

        /// <summary>
        /// Terminal context
        /// </summary>
        Terminal = 1,

        /// <summary>
        /// Database operations are performed within the domain of the user.
        /// </summary>
        User = 0
    }




    public class SmartCardManager : IDisposable
    {
        // Methods
        public SmartCardManager()
        {
            this.m_fDisposed = false;
            this.m_hContext = IntPtr.Zero;
        }

        private void _Dispose(bool fDisposing)
        {
            if (!this.m_fDisposed)
            {
                if (this.m_hContext != IntPtr.Zero)
                {
                    //WinSCard.SCardCancel(this.m_hContext);
                    //WinSCard.SCardReleaseContext(this.m_hContext);
                    //this.m_hContext = IntPtr.Zero;
                }
                this.m_fDisposed = true;
            }
        }


        /// <summary>
        /// Split the provided string into the list.
        /// </summary>
        /// <param name="msz"></param>
        /// <param name="aList">Provided list object</param>
        /// <returns>Number of items in the list</returns>
        private int _SplitMultiString(string msz, IList aList)
        {
            int nTemp;
            int nCount = 0;

            // For each string
            // (Note bump past null terminator)
            for (int nIter = 0; msz[nIter] != '\0'; nIter = nTemp + 1)
            {
                nTemp = nIter;

                // While not end of the current string
                // within the passed in string.
                while (msz[nTemp] != '\0')
                {
                    nTemp++;
                }

                // Add the string object to the list
                aList.Add(msz.Substring(nIter, nTemp - nIter));

                // Bump up count of strings within the passed in string.
                nCount++;
            }

            // Return Count
            return nCount;
        }



        ~SmartCardManager()
        {
            this._Dispose(false);
        }

        public void Dispose()
        {
            this._Dispose(true);
            GC.SuppressFinalize(this);
        }



        public string VendorIFDSerialNo
        {
            get
            {
                if (m_sVendorIfdSerialNo == null)
                    m_sVendorIfdSerialNo = GetReaderCapabilitiesString(SCardReaderCapability.VendorIFDSerialNo);
                return m_sVendorIfdSerialNo;
            }
        }

        public string VendorIFDType
        {
            get
            {
                if (m_sVendorIfdType == null)
                    m_sVendorIfdType = GetReaderCapabilitiesString(SCardReaderCapability.VendorIFDType);
                return m_sVendorIfdType;
            }
        }

        public Version VendorIFDVersion
        {
            get
            {
                if (m_aVendorIfdVersion == null)
                {
                    int i1 = GetReaderCapabilitiesInteger(SCardReaderCapability.VendorIFDVersion, -1);
                    if (i1 > 0)
                    {
                        int i2 = (i1 >> 24) & 255;
                        int i3 = (i1 >> 16) & 255;
                        int i4 = i1 & 65535;
                        m_aVendorIfdVersion = new Version(i2, i3, i4);
                    }
                }
                return m_aVendorIfdVersion;
            }
        }

        public string VendorName
        {
            get
            {
                if (m_sVendorName == null)
                    m_sVendorName = GetReaderCapabilitiesString(SCardReaderCapability.VendorName);
                return m_sVendorName;
            }
        }


        //public string getVendorIFDVersion()
        //{
        //    string retValue;
        //    retValue = VendorIFDVersion.ToString();
        //    return retValue;
        //}


        public bool GetReaderCapabilities(SCardReaderCapability nTag, out byte[] vbValue)
        {
            //if (this.m_fDisposed)
            //{
            //    throw new ObjectDisposedException(base.GetType().FullName);
            //}
            if ((/*this.*/m_hCard == IntPtr.Zero) || !/*this.*/m_fIsConnected)
            {
                throw new InvalidOperationException();
            }
            IntPtr ptr1 = IntPtr.Zero;
            uint num1 = uint.MaxValue;
            uint num2 = WinSCard.SCardGetAttrib(this.m_hCard, (uint)nTag, ref ptr1, ref num1);
            switch (num2)
            {
                case 0:
                    vbValue = new byte[num1];
                    Marshal.Copy(ptr1, vbValue, 0, (int)num1);
                    //num2 = WinSCard.SCardFreeMemory(this.m_aResourceManager.Context, ptr1);
                    return true;

                case 50:
                case 0x16:
                    vbValue = null;
                    return false;
            }
            //SmartCardException.RaiseWin32ResponseCode(num2);
            throw new InvalidProgramException();
        }


        public int GetReaderCapabilitiesByte(SCardReaderCapability nTag)
        {
            byte[] bArr;

            if (!GetReaderCapabilities(nTag, out bArr))
                return -1;
            if (bArr.Length < 1)
            {
                //throw new SmartCardException(0);
            }
            return bArr[0];
        }




        public string GetReaderCapabilitiesByteToString(SCardReaderCapability ReaderCapability)
        {
            int x = GetReaderCapabilitiesByte(ReaderCapability);
            return Convert.ToString(x);
        }

        public string GetReaderCapabilitiesIntToString(SCardReaderCapability ReaderCapability)
        {
            return Convert.ToString(GetReaderCapabilitiesInteger(ReaderCapability, 0));
        }


        public int GetReaderCapabilitiesInteger(SCardReaderCapability nTag, int nDefaultValue)
        {
            byte[] buffer1;
            if (!this.GetReaderCapabilities(nTag, out buffer1))
            {
                return nDefaultValue;
            }
            if (buffer1.Length < 4)
            {
            }
            return BitConverter.ToInt32(buffer1, 0);
        }




        public string GetReaderCapabilitiesString(SCardReaderCapability nTag)
        {
            byte[] bArr;

            if (!GetReaderCapabilities(nTag, out bArr))
                return null;

            int i = bArr.Length;

            if ((i > 0) && (bArr[i - 1] == 0))
                i--;

            return System.Text.Encoding.GetEncoding(1252).GetString(bArr, 0, i);
        }



        //public string GetReaderVendorName(string strReader)
        //{
        //    string strResponse = GetReaderCapabilitiesString(SCardReaderCapability.VendorName);

        //    return strResponse;
        //}

        //public string GetReaderIFDSerialNo(string strReader)
        //{
        //    string strResponse = GetReaderCapabilitiesByteToString(SCardReaderCapability.VendorIFDSerialNo);

        //    return strResponse;
        //}

        //public string GetReaderIFDVersion(string strReader)
        //{
        //    //string strResponse = getVendorIFDVersion();
        //    return (VendorIFDVersion.ToString());
        //}

        //public string GetReaderIFDType(string strReader)
        //{
        //    string strResponse = GetReaderCapabilitiesString(SCardReaderCapability.VendorIFDType);
        //    return strResponse;
        //}

        public string GetReaderSystemName()
        {
            string strResponse = GetReaderCapabilitiesString(SCardReaderCapability.DeviceSystemName);
            return strResponse;
        }
        public string GetReaderFriendlyName()
        {
            string strResponse = GetReaderCapabilitiesString(SCardReaderCapability.DeviceFriendlyName);
            return strResponse;
        }
        public string GetReaderMaxDataRate()
        {
            string strResponse = GetReaderCapabilitiesIntToString(SCardReaderCapability.ProtocolMaxDataRate);
            return strResponse;
        }



        // Context Functions

        /// <summary>
        /// Establish a resource manager context for the query.
        /// </summary>
        /// <param name="nScope"></param>
        /// <returns></returns>
        /// <remarks>
        /// The context used by the resource manager when accessing the smart 
        /// card database. The resource manager context is primarily used by the 
        /// query and management functions when accessing the database. The scope 
        /// of the resource manager context can be the current user or the system.
        /// </remarks>
        public bool EstablishContext(SCardContextScope nScope)
        {
            uint nErrCode;
            if (this.m_fDisposed)
            {
                throw new ObjectDisposedException(base.GetType().FullName);
            }
            if (this.m_hContext != IntPtr.Zero)
            {
                // Just release it so can get new one.
                nErrCode = WinSCard.SCardReleaseContext(this.m_hContext);
            }

            // Establish the resource manager context on the card.
            nErrCode = WinSCard.SCardEstablishContext((uint)nScope, IntPtr.Zero, IntPtr.Zero, out this.m_hContext);

            // If Service not running
            if (nErrCode == 0x8010001d)
            {
                //MessageBox.Show("The ensure that SCardSvr Service is running. PC/SC routines won't be available.");
                // Sometimes this is ok, like installing the omnikey ethernet driver the first time, besides, this is 
                // a rude practice and the text is gibberish.
                return false;
            }

            // else there is some other problem
            if (nErrCode != 0)
            {
                //MessageBox.Show(string.Format("SCardEstablishContext failed: 0x{0:X8}", nErrCode));
                //SCardException.RaiseWin32ResponseCode(nErrCode);
            }
            return true;
        }


        /// <summary>
        /// Release the resource manager context for the query
        /// </summary>
        public void ReleaseContext()
        {
            // Sanity Check
            if (this.m_fDisposed)
            {
                throw new ObjectDisposedException(base.GetType().FullName);
            }

            // Check Context
            if (this.m_hContext == IntPtr.Zero)
            {
                throw new InvalidOperationException();
            }

            // Cancel???
            WinSCard.SCardCancel(this.m_hContext);


            uint nErrCode = WinSCard.SCardReleaseContext(this.m_hContext);

            // Set Zero
            this.m_hContext = IntPtr.Zero;

            // Was there an error
            if (nErrCode != 0)
            {
                //SCardException.RaiseWin32ResponseCode(nErrCode);
            }
        }


        public bool IsValidContext()
        {
            // Sanity Check
            if (this.m_fDisposed)
            {
                throw new ObjectDisposedException(base.GetType().FullName);
            }

            // Verify Context exists
            if (this.m_hContext == IntPtr.Zero)
            {
                throw new InvalidOperationException();
            }

            // Call native fxn and return appropriately
            uint nErrCode = WinSCard.SCardIsValidContext(this.m_hContext);
            if (nErrCode == 0)
            {
                return true;
            }
            return false;
        }




        // Tracking Functions
        public void Cancel()
        {
            if (this.m_hContext == IntPtr.Zero)
            {
                throw new InvalidOperationException();
            }
            uint nErrCode = WinSCard.SCardCancel(this.m_hContext);
            if (nErrCode != 0)
            {
                //SCardException.RaiseWin32ResponseCode(nErrCode);
            }
        }


        /// <summary>
        /// Wait until one of the specified status changes occur (or timeout)
        /// </summary>
        /// <param name="nTimeout"></param>
        /// <param name="vaSCStates"></param>
        /// <returns></returns>
        public bool GetStatusChange(int nTimeout, SCStateInfo[] vaSCStates)
        {
            int nLen = vaSCStates.Length;

            // Create the array for the API call
            WinSCard.SCARD_READERSTATE[] statearray = new WinSCard.SCARD_READERSTATE[nLen];

            for (int nIter = 0; nIter < nLen; nIter++)
            {
                statearray[nIter].szReader = vaSCStates[nIter].sReaderName;
                statearray[nIter].pvUserData = IntPtr.Zero;
                statearray[nIter].dwCurrentState = (uint)vaSCStates[nIter].nCurrentState;
                statearray[nIter].dwEventState = (uint)SCStates.Unaware;
                statearray[nIter].cbAtr = 0;
                statearray[nIter].rgbAtr = null;
            }

            uint nErrCode = WinSCard.SCardGetStatusChange(this.m_hContext, (uint)nTimeout, statearray, (uint)statearray.Length);

            if (nErrCode == 0)
            {
                for (int nLoopCnt = 0; nLoopCnt < nLen; nLoopCnt++)
                {
                    vaSCStates[nLoopCnt].nEventState = (SCStates)statearray[nLoopCnt].dwEventState;
                    if ((statearray[nLoopCnt].cbAtr > 0) && (statearray[nLoopCnt].rgbAtr != null))
                    {
                        vaSCStates[nLoopCnt].vbATR = new byte[statearray[nLoopCnt].cbAtr];
                        Buffer.BlockCopy(statearray[nLoopCnt].rgbAtr, 0, vaSCStates[nLoopCnt].vbATR, 0, (int)statearray[nLoopCnt].cbAtr);
                    }
                    else
                    {
                        vaSCStates[nLoopCnt].vbATR = null;
                    }
                }
                return true;
            }

            // If Timeout or SCardCancel happened just bail out
            if ((nErrCode == 0x8010000a) || (nErrCode == 0x80100002))
            {
                return false;
            }
            // If we reach here there is a problem
            //SCardException.RaiseWin32ResponseCode(nErrCode);
            throw new InvalidProgramException();
        }


        /// <summary>
        /// Wait until the specified status change occurs (or timeout)
        /// </summary>
        /// <param name="nTimeout"></param>
        /// <param name="aSCInfo"></param>
        /// <returns></returns>
        public bool GetStatusChange(int nTimeout, ref SCStateInfo aSCInfo)
        {
            // Only looking for one state
            SCStateInfo[] infoArray = new SCStateInfo[1] { aSCInfo };

            bool bStatus = this.GetStatusChange(nTimeout, infoArray);

            // Return the resulting state
            aSCInfo = infoArray[0];

            return bStatus;
        }

        /// <summary>
        /// Wait until the specified status change occurs (or timeout) then get the resulting state.
        /// </summary>
        /// <param name="nTimeout"></param>
        /// <param name="sReaderName"></param>
        /// <param name="nCurrentState"></param>
        /// <param name="nEventState"></param>
        /// <returns></returns>
        public bool GetStatusChange(int nTimeout, string sReaderName, SCStates nCurrentState, out SCStates nEventState)
        {
            // Get the 
            SCStateInfo info;
            info.sReaderName = sReaderName;
            info.nCurrentState = nCurrentState;
            info.nEventState = SCStates.Unaware;
            info.vbATR = null;

            bool bStatus = this.GetStatusChange(nTimeout, ref info);
            nEventState = info.nEventState;
            return bStatus;
        }


        public SCardReaderState Status(out byte[] byteATR, out SCardReaderState eState, out SCardProtocolIdentifiers eProtocol)
        {
            if (this.m_fDisposed)
            {
                throw new ObjectDisposedException(base.GetType().FullName);
            }
            if (this.m_hCard == IntPtr.Zero)
            {
                throw new InvalidOperationException();
            }
            StringBuilder builder1 = new StringBuilder(0x100);
            uint num3 = (uint)builder1.Capacity;
            byte[] atr = new byte[0x20];
            uint num4 = (uint)atr.Length;
            uint dwState;
            uint dwProtocol;
            uint dwATRLength = (uint)atr.Length;

            uint num5 = WinSCard.SCardStatus(this.m_hCard, builder1, ref num3/*builder1.Capacity*/, out dwState/*pdwState*/, out dwProtocol/*pdwProtocol*/, atr/*pbATR*/, ref dwATRLength/*pbcATRLen*/);
            if (num5 != 0)
            {
                //SmartCardException.RaiseWin32ResponseCode(num5);
            }
            eState = (SCardReaderState)dwState;
            eProtocol = (SCardProtocolIdentifiers)dwProtocol;
            if (dwATRLength > 0)
            {
                // copy only the valid portion of the ATR to the return buffer.
                byteATR = new byte[dwATRLength];
                for (int i = 0; i < dwATRLength; i++)
                {
                    byteATR[i] = atr[i];
                }

            }
            else
            {
                byteATR = new byte[1];
                byteATR[0] = 0;// return an invalid state.
            }

            return (SCardReaderState)dwState;
        }


        public string GetATR()
        {
            string result = string.Empty;
            byte[] byteATR;
            SCardReaderState eState;
            SCardReaderState stateOut;
            SCardProtocolIdentifiers eProtocol;

            // Returns at byte array with at least one byte.
            stateOut = Status(out byteATR, out eState, out eProtocol);


            result += byteATR[0].ToString();
            for (int i = 1; i < byteATR.Length; i++)
            {
                result += " " + byteATR[i].ToString();
            }

            return result;
        }

        // Database Functions

        /// <summary>
        /// List the reader groups.
        /// </summary>
        /// <param name="aReaderGroupsList">List of reader groups</param>
        /// <returns></returns>
        public int ListReaderGroups(IList aReaderGroupsList)
        {
            // Sanity Check
            if (this.m_fDisposed)
            {
                throw new ObjectDisposedException(base.GetType().FullName);
            }
            // Sanity Check
            if (this.m_hContext == IntPtr.Zero)
            {
                throw new InvalidOperationException();
            }

            int nRet = 0;
            IntPtr ptrRMgrMem = IntPtr.Zero;
            uint nMax = uint.MaxValue;
            uint nErrCode = WinSCard.SCardListReaderGroups(this.m_hContext, ref ptrRMgrMem, ref nMax);

            // Success
            //if (nErrCode == 0)
            if (nErrCode == (uint)SCardReturnValues.SCARD_S_SUCCESS)
            {
                string text = Marshal.PtrToStringAuto(ptrRMgrMem, (int)nMax);
                nRet = this._SplitMultiString(text, aReaderGroupsList);
                nErrCode = WinSCard.SCardFreeMemory(this.m_hContext, ptrRMgrMem);
                return nRet;
            }

            // Error
            //if (nErrCode == 2148532270)
            if (nErrCode == (uint)SCardReturnValues.SCARD_E_NO_READERS_AVAILABLE)
            {
                return 0;
            }

            // Exception
            //SCardException.RaiseWin32ResponseCode(nErrCode);
            return nRet;
        }


        /// <summary>
        /// List all installed readers 
        /// </summary>
        /// <param name="aReadersList">Provided list object.</param>
        /// <returns>Number of readers installed</returns>
        public int ListReaders(IList aReadersList)
        {
            // Use a NULL value for "groups" to list all readers in the system
            return this.ListReaders((string[])null, aReadersList);
        }


        /// <summary>
        /// List the installed readers within a given group.
        /// </summary>
        /// <param name="sGroup">Group name</param>
        /// <param name="aReadersList">Provided list object.</param>
        /// <returns></returns>
        public int ListReaders(string sGroup, IList aReadersList)
        {
            // Sanity Check
            if ((sGroup == null) || (sGroup.Length == 0))
            {
                throw new ArgumentNullException();
            }

            // Create array of strings with only the one item
            string[] textArray = new string[1] { sGroup };

            // Then call the method 
            return this.ListReaders(textArray, aReadersList);
        }

        /// <summary>
        /// List the installed readers within the given list of groups.
        /// </summary>
        /// <param name="vsGroups">List of reader groups</param>
        /// <param name="aReadersList">Provided list object</param>
        /// <returns></returns>
        public int ListReaders(string[] vsGroups, IList aReadersList)
        {
            // Sanity Check
            if (this.m_fDisposed)
            {
                throw new ObjectDisposedException(base.GetType().FullName);
            }

            // A handle to the context had to be established prior to this.
            // (i.e. by calling EstablishContext)
            if (this.m_hContext == IntPtr.Zero)
            {
                throw new InvalidOperationException();
            }

            // Assume no readers yet
            int nReaders = 0;
            string text = null;

            // If a list of readers groups was provided then concatenate them
            // into a multi-string.  If not then all reader groups will be read.
            if ((vsGroups != null) && (vsGroups.Length > 0))
            {
                string[] textArray = vsGroups;
                for (int nIter = 0; nIter < textArray.Length; nIter++)
                {
                    string strTemp = textArray[nIter];
                    text = text + strTemp;
                    text = text + '\0';
                }
                text = text + '\0';
            }

            // NULL pointer - indicates to allocate the buffer internally.
            IntPtr ptrMem = IntPtr.Zero;

            // Autoallocate: SCARD_AUTOALLOCATE (which is -1).  See Winscard.h within the DDK.
            uint nMax = uint.MaxValue;

            // List the reader names within the given groups.
            // 
            // If pointer to the readers list (3rd parm) is NULL, SCardListReaders ignores the buffer length supplied 
            // in the 4th parm, writes the length of the buffer that would have been returned if this parameter had not 
            // been NULL to that passed in pointer, and returns a success code.
            //
            // The 4th parameter receives the actual length of the multi-string structure, including all trailing null 
            // characters. If the buffer length is specified as SCARD_AUTOALLOCATE, then mszReaders is converted to 
            // a pointer to a byte pointer, and receives the address of a block of memory containing the multi-string 
            // structure. This block of memory must be deallocated with SCardFreeMemory.
            uint nErrCode = WinSCard.SCardListReaders(this.m_hContext, text, ref ptrMem, ref nMax);

            // If the call returned OK then can interpret the results.
            if (nErrCode == (uint)SCardReturnValues.SCARD_S_SUCCESS)
            {
                // Marshall the list of readers to a string
                string sReaders = Marshal.PtrToStringAuto(ptrMem, (int)nMax);

                // Split the string into the ArrayList object provided by caller.
                nReaders = this._SplitMultiString(sReaders, aReadersList);

                // Free Autoallocate
                nErrCode = WinSCard.SCardFreeMemory(this.m_hContext, ptrMem);

                // Return the number of items in the ArrayList.
                return nReaders;
            }

            // Not successfully read
            if (nErrCode == (uint)SCardReturnValues.SCARD_E_NO_READERS_AVAILABLE)
            {
                return 0;
            }

            // Report Error
            //SCardException.RaiseWin32ResponseCode(nErrCode);
            return nReaders;
        }



        /// <summary>
        /// Connect the application to the PCSC driver
        /// </summary>
        /// <param name="sReader">The reader name</param>
        /// <param name="nAccessMode">Access mode (Direct, Exclusive or Shared).</param>
        /// <param name="nPreferredProtocols">Protocols the driver should use to communicate with the reader.</param>
        /// <returns>True if successfully connected, False if card removed.</returns>
        public bool Connect(string sReader, SCardAccessMode nAccessMode, SCardProtocolIdentifiers nPreferredProtocols)
        {
            if (this.m_fDisposed)
            {
                throw new ObjectDisposedException(base.GetType().FullName);
            }
            if (((this.m_hCard != IntPtr.Zero) || (this.Context == IntPtr.Zero)) || this.m_fIsConnected)
            {
                throw new InvalidOperationException();
            }

            // Share mode and protocols from caller.
            uint num1 = (uint)nAccessMode;
            uint num2 = (uint)nPreferredProtocols;

            // Establish a connection between application and card docked in the reader.
            // (Gets the handle to the card and the active protocol of the connection)
            uint num3 = WinSCard.SCardConnect(this.Context, sReader, num1, num2, out this.m_hCard, out this.m_dwActiveProtocol);

            // Check error code - either successfully connected or the card was removed are ok.
            switch (num3)
            {
                case (uint)SCardErrorCodes.SCARD_S_SUCCESS:
                    //case 0:
                    this.m_fIsConnected = true;
                    return true;

                case (uint)SCardErrorCodes.SCARD_W_REMOVED_CARD:
                    //case 0x80100069:
                    return false;
            }

            // Any other error codes are raised.
            //SCardException.RaiseWin32ResponseCode(num3);
            throw new InvalidProgramException();
        }




        /// <summary>
        /// Disconnect from the PCSC reader
        /// </summary>
        /// <param name="nDisposition"></param>
        public void Disconnect(SCardDisposition nDisposition)
        {
            if (this.m_fDisposed)
            {
                throw new ObjectDisposedException(base.GetType().FullName);
            }
            if ((this.m_hCard == IntPtr.Zero) || !this.m_fIsConnected)
            {
                throw new InvalidOperationException();
            }

            // Terminate the connection with this SmartCard
            uint num1 = WinSCard.SCardDisconnect(this.m_hCard, (uint)nDisposition);

            this.m_hCard = IntPtr.Zero;
            this.m_dwActiveProtocol = 0;
            this.m_fIsConnected = false;
            //this.m_fInTransaction = false;
            if (num1 != 0)
            {
                //SCardException.RaiseWin32ResponseCode(num1);
            }
        }

        /// <summary>
        /// Send a control code to the reader
        /// </summary>
        /// <param name="nControlCode"></param>
        /// <param name="vbInBuffer"></param>
        /// <param name="vbOutBuffer"></param>
        public void Control(int nControlCode, byte[] vbInBuffer, out byte[] vbOutBuffer)
        {
            if (m_fDisposed)
                throw new ObjectDisposedException(GetType().FullName);
            if (m_hCard == IntPtr.Zero || !m_fIsConnected)
                throw new InvalidOperationException();

            byte[] bArr = new byte[65538];
            uint ui1 = 0;

            // Send the control code using the PCSC interface to the reader
            uint ui2 = WinSCard.SCardControl(m_hCard, (uint)nControlCode, vbInBuffer, (uint)vbInBuffer.Length, bArr, (uint)bArr.Length, out ui1);

            // If the call was successful, get the response
            if ((int)ui2 == 0)
            {
                // Any bytes returned?
                if ((int)ui1 > 0)
                {
                    // Get the response
                    vbOutBuffer = new byte[ui1];
                    Buffer.BlockCopy(bArr, 0, vbOutBuffer, 0, (int)ui1);
                    return;
                }
                vbOutBuffer = null;
                return;
            }

            // Error code
            //SCardException.RaiseWin32ResponseCode(ui2);
            throw new InvalidProgramException();
        }




        public static int SCardCtlCode(int nFunctionCode)
        {
            return (0x310000 | (nFunctionCode << 2));
        }


        // Properties

        /// <summary>
        /// Handle of the context
        /// </summary>
        public IntPtr Context
        {
            get
            {
                return this.m_hContext;
            }
        }


        public bool IsConnected
        {
            get
            {
                return m_fIsConnected;
            }
        }












        // Fields

        private bool m_fDisposed;

        /// <summary>
        /// Handle of the context
        /// </summary>
        private IntPtr m_hContext;

        private bool m_fIsConnected;

        private IntPtr m_hCard;

        private uint m_dwActiveProtocol;



        private string m_sVendorIfdSerialNo;

        private string m_sVendorIfdType;

        private Version m_aVendorIfdVersion;

        private string m_sVendorName;


        //private bool m_fInTransaction;
    }
}
