namespace GiaoDien
{
    partial class GUI_KhoaHocDangKy
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_TenKhoaHoc = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Chon = new System.Windows.Forms.Button();
            this.lb_TenHocVien = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_MaHocVien = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_KhoaHoc = new System.Windows.Forms.DataGridView();
            this.lb_HocPhi = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhoaHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lb_HocPhi);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lb_TenKhoaHoc);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btn_Chon);
            this.panel2.Controls.Add(this.lb_TenHocVien);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lb_MaHocVien);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(779, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(291, 333);
            this.panel2.TabIndex = 28;
            // 
            // lb_TenKhoaHoc
            // 
            this.lb_TenKhoaHoc.AutoSize = true;
            this.lb_TenKhoaHoc.Location = new System.Drawing.Point(154, 107);
            this.lb_TenKhoaHoc.Name = "lb_TenKhoaHoc";
            this.lb_TenKhoaHoc.Size = new System.Drawing.Size(115, 22);
            this.lb_TenKhoaHoc.TabIndex = 19;
            this.lb_TenKhoaHoc.Text = "Tên khóa học";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 22);
            this.label5.TabIndex = 18;
            this.label5.Text = "Tên khóa học:";
            // 
            // btn_Chon
            // 
            this.btn_Chon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.btn_Chon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Chon.ForeColor = System.Drawing.Color.White;
            this.btn_Chon.Location = new System.Drawing.Point(28, 217);
            this.btn_Chon.Name = "btn_Chon";
            this.btn_Chon.Size = new System.Drawing.Size(237, 70);
            this.btn_Chon.TabIndex = 13;
            this.btn_Chon.Text = "Chọn";
            this.btn_Chon.UseVisualStyleBackColor = false;
            this.btn_Chon.Click += new System.EventHandler(this.btn_Chon_Click);
            // 
            // lb_TenHocVien
            // 
            this.lb_TenHocVien.AutoSize = true;
            this.lb_TenHocVien.Location = new System.Drawing.Point(154, 61);
            this.lb_TenHocVien.Name = "lb_TenHocVien";
            this.lb_TenHocVien.Size = new System.Drawing.Size(112, 22);
            this.lb_TenHocVien.TabIndex = 12;
            this.lb_TenHocVien.Text = "Tên học viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tên học viên:";
            // 
            // lb_MaHocVien
            // 
            this.lb_MaHocVien.AutoSize = true;
            this.lb_MaHocVien.Location = new System.Drawing.Point(154, 11);
            this.lb_MaHocVien.Name = "lb_MaHocVien";
            this.lb_MaHocVien.Size = new System.Drawing.Size(108, 22);
            this.lb_MaHocVien.TabIndex = 10;
            this.lb_MaHocVien.Text = "Mã học viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã học viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(288, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(567, 68);
            this.label2.TabIndex = 0;
            this.label2.Text = "Khóa học đã đăng ký";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 73);
            this.panel1.TabIndex = 27;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_KhoaHoc);
            this.groupBox1.Location = new System.Drawing.Point(12, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(750, 333);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách khóa học";
            // 
            // dgv_KhoaHoc
            // 
            this.dgv_KhoaHoc.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_KhoaHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_KhoaHoc.Location = new System.Drawing.Point(16, 26);
            this.dgv_KhoaHoc.Name = "dgv_KhoaHoc";
            this.dgv_KhoaHoc.RowHeadersWidth = 51;
            this.dgv_KhoaHoc.RowTemplate.Height = 24;
            this.dgv_KhoaHoc.Size = new System.Drawing.Size(718, 280);
            this.dgv_KhoaHoc.TabIndex = 31;
            this.dgv_KhoaHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_KhoaHoc_CellClick);
            // 
            // lb_HocPhi
            // 
            this.lb_HocPhi.AutoSize = true;
            this.lb_HocPhi.Location = new System.Drawing.Point(154, 148);
            this.lb_HocPhi.Name = "lb_HocPhi";
            this.lb_HocPhi.Size = new System.Drawing.Size(73, 22);
            this.lb_HocPhi.TabIndex = 21;
            this.lb_HocPhi.Text = "Học phí";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 22);
            this.label6.TabIndex = 20;
            this.label6.Text = "Học phí";
            // 
            // GUI_KhoaHocDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 619);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GUI_KhoaHocDangKy";
            this.Text = "Khóa học đã đăng ký";
            this.Load += new System.EventHandler(this.GUI_KhoaHocDangKy_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhoaHoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Chon;
        private System.Windows.Forms.Label lb_TenHocVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_MaHocVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_TenKhoaHoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_KhoaHoc;
        private System.Windows.Forms.Label lb_HocPhi;
        private System.Windows.Forms.Label label6;
    }
}