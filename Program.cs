using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace CSharpTesting
{
    class Program
    {
        private static System.Timers.Timer aTimer;
        static void Main(string[] args)
        {
            Console.WriteLine("Test");

            SetTimer();

            Console.WriteLine();



            Console.ReadLine();
        }
        private static void SetTimer()
        {
            int TimesRun = 0;
            // Create a timer with a two second interval.
            aTimer = new System.Timers.Timer(2000);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }
        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Console.WriteLine("");
            Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}", e.SignalTime);
        }
    }
}
