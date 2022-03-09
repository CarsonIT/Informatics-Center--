namespace GiaoDien
{
    partial class GUI_GiaoVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_GiaoVien));
            this.panel_cover = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_TenTaiKhoan = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_main = new System.Windows.Forms.Panel();
            this.lb_TenNhom = new System.Windows.Forms.Label();
            this.btn_Course = new System.Windows.Forms.Button();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.panel_side = new System.Windows.Forms.Panel();
            this.panel_cover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_main.SuspendLayout();
            this.panel_logo.SuspendLayout();
            this.panel_side.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_cover
            // 
            this.panel_cover.Controls.Add(this.pictureBox1);
            this.panel_cover.Controls.Add(this.panel2);
            this.panel_cover.Controls.Add(this.panel1);
            this.panel_cover.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_cover.Location = new System.Drawing.Point(0, 0);
            this.panel_cover.Name = "panel_cover";
            this.panel_cover.Size = new System.Drawing.Size(1160, 865);
            this.panel_cover.TabIndex = 0;
            this.panel_cover.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_cover_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(241, 233);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(728, 589);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.panel2.Controls.Add(this.lb_TenTaiKhoan);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1160, 79);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lb_TenTaiKhoan
            // 
            this.lb_TenTaiKhoan.AutoSize = true;
            this.lb_TenTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.lb_TenTaiKhoan.Location = new System.Drawing.Point(233, 17);
            this.lb_TenTaiKhoan.Name = "lb_TenTaiKhoan";
            this.lb_TenTaiKhoan.Size = new System.Drawing.Size(179, 46);
            this.lb_TenTaiKhoan.TabIndex = 1;
            this.lb_TenTaiKhoan.Text = "Giáo viên";
            this.lb_TenTaiKhoan.Click += new System.EventHandler(this.lb_TenTaiKhoan_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(59, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 46);
            this.label3.TabIndex = 0;
            this.label3.Text = "Welcome:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1160, 79);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(746, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trung tâm tin học - HCMUS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.panel_cover);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(213, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1160, 865);
            this.panel_main.TabIndex = 5;
            this.panel_main.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_main_Paint);
            // 
            // lb_TenNhom
            // 
            this.lb_TenNhom.AutoSize = true;
            this.lb_TenNhom.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenNhom.ForeColor = System.Drawing.Color.White;
            this.lb_TenNhom.Location = new System.Drawing.Point(12, 29);
            this.lb_TenNhom.Name = "lb_TenNhom";
            this.lb_TenNhom.Size = new System.Drawing.Size(302, 74);
            this.lb_TenNhom.TabIndex = 3;
            this.lb_TenNhom.Text = "GROUP 12";
            this.lb_TenNhom.Click += new System.EventHandler(this.lb_TenNhom_Click);
            // 
            // btn_Course
            // 
            this.btn_Course.BackColor = System.Drawing.Color.DarkRed;
            this.btn_Course.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Course.FlatAppearance.BorderSize = 0;
            this.btn_Course.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Course.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Course.ForeColor = System.Drawing.Color.White;
            this.btn_Course.Location = new System.Drawing.Point(0, 159);
            this.btn_Course.Name = "btn_Course";
            this.btn_Course.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Course.Size = new System.Drawing.Size(213, 74);
            this.btn_Course.TabIndex = 1;
            this.btn_Course.Text = "Danh sách lớp";
            this.btn_Course.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Course.UseVisualStyleBackColor = false;
            this.btn_Course.Click += new System.EventHandler(this.btn_Course_Click);
            // 
            // panel_logo
            // 
            this.panel_logo.Controls.Add(this.lb_TenNhom);
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Margin = new System.Windows.Forms.Padding(4);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(213, 159);
            this.panel_logo.TabIndex = 1;
            this.panel_logo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_logo_Paint);
            // 
            // panel_side
            // 
            this.panel_side.AutoScroll = true;
            this.panel_side.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.panel_side.Controls.Add(this.btn_Course);
            this.panel_side.Controls.Add(this.panel_logo);
            this.panel_side.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_side.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.panel_side.Location = new System.Drawing.Point(0, 0);
            this.panel_side.Margin = new System.Windows.Forms.Padding(4);
            this.panel_side.Name = "panel_side";
            this.panel_side.Size = new System.Drawing.Size(213, 865);
            this.panel_side.TabIndex = 4;
            this.panel_side.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_side_Paint);
            // 
            // GUI_GiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1373, 865);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_side);
            this.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GUI_GiaoVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI_GiaoVien";
            this.panel_cover.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_main.ResumeLayout(false);
            this.panel_logo.ResumeLayout(false);
            this.panel_logo.PerformLayout();
            this.panel_side.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_cover;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_TenTaiKhoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Label lb_TenNhom;
        private System.Windows.Forms.Button btn_Course;
        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.Panel panel_side;
    }
}