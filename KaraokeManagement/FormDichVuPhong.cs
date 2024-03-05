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
    public partial class FormDichVuPhong : Form
    {
        public int BookingDetailID;
        public FormDichVuPhong(int bookingDetailId)
        {
            this.BookingDetailID = bookingDetailId;
            InitializeComponent();
            txtId.Text = bookingDetailId.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            cbbDichVu.DataSource = null;
            var db = new KaraDB();
            var serviceList = db.Services.Where(s => s.ServiceName.Contains(txtTimDichVu.Text)).Select(s => s.ServiceName).ToList();
            cbbDichVu.DataSource = serviceList;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var db = new KaraDB();
            var serviceID = db.Services.Where(s => s.ServiceName.Equals(cbbDichVu.SelectedItem.ToString())).FirstOrDefault().ServiceID;
            RoomService roomService = new RoomService()
            {
                BookingDetailID = this.BookingDetailID,
                ServiceID = serviceID,
                Quantity = Convert.ToInt32(txtSoluong.Text),

            };
            db.RoomServices.Add(roomService);
            db.SaveChanges();
            MessageBox.Show("Đã thêm dịch vụ cho phòng!");
        }


    }
}
