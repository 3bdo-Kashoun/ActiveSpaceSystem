using ActiveSpaceSystem.Models.enums;

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
        public double TotalAmount { get; set; }
        public BookingStatus Status { get; set; }


        public Customer Customer { get; set; }
        public Court? Court { get; set; }
        public User? User { get; set; }
        public double Deposit { get; set; }
        public double DurationHours => (EndTime - StartTime).TotalHours;

        public static List<Booking> GetFakeData() => new List<Booking>
        {
            // حجوزات اليوم (الموجودة مسبقاً)
            new Booking { BookingID = 1, CustomerID = 1, CourtID = 1, UserID = 1, BookingDate = DateTime.Today, StartTime = new TimeSpan(18, 0, 0), EndTime = new TimeSpan(19, 0, 0), TotalAmount = 50, Deposit = 30, Status = BookingStatus.Confirmed, Customer = Customer.GetFakeData().FirstOrDefault(c=>c.CustomerID==1), Court = Court.GetFakeData().FirstOrDefault(c=>c.CourtID==1) },
            new Booking { BookingID = 2, CustomerID = 2, CourtID = 2, UserID = 1, BookingDate = DateTime.Today, StartTime = new TimeSpan(21, 0, 0), EndTime = new TimeSpan(22, 30, 0), TotalAmount = 120, Deposit = 120, Status = BookingStatus.Completed, Customer = Customer.GetFakeData().FirstOrDefault(c=>c.CustomerID==2), Court = Court.GetFakeData().FirstOrDefault(c=>c.CourtID==2) },
            new Booking { BookingID = 3, CustomerID = 1, CourtID = 1, UserID = 1, BookingDate = DateTime.Today, StartTime = new TimeSpan(21, 0, 0), EndTime = new TimeSpan(22, 30, 0), TotalAmount = 50, Deposit = 20, Status = BookingStatus.Confirmed, Customer = Customer.GetFakeData().FirstOrDefault(c=>c.CustomerID==1), Court = Court.GetFakeData().FirstOrDefault(c=>c.CourtID==1) },

            // حجوزات أمس (DateTime.Today.AddDays(-1))
            new Booking { BookingID = 4, CustomerID = 1, CourtID = 1, UserID = 1, BookingDate = DateTime.Today.AddDays(-1), StartTime = new TimeSpan(17, 0, 0), EndTime = new TimeSpan(18, 0, 0), TotalAmount = 50, Deposit = 50, Status = BookingStatus.Completed, Customer = Customer.GetFakeData().FirstOrDefault(c=>c.CustomerID==1), Court = Court.GetFakeData().FirstOrDefault(c=>c.CourtID==1) },
            new Booking { BookingID = 5, CustomerID = 2, CourtID = 2, UserID = 1, BookingDate = DateTime.Today.AddDays(-1), StartTime = new TimeSpan(20, 0, 0), EndTime = new TimeSpan(21, 0, 0), TotalAmount = 100, Deposit = 40, Status = BookingStatus.Confirmed, Customer = Customer.GetFakeData().FirstOrDefault(c=>c.CustomerID==2), Court = Court.GetFakeData().FirstOrDefault(c=>c.CourtID==2) },

            // حجوزات غداً (DateTime.Today.AddDays(1))
            new Booking { BookingID = 6, CustomerID = 1, CourtID = 2, UserID = 1, BookingDate = DateTime.Today.AddDays(1), StartTime = new TimeSpan(19, 0, 0), EndTime = new TimeSpan(20, 0, 0), TotalAmount = 80, Deposit = 20, Status = BookingStatus.Confirmed, Customer = Customer.GetFakeData().FirstOrDefault(c=>c.CustomerID==1), Court = Court.GetFakeData().FirstOrDefault(c=>c.CourtID==2) },
            new Booking { BookingID = 7, CustomerID = 2, CourtID = 1, UserID = 1, BookingDate = DateTime.Today.AddDays(1), StartTime = new TimeSpan(22, 0, 0), EndTime = new TimeSpan(23, 0, 0), TotalAmount = 50, Deposit = 50, Status = BookingStatus.Completed, Customer = Customer.GetFakeData().FirstOrDefault(c=>c.CustomerID==2), Court = Court.GetFakeData().FirstOrDefault(c=>c.CourtID==1) }
        };


    }


}