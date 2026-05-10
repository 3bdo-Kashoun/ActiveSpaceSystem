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

namespace ActiveSpaceSystem.Forms.SideForms
{
    public partial class DashBoardForm : Form
    {
        public DashBoardForm()
        {
            InitializeComponent();
            LoadCourts();
        }

        private void label19_Click(object sender, EventArgs e)
        {

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
                    card.ReservationTime = $"محجوز من {currentBooking.StartTime:HH:mm} إلى {currentBooking.EndTime:HH:mm}";
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

        private void DashBoardForm_MinimumSizeChanged(object sender, EventArgs e)
        {
            foreach (var card in flowLayoutPanel1.Controls.OfType<AdvancedStatusCard>())
            {
                card.Width = 100; // تحديث عرض الكروت عند تغيير حجم الشاشة
            }
        }

        private void DashBoardForm_DockChanged(object sender, EventArgs e)
        {
            foreach (var card in flowLayoutPanel1.Controls.OfType<AdvancedStatusCard>())
            {
                card.Width = 350; // تحديث عرض الكروت عند تغيير حجم الشاشة
            }
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft; // تغيير اتجاه التدفق إلى عمودي
            foreach (var card in CourtPanel.Controls.OfType<CourtCard>())
            {
                card.Width = CourtPanel.ClientSize.Width - 25; // تحديث عرض الكروت عند تغيير حجم الشاشة
            }
        }

        private void CourtPanel_DockChanged(object sender, EventArgs e)
        {

        }

        private void CourtPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void CourtPanel_Resize(object sender, EventArgs e)
        {
            // SuspendLayout تمنع الوميض (Flicker) أثناء تحديث الأحجام
            CourtPanel.SuspendLayout();

            foreach (var card in CourtPanel.Controls.OfType<CourtCard>())
            {
                // طرح 25 أو 30 بكسل لترك مساحة لشريط التمرير (Scrollbar)
                card.Width = CourtPanel.ClientSize.Width - 30;
            }

            CourtPanel.ResumeLayout();
        }
    }
}
