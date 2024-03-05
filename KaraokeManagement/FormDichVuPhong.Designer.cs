namespace KaraokeManagement
{
    partial class FormDichVuPhong
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
            label1 = new Label();
            txtId = new TextBox();
            label2 = new Label();
            txtTimDichVu = new TextBox();
            label3 = new Label();
            cbbDichVu = new ComboBox();
            button1 = new Button();
            label4 = new Label();
            txtSoluong = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(136, 77);
            label1.Name = "label1";
            label1.Size = new Size(194, 32);
            label1.TabIndex = 0;
            label1.Text = "BookingDetail ID";
            // 
            // txtId
            // 
            txtId.Location = new Point(405, 74);
            txtId.Name = "txtId";
            txtId.Size = new Size(462, 39);
            txtId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(136, 168);
            label2.Name = "label2";
            label2.Size = new Size(139, 32);
            label2.TabIndex = 2;
            label2.Text = "Tìm dịch vụ";
            // 
            // txtTimDichVu
            // 
            txtTimDichVu.Location = new Point(405, 168);
            txtTimDichVu.Name = "txtTimDichVu";
            txtTimDichVu.Size = new Size(462, 39);
            txtTimDichVu.TabIndex = 3;
            txtTimDichVu.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(136, 261);
            label3.Name = "label3";
            label3.Size = new Size(156, 32);
            label3.TabIndex = 4;
            label3.Text = "Chọn dịch vụ";
            // 
            // cbbDichVu
            // 
            cbbDichVu.FormattingEnabled = true;
            cbbDichVu.Location = new Point(405, 258);
            cbbDichVu.Name = "cbbDichVu";
            cbbDichVu.Size = new Size(462, 40);
            cbbDichVu.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(435, 405);
            button1.Name = "button1";
            button1.Size = new Size(379, 46);
            button1.TabIndex = 6;
            button1.Text = "Thêm dịch vụ cho phòng";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(136, 326);
            label4.Name = "label4";
            label4.Size = new Size(110, 32);
            label4.TabIndex = 7;
            label4.Text = "Số lượng";
            // 
            // txtSoluong
            // 
            txtSoluong.Location = new Point(405, 319);
            txtSoluong.Name = "txtSoluong";
            txtSoluong.Size = new Size(462, 39);
            txtSoluong.TabIndex = 8;
            // 
            // FormDichVuPhong
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1106, 516);
            Controls.Add(txtSoluong);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(cbbDichVu);
            Controls.Add(label3);
            Controls.Add(txtTimDichVu);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Name = "FormDichVuPhong";
            Text = "FormDichVuPhong";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtId;
        private Label label2;
        private TextBox txtTimDichVu;
        private Label label3;
        private ComboBox cbbDichVu;
        private Button button1;
        private Label label4;
        private TextBox txtSoluong;
    }
}