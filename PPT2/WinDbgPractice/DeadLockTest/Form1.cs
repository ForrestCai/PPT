using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace DeadLockTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var thread = new Thread(new ThreadStart(() => {
                lock (this)
                {
                    Thread.Sleep(2000);

                    // Update memory.

                    this.Invoke(new MethodInvoker(() =>
                    {
                        this.label1.Text = "Sync succeed!";
                    }));
                }
            }));
            thread.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lock (this)
            {

            }
        }
    }
}
