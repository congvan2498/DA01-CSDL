namespace QL_BANHANG
{
    partial class FormQLDH
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ts_dangxuat = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbDsSP = new System.Windows.Forms.ComboBox();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.btn_themCT_HD = new System.Windows.Forms.Button();
            this.txtGiagiam = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGiaban = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_mahd1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_makh = new System.Windows.Forms.ComboBox();
            this.btn_themHD = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_mahd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_XemDoanhthu = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDoanhthu = new System.Windows.Forms.TextBox();
            this.cmbNam = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbThang = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_XemDanhSach = new System.Windows.Forms.Button();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_dangxuat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ts_dangxuat
            // 
            this.ts_dangxuat.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.ts_dangxuat.Image = global::QL_BANHANG.Properties.Resources.logout_btn;
            this.ts_dangxuat.Name = "ts_dangxuat";
            this.ts_dangxuat.Size = new System.Drawing.Size(140, 29);
            this.ts_dangxuat.Text = "Đăng Xuất";
            this.ts_dangxuat.Click += new System.EventHandler(this.ts_dangxuat_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(12, 10);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1000, 529);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 43);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(992, 482);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "THÊM MỚI HÓA ĐƠN";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbDsSP);
            this.groupBox2.Controls.Add(this.txtSoluong);
            this.groupBox2.Controls.Add(this.btn_themCT_HD);
            this.groupBox2.Controls.Add(this.txtGiagiam);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtGiaban);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_mahd1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(431, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(561, 429);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thêm chi tiết hóa đơn:";
            // 
            // cmbDsSP
            // 
            this.cmbDsSP.FormattingEnabled = true;
            this.cmbDsSP.Location = new System.Drawing.Point(219, 107);
            this.cmbDsSP.Name = "cmbDsSP";
            this.cmbDsSP.Size = new System.Drawing.Size(218, 28);
            this.cmbDsSP.TabIndex = 2;
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(219, 169);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(218, 26);
            this.txtSoluong.TabIndex = 3;
            // 
            // btn_themCT_HD
            // 
            this.btn_themCT_HD.Location = new System.Drawing.Point(69, 351);
            this.btn_themCT_HD.Name = "btn_themCT_HD";
            this.btn_themCT_HD.Size = new System.Drawing.Size(137, 52);
            this.btn_themCT_HD.TabIndex = 6;
            this.btn_themCT_HD.Text = "Thêm";
            this.btn_themCT_HD.UseVisualStyleBackColor = true;
            this.btn_themCT_HD.Click += new System.EventHandler(this.btn_themCT_HD_Click);
            // 
            // txtGiagiam
            // 
            this.txtGiagiam.Location = new System.Drawing.Point(219, 289);
            this.txtGiagiam.Name = "txtGiagiam";
            this.txtGiagiam.Size = new System.Drawing.Size(218, 26);
            this.txtGiagiam.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Giá giảm:";
            // 
            // txtGiaban
            // 
            this.txtGiaban.Location = new System.Drawing.Point(219, 229);
            this.txtGiaban.Name = "txtGiaban";
            this.txtGiaban.Size = new System.Drawing.Size(218, 26);
            this.txtGiaban.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(65, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Giá bán:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Số lượng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Mã sản phẩm:";
            // 
            // txt_mahd1
            // 
            this.txt_mahd1.Location = new System.Drawing.Point(219, 47);
            this.txt_mahd1.Name = "txt_mahd1";
            this.txt_mahd1.ReadOnly = true;
            this.txt_mahd1.Size = new System.Drawing.Size(218, 26);
            this.txt_mahd1.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Mã hóa đơn:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 63);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(352, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "THÊM HÓA ĐƠN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_makh);
            this.groupBox1.Controls.Add(this.btn_themHD);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_mahd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 429);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm hóa đơn: ";
            // 
            // cmb_makh
            // 
            this.cmb_makh.FormattingEnabled = true;
            this.cmb_makh.Location = new System.Drawing.Point(175, 110);
            this.cmb_makh.Name = "cmb_makh";
            this.cmb_makh.Size = new System.Drawing.Size(218, 28);
            this.cmb_makh.TabIndex = 2;
            // 
            // btn_themHD
            // 
            this.btn_themHD.Location = new System.Drawing.Point(24, 212);
            this.btn_themHD.Name = "btn_themHD";
            this.btn_themHD.Size = new System.Drawing.Size(137, 52);
            this.btn_themHD.TabIndex = 3;
            this.btn_themHD.Text = "Thêm";
            this.btn_themHD.UseVisualStyleBackColor = true;
            this.btn_themHD.Click += new System.EventHandler(this.btn_themHD_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã khách hàng:";
            // 
            // txt_mahd
            // 
            this.txt_mahd.Location = new System.Drawing.Point(175, 47);
            this.txt_mahd.Name = "txt_mahd";
            this.txt_mahd.Size = new System.Drawing.Size(218, 26);
            this.txt_mahd.TabIndex = 1;
            this.txt_mahd.TextChanged += new System.EventHandler(this.txt_mahd_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã hóa đơn:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 43);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(992, 482);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "XEM HÓA ĐƠN VÀ DOANH THU";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.btn_XemDoanhthu);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.txtDoanhthu);
            this.groupBox4.Controls.Add(this.cmbNam);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.cmbThang);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(596, 7);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(388, 479);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thống kê doanh thu:";
            // 
            // btn_XemDoanhthu
            // 
            this.btn_XemDoanhthu.Location = new System.Drawing.Point(126, 341);
            this.btn_XemDoanhthu.Name = "btn_XemDoanhthu";
            this.btn_XemDoanhthu.Size = new System.Drawing.Size(136, 45);
            this.btn_XemDoanhthu.TabIndex = 6;
            this.btn_XemDoanhthu.Text = "Xem";
            this.btn_XemDoanhthu.UseVisualStyleBackColor = true;
            this.btn_XemDoanhthu.Click += new System.EventHandler(this.btn_XemDoanhthu_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 20);
            this.label11.TabIndex = 5;
            this.label11.Text = "Doanh thu:";
            // 
            // txtDoanhthu
            // 
            this.txtDoanhthu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoanhthu.Location = new System.Drawing.Point(32, 105);
            this.txtDoanhthu.Name = "txtDoanhthu";
            this.txtDoanhthu.ReadOnly = true;
            this.txtDoanhthu.Size = new System.Drawing.Size(306, 30);
            this.txtDoanhthu.TabIndex = 4;
            this.txtDoanhthu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmbNam
            // 
            this.cmbNam.FormattingEnabled = true;
            this.cmbNam.Items.AddRange(new object[] {
            "2020",
            "2021"});
            this.cmbNam.Location = new System.Drawing.Point(133, 248);
            this.cmbNam.Name = "cmbNam";
            this.cmbNam.Size = new System.Drawing.Size(205, 28);
            this.cmbNam.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 256);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Năm";
            // 
            // cmbThang
            // 
            this.cmbThang.FormattingEnabled = true;
            this.cmbThang.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cmbThang.Location = new System.Drawing.Point(133, 171);
            this.cmbThang.Name = "cmbThang";
            this.cmbThang.Size = new System.Drawing.Size(205, 28);
            this.cmbThang.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tháng:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvDanhSach);
            this.groupBox3.Controls.Add(this.btn_XemDanhSach);
            this.groupBox3.Location = new System.Drawing.Point(4, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(576, 475);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dạnh sách hóa đơn:";
            // 
            // btn_XemDanhSach
            // 
            this.btn_XemDanhSach.Location = new System.Drawing.Point(174, 394);
            this.btn_XemDanhSach.Name = "btn_XemDanhSach";
            this.btn_XemDanhSach.Size = new System.Drawing.Size(228, 52);
            this.btn_XemDanhSach.TabIndex = 1;
            this.btn_XemDanhSach.Text = "Xem danh sách";
            this.btn_XemDanhSach.UseVisualStyleBackColor = true;
            this.btn_XemDanhSach.Click += new System.EventHandler(this.btn_XemDanhSach_Click);
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvDanhSach.Location = new System.Drawing.Point(3, 22);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.ReadOnly = true;
            this.dgvDanhSach.RowHeadersWidth = 50;
            this.dgvDanhSach.RowTemplate.Height = 24;
            this.dgvDanhSach.Size = new System.Drawing.Size(570, 334);
            this.dgvDanhSach.TabIndex = 2;
            // 
            // FormQLDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormQLDH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormQLDH";
            this.Load += new System.EventHandler(this.FormQLDH_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ts_dangxuat;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.Button btn_themCT_HD;
        private System.Windows.Forms.TextBox txtGiagiam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGiaban;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_mahd1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_makh;
        private System.Windows.Forms.Button btn_themHD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_mahd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDsSP;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_XemDanhSach;
        private System.Windows.Forms.Button btn_XemDoanhthu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDoanhthu;
        private System.Windows.Forms.ComboBox cmbNam;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbThang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvDanhSach;
    }
}