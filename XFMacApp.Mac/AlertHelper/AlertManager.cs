using AppKit;

namespace XFMacApp.Mac.AlertHelper
{
    public class AlertManager
    {
        public static NSAlert CreateAlert(string title, string message, NSAlertStyle style)
        {
            var alert = new NSAlert();
            alert.AlertStyle = style;
            alert.InformativeText = message;
            alert.MessageText = title;
            return alert;
        }
    }
}
