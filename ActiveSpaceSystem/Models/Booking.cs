namespace ActiveSpace.Models
{
    public class Booking
    {
        //3
        public int BookingID { get; set; }
        public int CustomerID { get; set; }
        public int CourtID { get; set; }
        public int UserID { get; set; } 
        public int? ContractID { get; set; }

        public DateTime BookingDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public decimal TotalAmount { get; set; }
        public BookingStatus Status { get; set; }


        public Customer? Customer { get; set; } // Made nullable to match usage in fake data
        public Court? Court { get; set; }
        public User? User { get; set; }

        public double DurationHours => (EndTime - StartTime).TotalHours;

        public static List<Booking> GetFakeData() => new List<Booking>
{
    new Booking {
        BookingID = 1,
        CustomerID = 1,
        CourtID = 1,
        UserID = 1,
        BookingDate = DateTime.Today,
        StartTime = new TimeSpan(18, 0, 0),
        EndTime = new TimeSpan(19, 0, 0),
        TotalAmount = 50,
        Status = BookingStatus.Confirmed,
        Customer = new Customer { FullName = "أحمد محمد", Phone = "09125415236" },
        Court = new Court { CourtName = "ملعب المدينة 1" }
    },
    new Booking {
        BookingID = 2,
        CustomerID = 2,
        CourtID = 2,
        UserID = 1,
        BookingDate = DateTime.Today,
        StartTime = new TimeSpan(21, 0, 0),
        EndTime = new TimeSpan(22, 30, 0), // حجز لمدة ساعة ونصف
        TotalAmount = 120,
        Status = BookingStatus.Completed,
        Customer = new Customer { FullName = "سالم الفيتوري", Phone = "09123456789" },
        Court = new Court { CourtName = "ملعب البادل الرئيسي" }
    },
    new Booking {
        BookingID = 3,
        CustomerID = 1,
        CourtID = 1,
        UserID = 1,
        BookingDate = DateTime.Today,
        StartTime = new TimeSpan(21, 0, 0),
        EndTime = new TimeSpan(22, 30, 0), // حجز لمدة ساعة ونصف
        TotalAmount = 50,
        Status = BookingStatus.Confirmed,
        Customer = new Customer { FullName = "أحمد محمد", Phone = "09125415236" },
        Court = new Court { CourtName = "ملعب البادل الرئيسي" }
    }
};

        
    }

    
}