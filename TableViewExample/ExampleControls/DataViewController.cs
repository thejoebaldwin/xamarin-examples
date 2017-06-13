using System;

using UIKit;

namespace ExampleControls
{
    public partial class DataViewController : UIViewController
    {
        public string DataObject
        {
            get; set;
        }

        protected DataViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.

            //create the tableview contents
			string[] tableItems = new string[] { "Vegetables", "Fruits", "Flower Buds", "Legumes", "Bulbs", "Tubers" };
            //use the array contents to build the table view source
			ScheduleTableView.Source = new ScheduleTableViewSource(tableItems);

		}

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            dataLabel.Text = DataObject;
        }
    }
}
