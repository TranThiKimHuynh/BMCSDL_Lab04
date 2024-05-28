using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Lab04_Nhom
{
    public partial class LoginForm : Form
    {
        private SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-EO2BETF\YENVY;Initial Catalog=QLSVNhom;Integrated Security=True;");
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void bnt_SignIn_Click(object sender, EventArgs e)
        {
            string username = txt_Username.Text;
            string password = txt_Password.Text;



            try
            {
                



                String passMD5 = CalculateMD5Hash(password);
                String passSHA1 = CalculateSHA1Hash(password);
           

                String querry = "SELECT * FROM NHANVIEN WHERE TENDN = '" + username + "' AND MATKHAU = '" + passSHA1 + "'";

                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    username = txt_Username.Text;
                    password = txt_Password.Text;

                    MessageBox.Show("Đăng nhập thành công!");


                     // chuyển qua màn hình Quàn lý nhân viên
                      ManagerStaffForm managerStaffForm = new ManagerStaffForm();
                      managerStaffForm.username = username;
                      managerStaffForm.password = passSHA1;
                      managerStaffForm.Show();
                      this.Hide();




                }
                else
                {


                    querry = "SELECT * FROM SINHVIEN WHERE TENDN = '" + username + "' AND MATKHAU = '" + passMD5 + "'";

                    sda = new SqlDataAdapter(querry, conn);

                    dtable = new DataTable();
                    sda.Fill(dtable);

                    if (dtable.Rows.Count > 0)
                    {
                        username = txt_Username.Text;
                        password = txt_Password.Text;

                        MessageBox.Show("Đăng nhập thành công!");

                        // chuyển qua màn hình Quàn lý nhân viên
                        ManagerStaffForm managerStaffForm = new ManagerStaffForm();
                        managerStaffForm.username = username;
                        managerStaffForm.password = passSHA1;
                        managerStaffForm.Show();
                        this.Hide();

                    }
                    else
                    {

                        MessageBox.Show("Tên đăng nhập và mật khẩu không hợp lệ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_Username.Clear();
                        txt_Password.Clear();

                        // to focus username
                        txt_Username.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public static string CalculateMD5Hash(string input)
        {
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }



        public static string CalculateSHA1Hash(string input)
        {
            SHA1 sha1 = SHA1.Create();
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hash = sha1.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }


        private void bnt_Exit_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
}
