using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadSafe3
{
    class Program
    {
        static int threadId;

        static void Main(string[] args)
        {
            var thread1 = new Thread(() => {                
                threadId = Thread.CurrentThread.ManagedThreadId;
                Thread.Sleep(10);
                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId}'s thread is is {threadId}");
            });

            var thread2 = new Thread(() => {
                threadId = Thread.CurrentThread.ManagedThreadId;
                Thread.Sleep(10);
                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId}'s thread is is {threadId}");
            });

            var thread3 = new Thread(() => {
                threadId = Thread.CurrentThread.ManagedThreadId;
                Thread.Sleep(10);
                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId}'s thread is is {threadId}");
            });

            var thread4 = new Thread(() => {
                threadId = Thread.CurrentThread.ManagedThreadId;
                Thread.Sleep(10);
                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId}'s thread is is {threadId}");
            });

            var thread5 = new Thread(() => {
                threadId = Thread.CurrentThread.ManagedThreadId;
                Thread.Sleep(10);
                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId}'s thread is is {threadId}");
            });

            var thread6 = new Thread(() => {
                threadId = Thread.CurrentThread.ManagedThreadId;
                Thread.Sleep(1000);
                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId}'s thread is is {threadId}");
            });

            thread1.Start();
            thread2.Start();
            thread3.Start();
            thread4.Start();
            thread5.Start();
            thread6.Start();

            Console.ReadKey();
        }
    }
}
