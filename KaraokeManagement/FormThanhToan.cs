using KaraokeManagement.DTO;
using KaraokeManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaraokeManagement
{
    public partial class FormThanhToan : Form
    {
        public FormThanhToan(decimal totalServicePrice, decimal roomPrice, int bookingDetailId, List<PaymentDTO> paymentList)
        {
            InitializeComponent();
            txtId.Text = bookingDetailId.ToString();
            paymentDTOBindingSource.DataSource = paymentList;
            txtSerivcePrice.Text = totalServicePrice.ToString();
            txtRoomPrice.Text = roomPrice.ToString();
            txtTotalPrice.Text = (totalServicePrice + roomPrice).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var db = new KaraDB();
            var bookingId = db.BookingDetails.Where(b => b.BookingDetailID == Convert.ToInt32(txtId.Text)).FirstOrDefault().BookingID;
            var booking = db.Bookings.Find(bookingId);
            booking.Status = "Đã thanh toán!";
            booking.TotalAmount = Convert.ToDecimal(txtTotalPrice.Text);
            db.SaveChanges();
            MessageBox.Show("Thanh toán thành công!");
        }
        private void CaptureFormToImage(string filePath)
        {
            // Tạo một bitmap để chứa nội dung của form
            Bitmap bitmap = new Bitmap(this.Width, this.Height);

            // Tạo một đối tượng Graphics để vẽ nội dung lên bitmap
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                // Vẽ nội dung của form lên bitmap
                var sizeCrop = new Size(this.Width - 40, this.Height - 200);
                var pointCropt = new Point(this.Location.X + 20, this.Location.Y + 100);
                graphics.CopyFromScreen(pointCropt, new Point(0, 0), sizeCrop);
            }

            // Lưu bitmap thành tệp ảnh
            bitmap.Save(filePath, ImageFormat.Png);
        }

        // Xử lý sự kiện khi nhấn nút để xuất form sang hình ảnh
        private void btnExportToImage_Click(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // Kết hợp đường dẫn của desktop với tên tệp hình ảnh
            string fileName = "invoice_image.png";
            string filePath = Path.Combine(desktopPath, fileName);
            // Chụp và lưu ảnh
            CaptureFormToImage(filePath);
            MessageBox.Show("Đã xuất hóa đơn tại: " + filePath);
        }
    }
}
