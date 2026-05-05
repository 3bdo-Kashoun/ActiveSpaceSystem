using ActiveSpace.Models;
using ActiveSpaceSystem.Data;
using ActiveSpaceSystem.Models.enums;
using System;
using System.Linq;

namespace ActiveSpaceSystem.Forms.Views
{
    public class PaymentViewModel
    {
        public int BookingID { get; set; }
        public string CustomerName { get; set; }
        public string BookingDate { get; set; }
        public double TotalAmount { get; set; }
        public double PaidAmount { get; set; }
        public double Remaining { get; set; }
        public BookingStatus Status { get; set; }

        public static PaymentViewModel FromBooking(Booking b)
        {
            // حساب إجمالي المدفوعات من قائمة المدفوعات الفعلية في الذاكرة
            double paid = DataStorage.PaymentList
                .Where(p => p.BookingID == b.BookingID)
                .Sum(p => p.AmountPaid);

            return new PaymentViewModel
            {
                BookingID = b.BookingID,
                CustomerName = b.Customer?.FullName ?? "غير معروف",
                BookingDate = b.BookingDate.ToString("yyyy-MM-dd"),
                TotalAmount = b.TotalAmount,
                PaidAmount = paid,
                Remaining = b.TotalAmount - paid,
                Status = b.Status
            };
        }
    }
}