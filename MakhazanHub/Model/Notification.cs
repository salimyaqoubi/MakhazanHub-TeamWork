using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorDatabase_3_1.Model
{
    public enum NotificationType
    {
        Information,
        Warning,
        Error
    }
    public class Notification
    {
        public int NotificationID { get; set; }
        public int UserID { get; set; }
        public string Message { get; set; }
        public DateTime DateSent { get; set; }
        public bool IsRead { get; set; }
        public string NotificationType { get; set; } // Enum
    }
}
