using XFMacApp.GTK.Services;
using Gtk;
using Xamarin.Forms.Platform.GTK;
using Xamarin.Forms;

namespace XFMacApp.GTK
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Gtk.Application.Init();
            Forms.Init();

            var app = new App();
            var window = new FormsWindow();
            window.LoadApplication(app);
            window.SetApplicationTitle("Game of Life");
            window.Show();
            window.WindowPosition = WindowPosition.CenterAlways;

            GtkServices.Init(window);
            Gtk.Application.Run();
        }
    }
}