using ActiveSpace.Models;
using ActiveSpaceSystem.CustomItems;
using ActiveSpaceSystem.Data;
using ActiveSpaceSystem.Models.enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ActiveSpaceSystem.Forms.SideForms
{
    public partial class DashBoardForm : Form
    {
        public DashBoardForm()
        {
            InitializeComponent();
            this.Load += (s, e) => {
                LoadCourts();
                UpdateCards();

            };
            customChart1.LoadWeeklyRevenueFromStorage();
            

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }
        public void LoadData()
        {
            LoadCourts();
            UpdateCards();
            customChart1.LoadWeeklyRevenueFromStorage();
        }
        private void UpdateCards()
        {
            TotalBookingCountCard.ValueText = DataStorage.BookingsList.Count.ToString();
            TotalCustomersCard.ValueText = DataStorage.CustomersList.Count.ToString();

            string rlm = "\u200F";

            // 1. حساب إجمالي الدخل اليوم
            double todayTotal = DataStorage.PaymentList
                .Where(p => p.PaidAt.Date == DateTime.Today.Date)
                .Sum(b => b.AmountPaid);
            TotalIncomeCard.ValueText = $"{rlm}{todayTotal:N2} د.ل";

            // --- حساب معدل الإشغال للملاعب اليوم ---

            // 2. جلب حجوزات اليوم فقط
            var todayBookings = DataStorage.BookingsList
                .Where(b => b.BookingDate.Date == DateTime.Today.Date)
                .ToList();

            // 3. حساب إجمالي الساعات المحجوزة فعلياً
            double totalBookedHours = todayBookings.Sum(b => (b.EndTime - b.StartTime).TotalHours);

            // 4. حساب إجمالي الساعات المتاحة (ساعات العمل لجميع الملاعب)
            double totalAvailableHours = DataStorage.CourtsList.Sum(c => {
                TimeSpan closing = (c.CloseTime == TimeSpan.Zero) ? new TimeSpan(23, 59, 59) : c.CloseTime;
                return (closing - c.OpenTime).TotalHours;
            });

            // 5. حساب النسبة المئوية
            double occupancyRate = 0;
            if (totalAvailableHours > 0)
            {
                occupancyRate = (totalBookedHours / totalAvailableHours) * 100;
            }

            // 6. عرض النسبة في الكارد الخاص بها (بافتراض اسم الكارد OccupancyRateCard)
            // نستخدم N1 لعرض رقم عشري واحد مثل 75.5%
            PercentgeCard.ValueText = $"{occupancyRate:N1}%";

           
        }
        public void LoadCourts()
        {
            CourtPanel.Controls.Clear(); // Panel التي ستحتوي الكروت

            foreach (var court in DataStorage.CourtsList)
            {
                CourtCard card = new CourtCard();
                card.CourtName = court.CourtName;
                card.SportType = court.Type.TypeName;

                // منطق التحقق من الحجز الحالي
                var currentBooking = GetActiveBookingForCourt(court.CourtID);
                if (currentBooking != null)
                {
                    card.IsReserved = true;
                    card.ReservationTime = $"محجوز من {currentBooking.StartTime:hh\\:mm} إلى {currentBooking.EndTime:hh\\:mm}";
                }
                else
                {
                    card.IsReserved = false;
                }
                card.Width = CourtPanel.ClientSize.Width - 25;

                CourtPanel.Controls.Add(card);
            }
        }
        public static Booking GetActiveBookingForCourt(int courtId)
        {
            // الحصول على تاريخ اليوم ووقت اللحظة الحالية
            DateTime today = DateTime.Today;
            TimeSpan now = DateTime.Now.TimeOfDay;

            // البحث في قائمة الحجوزات
            return DataStorage.BookingsList.FirstOrDefault(b =>
                b.CourtID == courtId &&                 // نفس الملعب
                b.BookingDate.Date == today &&          // تاريخ اليوم
                b.StartTime <= now &&                   // بدأ بالفعل
                b.EndTime >= now &&                     // لم ينتهِ بعد
                b.Status != BookingStatus.NoShow     // ليس ملغياً
            );
        }



        // تعريف الفلاق خارج الدالة (على مستوى الكلاس)
        bool isFirstMode = true;

        private void DashBoardForm_DockChanged(object sender, EventArgs e)
        {
            if (isFirstMode)
            {
                // --- الإعدادات الجديدة (المرة الأولى) ---
                foreach (var card in flowLayoutPanel1.Controls.OfType<AdvancedStatusCard>())
                {
                    card.Width = 360;
                    card.Margin = new Padding(10, 0, 10, 0); // مسافة أكبر بين الكروت
                }
                flowLayoutPanel1.Padding = new Padding(30, 20, 30, 0); // تقليل الحشو حول الكروت

            }
            else
            {
                // --- الإعدادات القديمة (المرة الثانية) ---
                foreach (var card in flowLayoutPanel1.Controls.OfType<AdvancedStatusCard>())
                {
                    card.Width = 420; // افترضنا أن هذا هو العرض القديم
                    card.Margin = new Padding(10);
                }
                flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
                flowLayoutPanel1.Padding = new Padding(30, 20, 30, 20);



            }
            isFirstMode = !isFirstMode;


        }




        private void CourtPanel_Resize(object sender, EventArgs e)
        {

            foreach (var card in CourtPanel.Controls.OfType<CourtCard>())
            {
                // طرح 25 أو 30 بكسل لترك مساحة لشريط التمرير (Scrollbar)
                card.Width = CourtPanel.ClientSize.Width - 30;
            }

            CourtPanel.ResumeLayout();

        }

        private void flowLayoutPanel1_SizeChanged(object sender, EventArgs e)
        {

        }

        private void panel5_SizeChanged(object sender, EventArgs e)
        {
            
        }



       
    }
}
