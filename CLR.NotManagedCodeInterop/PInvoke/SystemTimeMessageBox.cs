using System;

namespace CLR.NotManagedCodeInterop.PInvoke
{
    public static class SystemTimeMessageBox
    {
        public static void Show()
        {
            MySystemTime sysTime = new MySystemTime();
            Win32.GetSystemTime(sysTime);

            string dt;
            dt = "System time is: \n" +
                  "Year: " + sysTime.wYear + "\n" +
                  "Month: " + sysTime.wMonth + "\n" +
                  "DayOfWeek: " + sysTime.wDayOfWeek + "\n" +
                  "Day: " + sysTime.wDay;
            Win32.MessageBox(IntPtr.Zero, dt, "Platform Invoke Sample", 0);
        }
    }
}
