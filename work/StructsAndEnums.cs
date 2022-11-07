namespace Epos2XamarinSDK_iOS
{
	public enum Epos2ErrorStatus
	{
		Success = 0,
		ErrParam,
		ErrConnect,
		ErrTimeout,
		ErrMemory,
		ErrIllegal,
		ErrProcessing,
		ErrNotFound,
		ErrInUse,
		ErrTypeInvalid,
		ErrDisconnect,
		ErrAlreadyOpened,
		ErrAlreadyUsed,
		ErrBoxCountOver,
		ErrBoxClientOver,
		ErrUnsupported,
		ErrDeviceBusy,
		ErrFailure = 255
	}

	public enum Epos2CallbackCode
	{
		Success = 0,
		ErrTimeout,
		ErrNotFound,
		ErrAutorecover,
		ErrCoverOpen,
		ErrCutter,
		ErrMechanical,
		ErrEmpty,
		ErrUnrecoverable,
		ErrSystem,
		ErrPort,
		ErrInvalidWindow,
		ErrJobNotFound,
		Printing,
		ErrSpooler,
		ErrBatteryLow,
		ErrTooManyRequests,
		ErrRequestEntityTooLarge,
		Canceled,
		ErrNoMicrData,
		ErrIllegalLength,
		ErrNoMagneticData,
		ErrRecognition,
		ErrRead,
		ErrNoiseDetected,
		ErrPaperJam,
		ErrPaperPulledOut,
		ErrCancelFailed,
		ErrPaperType,
		ErrWaitInsertion,
		ErrIllegal,
		ErrInserted,
		ErrWaitRemoval,
		ErrDeviceBusy,
		ErrGetJsonSize,
		ErrInUse,
		ErrConnect,
		ErrDisconnect,
		ErrDifferentModel,
		ErrDifferentVersion,
		ErrMemory,
		ErrProcessing,
		ErrDataCorrupted,
		ErrParam,
		Retry,
		ErrFailure = 255
	}

	public enum Epos2PrinterSeries
	{
		M10 = 0,
		M30,
		P20,
		P60,
		P60ii,
		P80,
		T20,
		T60,
		T70,
		T81,
		T82,
		T83,
		T88,
		T90,
		T90kp,
		U220,
		U330,
		L90,
		H6000,
		T83iii,
		T100,
		M30ii
	}

	public enum Epos2DisplayModel
	{
		DmD30 = 0,
		DmD110,
		DmD210
	}

	public enum Epos2ModelLang
	{
		Ank = 0,
		Japanese,
		Chinese,
		Taiwan,
		Korean,
		Thai,
		Southasia
	}

	public enum Epos2DeviceModel
	{
		ModelAll = 0
	}

	public enum Epos2PortType
	{
		All = 0,
		Tcp,
		Bluetooth,
		Usb
	}

	public enum Epos2StatusPaper
	{
		Ok = 0,
		NearEnd,
		Empty
	}

	public enum Epos2PanelSwitch
	{
		Off = 0,
		On
	}

	public enum Epos2StatusDrawer
	{
		High = 0,
		Low
	}

	public enum Epos2PrinterError
	{
		NoErr = 0,
		MechanicalErr,
		AutocutterErr,
		UnrecoverErr,
		AutorecoverErr
	}

	public enum Epos2AutoRecoverError
	{
		HeadOverheat = 0,
		MotorOverheat,
		BatteryOverheat,
		WrongPaper,
		CoverOpen
	}

	public enum Epos2BatteryLevel
	{
		Level0 = 0,
		Level1,
		Level2,
		Level3,
		Level4,
		Level5,
		Level6
	}

	public enum Epos2InsertionWaiting
	{
		Slip = 0,
		Validation,
		Micr,
		None
	}

	public enum Epos2RemovalWaiting
	{
		Paper = 0,
		None
	}

	public enum Epos2StatusSlipPaper
	{
		Ok = 0,
		Empty
	}

	public enum Epos2StatusEvent
	{
		Online = 0,
		Offline,
		PowerOff,
		CoverClose,
		CoverOpen,
		PaperOk,
		PaperNearEnd,
		PaperEmpty,
		DrawerHigh,
		DrawerLow,
		BatteryEnough,
		BatteryEmpty,
		InsertionWaitSlip,
		InsertionWaitValidation,
		InsertionWaitMicr,
		InsertionWaitNone,
		RemovalWaitPaper,
		RemovalWaitNone,
		SlipPaperOk,
		SlipPaperEmpty
	}

	public enum Epos2ConnectionEvent
	{
		Reconnecting = 0,
		Reconnect,
		Disconnect
	}

	public enum Epos2DeviceType
	{
		All = 0,
		Printer,
		HybridPrinter,
		Display,
		Keyboard,
		Scanner,
		Serial,
		Cchanger,
		PosKeyboard,
		Cat,
		Msr,
		OtherPeripheral,
		Gfe
	}

	public enum Epos2Align
	{
		Left = 0,
		Center,
		Right
	}

	public enum Epos2Lang
	{
		En = 0,
		Ja,
		ZhCn,
		ZhTw,
		Ko,
		Th,
		Vi,
		Multi
	}

	public enum Epos2Font
	{
		A = 0,
		B,
		C,
		D,
		E
	}

	public enum Epos2Color
	{
		None = 0,
		Color1,
		Color2,
		Color3,
		Color4
	}

	public enum Epos2Mode
	{
		Mono = 0,
		Gray16,
		MonoHighDensity
	}

	public enum Epos2Halftone
	{
		Dither = 0,
		ErrorDiffusion,
		Threshold
	}

	public enum Epos2Compress
	{
		Deflate = 0,
		None,
		Auto
	}

	public enum Epos2Barcode
	{
		UpcA = 0,
		UpcE,
		Ean13,
		Jan13,
		Ean8,
		Jan8,
		Code39,
		Itf,
		Codabar,
		Code93,
		Code128,
		Gs1128,
		Gs1DatabarOmnidirectional,
		Gs1DatabarTruncated,
		Gs1DatabarLimited,
		Gs1DatabarExpanded
	}

	public enum Epos2Hri
	{
		None = 0,
		Above,
		Below,
		Both
	}

	public enum Epos2Symbol
	{
		Pdf417Standard = 0,
		Pdf417Truncated,
		QrcodeModel1,
		QrcodeModel2,
		QrcodeMicro,
		MaxicodeMode2,
		MaxicodeMode3,
		MaxicodeMode4,
		MaxicodeMode5,
		MaxicodeMode6,
		Gs1DatabarStacked,
		Gs1DatabarStackedOmnidirectional,
		Gs1DatabarExpandedStacked,
		AzteccodeFullrange,
		AzteccodeCompact,
		DatamatrixSquare,
		DatamatrixRectangle8,
		DatamatrixRectangle12,
		DatamatrixRectangle16
	}

	public enum Epos2Level
	{
		Level0 = 0,
		Level1,
		Level2,
		Level3,
		Level4,
		Level5,
		Level6,
		Level7,
		Level8,
		L,
		M,
		Q,
		H
	}

	public enum Epos2Line
	{
		Thin = 0,
		Medium,
		Thick,
		ThinDouble,
		MediumDouble,
		ThickDouble
	}

	public enum Epos2Direction
	{
		LeftToRight = 0,
		BottomToTop,
		RightToLeft,
		TopToBottom
	}

	public enum Epos2Cut
	{
		Feed = 0,
		NoFeed,
		Reserve
	}

	public enum Epos2Drawer
	{
		Drawer2pin = 0,
		Drawer5pin
	}

	public enum Epos2Pulse
	{
		Pulse100 = 0,
		Pulse200,
		Pulse300,
		Pulse400,
		Pulse500
	}

	public enum Epos2Pattern
	{
		None = 0,
		A,
		B,
		C,
		D,
		E,
		Error,
		PaperEmpty,
		Pattern1,
		Pattern2,
		Pattern3,
		Pattern4,
		Pattern5,
		Pattern6,
		Pattern7,
		Pattern8,
		Pattern9,
		Pattern10
	}

	public enum Epos2FeedPosition
	{
		Peeling = 0,
		Cutting,
		CurrentTof,
		NextTof
	}

	public enum Epos2Layout
	{
		Receipt = 0,
		ReceiptBm,
		Label,
		LabelBm
	}

	public enum Epos2Papertype
	{
		Receipt = 0,
		Slip,
		Endorse,
		Validation
	}

	public enum Epos2MicrFont
	{
		E13b = 0,
		Cmc7
	}

	public enum Epos2HybridPrinterMethod
	{
		Waitinsertion = 0,
		Senddata,
		Cancelinsertion,
		Ejectpaper,
		Readmicrdata,
		Cleanmicrreader
	}

	public enum Epos2Scroll
	{
		Overwrite = 0,
		Vertical,
		Horizontal
	}

	public enum Epos2Format
	{
		Walk = 0,
		Place
	}

	public enum Epos2Brightness
	{
		Brightness20 = 0,
		Brightness40,
		Brightness60,
		Brightness100
	}

	public enum Epos2CursorPosition
	{
		TopLeft = 0,
		TopRight,
		BottomLeft,
		BottomRight
	}

	public enum Epos2CursorType
	{
		None = 0,
		Underline
	}

	public enum Epos2CountMode
	{
		ManualInput = 0,
		AutoCount
	}

	public enum Epos2Deposit
	{
		Change = 0,
		Nochange,
		Repay
	}

	public enum Epos2Collect
	{
		AllCash = 0,
		PartOfCash
	}

	public enum Epos2CChangerStatus
	{
		Busy = 0,
		Pause,
		End,
		Err
	}

	public enum Epos2CashStatus
	{
		Empty = 0,
		NearEmpty,
		Ok,
		NearFull,
		Full
	}

	public enum Epos2CChangerCallbackCode
	{
		Success = 0,
		Busy,
		Discrepancy,
		ErrCashInTray,
		ErrShortage,
		ErrRejectUnit,
		ErrOposcode,
		ErrUnsupported,
		ErrParam,
		ErrCommand,
		ErrDevice,
		ErrSystem,
		ErrFailure
	}

	public enum Epos2CChangerStatusUpdateEvent
	{
		PowerOnline = 2001,
		PowerOff = 2002,
		PowerOffline = 2003,
		PowerOffOffline = 2004,
		StatusEmpty = 11,
		StatusNearempty = 12,
		StatusEmptyok = 13,
		StatusFull = 21,
		StatusNearfull = 22,
		StatusFullok = 23,
		StatusJam = 31,
		StatusJamok = 32
	}

	public enum Epos2CATCallbackCode
	{
		Success = 0,
		Busy,
		ExceedingLimit,
		Disagreement,
		InvalidCard,
		Reset,
		ErrCenter,
		ErrOposcode,
		ErrParam,
		ErrDevice,
		ErrSystem,
		ErrTimeout,
		ErrFailure
	}

	public enum Epos2CATService
	{
		Credit = 0,
		Debit,
		Unionpay,
		Edy,
		Id,
		Nanaco,
		Quicpay,
		Suica,
		Waon,
		Point,
		Common
	}

	public enum Epos2CATPaymentCondition
	{
		LumpSum = 0,
		Bonus1,
		Bonus2,
		Bonus3,
		Installment1,
		Installment2,
		Revolving,
		Combination1,
		Combination2,
		Debit,
		ElectronicMoney,
		Other
	}

	public enum Epos2CATStatusUpdateEvent
	{
		PowerOnline = 2001,
		PowerOffOffline = 2004,
		LogstatusOk = 0,
		LogstatusNearfull = 1,
		LogstatusFull = 2
	}

	public enum Epos2LogPeriod
	{
		Temporary = 0,
		Permanent
	}

	public enum Epos2LogOutput
	{
		Disable = 0,
		Storage,
		Tcp
	}

	public enum Epos2LogLevel
	{
		LoglevelLow = 0
	}

	public enum Epos2MaintenanceCounterType
	{
		Paperfeed = 0,
		Autocutter
	}

	public enum Epos2PrinterSettingType
	{
		Paperwidth = 0,
		Printdensity,
		Printspeed
	}

	public enum Epos2PrinterSettingPaperWidth
	{
		Paperwidth580 = 2,
		Paperwidth600 = 3,
		Paperwidth800 = 6
	}

	public enum Epos2PrinterSettingPrintDensity
	{
		Dip = 100,
		Printdensity70 = 65530,
		Printdensity75 = 65531,
		Printdensity80 = 65532,
		Printdensity85 = 65533,
		Printdensity90 = 65534,
		Printdensity95 = 65535,
		Printdensity100 = 0,
		Printdensity105 = 1,
		Printdensity110 = 2,
		Printdensity115 = 3,
		Printdensity120 = 4,
		Printdensity125 = 5,
		Printdensity130 = 6
	}

	public enum Epos2PrinterSettingPrintSpeed
	{
		Printspeed1 = 1,
		Printspeed2 = 2,
		Printspeed3 = 3,
		Printspeed4 = 4,
		Printspeed5 = 5,
		Printspeed6 = 6,
		Printspeed7 = 7,
		Printspeed8 = 8,
		Printspeed9 = 9,
		Printspeed10 = 10,
		Printspeed11 = 11,
		Printspeed12 = 12,
		Printspeed13 = 13,
		Printspeed14 = 14
	}

	public enum Epos2BtConnection
	{
		Success = 0,
		ErrParam,
		ErrUnsupported,
		ErrCancel,
		ErrAlreadyConnect,
		ErrIllegalDevice,
		ErrFailure = 255
	}
}
