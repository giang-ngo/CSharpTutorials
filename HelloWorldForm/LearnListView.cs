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
    public partial class LearnListView : Form
    {
        public LearnListView()
        {
            InitializeComponent();
            AddImages();
            listView.Items[0].Focused = true;
            listView.Items[0].Selected = true;
        }

        private void AddImages()
        {
            var generalPath = @"C:\Image\";
            ImageList imageListSmall = new ImageList();
            imageListSmall.Images.Add(new Bitmap(generalPath + "anh1.jpg"));
            imageListSmall.Images.Add(new Bitmap(generalPath + "anh2.jpg"));
            imageListSmall.Images.Add(new Bitmap(generalPath + "anh3.jpg"));
            imageListSmall.Images.Add(new Bitmap(generalPath + "anh4.jpg"));
            imageListSmall.Images.Add(new Bitmap(generalPath + "anh5.jpg"));

            ImageList imageListLarge = new ImageList();
            imageListLarge.ImageSize = new Size(32, 32);
            imageListLarge.Images.Add(new Bitmap(generalPath + "anh1.jpg"));
            imageListLarge.Images.Add(new Bitmap(generalPath + "anh2.jpg"));
            imageListLarge.Images.Add(new Bitmap(generalPath + "anh3.jpg"));
            imageListLarge.Images.Add(new Bitmap(generalPath + "anh4.jpg"));
            imageListLarge.Images.Add(new Bitmap(generalPath + "anh5.jpg"));


            listView.SmallImageList = imageListSmall;
            listView.LargeImageList = imageListLarge;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
