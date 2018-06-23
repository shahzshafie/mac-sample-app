
namespace XFMacApp.GTK.Services
{
    public class GtkServices
    {
        public static void Init(Gtk.Window parent)
        {
            Parent = parent;
        }

        public static Gtk.Window Parent { get; private set; }
    }
}