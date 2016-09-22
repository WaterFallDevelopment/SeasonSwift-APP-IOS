using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UIKit;
using Foundation;

namespace SeasonSwift
{
    class HomeViewController : UITableViewController
    {
        public HomeViewController() {  }

        private string[] options =
        {
            "Request Service",
            "View Job History",
            "Edit Scheduale"
        };

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            this.View.BackgroundColor = UIColor.White;

            this.Title = "SeasonSwift";

            this.NavigationController.NavigationBar.BarTintColor = UIColor.FromRGB(73, 205, 192);

            this.NavigationController.NavigationBar.TitleTextAttributes = new UIStringAttributes() { ForegroundColor = UIColor.White };
        }
    }
}