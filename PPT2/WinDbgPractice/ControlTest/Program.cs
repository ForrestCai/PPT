using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace ControlTest
{
    class Program
    {
        static void Main(string[] args)
        {
            RichTextBox rtb1 = new RichTextBox();

            Thread thread = new Thread(delegate()
            {
                RichTextBox rtb = new RichTextBox();
                rtb.Rtf = @"{\rtf1\ansi\ansicpg1252\deff0\deflang1033{\fonttbl{\f0\fswiss\fcharset0 Arial;}";
                var plainText = rtb.Text;
            });

            Console.ReadKey();

            //thread.SetApartmentState(ApartmentState.STA);
            thread.Start();

            Console.ReadKey();
        }
    }
}
