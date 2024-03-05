namespace KaraokeManagement
{
    partial class FormThongKe
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
            sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            label1 = new Label();
            label2 = new Label();
            txtNam = new TextBox();
            cbbThang = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // sqliteCommand1
            // 
            sqliteCommand1.CommandTimeout = 30;
            sqliteCommand1.Connection = null;
            sqliteCommand1.Transaction = null;
            sqliteCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 626);
            label1.Name = "label1";
            label1.Size = new Size(81, 32);
            label1.TabIndex = 1;
            label1.Text = "Tháng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 699);
            label2.Name = "label2";
            label2.Size = new Size(65, 32);
            label2.TabIndex = 2;
            label2.Text = "Năm";
            // 
            // txtNam
            // 
            txtNam.Location = new Point(140, 699);
            txtNam.Name = "txtNam";
            txtNam.Size = new Size(242, 39);
            txtNam.TabIndex = 3;
            txtNam.Text = "2023";
            // 
            // cbbThang
            // 
            cbbThang.FormattingEnabled = true;
            cbbThang.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            cbbThang.Location = new Point(140, 626);
            cbbThang.Name = "cbbThang";
            cbbThang.Size = new Size(242, 40);
            cbbThang.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(430, 660);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 5;
            button1.Text = "Thống kê";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormThongKe
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1392, 763);
            Controls.Add(button1);
            Controls.Add(cbbThang);
            Controls.Add(txtNam);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormThongKe";
            Text = "FormThongKe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
        private Label label1;
        private Label label2;
        private TextBox txtNam;
        private ComboBox cbbThang;
        private Button button1;
    }
}