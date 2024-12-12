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

namespace HelloWorldForm
{
    public partial class LearnProgressBar : Form
    {
        public LearnProgressBar()
        {
            InitializeComponent();
        }

        private void StartPerformedHanlder(object sender, EventArgs e)
        {
            progressBar.Value = 0;
            button1.Enabled = false;
            new Thread(() => PerformedAction()) { IsBackground = true }.Start();
        }

        private void PerformedAction()
        {
            while (progressBar.Value < progressBar.Maximum)
            {
                progressBar.PerformStep();
                Thread.Sleep(1000);
            }
            button1.Enabled = true;
        }
    }
}
