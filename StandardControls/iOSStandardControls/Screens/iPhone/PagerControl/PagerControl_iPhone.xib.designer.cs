// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Example_StandardControls.Screens.iPhone.PagerControl {
	
	
	// Base type probably should be MonoTouch.UIKit.UIViewController or subclass
	[MonoTouch.Foundation.Register("PagerControl_iPhone")]
	public partial class PagerControl_iPhone {
		
		private MonoTouch.UIKit.UIView __mt_view;
		
		private MonoTouch.UIKit.UIPageControl __mt_pgrMain;
		
		private MonoTouch.UIKit.UIScrollView __mt_scrlMain;
		
		#pragma warning disable 0169
		[MonoTouch.Foundation.Connect("view")]
		private MonoTouch.UIKit.UIView view {
			get {
				this.__mt_view = ((MonoTouch.UIKit.UIView)(this.GetNativeField("view")));
				return this.__mt_view;
			}
			set {
				this.__mt_view = value;
				this.SetNativeField("view", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("pgrMain")]
		private MonoTouch.UIKit.UIPageControl pgrMain {
			get {
				this.__mt_pgrMain = ((MonoTouch.UIKit.UIPageControl)(this.GetNativeField("pgrMain")));
				return this.__mt_pgrMain;
			}
			set {
				this.__mt_pgrMain = value;
				this.SetNativeField("pgrMain", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("scrlMain")]
		private MonoTouch.UIKit.UIScrollView scrlMain {
			get {
				this.__mt_scrlMain = ((MonoTouch.UIKit.UIScrollView)(this.GetNativeField("scrlMain")));
				return this.__mt_scrlMain;
			}
			set {
				this.__mt_scrlMain = value;
				this.SetNativeField("scrlMain", value);
			}
		}
	}
}