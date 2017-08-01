using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadSafe2
{
    class Program
    {
        static List<int> lists = new List<int>();
        static void Main(string[] args)
        {
            var actions = new List<Action>();

            for (int i = 0; i < 1000; i++)
            {
                actions.Add(() =>
                {
                    lists.Add(100);
                });

                actions.Add(() =>
                {
                    foreach (var l in lists)
                    {
                        Console.WriteLine(i);
                    }
                });
            }

            Parallel.Invoke(actions.ToArray());
            Console.ReadKey();
        }
    }
}
