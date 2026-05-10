using ActiveSpace.Models;
using ActiveSpaceSystem.Data;
using ActiveSpaceSystem.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ActiveSpaceSystem.Forms.DialogForms
{
    public partial class AddCustomerForm : Form
    {
        private Customer _existingCustomer;
        private bool _isEditMode = false;

        // 1. مشيد الإضافة العادي
        public AddCustomerForm()
        {
            InitializeComponent();
            _isEditMode = false;
        }

        // 2. مشيد التعديل - يستقبل كائن العميل المراد تعديله
        public AddCustomerForm(Customer customer) : this()
        {
            _existingCustomer = customer;
            _isEditMode = true;

            // ملء الحقول بالبيانات الموجودة
            nametxt.Texts = customer.FullName;
            phonetxt.Texts = customer.Phone;

            // تغيير نصوص الواجهة لتناسب وضع التعديل
            lblTitle.Text = "تعديل بيانات العميل"; // تأكد من اسم Label العنوان لديك
            roundedButton2.Text = "حفظ التعديلات";
        }

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {
            // أي عمليات إعداد إضافية عند التحميل
        }

        // زر الحفظ (إضافة أو تعديل)
        private void roundedButton2_Click(object sender, EventArgs e)
        {
            string errorMsg;

            // التحقق من صحة الاسم
            if (!ValidationHelper.IsValidCustomerName(nametxt.Texts, out errorMsg))
            {
                MessageBox.Show(errorMsg, "خطأ في البيانات", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nametxt.Focus();
                return;
            }

            // التحقق من صحة رقم الهاتف
            if (!ValidationHelper.IsValidPhoneNumber(phonetxt.Texts, out errorMsg))
            {
                MessageBox.Show(errorMsg, "خطأ في البيانات", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                phonetxt.Focus();
                return;
            }

            try
            {
                if (_isEditMode)
                {
                    // --- وضع التعديل ---
                    _existingCustomer.FullName = nametxt.Texts.Trim();
                    _existingCustomer.Phone = phonetxt.Texts.Trim();

                    MessageBox.Show("تم تحديث بيانات العميل بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // --- وضع الإضافة ---
                    Customer newCustomer = new Customer
                    {
                        // توليد ID جديد بناءً على أكبر ID موجود + 1 لتجنب التكرار
                        CustomerID = (DataStorage.CustomersList.Any() ? DataStorage.CustomersList.Max(c => c.CustomerID) : 0) + 1,
                        FullName = nametxt.Texts.Trim(),
                        Phone = phonetxt.Texts.Trim(),
                        TotalDebt = 0
                    };

                    DataStorage.CustomersList.Add(newCustomer);
                    MessageBox.Show("تمت إضافة العميل بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ غير متوقع: " + ex.Message, "خطأ برمجي", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                phonetxt.Focus();
            }
        }

        private void phonetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                roundedButton2.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}