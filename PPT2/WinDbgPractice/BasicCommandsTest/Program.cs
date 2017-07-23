using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestLibarary;

namespace BasicCommandsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
            AutoResetEvent _event = new AutoResetEvent(false);
            TestMethodClass.StaticPrint("StaticPrint");

            TestMethodClass testMethodClass = new TestMethodClass();

            testMethodClass.Print("Print");

            int number = 30;

            EmptyClass eClass = new EmptyClass();

            var testFieldClass = new TestFieldClass();

            new Thread(() =>
            {
                lock (testFieldClass)
                {
                    _event.Set();
                    Console.WriteLine("Thread started");
                    Thread.Sleep(10000);
                }
            }).Start();

            _event.WaitOne();
            lock (testFieldClass)
            {

            }

            Helper.Print("Hello");

            Console.ReadKey();
        }
    }
}
