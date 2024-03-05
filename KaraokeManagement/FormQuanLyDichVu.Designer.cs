namespace KaraokeManagement
{
    partial class FormQuanLyDichVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLyDichVu));
            label1 = new Label();
            txtTenDV = new TextBox();
            label2 = new Label();
            txtGia = new TextBox();
            label4 = new Label();
            txtMota = new RichTextBox();
            txtId = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            tblService = new DataGridView();
            serviceNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            serviceBindingSource = new BindingSource(components);
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tblService).BeginInit();
            ((System.ComponentModel.ISupportInitialize)serviceBindingSource).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 100);
            label1.Name = "label1";
            label1.Size = new Size(137, 32);
            label1.TabIndex = 0;
            label1.Text = "Tên dịch vụ";
            // 
            // txtTenDV
            // 
            txtTenDV.Location = new Point(240, 100);
            txtTenDV.Name = "txtTenDV";
            txtTenDV.Size = new Size(353, 39);
            txtTenDV.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(98, 202);
            label2.Name = "label2";
            label2.Size = new Size(77, 32);
            label2.TabIndex = 2;
            label2.Text = "Mô tả";
            // 
            // txtGia
            // 
            txtGia.Location = new Point(240, 330);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(200, 39);
            txtGia.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(98, 330);
            label4.Name = "label4";
            label4.Size = new Size(48, 32);
            label4.TabIndex = 6;
            label4.Text = "Giá";
            // 
            // txtMota
            // 
            txtMota.Location = new Point(240, 179);
            txtMota.Name = "txtMota";
            txtMota.Size = new Size(579, 110);
            txtMota.TabIndex = 8;
            txtMota.Text = "";
            // 
            // txtId
            // 
            txtId.Location = new Point(240, 43);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(353, 39);
            txtId.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(86, 43);
            label3.Name = "label3";
            label3.Size = new Size(122, 32);
            label3.TabIndex = 9;
            label3.Text = "ID dịch vụ";
            // 
            // panel1
            // 
            panel1.Controls.Add(tblService);
            panel1.Controls.Add(toolStrip1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 407);
            panel1.Name = "panel1";
            panel1.Size = new Size(949, 371);
            panel1.TabIndex = 11;
            // 
            // tblService
            // 
            tblService.AutoGenerateColumns = false;
            tblService.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblService.Columns.AddRange(new DataGridViewColumn[] { serviceNameDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn });
            tblService.DataSource = serviceBindingSource;
            tblService.Dock = DockStyle.Fill;
            tblService.Location = new Point(0, 42);
            tblService.Name = "tblService";
            tblService.RowHeadersWidth = 82;
            tblService.RowTemplate.Height = 41;
            tblService.Size = new Size(949, 329);
            tblService.TabIndex = 0;
            tblService.CellClick += dataGridView1_CellClick;
            // 
            // serviceNameDataGridViewTextBoxColumn
            // 
            serviceNameDataGridViewTextBoxColumn.DataPropertyName = "ServiceName";
            serviceNameDataGridViewTextBoxColumn.HeaderText = "ServiceName";
            serviceNameDataGridViewTextBoxColumn.MinimumWidth = 10;
            serviceNameDataGridViewTextBoxColumn.Name = "serviceNameDataGridViewTextBoxColumn";
            serviceNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.MinimumWidth = 10;
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.MinimumWidth = 10;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.Width = 200;
            // 
            // serviceBindingSource
            // 
            serviceBindingSource.DataSource = typeof(Model.Service);
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(949, 42);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.ItemClicked += toolStrip1_ItemClicked;
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
            // FormQuanLyDichVu
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 778);
            Controls.Add(panel1);
            Controls.Add(txtId);
            Controls.Add(label3);
            Controls.Add(txtMota);
            Controls.Add(txtGia);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(txtTenDV);
            Controls.Add(label1);
            Name = "FormQuanLyDichVu";
            Text = "QuanLyDichVu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tblService).EndInit();
            ((System.ComponentModel.ISupportInitialize)serviceBindingSource).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTenDV;
        private Label label2;
        private TextBox txtGia;
        private Label label4;
        private RichTextBox txtMota;
        private TextBox txtId;
        private Label label3;
        private Panel panel1;
        private DataGridView tblService;
        private BindingSource serviceBindingSource;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private DataGridViewTextBoxColumn serviceNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
    }
}