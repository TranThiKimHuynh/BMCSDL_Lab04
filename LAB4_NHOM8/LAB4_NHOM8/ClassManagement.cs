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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LAB4_NHOM8
{
    public partial class ClassManagement : Form
    {
        public string manv { get; set; }

        public string username { get; set; }

        public ClassManagement()
        {
            InitializeComponent();
        }

        private void btn_QLNV_Click(object sender, EventArgs e)
        {
            StaffManagement staffManagement = new StaffManagement();
            staffManagement.manv = manv;
            staffManagement.username = username;
            staffManagement.Show();
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

        private void ClassManagement_Load(object sender, EventArgs e)
        {
            txt_malop.Enabled = false;
            txt_tenlop.Enabled = false;
            txt_nvql.Enabled = false;
            dataGridView1.Enabled = true;
            btn_QLNV.Enabled = true;
            btn_xemlop.Enabled = true;
            btn_luu.Enabled = false;

            if (manv == "SYSAD")
            {
                btn_sua.Enabled = true;
            }
            else
            {
                btn_sua.Enabled = false;
            }

            DataTable dt = new DataTable();
            dt = DatabaseHandler.GetLopInfo();

            foreach (DataRow dr in dt.Rows)
            {
                dataGridView1.Rows.Add(dr.ItemArray);
                dataGridView1.ClearSelection();
            }

            txt_malop.Text = string.Empty;
            txt_tenlop.Text = string.Empty;
            txt_nvql.Text = string.Empty;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txt_malop.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txt_tenlop.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txt_nvql.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            }
        }

        private void btn_khong_Click(object sender, EventArgs e)
        {
            txt_malop.Enabled = false;
            txt_tenlop.Enabled = false;
            txt_nvql.Enabled = false;
            dataGridView1.Enabled = true;
            btn_QLNV.Enabled = true;
            btn_xemlop.Enabled = true;
            btn_luu.Enabled = false;

            if (manv == "SYSAD")
            {
                btn_sua.Enabled = true;
            }
            else
            {
                btn_sua.Enabled = false;
            }

            txt_malop.Text = string.Empty;
            txt_tenlop.Text = string.Empty;
            txt_nvql.Text = string.Empty;

            dataGridView1.ClearSelection();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string upd_manv = txt_malop.Text.ToString();
                txt_nvql.Enabled = true;
                dataGridView1.Enabled = false;
                btn_sua.Enabled = false;
                btn_luu.Enabled = true;
                btn_QLNV.Enabled = false;
                btn_xemlop.Enabled = false;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn lớp học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            string maLop = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string nvql = txt_nvql.Text.ToString();
            DialogResult dlg = MessageBox.Show("Bạn có chắc chắn muốn cập nhật?", "Nhắc nhở", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                DatabaseHandler.UpdateLop(maLop, nvql);
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                ClassManagement_Load(sender, e);
            }
        }

        private void btn_xemlop_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Student student = new Student();
                student.manv = manv;
                student.username = username;
                student.malop = txt_malop.Text;
                student.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn lớp học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
