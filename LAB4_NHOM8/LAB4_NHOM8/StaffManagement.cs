using LAB4_NHOM8;
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

namespace LAB4_NHOM8
{
    public partial class StaffManagement : Form
    {
        public string manv { get; set; }

        public string username { get; set; }

        public StaffManagement()
        {
            InitializeComponent();
        }

        private void btn_QLLH_Click(object sender, EventArgs e)
        {
            ClassManagement classManagement = new ClassManagement();
            classManagement.manv = manv;
            classManagement.username = username;
            classManagement.Show();
            Hide();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void StaffManagement_Load(object sender, EventArgs e)
        {
            txt_manv.Enabled = false;
            txt_hoten.Enabled = false;
            txt_email.Enabled = false;
            txt_luong.Enabled = false;
            txt_tendn.Enabled = false;
            txt_mk.Enabled = false;
            dataGridView1.Enabled = true;
            btn_QLLH.Enabled = true;
            btn_luu.Enabled = false;

            if (manv == "SYSAD")
            {
                btn_them.Enabled = true;
                btn_xoa.Enabled = true;
                btn_sua.Enabled = true;
            }
            else
            {
                btn_them.Enabled = false;
                btn_xoa.Enabled = false;
                btn_sua.Enabled = false;
            }

            DataTable dt = new DataTable();
            dt = DatabaseHandler.GetNhanVienInfo();

            foreach (DataRow dr in dt.Rows)
            {
                if (manv == dr["MANV"].ToString() && File.Exists(manv + "_PRIVATE_KEY.pem"))
                {
                    RSAEncryption decRSA = new RSAEncryption();
                    decRSA.LoadPrivateKey(manv + "_PRIVATE_KEY.pem");
                    dr["LUONG"] = decRSA.Decrypt(dr["LUONG"].ToString());
                    dataGridView1.Rows.Add(dr.ItemArray);
                }
                else
                {
                    dr["LUONG"] = "";
                    dataGridView1.Rows.Add(dr.ItemArray);
                }
                dataGridView1.ClearSelection();
            }

            txt_manv.Text = string.Empty;
            txt_hoten.Text = string.Empty;
            txt_email.Text = string.Empty;
            txt_luong.Text = string.Empty;
            txt_tendn.Text = string.Empty;
            txt_mk.Text = string.Empty;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txt_manv.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txt_hoten.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txt_email.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                if (txt_manv.Text.ToString() == manv)
                {
                    txt_luong.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                    txt_tendn.Text = username;
                }
                else
                {
                    txt_luong.Text = "*******";
                    txt_tendn.Text = "*******";
                }
                txt_mk.Text = "*******";
            }
        }

        private void btn_khong_Click(object sender, EventArgs e)
        {
            txt_manv.Enabled = false;
            txt_hoten.Enabled = false;
            txt_email.Enabled = false;
            txt_luong.Enabled = false;
            txt_tendn.Enabled = false;
            txt_mk.Enabled = false;
            dataGridView1.Enabled = true;
            btn_QLLH.Enabled = true;
            btn_luu.Enabled = false;

            if (manv == "SYSAD")
            {
                btn_them.Enabled = true;
                btn_xoa.Enabled = true;
                btn_sua.Enabled = true;
            }
            else
            {
                btn_them.Enabled = false;
                btn_xoa.Enabled = false;
                btn_sua.Enabled = false;
            }

            txt_manv.Text = string.Empty;
            txt_hoten.Text = string.Empty;
            txt_email.Text = string.Empty;
            txt_luong.Text = string.Empty;
            txt_tendn.Text = string.Empty;
            txt_mk.Text = string.Empty;

            dataGridView1.ClearSelection();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string del_manv = txt_manv.Text.ToString();
                if (del_manv == "SYSAD")
                {
                    MessageBox.Show("Người dùng mặc định không thể xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult dlg = MessageBox.Show($"Bạn có chắc chắn muốn xóa {del_manv}?", "Nhắc nhở", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dlg == DialogResult.Yes)
                    {
                        DatabaseHandler.DeleteNhanVien(del_manv);
                        dataGridView1.Rows.Clear();
                        dataGridView1.Refresh();
                        StaffManagement_Load(sender, e);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string upd_manv = txt_manv.Text.ToString();
                if (upd_manv == "SYSAD")
                {
                    MessageBox.Show("Người dùng mặc định không thể chỉnh sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    txt_manv.Enabled = true;
                    txt_hoten.Enabled = true;
                    txt_email.Enabled = true;
                    dataGridView1.Enabled = false;
                    btn_them.Enabled = false;
                    btn_xoa.Enabled = false;
                    btn_sua.Enabled = false;
                    btn_luu.Enabled = true;
                    btn_QLLH.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (txt_mk.Enabled == false) // SUA
            {
                string maNV = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string maNV_new = txt_manv.Text.ToString();
                string hoTen = txt_hoten.Text.ToString();
                string eMail = txt_email.Text.ToString();

                if (maNV_new == string.Empty || hoTen == string.Empty)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin Mã nhân viên và Họ tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult dlg = MessageBox.Show("Bạn có chắc chắn muốn cập nhật?", "Nhắc nhở", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dlg == DialogResult.Yes)
                    {
                        DatabaseHandler.UpdateNhanVien(maNV, maNV_new, hoTen, eMail);
                        dataGridView1.Rows.Clear();
                        dataGridView1.Refresh();
                        StaffManagement_Load(sender, e);
                    }
                }
            }
            else // THEM
            {
                string maNV = txt_manv.Text.ToString();
                string hoTen = txt_hoten.Text.ToString();
                string eMail = txt_email.Text.ToString();
                string luong = txt_luong.Text.ToString();
                string tenDN = txt_tendn.Text.ToString();
                string mk = txt_mk.Text.ToString();

                if (maNV == string.Empty || hoTen == string.Empty || tenDN == string.Empty || mk == string.Empty)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin Mã nhân viên, Họ tên, Tên đăng nhập và Mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult dlg = MessageBox.Show("Bạn có chắc chắn muốn thêm?", "Nhắc nhở", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dlg == DialogResult.Yes)
                    {
                        string pubKeyName = maNV + "_PUBLIC_KEY";
                        string priKeyName = maNV + "_PRIVATE_KEY";
                        RSAEncryption myrsa = new RSAEncryption();
                        string luong_cipher = myrsa.Encrypt(luong);
                        myrsa.SavePrivateKey(priKeyName + ".pem");
                        myrsa.SavePublicKey(pubKeyName + ".pem");

                        DatabaseHandler.InsertNhanVien(maNV, hoTen, eMail, luong_cipher, tenDN, Helper.HashSHA1(mk), pubKeyName);
                        dataGridView1.Rows.Clear();
                        dataGridView1.Refresh();
                        StaffManagement_Load(sender, e);
                    }
                }
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            txt_manv.Enabled = true;
            txt_hoten.Enabled = true;
            txt_email.Enabled = true;
            txt_luong.Enabled = true;
            txt_tendn.Enabled = true;
            txt_mk.Enabled = true;
            dataGridView1.Enabled = false;
            btn_them.Enabled = false;
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
            btn_luu.Enabled = true;
            btn_QLLH.Enabled = false;
            dataGridView1.ClearSelection();
            txt_manv.Text = string.Empty;
            txt_hoten.Text = string.Empty;
            txt_email.Text = string.Empty;
            txt_luong.Text = string.Empty;
            txt_tendn.Text = string.Empty;
            txt_mk.Text = string.Empty;
        }
    }
}
