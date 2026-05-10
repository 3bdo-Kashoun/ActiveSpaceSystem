using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using ActiveSpace.Models;
using ActiveSpaceSystem.Data;
using ActiveSpaceSystem.Forms.DialogForms;
using ActiveSpaceSystem.Models.enums;
using ActiveSpaceSystem.Forms.GridStyle;
using ActiveSpaceSystem.Forms.Views; // استيراد الـ ViewModels

namespace ActiveSpaceSystem.Forms.SideForms
{
    public partial class MonthlyContractForm : Form
    {
        // إعدادات الألوان للنصوص (ستستخدم في الـ CellPainting)
        private Color ColorActiveBack = Color.FromArgb(232, 245, 233);
        private Color ColorActiveText = Color.FromArgb(46, 125, 50);
        private Color ColorExpiredBack = Color.FromArgb(255, 235, 238);
        private Color ColorExpiredText = Color.FromArgb(198, 40, 40);
        private Color ColorCanceledBack = Color.FromArgb(245, 245, 245);
        private Color ColorCanceledText = Color.FromArgb(117, 117, 117);

        private BindingList<ContractViewModel> contractsBindingList;
        private ImageList actionImageList;
        private ContractGridRenderer gridRenderer;

        public MonthlyContractForm()
        {
            InitializeComponent();
            this.TopLevel = false;

            InitializeActionImages();
            SetupGrid();

            this.Load += MonthlyContractForm_Load;
        }

        private void InitializeActionImages()
        {
            actionImageList = new ImageList { ImageSize = new Size(32, 32), ColorDepth = ColorDepth.Depth32Bit };
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

        private void SetupGrid()
        {
            dgvMonthlyContract.DataSource = null;
            dgvMonthlyContract.Columns.Clear();
            dgvMonthlyContract.AutoGenerateColumns = false;

            // إعدادات التصميم
            dgvMonthlyContract.RowTemplate.Height = 55;
            dgvMonthlyContract.ColumnHeadersHeight = 45;
            dgvMonthlyContract.EnableHeadersVisualStyles = false;
            dgvMonthlyContract.DefaultCellStyle.SelectionBackColor = Color.FromArgb(248, 249, 250);
            dgvMonthlyContract.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvMonthlyContract.DefaultCellStyle.Font = new Font("Tajawal", 9);
            dgvMonthlyContract.ColumnHeadersDefaultCellStyle.Font = new Font("Tajawal", 10, FontStyle.Bold);

            // إضافة الأعمدة يدوياً كما في ManageBooking
            AddColumns();

            dgvMonthlyContract.CellPainting += dgvMonthlyContract_CellPainting;
            dgvMonthlyContract.CellClick += dgvMonthlyContract_CellClick;
        }

        private void AddColumns()
        {
            dgvMonthlyContract.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "CustomerName", HeaderText = "اسم العميل", Name = "CustomerName", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvMonthlyContract.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "PhoneNumber", HeaderText = "رقم الهاتف", Width = 110 });
            dgvMonthlyContract.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "CourtName", HeaderText = "الملعب", Width = 110 });
            dgvMonthlyContract.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "DayOfWeek", HeaderText = "اليوم", Width = 80 });
            dgvMonthlyContract.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TimeSlot", HeaderText = "الفترة", Width = 110 });
            dgvMonthlyContract.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "StartDate", HeaderText = "البداية", Width = 95 });
            dgvMonthlyContract.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "EndDate", HeaderText = "النهاية", Width = 95 });
            dgvMonthlyContract.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Amount", HeaderText = "المبلغ", Width = 80 });
            dgvMonthlyContract.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Status", HeaderText = "الحالة", Name = "Status", Width = 100 });
            dgvMonthlyContract.Columns.Add(new DataGridViewTextBoxColumn { Name = "Actions", HeaderText = "الإجراءات", Width = 110 });
        }

        private void MonthlyContractForm_Load(object sender, EventArgs e)
        {
            RefreshContractsGrid();
            dgvMonthlyContract.ClearSelection();
        }

        public void RefreshContractsGrid()
        {
            var data = DataStorage.ContractsList
                .Select(ContractViewModel.FromContract)
                .ToList();

            contractsBindingList = new BindingList<ContractViewModel>(data);
            dgvMonthlyContract.DataSource = contractsBindingList;

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
                string displayStatus = "نشط";

                if (rawStatus == "Expired") { backColor = ColorExpiredBack; textColor = ColorExpiredText; displayStatus = "منتهي"; }
                else if (rawStatus == "Canceled") { backColor = ColorCanceledBack; textColor = ColorCanceledText; displayStatus = "ملغي"; }

                using (GraphicsPath path = new GraphicsPath())
                {
                    Rectangle rect = new Rectangle(e.CellBounds.X + 8, e.CellBounds.Y + 16, e.CellBounds.Width - 16, e.CellBounds.Height - 32);
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
            var item = dgvMonthlyContract.Rows[rowIndex].DataBoundItem as ContractViewModel;
            if (item == null) return;

            var contract = DataStorage.ContractsList.FirstOrDefault(c => c.ContractID == item.ContractID);
            if (contract != null)
            {
                using (var editForm = new AddContract(contract))
                {
                    if (editForm.ShowDialog() == DialogResult.OK) RefreshContractsGrid();
                }
            }
        }

        private void HandleDelete(int rowIndex)
        {
            var item = dgvMonthlyContract.Rows[rowIndex].DataBoundItem as ContractViewModel;
            if (item == null) return;

            if (MessageBox.Show("هل أنت متأكد من حذف هذا العقد وجميع متعلقاته؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                // الحذف المنطقي من البيانات
                DataStorage.BookingsList.RemoveAll(b => b.ContractID == item.ContractID);
                DataStorage.PaymentList.RemoveAll(p => p.Booking != null && p.Booking.ContractID == item.ContractID);

                var contractToRemove = DataStorage.ContractsList.FirstOrDefault(c => c.ContractID == item.ContractID);
                if (contractToRemove != null) DataStorage.ContractsList.Remove(contractToRemove);

                // التحديث المباشر للـ UI
                contractsBindingList.RemoveAt(rowIndex);
                UpdateDashboardCards();

                MessageBox.Show("تم الحذف بنجاح.", "إشعار", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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