using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CrashTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Read();
            Thread thread = new Thread(delegate()
            {
                object x = null;
                x.ToString();
            });

            thread.Start();

            //Task.Factory.StartNew(delegate() {
            //    object x = null;
            //    x.ToString();
            //});
            Console.ReadKey();
        }
    }
}
