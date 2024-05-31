using LAB4_NHOM8;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB4_NHOM8
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_SignIn_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txt_username.Text;
                string password = Helper.HashSHA1(txt_password.Text);

                if (DatabaseHandler.IsSignIn(username, password))
                {
                    StaffManagement staffManagement = new StaffManagement();
                    staffManagement.manv = DatabaseHandler.GetMANV(username);
                    staffManagement.username = username;
                    staffManagement.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập và mật khẩu không hợp lệ!", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_username.Clear();
                    txt_password.Clear();
                    txt_username.Focus();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
