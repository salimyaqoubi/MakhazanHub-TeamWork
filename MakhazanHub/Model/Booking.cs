using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorDatabase_3_1.Model
{
    public enum Status
    {
        Pending,
        Confirmed,
        Cancelled
    }

    public class Booking
    {
        public int BookingID { get; set; }
        public int UserID { get; set; }
        public int StoreID { get; set; }
        public DateTime BookingDate { get; set; }
        public string Status { get; set; } // Enum
        public int PaymentID { get; set; }
    }
}
