using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldForm
{
    public partial class LearnButtonForm : Form
    {
        public LearnButtonForm()
        {
            InitializeComponent();
        }

        private void btnClick(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đã nhấn nút login");
        }

        private void mouseHoverEventHandler(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.Purple;
        }

        private void mouseDownEventHandler(object sender, MouseEventArgs e)
        {
            btnLogin.BackColor = Color.Red;
        }

        private void mouseUpEventHandler(object sender, MouseEventArgs e)
        {
            btnLogin.BackColor = Color.Green;
        }

        private void mouseLeaveEventHandler(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.Blue;

        }
    }
}
