using ActiveSpace.Models;
using System;
using System.Linq;

namespace ActiveSpaceSystem.Forms.Views
{
    public class CustomerViewModel
    {
        public string FullName { get; set; }
        public string Phone { get; set; }
        public decimal TotalDebt { get; set; }
        public int NoShowCount { get; set; }
        public string LastBookingDate { get; set; }
        public ReliabilityFlag ReliabilityFlag { get; set; }

        public static CustomerViewModel FromCustomer(Customer c)
        {
            // محاكاة لتاريخ آخر حجز بما أن المودل لا يحتوي عليه مباشرة حالياً
            // في الواقع العملي سيتم جلب هذا من قاعدة البيانات
            string lastBooking = "2023-10-15"; // قيمة افتراضية للتوضيح

            return new CustomerViewModel
            {
                FullName = c.FullName,
                Phone = c.Phone,
                TotalDebt = c.TotalDebt,
                NoShowCount = c.NoShowCount,
                LastBookingDate = lastBooking,
                ReliabilityFlag = c.ReliabilityFlag
            };
        }
    }
}
