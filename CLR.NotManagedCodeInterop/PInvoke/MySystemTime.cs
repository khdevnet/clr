using System.Runtime.InteropServices;

namespace CLR.NotManagedCodeInterop.PInvoke
{
    [StructLayout(LayoutKind.Sequential)]
    public class MySystemTime
    {
        public ushort wYear;
        public ushort wMonth;
        public ushort wDayOfWeek;
        public ushort wDay;
        public ushort wHour;
        public ushort wMinute;
        public ushort wSecond;
        public ushort wMilliseconds;
    }
}
