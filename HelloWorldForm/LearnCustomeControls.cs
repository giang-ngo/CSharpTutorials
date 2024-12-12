using CustomeWinformsControls;
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
    public partial class LearnCustomeControls : Form
    {
        public LearnCustomeControls()
        {
            InitializeComponent();
            loginControl1.SetUserName("admin");
        }
    }
}
