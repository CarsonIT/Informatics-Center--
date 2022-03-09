namespace GiaoDien
{
    partial class GUI_Learning_Results
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
            this.dgv_KhoaHoc = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_MaKhoaHoc = new System.Windows.Forms.Label();
            this.lb_TenKhoaHoc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_XemChiTietDiemThi = new System.Windows.Forms.Button();
            this.btn_XemTatCaDiem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_khochoc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhoaHoc)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_KhoaHoc
            // 
            this.dgv_KhoaHoc.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_KhoaHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_KhoaHoc.Location = new System.Drawing.Point(12, 179);
            this.dgv_KhoaHoc.Name = "dgv_KhoaHoc";
            this.dgv_KhoaHoc.RowHeadersWidth = 51;
            this.dgv_KhoaHoc.RowTemplate.Height = 24;
            this.dgv_KhoaHoc.Size = new System.Drawing.Size(735, 280);
            this.dgv_KhoaHoc.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(811, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã môn học:";
            // 
            // lb_MaKhoaHoc
            // 
            this.lb_MaKhoaHoc.AutoSize = true;
            this.lb_MaKhoaHoc.Location = new System.Drawing.Point(937, 179);
            this.lb_MaKhoaHoc.Name = "lb_MaKhoaHoc";
            this.lb_MaKhoaHoc.Size = new System.Drawing.Size(111, 22);
            this.lb_MaKhoaHoc.TabIndex = 2;
            this.lb_MaKhoaHoc.Text = "Mã khóa học";
            // 
            // lb_TenKhoaHoc
            // 
            this.lb_TenKhoaHoc.AutoSize = true;
            this.lb_TenKhoaHoc.Location = new System.Drawing.Point(937, 223);
            this.lb_TenKhoaHoc.Name = "lb_TenKhoaHoc";
            this.lb_TenKhoaHoc.Size = new System.Drawing.Size(115, 22);
            this.lb_TenKhoaHoc.TabIndex = 4;
            this.lb_TenKhoaHoc.Text = "Tên khóa học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(807, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên môn học:";
            // 
            // btn_XemChiTietDiemThi
            // 
            this.btn_XemChiTietDiemThi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.btn_XemChiTietDiemThi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XemChiTietDiemThi.ForeColor = System.Drawing.Color.White;
            this.btn_XemChiTietDiemThi.Location = new System.Drawing.Point(818, 298);
            this.btn_XemChiTietDiemThi.Name = "btn_XemChiTietDiemThi";
            this.btn_XemChiTietDiemThi.Size = new System.Drawing.Size(237, 70);
            this.btn_XemChiTietDiemThi.TabIndex = 5;
            this.btn_XemChiTietDiemThi.Text = "Xem chi tiết điểm";
            this.btn_XemChiTietDiemThi.UseVisualStyleBackColor = false;
            // 
            // btn_XemTatCaDiem
            // 
            this.btn_XemTatCaDiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.btn_XemTatCaDiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XemTatCaDiem.ForeColor = System.Drawing.Color.White;
            this.btn_XemTatCaDiem.Location = new System.Drawing.Point(815, 408);
            this.btn_XemTatCaDiem.Name = "btn_XemTatCaDiem";
            this.btn_XemTatCaDiem.Size = new System.Drawing.Size(237, 70);
            this.btn_XemTatCaDiem.TabIndex = 6;
            this.btn_XemTatCaDiem.Text = "Xem tất cả điểm";
            this.btn_XemTatCaDiem.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 90);
            this.panel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.label2.Location = new System.Drawing.Point(362, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(433, 68);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kết quả học tập";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.panel2.Controls.Add(this.lb_khochoc);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1100, 56);
            this.panel2.TabIndex = 8;
            // 
            // lb_khochoc
            // 
            this.lb_khochoc.AutoSize = true;
            this.lb_khochoc.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_khochoc.ForeColor = System.Drawing.Color.White;
            this.lb_khochoc.Location = new System.Drawing.Point(205, 3);
            this.lb_khochoc.Name = "lb_khochoc";
            this.lb_khochoc.Size = new System.Drawing.Size(194, 37);
            this.lb_khochoc.TabIndex = 3;
            this.lb_khochoc.Text = "Tên khóa học";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 37);
            this.label4.TabIndex = 2;
            this.label4.Text = "Khóa học:";
            // 
            // GUI_Learning_Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 533);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_XemTatCaDiem);
            this.Controls.Add(this.btn_XemChiTietDiemThi);
            this.Controls.Add(this.lb_TenKhoaHoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_MaKhoaHoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_KhoaHoc);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GUI_Learning_Results";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kết quả học tập";
            this.Load += new System.EventHandler(this.GUI_Learning_Results_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhoaHoc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_KhoaHoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_MaKhoaHoc;
        private System.Windows.Forms.Label lb_TenKhoaHoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_XemChiTietDiemThi;
        private System.Windows.Forms.Button btn_XemTatCaDiem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_khochoc;
        private System.Windows.Forms.Label label4;
    }
}