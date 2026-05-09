using ActiveSpaceSystem.Data;

namespace ActiveSpace.Models
{
    
    public class Payment
    {
        public int PaymentID { get; set; }
        public int BookingID { get; set; }
        public double AmountPaid { get; set; }
        
        public DateTime PaidAt { get; set; }
        public Booking Booking {  get; set; }


        public static List<Payment> GetFakeData() => new List<Payment>
        {
            // مدفوعات اليوم
            new Payment { PaymentID = 1, BookingID = 1, AmountPaid = 30, PaidAt = DateTime.Today, Booking = DataStorage.BookingsList.FirstOrDefault(c=>c.BookingID==1) },
            new Payment { PaymentID = 2, BookingID = 2, AmountPaid = 120, PaidAt = DateTime.Today, Booking = DataStorage.BookingsList.FirstOrDefault(c=>c.BookingID==2) },
            new Payment { PaymentID = 3, BookingID = 3, AmountPaid = 20, PaidAt = DateTime.Today, Booking = DataStorage.BookingsList.FirstOrDefault(c=>c.BookingID==3) },

            // مدفوعات أمس (ستؤثر على إحصائية "منذ الأمس")
            new Payment { PaymentID = 4, BookingID = 4, AmountPaid = 50, PaidAt = DateTime.Today.AddDays(-1), Booking = DataStorage.BookingsList.FirstOrDefault(c=>c.BookingID==4) },
            new Payment { PaymentID = 5, BookingID = 5, AmountPaid = 40, PaidAt = DateTime.Today.AddDays(-1), Booking = DataStorage.BookingsList.FirstOrDefault(c=>c.BookingID==5) },

            // مدفوعات غداً
            new Payment { PaymentID = 6, BookingID = 6, AmountPaid = 20, PaidAt = DateTime.Today.AddDays(-1), Booking = DataStorage.BookingsList.FirstOrDefault(c=>c.BookingID==6) },
            new Payment { PaymentID = 7, BookingID = 7, AmountPaid = 50, PaidAt = DateTime.Today.AddDays(-1), Booking = DataStorage.BookingsList.FirstOrDefault(c=>c.BookingID==7) }
        };

        public static double CalculateRemaining(int bookingID)
        {
            // 1. جلب بيانات الحجز لمعرفة السعر الإجمالي المتفق عليه
            var booking = DataStorage.BookingsList.FirstOrDefault(b => b.BookingID == bookingID);
            if (booking == null) return 0;

            // 2. حساب مجموع كل المدفوعات الفعلية المسجلة لهذا الحجز
            double totalPaid = DataStorage.PaymentList
                                          .Where(p => p.BookingID == bookingID)
                                          .Sum(p => p.AmountPaid);

            // المتبقي = الإجمالي - كل ما تم دفعه فعلياً
            return booking.TotalAmount - totalPaid;
        }
    }
}