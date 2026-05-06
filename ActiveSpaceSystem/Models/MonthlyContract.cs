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

        // --- الخصائص المضافة للعرض في الجدول (Read-only Properties) ---
        // هذه الخصائص هي التي ستكتب اسمها في الـ DataPropertyName في الـ Designer

        public string CustomerName => DataStorage.CustomersList.FirstOrDefault(c => c.CustomerID == CustomerID)?.FullName ?? "غير معروف";
        public string CustomerPhone => DataStorage.CustomersList.FirstOrDefault(c => c.CustomerID == CustomerID)?.Phone ?? "---";
        public string CourtName => DataStorage.CourtsList.FirstOrDefault(c => c.CourtID == CourtID)?.CourtName ?? "غير معروف";

        public string FullTimeSlot => $"{FixedStartTime:hh\\:mm} - {FixedEndTime:hh\\:mm}";
        public double CalculatedTotalAmount => Bookings?.Sum(b => b.TotalAmount) ?? 0;
        // -----------------------------------------------------------

        public string DayOfWeek { get; set; }
        public TimeSpan FixedStartTime { get; set; }
        public TimeSpan FixedEndTime { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public double PricePerHour { get; set; }
        public double TotalAmount { get; set; }

        public MonthlyContractStatus Status { get; set; }

        public List<Booking> Bookings { get; set; } = new List<Booking>();

        public void GenerateBookings()
        {
            Bookings.Clear();
            DateTime current = StartDate;

            // حساب عدد الساعات للفترة المحجوزة
            double durationInHours = (FixedEndTime - FixedStartTime).TotalHours;

            while (current <= EndDate)
            {
                if (current.DayOfWeek.ToString() == DayOfWeek)
                {
                    // حساب مبلغ هذا الحجز المنفرد
                    double bookingAmount = durationInHours * PricePerHour;

                    Bookings.Add(new Booking
                    {
                        BookingID = Bookings.Count + 1,
                        CustomerID = CustomerID,
                        CourtID = CourtID,
                        BookingDate = current,
                        StartTime = FixedStartTime,
                        EndTime = FixedEndTime,
                        TotalAmount = bookingAmount, // القيمة المحسوبة للحجز الواحد
                        Status = BookingStatus.Confirmed
                    });
                }
                current = current.AddDays(1);
            }

            // تحديث إجمالي العقد ككل بناءً على مجموع الحجوزات المولدة
            this.TotalAmount = Bookings.Sum(b => b.TotalAmount);
        }

        public static List<MonthlyContract> GetFakeData()
        {
            var list = new List<MonthlyContract>
            {
                new MonthlyContract {
                    ContractID = 1, CustomerID = 1, CourtID = 1,
                    StartDate = DateTime.Today, EndDate = DateTime.Today.AddMonths(1),
                    FixedStartTime = new TimeSpan(20,0,0), FixedEndTime = new TimeSpan(21,0,0),
                    DayOfWeek = "Saturday",
                    Status = MonthlyContractStatus.Active
                },
                new MonthlyContract {
                    ContractID = 2, CustomerID = 2, CourtID = 2,
                    StartDate = DateTime.Today.AddDays(-5), EndDate = DateTime.Today.AddMonths(2),
                    FixedStartTime = new TimeSpan(18,0,0), FixedEndTime = new TimeSpan(19,30,0),
                    DayOfWeek = "Tuesday",
                    Status = MonthlyContractStatus.Expired
                }
            };

            foreach (var contract in list) { contract.GenerateBookings(); }
            return list;
        }
    }
}