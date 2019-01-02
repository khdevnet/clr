using System;
using System.Threading;

namespace CLR.DeadLock
{
    class Program
    {
        // Run code in Release mode.
        static void Main(string[] args)
        {
            object a = new { }, b = new { };
            new Thread(() => { lock (a) { Thread.Sleep(5); lock (b) { Console.WriteLine("Execute a."); } } }).Start();
            new Thread(() => { lock (b) { Thread.Sleep(5); lock (a) { Console.WriteLine("Execute b."); } } }).Start();

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
