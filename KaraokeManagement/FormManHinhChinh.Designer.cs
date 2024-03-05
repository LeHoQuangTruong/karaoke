namespace KaraokeManagement
{
    partial class FormManHinhChinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManHinhChinh));
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            quảnLýDịchVụToolStripMenuItem = new ToolStripMenuItem();
            quảnLýPhòngToolStripMenuItem = new ToolStripMenuItem();
            quảnLýĐặtPhòngToolStripMenuItem = new ToolStripMenuItem();
            quảnLýKháchHàngToolStripMenuItem = new ToolStripMenuItem();
            quảnLýNhânViênToolStripMenuItem = new ToolStripMenuItem();
            toolStripButton1 = new ToolStripButton();
            labelTenNhanVien = new ToolStripLabel();
            label1 = new Label();
            txtTimPhong = new TextBox();
            cbbPhong = new ComboBox();
            label2 = new Label();
            cbbLoaiPhong = new ComboBox();
            label3 = new Label();
            txtTimKH = new TextBox();
            label4 = new Label();
            cbbLoaiKhach = new ComboBox();
            btnThemKH = new Button();
            dtpCheckInDate = new DateTimePicker();
            button2 = new Button();
            dtpGioVao = new DateTimePicker();
            dtpGioRa = new DateTimePicker();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            dtpCheckOutDate = new DateTimePicker();
            label5 = new Label();
            txtSl = new TextBox();
            cbbKhachHang = new ComboBox();
            btnCheckHistory = new Button();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1, toolStripButton1, labelTenNhanVien });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1377, 42);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { quảnLýDịchVụToolStripMenuItem, quảnLýPhòngToolStripMenuItem, quảnLýĐặtPhòngToolStripMenuItem, quảnLýKháchHàngToolStripMenuItem, quảnLýNhânViênToolStripMenuItem });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(119, 36);
            toolStripDropDownButton1.Text = "Quản lý";
            // 
            // quảnLýDịchVụToolStripMenuItem
            // 
            quảnLýDịchVụToolStripMenuItem.Name = "quảnLýDịchVụToolStripMenuItem";
            quảnLýDịchVụToolStripMenuItem.Size = new Size(361, 44);
            quảnLýDịchVụToolStripMenuItem.Text = "Quản lý dịch vụ";
            quảnLýDịchVụToolStripMenuItem.Click += quảnLýDịchVụToolStripMenuItem_Click;
            // 
            // quảnLýPhòngToolStripMenuItem
            // 
            quảnLýPhòngToolStripMenuItem.Name = "quảnLýPhòngToolStripMenuItem";
            quảnLýPhòngToolStripMenuItem.Size = new Size(361, 44);
            quảnLýPhòngToolStripMenuItem.Text = "Quản lý phòng";
            // 
            // quảnLýĐặtPhòngToolStripMenuItem
            // 
            quảnLýĐặtPhòngToolStripMenuItem.Name = "quảnLýĐặtPhòngToolStripMenuItem";
            quảnLýĐặtPhòngToolStripMenuItem.Size = new Size(361, 44);
            quảnLýĐặtPhòngToolStripMenuItem.Text = "Quản lý Đặt phòng";
            quảnLýĐặtPhòngToolStripMenuItem.Click += quảnLýĐặtPhòngToolStripMenuItem_Click;
            // 
            // quảnLýKháchHàngToolStripMenuItem
            // 
            quảnLýKháchHàngToolStripMenuItem.Name = "quảnLýKháchHàngToolStripMenuItem";
            quảnLýKháchHàngToolStripMenuItem.Size = new Size(361, 44);
            quảnLýKháchHàngToolStripMenuItem.Text = "Quản lý khách hàng";
            quảnLýKháchHàngToolStripMenuItem.Click += quảnLýKháchHàngToolStripMenuItem_Click;
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            quảnLýNhânViênToolStripMenuItem.Size = new Size(361, 44);
            quảnLýNhânViênToolStripMenuItem.Text = "Quản lý nhân viên";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(210, 36);
            toolStripButton1.Text = "Thống kê báo cáo";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // labelTenNhanVien
            // 
            labelTenNhanVien.Alignment = ToolStripItemAlignment.Right;
            labelTenNhanVien.Name = "labelTenNhanVien";
            labelTenNhanVien.Size = new Size(0, 36);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 201);
            label1.Name = "label1";
            label1.Size = new Size(259, 32);
            label1.TabIndex = 1;
            label1.Text = "Chọn phòng muốn đặt";
            // 
            // txtTimPhong
            // 
            txtTimPhong.Location = new Point(392, 137);
            txtTimPhong.Name = "txtTimPhong";
            txtTimPhong.Size = new Size(241, 39);
            txtTimPhong.TabIndex = 2;
            txtTimPhong.TextChanged += txtTimPhong_TextChanged;
            txtTimPhong.KeyPress += txtTimPhong_KeyPress;
            // 
            // cbbPhong
            // 
            cbbPhong.FormattingEnabled = true;
            cbbPhong.Location = new Point(391, 198);
            cbbPhong.Name = "cbbPhong";
            cbbPhong.Size = new Size(743, 40);
            cbbPhong.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(720, 137);
            label2.Name = "label2";
            label2.Size = new Size(134, 32);
            label2.TabIndex = 4;
            label2.Text = "Loại phòng";
            // 
            // cbbLoaiPhong
            // 
            cbbLoaiPhong.FormattingEnabled = true;
            cbbLoaiPhong.Items.AddRange(new object[] { "VIP", "Regular" });
            cbbLoaiPhong.Location = new Point(892, 134);
            cbbLoaiPhong.Name = "cbbLoaiPhong";
            cbbLoaiPhong.Size = new Size(242, 40);
            cbbLoaiPhong.TabIndex = 5;
            cbbLoaiPhong.Text = "Chọn loại";
            cbbLoaiPhong.SelectedIndexChanged += cbbLoaiPhong_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(89, 391);
            label3.Name = "label3";
            label3.Size = new Size(188, 32);
            label3.TabIndex = 6;
            label3.Text = "Tên khách hàng:";
            // 
            // txtTimKH
            // 
            txtTimKH.Location = new Point(392, 298);
            txtTimKH.Name = "txtTimKH";
            txtTimKH.Size = new Size(241, 39);
            txtTimKH.TabIndex = 7;
            txtTimKH.TextChanged += txtTimKH_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(720, 301);
            label4.Name = "label4";
            label4.Size = new Size(127, 32);
            label4.TabIndex = 8;
            label4.Text = "Loại khách";
            // 
            // cbbLoaiKhach
            // 
            cbbLoaiKhach.FormattingEnabled = true;
            cbbLoaiKhach.Items.AddRange(new object[] { "Khách lẻ", "Khách quen" });
            cbbLoaiKhach.Location = new Point(892, 297);
            cbbLoaiKhach.Name = "cbbLoaiKhach";
            cbbLoaiKhach.Size = new Size(242, 40);
            cbbLoaiKhach.TabIndex = 9;
            cbbLoaiKhach.Text = "Chọn loại";
            cbbLoaiKhach.SelectedIndexChanged += cbbLoaiKhach_SelectedIndexChanged;
            // 
            // btnThemKH
            // 
            btnThemKH.Location = new Point(1163, 293);
            btnThemKH.Name = "btnThemKH";
            btnThemKH.Size = new Size(202, 46);
            btnThemKH.TabIndex = 10;
            btnThemKH.Text = "Thêm khách";
            btnThemKH.UseVisualStyleBackColor = true;
            // 
            // dtpCheckInDate
            // 
            dtpCheckInDate.Format = DateTimePickerFormat.Short;
            dtpCheckInDate.Location = new Point(392, 505);
            dtpCheckInDate.Name = "dtpCheckInDate";
            dtpCheckInDate.ShowUpDown = true;
            dtpCheckInDate.Size = new Size(181, 39);
            dtpCheckInDate.TabIndex = 14;
            // 
            // button2
            // 
            button2.Location = new Point(536, 686);
            button2.Name = "button2";
            button2.Size = new Size(202, 46);
            button2.TabIndex = 16;
            button2.Text = "Đặt phòng";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dtpGioVao
            // 
            dtpGioVao.CustomFormat = "HH:mm";
            dtpGioVao.Format = DateTimePickerFormat.Custom;
            dtpGioVao.Location = new Point(625, 505);
            dtpGioVao.Name = "dtpGioVao";
            dtpGioVao.Size = new Size(170, 39);
            dtpGioVao.TabIndex = 17;
            // 
            // dtpGioRa
            // 
            dtpGioRa.CustomFormat = "HH:mm";
            dtpGioRa.Format = DateTimePickerFormat.Custom;
            dtpGioRa.Location = new Point(625, 578);
            dtpGioRa.Name = "dtpGioRa";
            dtpGioRa.Size = new Size(170, 39);
            dtpGioRa.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(273, 505);
            label7.Name = "label7";
            label7.Size = new Size(75, 32);
            label7.TabIndex = 19;
            label7.Text = "Ngày:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(89, 134);
            label8.Name = "label8";
            label8.Size = new Size(180, 32);
            label8.TabIndex = 20;
            label8.Text = "Nhập số phòng";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(89, 301);
            label9.Name = "label9";
            label9.Size = new Size(245, 32);
            label9.TabIndex = 21;
            label9.Text = "Nhập tên khách hàng";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(273, 583);
            label10.Name = "label10";
            label10.Size = new Size(75, 32);
            label10.TabIndex = 23;
            label10.Text = "Ngày:";
            // 
            // dtpCheckOutDate
            // 
            dtpCheckOutDate.Format = DateTimePickerFormat.Short;
            dtpCheckOutDate.Location = new Point(392, 583);
            dtpCheckOutDate.Name = "dtpCheckOutDate";
            dtpCheckOutDate.Size = new Size(203, 39);
            dtpCheckOutDate.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(88, 450);
            label5.Name = "label5";
            label5.Size = new Size(185, 32);
            label5.TabIndex = 25;
            label5.Text = "Số lượng khách:";
            // 
            // txtSl
            // 
            txtSl.Location = new Point(391, 447);
            txtSl.Name = "txtSl";
            txtSl.Size = new Size(242, 39);
            txtSl.TabIndex = 24;
            // 
            // cbbKhachHang
            // 
            cbbKhachHang.FormattingEnabled = true;
            cbbKhachHang.Location = new Point(391, 389);
            cbbKhachHang.Name = "cbbKhachHang";
            cbbKhachHang.Size = new Size(743, 40);
            cbbKhachHang.TabIndex = 26;
            // 
            // btnCheckHistory
            // 
            btnCheckHistory.Location = new Point(868, 505);
            btnCheckHistory.Name = "btnCheckHistory";
            btnCheckHistory.Size = new Size(349, 75);
            btnCheckHistory.TabIndex = 27;
            btnCheckHistory.Text = "Xem lịch đặt của phòng này";
            btnCheckHistory.UseVisualStyleBackColor = true;
            btnCheckHistory.Click += btnCheckHistory_Click;
            // 
            // FormManHinhChinh
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1377, 744);
            Controls.Add(btnCheckHistory);
            Controls.Add(cbbKhachHang);
            Controls.Add(label5);
            Controls.Add(txtSl);
            Controls.Add(label10);
            Controls.Add(dtpCheckOutDate);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(dtpGioRa);
            Controls.Add(dtpGioVao);
            Controls.Add(button2);
            Controls.Add(dtpCheckInDate);
            Controls.Add(btnThemKH);
            Controls.Add(cbbLoaiKhach);
            Controls.Add(label4);
            Controls.Add(txtTimKH);
            Controls.Add(label3);
            Controls.Add(cbbLoaiPhong);
            Controls.Add(label2);
            Controls.Add(cbbPhong);
            Controls.Add(txtTimPhong);
            Controls.Add(label1);
            Controls.Add(toolStrip1);
            Name = "FormManHinhChinh";
            Text = "FormManHinhChinh";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem quảnLýDịchVụToolStripMenuItem;
        private ToolStripMenuItem quảnLýPhòngToolStripMenuItem;
        private ToolStripMenuItem quảnLýĐặtPhòngToolStripMenuItem;
        private ToolStripMenuItem quảnLýKháchHàngToolStripMenuItem;
        private ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private ToolStripButton toolStripButton1;
        private ToolStripLabel labelTenNhanVien;
        private Label label1;
        private TextBox txtTimPhong;
        private ComboBox cbbPhong;
        private Label label2;
        private ComboBox cbbLoaiPhong;
        private Label label3;
        private TextBox txtTimKH;
        private Label label4;
        private ComboBox cbbLoaiKhach;
        private Button btnThemKH;
        private DateTimePicker dtpCheckInDate;
        private Button button2;
        private DateTimePicker dtpGioVao;
        private DateTimePicker dtpGioRa;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private DateTimePicker dtpCheckOutDate;
        private Label label5;
        private TextBox txtSl;
        private ComboBox cbbKhachHang;
        private Button btnCheckHistory;
    }
}