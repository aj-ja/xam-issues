using System;
using Foundation;
using SafariServices;
using UIKit;

namespace TodoAzure.iOS
{
    public class iOSGoogleLogoutHelper : SFSafariViewControllerDelegate
    {
        public static void Logout(UIViewController controller)
        {
            var url = new NSUrl("https://www.google.com/accounts/Logout");
            var safari = new SFSafariViewController(url, false);
            safari.Delegate = new iOSGoogleLogoutHelper();
            controller.PresentViewController(safari, true, null);
        }

        public override void DidCompleteInitialLoad(SFSafariViewController controller, bool didLoadSuccessfully)
        {
            controller.DismissViewControllerAsync(true);
        }
    }
}
