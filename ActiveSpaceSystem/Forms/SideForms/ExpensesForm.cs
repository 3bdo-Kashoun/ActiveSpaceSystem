using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
// تأكد من استيراد الـ Namespaces الخاصة بمشروعك
// using ActiveSpaceSystem.Forms.GridStyle; 

namespace ActiveSpaceSystem.Forms.SideForms
{
    public partial class ExpensesForm : Form
    {
        private DataTable dtExpenses;
        private ImageList actionImageList;
        private ExpenseGridRenderer gridRenderer; // سنعرف الريندرر بالأسفل

        public ExpensesForm()
        {
            InitializeComponent();
            this.Load += ExpensesForm_Load;

            // تفعيل الـ DoubleBuffered لضمان عدم حدوث رعشة (Flicker) أثناء الحركة
            typeof(DataGridView).GetProperty("DoubleBuffered",
                System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                ?.SetValue(dgvExpenses, true, null);
        }

        private void ExpensesForm_Load(object sender, EventArgs e)
        {
            InitializeActionImages();
            SetupGrid();
            LoadData();
        }

        private void InitializeActionImages()
        {
            actionImageList = new ImageList();
            actionImageList.ImageSize = new Size(24, 24);
            actionImageList.ColorDepth = ColorDepth.Depth32Bit;
            gridRenderer = new ExpenseGridRenderer(actionImageList);

            try
            {
                var assembly = typeof(ExpensesForm).Assembly;
                // تأكد من تطابق المسميات مع ملفات الـ Resources لديك
                using (var editStream = assembly.GetManifestResourceStream("ActiveSpaceSystem.Resources.icons8-edit-48.png"))
                    if (editStream != null) actionImageList.Images.Add("edit", Image.FromStream(editStream));

                using (var deleteStream = assembly.GetManifestResourceStream("ActiveSpaceSystem.Resources.icons8-delete-48.png"))
                    if (deleteStream != null) actionImageList.Images.Add("delete", Image.FromStream(deleteStream));
            }
            catch { /* التعامل مع الخطأ */ }
        }

        private void SetupGrid()
        {
            dgvExpenses.Columns.Clear();
            dgvExpenses.AutoGenerateColumns = false;
            dgvExpenses.RowTemplate.Height = 65;
            dgvExpenses.ReadOnly = true;

            // إضافة الأعمدة المطلوبة فقط (بدون مورد أو طريقة دفع)
            dgvExpenses.Columns.Add(new DataGridViewTextBoxColumn { Name = "Date", HeaderText = "التاريخ", DataPropertyName = "Date", Width = 100 });
            dgvExpenses.Columns.Add(new DataGridViewTextBoxColumn { Name = "Category", HeaderText = "الفئة", DataPropertyName = "Category", Width = 110 });
            dgvExpenses.Columns.Add(new DataGridViewTextBoxColumn { Name = "Description", HeaderText = "الوصف", DataPropertyName = "Description", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvExpenses.Columns.Add(new DataGridViewTextBoxColumn { Name = "Amount", HeaderText = "المبلغ", DataPropertyName = "Amount", Width = 90 });
            dgvExpenses.Columns.Add(new DataGridViewTextBoxColumn { Name = "Status", HeaderText = "الحالة", DataPropertyName = "Status", Width = 100 });
            dgvExpenses.Columns.Add(new DataGridViewTextBoxColumn { Name = "Actions", HeaderText = "الإجراءات", Width = 110 });

            // ربط الأحداث بنفس أسلوب صفحة العملاء
            dgvExpenses.CellPainting += DgvExpenses_CellPainting;
            dgvExpenses.MouseDown += DgvExpenses_MouseDown; // استخدام MouseDown أدق للتفاعل
            dgvExpenses.MouseMove += DgvExpenses_MouseMove;
        }

        private void LoadData()
        {
            dtExpenses = new DataTable();
            dtExpenses.Columns.Add("Date"); dtExpenses.Columns.Add("Category");
            dtExpenses.Columns.Add("Description"); dtExpenses.Columns.Add("Amount");
            dtExpenses.Columns.Add("Status");

            // بيانات تجريبية
            dtExpenses.Rows.Add("2026-05-03", "كهرباء ومياه", "فاتورة الكهرباء - مايو", "٢,٤٠٠", "مدفوع");
            dtExpenses.Rows.Add("2026-05-04", "صيانة مرافق", "إصلاح نظام التكييف", "١,١٥٠", "مدفوع");
            dgvExpenses.DataSource = dtExpenses;
        }

        private void DgvExpenses_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dgvExpenses.Columns[e.ColumnIndex].Name == "Actions")
            {
                gridRenderer.RenderActionsCell(e);
            }
        }

        // حدث تحريك الماوس لتغيير المؤشر لـ "يد" (Hand) عند المرور فوق الأيقونات
        private void DgvExpenses_MouseMove(object sender, MouseEventArgs e)
        {
            var hit = dgvExpenses.HitTest(e.X, e.Y);
            if (hit.RowIndex >= 0 && hit.ColumnIndex >= 0 && dgvExpenses.Columns[hit.ColumnIndex].Name == "Actions")
            {
                var cellRect = dgvExpenses.GetCellDisplayRectangle(hit.ColumnIndex, hit.RowIndex, false);
                int relativeX = e.X - cellRect.X;
                var (isEdit, isDelete) = gridRenderer.GetClickedButton(cellRect, relativeX);

                dgvExpenses.Cursor = (isEdit || isDelete) ? Cursors.Hand : Cursors.Default;
            }
            else dgvExpenses.Cursor = Cursors.Default;
        }

        // حدث الضغط الفعلي على الأزرار
        private void DgvExpenses_MouseDown(object sender, MouseEventArgs e)
        {
            var hit = dgvExpenses.HitTest(e.X, e.Y);
            if (hit.RowIndex >= 0 && hit.ColumnIndex >= 0 && dgvExpenses.Columns[hit.ColumnIndex].Name == "Actions")
            {
                var cellRect = dgvExpenses.GetCellDisplayRectangle(hit.ColumnIndex, hit.RowIndex, false);
                int relativeX = e.X - cellRect.X;
                var (isEdit, isDelete) = gridRenderer.GetClickedButton(cellRect, relativeX);

                if (isEdit) HandleEdit(hit.RowIndex);
                else if (isDelete) HandleDelete(hit.RowIndex);
            }
        }

        private void HandleEdit(int rowIndex)
        {
            string info = dgvExpenses.Rows[rowIndex].Cells["Description"].Value.ToString();
            MessageBox.Show($"تعديل مصروف: {info}", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void HandleDelete(int rowIndex)
        {
            if (MessageBox.Show("هل أنت متأكد من الحذف؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                dtExpenses.Rows.RemoveAt(rowIndex);
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            Form form = new DialogForms.AddExpens();
            form.ShowDialog();
        }
    }

    // فئة الريندرر (ExpenseGridRenderer) مطابقة لمنطق العملاء
    public class ExpenseGridRenderer
    {
        private ImageList _imgs;
        public ExpenseGridRenderer(ImageList imgs) => _imgs = imgs;

        public void RenderActionsCell(DataGridViewCellPaintingEventArgs e)
        {
            e.PaintBackground(e.CellBounds, true);
            int iconSize = 22;
            int padding = 15;

            // أيقونة التعديل (يمين)
            if (_imgs.Images.ContainsKey("edit"))
                e.Graphics.DrawImage(_imgs.Images["edit"],
                    new Rectangle(e.CellBounds.Right - iconSize - padding, e.CellBounds.Y + (e.CellBounds.Height - iconSize) / 2, iconSize, iconSize));

            // أيقونة الحذف (يسار)
            if (_imgs.Images.ContainsKey("delete"))
                e.Graphics.DrawImage(_imgs.Images["delete"],
                    new Rectangle(e.CellBounds.Left + padding, e.CellBounds.Y + (e.CellBounds.Height - iconSize) / 2, iconSize, iconSize));

            e.Handled = true;
        }

        public (bool isEdit, bool isDelete) GetClickedButton(Rectangle cellRect, int relativeX)
        {
            // تحديد مساحة النقر بدقة:
            // تعديل: آخر 45 بكسل من اليمين | حذف: أول 45 بكسل من اليسار
            bool isEdit = relativeX > (cellRect.Width - 45);
            bool isDelete = relativeX < 45;
            return (isEdit, isDelete);
        }
    }
}