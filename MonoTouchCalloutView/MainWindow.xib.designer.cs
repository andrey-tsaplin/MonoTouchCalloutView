// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoTouchCalloutView {
	
	
	// Base type probably should be MonoTouch.Foundation.NSObject or subclass
	[MonoTouch.Foundation.Register("AppDelegate")]
	public partial class AppDelegate {
		
		#pragma warning disable 0169
		[MonoTouch.Foundation.Connect("window")]
		private MonoTouch.UIKit.UIWindow window {
			get {
				return ((MonoTouch.UIKit.UIWindow)(this.GetNativeField("window")));
			}
			set {
				this.SetNativeField("window", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("viewController")]
		private MonoTouch.UIKit.UIViewController viewController {
			get {
				return ((MonoTouch.UIKit.UIViewController)(this.GetNativeField("viewController")));
			}
			set {
				this.SetNativeField("viewController", value);
			}
		}
	}
	
	// Base type probably should be MonoTouch.UIKit.UIView or subclass
	[MonoTouch.Foundation.Register("TestView")]
	public partial class TestView {
	}
}
