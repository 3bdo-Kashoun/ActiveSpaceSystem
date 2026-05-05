using ActiveSpaceSystem.Data;

namespace ActiveSpace.Models
{
    
    public class Payment
    {
        public int PaymentID { get; set; }
        public int BookingID { get; set; }
        public double AmountPaid { get; set; }
        public double Deposit { get; set; }
        public DateTime PaidAt { get; set; }
        public Booking Booking {  get; set; }
        

        public static List<Payment> GetFakeData() => new List<Payment>
        {
            new Payment { PaymentID = 1, BookingID = 1, AmountPaid = 30, Deposit = 10, PaidAt = DateTime.Now,Booking=DataStorage.BookingsList.FirstOrDefault(c=>c.BookingID==1)},
            new Payment { PaymentID = 2, BookingID = 2, AmountPaid = 120, Deposit = 10, PaidAt = DateTime.Now,Booking=DataStorage.BookingsList.FirstOrDefault(c=>c.BookingID==2)},
        };

        public static double CalculateRemaining(int bookingID)
        {
            // جلب كل المدفوعات لهذا الحجز
            var allPayments = DataStorage.PaymentList.Where(p => p.BookingID == bookingID).ToList();

            // حساب مجموع المبالغ المدفوعة (AmountPaid)
            double totalPaid = allPayments.Sum(p => p.AmountPaid);

            // جلب بيانات الحجز لمعرفة المبلغ الكلي
            var booking = DataStorage.BookingsList.FirstOrDefault(b => b.BookingID == bookingID);

            if (booking == null) return 0;

            // المتبقي = الكلي - المدفوع
            return booking.TotalAmount - totalPaid;
        }
    }
}