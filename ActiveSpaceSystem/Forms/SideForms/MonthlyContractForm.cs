using ActiveSpace.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
namespace ActiveSpaceSystem.Forms.SideForms
{
    public partial class MonthlyContractForm : Form
    {
        // إعدادات الألوان والحالات
        private string TextActive = "نشط";
        private string TextExpired = "منتهي";
        private string TextCanceled = "ملغي";

        private Color ColorActiveBack = Color.FromArgb(232, 245, 233); // أخضر فاتح
        private Color ColorActiveText = Color.FromArgb(46, 125, 50);

        private Color ColorExpiredBack = Color.FromArgb(255, 235, 238); // أحمر فاتح
        private Color ColorExpiredText = Color.FromArgb(198, 40, 40);

        private Color ColorCanceledBack = Color.FromArgb(245, 245, 245); // رمادي فاتح
        private Color ColorCanceledText = Color.FromArgb(117, 117, 117);

        public MonthlyContractForm()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.dgvMonthlyContract.CellPainting += dgvMonthlyContract_CellPainting; // ربط حدث الرسم المخصص
        }

        private void MonthlyContractForm_Load_1(object sender, EventArgs e)
        {
            // إعدادات الجدول العامة
            dgvMonthlyContract.RowTemplate.Height = 55;
            dgvMonthlyContract.DefaultCellStyle.SelectionBackColor = Color.FromArgb(248, 249, 250);
            dgvMonthlyContract.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvMonthlyContract.DefaultCellStyle.Font = new Font("Tajawal", 9);
            dgvMonthlyContract.ColumnHeadersDefaultCellStyle.Font = new Font("Tajawal", 10, FontStyle.Bold);

            var data = MonthlyContract.GetFakeData().Select(mc =>
            {
                var court = Court.GetFakeData().FirstOrDefault(c => c.CourtID == mc.CourtID);
                var customer = Customer.GetFakeData().FirstOrDefault(cu => cu.CustomerID == mc.CustomerID);
                return new
                {
                    CustomerName = customer != null ? customer.FullName : "غير معروف",
                    PhoneNumber = customer != null ? customer.Phone : "غير معروف",
                    CourtName = court != null ? court.CourtName : "غير معروف",
                    DayOfWeek = GetArabicDay(mc.DayOfWeek), // دالة لتحويل اليوم للعربية للعرض فقط
                    TimeSlot = $"{mc.FixedStartTime:hh\\:mm} - {mc.FixedEndTime:hh\\:mm}",
                    StartDate = mc.StartDate.ToString("yyyy-MM-dd"),
                    EndDate = mc.EndDate.ToString("yyyy-MM-dd"),
                    Amount = mc.Bookings.Sum(b => b.TotalAmount),
                    Status = mc.Status.ToString() // نمرر الحالة كـ string للرسم
                };
            }).ToList();

            dgvMonthlyContract.DataSource = data;

            // تسمية الأعمدة
            dgvMonthlyContract.Columns["CustomerName"].HeaderText = "اسم العميل";
            dgvMonthlyContract.Columns["PhoneNumber"].HeaderText = "رقم الهاتف";
            dgvMonthlyContract.Columns["CourtName"].HeaderText = "الملعب";
            dgvMonthlyContract.Columns["DayOfWeek"].HeaderText = "اليوم";
            dgvMonthlyContract.Columns["TimeSlot"].HeaderText = "الفترة";
            dgvMonthlyContract.Columns["StartDate"].HeaderText = "تاريخ البداية";
            dgvMonthlyContract.Columns["EndDate"].HeaderText = "تاريخ النهاية";
            dgvMonthlyContract.Columns["Amount"].HeaderText = "المبلغ الإجمالي";
            dgvMonthlyContract.Columns["Status"].HeaderText = "الحالة";
            
        }

        // حدث الرسم المخصص للحالات
        private void dgvMonthlyContract_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (dgvMonthlyContract.Columns[e.ColumnIndex].Name == "Status")
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.ContentForeground);

                string rawStatus = e.Value?.ToString();
                string displayStatus = TextActive;
                Color backColor = ColorActiveBack;
                Color textColor = ColorActiveText;

                // تحديد الألوان بناءً على الحالة
                switch (rawStatus)
                {
                    case "Active":
                        displayStatus = TextActive;
                        backColor = ColorActiveBack;
                        textColor = ColorActiveText;
                        break;
                    case "Expired":
                        displayStatus = TextExpired;
                        backColor = ColorExpiredBack;
                        textColor = ColorExpiredText;
                        break;
                    case "Canceled":
                        displayStatus = TextCanceled;
                        backColor = ColorCanceledBack;
                        textColor = ColorCanceledText;
                        break;
                }

                // رسم الشكل البيضاوي (Capsule)
                using (GraphicsPath path = new GraphicsPath())
                {
                    // تصغير المستطيل قليلاً ليكون متناسقاً داخل الخلية
                    Rectangle rect = new Rectangle(e.CellBounds.X + 10, e.CellBounds.Y + 15, e.CellBounds.Width - 20, e.CellBounds.Height - 30);
                    int d = rect.Height;
                    path.AddArc(rect.X, rect.Y, d, d, 90, 180);
                    path.AddArc(rect.Right - d, rect.Y, d, d, 270, 180);
                    path.CloseFigure();

                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    using (SolidBrush sb = new SolidBrush(backColor))
                        e.Graphics.FillPath(sb, path);
                }

                // رسم النص فوق الشكل البيضاوي
                TextRenderer.DrawText(e.Graphics, displayStatus, e.CellStyle.Font, e.CellBounds, textColor, TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);
                e.Handled = true;
            }
        }

        private string GetArabicDay(string englishDay)
        {
            var days = new Dictionary<string, string>
            {
                {"Saturday", "السبت"}, {"Sunday", "الأحد"}, {"Monday", "الاثنين"},
                {"Tuesday", "الثلاثاء"}, {"Wednesday", "الأربعاء"}, {"Thursday", "الخميس"}, {"Friday", "الجمعة"}
            };
            return days.ContainsKey(englishDay) ? days[englishDay] : englishDay;
        }
    }
}