using Foundation;

namespace MyCalc
{
	// @interface mycalc : NSObject
	[BaseType (typeof(NSObject))]
	interface mycalc
	{
		// -(int)add:(int)a second:(int)b;
		[Export ("add:second:")]
		int Add (int a, int b);
	}
}
