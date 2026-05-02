namespace ActiveSpace.Models
{
    
    public class Payment
    {
        public int PaymentID { get; set; }
        public int BookingID { get; set; }
        public decimal AmountPaid { get; set; }
        public decimal Deposit { get; set; }
        public DateTime PaidAt { get; set; }
        public string Method { get; set; }

        public static List<Payment> GetFakeData() => new List<Payment>
        {
            new Payment { PaymentID = 1, BookingID = 1, AmountPaid = 30, Deposit = 10, PaidAt = DateTime.Now, Method = "نقداً" },
            new Payment { PaymentID = 2, BookingID = 2, AmountPaid = 120, Deposit = 10, PaidAt = DateTime.Now, Method = "نقداً" }
        };

        public static decimal CalculateRemaining(int bookingID)
        {
            // جلب كل المدفوعات لهذا الحجز
            var allPayments = GetFakeData().Where(p => p.BookingID == bookingID).ToList();

            // حساب مجموع المبالغ المدفوعة (AmountPaid)
            decimal totalPaid = allPayments.Sum(p => p.AmountPaid);

            // جلب بيانات الحجز لمعرفة المبلغ الكلي
            var booking = Booking.GetFakeData().FirstOrDefault(b => b.BookingID == bookingID);

            if (booking == null) return 0;

            // المتبقي = الكلي - المدفوع
            return booking.TotalAmount - totalPaid;
        }
    }
}