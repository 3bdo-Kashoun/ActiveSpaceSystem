using ActiveSpace.Models;
using ActiveSpaceSystem.Models.enums;
using ActiveSpaceSystem.Data; // أضفنا هذا لاستخدام DataStorage
using System.Linq;

namespace ActiveSpaceSystem.Forms.Views
{
    public class BookingViewModel
    {
        public int BookingID { get; set; }
        public string CustomerName { get; set; }
        public string Phone { get; set; }
        public string Court { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public double Amount { get; set; }
        public BookingStatus Status { get; set; }

        public static BookingViewModel FromBooking(Booking b)
        {
            // --- الإضافة هنا ---
            // البحث عن العميل في القائمة الرئيسية للعملاء بناءً على المعرف
            // لضمان سحب أحدث اسم ورقم هاتف حتى لو تم تعديلهما
            var masterCustomer = DataStorage.CustomersList.FirstOrDefault(c => c.CustomerID == b.CustomerID);

            return new BookingViewModel
            {
                BookingID = b.BookingID,
                // نستخدم البيانات من masterCustomer إذا وجدناه، وإلا نعود للبيانات المخزنة في الحجز
                CustomerName = masterCustomer?.FullName ?? b.Customer?.FullName ?? "غير معروف",
                Phone = masterCustomer?.Phone ?? b.Customer?.Phone ?? "غير معروف",

                Court = b.Court?.CourtName ?? "غير معروف",
                Date = b.BookingDate.ToString("yyyy-MM-dd"),
                Time = $"{b.StartTime:hh\\:mm} - {b.EndTime:hh\\:mm}",
                Amount = b.TotalAmount,
                Status = b.Status
            };
        }
    }
}