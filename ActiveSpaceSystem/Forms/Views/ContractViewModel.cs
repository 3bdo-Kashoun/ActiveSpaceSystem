using ActiveSpace.Models;
using ActiveSpaceSystem.Models.enums;
using ActiveSpaceSystem.Data;
using System.Linq;
using System;

namespace ActiveSpaceSystem.Forms.Views
{
    public class ContractViewModel
    {
        public int ContractID { get; set; }
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public string CourtName { get; set; }
        public string DayOfWeek { get; set; }
        public string TimeSlot { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public double Amount { get; set; }
        public string Status { get; set; } // سنتركه String كما في كودك الأصلي للتعامل مع العرض

        public static ContractViewModel FromContract(MonthlyContract mc)
        {
            var customer = DataStorage.CustomersList.FirstOrDefault(cu => cu.CustomerID == mc.CustomerID);
            var court = DataStorage.CourtsList.FirstOrDefault(c => c.CourtID == mc.CourtID);

            return new ContractViewModel
            {
                ContractID = mc.ContractID,
                CustomerName = mc.Customer.FullName,
                PhoneNumber = mc.Customer.Phone ?? "غير معروف",
                CourtName = court.CourtName ?? "غير معروف",
                DayOfWeek = GetArabicDay(mc.DayOfWeek),
                TimeSlot = $"{mc.FixedStartTime:hh\\:mm} - {mc.FixedEndTime:hh\\:mm}",
                StartDate = mc.StartDate.ToString("yyyy-MM-dd"),
                EndDate = mc.EndDate.ToString("yyyy-MM-dd"),
                Amount = mc.Bookings?.Sum(b => b.TotalAmount) ?? 0,
                Status = mc.Status.ToString()
            };
        }

        private static string GetArabicDay(string englishDay)
        {
            var days = new System.Collections.Generic.Dictionary<string, string> {
                {"Saturday", "السبت"}, {"Sunday", "الأحد"}, {"Monday", "الاثنين"},
                {"Tuesday", "الثلاثاء"}, {"Wednesday", "الأربعاء"}, {"Thursday", "الخميس"}, {"Friday", "الجمعة"}
            };
            return days.ContainsKey(englishDay) ? days[englishDay] : englishDay;
        }
    }
}