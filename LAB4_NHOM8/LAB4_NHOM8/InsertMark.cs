using LAB4_NHOM8;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB4_NHOM8
{
    public partial class InsertMark : Form
    {
        public string manv { get; set; }

        public string username { get; set; }

        public string malop { get; set; }

        public string masv { get; set; }

        public InsertMark()
        {
            InitializeComponent();
        }

        private void btn_QLLH_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.manv = manv;
            student.username = username;
            student.malop = malop;
            student.Show();
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

        private void InsertMark_Load(object sender, EventArgs e)
        {
            txt_masv.Enabled = false;
            txt_hocphan.Enabled = false;
            txt_diem.Enabled = false;
            dataGridView1.Enabled = true;
            btn_QLLH.Enabled = true;
            btn_them.Enabled = true;
            btn_xoa.Enabled = true;
            btn_luu.Enabled = false;

            DataTable dt = new DataTable();
            dt = DatabaseHandler.GetBangDiem(masv);

            foreach (DataRow dr in dt.Rows)
            {
                if (File.Exists(manv + "_PRIVATE_KEY.pem"))
                {
                    RSAEncryption decRSA = new RSAEncryption();
                    decRSA.LoadPrivateKey(manv + "_PRIVATE_KEY.pem");
                    dr["DIEMTHI"] = decRSA.Decrypt(dr["DIEMTHI"].ToString());
                    dataGridView1.Rows.Add(dr.ItemArray);
                }
                else
                {
                    dr["DIEMTHI"] = "";
                    dataGridView1.Rows.Add(dr.ItemArray);
                }
                dataGridView1.ClearSelection();
            }

            txt_masv.Text = masv;
            txt_hocphan.Text = string.Empty;
            txt_diem.Text = string.Empty;
        }

        private void btn_khong_Click(object sender, EventArgs e)
        {
            txt_masv.Enabled = false;
            txt_hocphan.Enabled = false;
            txt_diem.Enabled = false;
            dataGridView1.Enabled = true;
            btn_QLLH.Enabled = true;
            btn_them.Enabled = true;
            btn_xoa.Enabled = true;
            btn_luu.Enabled = false;

            txt_masv.Text = masv;
            txt_hocphan.Text = string.Empty;
            txt_diem.Text = string.Empty;
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txt_masv.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txt_hocphan.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txt_diem.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string del_masv = txt_masv.Text.ToString();
                string del_hocphan = txt_hocphan.Text.ToString();
                DialogResult dlg = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Nhắc nhở", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg == DialogResult.Yes)
                {
                    DatabaseHandler.DeleteDiem(del_masv, del_hocphan);
                    dataGridView1.Rows.Clear();
                    dataGridView1.Refresh();
                    InsertMark_Load(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            txt_hocphan.Enabled = true;
            txt_diem.Enabled = true;

            dataGridView1.Enabled = false;
            btn_them.Enabled = false;
            btn_xoa.Enabled = false;
            btn_luu.Enabled = true;
            btn_QLLH.Enabled = false;
            dataGridView1.ClearSelection();
            txt_hocphan.Text = string.Empty;
            txt_diem.Text = string.Empty;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            string maSV = txt_masv.Text.ToString();
            string maHP = txt_hocphan.Text.ToString();
            string diem = txt_diem.Text.ToString();

            if (maSV == string.Empty || maHP == string.Empty || diem == string.Empty)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin Mã sinh viên, Mã học phần và Điểm thi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult dlg = MessageBox.Show("Bạn có chắc chắn muốn thêm?", "Nhắc nhở", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg == DialogResult.Yes)
                {
                    string pubKeyName = manv + "_PUBLIC_KEY";
                    if (File.Exists(pubKeyName + ".pem"))
                    {
                        RSAEncryption myrsa = new RSAEncryption();
                        myrsa.LoadPublicKey(pubKeyName + ".pem");
                        string diem_cipher = myrsa.Encrypt(diem);
                        DatabaseHandler.InsertDiem(maSV, maHP, diem_cipher);
                    }

                    dataGridView1.Rows.Clear();
                    dataGridView1.Refresh();
                    InsertMark_Load(sender, e);
                }
            }
        }
    }
}
