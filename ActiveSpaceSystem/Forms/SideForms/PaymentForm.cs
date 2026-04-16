using ActiveSpace.Models;
using ActiveSpaceSystem.CustomItems;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace ActiveSpaceSystem.Forms.SideForms
{
    public partial class PaymentForm : Form
    {
        private MyGunaButton _btnRenderer = new MyGunaButton();

        public PaymentForm()
        {
            InitializeComponent();
            this.TopLevel = false;

            // إعدادات الزر
            _btnRenderer.NormalBackColor = Color.FromArgb(0, 184, 148);
            _btnRenderer.BorderRadius = 15;
            _btnRenderer.Font = new Font("Tajawal", 7, FontStyle.Bold);
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            

            BindGrid();
            dgvReservation.ClearSelection();
        }

        

        private void BindGrid()
        {
            var data = Booking.GetFakeData().Select(b =>
            {
                decimal paid = Payment.GetFakeData()
                              .Where(p => p.BookingID == b.BookingID)
                              .Sum(p => p.AmountPaid);
                return new
                {
                    b.BookingID,
                    CustomerName = b.Customer.FullName,
                    BookingDate = b.BookingDate.ToString("yyyy - MM-dd"),
                    TotalAmount = b.TotalAmount,
                    PaidAmount = paid,
                    Remaining = b.TotalAmount - paid,
                    Status = b.Status.ToString()
                };
            }).ToList();

            dgvReservation.DataSource = data;

            dgvReservation.Columns["BookingID"].HeaderText = "رقم الحجز";
            dgvReservation.Columns["CustomerName"].HeaderText = "العميل";
            dgvReservation.Columns["BookingDate"].HeaderText = "التاريخ";
            dgvReservation.Columns["TotalAmount"].HeaderText = "المبلغ الكلي";
            dgvReservation.Columns["PaidAmount"].HeaderText = "المدفوع";
            dgvReservation.Columns["Remaining"].HeaderText = "المتبقي";
            dgvReservation.Columns["Status"].HeaderText = "الحالة";
            

            if (!dgvReservation.Columns.Contains("ActionBtn"))
            {
                DataGridViewButtonColumn btnCol = new DataGridViewButtonColumn();
                btnCol.Name = "ActionBtn";
                btnCol.HeaderText = "الإجراء";
                btnCol.FlatStyle = FlatStyle.Flat;
                dgvReservation.Columns.Add(btnCol);
            }
            dgvReservation.Columns["ActionBtn"].Width = 100;
        }

        private void dgvReservation_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // 1. رسم عمود الحالة (Status)
            if (dgvReservation.Columns[e.ColumnIndex].Name == "Status")
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.ContentForeground);

                string rawStatus = e.Value?.ToString();
                string displayStatus;
                Color backColor, textColor;

                if (rawStatus == "Completed") { backColor = Color.FromArgb(232, 245, 233); textColor = Color.FromArgb(46, 125, 50); displayStatus = "مكتمل"; }
                else if (rawStatus == "Confirmed") { backColor = Color.FromArgb(255, 249, 196); textColor = Color.FromArgb(245, 127, 23); displayStatus = "جزئي"; }
                else { backColor = Color.FromArgb(255, 235, 238); textColor = Color.FromArgb(198, 40, 40); displayStatus = "غير مدفوع"; }

                using (GraphicsPath path = new GraphicsPath())
                {
                    Rectangle rect = new Rectangle(e.CellBounds.X + 15, e.CellBounds.Y + 12, e.CellBounds.Width - 30, e.CellBounds.Height - 24);
                    int d = rect.Height;
                    path.AddArc(rect.X, rect.Y, d, d, 90, 180);
                    path.AddArc(rect.Right - d, rect.Y, d, d, 270, 180);
                    path.CloseFigure();

                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    using (SolidBrush sb = new SolidBrush(backColor)) e.Graphics.FillPath(sb, path);
                }
                TextRenderer.DrawText(e.Graphics, displayStatus, e.CellStyle.Font, e.CellBounds, textColor, TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);
                e.Handled = true;
            }

            // 2. رسم زر تسجيل الدفعة (بدون تظليل عند النقر)
            if (dgvReservation.Columns[e.ColumnIndex].Name == "ActionBtn")
            {
                // نستخدم رسم الخلفية العادية للسطر حتى لو كانت الخلية محددة (Selected)
                bool isSelected = (e.State & DataGridViewElementStates.Selected) == DataGridViewElementStates.Selected;
                Color cellBack = isSelected ? Color.FromArgb(248, 249, 250) : e.CellStyle.BackColor;

                using (SolidBrush backBrush = new SolidBrush(cellBack))
                {
                    e.Graphics.FillRectangle(backBrush, e.CellBounds);
                }
                e.Paint(e.CellBounds, DataGridViewPaintParts.Border); // رسم الحدود فقط

                decimal remaining = Convert.ToDecimal(dgvReservation.Rows[e.RowIndex].Cells["Remaining"].Value);

                if (remaining > 0)
                {
                    Rectangle btnRect = new Rectangle(e.CellBounds.X + 10, e.CellBounds.Y + 10, e.CellBounds.Width - 20, e.CellBounds.Height - 20);

                    using (GraphicsPath path = new GraphicsPath())
                    {
                        int r = _btnRenderer.BorderRadius;
                        path.AddArc(btnRect.X, btnRect.Y, r, r, 180, 90);
                        path.AddArc(btnRect.Right - r, btnRect.Y, r, r, 270, 90);
                        path.AddArc(btnRect.Right - r, btnRect.Bottom - r, r, r, 0, 90);
                        path.AddArc(btnRect.X, btnRect.Bottom - r, r, r, 90, 90);
                        path.CloseFigure();

                        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                        using (SolidBrush br = new SolidBrush(_btnRenderer.NormalBackColor))
                            e.Graphics.FillPath(br, path);
                    }
                    TextRenderer.DrawText(e.Graphics, "تسجيل دفعة", _btnRenderer.Font, btnRect, Color.White, TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);
                }
                e.Handled = true;
            }
        }

        private void dgvReservation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvReservation.Columns[e.ColumnIndex].Name == "ActionBtn")
            {
                decimal remaining = Convert.ToDecimal(dgvReservation.Rows[e.RowIndex].Cells["Remaining"].Value);
                if (remaining > 0)
                {
                    int id = (int)dgvReservation.Rows[e.RowIndex].Cells["BookingID"].Value;
                    MessageBox.Show($"انتقال لتسجيل دفعة للحجز: B-{id}");
                }
            }
            else
            {
                int bookingId = Convert.ToInt32(dgvReservation.Rows[e.RowIndex].Cells["BookingID"].Value);
                ShowBookingDetails(bookingId);
            }
        }

        private void ShowBookingDetails(int bookingId)
        {
            var booking = Booking.GetFakeData().FirstOrDefault(b => b.BookingID == bookingId);
            if (booking != null)
            {
                decimal paid = Payment.GetFakeData()
                              .Where(p => p.BookingID == booking.BookingID)
                              .Sum(p => p.AmountPaid);
                decimal remaining = booking.TotalAmount - paid;

                bookingDetailsCard.BookingID = $"B-{booking.BookingID}";
                bookingDetailsCard.CustomerName = booking.Customer.FullName;
                bookingDetailsCard.PhoneNumber = booking.Customer.Phone;

                bookingDetailsCard.TotalAmount = $"{booking.TotalAmount} د.ل";
                bookingDetailsCard.PaidAmount = $"{paid} د.ل";
                bookingDetailsCard.RemainingAmount = $"{remaining} د.ل";

                bookingDetailsCard.IsItemSelected = true;
                bookingDetailsCard.RemainingColor = remaining > 0 ? Color.Red : Color.Green;
            }
        }
    }
}