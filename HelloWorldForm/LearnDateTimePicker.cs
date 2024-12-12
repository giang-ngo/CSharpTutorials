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
    public partial class LearnDateTimePicker : Form
    {
        public LearnDateTimePicker()
        {
            InitializeComponent();
            dateTimePicker.Value = new DateTime(2025, 1, 1, 15, 34, 26);
        }

        private void DateSelectedHandler(object sender, EventArgs e)
        {
            var selectedDateTime = dateTimePicker.Value;

            var dayOfWeek = selectedDateTime.DayOfWeek;

            //MessageBox.Show($"{dayOfWeek} {selectedDateTime}");

            var text = dateTimePicker.Text;

            MessageBox.Show(text);
        }

    }
}
