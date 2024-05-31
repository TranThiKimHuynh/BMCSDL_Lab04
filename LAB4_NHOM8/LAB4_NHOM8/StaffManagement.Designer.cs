namespace LAB4_NHOM8
{
    partial class StaffManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_mk = new System.Windows.Forms.TextBox();
            this.label_mk = new System.Windows.Forms.Label();
            this.txt_tendn = new System.Windows.Forms.TextBox();
            this.label_tendn = new System.Windows.Forms.Label();
            this.txt_luong = new System.Windows.Forms.TextBox();
            this.label_luong = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label_email = new System.Windows.Forms.Label();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.label_hoten = new System.Windows.Forms.Label();
            this.txt_manv = new System.Windows.Forms.TextBox();
            this.label_manv = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_title = new System.Windows.Forms.Label();
            this.btn_QLLH = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_khong = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.txt_mk);
            this.groupBox1.Controls.Add(this.label_mk);
            this.groupBox1.Controls.Add(this.txt_tendn);
            this.groupBox1.Controls.Add(this.label_tendn);
            this.groupBox1.Controls.Add(this.txt_luong);
            this.groupBox1.Controls.Add(this.label_luong);
            this.groupBox1.Controls.Add(this.txt_email);
            this.groupBox1.Controls.Add(this.label_email);
            this.groupBox1.Controls.Add(this.txt_hoten);
            this.groupBox1.Controls.Add(this.label_hoten);
            this.groupBox1.Controls.Add(this.txt_manv);
            this.groupBox1.Controls.Add(this.label_manv);
            this.groupBox1.Location = new System.Drawing.Point(12, 81);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(917, 164);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // txt_mk
            // 
            this.txt_mk.Enabled = false;
            this.txt_mk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txt_mk.Location = new System.Drawing.Point(644, 121);
            this.txt_mk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_mk.Name = "txt_mk";
            this.txt_mk.Size = new System.Drawing.Size(240, 24);
            this.txt_mk.TabIndex = 11;
            // 
            // label_mk
            // 
            this.label_mk.AutoSize = true;
            this.label_mk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label_mk.Location = new System.Drawing.Point(528, 126);
            this.label_mk.Name = "label_mk";
            this.label_mk.Size = new System.Drawing.Size(77, 18);
            this.label_mk.TabIndex = 10;
            this.label_mk.Text = "Mật khẩu";
            // 
            // txt_tendn
            // 
            this.txt_tendn.Enabled = false;
            this.txt_tendn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txt_tendn.Location = new System.Drawing.Point(185, 123);
            this.txt_tendn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tendn.Name = "txt_tendn";
            this.txt_tendn.Size = new System.Drawing.Size(240, 24);
            this.txt_tendn.TabIndex = 9;
            // 
            // label_tendn
            // 
            this.label_tendn.AutoSize = true;
            this.label_tendn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label_tendn.Location = new System.Drawing.Point(27, 126);
            this.label_tendn.Name = "label_tendn";
            this.label_tendn.Size = new System.Drawing.Size(118, 18);
            this.label_tendn.TabIndex = 8;
            this.label_tendn.Text = "Tên đăng nhập";
            // 
            // txt_luong
            // 
            this.txt_luong.Enabled = false;
            this.txt_luong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txt_luong.Location = new System.Drawing.Point(644, 74);
            this.txt_luong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_luong.Name = "txt_luong";
            this.txt_luong.Size = new System.Drawing.Size(240, 24);
            this.txt_luong.TabIndex = 7;
            // 
            // label_luong
            // 
            this.label_luong.AutoSize = true;
            this.label_luong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label_luong.Location = new System.Drawing.Point(528, 78);
            this.label_luong.Name = "label_luong";
            this.label_luong.Size = new System.Drawing.Size(54, 18);
            this.label_luong.TabIndex = 6;
            this.label_luong.Text = "Lương";
            // 
            // txt_email
            // 
            this.txt_email.Enabled = false;
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txt_email.Location = new System.Drawing.Point(185, 74);
            this.txt_email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(240, 24);
            this.txt_email.TabIndex = 5;
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label_email.Location = new System.Drawing.Point(27, 78);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(50, 18);
            this.label_email.TabIndex = 4;
            this.label_email.Text = "Email";
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
            // txt_manv
            // 
            this.txt_manv.Enabled = false;
            this.txt_manv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txt_manv.Location = new System.Drawing.Point(185, 27);
            this.txt_manv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_manv.Name = "txt_manv";
            this.txt_manv.Size = new System.Drawing.Size(240, 24);
            this.txt_manv.TabIndex = 1;
            // 
            // label_manv
            // 
            this.label_manv.AutoSize = true;
            this.label_manv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label_manv.Location = new System.Drawing.Point(27, 28);
            this.label_manv.Name = "label_manv";
            this.label_manv.Size = new System.Drawing.Size(107, 18);
            this.label_manv.TabIndex = 0;
            this.label_manv.Text = "Mã nhân viên";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 272);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(917, 239);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MANV,
            this.HOTEN,
            this.EMAIL,
            this.LUONG});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle14;
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
            // MANV
            // 
            this.MANV.HeaderText = "MÃ NHÂN VIÊN";
            this.MANV.MinimumWidth = 6;
            this.MANV.Name = "MANV";
            this.MANV.ReadOnly = true;
            // 
            // HOTEN
            // 
            this.HOTEN.FillWeight = 150F;
            this.HOTEN.HeaderText = "HỌ TÊN";
            this.HOTEN.MinimumWidth = 6;
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.ReadOnly = true;
            // 
            // EMAIL
            // 
            this.EMAIL.FillWeight = 150F;
            this.EMAIL.HeaderText = "EMAIL";
            this.EMAIL.MinimumWidth = 6;
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.ReadOnly = true;
            // 
            // LUONG
            // 
            this.LUONG.HeaderText = "LƯƠNG";
            this.LUONG.MinimumWidth = 6;
            this.LUONG.Name = "LUONG";
            this.LUONG.ReadOnly = true;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label_title.Location = new System.Drawing.Point(317, 28);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(269, 29);
            this.label_title.TabIndex = 2;
            this.label_title.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // btn_QLLH
            // 
            this.btn_QLLH.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_QLLH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_QLLH.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_QLLH.Location = new System.Drawing.Point(739, 12);
            this.btn_QLLH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_QLLH.Name = "btn_QLLH";
            this.btn_QLLH.Size = new System.Drawing.Size(189, 46);
            this.btn_QLLH.TabIndex = 3;
            this.btn_QLLH.Text = "Quản lý Lớp học";
            this.btn_QLLH.UseVisualStyleBackColor = false;
            this.btn_QLLH.Click += new System.EventHandler(this.btn_QLLH_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_them.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_them.Location = new System.Drawing.Point(20, 526);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(133, 36);
            this.btn_them.TabIndex = 4;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_xoa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_xoa.Location = new System.Drawing.Point(171, 526);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(133, 36);
            this.btn_xoa.TabIndex = 5;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_sua.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_sua.Location = new System.Drawing.Point(323, 526);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(133, 36);
            this.btn_sua.TabIndex = 6;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.Red;
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_thoat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_thoat.Location = new System.Drawing.Point(781, 526);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(133, 36);
            this.btn_thoat.TabIndex = 7;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_luu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_luu.Location = new System.Drawing.Point(475, 526);
            this.btn_luu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(133, 36);
            this.btn_luu.TabIndex = 8;
            this.btn_luu.Text = "Ghi/Lưu";
            this.btn_luu.UseVisualStyleBackColor = false;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_khong
            // 
            this.btn_khong.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_khong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_khong.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_khong.Location = new System.Drawing.Point(628, 526);
            this.btn_khong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_khong.Name = "btn_khong";
            this.btn_khong.Size = new System.Drawing.Size(133, 36);
            this.btn_khong.TabIndex = 9;
            this.btn_khong.Text = "Không";
            this.btn_khong.UseVisualStyleBackColor = false;
            this.btn_khong.Click += new System.EventHandler(this.btn_khong_Click);
            // 
            // StaffManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 602);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_khong);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.btn_QLLH);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StaffManagement";
            this.Text = "Quản lý Nhân viên";
            this.Load += new System.EventHandler(this.StaffManagement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_manv;
        private System.Windows.Forms.TextBox txt_manv;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.Label label_hoten;
        private System.Windows.Forms.TextBox txt_luong;
        private System.Windows.Forms.Label label_luong;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.TextBox txt_tendn;
        private System.Windows.Forms.Label label_tendn;
        private System.Windows.Forms.Label label_mk;
        private System.Windows.Forms.TextBox txt_mk;
        private System.Windows.Forms.Button btn_QLLH;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_khong;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn LUONG;
    }
}