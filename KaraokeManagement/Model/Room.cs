using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraokeManagement.Model
{
    [Table("Room")]
    public class Room
    {
        [Key]
        public int RoomID { get; set; }
        public string RoomNumber { get; set; }
        public string RoomType { get; set; }
        public int Rate { get; set; }
        public bool IsOccupied { get; set; }
        public virtual ICollection<BookingDetail> BookingDetails { get; set; }
    }
}
