using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateTest
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            Form1.Instance.OnSyncFinish += Instance_OnSyncFinish;
        }

        private void Instance_OnSyncFinish()
        {
            this.label1.Text = "Sync Finished!";
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void UnRegister()
        {
            Form1.Instance.OnSyncFinish -= Instance_OnSyncFinish;
        }

        ~UserControl1()
        {

        }
    }
}
