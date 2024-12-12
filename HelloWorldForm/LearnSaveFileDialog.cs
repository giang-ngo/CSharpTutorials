using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldForm
{
    public partial class LearnSaveFileDialog : Form
    {
        public LearnSaveFileDialog()
        {
            InitializeComponent();
        }

        private void SaveFileHandler(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                saveFileDialog.Title = "Lưu file mới";
                var text = textBox.Text;
                var stream = saveFileDialog.OpenFile();
                var sw = new StreamWriter(stream);
                sw.Write(text);
                sw.Close();
                stream.Close();
                MessageBox.Show("Ghi file thành công", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox.Text = "";
            }
        }
    }
}
