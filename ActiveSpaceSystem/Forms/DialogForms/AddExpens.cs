using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ActiveSpaceSystem.Data;
using ActiveSpaceSystem.Models;

namespace ActiveSpaceSystem.Forms.DialogForms
{
    public partial class AddExpens : Form
    {
        private readonly Expense _targetExpense; // readonly لضمان عدم تغيير المرجع
        private readonly bool _isEditMode = false;

        // الكونستركتور العادي (للإضافة)
        public AddExpens()
        {
            InitializeComponent();
            _isEditMode = false;
            this.Text = "إضافة مصروف جديد";
            btSave.Text = "حفظ";
        }

        // كونستركتور التعديل
        public AddExpens(Expense expense) : this()
        {
            // الحماية في حال تم تمرير كائن فارغ بالخطأ
            if (expense == null) return;

            _targetExpense = expense;
            _isEditMode = true;
            this.Text = "تعديل مصروف";
            btSave.Text = "تحديث";

            // تعبئة البيانات بأمان
            FillData(expense);
        }

        private void FillData(Expense expense)
        {
            txtAmount.Texts = expense.Amount.ToString("0.##"); // تنسيق الرقم بدون أصفار زائدة
            txtDescription.Texts = expense.Description ?? "";
            dtpDate.Value = expense.ExpenseDate > dtpDate.MinDate ? expense.ExpenseDate : DateTime.Now;

            // تأكد من تعبئة الكومبوبوكس أولاً قبل اختيار القيمة
            if (cmbCategory.Items.Count > 0)
                cmbCategory.Text = expense.ExpenseType?.ExpenseName ?? "";
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            // 1. التحقق من صحة المدخلات (Validation) - أهم خطوة لمنع الـ Crash
            if (!ValidateInput()) return;

            try
            {
                decimal amount = decimal.Parse(txtAmount.Texts.Trim());
                string description = txtDescription.Texts.Trim();
                string category = cmbCategory.Text;
                DateTime date = dtpDate.Value;

                if (_isEditMode && _targetExpense != null)
                {
                    // تحديث بيانات الكائن الأصلي (بالمرجع)
                    _targetExpense.Amount = amount;
                    _targetExpense.Description = description;
                    _targetExpense.ExpenseDate = date;

                    // تأكد من تهيئة الكائن الداخلي إذا كان null
                    if (_targetExpense.ExpenseType == null) _targetExpense.ExpenseType = new ExpenseType();
                    _targetExpense.ExpenseType.ExpenseName = category;
                }
                else
                {
                    // إضافة مصروف جديد
                    var newExpense = new Expense
                    {
                        Amount = amount,
                        Description = description,
                        ExpenseDate = date,
                        ExpenseType = new ExpenseType { ExpenseName = category }
                    };

                    if (DataStorage.AllExpenses == null) DataStorage.AllExpenses = new List<Expense>();
                    DataStorage.AllExpenses.Add(newExpense);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء حفظ البيانات: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            // التأكد من أن المبلغ رقم صحيح وليس نصاً أو فارغاً
            if (string.IsNullOrWhiteSpace(txtAmount.Texts) || !decimal.TryParse(txtAmount.Texts, out _))
            {
                MessageBox.Show("يرجى إدخال مبلغ صحيح (أرقام فقط)", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAmount.Focus();
                return false;
            }

            if (cmbCategory.SelectedIndex == -1 && string.IsNullOrWhiteSpace(cmbCategory.Text))
            {
                MessageBox.Show("يرجى اختيار فئة المصروف", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCategory.Focus();
                return false;
            }

            return true;
        }

        private void AddExpens_Load(object sender, EventArgs e)
        {
            try
            {
                // تعبئة الفئات
                var types = ExpenseType.GetDefaultTypes();
                if (types != null)
                {
                    cmbCategory.DataSource = types;
                    cmbCategory.DisplayMember = "ExpenseName";
                    cmbCategory.ValueMember = "ExpenseName";
                }

                // في حالة التعديل، نعيد ضبط النص بعد تحميل الـ DataSource
                if (_isEditMode && _targetExpense != null)
                {
                    cmbCategory.Text = _targetExpense.ExpenseType?.ExpenseName ?? "";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("خطأ في تحميل الفئات: " + ex.Message);
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // ميثود مكررة في كودك السابق تم دمجها
        private void button1_Click(object sender, EventArgs e) => btCancel_Click(sender, e);
    }
}