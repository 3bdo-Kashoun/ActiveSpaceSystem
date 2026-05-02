namespace ActiveSpace.Models
{
    
    public class MonthlyContract
    {
        public int ContractID { get; set; }
        public int CustomerID { get; set; }
        public int CourtID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public TimeSpan FixedStartTime { get; set; }
        public TimeSpan FixedEndTime { get; set; }
        public string DayOfWeek { get; set; }
        public MonthlyContractStatus Status { get; set; }
        public List<Booking> Bookings { get; set; } = new List<Booking>();

        public static List<MonthlyContract> GetFakeData()
        {
            var list = new List<MonthlyContract>
        {
            new MonthlyContract {
                ContractID = 1, CustomerID = 1, CourtID = 1,
                StartDate = DateTime.Today, EndDate = DateTime.Today.AddMonths(1),
                FixedStartTime = new TimeSpan(20,0,0), FixedEndTime = new TimeSpan(21,0,0),
                DayOfWeek = "Saturday",
                Status = MonthlyContractStatus.Active // تأكد من استخدام الاسم الإنجليزي للمقارنة مع DayOfWeek الخاص بالنظام
            },
            new MonthlyContract {
                ContractID = 2, CustomerID = 2, CourtID = 2,
                StartDate = DateTime.Today.AddDays(-5), EndDate = DateTime.Today.AddMonths(2),
                FixedStartTime = new TimeSpan(18,0,0), FixedEndTime = new TimeSpan(19,30,0),
                DayOfWeek = "Tuesday",
                Status = MonthlyContractStatus.Expired
            }
        };

            // استدعاء التوليد لكل عقد بعد إسناد القيم
            foreach (var contract in list)
            {
                contract.GenerateBookings();
            }

            return list;
        }

        private decimal CalculateAmount() => 100;

        public void GenerateBookings()
        {
            Bookings.Clear(); // مسح أي بيانات سابقة
            DateTime current = StartDate;

            while (current <= EndDate)
            {
                // المقارنة يجب أن تكون مع DayOfWeek الخاص بالتاريخ الحالي
                if (current.DayOfWeek.ToString() == DayOfWeek)
                {
                    Bookings.Add(new Booking
                    {
                        BookingID = Bookings.Count + 1, // رقم حجز وهمي
                        CustomerID = CustomerID,
                        CourtID = CourtID,
                        BookingDate = current,
                        StartTime = FixedStartTime,
                        EndTime = FixedEndTime,
                        TotalAmount = CalculateAmount(),
                        Status = BookingStatus.Confirmed // افتراضاً
                    });
                }
                current = current.AddDays(1);
            }
        }
    }

}