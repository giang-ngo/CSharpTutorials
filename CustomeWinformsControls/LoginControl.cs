using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomeWinformsControls
{
    public partial class LoginControl : UserControl
    {
        public TextBox TextBoxUserName { get => textBoxUsername; }
        public TextBox TextBoxPassword { get => textBoxPassword; }
        public LoginControl()
        {
            InitializeComponent();
        }

        public void SetUserName(string username)
        {
            textBoxUsername.Text = username;
        }

        public void SetPassword(string password)
        {
            textBoxPassword.Text = password;
        }

        public void Login()
        {

        }

        private void btnLoginClick(object sender, EventArgs e)
        {
            Login();
            MessageBox.Show("Đăng nhập thành công", "Thông báo", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
