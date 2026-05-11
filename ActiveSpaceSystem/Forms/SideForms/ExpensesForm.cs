using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ActiveSpace.Models;
using ActiveSpaceSystem.Data;
using ActiveSpaceSystem.Forms.DialogForms;
using ActiveSpaceSystem.Forms.GridStyle;
using ActiveSpaceSystem.Models;
using ActiveSpaceSystem.Models.enums;

namespace ActiveSpaceSystem.Forms.SideForms
{
    public partial class ExpensesForm : Form
    {
        private ImageList actionImageList;
        private ExpenseGridRenderer gridRenderer;
        private User currentUser;
        public ExpensesForm(User user)
        {
            InitializeComponent();
            this.TopLevel = false;
            UpdateStatistics();
            // تهيئة العناصر الأساسية قبل أي عملية أخرى لمنع NullReferenceException
            InitializeActionImages();
            SetupGrid();
            currentUser = user;
        }

        private void InitializeActionImages()
        {
            actionImageList = new ImageList
            {
                ImageSize = new Size(32, 32),
                ColorDepth = ColorDepth.Depth32Bit
            };

            try
            {
                // التحقق من وجود المصادر قبل محاولة إضافتها
                if (Properties.Resources.icons8_edit_48 != null)
                    actionImageList.Images.Add("edit", Properties.Resources.icons8_edit_48);
                
                if (Properties.Resources.icons8_delete_48 != null)
                    actionImageList.Images.Add("delete", Properties.Resources.icons8_delete_48);
            }
            catch (Exception ex)
            {
                // تسجيل الخطأ أو عرض تنبيه بسيط بدل توقف البرنامج
                Console.WriteLine($"خطأ في تحميل الموارد: {ex.Message}");
            }
            
            // نمرر الـ ImageList حتى لو كانت فارغة لتجنب خطأ في الـ Renderer
            gridRenderer = new ExpenseGridRenderer(actionImageList);
        }

        private void SetupGrid()
        {
            dgvExpenses.AutoGenerateColumns = false;
            
            // إلغاء ربط الأحداث القديمة قبل الربط الجديد لتجنب الاستدعاء المتكرر
            dgvExpenses.CellPainting -= DgvExpenses_CellPainting;
            dgvExpenses.CellClick -= DgvExpenses_CellClick;
            
            dgvExpenses.CellPainting += DgvExpenses_CellPainting;
            dgvExpenses.CellClick += DgvExpenses_CellClick;

            AddColumns();
        }

        private void AddColumns()
        {
            dgvExpenses.Columns.Clear();

            // استخدام مصفوفة لإضافة الأعمدة لسهولة الإدارة
            var columns = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "ExpenseDate", HeaderText = "التاريخ", Name = "ExpenseDate", Width = 110 },
                new DataGridViewTextBoxColumn { DataPropertyName = "CategoryName", HeaderText = "الفئة", Name = "CategoryName", Width = 120 },
                new DataGridViewTextBoxColumn { DataPropertyName = "Description", HeaderText = "الوصف", Name = "Description", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill },
                new DataGridViewTextBoxColumn 
                { 
                    DataPropertyName = "Amount", 
                    HeaderText = "المبلغ", 
                    Name = "Amount", 
                    Width = 90,
                    DefaultCellStyle = new DataGridViewCellStyle 
                    { 
                        ForeColor = Color.Red, 
                        SelectionForeColor = Color.Red, 
                        Font = new Font("Tajwal", 10, FontStyle.Bold),
                        Alignment = DataGridViewContentAlignment.MiddleCenter
                    } 
                },
                new DataGridViewTextBoxColumn { Name = "Actions", HeaderText = "الإجراءات", Width = 100 }
            };

            dgvExpenses.Columns.AddRange(columns);
        }

        private void DgvExpenses_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // الحماية من رسم الهيدر أو خارج النطاق أو الخلايا المفقودة
            if (e.RowIndex < 0 || e.ColumnIndex < 0 || gridRenderer == null) return;

            if (dgvExpenses.Columns[e.ColumnIndex].Name == "Actions")
            {
                gridRenderer.RenderActionsCell(e);
            }
        }

        private void DgvExpenses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (dgvExpenses.Columns[e.ColumnIndex].Name == "Actions")
            {
                try 
                {
                    Rectangle cellRect = dgvExpenses.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                    Point mousePos = dgvExpenses.PointToClient(Cursor.Position);
                    int relativeX = mousePos.X - cellRect.X;

                    var (isEdit, isDelete) = gridRenderer.GetClickedButton(cellRect, relativeX);

                    if (isEdit) HandleEditClick(e.RowIndex);
                    else if (isDelete) HandleDeleteClick(e.RowIndex);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("حدث خطأ أثناء معالجة النقر: " + ex.Message);
                }
            }
        }

        private void HandleEditClick(int rowIndex)
        {
            if (currentUser == null || currentUser.Role==UserRole.Staff)
            {
                MessageBox.Show("ليس لديك صلاحية تعديل المصروفات.", "صلاحية مرفوضة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var item = dgvExpenses.Rows[rowIndex].DataBoundItem as Expense;
            if (item == null) return;

            // استخدام كائن التعديل (AddExpens) مع تمرير البيانات
            using (AddExpens frm = new AddExpens(item)) // افترضنا أنك أضفت Constructor يستقبل الكائن
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    RefreshGrid();
                }
            }
        }

        private void HandleDeleteClick(int rowIndex)
        {
            if (currentUser == null || currentUser.Role == UserRole.Staff)
            {
                MessageBox.Show("ليس لديك صلاحية حذف المصروفات.", "صلاحية مرفوضة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var item = dgvExpenses.Rows[rowIndex].DataBoundItem as Expense;
            if (item == null) return;

            if (MessageBox.Show($"هل أنت متأكد من حذف مصروف '{item.Description}'؟", "تأكيد الحذف",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, 
                MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading) == DialogResult.Yes)
            {
                // الحذف من المصدر الأصلي لضمان المزامنة
                DataStorage.AllExpenses.Remove(item);
                RefreshGrid();
            }
        }

        private void FilterByCategory(string category)
        {
            // التحقق من وجود بيانات لتجنب أخطاء LINQ
            if (DataStorage.AllExpenses == null) return;

            var filtered = (category == "الكل") 
                ? DataStorage.AllExpenses 
                : DataStorage.AllExpenses.Where(x => x.CategoryName == category).ToList();

            UpdateGridDataSource(filtered);
        }

        // دالة موحدة لتحديث مصدر البيانات تمنع الـ Flickering وتحدث الإحصائيات
        private void UpdateGridDataSource(object source)
        {
            dgvExpenses.DataSource = null;
            dgvExpenses.DataSource = source;
            UpdateStatistics();
        }

        private void RefreshGrid()
        {
            // تحديث الجدول بناءً على البحث الحالي أو الفلتر النشط
            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
                txtSearch_TextChanged(null, null);
            else
                UpdateGridDataSource(DataStorage.AllExpenses);
        }

        private void UpdateStatistics()
        {
            // 1. الحصول على البيانات المعروضة حالياً مع حماية ضد الـ Null
            var currentData = dgvExpenses.DataSource as List<Expense> ?? new List<Expense>();

            // 2. حساب إجمالي المصروفات الكلي
            decimal totalAll = currentData.Sum(x => x.Amount);

            // 3. حساب إجمالي مصروفات الشهر الحالي فقط
            DateTime today = DateTime.Now;
            decimal monthlyTotal = currentData
                .Where(x => x.ExpenseDate.Year == today.Year && x.ExpenseDate.Month == today.Month)
                .Sum(x => x.Amount);

            // 4. تحديث الكروت بالقيم الجديدة
            advancedStatusCard4.ValueText = totalAll.ToString("N0") + " د.ل"; // الإجمالي الكلي
            advancedStatusCard3.ValueText = monthlyTotal.ToString("N0") + " د.ل"; // إجمالي الشهر الحالي
            advancedStatusCard1.ValueText = currentData.Count.ToString(); // عدد العمليات
        }

        // دالة مساعدة لضبط حالة أزرار الفلترة
        private void SetFilterButtonsState(Control activeBtn)
        {
            var buttons = new[] { btnFilterAll, btnFilterElectricity, btnFilterMaintenance, btnFilterSalaries };
            foreach (var btn in buttons) 
                if (btn != null) btn.Checked = (btn == activeBtn);
        }

        private void btnFilterAll_Click_1(object sender, EventArgs e)
        {
            SetFilterButtonsState(btnFilterAll);
            FilterByCategory("الكل");
        }

        private void btnFilterMaintenance_Click(object sender, EventArgs e)
        {
            SetFilterButtonsState(btnFilterMaintenance);
            FilterByCategory("صيانة الملاعب");
        }

        private void btnFilterElectricity_Click(object sender, EventArgs e)
        {
            SetFilterButtonsState(btnFilterElectricity);
            FilterByCategory("كهرباء");
        }

        private void btnFilterSalaries_Click(object sender, EventArgs e)
        {
            SetFilterButtonsState(btnFilterSalaries);
            FilterByCategory("رواتب الموظفين");
        }

        private void ExpensesForm_Load(object sender, EventArgs e)
        {
            DataStorage.SeedExpenseData();
            RefreshGrid();
           
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            using (AddExpens frm = new AddExpens())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    RefreshGrid();
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (DataStorage.AllExpenses == null) return;

            string searchText = txtSearch.Text.Trim().ToLower();

            // 1. تحديد التصنيف المختار حالياً بناءً على حالة الأزرار (Checked)
            string currentCategory = "الكل";
            if (btnFilterMaintenance.Checked) currentCategory = "صيانة الملاعب";
            else if (btnFilterElectricity.Checked) currentCategory = "كهرباء";
            else if (btnFilterSalaries.Checked) currentCategory = "رواتب الموظفين";

            // 2. تطبيق الفلترة المزدوجة (التصنيف + نص البحث)
            var filtered = DataStorage.AllExpenses.Where(x =>
                (currentCategory == "الكل" || x.CategoryName == currentCategory) && // شرط التصنيف
                ((x.Description?.ToLower() ?? "").Contains(searchText) ||           // شرط نص البحث في الوصف
                 (x.CategoryName?.ToLower() ?? "").Contains(searchText))            // شرط نص البحث في الفئة
            ).ToList();

            UpdateGridDataSource(filtered);
        }

    }
}