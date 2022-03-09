
namespace GiaoDien
{
    partial class ChamDiem
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
            this.HVList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ClassCode = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_TenTaiKhoan = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HVList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HVList
            // 
            this.HVList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.HVList.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.HVList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HVList.Location = new System.Drawing.Point(119, 218);
            this.HVList.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.HVList.Name = "HVList";
            this.HVList.RowHeadersWidth = 51;
            this.HVList.RowTemplate.Height = 24;
            this.HVList.Size = new System.Drawing.Size(799, 431);
            this.HVList.TabIndex = 0;
            this.HVList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.HVList_CellValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 145);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "LỚP HỌC";
            // 
            // ClassCode
            // 
            this.ClassCode.Enabled = false;
            this.ClassCode.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassCode.Location = new System.Drawing.Point(378, 139);
            this.ClassCode.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ClassCode.Name = "ClassCode";
            this.ClassCode.Size = new System.Drawing.Size(396, 45);
            this.ClassCode.TabIndex = 2;
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.Save.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.ForeColor = System.Drawing.Color.White;
            this.Save.Location = new System.Drawing.Point(412, 679);
            this.Save.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(193, 71);
            this.Save.TabIndex = 3;
            this.Save.Text = "SAVE";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.panel1.Controls.Add(this.lb_TenTaiKhoan);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1032, 119);
            this.panel1.TabIndex = 40;
            // 
            // lb_TenTaiKhoan
            // 
            this.lb_TenTaiKhoan.AutoSize = true;
            this.lb_TenTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.lb_TenTaiKhoan.Location = new System.Drawing.Point(1750, 41);
            this.lb_TenTaiKhoan.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_TenTaiKhoan.Name = "lb_TenTaiKhoan";
            this.lb_TenTaiKhoan.Size = new System.Drawing.Size(45, 37);
            this.lb_TenTaiKhoan.TabIndex = 43;
            this.lb_TenTaiKhoan.Text = "tk";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(370, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 68);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chấm điểm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1394, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 37);
            this.label4.TabIndex = 42;
            this.label4.Text = "Tên tài khoản:";
            // 
            // ChamDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1032, 779);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.ClassCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HVList);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "ChamDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChamDiem";
            ((System.ComponentModel.ISupportInitialize)(this.HVList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView HVList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ClassCode;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_TenTaiKhoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}