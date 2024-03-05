namespace KaraokeManagement
{
    partial class FormThanhToan
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
            txtId = new TextBox();
            tblHoaDon = new DataGridView();
            bookingDetailIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            serviceNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            paymentDTOBindingSource = new BindingSource(components);
            label2 = new Label();
            txtTotalPrice = new TextBox();
            button1 = new Button();
            txtSerivcePrice = new TextBox();
            label3 = new Label();
            txtRoomPrice = new TextBox();
            label4 = new Label();
            btn = new Button();
            ((System.ComponentModel.ISupportInitialize)tblHoaDon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)paymentDTOBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 112);
            label1.Name = "label1";
            label1.Size = new Size(187, 32);
            label1.TabIndex = 0;
            label1.Text = "BookingDetailID";
            // 
            // txtId
            // 
            txtId.Location = new Point(331, 112);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(460, 39);
            txtId.TabIndex = 1;
            // 
            // tblHoaDon
            // 
            tblHoaDon.AutoGenerateColumns = false;
            tblHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblHoaDon.Columns.AddRange(new DataGridViewColumn[] { bookingDetailIDDataGridViewTextBoxColumn, serviceNameDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn });
            tblHoaDon.DataSource = paymentDTOBindingSource;
            tblHoaDon.Location = new Point(52, 201);
            tblHoaDon.Name = "tblHoaDon";
            tblHoaDon.RowHeadersWidth = 82;
            tblHoaDon.RowTemplate.Height = 41;
            tblHoaDon.ScrollBars = ScrollBars.None;
            tblHoaDon.Size = new Size(805, 300);
            tblHoaDon.TabIndex = 2;
            // 
            // bookingDetailIDDataGridViewTextBoxColumn
            // 
            bookingDetailIDDataGridViewTextBoxColumn.DataPropertyName = "BookingDetailID";
            bookingDetailIDDataGridViewTextBoxColumn.HeaderText = "BookingDetailID";
            bookingDetailIDDataGridViewTextBoxColumn.MinimumWidth = 10;
            bookingDetailIDDataGridViewTextBoxColumn.Name = "bookingDetailIDDataGridViewTextBoxColumn";
            bookingDetailIDDataGridViewTextBoxColumn.Width = 200;
            // 
            // serviceNameDataGridViewTextBoxColumn
            // 
            serviceNameDataGridViewTextBoxColumn.DataPropertyName = "ServiceName";
            serviceNameDataGridViewTextBoxColumn.HeaderText = "ServiceName";
            serviceNameDataGridViewTextBoxColumn.MinimumWidth = 10;
            serviceNameDataGridViewTextBoxColumn.Name = "serviceNameDataGridViewTextBoxColumn";
            serviceNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            quantityDataGridViewTextBoxColumn.MinimumWidth = 10;
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            quantityDataGridViewTextBoxColumn.Width = 200;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.MinimumWidth = 10;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.Width = 200;
            // 
            // paymentDTOBindingSource
            // 
            paymentDTOBindingSource.DataSource = typeof(DTO.PaymentDTO);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 681);
            label2.Name = "label2";
            label2.Size = new Size(129, 32);
            label2.TabIndex = 3;
            label2.Text = "Total price:";
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Location = new Point(255, 681);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.ReadOnly = true;
            txtTotalPrice.Size = new Size(519, 39);
            txtTotalPrice.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(564, 769);
            button1.Name = "button1";
            button1.Size = new Size(210, 46);
            button1.TabIndex = 5;
            button1.Text = "Thanh toán";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtSerivcePrice
            // 
            txtSerivcePrice.Location = new Point(255, 521);
            txtSerivcePrice.Name = "txtSerivcePrice";
            txtSerivcePrice.ReadOnly = true;
            txtSerivcePrice.Size = new Size(519, 39);
            txtSerivcePrice.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 521);
            label3.Name = "label3";
            label3.Size = new Size(212, 32);
            label3.TabIndex = 6;
            label3.Text = "Total Service price:";
            // 
            // txtRoomPrice
            // 
            txtRoomPrice.Location = new Point(255, 592);
            txtRoomPrice.Name = "txtRoomPrice";
            txtRoomPrice.ReadOnly = true;
            txtRoomPrice.Size = new Size(519, 39);
            txtRoomPrice.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(97, 595);
            label4.Name = "label4";
            label4.Size = new Size(139, 32);
            label4.TabIndex = 8;
            label4.Text = "Room Price:";
            // 
            // btn
            // 
            btn.Location = new Point(320, 769);
            btn.Name = "btn";
            btn.Size = new Size(219, 46);
            btn.TabIndex = 10;
            btn.Text = "Xuất hóa đơn";
            btn.UseVisualStyleBackColor = true;
            btn.Click += btnExportToImage_Click;
            // 
            // FormThanhToan
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 832);
            Controls.Add(btn);
            Controls.Add(txtRoomPrice);
            Controls.Add(label4);
            Controls.Add(txtSerivcePrice);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(txtTotalPrice);
            Controls.Add(label2);
            Controls.Add(tblHoaDon);
            Controls.Add(txtId);
            Controls.Add(label1);
            Name = "FormThanhToan";
            Text = "FormThanhToan";
            ((System.ComponentModel.ISupportInitialize)tblHoaDon).EndInit();
            ((System.ComponentModel.ISupportInitialize)paymentDTOBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtId;
        private DataGridView tblHoaDon;
        private Label label2;
        private TextBox txtTotalPrice;
        private Button button1;
        private DataGridViewTextBoxColumn bookingDetailIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn serviceNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private BindingSource paymentDTOBindingSource;
        private TextBox txtSerivcePrice;
        private Label label3;
        private TextBox txtRoomPrice;
        private Label label4;
        private Button btn;
    }
}