namespace KaraokeManagement
{
    partial class FormLichDatPhong
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
            label1 = new Label();
            txtRoomNum = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            tblBookingHistory = new DataGridView();
            bookingIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            customerIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            roomIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            checkInDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            checkOutDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalAmountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bookingHistoryDTOBindingSource = new BindingSource(components);
            bookingHistoryDTOBindingSource2 = new BindingSource(components);
            bookingBindingSource = new BindingSource(components);
            button1 = new Button();
            dtpCheckInDate = new DateTimePicker();
            label3 = new Label();
            bookingHistoryDTOBindingSource1 = new BindingSource(components);
            btnAddService = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tblBookingHistory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookingHistoryDTOBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookingHistoryDTOBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookingBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookingHistoryDTOBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(250, 154);
            label1.Name = "label1";
            label1.Size = new Size(118, 32);
            label1.TabIndex = 0;
            label1.Text = "Số phòng";
            // 
            // txtRoomNum
            // 
            txtRoomNum.Location = new Point(456, 151);
            txtRoomNum.Name = "txtRoomNum";
            txtRoomNum.Size = new Size(546, 39);
            txtRoomNum.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            label2.Location = new Point(510, 29);
            label2.Name = "label2";
            label2.Size = new Size(449, 65);
            label2.TabIndex = 2;
            label2.Text = "Lịch sử đặt phòng";
            label2.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(tblBookingHistory);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 377);
            panel1.Name = "panel1";
            panel1.Size = new Size(1466, 367);
            panel1.TabIndex = 3;
            // 
            // tblBookingHistory
            // 
            tblBookingHistory.AutoGenerateColumns = false;
            tblBookingHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblBookingHistory.Columns.AddRange(new DataGridViewColumn[] { bookingIDDataGridViewTextBoxColumn, customerIDDataGridViewTextBoxColumn, roomIDDataGridViewTextBoxColumn, checkInDateDataGridViewTextBoxColumn, checkOutDateDataGridViewTextBoxColumn, totalAmountDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn });
            tblBookingHistory.DataSource = bookingHistoryDTOBindingSource;
            tblBookingHistory.Dock = DockStyle.Fill;
            tblBookingHistory.Location = new Point(0, 0);
            tblBookingHistory.Name = "tblBookingHistory";
            tblBookingHistory.RowHeadersWidth = 82;
            tblBookingHistory.RowTemplate.Height = 41;
            tblBookingHistory.Size = new Size(1466, 367);
            tblBookingHistory.TabIndex = 0;
            // 
            // bookingIDDataGridViewTextBoxColumn
            // 
            bookingIDDataGridViewTextBoxColumn.DataPropertyName = "BookingID";
            bookingIDDataGridViewTextBoxColumn.HeaderText = "BookingID";
            bookingIDDataGridViewTextBoxColumn.MinimumWidth = 10;
            bookingIDDataGridViewTextBoxColumn.Name = "bookingIDDataGridViewTextBoxColumn";
            bookingIDDataGridViewTextBoxColumn.Width = 200;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            customerIDDataGridViewTextBoxColumn.MinimumWidth = 10;
            customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            customerIDDataGridViewTextBoxColumn.Width = 200;
            // 
            // roomIDDataGridViewTextBoxColumn
            // 
            roomIDDataGridViewTextBoxColumn.DataPropertyName = "RoomID";
            roomIDDataGridViewTextBoxColumn.HeaderText = "RoomID";
            roomIDDataGridViewTextBoxColumn.MinimumWidth = 10;
            roomIDDataGridViewTextBoxColumn.Name = "roomIDDataGridViewTextBoxColumn";
            roomIDDataGridViewTextBoxColumn.Width = 200;
            // 
            // checkInDateDataGridViewTextBoxColumn
            // 
            checkInDateDataGridViewTextBoxColumn.DataPropertyName = "CheckInDate";
            checkInDateDataGridViewTextBoxColumn.HeaderText = "CheckInDate";
            checkInDateDataGridViewTextBoxColumn.MinimumWidth = 10;
            checkInDateDataGridViewTextBoxColumn.Name = "checkInDateDataGridViewTextBoxColumn";
            checkInDateDataGridViewTextBoxColumn.Width = 200;
            // 
            // checkOutDateDataGridViewTextBoxColumn
            // 
            checkOutDateDataGridViewTextBoxColumn.DataPropertyName = "CheckOutDate";
            checkOutDateDataGridViewTextBoxColumn.HeaderText = "CheckOutDate";
            checkOutDateDataGridViewTextBoxColumn.MinimumWidth = 10;
            checkOutDateDataGridViewTextBoxColumn.Name = "checkOutDateDataGridViewTextBoxColumn";
            checkOutDateDataGridViewTextBoxColumn.Width = 200;
            // 
            // totalAmountDataGridViewTextBoxColumn
            // 
            totalAmountDataGridViewTextBoxColumn.DataPropertyName = "TotalAmount";
            totalAmountDataGridViewTextBoxColumn.HeaderText = "TotalAmount";
            totalAmountDataGridViewTextBoxColumn.MinimumWidth = 10;
            totalAmountDataGridViewTextBoxColumn.Name = "totalAmountDataGridViewTextBoxColumn";
            totalAmountDataGridViewTextBoxColumn.Width = 200;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.MinimumWidth = 10;
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            statusDataGridViewTextBoxColumn.Width = 200;
            // 
            // bookingHistoryDTOBindingSource
            // 
            bookingHistoryDTOBindingSource.DataSource = typeof(DTO.BookingHistoryDTO);
            // 
            // bookingHistoryDTOBindingSource2
            // 
            bookingHistoryDTOBindingSource2.DataSource = typeof(DTO.BookingHistoryDTO);
            // 
            // bookingBindingSource
            // 
            bookingBindingSource.DataSource = typeof(Model.Booking);
            // 
            // button1
            // 
            button1.Location = new Point(1034, 147);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 4;
            button1.Text = "Tìm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dtpCheckInDate
            // 
            dtpCheckInDate.Location = new Point(456, 229);
            dtpCheckInDate.Name = "dtpCheckInDate";
            dtpCheckInDate.Size = new Size(546, 39);
            dtpCheckInDate.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(250, 229);
            label3.Name = "label3";
            label3.Size = new Size(165, 32);
            label3.TabIndex = 6;
            label3.Text = "Ngày check in";
            // 
            // bookingHistoryDTOBindingSource1
            // 
            bookingHistoryDTOBindingSource1.DataSource = typeof(DTO.BookingHistoryDTO);
            // 
            // btnAddService
            // 
            btnAddService.Location = new Point(1141, 313);
            btnAddService.Name = "btnAddService";
            btnAddService.Size = new Size(313, 46);
            btnAddService.TabIndex = 7;
            btnAddService.Text = "Thêm dịch vụ cho phòng";
            btnAddService.UseVisualStyleBackColor = true;
            btnAddService.Click += btnAddService_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 325);
            button2.Name = "button2";
            button2.Size = new Size(341, 46);
            button2.TabIndex = 8;
            button2.Text = "Xem thông tin khách hàng";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(961, 313);
            button3.Name = "button3";
            button3.Size = new Size(150, 46);
            button3.TabIndex = 9;
            button3.Text = "Trả phòng";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(755, 313);
            button4.Name = "button4";
            button4.Size = new Size(150, 46);
            button4.TabIndex = 10;
            button4.Text = "Refresh";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(432, 325);
            button5.Name = "button5";
            button5.Size = new Size(150, 46);
            button5.TabIndex = 11;
            button5.Text = "Xem tất cả";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // FormLichDatPhong
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1466, 744);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnAddService);
            Controls.Add(label3);
            Controls.Add(dtpCheckInDate);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(txtRoomNum);
            Controls.Add(label1);
            Name = "FormLichDatPhong";
            Text = "FormLichDatPhong";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tblBookingHistory).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookingHistoryDTOBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookingHistoryDTOBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookingBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookingHistoryDTOBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtRoomNum;
        private Label label2;
        private Panel panel1;
        private Button button1;
        private DateTimePicker dtpCheckInDate;
        private Label label3;
        private BindingSource bookingBindingSource;
        private BindingSource bookingHistoryDTOBindingSource;
        private BindingSource bookingHistoryDTOBindingSource1;
        private DataGridView tblBookingHistory;
        private DataGridViewTextBoxColumn bookingIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roomIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn checkInDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn checkOutDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private BindingSource bookingHistoryDTOBindingSource2;
        private Button btnAddService;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}