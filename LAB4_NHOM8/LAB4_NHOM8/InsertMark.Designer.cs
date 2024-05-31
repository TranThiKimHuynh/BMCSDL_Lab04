namespace LAB4_NHOM8
{
    partial class InsertMark
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_title = new System.Windows.Forms.Label();
            this.btn_QLLH = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_hocphan = new System.Windows.Forms.TextBox();
            this.label_hocphan = new System.Windows.Forms.Label();
            this.txt_diem = new System.Windows.Forms.TextBox();
            this.label_diem = new System.Windows.Forms.Label();
            this.txt_masv = new System.Windows.Forms.TextBox();
            this.label_masv = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MASV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIEMTHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_khong = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label_title.Location = new System.Drawing.Point(323, 25);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(346, 29);
            this.label_title.TabIndex = 4;
            this.label_title.Text = "NHẬP ĐIỂM CỦA SINH VIÊN";
            // 
            // btn_QLLH
            // 
            this.btn_QLLH.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_QLLH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_QLLH.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_QLLH.Location = new System.Drawing.Point(12, 8);
            this.btn_QLLH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_QLLH.Name = "btn_QLLH";
            this.btn_QLLH.Size = new System.Drawing.Size(189, 46);
            this.btn_QLLH.TabIndex = 5;
            this.btn_QLLH.Text = "Trở về Lớp học";
            this.btn_QLLH.UseVisualStyleBackColor = false;
            this.btn_QLLH.Click += new System.EventHandler(this.btn_QLLH_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.txt_hocphan);
            this.groupBox1.Controls.Add(this.label_hocphan);
            this.groupBox1.Controls.Add(this.txt_diem);
            this.groupBox1.Controls.Add(this.label_diem);
            this.groupBox1.Controls.Add(this.txt_masv);
            this.groupBox1.Controls.Add(this.label_masv);
            this.groupBox1.Location = new System.Drawing.Point(12, 80);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(911, 164);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin điểm số";
            // 
            // txt_hocphan
            // 
            this.txt_hocphan.Enabled = false;
            this.txt_hocphan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txt_hocphan.Location = new System.Drawing.Point(254, 72);
            this.txt_hocphan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_hocphan.Name = "txt_hocphan";
            this.txt_hocphan.Size = new System.Drawing.Size(408, 24);
            this.txt_hocphan.TabIndex = 2;
            // 
            // label_hocphan
            // 
            this.label_hocphan.AutoSize = true;
            this.label_hocphan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label_hocphan.Location = new System.Drawing.Point(27, 78);
            this.label_hocphan.Name = "label_hocphan";
            this.label_hocphan.Size = new System.Drawing.Size(105, 18);
            this.label_hocphan.TabIndex = 4;
            this.label_hocphan.Text = "Mã học phần";
            // 
            // txt_diem
            // 
            this.txt_diem.Enabled = false;
            this.txt_diem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txt_diem.Location = new System.Drawing.Point(254, 119);
            this.txt_diem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_diem.Name = "txt_diem";
            this.txt_diem.Size = new System.Drawing.Size(408, 24);
            this.txt_diem.TabIndex = 3;
            // 
            // label_diem
            // 
            this.label_diem.AutoSize = true;
            this.label_diem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label_diem.Location = new System.Drawing.Point(27, 125);
            this.label_diem.Name = "label_diem";
            this.label_diem.Size = new System.Drawing.Size(70, 18);
            this.label_diem.TabIndex = 2;
            this.label_diem.Text = "Điểm thi";
            // 
            // txt_masv
            // 
            this.txt_masv.Enabled = false;
            this.txt_masv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txt_masv.Location = new System.Drawing.Point(254, 25);
            this.txt_masv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_masv.Name = "txt_masv";
            this.txt_masv.Size = new System.Drawing.Size(408, 24);
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
            this.groupBox2.Location = new System.Drawing.Point(12, 265);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(911, 239);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MASV,
            this.MAHP,
            this.DIEMTHI});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
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
            this.dataGridView1.Size = new System.Drawing.Size(846, 200);
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
            // MAHP
            // 
            this.MAHP.HeaderText = "MÃ HỌC PHẦN";
            this.MAHP.MinimumWidth = 6;
            this.MAHP.Name = "MAHP";
            this.MAHP.ReadOnly = true;
            // 
            // DIEMTHI
            // 
            this.DIEMTHI.HeaderText = "ĐIỂM THI";
            this.DIEMTHI.MinimumWidth = 6;
            this.DIEMTHI.Name = "DIEMTHI";
            this.DIEMTHI.ReadOnly = true;
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.Red;
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_thoat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_thoat.Location = new System.Drawing.Point(783, 524);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(133, 36);
            this.btn_thoat.TabIndex = 13;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_khong
            // 
            this.btn_khong.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_khong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_khong.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_khong.Location = new System.Drawing.Point(630, 524);
            this.btn_khong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_khong.Name = "btn_khong";
            this.btn_khong.Size = new System.Drawing.Size(133, 36);
            this.btn_khong.TabIndex = 15;
            this.btn_khong.Text = "Không";
            this.btn_khong.UseVisualStyleBackColor = false;
            this.btn_khong.Click += new System.EventHandler(this.btn_khong_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_xoa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_xoa.Location = new System.Drawing.Point(173, 524);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(133, 36);
            this.btn_xoa.TabIndex = 11;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_luu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_luu.Location = new System.Drawing.Point(477, 524);
            this.btn_luu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(133, 36);
            this.btn_luu.TabIndex = 14;
            this.btn_luu.Text = "Ghi/Lưu";
            this.btn_luu.UseVisualStyleBackColor = false;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_them.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_them.Location = new System.Drawing.Point(22, 524);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(133, 36);
            this.btn_them.TabIndex = 10;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // InsertMark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 595);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_khong);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_QLLH);
            this.Controls.Add(this.label_title);
            this.Name = "InsertMark";
            this.Text = "Nhập điểm";
            this.Load += new System.EventHandler(this.InsertMark_Load);
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_hocphan;
        private System.Windows.Forms.TextBox txt_diem;
        private System.Windows.Forms.Label label_diem;
        private System.Windows.Forms.TextBox txt_masv;
        private System.Windows.Forms.Label label_masv;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIEMTHI;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_khong;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.TextBox txt_hocphan;
    }
}