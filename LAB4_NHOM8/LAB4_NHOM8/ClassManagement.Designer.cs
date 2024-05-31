namespace LAB4_NHOM8
{
    partial class ClassManagement
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
            this.btn_QLNV = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_xemlop = new System.Windows.Forms.Button();
            this.txt_tenlop = new System.Windows.Forms.TextBox();
            this.label_tenlop = new System.Windows.Forms.Label();
            this.txt_nvql = new System.Windows.Forms.TextBox();
            this.label_nvql = new System.Windows.Forms.Label();
            this.txt_malop = new System.Windows.Forms.TextBox();
            this.label_malop = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MALOP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENLOP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NVQL = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.label_title.Location = new System.Drawing.Point(355, 28);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(245, 29);
            this.label_title.TabIndex = 3;
            this.label_title.Text = "QUẢN LÝ LỚP HỌC";
            // 
            // btn_QLNV
            // 
            this.btn_QLNV.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_QLNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_QLNV.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_QLNV.Location = new System.Drawing.Point(12, 11);
            this.btn_QLNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_QLNV.Name = "btn_QLNV";
            this.btn_QLNV.Size = new System.Drawing.Size(248, 46);
            this.btn_QLNV.TabIndex = 4;
            this.btn_QLNV.Text = "Quản lý Nhân viên";
            this.btn_QLNV.UseVisualStyleBackColor = false;
            this.btn_QLNV.Click += new System.EventHandler(this.btn_QLNV_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.btn_xemlop);
            this.groupBox1.Controls.Add(this.txt_tenlop);
            this.groupBox1.Controls.Add(this.label_tenlop);
            this.groupBox1.Controls.Add(this.txt_nvql);
            this.groupBox1.Controls.Add(this.label_nvql);
            this.groupBox1.Controls.Add(this.txt_malop);
            this.groupBox1.Controls.Add(this.label_malop);
            this.groupBox1.Location = new System.Drawing.Point(12, 90);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(911, 164);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin lớp học";
            // 
            // btn_xemlop
            // 
            this.btn_xemlop.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_xemlop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_xemlop.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_xemlop.Location = new System.Drawing.Point(723, 19);
            this.btn_xemlop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xemlop.Name = "btn_xemlop";
            this.btn_xemlop.Size = new System.Drawing.Size(153, 50);
            this.btn_xemlop.TabIndex = 16;
            this.btn_xemlop.Text = "Xem lớp";
            this.btn_xemlop.UseVisualStyleBackColor = false;
            this.btn_xemlop.Click += new System.EventHandler(this.btn_xemlop_Click);
            // 
            // txt_tenlop
            // 
            this.txt_tenlop.Enabled = false;
            this.txt_tenlop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txt_tenlop.Location = new System.Drawing.Point(254, 72);
            this.txt_tenlop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tenlop.Name = "txt_tenlop";
            this.txt_tenlop.Size = new System.Drawing.Size(408, 24);
            this.txt_tenlop.TabIndex = 5;
            // 
            // label_tenlop
            // 
            this.label_tenlop.AutoSize = true;
            this.label_tenlop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label_tenlop.Location = new System.Drawing.Point(27, 78);
            this.label_tenlop.Name = "label_tenlop";
            this.label_tenlop.Size = new System.Drawing.Size(64, 18);
            this.label_tenlop.TabIndex = 4;
            this.label_tenlop.Text = "Tên lớp";
            // 
            // txt_nvql
            // 
            this.txt_nvql.Enabled = false;
            this.txt_nvql.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txt_nvql.Location = new System.Drawing.Point(254, 119);
            this.txt_nvql.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nvql.Name = "txt_nvql";
            this.txt_nvql.Size = new System.Drawing.Size(408, 24);
            this.txt_nvql.TabIndex = 3;
            // 
            // label_nvql
            // 
            this.label_nvql.AutoSize = true;
            this.label_nvql.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label_nvql.Location = new System.Drawing.Point(27, 125);
            this.label_nvql.Name = "label_nvql";
            this.label_nvql.Size = new System.Drawing.Size(140, 18);
            this.label_nvql.TabIndex = 2;
            this.label_nvql.Text = "Nhân viên quản lý";
            // 
            // txt_malop
            // 
            this.txt_malop.Enabled = false;
            this.txt_malop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txt_malop.Location = new System.Drawing.Point(254, 25);
            this.txt_malop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_malop.Name = "txt_malop";
            this.txt_malop.Size = new System.Drawing.Size(408, 24);
            this.txt_malop.TabIndex = 1;
            // 
            // label_malop
            // 
            this.label_malop.AutoSize = true;
            this.label_malop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label_malop.Location = new System.Drawing.Point(27, 28);
            this.label_malop.Name = "label_malop";
            this.label_malop.Size = new System.Drawing.Size(59, 18);
            this.label_malop.TabIndex = 0;
            this.label_malop.Text = "Mã lớp";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 270);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(911, 239);
            this.groupBox2.TabIndex = 6;
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
            this.MALOP,
            this.TENLOP,
            this.NVQL});
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
            // MALOP
            // 
            this.MALOP.HeaderText = "MÃ LỚP";
            this.MALOP.MinimumWidth = 6;
            this.MALOP.Name = "MALOP";
            this.MALOP.ReadOnly = true;
            // 
            // TENLOP
            // 
            this.TENLOP.FillWeight = 150F;
            this.TENLOP.HeaderText = "TÊN LỚP";
            this.TENLOP.MinimumWidth = 6;
            this.TENLOP.Name = "TENLOP";
            this.TENLOP.ReadOnly = true;
            // 
            // NVQL
            // 
            this.NVQL.FillWeight = 150F;
            this.NVQL.HeaderText = "NHÂN VIÊN QUẢN LÝ";
            this.NVQL.MinimumWidth = 6;
            this.NVQL.Name = "NVQL";
            this.NVQL.ReadOnly = true;
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.Red;
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_thoat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_thoat.Location = new System.Drawing.Point(620, 525);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(133, 36);
            this.btn_thoat.TabIndex = 13;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_sua.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_sua.Location = new System.Drawing.Point(162, 525);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(133, 36);
            this.btn_sua.TabIndex = 12;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_khong
            // 
            this.btn_khong.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_khong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_khong.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_khong.Location = new System.Drawing.Point(467, 525);
            this.btn_khong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_khong.Name = "btn_khong";
            this.btn_khong.Size = new System.Drawing.Size(133, 36);
            this.btn_khong.TabIndex = 15;
            this.btn_khong.Text = "Không";
            this.btn_khong.UseVisualStyleBackColor = false;
            this.btn_khong.Click += new System.EventHandler(this.btn_khong_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_luu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_luu.Location = new System.Drawing.Point(314, 525);
            this.btn_luu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(133, 36);
            this.btn_luu.TabIndex = 14;
            this.btn_luu.Text = "Ghi/Lưu";
            this.btn_luu.UseVisualStyleBackColor = false;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // ClassManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 582);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_khong);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_QLNV);
            this.Controls.Add(this.label_title);
            this.Name = "ClassManagement";
            this.Text = "Quản lý Lớp học";
            this.Load += new System.EventHandler(this.ClassManagement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Button btn_QLNV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_tenlop;
        private System.Windows.Forms.Label label_tenlop;
        private System.Windows.Forms.TextBox txt_nvql;
        private System.Windows.Forms.Label label_nvql;
        private System.Windows.Forms.TextBox txt_malop;
        private System.Windows.Forms.Label label_malop;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_khong;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_xemlop;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALOP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENLOP;
        private System.Windows.Forms.DataGridViewTextBoxColumn NVQL;
    }
}