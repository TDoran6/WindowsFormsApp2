
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace SmartCardManager
{
    internal sealed class WinSCard
    {
        // Methods
        public WinSCard()
        {
        }

        // Native Methods Entrypoints
        [DllImport("WINSCARD.DLL")]
        internal static extern uint SCardBeginTransaction(IntPtr hCard);

        [DllImport("WINSCARD.DLL")]
        internal static extern uint SCardCancel(IntPtr hContext);

        /// <summary>
        /// Establishes a connection (using a specific resource manager context) between calling app and a smart card contained by a specific reader.
        /// </summary>
        /// <param name="hContext">Handle of the resource manager context</param>
        /// <param name="szReader">Name of the reader that contains the target card.</param>
        /// <param name="dwShareMode">Flag that indicates whether other applications may form connections to the card.</param>
        /// <param name="dwPreferredProtocols">Bitmask of acceptable protocols for the connection.</param>
        /// <param name="phCard">(Out) Handle that identifies the connection to the smart card in the designated reader.</param>
        /// <param name="pdwActiveProtocol">(Out) Flag that indicates the established active protocol.</param>
        /// <returns>SCARD_S_SUCCESS if success</returns>
        [DllImport("WINSCARD.DLL", CharSet = CharSet.Auto)]
        internal static extern uint SCardConnect(
            IntPtr hContext,
            string szReader,
            uint dwShareMode,
            uint dwPreferredProtocols,
            out IntPtr phCard,
            out uint pdwActiveProtocol);



        /// <summary>
        /// Send a control code to the reader
        /// </summary>
        /// <param name="hCard">Handle to the card</param>
        /// <param name="dwControlCode">Control code for the operation. This value identifies the specific operation to be performed.</param>
        /// <param name="lpInBuffer">Pointer to a buffer that contains the data required to perform the operation.</param>
        /// <param name="nInBufferSize">Size, in bytes, of the buffer pointed to by lpInBuffer.</param>
        /// <param name="lpOutBuffer">Pointer to a buffer that receives the operation's output data.</param>
        /// <param name="nOutBufferSize">Size, in bytes, of the buffer pointed to by lpOutBuffer.</param>
        /// <param name="lpBytesReturned">Pointer to a DWORD that receives the size, in bytes, of the data stored into the buffer pointed to by lpOutBuffer.</param>
        /// <returns>SCARD_S_SUCCESS if successful.</returns>
        [DllImport("WINSCARD.DLL")]
        internal static extern uint SCardControl(
            IntPtr hCard,
            uint dwControlCode,
            [In] byte[] lpInBuffer,
            uint nInBufferSize,
            [In, Out] byte[] lpOutBuffer,
            uint nOutBufferSize,
            out uint lpBytesReturned);

        /// <summary>
        /// Terminates a connection previously opened between the calling application and a smart card in the target reader.
        /// </summary>
        /// <param name="hCard"></param>
        /// <param name="dwDisposition"></param>
        /// <returns></returns>
        [DllImport("WINSCARD.DLL")]
        internal static extern uint SCardDisconnect(
            IntPtr hCard,
            uint dwDisposition);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hCard"></param>
        /// <param name="dwDisposition"></param>
        /// <returns></returns>
        [DllImport("WINSCARD.DLL")]
        internal static extern uint SCardEndTransaction(
            IntPtr hCard,
            uint dwDisposition);

        /// <summary>
        /// Establishes the resource manager context (the scope) within which database operations are performed.
        /// </summary>
        /// <param name="dwScope"></param>
        /// <param name="pvReserved1"></param>
        /// <param name="pvReserved2"></param>
        /// <param name="phContext"></param>
        /// <returns></returns>
        [DllImport("WINSCARD.DLL")]
        internal static extern uint SCardEstablishContext(
            uint dwScope,
            IntPtr pvReserved1,
            IntPtr pvReserved2,
            out IntPtr phContext);

        [DllImport("WINSCARD.DLL")]
        internal static extern uint SCardFreeMemory(
            IntPtr hContext,
            IntPtr pvMem);

        [DllImport("WINSCARD.DLL")]
        internal static extern uint SCardGetAttrib(
            IntPtr hCard,
            uint dwAttrId,
            ref IntPtr pbAttr,
            ref uint pcbAttrLen);


        /// <summary>
        /// Blocks execution until the current availability of the cards in a specific set of readers changes.
        /// </summary>
        /// <param name="hContext">identifies the resource manager context.</param>
        /// <param name="dwTimeout">The maximum amount of time, in milliseconds, to wait for an action. A value of zero causes the function to return immediately. A value of INFINITE causes this function never to time out</param>
        /// <param name="rgReaderStates">An array of SCARD_READERSTATE structures that specify the readers to watch, and that receives the result.</param>
        /// <param name="cReaders">The number of elements in the rgReaderStates array.</param>
        /// <returns>SCARD_S_SUCCESS if successful</returns>
        [DllImport("WINSCARD.DLL", CharSet = CharSet.Auto)]
        internal static extern uint SCardGetStatusChange(
            IntPtr hContext,
            uint dwTimeout,
            [In, Out] SCARD_READERSTATE[] rgReaderStates,
            uint cReaders);


        [DllImport("WINSCARD.DLL")]
        internal static extern uint SCardIsValidContext(
            IntPtr hContext);

        [DllImport("WINSCARD.DLL", CharSet = CharSet.Auto)]
        internal static extern uint SCardListReaderGroups(
            IntPtr hContext,
            ref IntPtr pmszGroups,
            ref uint pcchGroups);

        /// <summary>
        /// Provides the list of readers within a set of named reader groups, eliminating duplicates.
        /// </summary>
        /// <param name="hContext">Handle that identifies the resource manager context for the query.</param>
        /// <param name="mszGroups">Names of the reader groups defined to the system, as a multi-string.</param>
        /// <param name="pmszReaders">Multi-string that lists the card readers within the supplied reader groups.</param>
        /// <param name="pcchReaders">Length of the mszReaders buffer in characters.</param>
        /// <returns>SCARD_S_SUCCESS if success, otherwise other error codes (see SCardErr.h in the Windows DDK)</returns>
        /// <remarks>
        /// The caller supplies a list of reader groups, and receives the list of readers within the named groups. 
        /// Unrecognized group names are ignored.
        /// </remarks>
        [DllImport("WINSCARD.DLL", CharSet = CharSet.Auto)]
        internal static extern uint SCardListReaders(
            IntPtr hContext,
            string mszGroups,
            ref IntPtr pmszReaders,
            ref uint pcchReaders);

        [DllImport("WINSCARD.DLL")]
        internal static extern uint SCardReconnect(
            IntPtr hCard,
            uint dwShareMode,
            uint dwPreferredProtocols,
            uint dwInitialization,
            out uint pdwActiveProtocol);

        [DllImport("WINSCARD.DLL")]
        internal static extern uint SCardReleaseContext(
            IntPtr hContext);

        [DllImport("WINSCARD.DLL")]
        internal static extern uint SCardSetAttrib(
            IntPtr hCard,
            uint dwAttrId,
            [In] byte[] pbAttr,
            uint cbAttrLen);

        [DllImport("WINSCARD.DLL", CharSet = CharSet.Auto)]
        internal static extern uint SCardStatus(
            IntPtr hCard,
            StringBuilder szReaderName,
            ref uint pcchReaderLen,
            out uint pdwState,
            out uint pdwProtocol,
            [Out] byte[] pbAtr,
            ref uint pcbAtrLen);

        [DllImport("WINSCARD.DLL")]
        internal static extern uint SCardTransmit(
            IntPtr hCard,
            SCARD_IO_REQUEST pioSendPci,
            [In] byte[] pbSendBuffer,
            uint cbSendLength,
            SCARD_IO_REQUEST pioRecvPci,
            [In, Out] byte[] pbRecvBuffer,
            ref uint pcbRecvLength);

        // Private/Internal Types
        [StructLayout(LayoutKind.Sequential)]
        internal class SCARD_IO_REQUEST
        {
            internal uint dwProtocol;
            internal uint cbPciLength;
            public SCARD_IO_REQUEST()
            {
                dwProtocol = 0;
            }
        }


        /// <summary>
        /// Used by functions for tracking smart cards within readers.
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        internal struct SCARD_READERSTATE
        {
            /// <summary>
            /// A pointer to the name of the reader being monitored.
            /// </summary>
            internal string szReader;

            /// <summary>
            /// Not used by the smart card subsystem. This member is used by the application.
            /// </summary>
            internal IntPtr pvUserData;

            /// <summary>
            /// Current state of the reader, as seen by the application.
            /// </summary>
            internal uint dwCurrentState;

            /// <summary>
            /// Current state of the reader, as known by the smart card resource manager.
            /// </summary>
            internal uint dwEventState;

            /// <summary>
            /// Number of bytes in the returned ATR.
            /// </summary>
            internal uint cbAtr;

            /// <summary>
            /// ATR of the inserted card, with extra alignment bytes.
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 0x24, ArraySubType = UnmanagedType.U1)]
            internal byte[] rgbAtr;
        }







    }
}
