using KaraokeManagement.DTO;
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
    public partial class FormLichDatPhong : Form
    {

        public FormLichDatPhong()
        {
            InitializeComponent();
            LoadData();
        }
        public FormLichDatPhong(string roomNum)
        {

            InitializeComponent();
            txtRoomNum.Text = roomNum;
            LoadData();
        }
        void LoadData()
        {

            var db = new KaraDB();
            var dateTb = dtpCheckInDate.Value.Date;

            var roomId = db.Rooms.Where(r => r.RoomNumber.Equals(txtRoomNum.Text)).Select(r => r.RoomID).FirstOrDefault();
            var history = db.Bookings.Join(db.BookingDetails, booking => booking.BookingID, bookingDetail => bookingDetail.BookingID, (booking, bookingDetail) =>
            new BookingHistoryDTO
            {
                BookingID = booking.BookingID,
                CustomerID = booking.CustomerID,
                RoomID = bookingDetail.RoomID,
                CheckInDate = booking.CheckInDate,
                CheckOutDate = booking.CheckOutDate,
                TotalAmount = booking.TotalAmount,
                Status = booking.Status,
            });
            if (txtRoomNum.Text.Equals(""))
            {
                bookingHistoryDTOBindingSource.DataSource = history.ToList();
            }
            else
            {
                bookingHistoryDTOBindingSource.DataSource = history.Where(b => b.RoomID == roomId && dtpCheckInDate.Value.Date == b.CheckInDate.Date).ToList();

            }



        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            var db = new KaraDB();
            var curHistory = bookingHistoryDTOBindingSource.Current as BookingHistoryDTO;
            if (curHistory != null)
            {
                var bookingDetailId = db.BookingDetails.Where(b => b.BookingID == curHistory.BookingID && b.RoomID == curHistory.RoomID).FirstOrDefault().BookingDetailID;
                FormDichVuPhong rsv = new FormDichVuPhong(bookingDetailId);
                rsv.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var db = new KaraDB();
            var curHistory = bookingHistoryDTOBindingSource.Current as BookingHistoryDTO;
            if (curHistory != null)
            {
                var bookingDetailId = db.BookingDetails.Where(b => b.BookingID == curHistory.BookingID && b.RoomID == curHistory.RoomID).FirstOrDefault().BookingDetailID;
                List<PaymentDTO> bkdt = db.Services.Join(db.RoomServices, service => service.ServiceID, roomService => roomService.ServiceID, (service, roomSerivce) =>
               new PaymentDTO
               {
                   BookingDetailID = roomSerivce.BookingDetailID,
                   ServiceName = service.ServiceName,
                   Quantity = roomSerivce.Quantity,
                   Price = service.Price
               }).Where(rs => rs.BookingDetailID == bookingDetailId).ToList();

                var totalServicePrice = bkdt.Join(db.BookingDetails, rs => rs.BookingDetailID, bookingDetail => bookingDetail.BookingDetailID, (rs, bookingDetail) =>
                new
                {
                    TotalServicePrice = rs.Quantity * rs.Price

                })
                .Sum(rs => rs.TotalServicePrice);
                var bookingId = db.BookingDetails.Where(b => b.BookingDetailID == bookingDetailId).FirstOrDefault().BookingID;
                var roomPrice = db.BookingDetails.Join(db.Rooms, bookingDetail => bookingDetail.RoomID, room => room.RoomID, (bookingDetail, room) => new
                {
                    Price = (decimal)(room.RoomType.Equals("VIP") ? 40.0 / 60 : 20.0 / 60),
                }).Select(p => p.Price).FirstOrDefault();
                TimeSpan duration = curHistory.CheckOutDate - curHistory.CheckInDate;
                double totalMinutes = duration.TotalMinutes;
                roomPrice = Math.Round(roomPrice * (decimal)totalMinutes, 2);
                FormThanhToan frmTt = new FormThanhToan(totalServicePrice, roomPrice, bookingDetailId, bkdt);
                frmTt.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var curHistory = bookingHistoryDTOBindingSource.Current as BookingHistoryDTO;
            FormQuanLyKhachHang frmKH = new FormQuanLyKhachHang(curHistory.CustomerID);
            frmKH.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
