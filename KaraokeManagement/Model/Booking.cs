using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraokeManagement.Model
{
    [Table("Booking")]
    public class Booking
    {
        [Key]
        public int BookingID { get; set; }
        [ForeignKey(nameof(CustomerID))]
        public int CustomerID { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; }
        public virtual Customer Customer { get; set; }


    }
}
