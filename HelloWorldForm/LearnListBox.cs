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
    public partial class LearnListBox : Form
    {
        public LearnListBox()
        {
            InitializeComponent();
            var months = new string[]
            {
                "January",
                "February",
                "March",
                "April",
                "May",
                "June",
                "July",
                "August",
                "September",
                "October",
                "November",
                "December",
                "None"
            };
            //listBoxMonths.Items.AddRange(months);
            //listBoxMonths.SelectedItem = months[0];

            var listMonths = new List<string>(months);
            listBoxMonths.DataSource = listMonths;
            listBoxMonths.SelectedIndex = 0;
            //listBoxMonths.Items.Remove("None");
        }
        private void btnEventClick(object sender, EventArgs e)
        {
            var str = "";
            var selectedItems = listBoxMonths.SelectedItems;
            foreach (var item in selectedItems)
            {
                str += item.ToString() + "\n";
            }
            MessageBox.Show($"Bạn chọn: \n{str}");

        }
    }
}
