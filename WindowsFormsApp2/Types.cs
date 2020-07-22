using System;
using System.Runtime.InteropServices;

namespace SmartCardManager
{
    /// <summary>
    /// A flag that indicates whether other applications may form connections to the card.
    /// </summary>
    public enum SCardAccessMode
    {
        /// <summary>
        /// (SCARD_SHARE_DIRECT) This application is allocating the reader for its private use, and will be controlling it directly. No other applications are allowed access to it.
        /// </summary>
        Direct = 3,

        /// <summary>
        /// (SCARD_SHARE_EXCLUSIVE) This application is not willing to share the card with other applications.
        /// </summary>
        Exclusive = 1,

        /// <summary>
        /// (SCARD_SHARE_SHARED) This application is willing to share the card with other applications.
        /// </summary>
        Shared = 2
    }

    /// <summary>
    /// 
    /// </summary>
    public enum SCardResponseCode
    {
        Cancelled = 2,
        InsufficientBuffer = 8,
        InvalidHandle = 3,
        InvalidParameter = 4,
        InvalidValue = 0x11,
        NoMemory = 6,
        NoService = 0x1d,
        NoSmartCard = 12,
        NotReady = 0x10,
        NotTransacted = 0x16,
        ProtoMismatch = 15,
        ReaderUnavailable = 0x17,
        RemovedCard = 0x69,
        ResetCard = 0x68,
        ServiceStopped = 30,
        SharingViolation = 11,
        SystemCancelled = 0x12,
        Timeout = 10,
        UnknownCard = 13,
        UnknownReader = 9,
        UnpoweredCard = 0x67,
        UnresponsiveCard = 0x66,
        UnsupportedCard = 0x65
    }

    ///// <summary>
    ///// Smart Card Reader contexts
    ///// </summary>
    //public enum SCardContextScope
    //{
    //    /// <summary>
    //    /// Database operations are performed within the domain of the system. The calling application must have appropriate access permissions for any database actions.
    //    /// </summary>
    //    System = 2,

    //    /// <summary>
    //    /// Terminal context
    //    /// </summary>
    //    Terminal = 1,

    //    /// <summary>
    //    /// Database operations are performed within the domain of the user.
    //    /// </summary>
    //    User = 0
    //}

    /// <summary>
    /// Smart Card Reader return codes.
    /// </summary>
    /// <remarks>See SCardErr.h in the Windows DDK</remarks>
    public enum SCardReturnValues : uint
    {
        /// <summary>
        /// Success.
        /// </summary>
        SCARD_S_SUCCESS = 0,

        /// <summary>
        /// Cannot find a smart card reader.
        /// </summary>
        SCARD_E_NO_READERS_AVAILABLE = 0x8010002E,
    }



    public enum SCardReaderState
    {
        Absent = 1,
        Negotiable = 5,
        Powered = 4,
        Present = 2,
        Specific = 6,
        Swallowed = 3,
        Unknown = 0
    }

    public enum SCardReaderCapability
    {
        ATRString = 0x90303,
        ChannelID = 0x20110,
        Characteristics = 0x60150,
        CurrentBWT = 0x80209,
        CurrentCLK = 0x80202,
        CurrentCWT = 524810,
        CurrentD = 0x80204,
        CurrentEBCEncoding = 0x8020b,
        CurrentF = 0x80203,
        CurrentIFSC = 0x80207,
        CurrentIFSD = 0x80208,
        CurrentIOState = 0x90302,
        CurrentN = 0x80205,
        CurrentProtocolType = 0x80201,
        CurrentW = 0x80206,
        DeviceFriendlyName = 0x7fff0003,
        DeviceInUse = 0x7fff0002,
        DeviceSystemName = 0x7fff0004,
        DeviceUnit = 0x7fff0001,
        EscAuthRequest = 0x7a005,
        EscCancel = 0x7a003,
        EscReset = 0x7a000,
        ExtendedBWT = 0x8020c,
        ICCInterfaceStatus = 0x90301,
        ICCPresence = 0x90300,
        ICCTypePerATR = 0x90304,
        MaxInput = 0x7a007,
        PerfBytesTransmitted = 0x7ffe0002,
        PerfNumTransmissions = 0x7ffe0001,
        PerfTransmissionTime = 0x7ffe0003,
        PowerMgmtSupport = 0x40131,
        ProtocolDefaultCLK = 0x30121,
        ProtocolDefaultDataRate = 0x30123,
        ProtocolMaxCLK = 0x30122,
        ProtocolMaxDataRate = 196900,
        ProtocolMaxIFSD = 0x30125,
        ProtocolTypes = 0x30120,
        SuppressT1IFSRequest = 0x7fff0007,
        UserAuthInputDevice = 0x50142,
        UserToCardAuthDevice = 328000,
        VendorIFDSerialNo = 0x10103,
        VendorIFDType = 0x10101,
        VendorIFDVersion = 0x10102,
        VendorName = 0x10100
    }


    /// <summary>
    /// Type of protocol used between the driver and reader.
    /// </summary>
    [Flags]
    public enum SCardProtocolIdentifiers
    {
        /// <summary>
        /// Quad word 0xFFFFFFFF80000000
        /// </summary>
        Default = -2147483648,

        Optimal = 0,

        Raw = 0x10000,

        /// <summary>
        /// T=0 is the active protocol
        /// </summary>
        T0 = 1,

        /// <summary>
        /// T=1 is the active protocol.
        /// </summary>
        T1 = 2,

        /// <summary>
        /// (SCARD_PROTOCOL_UNDEFINED) SCARD_SHARE_DIRECT has been specified, so that no protocol negotiation has occurred. It is possible that there is no card in the reader.
        /// </summary>
        Undefined = 0
    }




    /// <summary>
    /// SCard function error codes.
    /// </summary>
    public enum SCardErrorCodes : uint
    {

        // *****************
        // FACILITY_SCARD
        // *****************
        //
        // =============================
        // Facility SCARD Error Messages
        // =============================
        //
        SCARD_S_SUCCESS = 0,
        //
        // MessageId: SCARD_F_INTERNAL_ERROR
        //
        // MessageText:
        //
        // An internal consistency check failed.
        //
        SCARD_F_INTERNAL_ERROR = (0x80100001),

        //
        // MessageId: SCARD_E_CANCELLED
        //
        // MessageText:
        //
        // The action was cancelled by an SCardCancel request.
        //
        SCARD_E_CANCELLED = (0x80100002),

        //
        // MessageId: SCARD_E_INVALID_HANDLE
        //
        // MessageText:
        //
        // The supplied handle was invalid.
        //
        SCARD_E_INVALID_HANDLE = (0x80100003),

        //
        // MessageId: SCARD_E_INVALID_PARAMETER
        //
        // MessageText:
        //
        // One or more of the supplied parameters could not be properly interpreted.
        //
        SCARD_E_INVALID_PARAMETER = (0x80100004),

        //
        // MessageId: SCARD_E_INVALID_TARGET
        //
        // MessageText:
        //
        // Registry startup information is missing or invalid.
        //
        SCARD_E_INVALID_TARGET = (0x80100005),

        //
        // MessageId: SCARD_E_NO_MEMORY
        //
        // MessageText:
        //
        // Not enough memory available to complete this command.
        //
        SCARD_E_NO_MEMORY = (0x80100006),

        //
        // MessageId: SCARD_F_WAITED_TOO_LONG
        //
        // MessageText:
        //
        // An internal consistency timer has expired.
        //
        SCARD_F_WAITED_TOO_LONG = (0x80100007),

        //
        // MessageId: SCARD_E_INSUFFICIENT_BUFFER
        //
        // MessageText:
        //
        // The data buffer to receive returned data is too small for the returned data.
        //
        SCARD_E_INSUFFICIENT_BUFFER = (0x80100008),

        //
        // MessageId: SCARD_E_UNKNOWN_READER
        //
        // MessageText:
        //
        // The specified reader name is not recognized.
        //
        SCARD_E_UNKNOWN_READER = (0x80100009),

        //
        // MessageId: SCARD_E_TIMEOUT
        //
        // MessageText:
        //
        // The user-specified timeout value has expired.
        //
        SCARD_E_TIMEOUT = (0x8010000A),

        //
        // MessageId: SCARD_E_SHARING_VIOLATION
        //
        // MessageText:
        //
        // The smart card cannot be accessed because of other connections outstanding.
        //
        SCARD_E_SHARING_VIOLATION = (0x8010000B),

        //
        // MessageId: SCARD_E_NO_SMARTCARD
        //
        // MessageText:
        //
        // The operation requires a Smart Card, but no Smart Card is currently in the device.
        //
        SCARD_E_NO_SMARTCARD = (0x8010000C),

        //
        // MessageId: SCARD_E_UNKNOWN_CARD
        //
        // MessageText:
        //
        // The specified smart card name is not recognized.
        //
        SCARD_E_UNKNOWN_CARD = (0x8010000D),

        //
        // MessageId: SCARD_E_CANT_DISPOSE
        //
        // MessageText:
        //
        // The system could not dispose of the media in the requested manner.
        //
        SCARD_E_CANT_DISPOSE = (0x8010000E),

        //
        // MessageId: SCARD_E_PROTO_MISMATCH
        //
        // MessageText:
        //
        // The requested protocols are incompatible with the protocol currently in use with the smart card.
        //
        SCARD_E_PROTO_MISMATCH = (0x8010000F),

        //
        // MessageId: SCARD_E_NOT_READY
        //
        // MessageText:
        //
        // The reader or smart card is not ready to accept commands.
        //
        SCARD_E_NOT_READY = (0x80100010),

        //
        // MessageId: SCARD_E_INVALID_VALUE
        //
        // MessageText:
        //
        // One or more of the supplied parameters values could not be properly interpreted.
        //
        SCARD_E_INVALID_VALUE = (0x80100011),

        //
        // MessageId: SCARD_E_SYSTEM_CANCELLED
        //
        // MessageText:
        //
        // The action was cancelled by the system, presumably to log off or shut down.
        //
        SCARD_E_SYSTEM_CANCELLED = (0x80100012),

        //
        // MessageId: SCARD_F_COMM_ERROR
        //
        // MessageText:
        //
        // An internal communications error has been detected.
        //
        SCARD_F_COMM_ERROR = (0x80100013),

        //
        // MessageId: SCARD_F_UNKNOWN_ERROR
        //
        // MessageText:
        //
        // An internal error has been detected, but the source is unknown.
        //
        SCARD_F_UNKNOWN_ERROR = (0x80100014),

        //
        // MessageId: SCARD_E_INVALID_ATR
        //
        // MessageText:
        //
        // An ATR obtained from the registry is not a valid ATR string.
        //
        SCARD_E_INVALID_ATR = (0x80100015),

        //
        // MessageId: SCARD_E_NOT_TRANSACTED
        //
        // MessageText:
        //
        // An attempt was made to end a non-existent transaction.
        //
        SCARD_E_NOT_TRANSACTED = (0x80100016),

        //
        // MessageId: SCARD_E_READER_UNAVAILABLE
        //
        // MessageText:
        //
        // The specified reader is not currently available for use.
        //
        SCARD_E_READER_UNAVAILABLE = (0x80100017),

        //
        // MessageId: SCARD_P_SHUTDOWN
        //
        // MessageText:
        //
        // The operation has been aborted to allow the server application to exit.
        //
        SCARD_P_SHUTDOWN = (0x80100018),

        //
        // MessageId: SCARD_E_PCI_TOO_SMALL
        //
        // MessageText:
        //
        // The PCI Receive buffer was too small.
        //
        SCARD_E_PCI_TOO_SMALL = (0x80100019),

        //
        // MessageId: SCARD_E_READER_UNSUPPORTED
        //
        // MessageText:
        //
        // The reader driver does not meet minimal requirements for support.
        //
        SCARD_E_READER_UNSUPPORTED = (0x8010001A),

        //
        // MessageId: SCARD_E_DUPLICATE_READER
        //
        // MessageText:
        //
        // The reader driver did not produce a unique reader name.
        //
        SCARD_E_DUPLICATE_READER = (0x8010001B),

        //
        // MessageId: SCARD_E_CARD_UNSUPPORTED
        //
        // MessageText:
        //
        // The smart card does not meet minimal requirements for support.
        //
        SCARD_E_CARD_UNSUPPORTED = (0x8010001C),

        //
        // MessageId: SCARD_E_NO_SERVICE
        //
        // MessageText:
        //
        // The Smart card resource manager is not running.
        //
        SCARD_E_NO_SERVICE = (0x8010001D),

        //
        // MessageId: SCARD_E_SERVICE_STOPPED
        //
        // MessageText:
        //
        // The Smart card resource manager has shut down.
        //
        SCARD_E_SERVICE_STOPPED = (0x8010001E),

        //
        // MessageId: SCARD_E_UNEXPECTED
        //
        // MessageText:
        //
        // An unexpected card error has occurred.
        //
        SCARD_E_UNEXPECTED = (0x8010001F),

        //
        // MessageId: SCARD_E_ICC_INSTALLATION
        //
        // MessageText:
        //
        // No Primary Provider can be found for the smart card.
        //
        SCARD_E_ICC_INSTALLATION = (0x80100020),

        //
        // MessageId: SCARD_E_ICC_CREATEORDER
        //
        // MessageText:
        //
        // The requested order of object creation is not supported.
        //
        SCARD_E_ICC_CREATEORDER = (0x80100021),

        //
        // MessageId: SCARD_E_UNSUPPORTED_FEATURE
        //
        // MessageText:
        //
        // This smart card does not support the requested feature.
        //
        SCARD_E_UNSUPPORTED_FEATURE = (0x80100022),

        //
        // MessageId: SCARD_E_DIR_NOT_FOUND
        //
        // MessageText:
        //
        // The identified directory does not exist in the smart card.
        //
        SCARD_E_DIR_NOT_FOUND = (0x80100023),

        //
        // MessageId: SCARD_E_FILE_NOT_FOUND
        //
        // MessageText:
        //
        // The identified file does not exist in the smart card.
        //
        SCARD_E_FILE_NOT_FOUND = (0x80100024),

        //
        // MessageId: SCARD_E_NO_DIR
        //
        // MessageText:
        //
        // The supplied path does not represent a smart card directory.
        //
        SCARD_E_NO_DIR = (0x80100025),

        //
        // MessageId: SCARD_E_NO_FILE
        //
        // MessageText:
        //
        // The supplied path does not represent a smart card file.
        //
        SCARD_E_NO_FILE = (0x80100026),

        //
        // MessageId: SCARD_E_NO_ACCESS
        //
        // MessageText:
        //
        // Access is denied to this file.
        //
        SCARD_E_NO_ACCESS = (0x80100027),

        //
        // MessageId: SCARD_E_WRITE_TOO_MANY
        //
        // MessageText:
        //
        // The smartcard does not have enough memory to store the information.
        //
        SCARD_E_WRITE_TOO_MANY = (0x80100028),

        //
        // MessageId: SCARD_E_BAD_SEEK
        //
        // MessageText:
        //
        // There was an error trying to set the smart card file object pointer.
        //
        SCARD_E_BAD_SEEK = (0x80100029),

        //
        // MessageId: SCARD_E_INVALID_CHV
        //
        // MessageText:
        //
        // The supplied PIN is incorrect.
        //
        SCARD_E_INVALID_CHV = (0x8010002A),

        //
        // MessageId: SCARD_E_UNKNOWN_RES_MNG
        //
        // MessageText:
        //
        // An unrecognized error code was returned from a layered component.
        //
        SCARD_E_UNKNOWN_RES_MNG = (0x8010002B),

        //
        // MessageId: SCARD_E_NO_SUCH_CERTIFICATE
        //
        // MessageText:
        //
        // The requested certificate does not exist.
        //
        SCARD_E_NO_SUCH_CERTIFICATE = (0x8010002C),

        //
        // MessageId: SCARD_E_CERTIFICATE_UNAVAILABLE
        //
        // MessageText:
        //
        // The requested certificate could not be obtained.
        //
        SCARD_E_CERTIFICATE_UNAVAILABLE = (0x8010002D),

        //
        // MessageId: SCARD_E_NO_READERS_AVAILABLE
        //
        // MessageText:
        //
        // Cannot find a smart card reader.
        //
        SCARD_E_NO_READERS_AVAILABLE = (0x8010002E),

        //
        // MessageId: SCARD_E_COMM_DATA_LOST
        //
        // MessageText:
        //
        // A communications error with the smart card has been detected. Retry the operation.
        //
        SCARD_E_COMM_DATA_LOST = (0x8010002F),

        //
        // MessageId: SCARD_E_NO_KEY_CONTAINER
        //
        // MessageText:
        //
        // The requested key container does not exist on the smart card.
        //
        SCARD_E_NO_KEY_CONTAINER = (0x80100030),

        //
        // MessageId: SCARD_E_SERVER_TOO_BUSY
        //
        // MessageText:
        //
        // The Smart card resource manager is too busy to complete this operation.
        //
        SCARD_E_SERVER_TOO_BUSY = (0x80100031),

        //
        // MessageId: SCARD_E_PIN_CACHE_EXPIRED
        //
        // MessageText:
        //
        // The smart card PIN cache has expired.
        //
        SCARD_E_PIN_CACHE_EXPIRED = (0x80100032),

        //
        // MessageId: SCARD_E_NO_PIN_CACHE
        //
        // MessageText:
        //
        // The smart card PIN cannot be cached.
        //
        SCARD_E_NO_PIN_CACHE = (0x80100033),

        //
        // MessageId: SCARD_E_READ_ONLY_CARD
        //
        // MessageText:
        //
        // The smart card is read only and cannot be written to.
        //
        SCARD_E_READ_ONLY_CARD = (0x80100034),

        //
        // These are warning codes.
        //
        //
        // MessageId: SCARD_W_UNSUPPORTED_CARD
        //
        // MessageText:
        //
        // The reader cannot communicate with the smart card, due to ATR configuration conflicts.
        //
        SCARD_W_UNSUPPORTED_CARD = (0x80100065),

        //
        // MessageId: SCARD_W_UNRESPONSIVE_CARD
        //
        // MessageText:
        //
        // The smart card is not responding to a reset.
        //
        SCARD_W_UNRESPONSIVE_CARD = (0x80100066),

        //
        // MessageId: SCARD_W_UNPOWERED_CARD
        //
        // MessageText:
        //
        // Power has been removed from the smart card, so that further communication is not possible.
        //
        SCARD_W_UNPOWERED_CARD = (0x80100067),

        //
        // MessageId: SCARD_W_RESET_CARD
        //
        // MessageText:
        //
        // The smart card has been reset, so any shared state information is invalid.
        //
        SCARD_W_RESET_CARD = (0x80100068),

        //
        // MessageId: SCARD_W_REMOVED_CARD
        //
        // MessageText:
        //
        // The smart card has been removed, so that further communication is not possible.
        //
        SCARD_W_REMOVED_CARD = (0x80100069),

        //
        // MessageId: SCARD_W_SECURITY_VIOLATION
        //
        // MessageText:
        //
        // Access was denied because of a security violation.
        //
        SCARD_W_SECURITY_VIOLATION = (0x8010006A),

        //
        // MessageId: SCARD_W_WRONG_CHV
        //
        // MessageText:
        //
        // The card cannot be accessed because the wrong PIN was presented.
        //
        SCARD_W_WRONG_CHV = (0x8010006B),

        //
        // MessageId: SCARD_W_CHV_BLOCKED
        //
        // MessageText:
        //
        // The card cannot be accessed because the maximum number of PIN entry attempts has been reached.
        //
        SCARD_W_CHV_BLOCKED = (0x8010006C),

        //
        // MessageId: SCARD_W_EOF
        //
        // MessageText:
        //
        // The end of the smart card file has been reached.
        //
        SCARD_W_EOF = (0x8010006D),

        //
        // MessageId: SCARD_W_CANCELLED_BY_USER
        //
        // MessageText:
        //
        // The action was cancelled by the user.
        //
        SCARD_W_CANCELLED_BY_USER = (0x8010006E),

        //
        // MessageId: SCARD_W_CARD_NOT_AUTHENTICATED
        //
        // MessageText:
        //
        // No PIN was presented to the smart card.
        //
        SCARD_W_CARD_NOT_AUTHENTICATED = (0x8010006F),

        //
        // MessageId: SCARD_W_CACHE_ITEM_NOT_FOUND
        //
        // MessageText:
        //
        // The requested item could not be found in the cache.
        //
        SCARD_W_CACHE_ITEM_NOT_FOUND = (0x80100070),

        //
        // MessageId: SCARD_W_CACHE_ITEM_STALE
        //
        // MessageText:
        //
        // The requested cache item is too old and was deleted from the cache.
        //
        SCARD_W_CACHE_ITEM_STALE = (0x80100071),

        //
        // MessageId: SCARD_W_CACHE_ITEM_TOO_BIG
        //
        // MessageText:
        //
        // The new cache item exceeds the maximum per-item size defined for the cache.
        //
        SCARD_W_CACHE_ITEM_TOO_BIG = (0x80100072),
    }


    /// <summary>
    /// State of the reader. This field can take on any of the following values, in combination, as a bitmask.
    /// </summary>
    /// <remarks>
    /// See winscard.h of the DDK.
    /// </remarks>
    [Flags]
    public enum SCStates
    {

        //#define SCARD_STATE_UNAWARE     0x00000000  // The application is unaware of the
        //                                            // current state, and would like to
        //                                            // know.  The use of this value
        //                                            // results in an immediate return
        //                                            // from state transition monitoring
        //                                            // services.  This is represented by
        //                                            // all bits set to zero.
        //#define SCARD_STATE_IGNORE      0x00000001  // The application requested that
        //                                            // this reader be ignored.  No other
        //                                            // bits will be set.
        //#define SCARD_STATE_UNKNOWN     0x00000004  // This implies that the given
        //                                            // reader name is not recognized by
        //                                            // the Service Manager.  If this bit
        //                                            // is set, then SCARD_STATE_CHANGED
        //                                            // and SCARD_STATE_IGNORE will also
        //                                            // be set.
        //#define SCARD_STATE_UNAVAILABLE 0x00000008  // This implies that the actual
        //                                            // state of this reader is not
        //                                            // available.  If this bit is set,
        //                                            // then all the following bits are
        //                                            // clear.
        //#define SCARD_STATE_EMPTY       0x00000010  // This implies that there is not
        //                                            // card in the reader.  If this bit
        //                                            // is set, all the following bits
        //                                            // will be clear.
        //#define SCARD_STATE_PRESENT     0x00000020  // This implies that there is a card
        //                                            // in the reader.
        //#define SCARD_STATE_EXCLUSIVE   0x00000080  // This implies that the card in the
        //                                            // reader is allocated for exclusive
        //                                            // use by another application.  If
        //                                            // this bit is set,
        //                                            // SCARD_STATE_PRESENT will also be
        //                                            // set.
        //#define SCARD_STATE_UNPOWERED   0x00000400  // This implies that the card in the
        //                                            // reader has not been powered up.
        /// <summary>
        /// (SCARD_STATE_UNAWARE = 0)
        /// </summary>
        /// <remarks>
        /// The application is unaware of the current state, and would like to know.  The use of this value
        /// results in an immediate return from state transition monitoring services.
        /// </remarks>
        Unaware = 0,


        /// <summary>
        /// (SCARD_STATE_IGNORE = 1)
        /// </summary>
        Ignore = 1,


        /// <summary>
        /// (SCARD_STATE_CHANGED=2) There is a difference between the state believed by the application, and the state known by the resource manager.
        /// </summary>
        /// <remarks>
        /// This implies that there is a difference between the state believed by the application, and
        /// the state known by the Service Manager.  When this bit is set, the application may assume a
        /// significant state change has occurred on this reader.
        /// </remarks>
        Changed = 2,

        /// <summary>
        /// 
        /// </summary>
        Unknown = 4,

        /// <summary>
        /// (SCARD_STATE_UNAVAILABLE=0x08)
        /// </summary>
        Unavailable = 8,


        /// <summary>
        /// (SCARD_STATE_EMPTY=0x10) There is no card in the reader.
        /// </summary>
        /// <remarks>
        /// If this bit is set, all the following bits will be clear.
        /// </remarks>
        Empty = 0x10,

        /// <summary>
        /// (SCARD_STATE_PRESENT=0x20)
        /// </summary>
        Present = 0x20,

        /// <summary>
        /// (SCARD_STATE_ATRMATCH=0x40) There is a card in the reader with an ATR matching one of the target cards.
        /// </summary>
        /// <remarks>
        /// This implies that there is a card in the reader with an ATR matching one of the target cards.  
        /// If this bit is set, SCARD_STATE_PRESENT will also be set.  This bit is only returned on the 
        /// SCardLocateCard() service.
        /// </remarks>
        AtrMatch = 0x40,

        /// <summary>
        /// (SCARD_STATE_EXCLUSIVE=0x80)
        /// </summary>
        Exclusive = 0x80,


        /// <summary>
        /// (SCARD_STATE_INUSE=0x100) The card in the reader is in use by one or more other applications, but may be connected to in shared mode.
        /// </summary>
        /// <remarks>
        /// This implies that the card in the reader is in use by one or more
        /// other applications, but may be connected to in shared mode.  If this bit is set,
        /// SCARD_STATE_PRESENT will also be set.
        /// </remarks>
        InUse = 0x100,

        /// <summary>
        /// (SCARD_STATE_MUTE=0x200) There is an unresponsive card in the reader.
        /// </summary>
        /// <remarks>
        /// This implies that the card in the reader is unresponsive or not supported by the reader or
        /// software.
        /// </remarks>
        Mute = 0x200,



        Unpowered = 0x400
    }


    /// <summary>
    /// State of the card inside the reader.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct SCStateInfo
    {
        /// <summary>
        /// Name of the reader.
        /// </summary>
        public string sReaderName;

        /// <summary>
        /// Current state of the reader, as seen by the application.
        /// </summary>
        public SCStates nCurrentState;

        /// <summary>
        /// Current state of the reader, as known by the smart card resource manager.
        /// </summary>
        public SCStates nEventState;

        /// <summary>
        /// ATR of the inserted card
        /// </summary>
        public byte[] vbATR;
    }


    /// <summary>
    /// 
    /// </summary>
    [Flags]
    public enum SCardMechanicalCharacteristics
    {
        Captures = 4,
        Ejects = 2,
        None = 0,
        Swallows = 1
    }

    public enum SCardDisposition
    {
        Confiscate = 4,
        EjectCard = 3,
        LeaveCard = 0,
        ResetCard = 1,
        UnpowerCard = 2
    }
    public enum SCardControlCodes
    {
        Absent = 0x31002c,
        Confiscate = 3211280,
        Eject = 0x310018,
        GetAttribute = 0x310008,
        GetLastError = 0x31003c,
        GetPerfCntr = 0x310040,
        Power = 0x310004,
        Present = 0x310028,
        Protocol = 0x310030,
        Read = 0x310020,
        SetAttribute = 0x31000c,
        State = 3211320,
        Swallow = 0x31001c,
        Transmit = 0x310014,
        Write = 3211300
    }

    public enum SCardChannelType
    {
        IDE = 0x10,
        Keyboard = 4,
        Parallel = 2,
        PCMCIA = 0x40,
        SCSI = 8,
        Serial = 1,
        Unknown = 0,
        USB = 0x20,
        Vendor = 240
    }

    [Flags]
    public enum SCardAuthDevices
    {
        Display = 0x80,
        EncryptedInput = 0x8000,
        Fingerprint = 8,
        Image = 0x20,
        Keyboard = 4,
        NoDevices = 0,
        Numeric = 2,
        ReservedFU = 1,
        Retinal = 0x10,
        Voice = 0x40
    }


    public enum SCLibExceptionCode
    {
        CardCommunicationError = 2,
        CardWithdrawn = 1,
        DriverError = 3,
        DriverException = 4,
        DriverIncompatible = 5,
        InvalidAPDU = 0
    }

}