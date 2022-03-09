namespace GiaoDien
{
    partial class GUI_KQLopChungChi
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
            this.lbmakh = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbtenkh = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbkq = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhoaHoc)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_KhoaHoc
            // 
            this.dgv_KhoaHoc.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_KhoaHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_KhoaHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgv_KhoaHoc.Location = new System.Drawing.Point(13, 29);
            this.dgv_KhoaHoc.Name = "dgv_KhoaHoc";
            this.dgv_KhoaHoc.RowHeadersWidth = 51;
            this.dgv_KhoaHoc.RowTemplate.Height = 24;
            this.dgv_KhoaHoc.Size = new System.Drawing.Size(842, 280);
            this.dgv_KhoaHoc.TabIndex = 29;
            // 
            // lbmakh
            // 
            this.lbmakh.AutoSize = true;
            this.lbmakh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbmakh.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.lbmakh.ForeColor = System.Drawing.Color.White;
            this.lbmakh.Location = new System.Drawing.Point(3, 9);
            this.lbmakh.Name = "lbmakh";
            this.lbmakh.Size = new System.Drawing.Size(169, 40);
            this.lbmakh.TabIndex = 0;
            this.lbmakh.Text = "Khóa học:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_KhoaHoc);
            this.groupBox1.Location = new System.Drawing.Point(66, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(875, 333);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách môn học";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.panel1.Controls.Add(this.lbtenkh);
            this.panel1.Controls.Add(this.lbmakh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 73);
            this.panel1.TabIndex = 33;
            // 
            // lbtenkh
            // 
            this.lbtenkh.AutoSize = true;
            this.lbtenkh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbtenkh.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lbtenkh.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.lbtenkh.ForeColor = System.Drawing.Color.White;
            this.lbtenkh.Location = new System.Drawing.Point(190, 9);
            this.lbtenkh.Name = "lbtenkh";
            this.lbtenkh.Size = new System.Drawing.Size(217, 40);
            this.lbtenkh.TabIndex = 1;
            this.lbtenkh.Text = "Tên khóa học";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 463);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Kết quả:";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaMH1";
            this.Column1.HeaderText = "Mã môn học";
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenMH1";
            this.Column2.HeaderText = "Tên môn học";
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MaLMH1";
            this.Column3.HeaderText = "Mã lớp";
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Diem1";
            this.Column4.HeaderText = "Điểm";
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // lbkq
            // 
            this.lbkq.AutoSize = true;
            this.lbkq.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbkq.ForeColor = System.Drawing.Color.Red;
            this.lbkq.Location = new System.Drawing.Point(189, 462);
            this.lbkq.Name = "lbkq";
            this.lbkq.Size = new System.Drawing.Size(34, 23);
            this.lbkq.TabIndex = 36;
            this.lbkq.Text = "(*)";
            this.lbkq.Click += new System.EventHandler(this.lbkq_Click);
            // 
            // GUI_KQLopChungChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 619);
            this.Controls.Add(this.lbkq);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GUI_KQLopChungChi";
            this.Text = "Kết quả học tập";
            this.Load += new System.EventHandler(this.Newbie_DangKyKhoaHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhoaHoc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_KhoaHoc;
        private System.Windows.Forms.Label lbmakh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbtenkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label lbkq;
    }
}