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
    public partial class LearnPictureBox : Form
    {
        public LearnPictureBox()
        {
            InitializeComponent();
            comboBoxSizeMode.SelectedIndex = comboBoxSizeMode.Items.Count - 1;
            comboBoxSelectedImage.SelectedIndex = 0;

        }

        private void SelectImageChangeHandler(object sender, EventArgs e)
        {
            var imageName = comboBoxSelectedImage.Text;
            var fullPath = @"C:\Image\" + imageName;
            var image = new Bitmap(fullPath);
            pictureBoxWallpaper.Image = image;
        }

        private void SizeModeChangeHandler(object sender, EventArgs e)
        {
            var sizeMode = comboBoxSizeMode.Text;
            if (sizeMode.CompareTo("AutoSize") == 0)
            {
                pictureBoxWallpaper.SizeMode = PictureBoxSizeMode.AutoSize;
            }
            else if (sizeMode.CompareTo("Zoom") == 0)
            {
                pictureBoxWallpaper.SizeMode = PictureBoxSizeMode.Zoom;

            }
            else if (sizeMode.CompareTo("CenterImage") == 0)
            {
                pictureBoxWallpaper.SizeMode = PictureBoxSizeMode.CenterImage;

            }
            else if (sizeMode.CompareTo("Normal") == 0)
            {
                pictureBoxWallpaper.SizeMode = PictureBoxSizeMode.Normal;

            }
            else if (sizeMode.CompareTo("StretchImage") == 0)
            {
                pictureBoxWallpaper.SizeMode = PictureBoxSizeMode.StretchImage;

            }
        }
    }
}
