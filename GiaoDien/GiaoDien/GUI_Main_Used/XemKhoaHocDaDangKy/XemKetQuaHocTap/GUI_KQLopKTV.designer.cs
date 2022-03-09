namespace GiaoDien
{
    partial class GUI_KQLopKTV
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
            this.dgv_MonHoc = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbmakh = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbmahp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbtenkh = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbkq = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_DSHP = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.lbdiemtn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MonHoc)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSHP)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_MonHoc
            // 
            this.dgv_MonHoc.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_MonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MonHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgv_MonHoc.Location = new System.Drawing.Point(13, 29);
            this.dgv_MonHoc.Name = "dgv_MonHoc";
            this.dgv_MonHoc.RowHeadersWidth = 51;
            this.dgv_MonHoc.RowTemplate.Height = 24;
            this.dgv_MonHoc.Size = new System.Drawing.Size(842, 172);
            this.dgv_MonHoc.TabIndex = 29;
            this.dgv_MonHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_MonHoc_CellClick);
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
            this.groupBox1.Controls.Add(this.lbmahp);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dgv_MonHoc);
            this.groupBox1.Location = new System.Drawing.Point(32, 374);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(875, 222);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách môn học";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbmahp
            // 
            this.lbmahp.AutoSize = true;
            this.lbmahp.Location = new System.Drawing.Point(279, 0);
            this.lbmahp.Name = "lbmahp";
            this.lbmahp.Size = new System.Drawing.Size(0, 22);
            this.lbmahp.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 22);
            this.label3.TabIndex = 38;
            this.label3.Text = "Học phần: ";
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
            this.panel1.TabIndex = 38;
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
            this.label1.Location = new System.Drawing.Point(786, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 22);
            this.label1.TabIndex = 37;
            this.label1.Text = "Kết quả:";
            // 
            // lbkq
            // 
            this.lbkq.AutoSize = true;
            this.lbkq.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbkq.ForeColor = System.Drawing.Color.Red;
            this.lbkq.Location = new System.Drawing.Point(873, 224);
            this.lbkq.Name = "lbkq";
            this.lbkq.Size = new System.Drawing.Size(34, 23);
            this.lbkq.TabIndex = 40;
            this.lbkq.Text = "(*)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_DSHP);
            this.groupBox2.Location = new System.Drawing.Point(32, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(693, 213);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách học phần";
            // 
            // dgv_DSHP
            // 
            this.dgv_DSHP.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_DSHP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSHP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgv_DSHP.Location = new System.Drawing.Point(13, 29);
            this.dgv_DSHP.Name = "dgv_DSHP";
            this.dgv_DSHP.RowHeadersWidth = 51;
            this.dgv_DSHP.RowTemplate.Height = 24;
            this.dgv_DSHP.Size = new System.Drawing.Size(842, 172);
            this.dgv_DSHP.TabIndex = 29;
            this.dgv_DSHP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DSHP_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaHP1";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã học phần";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenHP1";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên học phần";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DiemTB1";
            this.dataGridViewTextBoxColumn3.HeaderText = "Điểm trung bình";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(786, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 22);
            this.label2.TabIndex = 42;
            this.label2.Text = "Điểm thi tốt nghiệp:";
            // 
            // lbdiemtn
            // 
            this.lbdiemtn.AutoSize = true;
            this.lbdiemtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbdiemtn.ForeColor = System.Drawing.Color.Red;
            this.lbdiemtn.Location = new System.Drawing.Point(958, 165);
            this.lbdiemtn.Name = "lbdiemtn";
            this.lbdiemtn.Size = new System.Drawing.Size(34, 23);
            this.lbdiemtn.TabIndex = 43;
            this.lbdiemtn.Text = "(*)";
            // 
            // GUI_KQLopKTV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 619);
            this.Controls.Add(this.lbdiemtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbkq);
            this.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GUI_KQLopKTV";
            this.Text = "Kết quả học tập";
            this.Load += new System.EventHandler(this.GUI_KQLopKTV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MonHoc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSHP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_MonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label lbmakh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbtenkh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbkq;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_DSHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbdiemtn;
        private System.Windows.Forms.Label lbmahp;
        private System.Windows.Forms.Label label3;
    }
}