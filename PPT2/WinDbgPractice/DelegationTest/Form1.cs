using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateTest
{
    public delegate void SyncFinish();

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static readonly Form1 Instance = new Form1();

        public event SyncFinish OnSyncFinish;

        private void syncToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OnSyncFinish != null)
            {
                OnSyncFinish();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var testPanel = new UserControl1();
            testPanel.Dock = DockStyle.Right;
            this.Controls.Add(testPanel);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserControl1 testPanel = null;

            foreach (var control in this.Controls)
            {
                if (control is UserControl1)
                {
                    testPanel = control as UserControl1;
                    break;
                }                
            }

            if (testPanel != null)
            {
                this.Controls.Remove(testPanel);
                testPanel.Dispose();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            GC.Collect();
        }
    }
}
