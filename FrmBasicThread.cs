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

namespace BasicThreading
{
    public partial class FrmBasicThread : Form
{
        private Thread ThreadA, ThreadB;

        public FrmBasicThread()
        {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            ThreadStart delThread = new ThreadStart(MyThreadClass.Thread1);
            ThreadA = new Thread(delThread);
            ThreadA.Name = "Thread A Process";
            ThreadB = new Thread(delThread);
            ThreadB.Name = "Thread B Process";

            ThreadA.Start();
            ThreadB.Start();

            ThreadA.Join();
            ThreadB.Join();
            label1.Text = (" -End of Thread- ");
            Console.WriteLine("End of Thread");
        }

        private void FrmBasicThread_Load(object sender, EventArgs e)
        {

        }
    }
}
