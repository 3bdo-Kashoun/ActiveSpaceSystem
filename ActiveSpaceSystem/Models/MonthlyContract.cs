using ActiveSpaceSystem.Models.enums;
using ActiveSpaceSystem.Data; // الوصول للمخزن لجلب الأسماء
using System;
using System.Collections.Generic;
using System.Linq;

namespace ActiveSpace.Models
{
    public class MonthlyContract
    {
        // المعرفات الأساسية
        public int ContractID { get; set; }
        public int CustomerID { get; set; }
        public int CourtID { get; set; }

       

       

        public string DayOfWeek { get; set; }
        public TimeSpan FixedStartTime { get; set; }
        public TimeSpan FixedEndTime { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public double PricePerHour { get; set; }
        public double TotalAmount { get; set; }
        public double Deposit { get; set; } // مبلغ العربون المدفوع عند توقيع العقد

        public MonthlyContractStatus Status { get; set; }

        public List<Booking> Bookings { get; set; } = new List<Booking>();

        public void GenerateBookings()
        {
            Bookings.Clear();
            DateTime current = StartDate;

            // جلب كائن الملعب من المخزن بناءً على ID لضمان عدم ظهوره كـ "غير معروف"
            var court = DataStorage.CourtsList.FirstOrDefault(c => c.CourtID == this.CourtID);
            double durationInHours = (FixedEndTime - FixedStartTime).TotalHours;

            while (current <= EndDate)
            {
                if (current.DayOfWeek.ToString() == DayOfWeek)
                {
                    double bookingAmount = durationInHours * PricePerHour;

                    Bookings.Add(new Booking
                    {
                        BookingID = DataStorage.BookingsList.Count + Bookings.Count + 1,
                        CustomerID = CustomerID,
                        CourtID = CourtID,
                        Court = court, // ربط كائن الملعب كاملاً هنا
                        BookingDate = current,
                        StartTime = FixedStartTime,
                        EndTime = FixedEndTime,
                        TotalAmount = bookingAmount,
                        Deposit = 0,
                        Status = BookingStatus.Confirmed
                    });
                }
                current = current.AddDays(1);
            }

            this.TotalAmount = Bookings.Sum(b => b.TotalAmount);
        }

        public static List<MonthlyContract> GetFakeData()
        {
            // التأكد من وجود عملاء وملاعب في النظام قبل توليد البيانات الوهمية
            // إذا كانت القوائم فارغة، يفضل عدم إضافة بيانات لتجنب الـ NullReferenceException
            if (DataStorage.CustomersList.Count == 0 || DataStorage.CourtsList.Count == 0)
                return new List<MonthlyContract>();

            var list = new List<MonthlyContract>
    {
        // العقد الأول: حجز يوم السبت لمدة شهر
        new MonthlyContract {
            ContractID = 1,
            // ربط العقد بأول عميل متاح في القائمة
            CustomerID = DataStorage.CustomersList[0].CustomerID, 
            // ربط العقد بأول ملعب متاح
            CourtID = DataStorage.CourtsList[0].CourtID,
            StartDate = DateTime.Today,
            EndDate = DateTime.Today.AddMonths(1),
            FixedStartTime = new TimeSpan(20, 0, 0), // من الساعة 8 مساءً
            FixedEndTime = new TimeSpan(21, 30, 0),  // إلى 9:30 مساءً (ساعة ونصف)
            DayOfWeek = "Saturday",
            PricePerHour = 50, // سعر الساعة
            Status = MonthlyContractStatus.Active
        },

        // العقد الثاني: حجز يوم الثلاثاء بدأ من أسبوع مضى
        new MonthlyContract {
            ContractID = 2,
            // ربط العقد بالعميل الثاني إذا وجد، وإلا نستخدم الأول
            CustomerID = DataStorage.CustomersList.Count > 1 ? DataStorage.CustomersList[1].CustomerID : DataStorage.CustomersList[0].CustomerID,
            CourtID = DataStorage.CourtsList.Count > 1 ? DataStorage.CourtsList[1].CourtID : DataStorage.CourtsList[0].CourtID,
            StartDate = DateTime.Today.AddDays(-7),
            EndDate = DateTime.Today.AddMonths(2),
            FixedStartTime = new TimeSpan(18, 0, 0), // من الساعة 6 مساءً
            FixedEndTime = new TimeSpan(19, 0, 0),  // إلى الساعة 7 مساءً (ساعة واحدة)
            DayOfWeek = "Tuesday",
            PricePerHour = 40,
            Status = MonthlyContractStatus.Active
        }
    };

            // توليد الحصص (Bookings) لكل عقد وربطها بالبيانات الأساسية
            foreach (var contract in list)
            {
                contract.GenerateBookings();

                // ربط كائن العميل بكل حجز تم توليده لضمان ظهور الأسماء في الجداول
                var customer = DataStorage.CustomersList.FirstOrDefault(c => c.CustomerID == contract.CustomerID);
                foreach (var booking in contract.Bookings)
                {
                    booking.Customer = customer;
                }
            }

            return list;
        }
    }
}