namespace LAB4_NHOM8
{
    partial class Student
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_title = new System.Windows.Forms.Label();
            this.btn_QLLH = new System.Windows.Forms.Button();
            this.btn_nhapdiem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dt_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.txt_malop = new System.Windows.Forms.TextBox();
            this.label_malop = new System.Windows.Forms.Label();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.label_diachi = new System.Windows.Forms.Label();
            this.label_ngaysinh = new System.Windows.Forms.Label();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.label_hoten = new System.Windows.Forms.Label();
            this.txt_masv = new System.Windows.Forms.TextBox();
            this.label_masv = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MASV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_khong = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label_title.Location = new System.Drawing.Point(314, 35);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(352, 29);
            this.label_title.TabIndex = 3;
            this.label_title.Text = "DANH SÁCH SINH VIÊN LỚP";
            // 
            // btn_QLLH
            // 
            this.btn_QLLH.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_QLLH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_QLLH.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_QLLH.Location = new System.Drawing.Point(12, 18);
            this.btn_QLLH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_QLLH.Name = "btn_QLLH";
            this.btn_QLLH.Size = new System.Drawing.Size(189, 46);
            this.btn_QLLH.TabIndex = 4;
            this.btn_QLLH.Text = "Quản lý Lớp học";
            this.btn_QLLH.UseVisualStyleBackColor = false;
            this.btn_QLLH.Click += new System.EventHandler(this.btn_QLLH_Click);
            // 
            // btn_nhapdiem
            // 
            this.btn_nhapdiem.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_nhapdiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_nhapdiem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_nhapdiem.Location = new System.Drawing.Point(740, 18);
            this.btn_nhapdiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_nhapdiem.Name = "btn_nhapdiem";
            this.btn_nhapdiem.Size = new System.Drawing.Size(189, 46);
            this.btn_nhapdiem.TabIndex = 5;
            this.btn_nhapdiem.Text = "Nhập Điểm";
            this.btn_nhapdiem.UseVisualStyleBackColor = false;
            this.btn_nhapdiem.Click += new System.EventHandler(this.btn_nhapdiem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.dt_ngaysinh);
            this.groupBox1.Controls.Add(this.txt_malop);
            this.groupBox1.Controls.Add(this.label_malop);
            this.groupBox1.Controls.Add(this.txt_diachi);
            this.groupBox1.Controls.Add(this.label_diachi);
            this.groupBox1.Controls.Add(this.label_ngaysinh);
            this.groupBox1.Controls.Add(this.txt_hoten);
            this.groupBox1.Controls.Add(this.label_hoten);
            this.groupBox1.Controls.Add(this.txt_masv);
            this.groupBox1.Controls.Add(this.label_masv);
            this.groupBox1.Location = new System.Drawing.Point(12, 100);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(917, 164);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sinh viên";
            // 
            // dt_ngaysinh
            // 
            this.dt_ngaysinh.Enabled = false;
            this.dt_ngaysinh.Location = new System.Drawing.Point(185, 78);
            this.dt_ngaysinh.Name = "dt_ngaysinh";
            this.dt_ngaysinh.Size = new System.Drawing.Size(240, 22);
            this.dt_ngaysinh.TabIndex = 12;
            // 
            // txt_malop
            // 
            this.txt_malop.Enabled = false;
            this.txt_malop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txt_malop.Location = new System.Drawing.Point(644, 121);
            this.txt_malop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_malop.Name = "txt_malop";
            this.txt_malop.Size = new System.Drawing.Size(240, 24);
            this.txt_malop.TabIndex = 11;
            // 
            // label_malop
            // 
            this.label_malop.AutoSize = true;
            this.label_malop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label_malop.Location = new System.Drawing.Point(528, 126);
            this.label_malop.Name = "label_malop";
            this.label_malop.Size = new System.Drawing.Size(59, 18);
            this.label_malop.TabIndex = 10;
            this.label_malop.Text = "Mã lớp";
            // 
            // txt_diachi
            // 
            this.txt_diachi.Enabled = false;
            this.txt_diachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txt_diachi.Location = new System.Drawing.Point(644, 74);
            this.txt_diachi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(240, 24);
            this.txt_diachi.TabIndex = 7;
            // 
            // label_diachi
            // 
            this.label_diachi.AutoSize = true;
            this.label_diachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label_diachi.Location = new System.Drawing.Point(528, 78);
            this.label_diachi.Name = "label_diachi";
            this.label_diachi.Size = new System.Drawing.Size(60, 18);
            this.label_diachi.TabIndex = 6;
            this.label_diachi.Text = "Địa chỉ";
            // 
            // label_ngaysinh
            // 
            this.label_ngaysinh.AutoSize = true;
            this.label_ngaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label_ngaysinh.Location = new System.Drawing.Point(27, 78);
            this.label_ngaysinh.Name = "label_ngaysinh";
            this.label_ngaysinh.Size = new System.Drawing.Size(82, 18);
            this.label_ngaysinh.TabIndex = 4;
            this.label_ngaysinh.Text = "Ngày sinh";
            // 
            // txt_hoten
            // 
            this.txt_hoten.Enabled = false;
            this.txt_hoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txt_hoten.Location = new System.Drawing.Point(644, 25);
            this.txt_hoten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(240, 24);
            this.txt_hoten.TabIndex = 3;
            // 
            // label_hoten
            // 
            this.label_hoten.AutoSize = true;
            this.label_hoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label_hoten.Location = new System.Drawing.Point(528, 28);
            this.label_hoten.Name = "label_hoten";
            this.label_hoten.Size = new System.Drawing.Size(58, 18);
            this.label_hoten.TabIndex = 2;
            this.label_hoten.Text = "Họ tên";
            // 
            // txt_masv
            // 
            this.txt_masv.Enabled = false;
            this.txt_masv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txt_masv.Location = new System.Drawing.Point(185, 27);
            this.txt_masv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_masv.Name = "txt_masv";
            this.txt_masv.Size = new System.Drawing.Size(240, 24);
            this.txt_masv.TabIndex = 1;
            // 
            // label_masv
            // 
            this.label_masv.AutoSize = true;
            this.label_masv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label_masv.Location = new System.Drawing.Point(27, 28);
            this.label_masv.Name = "label_masv";
            this.label_masv.Size = new System.Drawing.Size(102, 18);
            this.label_masv.TabIndex = 0;
            this.label_masv.Text = "Mã sinh viên";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 287);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(917, 239);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MASV,
            this.HOTEN,
            this.NGAYSINH,
            this.DIACHI});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(30, 20);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(854, 200);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // MASV
            // 
            this.MASV.HeaderText = "MÃ SINH VIÊN";
            this.MASV.MinimumWidth = 6;
            this.MASV.Name = "MASV";
            this.MASV.ReadOnly = true;
            // 
            // HOTEN
            // 
            this.HOTEN.FillWeight = 150F;
            this.HOTEN.HeaderText = "HỌ TÊN";
            this.HOTEN.MinimumWidth = 6;
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.ReadOnly = true;
            // 
            // NGAYSINH
            // 
            this.NGAYSINH.HeaderText = "NGÀY SINH";
            this.NGAYSINH.MinimumWidth = 6;
            this.NGAYSINH.Name = "NGAYSINH";
            this.NGAYSINH.ReadOnly = true;
            // 
            // DIACHI
            // 
            this.DIACHI.FillWeight = 150F;
            this.DIACHI.HeaderText = "ĐỊA CHỈ";
            this.DIACHI.MinimumWidth = 6;
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.ReadOnly = true;
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.Red;
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_thoat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_thoat.Location = new System.Drawing.Point(637, 539);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(133, 36);
            this.btn_thoat.TabIndex = 17;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_sua.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_sua.Location = new System.Drawing.Point(179, 539);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(133, 36);
            this.btn_sua.TabIndex = 16;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_khong
            // 
            this.btn_khong.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_khong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_khong.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_khong.Location = new System.Drawing.Point(484, 539);
            this.btn_khong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_khong.Name = "btn_khong";
            this.btn_khong.Size = new System.Drawing.Size(133, 36);
            this.btn_khong.TabIndex = 19;
            this.btn_khong.Text = "Không";
            this.btn_khong.UseVisualStyleBackColor = false;
            this.btn_khong.Click += new System.EventHandler(this.btn_khong_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_luu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_luu.Location = new System.Drawing.Point(331, 539);
            this.btn_luu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(133, 36);
            this.btn_luu.TabIndex = 18;
            this.btn_luu.Text = "Ghi/Lưu";
            this.btn_luu.UseVisualStyleBackColor = false;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 590);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_khong);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_nhapdiem);
            this.Controls.Add(this.btn_QLLH);
            this.Controls.Add(this.label_title);
            this.Name = "Student";
            this.Text = "Sinh Viên Lớp";
            this.Load += new System.EventHandler(this.Student_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Button btn_QLLH;
        private System.Windows.Forms.Button btn_nhapdiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_malop;
        private System.Windows.Forms.Label label_malop;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.Label label_diachi;
        private System.Windows.Forms.Label label_ngaysinh;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.Label label_hoten;
        private System.Windows.Forms.TextBox txt_masv;
        private System.Windows.Forms.Label label_masv;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_khong;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.DateTimePicker dt_ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHI;
    }
}