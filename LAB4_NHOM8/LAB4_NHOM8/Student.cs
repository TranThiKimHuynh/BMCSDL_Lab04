using LAB4_NHOM8;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB4_NHOM8
{
    public partial class Student : Form
    {
        public string manv { get; set; }

        public string username { get; set; }

        public string malop { get; set; }

        public Student()
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

        private void Student_Load(object sender, EventArgs e)
        {
            txt_masv.Enabled = false;
            txt_hoten.Enabled = false;
            dt_ngaysinh.Enabled = false;
            txt_diachi.Enabled = false;
            txt_malop.Enabled = false;
            dataGridView1.Enabled = true;
            btn_QLLH.Enabled = true;
            btn_luu.Enabled = false;
            dataGridView1.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";

            if (manv == DatabaseHandler.GetNVQL(malop))
            {
                btn_sua.Enabled = true;
                btn_nhapdiem.Enabled = true;
            }
            else
            {
                btn_sua.Enabled = false;
                btn_nhapdiem.Enabled = false;
            }

            DataTable dt = new DataTable();
            dt = DatabaseHandler.GetSinhVienLopInfo(malop);

            foreach (DataRow dr in dt.Rows)
            {
                dataGridView1.Rows.Add(dr.ItemArray);
                dataGridView1.ClearSelection();
            }

            txt_masv.Text = string.Empty;
            txt_hoten.Text = string.Empty;
            txt_diachi.Text = string.Empty;
            txt_malop.Text = malop;
            dt_ngaysinh.Value = DateTime.ParseExact("01/01/1753", "dd/MM/yyyy", CultureInfo.InvariantCulture);
        }

        private void btn_khong_Click(object sender, EventArgs e)
        {
            txt_masv.Enabled = false;
            txt_hoten.Enabled = false;
            dt_ngaysinh.Enabled = false;
            txt_diachi.Enabled = false;
            txt_malop.Enabled = false;
            dataGridView1.Enabled = true;
            btn_QLLH.Enabled = true;
            btn_luu.Enabled = false;
            dataGridView1.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";

            if (manv == DatabaseHandler.GetNVQL(malop))
            {
                btn_sua.Enabled = true;
                btn_nhapdiem.Enabled = true;
            }
            else
            {
                btn_sua.Enabled = false;
                btn_nhapdiem.Enabled = false;
            }

            txt_masv.Text = string.Empty;
            txt_hoten.Text = string.Empty;
            txt_diachi.Text = string.Empty;
            txt_malop.Text = malop;
            dt_ngaysinh.Value = DateTime.ParseExact("01/01/1753", "dd/MM/yyyy", CultureInfo.InvariantCulture);

            dataGridView1.ClearSelection();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txt_masv.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txt_hoten.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txt_diachi.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                string dateStr = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

                if (dateStr == string.Empty)
                {
                    dt_ngaysinh.Value = DateTime.ParseExact("01/01/1753", "dd/MM/yyyy", CultureInfo.InvariantCulture);
                }
                else
                {
                    dt_ngaysinh.Value = DateTime.Parse(dateStr);
                }
            }
        }

        private void btn_nhapdiem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                InsertMark insertMark = new InsertMark();
                insertMark.manv = manv;
                insertMark.username = username;
                insertMark.malop = malop;
                insertMark.masv = txt_masv.Text;
                insertMark.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txt_masv.Enabled = true;
                txt_hoten.Enabled = true;
                dt_ngaysinh.Enabled = true;
                txt_diachi.Enabled = true;
                dataGridView1.Enabled = false;
                btn_sua.Enabled = false;
                btn_luu.Enabled = true;
                btn_QLLH.Enabled = false;
                btn_nhapdiem.Enabled = false;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            string maSV = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string maSV_new = txt_masv.Text.ToString();
            string hoTen = txt_hoten.Text.ToString();
            string diaChi = txt_diachi.Text.ToString();
            string ngaySinh = dt_ngaysinh.Text.ToString();
            var dt = Convert.ToDateTime(ngaySinh);
            ngaySinh = dt.ToString("MM/dd/yyyy");

            if (maSV_new == string.Empty || hoTen == string.Empty)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin Mã sinh viên và Họ tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult dlg = MessageBox.Show("Bạn có chắc chắn muốn cập nhật?", "Nhắc nhở", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg == DialogResult.Yes)
                {
                    DatabaseHandler.UpdateSinhVien(maSV, maSV_new, hoTen, ngaySinh, diaChi);
                    dataGridView1.Rows.Clear();
                    dataGridView1.Refresh();
                    Student_Load(sender, e);
                }
            }
        }
    }
}
