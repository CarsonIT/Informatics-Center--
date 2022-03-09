
namespace GiaoDien
{
    partial class GIAOVIEN
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
            this.ClassList = new System.Windows.Forms.DataGridView();
            this.Mark = new System.Windows.Forms.Button();
            this.Courseclass = new System.Windows.Forms.RadioButton();
            this.SJClass = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.ClassCode = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_TenTaiKhoan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ClassList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClassList
            // 
            this.ClassList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ClassList.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClassList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClassList.Location = new System.Drawing.Point(60, 181);
            this.ClassList.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ClassList.Name = "ClassList";
            this.ClassList.RowHeadersWidth = 51;
            this.ClassList.RowTemplate.Height = 24;
            this.ClassList.Size = new System.Drawing.Size(1103, 335);
            this.ClassList.TabIndex = 0;
            // 
            // Mark
            // 
            this.Mark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.Mark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mark.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mark.ForeColor = System.Drawing.Color.White;
            this.Mark.Location = new System.Drawing.Point(796, 534);
            this.Mark.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Mark.Name = "Mark";
            this.Mark.Size = new System.Drawing.Size(210, 67);
            this.Mark.TabIndex = 1;
            this.Mark.Text = "Chấm Điểm";
            this.Mark.UseVisualStyleBackColor = false;
            this.Mark.Click += new System.EventHandler(this.Mark_Click);
            // 
            // Courseclass
            // 
            this.Courseclass.AutoSize = true;
            this.Courseclass.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Courseclass.Location = new System.Drawing.Point(333, 111);
            this.Courseclass.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Courseclass.Name = "Courseclass";
            this.Courseclass.Size = new System.Drawing.Size(264, 47);
            this.Courseclass.TabIndex = 2;
            this.Courseclass.TabStop = true;
            this.Courseclass.Text = "Lớp Khóa Học";
            this.Courseclass.UseVisualStyleBackColor = true;
            // 
            // SJClass
            // 
            this.SJClass.AutoSize = true;
            this.SJClass.Checked = true;
            this.SJClass.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SJClass.Location = new System.Drawing.Point(653, 111);
            this.SJClass.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.SJClass.Name = "SJClass";
            this.SJClass.Size = new System.Drawing.Size(254, 47);
            this.SJClass.TabIndex = 3;
            this.SJClass.TabStop = true;
            this.SJClass.Text = "Lớp Môn Học";
            this.SJClass.UseVisualStyleBackColor = true;
            this.SJClass.CheckedChanged += new System.EventHandler(this.SJClass_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(229, 543);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 43);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã lớp";
            // 
            // ClassCode
            // 
            this.ClassCode.Enabled = false;
            this.ClassCode.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassCode.Location = new System.Drawing.Point(403, 543);
            this.ClassCode.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ClassCode.Name = "ClassCode";
            this.ClassCode.Size = new System.Drawing.Size(308, 50);
            this.ClassCode.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.panel1.Controls.Add(this.lb_TenTaiKhoan);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
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
            this.lb_TenTaiKhoan.Location = new System.Drawing.Point(1077, 25);
            this.lb_TenTaiKhoan.Name = "lb_TenTaiKhoan";
            this.lb_TenTaiKhoan.Size = new System.Drawing.Size(45, 37);
            this.lb_TenTaiKhoan.TabIndex = 43;
            this.lb_TenTaiKhoan.Text = "tk";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(124, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách lớp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(858, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 37);
            this.label4.TabIndex = 42;
            this.label4.Text = "Tên tài khoản:";
            // 
            // GIAOVIEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1209, 686);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ClassCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SJClass);
            this.Controls.Add(this.Courseclass);
            this.Controls.Add(this.Mark);
            this.Controls.Add(this.ClassList);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "GIAOVIEN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GIAOVIEN";
            ((System.ComponentModel.ISupportInitialize)(this.ClassList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ClassList;
        private System.Windows.Forms.Button Mark;
        private System.Windows.Forms.RadioButton Courseclass;
        private System.Windows.Forms.RadioButton SJClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ClassCode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_TenTaiKhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}