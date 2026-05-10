using ActiveSpaceSystem.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActiveSpaceSystem.CustomItems
{
    public partial class CustomChart : UserControl
    {
        private Dictionary<string, double> _chartData = new Dictionary<string, double>();

        [Category("Custom Data")]
        [Description("The data to be displayed in the bar chart (Day Name, Value).")]
        public Dictionary<string, double> ChartData
        {
            get { return _chartData; }
            set
            {
                _chartData = value ?? new Dictionary<string, double>();
                this.Invalidate(); // إعادة رسم الكنترول عند تغيير البيانات
            }
        }

        [Category("Custom Appearance")]
        [Description("The color of the chart bars.")]
        public Color BarColor { get; set; } = Color.FromArgb(46, 204, 113);

        [Category("Custom Appearance")]
        [Description("The font for the labels on the X-axis.")]
        public Font LabelFont { get; set; } = new Font("Tajawal", 8f);

        [Category("Custom Appearance")]
        [Description("The font for the values on top of the bars.")]
        public Font ValueFont { get; set; } = new Font("Tajawal", 9f, FontStyle.Bold);

        public CustomChart()
        {
            this.DoubleBuffered = true; // لمنع الوميض أثناء الرسم
            this.Resize += (s, e) => this.Invalidate(); // إعادة الرسم عند تغيير الحجم
            this.BackColor = Color.White; // خلفية بيضاء افتراضية
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DrawBarChart(e.Graphics, this.ClientRectangle, _chartData);
        }

        private void DrawBarChart(Graphics g, Rectangle bounds, Dictionary<string, double> data)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;

            // مسح الخلفية
            g.Clear(this.BackColor);

            if (data == null || data.Count == 0) return;

            // تقليل الهوامش ليتمدد الرسم أكثر
            int paddingLeft = 40; // مساحة للأرقام على اليسار
            int paddingRight = 20;
            int paddingTop = 30;
            int paddingBottom = 30;

            Rectangle chartArea = new Rectangle(bounds.X + paddingLeft,
                                                bounds.Y + paddingTop,
                                                bounds.Width - paddingLeft - paddingRight,
                                                bounds.Height - paddingTop - paddingBottom);

            // رسم المحاور
            using (Pen axisPen = new Pen(Color.FromArgb(230, 230, 230), 1))
            {
                g.DrawLine(axisPen, chartArea.X, chartArea.Bottom, chartArea.Right, chartArea.Bottom); // X-axis
            }

            // ترتيب الأيام (الأحد -> السبت)
            var daysOrder = new[] { "الأحد", "الاثنين", "الثلاثاء", "الأربعاء", "الخميس", "الجمعة", "السبت" };
            var orderedData = daysOrder.Select(day => new KeyValuePair<string, double>(day, data.ContainsKey(day) ? data[day] : 0)).ToList();

            // حساب أقصى قيمة لتحديد مقياس الرسم
            double maxValue = orderedData.Max(entry => entry.Value);
            if (maxValue == 0) maxValue = 100;

            // زيادة عرض الأعمدة (85% بدلاً من 70%)
            float totalBarSpace = (float)chartArea.Width / orderedData.Count;
            float barWidth = totalBarSpace * 0.85f;
            float gap = (totalBarSpace - barWidth) / 2f;

            using (SolidBrush barBrush = new SolidBrush(BarColor))
            using (SolidBrush textBrush = new SolidBrush(this.ForeColor))
            {
                // لا نستخدم using هنا لأن الخطوط هي خصائص (Properties) يتم إعادة استخدامها
                Font labelFont = LabelFont;
                Font valueFont = ValueFont;

                for (int i = 0; i < orderedData.Count; i++)
                {
                    var entry = orderedData[i];
                    float x = chartArea.X + (i * (barWidth + 2 * gap)) + gap;
                    float barHeight = (float)(entry.Value / maxValue) * chartArea.Height;
                    float y = chartArea.Bottom - barHeight;

                    // رسم العمود
                    g.FillRectangle(barBrush, x, y, barWidth, barHeight);

                    // رسم قيمة العمود
                    string valueText = entry.Value.ToString("N0");
                    SizeF textSize = g.MeasureString(valueText, valueFont);
                    g.DrawString(valueText, valueFont, textBrush, x + (barWidth / 2) - (textSize.Width / 2), y - textSize.Height - 5);

                    // رسم اسم اليوم
                    SizeF dayTextSize = g.MeasureString(entry.Key, labelFont);
                    g.DrawString(entry.Key, labelFont, textBrush, x + (barWidth / 2) - (dayTextSize.Width / 2), chartArea.Bottom + 5);
                }
            }

            // رسم تسميات المحور Y (اختياري، يمكن تحسينه)
            using (Pen gridPen = new Pen(Color.FromArgb(240, 240, 240), 1))
            using (Font yLabelFont = new Font("Tajawal", 8f))
            {
                int numLabels = 5;
                for (int i = 0; i <= numLabels; i++)
                {
                    double labelValue = (maxValue / numLabels) * i;
                    float yPos = chartArea.Bottom - (float)(labelValue / maxValue) * chartArea.Height;
                    g.DrawLine(gridPen, chartArea.X, yPos, chartArea.X - 5, yPos); // علامات صغيرة
                    g.DrawString(labelValue.ToString("N0"), yLabelFont, Brushes.Black, chartArea.X - paddingLeft + 5, yPos - (yLabelFont.Height / 2));
                }
            }
        }

        // دالة لتحميل البيانات من التخزين وتحديث الرسم البياني
        public void LoadWeeklyRevenueFromStorage()
        {
            DateTime today = DateTime.Today;
            int diff = (7 + (today.DayOfWeek - DayOfWeek.Sunday)) % 7;
            DateTime startOfWeek = today.AddDays(-1 * diff).Date;
            DateTime endOfWeek = startOfWeek.AddDays(6).Date;

            var weeklyData = new Dictionary<string, double>();

            var daysOrder = new[] { "الأحد", "الاثنين", "الثلاثاء", "الأربعاء", "الخميس", "الجمعة", "السبت" };
            foreach (var day in daysOrder)
            {
                weeklyData[day] = 0;
            }

            if (DataStorage.BookingsList != null)
            {
                var bookingsThisWeek = DataStorage.BookingsList
                    .Where(b => b.BookingDate.Date >= startOfWeek && b.BookingDate.Date <= endOfWeek)
                    .ToList();

                foreach (var booking in bookingsThisWeek)
                {
                    string dayName = DataStorage.DaysMap.FirstOrDefault(x => x.Value == booking.BookingDate.DayOfWeek).Key;
                    if (dayName != null && weeklyData.ContainsKey(dayName))
                    {
                        weeklyData[dayName] += (double)booking.TotalAmount;
                    }
                }
            }

            this.ChartData = weeklyData; // تحديث البيانات في الكنترول المخصص
        }
    }
}
