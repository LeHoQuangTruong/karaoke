using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraokeManagement.DTO
{
    public class BookingHistoryDTO
    {
        public BookingHistoryDTO() { }
        public int BookingID { get; set; }
        public int CustomerID { get; set; }
        public int RoomID { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; }

        internal object Where(Func<object, object> value)
        {
            throw new NotImplementedException();
        }
    }
}
