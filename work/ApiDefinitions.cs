using System;
using Foundation;
using UIKit;

namespace Epos2XamarinSDK_iOS
{
	// @protocol Epos2ConnectionDelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]
	interface Epos2ConnectionDelegate
	{
		// @required -(void)onConnection:(id)deviceObj eventType:(int)eventType;
		[Abstract]
		[Export ("onConnection:eventType:")]
		void OnConnection (NSObject deviceObj, int eventType);
	}

	// @protocol Epos2PtrStatusChangeDelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]
	interface Epos2PtrStatusChangeDelegate
	{
		// @required -(void)onPtrStatusChange:(Epos2Printer *)printerObj eventType:(int)eventType;
		[Abstract]
		[Export ("onPtrStatusChange:eventType:")]
		void OnPtrStatusChange (Epos2Printer printerObj, int eventType);
	}

	// @protocol Epos2PtrReceiveDelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]
	interface Epos2PtrReceiveDelegate
	{
		// @required -(void)onPtrReceive:(Epos2Printer *)printerObj code:(int)code status:(Epos2PrinterStatusInfo *)status printJobId:(NSString *)printJobId;
		[Abstract]
		[Export ("onPtrReceive:code:status:printJobId:")]
		void OnPtrReceive (Epos2Printer printerObj, int code, Epos2PrinterStatusInfo status, string printJobId);
	}

	// @protocol Epos2HybdStatusChangeDelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]
	interface Epos2HybdStatusChangeDelegate
	{
		// @required -(void)onHybdStatusChange:(Epos2HybridPrinter *)hybridPrinterObj eventType:(int)eventType;
		[Abstract]
		[Export ("onHybdStatusChange:eventType:")]
		void OnHybdStatusChange (Epos2HybridPrinter hybridPrinterObj, int eventType);
	}

	// @protocol Epos2HybdReceiveDelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]
	interface Epos2HybdReceiveDelegate
	{
		// @required -(void)onHybdReceive:(Epos2HybridPrinter *)hybridPrinterObj method:(int)method code:(int)code micrData:(NSString *)micrData status:(Epos2HybridPrinterStatusInfo *)status;
		[Abstract]
		[Export ("onHybdReceive:method:code:micrData:status:")]
		void OnHybdReceive (Epos2HybridPrinter hybridPrinterObj, int method, int code, string micrData, Epos2HybridPrinterStatusInfo status);
	}

	// @protocol Epos2DispReceiveDelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]
	interface Epos2DispReceiveDelegate
	{
		// @required -(void)onDispReceive:(Epos2LineDisplay *)displayObj code:(int)code;
		[Abstract]
		[Export ("onDispReceive:code:")]
		void OnDispReceive (Epos2LineDisplay displayObj, int code);
	}

	// @protocol Epos2KbdKeyPressDelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]
	interface Epos2KbdKeyPressDelegate
	{
		// @required -(void)onKbdKeyPress:(Epos2Keyboard *)keyboardObj keyCode:(int)keyCode ascii:(NSString *)ascii;
		[Abstract]
		[Export ("onKbdKeyPress:keyCode:ascii:")]
		void OnKbdKeyPress (Epos2Keyboard keyboardObj, int keyCode, string ascii);
	}

	// @protocol Epos2KbdReadStringDelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]
	interface Epos2KbdReadStringDelegate
	{
		// @required -(void)onKbdReadString:(Epos2Keyboard *)keyboardObj readString:(NSString *)readString prefix:(int)prefix;
		[Abstract]
		[Export ("onKbdReadString:readString:prefix:")]
		void OnKbdReadString (Epos2Keyboard keyboardObj, string readString, int prefix);
	}

	// @protocol Epos2ScanDelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]
	interface Epos2ScanDelegate
	{
		// @required -(void)onScanData:(Epos2BarcodeScanner *)scannerObj scanData:(NSString *)scanData;
		[Abstract]
		[Export ("onScanData:scanData:")]
		void OnScanData (Epos2BarcodeScanner scannerObj, string scanData);
	}

	// @protocol Epos2SimpleSerialReceiveDelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]
	interface Epos2SimpleSerialReceiveDelegate
	{
		// @required -(void)onSimpleSerialReceive:(Epos2SimpleSerial *)serialObj data:(NSData *)data;
		[Abstract]
		[Export ("onSimpleSerialReceive:data:")]
		void OnSimpleSerialReceive (Epos2SimpleSerial serialObj, NSData data);
	}

	// @protocol Epos2GetCommHistoryDelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]
	interface Epos2GetCommHistoryDelegate
	{
		// @required -(void)onGetCommHistory:(Epos2CommBox *)commBoxObj code:(int)code historyList:(NSArray *)historyList;
		[Abstract]
		[Export ("onGetCommHistory:code:historyList:")]
		// [Verify (StronglyTypedNSArray)]
		void OnGetCommHistory (Epos2CommBox commBoxObj, int code, NSObject[] historyList);
	}

	// @protocol Epos2CommBoxSendMessageDelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]
	interface Epos2CommBoxSendMessageDelegate
	{
		// @required -(void)onCommBoxSendMessage:(Epos2CommBox *)commBoxObj code:(int)code count:(long)count;
		[Abstract]
		[Export ("onCommBoxSendMessage:code:count:")]
		void OnCommBoxSendMessage (Epos2CommBox commBoxObj, int code, nint count);
	}

	// @protocol Epos2CommBoxReceiveDelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]
	interface Epos2CommBoxReceiveDelegate
	{
		// @required -(void)onCommBoxReceive:(Epos2CommBox *)commBoxObj senderId:(NSString *)senderId receiverId:(NSString *)receiverId message:(NSString *)message;
		[Abstract]
		[Export ("onCommBoxReceive:senderId:receiverId:message:")]
		void OnCommBoxReceive (Epos2CommBox commBoxObj, string senderId, string receiverId, string message);
	}

	// @protocol Epos2POSKbdKeyPressDelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]
	interface Epos2POSKbdKeyPressDelegate
	{
		// @required -(void)onPOSKbdKeyPress:(Epos2POSKeyboard *)poskeyboardObj posKeyCode:(int)posKeyCode;
		[Abstract]
		[Export ("onPOSKbdKeyPress:posKeyCode:")]
		void OnPOSKbdKeyPress (Epos2POSKeyboard poskeyboardObj, int posKeyCode);
	}

	// @protocol Epos2CChangerConfigChangeDelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]
	interface Epos2CChangerConfigChangeDelegate
	{
		// @required -(void)onCChangerConfigChange:(Epos2CashChanger *)cchangerObj code:(int)code;
		[Abstract]
		[Export ("onCChangerConfigChange:code:")]
		void OnCChangerConfigChange (Epos2CashChanger cchangerObj, int code);
	}

	// @protocol Epos2CChangerCashCountDelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]
	interface Epos2CChangerCashCountDelegate
	{
		// @required -(void)onCChangerCashCount:(Epos2CashChanger *)cchangerObj code:(int)code data:(NSDictionary *)data;
		[Abstract]
		[Export ("onCChangerCashCount:code:data:")]
		void OnCChangerCashCount (Epos2CashChanger cchangerObj, int code, NSDictionary data);
	}

	// @protocol Epos2CChangerDepositDelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]
	interface Epos2CChangerDepositDelegate
	{
		// @required -(void)onCChangerDeposit:(Epos2CashChanger *)cchangerObj code:(int)code status:(int)status amount:(long)amount data:(NSDictionary *)data;
		[Abstract]
		[Export ("onCChangerDeposit:code:status:amount:data:")]
		void OnCChangerDeposit (Epos2CashChanger cchangerObj, int code, int status, nint amount, NSDictionary data);
	}

	// @protocol Epos2CChangerDispenseDelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]
	interface Epos2CChangerDispenseDelegate
	{
		// @required -(void)onCChangerDispense:(Epos2CashChanger *)cchangerObj code:(int)code;
		[Abstract]
		[Export ("onCChangerDispense:code:")]
		void OnCChangerDispense (Epos2CashChanger cchangerObj, int code);
	}

	// @protocol Epos2CChangerCollectDelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]
	interface Epos2CChangerCollectDelegate
	{
		// @required -(void)onCChangerCollect:(Epos2CashChanger *)cchangerObj code:(int)code;
		[Abstract]
		[Export ("onCChangerCollect:code:")]
		void OnCChangerCollect (Epos2CashChanger cchangerObj, int code);
	}

	// @protocol Epos2CChangerCommandReplyDelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]
	interface Epos2CChangerCommandReplyDelegate
	{
		// @required -(void)onCChangerCommandReply:(Epos2CashChanger *)cchangerObj code:(int)code data:(NSData *)data;
		[Abstract]
		[Export ("onCChangerCommandReply:code:data:")]
		void OnCChangerCommandReply (Epos2CashChanger cchangerObj, int code, NSData data);
	}

	// @protocol Epos2CChangerDirectIOCommandReplyDelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]
	interface Epos2CChangerDirectIOCommandReplyDelegate
	{
		// @required -(void)onCChangerDirectIOCommandReply:(Epos2CashChanger *)cchangerObj code:(int)code command:(long)command data:(long)data string:(NSString *)string;
		[Abstract]
		[Export ("onCChangerDirectIOCommandReply:code:command:data:string:")]
		void OnCChangerDirectIOCommandReply (Epos2CashChanger cchangerObj, int code, nint command, nint data, string @string);
	}

	// @protocol Epos2CChangerStatusChangeDelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]
	interface Epos2CChangerStatusChangeDelegate
	{
		// @required -(void)onCChangerStatusChange:(Epos2CashChanger *)cchangerObj code:(int)code status:(NSDictionary *)status;
		[Abstract]
		[Export ("onCChangerStatusChange:code:status:")]
		void OnCChangerStatusChange (Epos2CashChanger cchangerObj, int code, NSDictionary status);
	}

	// @protocol Epos2CChangerDirectIODelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]
	interface Epos2CChangerDirectIODelegate
	{
		// @required -(void)onCChangerDirectIO:(Epos2CashChanger *)cchangerObj eventnumber:(long)eventnumber data:(long)data string:(NSString *)string;
		[Abstract]
		[Export ("onCChangerDirectIO:eventnumber:data:string:")]
		void OnCChangerDirectIO (Epos2CashChanger cchangerObj, nint eventnumber, nint data, string @string);
	}

	// @protocol Epos2CChangerStatusUpdateDelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]
	interface Epos2CChangerStatusUpdateDelegate
	{
		// @required -(void)onCChangerStatusUpdate:(Epos2CashChanger *)cchangerObj status:(long)status;
		[Abstract]
		[Export ("onCChangerStatusUpdate:status:")]
		void OnCChangerStatusUpdate (Epos2CashChanger cchangerObj, nint status);
	}

	// @protocol Epos2CATAuthorizeSalesDelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]
	interface Epos2CATAuthorizeSalesDelegate
	{
		// @required -(void)onCATAuthorizeSales:(Epos2CAT *)catObj code:(int)code sequence:(long)sequence service:(int)service result:(Epos2CATAuthorizeResult *)result;
		[Abstract]
		[Export ("onCATAuthorizeSales:code:sequence:service:result:")]
		void OnCATAuthorizeSales (Epos2CAT catObj, int code, nint sequence, int service, Epos2CATAuthorizeResult result);
	}

	// @protocol Epos2CATAuthorizeVoidDelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]
	interface Epos2CATAuthorizeVoidDelegate
	{
		// @required -(void)onCATAuthorizeVoid:(Epos2CAT *)catObj code:(int)code sequence:(long)sequence service:(int)service result:(Epos2CATAuthorizeResult *)result;
		[Abstract]
		[Export ("onCATAuthorizeVoid:code:sequence:service:result:")]
		void OnCATAuthorizeVoid (Epos2CAT catObj, int code, nint sequence, int service, Epos2CATAuthorizeResult result);
	}

	// @protocol Epos2CATAuthorizeRefundDelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]
	interface Epos2CATAuthorizeRefundDelegate
	{
		// @required -(void)onCATAuthorizeRefund:(Epos2CAT *)catObj code:(int)code sequence:(long)sequence service:(int)service result:(Epos2CATAuthorizeResult *)result;
		[Abstract]
		[Export ("onCATAuthorizeRefund:code:sequence:service:result:")]
		void OnCATAuthorizeRefund (Epos2CAT catObj, int code, nint sequence, int service, Epos2CATAuthorizeResult result);
	}

	// @protocol Epos2CATAuthorizeCompletionDelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]
	interface Epos2CATAuthorizeCompletionDelegate
	{
		// @required -(void)onCATAuthorizeCompletion:(Epos2CAT *)catObj code:(int)code sequence:(long)sequence service:(int)service result:(Epos2CATAuthorizeResult *)result;
		[Abstract]
		[Export ("onCATAuthorizeCompletion:code:sequence:service:result:")]
		void OnCATAuthorizeCompletion (Epos2CAT catObj, int code, nint sequence, int service, Epos2CATAuthorizeResult result);
	}

	// @protocol Epos2CATAccessDailyLogDelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]
	interface Epos2CATAccessDailyLogDelegate
	{
		// @required -(void)onCATAccessDailyLog:(Epos2CAT *)catObj code:(int)code sequence:(long)sequence service:(int)service dailyLog:(NSArray *)dailyLog;
		[Abstract]
		[Export ("onCATAccessDailyLog:code:sequence:service:dailyLog:")]
		// [Verify (StronglyTypedNSArray)]
		void OnCATAccessDailyLog (Epos2CAT catObj, int code, nint sequence, int service, NSObject[] dailyLog);
	}

	// @protocol Epos2CATDirectIOCommandReplyDelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]
	interface Epos2CATDirectIOCommandReplyDelegate
	{
		// @required -(void)onCATDirectIOCommandReply:(Epos2CAT *)catObj code:(int)code command:(long)command data:(long)data string:(NSString *)string sequence:(long)sequence service:(int)service result:(Epos2CATDirectIOResult *)result;
		[Abstract]
		[Export ("onCATDirectIOCommandReply:code:command:data:string:sequence:service:result:")]
		void OnCATDirectIOCommandReply (Epos2CAT catObj, int code, nint command, nint data, string @string, nint sequence, int service, Epos2CATDirectIOResult result);
	}

	// @protocol Epos2CATStatusUpdateDelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]
	interface Epos2CATStatusUpdateDelegate
	{
		// @required -(void)onCATStatusUpdate:(Epos2CAT *)catObj status:(long)status;
		[Abstract]
		[Export ("onCATStatusUpdate:status:")]
		void OnCATStatusUpdate (Epos2CAT catObj, nint status);
	}

	// @protocol Epos2MSRDataDelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]
	interface Epos2MSRDataDelegate
	{
		// @required -(void)onMSRData:(Epos2MSR *)msrObj data:(Epos2MSRData *)data;
		[Abstract]
		[Export ("onMSRData:data:")]
		void OnMSRData (Epos2MSR msrObj, Epos2MSRData data);
	}

	// @protocol Epos2OtherReceiveDelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]
	interface Epos2OtherReceiveDelegate
	{
		// @required -(void)onOtherReceive:(Epos2OtherPeripheral *)otherObj eventName:(NSString *)eventName data:(NSString *)data;
		[Abstract]
		[Export ("onOtherReceive:eventName:data:")]
		void OnOtherReceive (Epos2OtherPeripheral otherObj, string eventName, string data);
	}

	// @protocol Epos2GermanyFiscalElementReceiveDelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]
	interface Epos2GermanyFiscalElementReceiveDelegate
	{
		// @required -(void)onGfeReceive:(Epos2GermanyFiscalElement *)germanyFiscalObj code:(int)code data:(NSString *)data;
		[Abstract]
		[Export ("onGfeReceive:code:data:")]
		void OnGfeReceive (Epos2GermanyFiscalElement germanyFiscalObj, int code, string data);
	}

	// @protocol Epos2DiscoveryDelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]
	interface Epos2DiscoveryDelegate
	{
		// @required -(void)onDiscovery:(Epos2DeviceInfo *)deviceInfo;
		[Abstract]
		[Export ("onDiscovery:")]
		void OnDiscovery(Epos2DeviceInfo deviceInfo);
	}

	// @protocol Epos2FirmwareListDownloadDelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]
	interface Epos2FirmwareListDownloadDelegate
	{
		// @required -(void)onFirmwareListDownload:(int)code firmwareList:(NSMutableArray<Epos2FirmwareInfo *> *)firmwareList;
		[Abstract]
		[Export ("onFirmwareListDownload:firmwareList:")]
		void OnFirmwareListDownload (int code, NSMutableArray<NSObject> firmwareList);
	}

	// @protocol Epos2FirmwareInformationDelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]
	interface Epos2FirmwareInformationDelegate
	{
		// @required -(void)onFirmwareInformationReceive:(int)code firmwareInfo:(Epos2FirmwareInfo *)firmwareInfo;
		[Abstract]
		[Export ("onFirmwareInformationReceive:firmwareInfo:")]
		void OnFirmwareInformationReceive (int code, Epos2FirmwareInfo firmwareInfo);
	}

	// @protocol Epos2FirmwareUpdateDelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]
	interface Epos2FirmwareUpdateDelegate
	{
		// @required -(void)onFirmwareUpdateProgress:(NSString *)task progress:(float)progress;
		[Abstract]
		[Export ("onFirmwareUpdateProgress:progress:")]
		void OnFirmwareUpdateProgress (string task, float progress);

		// @required -(void)onFirmwareUpdate:(int)code maxWaitTime:(int)maxWaitTime;
		[Abstract]
		[Export ("onFirmwareUpdate:maxWaitTime:")]
		void OnFirmwareUpdate (int code, int maxWaitTime);
	}

	// @protocol Epos2VerifyeUpdateDelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]
	interface Epos2VerifyeUpdateDelegate
	{
		// @required -(void)onUpdateVerify:(int)code;
		[Abstract]
		[Export ("onUpdateVerify:")]
		void OnUpdateVerify (int code);
	}

	// @protocol Epos2MaintenanceCounterDelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]
	interface Epos2MaintenanceCounterDelegate
	{
		// @required -(void)onGetMaintenanceCounter:(int)code type:(int)type value:(int)value;
		[Abstract]
		[Export ("onGetMaintenanceCounter:type:value:")]
		void OnGetMaintenanceCounter (int code, int type, int value);

		// @required -(void)onResetMaintenanceCounter:(int)code type:(int)type;
		[Abstract]
		[Export ("onResetMaintenanceCounter:type:")]
		void OnResetMaintenanceCounter (int code, int type);
	}

	// @protocol Epos2PrinterSettingDelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]
	interface Epos2PrinterSettingDelegate
	{
		// @required -(void)onGetPrinterSetting:(int)code type:(int)type value:(int)value;
		[Abstract]
		[Export ("onGetPrinterSetting:type:value:")]
		void OnGetPrinterSetting (int code, int type, int value);

		// @required -(void)onSetPrinterSetting:(int)code;
		[Abstract]
		[Export ("onSetPrinterSetting:")]
		void OnSetPrinterSetting (int code);
	}

	// @interface Epos2CommonPrinter : NSObject
	[BaseType (typeof(NSObject))]
	interface Epos2CommonPrinter
	{
		// -(int)startMonitor;
		[Export ("startMonitor")]
		int StartMonitor();

		// -(int)stopMonitor;
		[Export ("stopMonitor")]
		int StopMonitor();

		// -(int)beginTransaction;
		[Export ("beginTransaction")]
		int BeginTransaction();

		// -(int)endTransaction;
		[Export ("endTransaction")]
		int EndTransaction();

		// -(int)clearCommandBuffer;
		[Export ("clearCommandBuffer")]
		int ClearCommandBuffer();

		// -(int)addTextAlign:(int)align;
		[Export ("addTextAlign:")]
		int AddTextAlign (int align);

		// -(int)addLineSpace:(long)linespc;
		[Export ("addLineSpace:")]
		int AddLineSpace (nint linespc);

		// -(int)addTextRotate:(int)rotate;
		[Export ("addTextRotate:")]
		int AddTextRotate (int rotate);

		// -(int)addText:(NSString *)data;
		[Export ("addText:")]
		int AddText (string data);

		// -(int)addTextLang:(int)lang;
		[Export ("addTextLang:")]
		int AddTextLang (int lang);

		// -(int)addTextFont:(int)font;
		[Export ("addTextFont:")]
		int AddTextFont (int font);

		// -(int)addTextSmooth:(int)smooth;
		[Export ("addTextSmooth:")]
		int AddTextSmooth (int smooth);

		// -(int)addTextSize:(long)width height:(long)height;
		[Export ("addTextSize:height:")]
		int AddTextSize (nint width, nint height);

		// -(int)addTextStyle:(int)reverse ul:(int)ul em:(int)em color:(int)color;
		[Export ("addTextStyle:ul:em:color:")]
		int AddTextStyle (int reverse, int ul, int em, int color);

		// -(int)addHPosition:(long)x;
		[Export ("addHPosition:")]
		int AddHPosition (nint x);

		// -(int)addFeedUnit:(long)unit;
		[Export ("addFeedUnit:")]
		int AddFeedUnit (nint unit);

		// -(int)addFeedLine:(long)line;
		[Export ("addFeedLine:")]
		int AddFeedLine (nint line);

		// -(int)addImage:(UIImage *)data x:(long)x y:(long)y width:(long)width height:(long)height color:(int)color mode:(int)mode halftone:(int)halftone brightness:(double)brightness compress:(int)compress;
		[Export ("addImage:x:y:width:height:color:mode:halftone:brightness:compress:")]
		int AddImage (UIImage data, nint x, nint y, nint width, nint height, int color, int mode, int halftone, double brightness, int compress);

		// -(int)addLogo:(long)key1 key2:(long)key2;
		[Export ("addLogo:key2:")]
		int AddLogo (nint key1, nint key2);

		// -(int)addBarcode:(NSString *)data type:(int)type hri:(int)hri font:(int)font width:(long)width height:(long)height;
		[Export ("addBarcode:type:hri:font:width:height:")]
		int AddBarcode (string data, int type, int hri, int font, nint width, nint height);

		// -(int)addSymbol:(NSString *)data type:(int)type level:(int)level width:(long)width height:(long)height size:(long)size;
		[Export ("addSymbol:type:level:width:height:size:")]
		int AddSymbol (string data, int type, int level, nint width, nint height, nint size);

		// -(int)addPageBegin;
		[Export ("addPageBegin")]
		int AddPageBegin();

		// -(int)addPageEnd;
		[Export ("addPageEnd")]
		int AddPageEnd();

		// -(int)addPageArea:(long)x y:(long)y width:(long)width height:(long)height;
		[Export ("addPageArea:y:width:height:")]
		int AddPageArea (nint x, nint y, nint width, nint height);

		// -(int)addPageDirection:(int)direction;
		[Export ("addPageDirection:")]
		int AddPageDirection (int direction);

		// -(int)addPagePosition:(long)x y:(long)y;
		[Export ("addPagePosition:y:")]
		int AddPagePosition (nint x, nint y);

		// -(int)addPageLine:(long)x1 y1:(long)y1 x2:(long)x2 y2:(long)y2 style:(int)style;
		[Export ("addPageLine:y1:x2:y2:style:")]
		int AddPageLine (nint x1, nint y1, nint x2, nint y2, int style);

		// -(int)addPageRectangle:(long)x1 y1:(long)y1 x2:(long)x2 y2:(long)y2 style:(int)style;
		[Export ("addPageRectangle:y1:x2:y2:style:")]
		int AddPageRectangle (nint x1, nint y1, nint x2, nint y2, int style);

		// -(int)addCut:(int)type;
		[Export ("addCut:")]
		int AddCut (int type);

		// -(int)addPulse:(int)drawer time:(int)time;
		[Export ("addPulse:time:")]
		int AddPulse (int drawer, int time);

		// -(int)addCommand:(NSData *)data;
		[Export ("addCommand:")]
		int AddCommand (NSData data);

		// -(int)forceRecover:(long)timeout;
		[Export ("forceRecover:")]
		int ForceRecover (nint timeout);

		// -(int)forcePulse:(int)drawer pulseTime:(int)time timeout:(long)timeout;
		[Export ("forcePulse:pulseTime:timeout:")]
		int ForcePulse (int drawer, int time, nint timeout);

		// -(int)forceReset:(long)timeout;
		[Export ("forceReset:")]
		int ForceReset (nint timeout);
	}

	// @interface Epos2PrinterStatusInfo : NSObject
	[BaseType (typeof(NSObject))]
	interface Epos2PrinterStatusInfo
	{
		// @property (readonly, getter = getConnection) int connection;
		[Export ("connection")]
		int Connection { [Bind ("getConnection")] get; }

		// @property (readonly, getter = getOnline) int online;
		[Export ("online")]
		int Online { [Bind ("getOnline")] get; }

		// @property (readonly, getter = getCoverOpen) int coverOpen;
		[Export ("coverOpen")]
		int CoverOpen { [Bind ("getCoverOpen")] get; }

		// @property (readonly, getter = getPaper) int paper;
		[Export ("paper")]
		int Paper { [Bind ("getPaper")] get; }

		// @property (readonly, getter = getPaperFeed) int paperFeed;
		[Export ("paperFeed")]
		int PaperFeed { [Bind ("getPaperFeed")] get; }

		// @property (readonly, getter = getPanelSwitch) int panelSwitch;
		[Export ("panelSwitch")]
		int PanelSwitch { [Bind ("getPanelSwitch")] get; }

		// @property (readonly, getter = getWaitOnline) int waitOnline;
		[Export ("waitOnline")]
		int WaitOnline { [Bind ("getWaitOnline")] get; }

		// @property (readonly, getter = getDrawer) int drawer;
		[Export ("drawer")]
		int Drawer { [Bind ("getDrawer")] get; }

		// @property (readonly, getter = getErrorStatus) int errorStatus;
		[Export ("errorStatus")]
		int ErrorStatus { [Bind ("getErrorStatus")] get; }

		// @property (readonly, getter = getAutoRecoverError) int autoRecoverError;
		[Export ("autoRecoverError")]
		int AutoRecoverError { [Bind ("getAutoRecoverError")] get; }

		// @property (readonly, getter = getBuzzer) int buzzer;
		[Export ("buzzer")]
		int Buzzer { [Bind ("getBuzzer")] get; }

		// @property (readonly, getter = getAdapter) int adapter;
		[Export ("adapter")]
		int Adapter { [Bind ("getAdapter")] get; }

		// @property (readonly, getter = getBatteryLevel) int batteryLevel;
		[Export ("batteryLevel")]
		int BatteryLevel { [Bind ("getBatteryLevel")] get; }
	}

	// @interface Epos2Printer : Epos2CommonPrinter
	[BaseType (typeof(Epos2CommonPrinter))]
	interface Epos2Printer
	{
		// -(id)initWithPrinterSeries:(int)printerSeries lang:(int)lang;
		[Export ("initWithPrinterSeries:lang:")]
		IntPtr Constructor (int printerSeries, int lang);

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();

		// -(int)connect:(NSString *)target timeout:(long)timeout;
		[Export ("connect:timeout:")]
		int Connect (string target, nint timeout);

		// -(int)disconnect;
		[Export ("disconnect")]
		int Disconnect();

		// -(Epos2PrinterStatusInfo *)getStatus;
		[Export ("getStatus")]
		Epos2PrinterStatusInfo GetStatus();

		// -(int)sendData:(long)timeout;
		[Export ("sendData:")]
		int SendData (nint timeout);

		// -(int)requestPrintJobStatus:(NSString *)printJobId;
		[Export ("requestPrintJobStatus:")]
		int RequestPrintJobStatus (string printJobId);

		// -(int)addHLine:(long)x1 x2:(long)x2 style:(int)style;
		[Export ("addHLine:x2:style:")]
		int AddHLine (nint x1, nint x2, int style);

		// -(int)addVLineBegin:(long)x style:(int)style lineId:(int *)lineId;
		[Export ("addVLineBegin:style:lineId:")]
		int AddVLineBegin (nint x, int style, out int lineId);

		// -(int)addVLineEnd:(int)lineId;
		[Export ("addVLineEnd:")]
		int AddVLineEnd (int lineId);

		// -(int)addSound:(int)pattern repeat:(long)repeat cycle:(long)cycle;
		[Export ("addSound:repeat:cycle:")]
		int AddSound (int pattern, nint repeat, nint cycle);

		// -(int)addFeedPosition:(int)position;
		[Export ("addFeedPosition:")]
		int AddFeedPosition (int position);

		// -(int)addLayout:(int)type width:(long)width height:(long)height marginTop:(long)marginTop marginBottom:(long)marginBottom offsetCut:(long)offsetCut offsetLabel:(long)offsetLabel;
		[Export ("addLayout:width:height:marginTop:marginBottom:offsetCut:offsetLabel:")]
		int AddLayout (int type, nint width, nint height, nint marginTop, nint marginBottom, nint offsetCut, nint offsetLabel);

		// -(int)addRotateBegin;
		[Export("addRotateBegin")]
		int AddRotateBegin();

		// -(int)addRotateEnd;
		[Export("addRotateEnd")]
		int AddRotateEnd();

		// -(int)forceStopSound:(long)timeout;
		[Export ("forceStopSound:")]
		int ForceStopSound (nint timeout);

		// -(int)forceCommand:(NSData *)data timeout:(long)timeout;
		[Export ("forceCommand:timeout:")]
		int ForceCommand (NSData data, nint timeout);

		// -(void)setStatusChangeEventDelegate:(id<Epos2PtrStatusChangeDelegate>)delegate;
		[Export ("setStatusChangeEventDelegate:")]
		void SetStatusChangeEventDelegate ([NullAllowed]Epos2PtrStatusChangeDelegate @delegate);

		// -(void)setReceiveEventDelegate:(id<Epos2PtrReceiveDelegate>)delegate;
		[Export ("setReceiveEventDelegate:")]
		void SetReceiveEventDelegate ([NullAllowed]Epos2PtrReceiveDelegate @delegate);

		// -(int)setInterval:(long)interval;
		[Export ("setInterval:")]
		int SetInterval (nint interval);

		// -(long)getInterval;
		[Export ("getInterval")]
		nint GetInterval();

		// -(void)setConnectionEventDelegate:(id<Epos2ConnectionDelegate>)delegate;
		[Export ("setConnectionEventDelegate:")]
		void SetConnectionEventDelegate ([NullAllowed]Epos2ConnectionDelegate @delegate);

		// -(NSString *)getAdmin;
		[Export ("getAdmin")]
		string GetAdmin();

		// -(NSString *)getLocation;
		[Export ("getLocation")]
		string GetLocation();

		// -(int)downloadFirmwareList:(NSString *)printerModel delegate:(id<Epos2FirmwareListDownloadDelegate>)delegate;
		[Export ("downloadFirmwareList:delegate:")]
		int DownloadFirmwareList (string printerModel, Epos2FirmwareListDownloadDelegate @delegate);

		// -(int)downloadFirmwareList:(NSString *)printerModel option:(NSString *)option delegate:(id<Epos2FirmwareListDownloadDelegate>)delegate;
		[Export ("downloadFirmwareList:option:delegate:")]
		int DownloadFirmwareList (string printerModel, string option, Epos2FirmwareListDownloadDelegate @delegate);

		// -(int)getPrinterFirmwareInfo:(long)timeout delegate:(id<Epos2FirmwareInformationDelegate>)delegate;
		[Export ("getPrinterFirmwareInfo:delegate:")]
		int GetPrinterFirmwareInfo (nint timeout, Epos2FirmwareInformationDelegate @delegate);

		// -(int)updateFirmware:(Epos2FirmwareInfo *)targetFirmwareInfo delegate:(id<Epos2FirmwareUpdateDelegate>)delegate;
		[Export ("updateFirmware:delegate:")]
		int UpdateFirmware (Epos2FirmwareInfo targetFirmwareInfo, Epos2FirmwareUpdateDelegate @delegate);

		// -(int)verifyUpdate:(Epos2FirmwareInfo *)targetFirmwareInfo delegate:(id<Epos2VerifyeUpdateDelegate>)delegate;
		[Export ("verifyUpdate:delegate:")]
		int VerifyUpdate (Epos2FirmwareInfo targetFirmwareInfo, Epos2VerifyeUpdateDelegate @delegate);

		// -(int)getMaintenanceCounter:(long)timeout type:(int)Type delegate:(id<Epos2MaintenanceCounterDelegate>)delegate;
		[Export ("getMaintenanceCounter:type:delegate:")]
		int GetMaintenanceCounter (nint timeout, int Type, Epos2MaintenanceCounterDelegate @delegate);

		// -(int)resetMaintenanceCounter:(long)timeout type:(int)Type delegate:(id<Epos2MaintenanceCounterDelegate>)delegate;
		[Export ("resetMaintenanceCounter:type:delegate:")]
		int ResetMaintenanceCounter (nint timeout, int Type, Epos2MaintenanceCounterDelegate @delegate);

		// -(int)getPrinterSetting:(long)timeout type:(int)Type delegate:(id<Epos2PrinterSettingDelegate>)delegate;
		[Export ("getPrinterSetting:type:delegate:")]
		int GetPrinterSetting (nint timeout, int Type, Epos2PrinterSettingDelegate @delegate);

		// -(int)setPrinterSetting:(long)timeout setttingList:(NSDictionary *)list delegate:(id<Epos2PrinterSettingDelegate>)delegate;
		[Export ("setPrinterSetting:setttingList:delegate:")]
		int SetPrinterSetting (nint timeout, NSDictionary list, Epos2PrinterSettingDelegate @delegate);
	}

	// @interface Epos2HybridPrinterStatusInfo : NSObject
	[BaseType (typeof(NSObject))]
	interface Epos2HybridPrinterStatusInfo
	{
		// @property (readonly, getter = getConnection) int connection;
		[Export ("connection")]
		int Connection { [Bind ("getConnection")] get; }

		// @property (readonly, getter = getOnline) int online;
		[Export ("online")]
		int Online { [Bind ("getOnline")] get; }

		// @property (readonly, getter = getCoverOpen) int coverOpen;
		[Export ("coverOpen")]
		int CoverOpen { [Bind ("getCoverOpen")] get; }

		// @property (readonly, getter = getPaper) int paper;
		[Export ("paper")]
		int Paper { [Bind ("getPaper")] get; }

		// @property (readonly, getter = getPaperFeed) int paperFeed;
		[Export ("paperFeed")]
		int PaperFeed { [Bind ("getPaperFeed")] get; }

		// @property (readonly, getter = getPanelSwitch) int panelSwitch;
		[Export ("panelSwitch")]
		int PanelSwitch { [Bind ("getPanelSwitch")] get; }

		// @property (readonly, getter = getWaitOnline) int waitOnline;
		[Export ("waitOnline")]
		int WaitOnline { [Bind ("getWaitOnline")] get; }

		// @property (readonly, getter = getDrawer) int drawer;
		[Export ("drawer")]
		int Drawer { [Bind ("getDrawer")] get; }

		// @property (readonly, getter = getErrorStatus) int errorStatus;
		[Export ("errorStatus")]
		int ErrorStatus { [Bind ("getErrorStatus")] get; }

		// @property (readonly, getter = getAutoRecoverError) int autoRecoverError;
		[Export ("autoRecoverError")]
		int AutoRecoverError { [Bind ("getAutoRecoverError")] get; }

		// @property (readonly, getter = getInsertionWaiting) int insertionWaiting;
		[Export ("insertionWaiting")]
		int InsertionWaiting { [Bind ("getInsertionWaiting")] get; }

		// @property (readonly, getter = getRemovalWaiting) int removalWaiting;
		[Export ("removalWaiting")]
		int RemovalWaiting { [Bind ("getRemovalWaiting")] get; }

		// @property (readonly, getter = getSlipPaper) int slipPaper;
		[Export ("slipPaper")]
		int SlipPaper { [Bind ("getSlipPaper")] get; }
	}

	// @interface Epos2HybridPrinter : Epos2CommonPrinter
	[BaseType (typeof(Epos2CommonPrinter))]
	interface Epos2HybridPrinter
	{
		// -(id)initWithLang:(int)lang;
		[Export ("initWithLang:")]
		IntPtr Constructor (int lang);

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();

		// -(int)connect:(NSString *)target timeout:(long)timeout;
		[Export ("connect:timeout:")]
		int Connect (string target, nint timeout);

		// -(int)disconnect;
		[Export ("disconnect")]
		int Disconnect ();

		// -(Epos2HybridPrinterStatusInfo *)getStatus;
		[Export ("getStatus")]
		Epos2HybridPrinterStatusInfo GetStatus();

		// -(int)selectPaperType:(int)paperType;
		[Export ("selectPaperType:")]
		int SelectPaperType (int paperType);

		// -(int)waitInsertion:(long)timeout;
		[Export ("waitInsertion:")]
		int WaitInsertion (nint timeout);

		// -(int)sendData:(long)timeout;
		[Export ("sendData:")]
		int SendData (nint timeout);

		// -(int)cancelInsertion;
		[Export ("cancelInsertion")]
		int CancelInsertion();

		// -(int)ejectPaper;
		[Export ("ejectPaper")]
		int EjectPaper();

		// -(int)readMicrData:(int)micrFont timeout:(long)timeout;
		[Export ("readMicrData:timeout:")]
		int ReadMicrData (int micrFont, nint timeout);

		// -(int)cleanMicrReader:(long)timeout;
		[Export ("cleanMicrReader:")]
		int CleanMicrReader (nint timeout);

		// -(int)forceCommand:(NSData *)data timeout:(long)timeout;
		[Export ("forceCommand:timeout:")]
		int ForceCommand (NSData data, nint timeout);

		// -(void)setStatusChangeEventDelegate:(id<Epos2HybdStatusChangeDelegate>)delegate;
		[Export ("setStatusChangeEventDelegate:")]
		void SetStatusChangeEventDelegate ([NullAllowed]Epos2HybdStatusChangeDelegate @delegate);

		// -(void)setReceiveEventDelegate:(id<Epos2HybdReceiveDelegate>)delegate;
		[Export ("setReceiveEventDelegate:")]
		void SetReceiveEventDelegate ([NullAllowed]Epos2HybdReceiveDelegate @delegate);

		// -(int)getPaperType;
		[Export ("getPaperType")]
		int GetPaperType();

		// -(int)setInterval:(long)interval;
		[Export ("setInterval:")]
		int SetInterval (nint interval);

		// -(long)getInterval;
		[Export ("getInterval")]
		nint GetInterval();

		// -(int)setWaitTime:(long)waitTime;
		[Export ("setWaitTime:")]
		int SetWaitTime (nint waitTime);

		// -(long)getWaitTime;
		[Export ("getWaitTime")]
		nint GetWaitTime();

		// -(int)setMode40Cpl:(int)mode40Cpl;
		[Export ("setMode40Cpl:")]
		int SetMode40Cpl (int mode40Cpl);

		// -(int)getMode40Cpl;
		[Export ("getMode40Cpl")]
		int GetMode40Cpl();

		// -(void)setConnectionEventDelegate:(id<Epos2ConnectionDelegate>)delegate;
		[Export ("setConnectionEventDelegate:")]
		void SetConnectionEventDelegate ([NullAllowed]Epos2ConnectionDelegate @delegate);

		// -(NSString *)getAdmin;
		[Export ("getAdmin")]
		string GetAdmin();

		// -(NSString *)getLocation;
		[Export ("getLocation")]
		string GetLocation();
	}

	// @interface Epos2DisplayStatusInfo : NSObject
	[BaseType (typeof(NSObject))]
	interface Epos2DisplayStatusInfo
	{
		// @property (readonly, getter = getConnection) int connection;
		[Export ("connection")]
		int Connection { [Bind ("getConnection")] get; }
	}

	// @interface Epos2LineDisplay : NSObject
	[BaseType (typeof(NSObject))]
	interface Epos2LineDisplay
	{
		// -(id)initWithDisplayModel:(int)displayModel;
		[Export ("initWithDisplayModel:")]
		IntPtr Constructor (int displayModel);

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();

		// -(int)connect:(NSString *)target timeout:(long)timeout;
		[Export ("connect:timeout:")]
		int Connect (string target, nint timeout);

		// -(int)disconnect;
		[Export ("disconnect")]
		int Disconnect();

		// -(Epos2DisplayStatusInfo *)getStatus;
		[Export ("getStatus")]
		Epos2DisplayStatusInfo GetStatus();

		// -(int)sendData;
		[Export ("sendData")]
		int SendData();

		// -(int)clearCommandBuffer;
		[Export ("clearCommandBuffer")]
		int ClearCommandBuffer();

		// -(int)addInitialize;
		[Export ("addInitialize")]
		int AddInitialize();

		// -(int)addCreateWindow:(long)number x:(long)x y:(long)y width:(long)width height:(long)height scrollMode:(int)scrollMode;
		[Export ("addCreateWindow:x:y:width:height:scrollMode:")]
		int AddCreateWindow (nint number, nint x, nint y, nint width, nint height, int scrollMode);

		// -(int)addDestroyWindow:(long)number;
		[Export ("addDestroyWindow:")]
		int AddDestroyWindow (nint number);

		// -(int)addSetCurrentWindow:(long)number;
		[Export ("addSetCurrentWindow:")]
		int AddSetCurrentWindow (nint number);

		// -(int)addClearCurrentWindow;
		[Export ("addClearCurrentWindow")]
		int AddClearCurrentWindow();

		// -(int)addSetCursorPosition:(long)x y:(long)y;
		[Export ("addSetCursorPosition:y:")]
		int AddSetCursorPosition (nint x, nint y);

		// -(int)addMoveCursorPosition:(int)position;
		[Export ("addMoveCursorPosition:")]
		int AddMoveCursorPosition (int position);

		// -(int)addSetCursorType:(int)type;
		[Export ("addSetCursorType:")]
		int AddSetCursorType (int type);

		// -(int)addText:(NSString *)data;
		[Export ("addText:")]
		int AddText (string data);

		// -(int)addText:(NSString *)data lang:(int)lang;
		[Export ("addText:lang:")]
		int AddText (string data, int lang);

		// -(int)addText:(NSString *)data x:(long)x y:(long)y;
		[Export ("addText:x:y:")]
		int AddText (string data, nint x, nint y);

		// -(int)addText:(NSString *)data x:(long)x y:(long)y lang:(int)lang;
		[Export ("addText:x:y:lang:")]
		int AddText (string data, nint x, nint y, int lang);

		// -(int)addReverseText:(NSString *)data;
		[Export ("addReverseText:")]
		int AddReverseText (string data);

		// -(int)addReverseText:(NSString *)data lang:(int)lang;
		[Export ("addReverseText:lang:")]
		int AddReverseText (string data, int lang);

		// -(int)addReverseText:(NSString *)data x:(long)x y:(long)y;
		[Export ("addReverseText:x:y:")]
		int AddReverseText (string data, nint x, nint y);

		// -(int)addReverseText:(NSString *)data x:(long)x y:(long)y lang:(int)lang;
		[Export ("addReverseText:x:y:lang:")]
		int AddReverseText (string data, nint x, nint y, int lang);

		// -(int)addMarqueeText:(NSString *)data format:(int)format unitWait:(long)unitWait repeatWait:(long)repeatWait repeatCount:(long)repeatCount lang:(int)lang;
		[Export ("addMarqueeText:format:unitWait:repeatWait:repeatCount:lang:")]
		int AddMarqueeText (string data, int format, nint unitWait, nint repeatWait, nint repeatCount, int lang);

		// -(int)addSetBlink:(long)interval;
		[Export ("addSetBlink:")]
		int AddSetBlink (nint interval);

		// -(int)addSetBrightness:(int)brightness;
		[Export ("addSetBrightness:")]
		int AddSetBrightness (int brightness);

		// -(int)addShowClock;
		[Export ("addShowClock")]
		int AddShowClock();

		// -(int)addCommand:(NSData *)data;
		[Export ("addCommand:")]
		int AddCommand (NSData data);

		// -(void)setReceiveEventDelegate:(id<Epos2DispReceiveDelegate>)delegate;
		[Export ("setReceiveEventDelegate:")]
		void SetReceiveEventDelegate ([NullAllowed]Epos2DispReceiveDelegate @delegate);

		// -(void)setConnectionEventDelegate:(id<Epos2ConnectionDelegate>)delegate;
		[Export ("setConnectionEventDelegate:")]
		void SetConnectionEventDelegate ([NullAllowed]Epos2ConnectionDelegate @delegate);

		// -(NSString *)getAdmin;
		[Export ("getAdmin")]
		string GetAdmin();

		// -(NSString *)getLocation;
		[Export ("getLocation")]
		string GetLocation();
	}

	// @interface Epos2KeyboardStatusInfo : NSObject
	[BaseType (typeof(NSObject))]
	interface Epos2KeyboardStatusInfo
	{
		// @property (readonly, getter = getConnection) int connection;
		[Export ("connection")]
		int Connection { [Bind ("getConnection")] get; }
	}

	// @interface Epos2Keyboard : NSObject
	[BaseType (typeof(NSObject))]
	interface Epos2Keyboard
	{
		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();

		// -(int)connect:(NSString *)target timeout:(long)timeout;
		[Export ("connect:timeout:")]
		int Connect (string target, nint timeout);

		// -(int)disconnect;
		[Export ("disconnect")]
		int Disconnect();

		// -(Epos2KeyboardStatusInfo *)getStatus;
		[Export ("getStatus")]
		Epos2KeyboardStatusInfo GetStatus();

		// -(int)setPrefix:(NSData *)data;
		[Export ("setPrefix:")]
		int SetPrefix ([NullAllowed]NSData data);

		// -(NSData *)getPrefix;
		[Export ("getPrefix")]
		NSData GetPrefix();

		// -(void)setKeyPressEventDelegate:(id<Epos2KbdKeyPressDelegate>)delegate;
		[Export ("setKeyPressEventDelegate:")]
		void SetKeyPressEventDelegate ([NullAllowed]Epos2KbdKeyPressDelegate @delegate);

		// -(void)setReadStringEventDelegate:(id<Epos2KbdReadStringDelegate>)delegate;
		[Export ("setReadStringEventDelegate:")]
		void SetReadStringEventDelegate ([NullAllowed]Epos2KbdReadStringDelegate @delegate);

		// -(void)setConnectionEventDelegate:(id<Epos2ConnectionDelegate>)delegate;
		[Export ("setConnectionEventDelegate:")]
		void SetConnectionEventDelegate ([NullAllowed]Epos2ConnectionDelegate @delegate);

		// -(NSString *)getAdmin;
		[Export ("getAdmin")]
		string GetAdmin();

		// -(NSString *)getLocation;
		[Export ("getLocation")]
		string GetLocation();
	}

	// @interface Epos2ScannerStatusInfo : NSObject
	[BaseType (typeof(NSObject))]
	interface Epos2ScannerStatusInfo
	{
		// @property (readonly, getter = getConnection) int connection;
		[Export ("connection")]
		int Connection { [Bind ("getConnection")] get; }
	}

	// @interface Epos2BarcodeScanner : NSObject
	[BaseType (typeof(NSObject))]
	interface Epos2BarcodeScanner
	{
		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();

		// -(int)connect:(NSString *)target timeout:(long)timeout;
		[Export ("connect:timeout:")]
		int Connect (string target, nint timeout);

		// -(int)disconnect;
		[Export ("disconnect")]
		int Disconnect();

		// -(Epos2ScannerStatusInfo *)getStatus;
		[Export ("getStatus")]
		Epos2ScannerStatusInfo GetStatus();

		// -(void)setScanEventDelegate:(id<Epos2ScanDelegate>)delegate;
		[Export ("setScanEventDelegate:")]
		void SetScanEventDelegate ([NullAllowed]Epos2ScanDelegate @delegate);

		// -(void)setConnectionEventDelegate:(id<Epos2ConnectionDelegate>)delegate;
		[Export ("setConnectionEventDelegate:")]
		void SetConnectionEventDelegate ([NullAllowed]Epos2ConnectionDelegate @delegate);

		// -(NSString *)getAdmin;
		[Export ("getAdmin")]
		string GetAdmin();

		// -(NSString *)getLocation;
		[Export ("getLocation")]
		string GetLocation();
	}

	// @interface Epos2SimpleSerialStatusInfo : NSObject
	[BaseType (typeof(NSObject))]
	interface Epos2SimpleSerialStatusInfo
	{
		// @property (readonly, getter = getConnection) int connection;
		[Export ("connection")]
		int Connection { [Bind ("getConnection")] get; }
	}

	// @interface Epos2SimpleSerial : NSObject
	[BaseType (typeof(NSObject))]
	interface Epos2SimpleSerial
	{
		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();

		// -(int)connect:(NSString *)target timeout:(long)timeout;
		[Export ("connect:timeout:")]
		int Connect (string target, nint timeout);

		// -(int)disconnect;
		[Export ("disconnect")]
		int Disconnect();

		// -(Epos2SimpleSerialStatusInfo *)getStatus;
		[Export ("getStatus")]
		Epos2SimpleSerialStatusInfo GetStatus();

		// -(int)sendCommand:(NSData *)data;
		[Export ("sendCommand:")]
		int SendCommand (NSData data);

		// -(void)setReceiveEventDelegate:(id<Epos2SimpleSerialReceiveDelegate>)delegate;
		[Export ("setReceiveEventDelegate:")]
		void SetReceiveEventDelegate ([NullAllowed]Epos2SimpleSerialReceiveDelegate @delegate);

		// -(void)setConnectionEventDelegate:(id<Epos2ConnectionDelegate>)delegate;
		[Export ("setConnectionEventDelegate:")]
		void SetConnectionEventDelegate ([NullAllowed]Epos2ConnectionDelegate @delegate);

		// -(NSString *)getAdmin;
		[Export ("getAdmin")]
		string GetAdmin();

		// -(NSString *)getLocation;
		[Export ("getLocation")]
		string GetLocation();
	}

	// @interface Epos2CommBoxStatusInfo : NSObject
	[BaseType (typeof(NSObject))]
	interface Epos2CommBoxStatusInfo
	{
		// @property (readonly, getter = getConnection) int connection;
		[Export ("connection")]
		int Connection { [Bind ("getConnection")] get; }
	}

	// @interface Epos2CommBox : NSObject
	[BaseType (typeof(NSObject))]
	interface Epos2CommBox
	{
		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();

		// -(int)connect:(NSString *)target timeout:(long)timeout myId:(NSString *)myId;
		[Export ("connect:timeout:myId:")]
		int Connect (string target, nint timeout, string myId);

		// -(int)disconnect;
		[Export ("disconnect")]
		int Disconnect();

		// -(Epos2CommBoxStatusInfo *)getStatus;
		[Export ("getStatus")]
		Epos2CommBoxStatusInfo GetStatus();

		// -(int)getCommHistory:(id<Epos2GetCommHistoryDelegate>)delegate;
		[Export ("getCommHistory:")]
		int GetCommHistory (Epos2GetCommHistoryDelegate @delegate);

		// -(int)sendMessage:(NSString *)message targetId:(NSString *)targetId delegate:(id<Epos2CommBoxSendMessageDelegate>)delegate;
		[Export ("sendMessage:targetId:delegate:")]
		int SendMessage (string message, [NullAllowed]string targetId, Epos2CommBoxSendMessageDelegate @delegate);

		// -(void)setReceiveEventDelegate:(id<Epos2CommBoxReceiveDelegate>)delegate;
		[Export ("setReceiveEventDelegate:")]
		void SetReceiveEventDelegate ([NullAllowed]Epos2CommBoxReceiveDelegate @delegate);

		// -(void)setConnectionEventDelegate:(id<Epos2ConnectionDelegate>)delegate;
		[Export ("setConnectionEventDelegate:")]
		void SetConnectionEventDelegate ([NullAllowed]Epos2ConnectionDelegate @delegate);

		// -(NSString *)getAdmin;
		[Export ("getAdmin")]
		string GetAdmin();

		// -(NSString *)getLocation;
		[Export ("getLocation")]
		string GetLocation();
	}

	// @interface Epos2CashChangerStatusInfo : NSObject
	[BaseType (typeof(NSObject))]
	interface Epos2CashChangerStatusInfo
	{
		// @property (readonly, getter = getConnection) int connection;
		[Export ("connection")]
		int Connection { [Bind ("getConnection")] get; }
	}

	// @interface Epos2CashChanger : NSObject
	[BaseType (typeof(NSObject))]
	interface Epos2CashChanger
	{
		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();

		// -(int)connect:(NSString *)target timeout:(long)timeout;
		[Export ("connect:timeout:")]
		int Connect (string target, nint timeout);

		// -(int)disconnect;
		[Export ("disconnect")]
		int Disconnect();

		// -(Epos2CashChangerStatusInfo *)getStatus;
		[Export ("getStatus")]
		Epos2CashChangerStatusInfo GetStatus();

		// -(int)getOposErrorCode;
		[Export ("getOposErrorCode")]
		int GetOposErrorCode();

		// -(int)setConfigCountMode:(int)countMode;
		[Export ("setConfigCountMode:")]
		int SetConfigCountMode (int countMode);

		// -(int)setConfigLeftCash:(long)coins bills:(long)bills;
		[Export ("setConfigLeftCash:bills:")]
		int SetConfigLeftCash (nint coins, nint bills);

		// -(int)readCashCount;
		[Export ("readCashCount")]
		int ReadCashCount();

		// -(int)beginDeposit;
		[Export ("beginDeposit")]
		int BeginDeposit();

		// -(int)pauseDeposit;
		[Export ("pauseDeposit")]
		int PauseDeposit();

		// -(int)restartDeposit;
		[Export ("restartDeposit")]
		int RestartDeposit();

		// -(int)endDeposit:(int)config;
		[Export ("endDeposit:")]
		int EndDeposit (int config);

		// -(int)dispenseChange:(long)cash;
		[Export ("dispenseChange:")]
		int DispenseChange (nint cash);

		// -(int)dispenseCash:(NSDictionary *)data;
		[Export ("dispenseCash:")]
		int DispenseCash (NSDictionary data);

		// -(int)collectCash:(int)type;
		[Export ("collectCash:")]
		int CollectCash (int type);

		// -(int)openDrawer;
		[Export ("openDrawer")]
		int OpenDrawer ();

		// -(int)sendCommand:(NSData *)data;
		[Export ("sendCommand:")]
		int SendCommand (NSData data);

		// -(int)sendDirectIOCommand:(long)command data:(long)data string:(NSString *)string;
		[Export ("sendDirectIOCommand:data:string:")]
		int SendDirectIOCommand (nint command, nint data, string @string);

		// -(void)setConfigChangeEventDelegate:(id<Epos2CChangerConfigChangeDelegate>)delegate;
		[Export ("setConfigChangeEventDelegate:")]
		void SetConfigChangeEventDelegate ([NullAllowed]Epos2CChangerConfigChangeDelegate @delegate);

		// -(void)setCashCountEventDelegate:(id<Epos2CChangerCashCountDelegate>)delegate;
		[Export ("setCashCountEventDelegate:")]
		void SetCashCountEventDelegate ([NullAllowed]Epos2CChangerCashCountDelegate @delegate);

		// -(void)setDepositEventDelegate:(id<Epos2CChangerDepositDelegate>)delegate;
		[Export ("setDepositEventDelegate:")]
		void SetDepositEventDelegate ([NullAllowed]Epos2CChangerDepositDelegate @delegate);

		// -(void)setDispenseEventDelegate:(id<Epos2CChangerDispenseDelegate>)delegate;
		[Export ("setDispenseEventDelegate:")]
		void SetDispenseEventDelegate ([NullAllowed]Epos2CChangerDispenseDelegate @delegate);

		// -(void)setCollectEventDelegate:(id<Epos2CChangerCollectDelegate>)delegate;
		[Export ("setCollectEventDelegate:")]
		void SetCollectEventDelegate ([NullAllowed]Epos2CChangerCollectDelegate @delegate);

		// -(void)setCommandReplyEventDelegate:(id<Epos2CChangerCommandReplyDelegate>)delegate;
		[Export ("setCommandReplyEventDelegate:")]
		void SetCommandReplyEventDelegate ([NullAllowed]Epos2CChangerCommandReplyDelegate @delegate);

		// -(void)setDirectIOCommandReplyEventDelegate:(id<Epos2CChangerDirectIOCommandReplyDelegate>)delegate;
		[Export ("setDirectIOCommandReplyEventDelegate:")]
		void SetDirectIOCommandReplyEventDelegate ([NullAllowed]Epos2CChangerDirectIOCommandReplyDelegate @delegate);

		// -(void)setStatusChangeEventDelegate:(id<Epos2CChangerStatusChangeDelegate>)delegate;
		[Export ("setStatusChangeEventDelegate:")]
		void SetStatusChangeEventDelegate ([NullAllowed]Epos2CChangerStatusChangeDelegate @delegate);

		// -(void)setDirectIOEventDelegate:(id<Epos2CChangerDirectIODelegate>)delegate;
		[Export ("setDirectIOEventDelegate:")]
		void SetDirectIOEventDelegate ([NullAllowed]Epos2CChangerDirectIODelegate @delegate);

		// -(void)setStatusUpdateEventDelegate:(id<Epos2CChangerStatusUpdateDelegate>)delegate;
		[Export ("setStatusUpdateEventDelegate:")]
		void SetStatusUpdateEventDelegate ([NullAllowed]Epos2CChangerStatusUpdateDelegate @delegate);

		// -(void)setConnectionEventDelegate:(id<Epos2ConnectionDelegate>)delegate;
		[Export ("setConnectionEventDelegate:")]
		void SetConnectionEventDelegate ([NullAllowed]Epos2ConnectionDelegate @delegate);

		// -(NSString *)getAdmin;
		[Export ("getAdmin")]
		string GetAdmin();

		// -(NSString *)getLocation;
		[Export ("getLocation")]
		string GetLocation();
	}

	// @interface Epos2POSKeyboardStatusInfo : NSObject
	[BaseType (typeof(NSObject))]
	interface Epos2POSKeyboardStatusInfo
	{
		// @property (readonly, getter = getConnection) int connection;
		[Export ("connection")]
		int Connection { [Bind ("getConnection")] get; }
	}

	// @interface Epos2POSKeyboard : NSObject
	[BaseType (typeof(NSObject))]
	interface Epos2POSKeyboard
	{
		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();

		// -(int)connect:(NSString *)target timeout:(long)timeout;
		[Export ("connect:timeout:")]
		int Connect (string target, nint timeout);

		// -(int)disconnect;
		[Export ("disconnect")]
		int Disconnect();

		// -(Epos2POSKeyboardStatusInfo *)getStatus;
		[Export ("getStatus")]
		Epos2POSKeyboardStatusInfo GetStatus();

		// -(void)setKeyPressEventDelegate:(id<Epos2POSKbdKeyPressDelegate>)delegate;
		[Export ("setKeyPressEventDelegate:")]
		void SetKeyPressEventDelegate([NullAllowed]Epos2POSKbdKeyPressDelegate @delegate);

		// -(void)setConnectionEventDelegate:(id<Epos2ConnectionDelegate>)delegate;
		[Export ("setConnectionEventDelegate:")]
		void SetConnectionEventDelegate([NullAllowed]Epos2ConnectionDelegate @delegate);

		// -(NSString *)getAdmin;
		[Export ("getAdmin")]
		string GetAdmin();

		// -(NSString *)getLocation;
		[Export ("getLocation")]
		string GetLocation();
	}

	// @interface Epos2CATStatusInfo : NSObject
	[BaseType (typeof(NSObject))]
	interface Epos2CATStatusInfo
	{
		// @property (readonly, getter = getConnection) int connection;
		[Export ("connection")]
		int Connection { [Bind ("getConnection")] get; }
	}

	// @interface Epos2CATAuthorizeResult : NSObject
	[BaseType (typeof(NSObject))]
	interface Epos2CATAuthorizeResult
	{
		// @property (readonly, getter = getAccountNumber, copy, nonatomic) NSString * accountNumber;
		[Export ("accountNumber")]
		string AccountNumber { [Bind ("getAccountNumber")] get; }

		// @property (readonly, getter = getSettledAmount, nonatomic) long settledAmount;
		[Export ("settledAmount")]
		nint SettledAmount { [Bind ("getSettledAmount")] get; }

		// @property (readonly, getter = getSlipNumber, copy, nonatomic) NSString * slipNumber;
		[Export ("slipNumber")]
		string SlipNumber { [Bind ("getSlipNumber")] get; }

		// @property (readonly, getter = getKid, copy, nonatomic) NSString * kid;
		[Export ("kid")]
		string Kid { [Bind ("getKid")] get; }

		// @property (readonly, getter = getApprovalCode, copy, nonatomic) NSString * approvalCode;
		[Export ("approvalCode")]
		string ApprovalCode { [Bind ("getApprovalCode")] get; }

		// @property (readonly, getter = getTransactionNumber, copy, nonatomic) NSString * transactionNumber;
		[Export ("transactionNumber")]
		string TransactionNumber { [Bind ("getTransactionNumber")] get; }

		// @property (readonly, getter = getPaymentCondition, nonatomic) int paymentCondition;
		[Export ("paymentCondition")]
		int PaymentCondition { [Bind ("getPaymentCondition")] get; }

		// @property (readonly, getter = getVoidSlipNumber, copy, nonatomic) NSString * voidSlipNumber;
		[Export ("voidSlipNumber")]
		string VoidSlipNumber { [Bind ("getVoidSlipNumber")] get; }

		// @property (readonly, getter = getBalance, nonatomic) long balance;
		[Export ("balance")]
		nint Balance { [Bind ("getBalance")] get; }
	}

	// @interface Epos2CATDailyLog : NSObject
	[BaseType (typeof(NSObject))]
	interface Epos2CATDailyLog
	{
		// @property (readonly, getter = getKid, copy, nonatomic) NSString * kid;
		[Export ("kid")]
		string Kid { [Bind ("getKid")] get; }

		// @property (readonly, getter = getSalesCount, nonatomic) long long salesCount;
		[Export ("salesCount")]
		long SalesCount { [Bind ("getSalesCount")] get; }

		// @property (readonly, getter = getSalesAmount, nonatomic) long long salesAmount;
		[Export ("salesAmount")]
		long SalesAmount { [Bind ("getSalesAmount")] get; }

		// @property (readonly, getter = getVoidCount, nonatomic) long long voidCount;
		[Export ("voidCount")]
		long VoidCount { [Bind ("getVoidCount")] get; }

		// @property (readonly, getter = getVoidAmount, nonatomic) long long voidAmount;
		[Export ("voidAmount")]
		long VoidAmount { [Bind ("getVoidAmount")] get; }
	}

	// @interface Epos2CATDirectIOResult : NSObject
	[BaseType (typeof(NSObject))]
	interface Epos2CATDirectIOResult
	{
		// @property (readonly, getter = getAccountNumber, copy, nonatomic) NSString * accountNumber;
		[Export ("accountNumber")]
		string AccountNumber { [Bind ("getAccountNumber")] get; }

		// @property (readonly, getter = getSettledAmount, nonatomic) long settledAmount;
		[Export ("settledAmount")]
		nint SettledAmount { [Bind ("getSettledAmount")] get; }

		// @property (readonly, getter = getSlipNumber, copy, nonatomic) NSString * slipNumber;
		[Export ("slipNumber")]
		string SlipNumber { [Bind ("getSlipNumber")] get; }

		// @property (readonly, getter = getTransactionNumber, copy, nonatomic) NSString * transactionNumber;
		[Export ("transactionNumber")]
		string TransactionNumber { [Bind ("getTransactionNumber")] get; }

		// @property (readonly, getter = getPaymentCondition, nonatomic) int paymentCondition;
		[Export ("paymentCondition")]
		int PaymentCondition { [Bind ("getPaymentCondition")] get; }

		// @property (readonly, getter = getBalance, nonatomic) long balance;
		[Export ("balance")]
		nint Balance { [Bind ("getBalance")] get; }

		// @property (readonly, getter = getAdditionalSecurityInformation, copy, nonatomic) NSString * additionalSecurityInformation;
		[Export ("additionalSecurityInformation")]
		string AdditionalSecurityInformation { [Bind ("getAdditionalSecurityInformation")] get; }
	}

	// @interface Epos2CAT : NSObject
	[BaseType (typeof(NSObject))]
	interface Epos2CAT
	{
		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();

		// -(int)setTimeout:(long)timeout;
		[Export ("setTimeout:")]
		int SetTimeout (nint timeout);

		// -(long)getTimeout;
		[Export ("getTimeout")]
		nint GetTimeout();

		// -(int)setTrainingMode:(int)mode;
		[Export ("setTrainingMode:")]
		int SetTrainingMode (int mode);

		// -(int)getTrainingMode;
		[Export ("getTrainingMode")]
		int GetTrainingMode();

		// -(int)connect:(NSString *)target timeout:(long)timeout;
		[Export ("connect:timeout:")]
		int Connect (string target, nint timeout);

		// -(int)disconnect;
		[Export ("disconnect")]
		int Disconnect();

		// -(Epos2CATStatusInfo *)getStatus;
		[Export ("getStatus")]
		Epos2CATStatusInfo GetStatus();

		// -(int)getOposErrorCode;
		[Export ("getOposErrorCode")]
		int GetOposErrorCode();

		// -(int)authorizeSales:(int)service totalAmount:(long)totalAmount sequence:(long)sequence;
		[Export ("authorizeSales:totalAmount:sequence:")]
		int AuthorizeSales (int service, nint totalAmount, nint sequence);

		// -(int)authorizeVoid:(int)service totalAmount:(long)totalAmount sequence:(long)sequence;
		[Export ("authorizeVoid:totalAmount:sequence:")]
		int AuthorizeVoid (int service, nint totalAmount, nint sequence);

		// -(int)authorizeRefund:(int)service totalAmount:(long)totalAmount sequence:(long)sequence;
		[Export ("authorizeRefund:totalAmount:sequence:")]
		int AuthorizeRefund (int service, nint totalAmount, nint sequence);

		// -(int)authorizeCompletion:(int)service totalAmount:(long)totalAmount sequence:(long)sequence;
		[Export ("authorizeCompletion:totalAmount:sequence:")]
		int AuthorizeCompletion (int service, nint totalAmount, nint sequence);

		// -(int)accessDailyLog:(int)service sequence:(long)sequence;
		[Export ("accessDailyLog:sequence:")]
		int AccessDailyLog (int service, nint sequence);

		// -(int)sendDirectIOCommand:(long)command data:(long)data string:(NSString *)string service:(int)service;
		[Export ("sendDirectIOCommand:data:string:service:")]
		int SendDirectIOCommand (nint command, nint data, string @string, int service);

		// -(void)setAuthorizeSalesEventDelegate:(id<Epos2CATAuthorizeSalesDelegate>)delegate;
		[Export ("setAuthorizeSalesEventDelegate:")]
		void SetAuthorizeSalesEventDelegate ([NullAllowed]Epos2CATAuthorizeSalesDelegate @delegate);

		// -(void)setAuthorizeVoidEventDelegate:(id<Epos2CATAuthorizeVoidDelegate>)delegate;
		[Export ("setAuthorizeVoidEventDelegate:")]
		void SetAuthorizeVoidEventDelegate ([NullAllowed]Epos2CATAuthorizeVoidDelegate @delegate);

		// -(void)setAuthorizeRefundEventDelegate:(id<Epos2CATAuthorizeRefundDelegate>)delegate;
		[Export ("setAuthorizeRefundEventDelegate:")]
		void SetAuthorizeRefundEventDelegate ([NullAllowed]Epos2CATAuthorizeRefundDelegate @delegate);

		// -(void)setAuthorizeCompletionEventDelegate:(id<Epos2CATAuthorizeCompletionDelegate>)delegate;
		[Export ("setAuthorizeCompletionEventDelegate:")]
		void SetAuthorizeCompletionEventDelegate ([NullAllowed]Epos2CATAuthorizeCompletionDelegate @delegate);

		// -(void)setAccessDailyLogEventDelegate:(id<Epos2CATAccessDailyLogDelegate>)delegate;
		[Export ("setAccessDailyLogEventDelegate:")]
		void SetAccessDailyLogEventDelegate ([NullAllowed]Epos2CATAccessDailyLogDelegate @delegate);

		// -(void)setDirectIOCommandReplyEventDelegate:(id<Epos2CATDirectIOCommandReplyDelegate>)delegate;
		[Export ("setDirectIOCommandReplyEventDelegate:")]
		void SetDirectIOCommandReplyEventDelegate ([NullAllowed]Epos2CATDirectIOCommandReplyDelegate @delegate);

		// -(void)setStatusUpdateEventDelegate:(id<Epos2CATStatusUpdateDelegate>)delegate;
		[Export ("setStatusUpdateEventDelegate:")]
		void SetStatusUpdateEventDelegate ([NullAllowed]Epos2CATStatusUpdateDelegate @delegate);

		// -(void)setConnectionEventDelegate:(id<Epos2ConnectionDelegate>)delegate;
		[Export ("setConnectionEventDelegate:")]
		void SetConnectionEventDelegate ([NullAllowed]Epos2ConnectionDelegate @delegate);

		// -(NSString *)getAdmin;
		[Export ("getAdmin")]
		string GetAdmin();

		// -(NSString *)getLocation;
		[Export ("getLocation")]
		string GetLocation();
	}

	// @interface Epos2MSRStatusInfo : NSObject
	[BaseType (typeof(NSObject))]
	interface Epos2MSRStatusInfo
	{
		// @property (readonly, getter = getConnection) int connection;
		[Export ("connection")]
		int Connection { [Bind ("getConnection")] get; }
	}

	// @interface Epos2MSRData : NSObject
	[BaseType (typeof(NSObject))]
	interface Epos2MSRData
	{
		// @property (readonly, getter = getTrack1, copy, nonatomic) NSString * track1;
		[Export ("track1")]
		string Track1 { [Bind ("getTrack1")] get; }

		// @property (readonly, getter = getTrack2, copy, nonatomic) NSString * track2;
		[Export ("track2")]
		string Track2 { [Bind ("getTrack2")] get; }

		// @property (readonly, getter = getTrack4, copy, nonatomic) NSString * track4;
		[Export ("track4")]
		string Track4 { [Bind ("getTrack4")] get; }

		// @property (readonly, getter = getAccountNumber, copy, nonatomic) NSString * accountNumber;
		[Export ("accountNumber")]
		string AccountNumber { [Bind ("getAccountNumber")] get; }

		// @property (readonly, getter = getExpirationData, copy, nonatomic) NSString * expirationData;
		[Export ("expirationData")]
		string ExpirationData { [Bind ("getExpirationData")] get; }

		// @property (readonly, getter = getSurname, copy, nonatomic) NSString * surname;
		[Export ("surname")]
		string Surname { [Bind ("getSurname")] get; }

		// @property (readonly, getter = getFirstName, copy, nonatomic) NSString * firstName;
		[Export ("firstName")]
		string FirstName { [Bind ("getFirstName")] get; }

		// @property (readonly, getter = getMiddleInitial, copy, nonatomic) NSString * middleInitial;
		[Export ("middleInitial")]
		string MiddleInitial { [Bind ("getMiddleInitial")] get; }

		// @property (readonly, getter = getTitle, copy, nonatomic) NSString * title;
		[Export ("title")]
		string Title { [Bind ("getTitle")] get; }

		// @property (readonly, getter = getServiceCode, copy, nonatomic) NSString * serviceCode;
		[Export ("serviceCode")]
		string ServiceCode { [Bind ("getServiceCode")] get; }

		// @property (readonly, getter = getTrack1_dd, copy, nonatomic) NSString * track1_dd;
		[Export ("track1_dd")]
		string Track1_dd { [Bind ("getTrack1_dd")] get; }

		// @property (readonly, getter = getTrack2_dd, copy, nonatomic) NSString * track2_dd;
		[Export ("track2_dd")]
		string Track2_dd { [Bind ("getTrack2_dd")] get; }
	}

	// @interface Epos2MSR : NSObject
	[BaseType (typeof(NSObject))]
	interface Epos2MSR
	{
		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();

		// -(int)connect:(NSString *)target timeout:(long)timeout;
		[Export ("connect:timeout:")]
		int Connect (string target, nint timeout);

		// -(int)disconnect;
		[Export ("disconnect")]
		int Disconnect();

		// -(Epos2MSRStatusInfo *)getStatus;
		[Export ("getStatus")]
		Epos2MSRStatusInfo GetStatus();

		// -(void)setDataEventDelegate:(id<Epos2MSRDataDelegate>)delegate;
		[Export ("setDataEventDelegate:")]
		void SetDataEventDelegate ([NullAllowed]Epos2MSRDataDelegate @delegate);

		// -(void)setConnectionEventDelegate:(id<Epos2ConnectionDelegate>)delegate;
		[Export ("setConnectionEventDelegate:")]
		void SetConnectionEventDelegate ([NullAllowed]Epos2ConnectionDelegate @delegate);

		// -(NSString *)getAdmin;
		[Export ("getAdmin")]
		string GetAdmin();

		// -(NSString *)getLocation;
		[Export ("getLocation")]
		string GetLocation();
	}

	// @interface Epos2OtherPeripheralStatusInfo : NSObject
	[BaseType (typeof(NSObject))]
	interface Epos2OtherPeripheralStatusInfo
	{
		// @property (readonly, getter = getConnection) int connection;
		[Export ("connection")]
		int Connection { [Bind ("getConnection")] get; }
	}

	// @interface Epos2OtherPeripheral : NSObject
	[BaseType (typeof(NSObject))]
	interface Epos2OtherPeripheral
	{
		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();

		// -(int)connect:(NSString *)target timeout:(long)timeout;
		[Export ("connect:timeout:")]
		int Connect (string target, nint timeout);

		// -(int)disconnect;
		[Export ("disconnect")]
		int Disconnect();

		// -(Epos2OtherPeripheralStatusInfo *)getStatus;
		[Export ("getStatus")]
		Epos2OtherPeripheralStatusInfo GetStatus();

		// -(int)sendData:(NSString *)methodName data:(NSString *)data;
		[Export ("sendData:data:")]
		int SendData (string methodName, string data);

		// -(void)setReceiveEventDelegate:(id<Epos2OtherReceiveDelegate>)delegate;
		[Export ("setReceiveEventDelegate:")]
		void SetReceiveEventDelegate ([NullAllowed]Epos2OtherReceiveDelegate @delegate);
		// -(void)setConnectionEventDelegate:(id<Epos2ConnectionDelegate>)delegate;
		[Export ("setConnectionEventDelegate:")]
		void SetConnectionEventDelegate (Epos2ConnectionDelegate @delegate);

		// -(NSString *)getAdmin;
		[Export ("getAdmin")]
		string GetAdmin();

		// -(NSString *)getLocation;
		[Export ("getLocation")]
		string GetLocation();
	}

	// @interface Epos2GermanyFiscalElementStatusinfo : NSObject
	[BaseType (typeof(NSObject))]
	interface Epos2GermanyFiscalElementStatusinfo
	{
		// @property (readonly, getter = getConnection) int connection;
		[Export ("connection")]
		int Connection { [Bind ("getConnection")] get; }
	}

	// @interface Epos2GermanyFiscalElement : NSObject
	[BaseType (typeof(NSObject))]
	interface Epos2GermanyFiscalElement
	{
		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();

		// -(int)connect:(NSString *)target timeout:(long)timeout;
		[Export ("connect:timeout:")]
		int Connect (string target, nint timeout);

		// -(int)disconnect;
		[Export ("disconnect")]
		int Disconnect();

		// -(Epos2GermanyFiscalElementStatusinfo *)getStatus;
		[Export ("getStatus")]
		Epos2GermanyFiscalElementStatusinfo GetStatus();

		// -(int)operate:(NSString *)jsonString timeout:(long)timeout;
		[Export ("operate:timeout:")]
		int Operate (string jsonString, nint timeout);

		// -(void)setReceiveEventDelegate:(id<Epos2GermanyFiscalElementReceiveDelegate>)delegate;
		[Export ("setReceiveEventDelegate:")]
		void SetReceiveEventDelegate (Epos2GermanyFiscalElementReceiveDelegate @delegate);

		// -(void)setConnectionEventDelegate:(id<Epos2ConnectionDelegate>)delegate;
		[Export ("setConnectionEventDelegate:")]
		void SetConnectionEventDelegate ([NullAllowed]Epos2ConnectionDelegate @delegate);

		// -(NSString *)getAdmin;
		[Export ("getAdmin")]
		string GetAdmin();

		// -(NSString *)getLocation;
		[Export ("getLocation")]
		string GetLocation();
	}

	// @interface Epos2FirmwareInfo : NSObject
	[BaseType (typeof(NSObject))]
	interface Epos2FirmwareInfo
	{
		// @property (readonly, getter = getVersion, copy, nonatomic) NSString * version;
		[Export ("version")]
		string Version { [Bind ("getVersion")] get; }
	}

	// @interface Epos2FilterOption : NSObject
	[BaseType (typeof(NSObject))]
	interface Epos2FilterOption
	{
		// @property (getter = getPortType, nonatomic, setter = setPortType:) int portType;
		[Export ("portType")]
		int PortType { [Bind ("getPortType")] get; [Bind ("setPortType:")] set; }

		// @property (getter = getBroadcast, copy, nonatomic, setter = setBroadcast:) NSString * broadcast;
		[Export ("broadcast")]
		string Broadcast { [Bind ("getBroadcast")] get; [Bind ("setBroadcast:")] set; }

		// @property (getter = getDeviceModel, nonatomic, setter = setDeviceModel:) int deviceModel;
		[Export ("deviceModel")]
		int DeviceModel { [Bind ("getDeviceModel")] get; [Bind ("setDeviceModel:")] set; }

		// @property (getter = getDeviceType, nonatomic, setter = setDeviceType:) int deviceType;
		[Export ("deviceType")]
		int DeviceType { [Bind ("getDeviceType")] get; [Bind ("setDeviceType:")] set; }
	}

	// @interface Epos2DeviceInfo : NSObject
	[BaseType (typeof(NSObject))]
	interface Epos2DeviceInfo
	{
		// @property (readonly, getter = getDeviceType, nonatomic) int deviceType;
		[Export ("deviceType")]
		int DeviceType { [Bind ("getDeviceType")] get; }

		// @property (readonly, getter = getTarget, copy, nonatomic) NSString * target;
		[Export ("target")]
		string Target { [Bind ("getTarget")] get; }

		// @property (readonly, getter = getDeviceName, copy, nonatomic) NSString * deviceName;
		[Export ("deviceName")]
		string DeviceName { [Bind ("getDeviceName")] get; }

		// @property (readonly, getter = getIpAddress, copy, nonatomic) NSString * ipAddress;
		[Export ("ipAddress")]
		string IpAddress { [Bind ("getIpAddress")] get; }

		// @property (readonly, getter = getMacAddress, copy, nonatomic) NSString * macAddress;
		[Export ("macAddress")]
		string MacAddress { [Bind ("getMacAddress")] get; }

		// @property (readonly, getter = getBdAddress, copy, nonatomic) NSString * bdAddress;
		[Export ("bdAddress")]
		string BdAddress { [Bind ("getBdAddress")] get; }
	}

	// @interface Epos2Discovery : NSObject
	[BaseType (typeof(NSObject))]
	interface Epos2Discovery
	{
		// +(int)start:(Epos2FilterOption *)filterOption delegate:(id<Epos2DiscoveryDelegate>)delegate;
		[Static]
		[Export ("start:delegate:")]
		int Start ([NullAllowed]Epos2FilterOption filterOption, Epos2DiscoveryDelegate @delegate);

		// +(int)stop;
		[Static]
		[Export ("stop")]
		int Stop();
	}

	// @interface Epos2Log : NSObject
	[BaseType (typeof(NSObject))]
	interface Epos2Log
	{
		// +(int)setLogSettings:(int)period output:(int)output ipAddress:(NSString *)ipAddress port:(int)port logSize:(int)logSize logLevel:(int)logLevel;
		[Static]
		[Export ("setLogSettings:output:ipAddress:port:logSize:logLevel:")]
		int SetLogSettings (int period, int output, [NullAllowed]string ipAddress, int port, int logSize, int logLevel);

		// +(NSString *)getSdkVersion;
		[Static]
		[Export ("getSdkVersion")]
		string GetSdkVersion();
	}

	// @interface Epos2BluetoothConnection : NSObject
	[BaseType (typeof(NSObject))]
	interface Epos2BluetoothConnection
	{
		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();

		// -(int)connectDevice:(NSMutableString *)target;
		[Export ("connectDevice:")]
		int ConnectDevice (NSMutableString target);

		// -(int)disconnectDevice:(NSString *)target;
		[Export ("disconnectDevice:")]
		int DisconnectDevice (string target);
	}
}
