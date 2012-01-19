using System;
using MonoTouch.UIKit;
using MonoTouch.Dialog;
using MonoTouch.Foundation;
using System.Text;

namespace MWC.iOS.UI.CustomElements
{
	/// <summary>
	/// Exhibitor element for MonoTouch.Dialog
	/// </summary>
	public class ExhibitorElement : Element, IElementSizing
	{
		/// <summary>
		/// Gets or sets the exhibitor.
		/// </summary>
		/// <value>
		/// The exhibitor that is used to populate the cell.
		/// </value>
		public BL.Exhibitor Exhibitor
		{
			get { return this._exhibitor; }
			set { this._exhibitor = value; }
		}
		protected BL.Exhibitor _exhibitor = null;
		
		/// <summary>
		/// Gets the reuse identifier
		/// </summary>
		protected override MonoTouch.Foundation.NSString CellKey
		{
			get { return _cellKey; }
		}
		static NSString _cellKey = new NSString("ExhibitorCell");
		
		public ExhibitorElement (BL.Exhibitor exhibitor) : base ("")
		{
			this._exhibitor = exhibitor;
		}
		
		public override MonoTouch.UIKit.UITableViewCell GetCell (MonoTouch.UIKit.UITableView tv)
		{
			// try and dequeue a cell object to reuse. if one doesn't exist, create a new one
			ExhibitorCell cell = tv.DequeueReusableCell(_cellKey) as ExhibitorCell;
			if(cell == null)
			{
				cell = new UI.CustomElements.ExhibitorCell(_exhibitor);
			}
			cell.UpdateCell(_exhibitor);

			return cell;
		}
		
		public float GetHeight (MonoTouch.UIKit.UITableView tableView, MonoTouch.Foundation.NSIndexPath indexPath)
		{
			return 65f;
		}
	
		public override void Selected (DialogViewController dvc, UITableView tableView, MonoTouch.Foundation.NSIndexPath path)
		{
			var eds = new MWC.iOS.Screens.iPhone.Exhibitors.ExhibitorDetailsScreen (_exhibitor.ID);
			dvc.ActivateController (eds);
		}	
	}
}
