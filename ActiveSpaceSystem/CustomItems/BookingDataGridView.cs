using System;
using System.Drawing;
using System.Windows.Forms;

namespace SportsApp.Controls
{
    public class BookingDataGridView : DataGridView
    {
        // تعريف الألوان كفواتير ثابتة لتسهيل التعديل
        private readonly Color HeaderBgColor = Color.FromArgb(245, 247, 249);
        private readonly Color AvailableBg = Color.FromArgb(232, 249, 244);
        private readonly Color AvailableText = Color.FromArgb(46, 204, 113);
        private readonly Color ReservedBg = Color.FromArgb(255, 225, 225);
        private readonly Color ReservedText = Color.FromArgb(231, 76, 60);
        private readonly Color GridLineColor = Color.FromArgb(230, 230, 230);

        public BookingDataGridView()
        {
            // إعدادات افتراضية للتحكم
            this.DoubleBuffered = true; // لمنع الوميض (Flicker)
            this.RightToLeft = RightToLeft.Yes;
            this.BackgroundColor = Color.White;
            this.BorderStyle = BorderStyle.None;
            this.RowHeadersVisible = false;
            this.AllowUserToAddRows = false;
            this.EnableHeadersVisualStyles = false;
            this.SelectionMode = DataGridViewSelectionMode.CellSelect;
            this.RowTemplate.Height = 70;
            this.GridColor = GridLineColor;

            // تنسيق رأس الجدول
            this.ColumnHeadersDefaultCellStyle.BackColor = HeaderBgColor;
            this.ColumnHeadersDefaultCellStyle.ForeColor = Color.DimGray;
            this.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            this.ColumnHeadersHeight = 50;
            this.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
        }

        protected override void OnCellPainting(DataGridViewCellPaintingEventArgs e)
        {
            // 1. رسم رؤوس الأعمدة
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                e.PaintBackground(e.CellBounds, true);
                TextRenderer.DrawText(e.Graphics, e.FormattedValue.ToString(), e.CellStyle.Font,
                    e.CellBounds, e.CellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);
                e.Handled = true;
            }

            // 2. رسم عمود الملاعب (العمود الأول) بتنسيق سطرين
            else if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                e.PaintBackground(e.CellBounds, true);
                if (e.Value != null)
                {
                    string text = e.Value.ToString();
                    string[] parts = text.Split('\n');

                    // السطر الأول: اسم الملعب (عريض)
                    Font titleFont = new Font("Segoe UI", 10, FontStyle.Bold);
                    Rectangle rectTitle = new Rectangle(e.CellBounds.X, e.CellBounds.Y + 15, e.CellBounds.Width, 25);
                    TextRenderer.DrawText(e.Graphics, parts[0], titleFont, rectTitle, Color.Black, TextFormatFlags.HorizontalCenter);

                    // السطر الثاني: نوع الرياضة (رمادي وصغير)
                    if (parts.Length > 1)
                    {
                        Font subFont = new Font("Segoe UI", 8, FontStyle.Regular);
                        Rectangle rectSub = new Rectangle(e.CellBounds.X, e.CellBounds.Y + 38, e.CellBounds.Width, 20);
                        TextRenderer.DrawText(e.Graphics, parts[1], subFont, rectSub, Color.Gray, TextFormatFlags.HorizontalCenter);
                    }
                }
                e.Graphics.DrawRectangle(new Pen(GridLineColor), e.CellBounds);
                e.Handled = true;
            }

            // 3. رسم خلايا الحجز (متاح / محجوز)
            else if (e.RowIndex >= 0 && e.ColumnIndex > 0)
            {
                string status = e.Value?.ToString() ?? "";
                Color backColor = AvailableBg;
                Color textColor = AvailableText;

                if (status.Contains("محجوز"))
                {
                    backColor = ReservedBg;
                    textColor = ReservedText;
                }

                using (SolidBrush brush = new SolidBrush(backColor))
                {
                    e.Graphics.FillRectangle(brush, e.CellBounds);
                }

                // رسم الإطار الداخلي
                e.Graphics.DrawRectangle(new Pen(Color.FromArgb(245, 245, 245)), e.CellBounds);

                TextRenderer.DrawText(e.Graphics, status, e.CellStyle.Font, e.CellBounds,
                    textColor, TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter | TextFormatFlags.WordBreak);

                e.Handled = true;
            }
        }

        // ميزة إضافية: ميثود لتجهيز الأعمدة تلقائياً
        public void InitializeTimeSlots(int startHour, int endHour)
        {
            this.Columns.Clear();
            this.Columns.Add("CourtName", "الملعب");
            this.Columns[0].Width = 180;

            for (int i = startHour; i <= endHour; i++)
            {
                string colName = $"h{i}";
                string colHeader = $"{i}:00";
                int idx = this.Columns.Add(colName, colHeader);
                this.Columns[idx].Width = 100;
                this.Columns[idx].DefaultCellStyle.Font = new Font("Segoe UI", 9);
            }
        }
    }
}