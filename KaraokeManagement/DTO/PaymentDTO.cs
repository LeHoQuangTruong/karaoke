using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraokeManagement.DTO
{
    public class PaymentDTO

    {
        public PaymentDTO() { }
        public int BookingDetailID { get; set; }
        public string ServiceName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
