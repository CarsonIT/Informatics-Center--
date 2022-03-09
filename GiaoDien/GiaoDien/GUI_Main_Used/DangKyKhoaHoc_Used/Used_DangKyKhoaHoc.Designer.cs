namespace GiaoDien
{
    partial class Used_DangKyKhoaHoc
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
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_All_LopHoc = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_All_KhoaHoc = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_TenTaiKhoan = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_DangKy = new System.Windows.Forms.Button();
            this.lb_ngayKhaiGiang = new System.Windows.Forms.DateTimePicker();
            this.lb_SoTietHoc = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_HocPhi = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_TenKhoaHoc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_MaLopKhoaHoc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_All_LopHoc)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_All_KhoaHoc)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "SoTiet";
            this.Column9.HeaderText = "Số tiết";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "TenMonHoc";
            this.Column7.HeaderText = "Tên môn học";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "MaLop";
            this.Column6.HeaderText = "Mã lớp";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // dgv_All_LopHoc
            // 
            this.dgv_All_LopHoc.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_All_LopHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_All_LopHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgv_All_LopHoc.Location = new System.Drawing.Point(13, 29);
            this.dgv_All_LopHoc.Name = "dgv_All_LopHoc";
            this.dgv_All_LopHoc.RowHeadersWidth = 51;
            this.dgv_All_LopHoc.RowTemplate.Height = 24;
            this.dgv_All_LopHoc.Size = new System.Drawing.Size(686, 225);
            this.dgv_All_LopHoc.TabIndex = 29;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "ThoiGianHoc";
            this.Column8.HeaderText = "Thời gian học";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_All_LopHoc);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 459);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(705, 273);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách lớp học";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_All_KhoaHoc);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(705, 333);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách khóa học";
            // 
            // dgv_All_KhoaHoc
            // 
            this.dgv_All_KhoaHoc.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_All_KhoaHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_All_KhoaHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgv_All_KhoaHoc.Location = new System.Drawing.Point(13, 29);
            this.dgv_All_KhoaHoc.Name = "dgv_All_KhoaHoc";
            this.dgv_All_KhoaHoc.RowHeadersWidth = 51;
            this.dgv_All_KhoaHoc.RowTemplate.Height = 24;
            this.dgv_All_KhoaHoc.Size = new System.Drawing.Size(686, 280);
            this.dgv_All_KhoaHoc.TabIndex = 29;
            this.dgv_All_KhoaHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_All_KhoaHoc_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaLopKhoaHoc";
            this.Column1.HeaderText = "Mã lớp khóa học";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenKhoaHoc";
            this.Column2.HeaderText = "Tên khóa học";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 175;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NgayKhaiGiang";
            this.Column3.HeaderText = "Ngày khai giảng ";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "HocPhi";
            this.Column4.HeaderText = "Học phí";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "SoTietHoc";
            this.Column5.HeaderText = "Số tiết học";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 50;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.panel1.Controls.Add(this.lb_TenTaiKhoan);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1209, 73);
            this.panel1.TabIndex = 39;
            // 
            // lb_TenTaiKhoan
            // 
            this.lb_TenTaiKhoan.AutoSize = true;
            this.lb_TenTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.lb_TenTaiKhoan.Location = new System.Drawing.Point(1021, 9);
            this.lb_TenTaiKhoan.Name = "lb_TenTaiKhoan";
            this.lb_TenTaiKhoan.Size = new System.Drawing.Size(45, 37);
            this.lb_TenTaiKhoan.TabIndex = 2;
            this.lb_TenTaiKhoan.Text = "tk";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(802, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 37);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên tài khoản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(254, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(484, 68);
            this.label2.TabIndex = 0;
            this.label2.Text = "Đăng ký khóa học";
            // 
            // btn_DangKy
            // 
            this.btn_DangKy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.btn_DangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DangKy.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangKy.ForeColor = System.Drawing.Color.White;
            this.btn_DangKy.Location = new System.Drawing.Point(843, 426);
            this.btn_DangKy.Name = "btn_DangKy";
            this.btn_DangKy.Size = new System.Drawing.Size(237, 70);
            this.btn_DangKy.TabIndex = 37;
            this.btn_DangKy.Text = "Đăng ký";
            this.btn_DangKy.UseVisualStyleBackColor = false;
            this.btn_DangKy.Click += new System.EventHandler(this.btn_DangKy_Click);
            // 
            // lb_ngayKhaiGiang
            // 
            this.lb_ngayKhaiGiang.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.lb_ngayKhaiGiang.Location = new System.Drawing.Point(208, 102);
            this.lb_ngayKhaiGiang.Name = "lb_ngayKhaiGiang";
            this.lb_ngayKhaiGiang.Size = new System.Drawing.Size(118, 34);
            this.lb_ngayKhaiGiang.TabIndex = 20;
            // 
            // lb_SoTietHoc
            // 
            this.lb_SoTietHoc.AutoSize = true;
            this.lb_SoTietHoc.Location = new System.Drawing.Point(204, 210);
            this.lb_SoTietHoc.Name = "lb_SoTietHoc";
            this.lb_SoTietHoc.Size = new System.Drawing.Size(114, 27);
            this.lb_SoTietHoc.TabIndex = 19;
            this.lb_SoTietHoc.Text = "Số tiết học";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 27);
            this.label7.TabIndex = 18;
            this.label7.Text = "Số tiết học";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 27);
            this.label6.TabIndex = 16;
            this.label6.Text = "Ngày khai giảng";
            // 
            // lb_HocPhi
            // 
            this.lb_HocPhi.AutoSize = true;
            this.lb_HocPhi.Location = new System.Drawing.Point(204, 159);
            this.lb_HocPhi.Name = "lb_HocPhi";
            this.lb_HocPhi.Size = new System.Drawing.Size(88, 27);
            this.lb_HocPhi.TabIndex = 15;
            this.lb_HocPhi.Text = "Học phí";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 27);
            this.label5.TabIndex = 14;
            this.label5.Text = "Học phí: ";
            // 
            // lb_TenKhoaHoc
            // 
            this.lb_TenKhoaHoc.AutoSize = true;
            this.lb_TenKhoaHoc.Location = new System.Drawing.Point(204, 61);
            this.lb_TenKhoaHoc.Name = "lb_TenKhoaHoc";
            this.lb_TenKhoaHoc.Size = new System.Drawing.Size(143, 27);
            this.lb_TenKhoaHoc.TabIndex = 12;
            this.lb_TenKhoaHoc.Text = "Tên khóa học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 27);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tên khóa học:";
            // 
            // lb_MaLopKhoaHoc
            // 
            this.lb_MaLopKhoaHoc.AutoSize = true;
            this.lb_MaLopKhoaHoc.Location = new System.Drawing.Point(204, 11);
            this.lb_MaLopKhoaHoc.Name = "lb_MaLopKhoaHoc";
            this.lb_MaLopKhoaHoc.Size = new System.Drawing.Size(175, 27);
            this.lb_MaLopKhoaHoc.TabIndex = 10;
            this.lb_MaLopKhoaHoc.Text = "Mã lớp khóa học";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 27);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã lớp khóa học:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lb_ngayKhaiGiang);
            this.panel2.Controls.Add(this.lb_SoTietHoc);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lb_HocPhi);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lb_TenKhoaHoc);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lb_MaLopKhoaHoc);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(776, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(404, 263);
            this.panel2.TabIndex = 40;
            // 
            // Used_DangKyKhoaHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1209, 864);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_DangKy);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Used_DangKyKhoaHoc";
            this.Text = "Used_DangKyKhoaHoc";
            this.Load += new System.EventHandler(this.Used_DangKyKhoaHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_All_LopHoc)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_All_KhoaHoc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridView dgv_All_LopHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_All_KhoaHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_DangKy;
        private System.Windows.Forms.DateTimePicker lb_ngayKhaiGiang;
        private System.Windows.Forms.Label lb_SoTietHoc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_HocPhi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_TenKhoaHoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_MaLopKhoaHoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_TenTaiKhoan;
        private System.Windows.Forms.Label label4;
    }
}