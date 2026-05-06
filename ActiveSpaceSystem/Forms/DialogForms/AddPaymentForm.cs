using ActiveSpace.Models;
using ActiveSpaceSystem.Data;
using ActiveSpaceSystem.Helpers;
using ActiveSpaceSystem.Models.enums; // تأكد من استيراد الـ Enums لحالة الحجز
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ActiveSpaceSystem.Forms.DialogForms
{
    public partial class AddPaymentForm : Form
    {
        // استيراد دالة تدوير الحواف الخارجية للفورم
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        // دالة تنظيف الذاكرة الخاصة بمقابض الـ GDI لتفادي الـ Memory Leak
        [DllImport("gdi32.dll", EntryPoint = "DeleteObject")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool DeleteObject(IntPtr hObject);

        private IntPtr _formRegionHandle;

        public AddPaymentForm()
        {
            InitializeComponent();
        }

        private void AddPaymentForm_Load(object sender, EventArgs e)
        {
            // تطبيق تدوير الحواف للفورم وحفظ المقبض لتنظيفه لاحقاً
            _formRegionHandle = CreateRoundRectRgn(0, 0, Width, Height, 30, 30);
            this.Region = System.Drawing.Region.FromHrgn(_formRegionHandle);
        }

        private void AddPaymentForm_Paint(object sender, PaintEventArgs e)
        {
            int lineY = 65;
            // استخدام الحدث لرسم الخط الأفقي تحت الـ Header مباشرة
            using (Pen linePen = new Pen(Color.FromArgb(229, 231, 235), 2))
            {
                e.Graphics.DrawLine(linePen, 0, lineY, this.Width, lineY);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // 1. استخراج رقم الحجز بطريقة آمنة تماماً تدعم النصوص والرموز (مثال: B-2026-001)
            string rawBookingValue = bookingInfoCard1.BookingNumberValue;

            // تنظيف النص للحصول على الرقم فقط (إذا كان يحتوي على حروف مثل B- أو رموز)
            string cleanNumbers = new string(rawBookingValue.Where(char.IsDigit).ToArray());

            if (!int.TryParse(cleanNumbers, out int bookingId))
            {
                ShowWarning("رقم الحجز غير صالح أو غير معروف بالنظام.");
                return;
            }

            // 2. البحث عن الحجز داخل قائمة الحجوزات
            var booking = DataStorage.BookingsList.FirstOrDefault(i => i.BookingID == bookingId);
            if (booking == null)
            {
                ShowWarning("عفواً، لم يتم العثور على بيانات هذا الحجز.");
                return;
            }

            // 3. التحقق من صحة القيمة المدفوعة المدخلة من التكست بوكس
            if (!ValidationHelper.IsValidDecimalValue(abdulTextBox1.Texts, "القيمة المدفوعة", out double paid, out string depositError))
            {
                ShowWarning(depositError);
                return;
            }

            // منع إدخال قيم صفرية أو سالبة
            if (paid <= 0)
            {
                ShowWarning("يرجى إدخال قيمة دفع أكبر من الصفر.");
                return;
            }

            // 4. التحقق من أن المدفوع لا يتجاوز الدين المتبقي للحجز
            double remainingAmount = Payment.CalculateRemaining(booking.BookingID);
            if (paid > remainingAmount)
            {
                ShowWarning($"القيمة المدخلة ({paid} د.ل) أكبر من المبلغ المتبقي المطلوب للحجز ({remainingAmount} د.ل).");
                return;
            }

            // 5. إنشاء كائن الدفعة الجديد وإضافته للقائمة
            var payment = new Payment
            {
                PaymentID = DataStorage.PaymentList.Count + 1,
                AmountPaid = paid,
                PaidAt = DateTime.Now,
                BookingID = booking.BookingID,
                Booking = booking
            };
            DataStorage.PaymentList.Add(payment);

            // 6. تحديث ديون الزبون الإجمالية (تلقائياً)
            if (booking.Customer != null)
            {
                booking.Customer.TotalDebt = Math.Max(0, booking.Customer.TotalDebt - paid);
            }

            // 7. تحديث حالة الحجز بناءً على المبلغ المتبقي الجديد
            double currentRemaining = Payment.CalculateRemaining(booking.BookingID);
            if (currentRemaining <= 0)
            {
                booking.Status = BookingStatus.Completed; // الحجز مغطى بالكامل
            }
            else
            {
                booking.Status = BookingStatus.Confirmed; // مازال مدفوع جزئياً
            }

            // نجاح العملية وإغلاق الفورم
            ShowInfo("تمت إضافة الدفعة وتحديث الحالة المالية للحجز بنجاح.");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // تنظيف مقابض الـ GDI المستوردة عند إغلاق الفورم بشكل كامل لمنع تسريب الذاكرة
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            if (_formRegionHandle != IntPtr.Zero)
            {
                DeleteObject(_formRegionHandle);
            }
        }

        private void ShowWarning(string message)
        {
            MessageBox.Show(message, "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ShowInfo(string message)
        {
            MessageBox.Show(message, "نجاح العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // أضف هذه الدالة داخل كلاس AddPaymentForm.cs لتهيئة البيانات
        public void SetBookingData(int bookingId, string remainingAmount)
        {
            // تعيين القيم في الكارد المخصص
            // تذكر: "B-" + رقم الحجز ليظهر بشكل منسق مثل B-1
            bookingInfoCard1.BookingNumberValue = $"B-{bookingId}";
            bookingInfoCard1.RemainingAmountValue = remainingAmount;

            // تصفير مربع نص القيمة المدفوعة ليقوم المستخدم بإدخالها
            abdulTextBox1.Texts = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}