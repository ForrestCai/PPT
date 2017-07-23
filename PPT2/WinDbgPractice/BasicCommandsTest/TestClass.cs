using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCommandsTest
{
    public class TestMethodClass
    {
        public static void StaticPrint(string message)
        {
            message = message ?? "Hello World!!!";
            Console.WriteLine(message);
        }

        public static void StaticPrint(string message1, string message2)
        {
            var message = message1 + message2;
            Console.WriteLine(message);
        }

        public void Print(string message)
        {
            message = message ?? "Hello World!!!";
            Console.WriteLine(message);
        }

        public void Print(string message1, string message2)
        {
            var message = message1 + message2;
            Console.WriteLine(message);
        }
    }

    public class TestFieldClass
    {
        private static TestMethodClass _testMethodClass = new TestMethodClass();

        private string name = "test";

        private int _number = 5;

        private int _id = 6;

        private short _short = 8;

        private bool _flag = true;
    }

    public class EmptyClass
    {
 
    }
}
