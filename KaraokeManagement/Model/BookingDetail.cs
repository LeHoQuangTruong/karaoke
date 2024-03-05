using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraokeManagement.Model
{
    [Table("BookingDetail")]
    public class BookingDetail
    {
        [Key]
        public int BookingDetailID { get; set; }

        public int BookingID { get; set; }
        [ForeignKey(nameof(BookingID))]

        public int RoomID { get; set; }
        [ForeignKey(nameof(RoomID))]
        public int EmployeeID { get; set; }
        [ForeignKey(nameof(EmployeeID))]
        public int NumberOfGuests { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<RoomService> RoomServices { get; set; }
        public virtual Booking Booking { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Room Room { get; set; }


    }
}
