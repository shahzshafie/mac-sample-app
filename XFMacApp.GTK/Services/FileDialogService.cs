using Gtk;
using Xamarin.Forms;
using XFMacApp.Abstractionlayer.Services;
using XFMacApp.GTK.Services;

[assembly: Dependency(typeof(FileDialogService))]
namespace XFMacApp.GTK.Services
{
    public class FileDialogService : IFileDialogService
    {
        public FileDialogService()
        {
        }

        public void Open()
        {
            var fileChooser = new FileChooserDialog("Choose a file to open",
                                                                  GtkServices.Parent,
                                                                  FileChooserAction.Open,
                                                                  "Cancel", ResponseType.Cancel,
                                                                  "Open", ResponseType.Accept);
            
            if (fileChooser.Run() == (int)ResponseType.Accept)
            {
                System.IO.FileStream file = System.IO.File.OpenRead(fileChooser.Filename);
                file.Close();
            }

            fileChooser.Destroy();
        }
    }
}
