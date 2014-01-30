using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.UIKit;
using MonoTouch.Foundation;

namespace TablesDemo
{
	public class SpeakersViewController : UITableViewController
	{
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			string[] items = new string[] { "Miguel de Icaza", "Nat Friedman", "Bart Decrem", "Scott Hanselman" };
		
			//TODO: Step 1a: uncomment to set SpeakersTableSource as the TableView Source
			TableView.Source = new SpeakersTableSource (items);

		}

		// TODO: Step 1c: uncomment to fix overlap of first row by status bar for iOS 7
		public override void ViewDidLayoutSubviews ()
		{
			base.ViewDidLayoutSubviews ();

			// Establish offset of tableview by 20 px from the top.
			// NOTE:  TopLayoutGuide is only iOS 7, will crash on iOS 6

			if (UIDevice.CurrentDevice.CheckSystemVersion (7, 0) == true)
			{
				TableView.ContentInset = new UIEdgeInsets (this.TopLayoutGuide.Length, 0, 0, 0);
			}
		}
	}
}