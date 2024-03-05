
namespace KaraokeManagement
{
    partial class FormQuanLyKhachHang
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLyKhachHang));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtPhoneNum = new TextBox();
            txtEmail = new TextBox();
            txtAddress = new TextBox();
            panel1 = new Panel();
            tblKhachHang = new DataGridView();
            customerIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bookingsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            customerBindingSource = new BindingSource(components);
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            label6 = new Label();
            txtId = new TextBox();
            txtTimKH = new TextBox();
            label7 = new Label();
            btnSearch = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tblKhachHang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 111);
            label1.Name = "label1";
            label1.Size = new Size(134, 32);
            label1.TabIndex = 0;
            label1.Text = "First Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(564, 111);
            label2.Name = "label2";
            label2.Size = new Size(131, 32);
            label2.TabIndex = 1;
            label2.Text = "Last Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 195);
            label3.Name = "label3";
            label3.Size = new Size(182, 32);
            label3.TabIndex = 2;
            label3.Text = "Phone Number:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(564, 198);
            label4.Name = "label4";
            label4.Size = new Size(76, 32);
            label4.TabIndex = 3;
            label4.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(91, 261);
            label5.Name = "label5";
            label5.Size = new Size(103, 32);
            label5.TabIndex = 4;
            label5.Text = "Address:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(227, 108);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(287, 39);
            txtFirstName.TabIndex = 5;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(730, 108);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(287, 39);
            txtLastName.TabIndex = 6;
            // 
            // txtPhoneNum
            // 
            txtPhoneNum.Location = new Point(227, 195);
            txtPhoneNum.Name = "txtPhoneNum";
            txtPhoneNum.Size = new Size(287, 39);
            txtPhoneNum.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(730, 195);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(287, 39);
            txtEmail.TabIndex = 8;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(227, 261);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(790, 39);
            txtAddress.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.Controls.Add(tblKhachHang);
            panel1.Controls.Add(toolStrip1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 420);
            panel1.Name = "panel1";
            panel1.Size = new Size(1070, 295);
            panel1.TabIndex = 10;
            // 
            // tblKhachHang
            // 
            tblKhachHang.AutoGenerateColumns = false;
            tblKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblKhachHang.Columns.AddRange(new DataGridViewColumn[] { customerIDDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, phoneNumberDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, bookingsDataGridViewTextBoxColumn });
            tblKhachHang.DataSource = customerBindingSource;
            tblKhachHang.Dock = DockStyle.Fill;
            tblKhachHang.Location = new Point(0, 42);
            tblKhachHang.Name = "tblKhachHang";
            tblKhachHang.RowHeadersWidth = 82;
            tblKhachHang.RowTemplate.Height = 41;
            tblKhachHang.Size = new Size(1070, 253);
            tblKhachHang.TabIndex = 0;
            tblKhachHang.CellClick += tblKhachHang_CellClick;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            customerIDDataGridViewTextBoxColumn.MinimumWidth = 10;
            customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            customerIDDataGridViewTextBoxColumn.Width = 200;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            firstNameDataGridViewTextBoxColumn.MinimumWidth = 10;
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            firstNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            lastNameDataGridViewTextBoxColumn.MinimumWidth = 10;
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            lastNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 10;
            phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            phoneNumberDataGridViewTextBoxColumn.Width = 200;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.MinimumWidth = 10;
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.Width = 200;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.HeaderText = "Address";
            addressDataGridViewTextBoxColumn.MinimumWidth = 10;
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            addressDataGridViewTextBoxColumn.Width = 200;
            // 
            // bookingsDataGridViewTextBoxColumn
            // 
            bookingsDataGridViewTextBoxColumn.DataPropertyName = "Bookings";
            bookingsDataGridViewTextBoxColumn.HeaderText = "Bookings";
            bookingsDataGridViewTextBoxColumn.MinimumWidth = 10;
            bookingsDataGridViewTextBoxColumn.Name = "bookingsDataGridViewTextBoxColumn";
            bookingsDataGridViewTextBoxColumn.Width = 200;
            // 
            // customerBindingSource
            // 
            customerBindingSource.DataSource = typeof(Model.Customer);
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1070, 42);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(117, 36);
            toolStripButton1.Text = "Thêm KH";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(201, 36);
            toolStripButton2.Text = "Sửa thông tin KH";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(189, 36);
            toolStripButton3.Text = "Xóa khách hàng";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(42, 48);
            label6.Name = "label6";
            label6.Size = new Size(152, 32);
            label6.TabIndex = 11;
            label6.Text = "Customer ID:";
            // 
            // txtId
            // 
            txtId.Location = new Point(227, 48);
            txtId.Name = "txtId";
            txtId.Size = new Size(287, 39);
            txtId.TabIndex = 12;
            // 
            // txtTimKH
            // 
            txtTimKH.Location = new Point(227, 317);
            txtTimKH.Name = "txtTimKH";
            txtTimKH.Size = new Size(583, 39);
            txtTimKH.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(4, 317);
            label7.Name = "label7";
            label7.Size = new Size(190, 32);
            label7.TabIndex = 13;
            label7.Text = "Tìm khách hàng:";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(845, 313);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(150, 46);
            btnSearch.TabIndex = 15;
            btnSearch.Text = "Tìm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // FormQuanLyKhachHang
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 715);
            Controls.Add(btnSearch);
            Controls.Add(txtTimKH);
            Controls.Add(label7);
            Controls.Add(txtId);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(txtAddress);
            Controls.Add(txtEmail);
            Controls.Add(txtPhoneNum);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormQuanLyKhachHang";
            Text = "FormQuanLyKhachHang";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tblKhachHang).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtPhoneNum;
        private TextBox txtEmail;
        private TextBox txtAddress;
        private Panel panel1;
        private DataGridView tblKhachHang;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bookingsDataGridViewTextBoxColumn;
        private BindingSource customerBindingSource;
        private Label label6;
        private TextBox txtId;
        private TextBox txtTimKH;
        private Label label7;
        private Button btnSearch;
    }
}