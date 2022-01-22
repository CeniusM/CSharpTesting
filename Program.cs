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
<<<<<<< HEAD
=======
            Console.WriteLine("Test");

            SetTimer();
            int SecondsGoneBy = 0;

            Console.WriteLine();



>>>>>>> 48399d3d2f6cb733790d22803b3feaa3e95bdb3a
            Console.ReadLine();
        }
        private static void SetTimer()
        {
            // Create a timer with a two second interval.
            aTimer = new System.Timers.Timer(1000);
            // Hook up the Elapsed event for the timer.
            aTimer.Elapsed += OnTimedEvent;
            aTimer.Elapsed += OnTimedEvent2;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }
        private static void OnTimedEvent2(Object source, ElapsedEventArgs e)
        {
            Console.WriteLine("");
            Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}", e.SignalTime);
        }
        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            // Console.WriteLine("");
            // Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}", e.SignalTime);
        }
    }
}
