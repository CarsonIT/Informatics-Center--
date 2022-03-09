namespace GiaoDien
{
    partial class GUI_ChuyenLop
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.lb_khochoc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lb_TenKhoaHoc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_MaKhoaHoc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Chon = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.panel3.Controls.Add(this.lb_khochoc);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 85);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1100, 56);
            this.panel3.TabIndex = 22;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Khóa học:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 85);
            this.panel1.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.label2.Location = new System.Drawing.Point(382, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(368, 68);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chuyển khóa";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(622, 210);
            this.dataGridView1.TabIndex = 23;
            // 
            // lb_TenKhoaHoc
            // 
            this.lb_TenKhoaHoc.AutoSize = true;
            this.lb_TenKhoaHoc.Location = new System.Drawing.Point(872, 218);
            this.lb_TenKhoaHoc.Name = "lb_TenKhoaHoc";
            this.lb_TenKhoaHoc.Size = new System.Drawing.Size(115, 22);
            this.lb_TenKhoaHoc.TabIndex = 27;
            this.lb_TenKhoaHoc.Text = "Tên khóa học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(742, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 22);
            this.label3.TabIndex = 26;
            this.label3.Text = "Tên môn học:";
            // 
            // lb_MaKhoaHoc
            // 
            this.lb_MaKhoaHoc.AutoSize = true;
            this.lb_MaKhoaHoc.Location = new System.Drawing.Point(872, 174);
            this.lb_MaKhoaHoc.Name = "lb_MaKhoaHoc";
            this.lb_MaKhoaHoc.Size = new System.Drawing.Size(111, 22);
            this.lb_MaKhoaHoc.TabIndex = 25;
            this.lb_MaKhoaHoc.Text = "Mã khóa học";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(746, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 22);
            this.label4.TabIndex = 24;
            this.label4.Text = "Mã môn học:";
            // 
            // btn_Chon
            // 
            this.btn_Chon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.btn_Chon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Chon.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Chon.ForeColor = System.Drawing.Color.White;
            this.btn_Chon.Location = new System.Drawing.Point(750, 301);
            this.btn_Chon.Name = "btn_Chon";
            this.btn_Chon.Size = new System.Drawing.Size(237, 70);
            this.btn_Chon.TabIndex = 28;
            this.btn_Chon.Text = "CHANGE";
            this.btn_Chon.UseVisualStyleBackColor = false;
            // 
            // GUI_ChuyenLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 619);
            this.Controls.Add(this.btn_Chon);
            this.Controls.Add(this.lb_TenKhoaHoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_MaKhoaHoc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GUI_ChuyenLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chuyển khóa";
            this.Load += new System.EventHandler(this.GUI_ChuyenLop_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lb_khochoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lb_TenKhoaHoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_MaKhoaHoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Chon;
    }
}