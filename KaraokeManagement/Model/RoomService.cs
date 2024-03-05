using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraokeManagement.Model
{
    [Table("RoomService")]
    public class RoomService
    {
        [Key]
        public int RoomServiceID { get; set; }
        [ForeignKey(nameof(BookingDetailID))]
        public int BookingDetailID { get; set; }

        public int ServiceID { get; set; }
        [ForeignKey(nameof(ServiceID))]
        public int Quantity { get; set; }
        public virtual Service Service { get; set; }
        public virtual BookingDetail BookingDetail { get; set; }
    }

}

