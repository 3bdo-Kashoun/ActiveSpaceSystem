using ActiveSpace.Models;
using ActiveSpaceSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiveSpaceSystem.Data
{
    internal class DataStorage
    {
        public static List<User> UsersList = new List<User>();
        public static List<Booking> BookingsList = new List<Booking>();
        public static List<Court> CourtsList = new List<Court>();
        public static List<Customer> CustomersList = new List<Customer>();
        public static List<CourtType> CourtTypesList = new List<CourtType>();
        public static List<MonthlyContract> ContractsList = new List<MonthlyContract>();
        public static List<Payment> PaymentList = new List<Payment>();

        public static Dictionary<string, DayOfWeek> DaysMap = new Dictionary<string, DayOfWeek>
        {
        { "الأحد", DayOfWeek.Sunday },
         { "الاثنين", DayOfWeek.Monday },
         { "الثلاثاء", DayOfWeek.Tuesday },
         { "الأربعاء", DayOfWeek.Wednesday },
      { "الخميس", DayOfWeek.Thursday },
    { "الجمعة", DayOfWeek.Friday },
    { "السبت", DayOfWeek.Saturday }
        };
        static DataStorage()    
        {
           
            UsersList = User.GetFakeData();
            CustomersList = Customer.GetFakeData();
            CourtsList = Court.GetFakeData();
            CourtTypesList=CourtType.GetFakeData();
            
            ContractsList = MonthlyContract.GetFakeData();
            BookingsList = Booking.GetFakeData();
            PaymentList = Payment.GetFakeData();

        }
        public static List<TimeSlot> GetCourtAvailability(int courtId, DateTime date)
        {
            var court = CourtsList.FirstOrDefault(c => c.CourtID == courtId);
            if (court == null) return new List<TimeSlot>();

            // 1. جلب الحجوزات وترتيبها حسب وقت البدء
            var bookings = BookingsList
                .Where(b => b.CourtID == courtId && b.BookingDate.Date == date.Date)
                .OrderBy(b => b.StartTime)
                .ToList();

            var schedule = new List<TimeSlot>();
            TimeSpan currentPos = court.OpenTime;
            TimeSpan closing = (court.CloseTime == TimeSpan.Zero) ? new TimeSpan(23, 59, 59) : court.CloseTime;

            // 2. خوارزمية ملء الفراغات (Gap Filling)
            foreach (var booking in bookings)
            {
                // إذا كان فيه وقت فاضي قبل هذا الحجز، نضيفوه كفترة متاحة
                if (booking.StartTime > currentPos)
                {
                    schedule.Add(new TimeSlot
                    {
                        Start = currentPos,
                        End = booking.StartTime,
                        IsBooked = false
                    });
                }

                // إضافة الحجز نفسه
                schedule.Add(new TimeSlot
                {
                    Start = booking.StartTime,
                    End = booking.EndTime,
                    IsBooked = true,
                    CustomerName = booking.Customer?.FullName ?? "Unknown"
                });

                currentPos = booking.EndTime;
            }

            // 3. إضافة الفترة المتبقية من آخر حجز لعند وقت الإغلاق
            if (currentPos < closing)
            {
                schedule.Add(new TimeSlot
                {
                    Start = currentPos,
                    End = closing,
                    IsBooked = false
                });
            }

            return schedule;
        }

    }
}