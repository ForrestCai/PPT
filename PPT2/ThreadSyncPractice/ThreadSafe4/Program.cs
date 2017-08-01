using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadSafe4
{
    class Program
    {
        static List<int> lists = new List<int>();
        static void Main(string[] args)
        {
            var actions = new List<Action>();

            for (int i = 0; i < 10000; i++)
            {
                actions.Add(() =>
                {
                    lists.Add(100);
                });

                //actions.Add(() =>
                //{
                //    lists.RemoveAt(0);
                //});
            }

            Parallel.Invoke(actions.ToArray());
            Console.Write(lists.Count);
            Console.ReadKey();
        }
    }
}
