using AppKit;
using Xamarin.Forms;
using XFMacApp.Abstractionlayer.Services;
using XFMacApp.Mac.AlertHelper;
using XFMacApp.Mac.Services;

[assembly: Dependency(typeof(FileDialogService))]

namespace XFMacApp.Mac.Services
{
    public class FileDialogService : IFileDialogService
    {
        public void Open()
        {
            var dlg = NSOpenPanel.OpenPanel;
            dlg.CanChooseFiles = false;
            dlg.CanChooseDirectories = true;
            //dlg.AllowedFileTypes = new string[] { "txt", "html", "md", "css" };

            var returnValue = dlg.RunModal();

            if (returnValue == 1)
            {
                // Nab the first file
                var url = dlg.Urls[0];

                if (url != null)
                {
                    var path = url.Path;
                    var alert = AlertManager.CreateAlert("Chosen Path", path, NSAlertStyle.Informational);
                    alert.RunSheetModal(XamMacService.ParentWindow);

                    // Create a new window to hold the text
                    //var newWindowController = new MainWindowController();
                    //newWindowController.Window.MakeKeyAndOrderFront(this);
                    XamMacService.ParentWindow.MakeKeyAndOrderFront(null);

                    // Load the text into the window
                    //var window = newWindowController.Window as MainWindow;
                    //window.Text = File.ReadAllText(path);
                    //window.SetTitleWithRepresentedFilename(Path.GetFileName(path));
                    //window.RepresentedUrl = url;

                    //XamMacService.ParentWindow.PerformTextFinderAction
                }
            }
            else
            {
                var alert = AlertManager.CreateAlert("Ops!", $"ops!!! {returnValue.ToString()}" , NSAlertStyle.Informational);
                alert.RunSheetModal(XamMacService.ParentWindow);
            }
        }
    }
}