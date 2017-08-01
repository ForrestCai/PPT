using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadSafe1
{
    class Program
    {
        static int count = 0;

        static void Main(string[] args)
        {
            var actions = new List<Action>();

            for (int i = 0; i < 1000; i++)
            {
                actions.Add(() => count++);
            }

            Parallel.Invoke(actions.ToArray());

            Console.Write(count);

            Console.ReadKey();
        }
    }
}
