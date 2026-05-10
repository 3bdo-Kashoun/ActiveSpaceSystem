using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using ActiveSpace.Models;
using ActiveSpaceSystem.Data;
using ActiveSpaceSystem.Forms.DialogForms;
using ActiveSpaceSystem.Models.enums;
using ActiveSpaceSystem.Forms.GridStyle; // استيراد الرسام

namespace ActiveSpaceSystem.Forms.SideForms
{
    public partial class MonthlyContractForm : Form
    {
        // إعدادات النصوص والألوان للحالات
        private string TextActive = "نشط";
        private string TextExpired = "منتهي";
        private string TextCanceled = "ملغي";

        private Color ColorActiveBack = Color.FromArgb(232, 245, 233);
        private Color ColorActiveText = Color.FromArgb(46, 125, 50);
        private Color ColorExpiredBack = Color.FromArgb(255, 235, 238);
        private Color ColorExpiredText = Color.FromArgb(198, 40, 40);
        private Color ColorCanceledBack = Color.FromArgb(245, 245, 245);
        private Color ColorCanceledText = Color.FromArgb(117, 117, 117);

        // متغيرات الأزرار
        private ImageList actionImageList;
        private ContractGridRenderer gridRenderer;

        public MonthlyContractForm()
        {
            InitializeComponent();
            this.TopLevel = false;

            // إعداد الأيقونات والرسام
            InitializeActionImages();

            // ربط الأحداث برمجياً لضمان عدم ضياعها
            dgvMonthlyContract.CellPainting += dgvMonthlyContract_CellPainting;
            dgvMonthlyContract.CellClick += dgvMonthlyContract_CellClick;
        }

        private void InitializeActionImages()
        {
            actionImageList = new ImageList();
            actionImageList.ImageSize = new Size(32, 32);
            actionImageList.ColorDepth = ColorDepth.Depth32Bit;
            gridRenderer = new ContractGridRenderer(actionImageList);

            try
            {
                var assembly = typeof(MonthlyContractForm).Assembly;
                using (var editStream = assembly.GetManifestResourceStream("ActiveSpaceSystem.Resources.icons8-edit-48.png"))
                    if (editStream != null) actionImageList.Images.Add("edit", Image.FromStream(editStream));

                using (var deleteStream = assembly.GetManifestResourceStream("ActiveSpaceSystem.Resources.icons8-delete-48.png"))
                    if (deleteStream != null) actionImageList.Images.Add("delete", Image.FromStream(deleteStream));
            }
            catch { }
        }

        private void MonthlyContractForm_Load_1(object sender, EventArgs e)
        {
            dgvMonthlyContract.RowTemplate.Height = 55;
            dgvMonthlyContract.ColumnHeadersHeight = 45;
            dgvMonthlyContract.EnableHeadersVisualStyles = false;
            dgvMonthlyContract.DefaultCellStyle.SelectionBackColor = Color.FromArgb(248, 249, 250);
            dgvMonthlyContract.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvMonthlyContract.DefaultCellStyle.Font = new Font("Tajawal", 9);
            dgvMonthlyContract.ColumnHeadersDefaultCellStyle.Font = new Font("Tajawal", 10, FontStyle.Bold);

            RefreshContractsGrid();
        }

        public void RefreshContractsGrid()
        {
            var data = DataStorage.ContractsList.Select(mc =>
            {
                var court = DataStorage.CourtsList.FirstOrDefault(c => c.CourtID == mc.CourtID);
                var customer = DataStorage.CustomersList.FirstOrDefault(cu => cu.CustomerID == mc.CustomerID);

                return new
                {
                    mc.ContractID,
                    CustomerName = customer != null ? customer.FullName : "غير معروف",
                    PhoneNumber = customer != null ? customer.Phone : "غير معروف",
                    CourtName = court != null ? court.CourtName : "غير معروف",
                    DayOfWeek = GetArabicDay(mc.DayOfWeek),
                    TimeSlot = $"{mc.FixedStartTime:hh\\:mm} - {mc.FixedEndTime:hh\\:mm}",
                    StartDate = mc.StartDate.ToString("yyyy-MM-dd"),
                    EndDate = mc.EndDate.ToString("yyyy-MM-dd"),
                    Amount = mc.Bookings?.Sum(b => b.TotalAmount) ?? 0,
                    Status = mc.Status.ToString()
                };
            }).ToList();

            dgvMonthlyContract.DataSource = null;
            dgvMonthlyContract.Columns.Clear();
            dgvMonthlyContract.DataSource = data;

            if (dgvMonthlyContract.Columns["ContractID"] != null) dgvMonthlyContract.Columns["ContractID"].Visible = false;

            dgvMonthlyContract.Columns["CustomerName"].HeaderText = "اسم العميل";
            dgvMonthlyContract.Columns["PhoneNumber"].HeaderText = "رقم الهاتف";
            dgvMonthlyContract.Columns["CourtName"].HeaderText = "الملعب";
            dgvMonthlyContract.Columns["DayOfWeek"].HeaderText = "اليوم";
            dgvMonthlyContract.Columns["TimeSlot"].HeaderText = "الفترة";
            dgvMonthlyContract.Columns["StartDate"].HeaderText = "البداية";
            dgvMonthlyContract.Columns["EndDate"].HeaderText = "النهاية";
            dgvMonthlyContract.Columns["Amount"].HeaderText = "المبلغ";
            dgvMonthlyContract.Columns["Status"].HeaderText = "الحالة";

            DataGridViewTextBoxColumn actionCol = new DataGridViewTextBoxColumn();
            actionCol.Name = "Actions";
            actionCol.HeaderText = "الإجراءات";
            actionCol.Width = 110;
            dgvMonthlyContract.Columns.Add(actionCol);

            UpdateDashboardCards();
        }

        private void dgvMonthlyContract_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (dgvMonthlyContract.Columns[e.ColumnIndex].Name == "Status")
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.ContentForeground);
                string rawStatus = e.Value?.ToString();
                Color backColor = ColorActiveBack;
                Color textColor = ColorActiveText;
                string displayStatus = TextActive;

                if (rawStatus == "Expired") { backColor = ColorExpiredBack; textColor = ColorExpiredText; displayStatus = TextExpired; }
                else if (rawStatus == "Canceled") { backColor = ColorCanceledBack; textColor = ColorCanceledText; displayStatus = TextCanceled; }

                using (GraphicsPath path = new GraphicsPath())
                {
                    Rectangle rect = new Rectangle(e.CellBounds.X + 12, e.CellBounds.Y + 16, e.CellBounds.Width - 24, e.CellBounds.Height - 32);
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
            else if (dgvMonthlyContract.Columns[e.ColumnIndex].Name == "Actions")
            {
                gridRenderer.RenderActionsCell(e);
            }
        }

        private void dgvMonthlyContract_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (dgvMonthlyContract.Columns[e.ColumnIndex].Name == "Actions")
            {
                var cellRect = dgvMonthlyContract.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                var mousePos = dgvMonthlyContract.PointToClient(Cursor.Position);
                int relativeX = mousePos.X - cellRect.X;

                var (isEdit, isDelete) = gridRenderer.GetClickedButton(cellRect, relativeX);

                if (isEdit) HandleEdit(e.RowIndex);
                else if (isDelete) HandleDelete(e.RowIndex);
            }
        }

        private void HandleEdit(int rowIndex)
        {
            // جلب الـ ID من السطر المحدد
            if (dgvMonthlyContract.Rows[rowIndex].Cells["ContractID"].Value is int contractId)
            {
                // البحث عن العقد في مخزن البيانات
                var contract = DataStorage.ContractsList.FirstOrDefault(c => c.ContractID == contractId);
                if (contract != null)
                {
                    // فتح واجهة AddContract وتمرير العقد لها (استخدام المشيد الثاني)
                    using (var editForm = new AddContract(contract))
                    {
                        if (editForm.ShowDialog() == DialogResult.OK)
                        {
                            RefreshContractsGrid();
                        }
                    }
                }
            }
        }

        private void HandleDelete(int rowIndex)
        {
            // 1. الحصول على معرف العقد من الصف المختار
            if (dgvMonthlyContract.Rows[rowIndex].Cells["ContractID"].Value is int contractId)
            {
                // 2. رسالة تأكيد للمستخدم
                var result = MessageBox.Show("هل أنت متأكد من حذف هذا العقد؟\nسيتم حذف جميع الحجوزات والمدفوعات المرتبطة به أيضاً.",
                                           "تأكيد الحذف النهائي",
                                           MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // 3. الحذف من مخزن البيانات (DataStorage)

                        // أ- حذف الحجوزات المرتبطة بهذا العقد أولاً
                        DataStorage.BookingsList.RemoveAll(b => b.ContractID == contractId);

                        // ب- حذف المدفوعات المرتبطة بحجوزات هذا العقد
                        // (نبحث عن المدفوعات التي ينتمي حجزها لهذا العقد)
                        DataStorage.PaymentList.RemoveAll(p => p.Booking != null && p.Booking.ContractID == contractId);

                        // ج- حذف العقد نفسه من قائمة العقود
                        var contractToRemove = DataStorage.ContractsList.FirstOrDefault(c => c.ContractID == contractId);
                        if (contractToRemove != null)
                        {
                            DataStorage.ContractsList.Remove(contractToRemove);
                        }

                        // 4. تحديث الواجهة والبطاقات الإحصائية
                        RefreshContractsGrid();

                        MessageBox.Show("تم حذف العقد وجميع متعلقاته بنجاح.", "تم الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("حدث خطأ أثناء الحذف: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private string GetArabicDay(string englishDay)
        {
            var days = new Dictionary<string, string> {
                {"Saturday", "السبت"}, {"Sunday", "الأحد"}, {"Monday", "الاثنين"},
                {"Tuesday", "الثلاثاء"}, {"Wednesday", "الأربعاء"}, {"Thursday", "الخميس"}, {"Friday", "الجمعة"}
            };
            return days.ContainsKey(englishDay) ? days[englishDay] : englishDay;
        }

        private void UpdateDashboardCards()
        {
            try
            {
                int activeCount = DataStorage.ContractsList.Count(c => c.Status == MonthlyContractStatus.Active);
                if (statusCardCont != null) statusCardCont.ValueText = activeCount.ToString();

                double totalRevenue = DataStorage.ContractsList
                    .Where(c => c.Status == MonthlyContractStatus.Active)
                    .Sum(c => c.Bookings?.Sum(b => b.TotalAmount) ?? 0);
                if (statusCardTotal != null) statusCardTotal.ValueText = totalRevenue.ToString("N0") + " د.ل";
            }
            catch { }
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            using (var addForm = new AddContract())
            {
                if (addForm.ShowDialog() == DialogResult.OK) RefreshContractsGrid();
            }
        }
    }
}