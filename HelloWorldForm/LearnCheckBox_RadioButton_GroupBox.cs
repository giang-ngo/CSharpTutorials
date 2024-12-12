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
    public partial class LearnCheckBox_RadioButton_GroupBox : Form
    {
        public LearnCheckBox_RadioButton_GroupBox()
        {
            InitializeComponent();
        }

        private void checkBoxClicked(object sender, EventArgs e)
        {
            if ((checkBox365.Checked || checkBox366.Checked) &&
                (!checkBox300.Checked && !checkBox360.Checked && !checkBox370.Checked))
            {
                MessageBox.Show("Đáp án chính xác!!");
            }
            else if (checkBox300.Checked || checkBox360.Checked || checkBox370.Checked)
            {
                MessageBox.Show("Đáp án không chính xác!!");
            }

        }

        private void radioBtnClicked(object sender, EventArgs e)
        {
            if (radioButton12.Checked)
            {
                MessageBox.Show($"Đúng rồi!!");
            }
            else
            {
                MessageBox.Show($"Sai rồi!!");

            }
        }
    }
}
