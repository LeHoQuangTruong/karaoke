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

    public partial class FormManHinhChinh : Form
    {
        private Employee employee;

        public FormManHinhChinh(Employee employeeParam)
        {
            employee = employeeParam;
            InitializeComponent();

        }

        private void quảnLýDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQuanLyDichVu frmQl = new FormQuanLyDichVu();
            frmQl.Show();
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQuanLyKhachHang frmKH = new FormQuanLyKhachHang();
            frmKH.Show();
        }

        private void quảnLýĐặtPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLichDatPhong frmLich = new FormLichDatPhong();
            frmLich.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTimPhong_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtTimPhong_TextChanged(object sender, EventArgs e)
        {
            cbbPhong.DataSource = null;

            var db = new KaraDB();
            if (cbbLoaiPhong.SelectedItem != null)
            {
                var roomList = db.Rooms.Where(r => r.RoomType.Equals(cbbLoaiPhong.SelectedItem)
                && r.RoomNumber.StartsWith(txtTimPhong.Text))
             .Select(r => r.RoomNumber).ToList();
                cbbPhong.DataSource = roomList;
            }

        }



        private void cbbLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTimPhong.Text = "";
            cbbPhong.DataSource = null;
        }

        private void cbbLoaiKhach_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var db = new KaraDB();

                var phoneNum = cbbKhachHang?.SelectedItem.ToString().Split("|")[1].Trim();
                var custommerId = db.Customers.Where(r => r.PhoneNumber.Equals(phoneNum)).Select(r => r.CustomerID).FirstOrDefault();
                var roomId = db.Rooms.Where(r => r.RoomNumber.Equals(cbbPhong.SelectedItem)).Select(r => r.RoomID).FirstOrDefault();

                var checkInTime = dtpGioVao.Value.TimeOfDay;

                var checkOutTime = dtpGioRa.Value.TimeOfDay;
                DateTime checkInDate = new DateTime(dtpCheckInDate.Value.Year, dtpCheckInDate.Value.Month, dtpCheckInDate.Value.Day);
                checkInDate = checkInDate.Add(checkInTime);
                DateTime checkOutDate = new DateTime(dtpCheckOutDate.Value.Year, dtpCheckOutDate.Value.Month, dtpCheckOutDate.Value.Day);
                checkOutDate = checkOutDate.Add(checkOutTime);

                if (checkInDate > checkOutDate)
                {
                    MessageBox.Show("Ngày(giờ) CheckIn phải nhỏ hơn ngày(giờ) Check out!");
                    return;
                }
                //Kiểm tra lịch bị trùng hay chưa
                var isBooked = db.BookingDetails.Join(db.Bookings, bookingDetail => bookingDetail.BookingID,
                        booking => booking.BookingID,
                        (bookingDetail, booking) => new
                        {
                            // Select the columns you need from both tables
                            BookingID = bookingDetail.BookingID,
                            RoomID = bookingDetail.RoomID,
                            checkInDateJoin = booking.CheckInDate,
                            checkOutDateJoin = booking.CheckOutDate,

                            // Other columns from BookingDetails and Bookings tables
                        }).Any(b => b.RoomID == roomId &&
                          ((checkInDate >= b.checkInDateJoin && checkInDate < b.checkOutDateJoin) ||
                           (checkOutDate > b.checkInDateJoin && checkOutDate <= b.checkOutDateJoin) ||
                           (b.checkInDateJoin >= checkInDate && b.checkOutDateJoin <= checkOutDate)));
                if (isBooked)
                {
                    MessageBox.Show("Phòng này đã được đặt. Vui lòng kiểm tra lại giờ Check in và Check Out"); ;
                    return;
                }
                Booking newBooking = new Booking
                {
                    CustomerID = Convert.ToInt32(custommerId),
                    CheckInDate = checkInDate,
                    CheckOutDate = checkOutDate,
                    TotalAmount = 0,
                    Status = "Chưa thanh toán"
                };

                db.Bookings.Add(newBooking);
                db.SaveChanges();
                var db1 = new KaraDB();
                var bookingId = db1.Bookings.Where(r => r.CustomerID == newBooking.CustomerID
                && r.CheckInDate == newBooking.CheckInDate && r.CheckOutDate == newBooking.CheckOutDate).OrderByDescending(r => r.BookingID).FirstOrDefault().BookingID;

                int parsedBookingId = Convert.ToInt32(bookingId);
                int parsedRoomId = Convert.ToInt32(roomId);
                int parsedNumberOfGuests = Convert.ToInt32(txtSl.Text);

                BookingDetail newBookingDetail = new BookingDetail
                {
                    BookingID = parsedBookingId,
                    RoomID = parsedRoomId,
                    EmployeeID = employee.EmployeeID,
                    NumberOfGuests = parsedNumberOfGuests,
                    Price = 0
                };
                db.BookingDetails.Add(newBookingDetail);

                db.SaveChanges();
                MessageBox.Show("Đặt phòng thành công!", "Thông báo");
            }
            catch (Exception err)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin!\n" + err.Message);
            }
        }





        private void txtTimKH_TextChanged(object sender, EventArgs e)
        {
            cbbKhachHang.DataSource = null;
            var db = new KaraDB();
            var customerName = txtTimKH.Text.ToString().Replace(" ", "").ToLower();
            if (!customerName.Equals(""))
            {
                var customerList = db.Customers.Where(c => (c.FirstName + c.LastName).ToLower().Contains(customerName)).Select(c => c.FirstName + " " + c.LastName + "   |   " + c.PhoneNumber).ToList();
                cbbKhachHang.DataSource = customerList;
            }
        }

        private void btnCheckHistory_Click(object sender, EventArgs e)
        {
            if (cbbPhong?.SelectedValue.ToString() != null)
            {
                FormLichDatPhong FrmLs = new FormLichDatPhong(cbbPhong.SelectedValue.ToString());
                FrmLs.Show();
            }
        }

        private void quảnLýLịchSửToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLichDatPhong FrmLs = new FormLichDatPhong();
            FrmLs.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FormThongKe frmTk = new FormThongKe();
            frmTk.Show();
        }
    }
}
