using ActiveSpace.Models;

namespace ActiveSpaceSystem.Forms.Views
{
    public class BookingViewModel
    {
        
        public string CustomerName { get; set; }
        public string Phone { get; set; }
        public string Court { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public decimal Amount { get; set; }
        public BookingStatus Status { get; set; }

        public static BookingViewModel FromBooking(Booking b)
        {
            return new BookingViewModel
            {
                
                CustomerName = b.Customer?.FullName ?? "غير معروف",
                Phone = b.Customer?.Phone ?? "غير معروف",
                Court = b.Court?.CourtName ?? "غير معروف",
                Date = b.BookingDate.ToString("yyyy-MM-dd"),
                Time = $"{b.StartTime:hh\\:mm} - {b.EndTime:hh\\:mm}",
                Amount = b.TotalAmount,
                Status = b.Status
            };
        }
    }
}