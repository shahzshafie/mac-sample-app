using AppKit;

namespace XFMacApp.Mac.Services
{
    public class XamMacService
    {
        public static void Init(NSWindow parent)
        {
            ParentWindow = parent;
        }

        public static NSWindow ParentWindow { get; private set; }
    }
}
