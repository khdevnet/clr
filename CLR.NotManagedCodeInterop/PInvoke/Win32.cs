using System;
using System.Runtime.InteropServices;

namespace CLR.NotManagedCodeInterop.PInvoke
{
    public class Win32
    {
        [DllImport("Kernel32.dll")]
        public static extern void GetSystemTime(MySystemTime st);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int MessageBox(IntPtr hWnd, string text, string caption, int options);
    }
}
