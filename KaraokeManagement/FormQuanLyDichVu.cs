using KaraokeManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaraokeManagement
{
    public partial class FormQuanLyDichVu : Form
    {
        public FormQuanLyDichVu()
        {
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {
            var db = new KaraDB();
            var serviceList = db.Services.OrderBy(sv => sv.ServiceName).ToList();
            serviceBindingSource.DataSource = serviceList;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            var selectedSvRoom = serviceBindingSource.Current;
            DataGridViewRow row = new DataGridViewRow();
            if (e.RowIndex == -1)
                return;
            row = tblService.Rows[e.RowIndex];
            Service sp = (Service)row.DataBoundItem;
            txtId.Text = sp.ServiceID.ToString();
            txtTenDV.Text = sp.ServiceName;
            txtMota.Text = sp.Description;
            txtGia.Text = sp.Price.ToString();


        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                var db = new KaraDB();
                db.Database.EnsureCreated();
                Service newService = new Service()
                {
                    //ServiceID = Convert.ToInt32(txtId.Text),
                    ServiceName = txtTenDV.Text,
                    Description = txtMota.Text,
                    Price = Convert.ToDecimal(txtGia.Text),

                };
                var check = db.Services.Where(r => r.ServiceName == newService.ServiceName).FirstOrDefault();
                if (check != null)
                {
                    MessageBox.Show("Tên dịch vụ đã tồn tại!", "Thông báo");
                    return;
                }
                db.Services.Add(newService);
                db.SaveChanges();
                LoadData();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                Service editedService = new Service()
                {
                    ServiceID = Convert.ToInt32(txtId.Text),
                    ServiceName = txtTenDV.Text,
                    Description = txtMota.Text,
                    Price = Convert.ToDecimal(txtGia.Text),
                };
                var db = new KaraDB();
                db.Database.EnsureCreated();
                var obj = db.Services.Find(editedService.ServiceID);
                if (obj != null)
                {
                    obj.ServiceName = editedService.ServiceName;
                    obj.Description = editedService.Description;
                    obj.Price = editedService.Price;
                    db.SaveChanges();
                    LoadData();
                }
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            var db = new KaraDB();
            var obj = db.Services.Find(Convert.ToInt32(txtId.Text));
            if (obj != null)
            {
                var rs = MessageBox.Show("Bạn có thực sự muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rs == DialogResult.OK)
                {
                    db.Services.Remove(obj);
                    db.SaveChanges();
                    LoadData();
                }
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

        }
    }
}
