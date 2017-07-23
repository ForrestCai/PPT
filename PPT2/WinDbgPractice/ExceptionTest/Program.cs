using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.ReadKey();
                    try
                    {
                        object x = null;
                        x.ToString();
                    }
                    catch (Exception e)
                    {
                        throw e;
                    }
                }
                catch (Exception e)
                {
                    //Console.WriteLine(e.Message);
                }
            }
            Console.ReadKey();
        }
    }
}
