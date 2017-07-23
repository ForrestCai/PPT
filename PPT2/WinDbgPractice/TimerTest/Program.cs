using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace TimerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
            SetupTimer();
            Console.WriteLine("Timer is setup.");
            Console.ReadKey();
            GC.Collect();
            Console.WriteLine("GC collected.");
            Console.ReadKey();
        }

        static void SetupTimer()
        {
            Timer timer = new Timer();
            timer.Interval = 5000;
            timer.Elapsed += timer_Elapsed;
            timer.Start();
        }

        static void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Elapsed");
        }
    }
}
