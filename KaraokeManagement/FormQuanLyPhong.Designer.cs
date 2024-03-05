namespace KaraokeManagement
{
    partial class FormQuanLyPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLyPhong));
            tblRoom = new DataGridView();
            roomNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            roomTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isOccupiedDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            roomBindingSource = new BindingSource(components);
            panel1 = new Panel();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtRoomNum = new TextBox();
            cbbRoomType = new ComboBox();
            cbbRoomRate = new ComboBox();
            cbbIsOccpied = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            txtId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)tblRoom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roomBindingSource).BeginInit();
            panel1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tblRoom
            // 
            tblRoom.AutoGenerateColumns = false;
            tblRoom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblRoom.Columns.AddRange(new DataGridViewColumn[] { roomNumberDataGridViewTextBoxColumn, roomTypeDataGridViewTextBoxColumn, rateDataGridViewTextBoxColumn, isOccupiedDataGridViewCheckBoxColumn });
            tblRoom.DataSource = roomBindingSource;
            tblRoom.Dock = DockStyle.Fill;
            tblRoom.Location = new Point(0, 42);
            tblRoom.Name = "tblRoom";
            tblRoom.RowHeadersWidth = 82;
            tblRoom.RowTemplate.Height = 41;
            tblRoom.Size = new Size(1181, 270);
            tblRoom.TabIndex = 0;
            tblRoom.CellClick += tblRoom_CellClick;
            tblRoom.CellContentClick += dataGridView1_CellContentClick;
            // 
            // roomNumberDataGridViewTextBoxColumn
            // 
            roomNumberDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            roomNumberDataGridViewTextBoxColumn.DataPropertyName = "RoomNumber";
            roomNumberDataGridViewTextBoxColumn.HeaderText = "RoomNumber";
            roomNumberDataGridViewTextBoxColumn.MinimumWidth = 10;
            roomNumberDataGridViewTextBoxColumn.Name = "roomNumberDataGridViewTextBoxColumn";
            roomNumberDataGridViewTextBoxColumn.Width = 200;
            // 
            // roomTypeDataGridViewTextBoxColumn
            // 
            roomTypeDataGridViewTextBoxColumn.DataPropertyName = "RoomType";
            roomTypeDataGridViewTextBoxColumn.HeaderText = "RoomType";
            roomTypeDataGridViewTextBoxColumn.MinimumWidth = 10;
            roomTypeDataGridViewTextBoxColumn.Name = "roomTypeDataGridViewTextBoxColumn";
            roomTypeDataGridViewTextBoxColumn.Width = 200;
            // 
            // rateDataGridViewTextBoxColumn
            // 
            rateDataGridViewTextBoxColumn.DataPropertyName = "Rate";
            rateDataGridViewTextBoxColumn.HeaderText = "Rate";
            rateDataGridViewTextBoxColumn.MinimumWidth = 10;
            rateDataGridViewTextBoxColumn.Name = "rateDataGridViewTextBoxColumn";
            rateDataGridViewTextBoxColumn.Width = 200;
            // 
            // isOccupiedDataGridViewCheckBoxColumn
            // 
            isOccupiedDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            isOccupiedDataGridViewCheckBoxColumn.DataPropertyName = "IsOccupied";
            isOccupiedDataGridViewCheckBoxColumn.HeaderText = "IsOccupied";
            isOccupiedDataGridViewCheckBoxColumn.MinimumWidth = 10;
            isOccupiedDataGridViewCheckBoxColumn.Name = "isOccupiedDataGridViewCheckBoxColumn";
            // 
            // roomBindingSource
            // 
            roomBindingSource.DataSource = typeof(Model.Room);
            // 
            // panel1
            // 
            panel1.Controls.Add(tblRoom);
            panel1.Controls.Add(toolStrip1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 301);
            panel1.Name = "panel1";
            panel1.Size = new Size(1181, 312);
            panel1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1181, 42);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(79, 36);
            toolStripButton1.Text = "Thêm";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(57, 36);
            toolStripButton2.Text = "Sửa";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(58, 36);
            toolStripButton3.Text = "Xóa";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 92);
            label1.Name = "label1";
            label1.Size = new Size(118, 32);
            label1.TabIndex = 2;
            label1.Text = "Số phòng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(113, 155);
            label2.Name = "label2";
            label2.Size = new Size(134, 32);
            label2.TabIndex = 3;
            label2.Text = "Loại phòng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(598, 92);
            label3.Name = "label3";
            label3.Size = new Size(110, 32);
            label3.TabIndex = 4;
            label3.Text = "Đánh giá";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(598, 175);
            label4.Name = "label4";
            label4.Size = new Size(189, 32);
            label4.TabIndex = 5;
            label4.Text = "Đang hoạt động";
            // 
            // txtRoomNum
            // 
            txtRoomNum.Location = new Point(272, 92);
            txtRoomNum.Name = "txtRoomNum";
            txtRoomNum.Size = new Size(200, 39);
            txtRoomNum.TabIndex = 6;
            // 
            // cbbRoomType
            // 
            cbbRoomType.FormattingEnabled = true;
            cbbRoomType.Items.AddRange(new object[] { "VIP", "Regular" });
            cbbRoomType.Location = new Point(276, 159);
            cbbRoomType.Name = "cbbRoomType";
            cbbRoomType.Size = new Size(242, 40);
            cbbRoomType.TabIndex = 7;
            cbbRoomType.Text = "Nhấn để chọn";
            // 
            // cbbRoomRate
            // 
            cbbRoomRate.FormattingEnabled = true;
            cbbRoomRate.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cbbRoomRate.Location = new Point(793, 84);
            cbbRoomRate.Name = "cbbRoomRate";
            cbbRoomRate.Size = new Size(242, 40);
            cbbRoomRate.TabIndex = 8;
            cbbRoomRate.Text = "Nhấn để chọn";
            // 
            // cbbIsOccpied
            // 
            cbbIsOccpied.FormattingEnabled = true;
            cbbIsOccpied.Items.AddRange(new object[] { "Có", "Không" });
            cbbIsOccpied.Location = new Point(793, 172);
            cbbIsOccpied.Name = "cbbIsOccpied";
            cbbIsOccpied.Size = new Size(242, 40);
            cbbIsOccpied.TabIndex = 9;
            cbbIsOccpied.Text = "Nhấn để chọn";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1059, 87);
            label5.Name = "label5";
            label5.Size = new Size(53, 32);
            label5.TabIndex = 10;
            label5.Text = "Sao";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(113, 37);
            label6.Name = "label6";
            label6.Size = new Size(114, 32);
            label6.TabIndex = 11;
            label6.Text = "ID phòng";
            // 
            // txtId
            // 
            txtId.Location = new Point(272, 34);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(200, 39);
            txtId.TabIndex = 12;
            // 
            // FormQuanLyPhong
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1181, 613);
            Controls.Add(txtId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(cbbIsOccpied);
            Controls.Add(cbbRoomRate);
            Controls.Add(cbbRoomType);
            Controls.Add(txtRoomNum);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "FormQuanLyPhong";
            Text = "FormQuanLyPhong";
            Load += FormQuanLyPhong_Load;
            ((System.ComponentModel.ISupportInitialize)tblRoom).EndInit();
            ((System.ComponentModel.ISupportInitialize)roomBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tblRoom;
        private Panel panel1;
        private BindingSource roomBindingSource;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtRoomNum;
        private ComboBox cbbRoomType;
        private ComboBox cbbRoomRate;
        private ComboBox cbbIsOccpied;
        private Label label5;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private DataGridViewTextBoxColumn roomNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roomTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rateDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isOccupiedDataGridViewCheckBoxColumn;
        private Label label6;
        private TextBox txtId;
    }
}