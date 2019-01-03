using System;
using CLR.NotManagedCodeInterop.PInvoke;

namespace CLR.NotManagedCodeInterop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Run Win32 methods using PInvoke
            SystemTimeMessageBox.Show();

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
