using ActiveSpaceSystem.Data;
using ActiveSpaceSystem.Forms.DialogForms;
using ActiveSpaceSystem.Forms.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ActiveSpaceSystem.Forms.SideForms
{
    public partial class SchedulingForm : Form
    {
        private List<ScheduleRowViewModel> scheduleList;

        public SchedulingForm()
        {
            InitializeComponent();
            this.TopLevel = false;
            SetupGrid();
            this.Load += SchedulingForm_Load;
        }

        private void SchedulingForm_Load(object sender, EventArgs e)
        {
            LoadDataToGrid(dateTimePicker2.Value);
        }

        private void SetupGrid()
        {
            stadiumGrid1.Columns.Clear();
            stadiumGrid1.Rows.Clear();

            stadiumGrid1.EditMode = DataGridViewEditMode.EditProgrammatically;

            // إزالة الأحداث القديمة لمنع تكرار النقر المزدوج
            stadiumGrid1.CellDoubleClick -= StadiumGrid1_CellDoubleClick;
            stadiumGrid1.CellDoubleClick += StadiumGrid1_CellDoubleClick;

            // العمود الأول لاسم الملعب
            stadiumGrid1.Columns.Add("Stadium", "الملعب");
            stadiumGrid1.Columns["Stadium"].Width = 180;
            stadiumGrid1.Columns["Stadium"].Frozen = true;

            // إضافة أعمدة الساعات من 8 إلى 23 مع إظهار الفترة الزمنية كاملة (مثال: 08:00 - 09:00)
            for (int i = 8; i <= 23; i++)
            {
                string colName = $"h{i}";

                string startTime = $"{i:D2}:00";
                string endTime = $"{(i + 1):D2}:00";
                string periodHeader = $"{startTime} - {endTime}"; // تنسيق الوقت الكامل

                stadiumGrid1.Columns.Add(colName, periodHeader);
                stadiumGrid1.Columns[colName].Width = 150; // زيادة العرض لتفادي اقتصاص النص (Ellipsis)
            }
        }

        public void LoadDataToGrid(DateTime targetDate)
        {
            stadiumGrid1.Rows.Clear();
            scheduleList = new List<ScheduleRowViewModel>();

            foreach (var court in DataStorage.CourtsList)
            {
                // 1. بناء السطر بالقيم العربية المتوافقة مع رسم الكنترول المخصص
                var rowData = ScheduleRowViewModel.BuildRow(court, targetDate);
                scheduleList.Add(rowData);

                // 2. تجهيز القيم لإضافتها للـ GridRow
                List<object> rowValues = new List<object> { rowData.CourtName };

                for (int i = 8; i <= 23; i++)
                {
                    rowValues.Add(rowData.HourlySlots[$"h{i}"]);
                }

                stadiumGrid1.Rows.Add(rowValues.ToArray());
            }

            stadiumGrid1.ClearSelection();
        }

        private void StadiumGrid1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            string columnName = stadiumGrid1.Columns[e.ColumnIndex].Name;

            if (columnName != "Stadium")
            {
                var cellValue = stadiumGrid1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();

                // نفتح واجهة الحجز عند النقر على خلية قيمتها النصية "متاح"
                if (cellValue == "متاح")
                {
                    string courtName = stadiumGrid1.Rows[e.RowIndex].Cells["Stadium"].Value.ToString();
                    int selectedHour = int.Parse(columnName.Replace("h", ""));

                    var court = DataStorage.CourtsList.FirstOrDefault(c => c.CourtName == courtName);
                    if (court == null) return;

                    using (AddBookingForm form = new AddBookingForm())
                    {
                        // تمرير البيانات المبدئية للفورم
                        form.cmbCourtType.SelectedValue = court.Type.TypeName;
                        form.cmbCourt.SelectedValue = court.CourtName;

                        form.dtpBookingDate.Value = dateTimePicker2.Value;
                        form.dtpStartTime.Value = DateTime.Today.AddHours(selectedHour);
                        form.dtpEndTime.Value = DateTime.Today.AddHours(selectedHour + 1);

                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            // إعادة تحميل الجدول فور الحفظ لتحديث الخلايا تلقائياً
                            LoadDataToGrid(dateTimePicker2.Value);
                        }
                    }
                }
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            LoadDataToGrid(dateTimePicker2.Value);
        }
    }
}