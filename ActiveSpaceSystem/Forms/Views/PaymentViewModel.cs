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
        public DateTime PaidAt { get; set; }
        public Booking Booking { get; set; } = new Booking();

        public static PaymentViewModel FromBooking(Payment p)
        {
            var b = p.Booking;

            // 1. البحث عن العميل في المصدر الرئيسي لضمان الحصول على الاسم المحدث دائماً
            // نستخدم b.CustomerID للوصول للعميل الصحيح من قائمة العملاء العامة
            var masterCustomer = DataStorage.CustomersList.FirstOrDefault(c => c.CustomerID == b.CustomerID);

            // 2. حساب إجمالي المدفوعات من قائمة المدفوعات الفعلية في الذاكرة
            double paid = DataStorage.PaymentList
                .Where(pay => pay.BookingID == b.BookingID)
                .Sum(pay => pay.AmountPaid);

            return new PaymentViewModel
            {
                BookingID = b.BookingID,

                
                CustomerName = masterCustomer?.FullName ?? b.Customer?.FullName ?? "غير معروف",

                BookingDate = b.BookingDate.ToString("yyyy-MM-dd"),
                TotalAmount = b.TotalAmount,
                PaidAmount = paid,
                Remaining = b.TotalAmount - paid,
                Status = b.Status,
                PaidAt = p.PaidAt,
                Booking = b
            };
        }
    }
}