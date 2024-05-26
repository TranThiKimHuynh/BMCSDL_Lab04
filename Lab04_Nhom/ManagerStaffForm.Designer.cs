namespace Lab04_Nhom
{
    partial class ManagerStaffForm
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
            groupBox1 = new GroupBox();
            txt_mk = new TextBox();
            txt_luong = new TextBox();
            txt_hoten = new TextBox();
            txt_tendn = new TextBox();
            txt_email = new TextBox();
            txt_manv = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label12 = new Label();
            label11 = new Label();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            col_manv = new DataGridViewTextBoxColumn();
            col_hoten = new DataGridViewTextBoxColumn();
            col_email = new DataGridViewTextBoxColumn();
            btn_Add = new Button();
            btn_Save = new Button();
            bnt_Exit = new Button();
            bnt_qllh = new Button();
            label7 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightSteelBlue;
            groupBox1.Controls.Add(txt_mk);
            groupBox1.Controls.Add(txt_luong);
            groupBox1.Controls.Add(txt_hoten);
            groupBox1.Controls.Add(txt_tendn);
            groupBox1.Controls.Add(txt_email);
            groupBox1.Controls.Add(txt_manv);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(39, 79);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(869, 231);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên";
            // 
            // txt_mk
            // 
            txt_mk.Location = new Point(543, 177);
            txt_mk.Name = "txt_mk";
            txt_mk.Size = new Size(245, 31);
            txt_mk.TabIndex = 10;
            txt_mk.Text = "********";
            // 
            // txt_luong
            // 
            txt_luong.Location = new Point(543, 111);
            txt_luong.Name = "txt_luong";
            txt_luong.Size = new Size(245, 31);
            txt_luong.TabIndex = 9;
            txt_luong.Text = "********";
            // 
            // txt_hoten
            // 
            txt_hoten.Location = new Point(543, 42);
            txt_hoten.Name = "txt_hoten";
            txt_hoten.Size = new Size(245, 31);
            txt_hoten.TabIndex = 7;
            // 
            // txt_tendn
            // 
            txt_tendn.Location = new Point(172, 177);
            txt_tendn.Name = "txt_tendn";
            txt_tendn.Size = new Size(206, 31);
            txt_tendn.TabIndex = 8;
            txt_tendn.Text = "********";
            // 
            // txt_email
            // 
            txt_email.Location = new Point(172, 108);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(206, 31);
            txt_email.TabIndex = 7;
            // 
            // txt_manv
            // 
            txt_manv.Location = new Point(172, 42);
            txt_manv.Name = "txt_manv";
            txt_manv.Size = new Size(206, 31);
            txt_manv.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(437, 183);
            label6.Name = "label6";
            label6.Size = new Size(93, 25);
            label6.TabIndex = 5;
            label6.Text = "Mật khẩu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(437, 114);
            label5.Name = "label5";
            label5.Size = new Size(66, 25);
            label5.TabIndex = 4;
            label5.Text = "Lương";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(437, 42);
            label4.Name = "label4";
            label4.Size = new Size(70, 25);
            label4.TabIndex = 3;
            label4.Text = "Họ tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 183);
            label3.Name = "label3";
            label3.Size = new Size(138, 25);
            label3.TabIndex = 2;
            label3.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 114);
            label2.Name = "label2";
            label2.Size = new Size(58, 25);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 42);
            label1.Name = "label1";
            label1.Size = new Size(70, 25);
            label1.TabIndex = 0;
            label1.Text = "Mã NV";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(16, 42);
            label12.Name = "label12";
            label12.Size = new Size(0, 25);
            label12.TabIndex = 0;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(16, 114);
            label11.Name = "label11";
            label11.Size = new Size(0, 25);
            label11.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.LightSteelBlue;
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label12);
            groupBox2.Location = new Point(39, 316);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(869, 244);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { col_manv, col_hoten, col_email });
            dataGridView1.Location = new Point(99, 20);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(665, 218);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // col_manv
            // 
            col_manv.DataPropertyName = "MANV";
            col_manv.HeaderText = "MÃ NHÂN VIÊN";
            col_manv.MinimumWidth = 8;
            col_manv.Name = "col_manv";
            col_manv.Width = 200;
            // 
            // col_hoten
            // 
            col_hoten.DataPropertyName = "HOTEN";
            col_hoten.HeaderText = "HỌ TÊN";
            col_hoten.MinimumWidth = 8;
            col_hoten.Name = "col_hoten";
            col_hoten.Width = 200;
            // 
            // col_email
            // 
            col_email.DataPropertyName = "EMAIL";
            col_email.HeaderText = "EMAIL";
            col_email.MinimumWidth = 8;
            col_email.Name = "col_email";
            col_email.Width = 200;
            // 
            // btn_Add
            // 
            btn_Add.BackColor = SystemColors.MenuHighlight;
            btn_Add.Font = new Font("Segoe UI", 10F);
            btn_Add.ForeColor = SystemColors.HighlightText;
            btn_Add.Location = new Point(39, 576);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(158, 56);
            btn_Add.TabIndex = 12;
            btn_Add.Text = "Thêm";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // btn_Save
            // 
            btn_Save.BackColor = SystemColors.MenuHighlight;
            btn_Save.Font = new Font("Segoe UI", 10F);
            btn_Save.ForeColor = SystemColors.HighlightText;
            btn_Save.Location = new Point(397, 576);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(158, 56);
            btn_Save.TabIndex = 13;
            btn_Save.Text = "Ghi / Lưu";
            btn_Save.UseVisualStyleBackColor = false;
            btn_Save.Click += bnt_Save_Click;
            // 
            // bnt_Exit
            // 
            bnt_Exit.BackColor = SystemColors.MenuHighlight;
            bnt_Exit.Font = new Font("Segoe UI", 10F);
            bnt_Exit.ForeColor = SystemColors.HighlightText;
            bnt_Exit.Location = new Point(750, 576);
            bnt_Exit.Name = "bnt_Exit";
            bnt_Exit.Size = new Size(158, 56);
            bnt_Exit.TabIndex = 14;
            bnt_Exit.Text = "Thoát";
            bnt_Exit.UseVisualStyleBackColor = false;
            bnt_Exit.Click += bnt_Exit_Click;
            // 
            // bnt_qllh
            // 
            bnt_qllh.BackColor = SystemColors.MenuHighlight;
            bnt_qllh.Font = new Font("Segoe UI", 10F);
            bnt_qllh.ForeColor = SystemColors.HighlightText;
            bnt_qllh.Location = new Point(688, 12);
            bnt_qllh.Name = "bnt_qllh";
            bnt_qllh.Size = new Size(220, 56);
            bnt_qllh.TabIndex = 15;
            bnt_qllh.Text = "Quản lý lớp học";
            bnt_qllh.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label7.Location = new Point(211, 18);
            label7.Name = "label7";
            label7.Size = new Size(462, 38);
            label7.TabIndex = 16;
            label7.Text = "MÀN HÌNH QUẢN LÝ NHÂN VIÊN";
            // 
            // ManagerStaffForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 663);
            Controls.Add(label7);
            Controls.Add(bnt_qllh);
            Controls.Add(bnt_Exit);
            Controls.Add(btn_Save);
            Controls.Add(btn_Add);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ManagerStaffForm";
            Text = "Màn hình quản lý nhân viên";
            Load += ManagerStaffForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txt_manv;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_mk;
        private TextBox txt_luong;
        private TextBox txt_hoten;
        private TextBox txt_tendn;
        private TextBox txt_email;
        private Label label12;
        private Label label11;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn col_manv;
        private DataGridViewTextBoxColumn col_hoten;
        private DataGridViewTextBoxColumn col_email;
        private Button btn_Add;
        private Button bnt_qllh;
        private Button btn_Save;
        private Button bnt_Exit;
        private Label label7;
    }
}