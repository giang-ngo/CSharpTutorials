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
    public partial class LearnComboBox : Form
    {
        public List<string> Brands { get; set; } = new List<string>(new string[]
        {
            "Toyota",
            "Honda",
            "Hyundai",
            "Kia",
            "Mazda",
            "VinFast",
            "Ford",
            "Mitsubishi",
            "Suzuki",
            "Mercedes-Benz",
        });
        public LearnComboBox()
        {
            InitializeComponent();
            //comboBoxBrands.DataSource = Brands;
            comboBoxBrands.SelectedIndex = 0;
            foreach (var brand in Brands)
            {
                if (!comboBoxBrands.Items.Contains(brand)) // Kiểm tra trùng
                {
                    comboBoxBrands.Items.Add(brand); // Thêm mục nếu chưa tồn tại
                }
            }

            comboBoxBrands.Items.Remove("BMW");// xóa
            comboBoxBrands.Items.Insert(0, "TESLA");

            var length = comboBoxBrands.Items.Count;
        }

        private void btnEventClick(object sender, EventArgs e)
        {
            MessageBox.Show($"Bạn chọn hãng xe: {comboBoxBrands.SelectedItem}");
        }

        private void addEventClick(object sender, EventArgs e)
        {
            comboBoxBrands.Items.Add(textBoxBrand.Text);
            textBoxBrand.Text = "";
        }
    }
}
