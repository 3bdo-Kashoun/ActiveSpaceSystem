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

namespace ActiveSpaceSystem.Forms.SideForms
{
    public partial class SchedulingForm : Form
    {
        public SchedulingForm()
        {
            InitializeComponent();
        }
        private void SetupGrid()
        {
            stadiumGrid1.Columns.Clear();

            // العمود الأول لاسم الملعب
            stadiumGrid1.Columns.Add("Stadium", "الملعب");
            stadiumGrid1.Columns["Stadium"].Width = 200;
            stadiumGrid1.Columns["Stadium"].Frozen = true; // تثبيت العمود الأول

            // إضافة أعمدة الساعات من 8 إلى 23
            for (int i = 8; i <= 23; i++)
            {
                string colName = $"h{i}";
                stadiumGrid1.Columns.Add(colName, $"{i}:00");
                stadiumGrid1.Columns[colName].Width = 130;
            }
        }
        private void LoadDataToGrid(DateTime targetDate)
        {
            stadiumGrid1.Rows.Clear();

            // نمروا على كل الملاعب اللي في الـ DataStorage
            foreach (var court in DataStorage.CourtsList)
            {
                List<object> rowValues = new List<object>();
                rowValues.Add(court.CourtName); // اسم الملعب

                // نجيبوا حجوزات هادا الملعب في اليوم المحدد
                var dayBookings = DataStorage.BookingsList
                    .Where(b => b.CourtID == court.CourtID && b.BookingDate.Date == targetDate.Date)
                    .ToList();

                // نمروا على الساعات (نفس ترتيب الأعمدة)
                for (int hour = 8; hour <= 23; hour++)
                {
                    TimeSpan slotStart = new TimeSpan(hour, 0, 0);
                    TimeSpan slotEnd = new TimeSpan(hour, 59, 59);

                    // 1. هل الملعب فاتح في الوقت هادا؟
                    // ملاحظة: لو CloseTime = 00:00 يعني مسكر نهاية اليوم (24:00)
                    TimeSpan actualClose = (court.CloseTime == TimeSpan.Zero) ? new TimeSpan(23, 59, 59) : court.CloseTime;

                    if (slotStart < court.OpenTime || slotStart >= actualClose)
                    {
                        rowValues.Add("خارج وقت العمل");
                    }
                    else
                    {
                        // 2. هل فيه حجز يتقاطع مع هادي الساعة؟
                        var booking = dayBookings.FirstOrDefault(b =>
                            (slotStart < b.EndTime && slotEnd > b.StartTime));

                        if (booking != null)
                        {
                            rowValues.Add($"محجوز|{booking.Customer?.FullName ?? "عميل"}");
                        }
                        else
                        {
                            rowValues.Add("متاح");
                        }
                    }
                }

                stadiumGrid1.Rows.Add(rowValues.ToArray());
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            LoadDataToGrid(dateTimePicker2.Value);
        }

        private void SchedulingForm_Load(object sender, EventArgs e)
        {
            SetupGrid();
            LoadDataToGrid(dateTimePicker2.Value);
        }
    }
}
