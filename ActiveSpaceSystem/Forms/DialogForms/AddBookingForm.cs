using ActiveSpace.Models;
using ActiveSpaceSystem.CustomItems;
using ActiveSpaceSystem.Data;
using ActiveSpaceSystem.Models.enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActiveSpaceSystem.Forms.DialogForms
{
    public partial class AddBookingForm : Form
    {
        // استدعاء دالة من الويندوز لعمل الأركان الدائرية للفورم نفسه
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // إحداثيات الزاوية اليسرى
            int nTopRect,      // إحداثيات الزاوية العلوية
            int nRightRect,    // إحداثيات الزاوية اليمنى السفلى
            int nBottomRect,   // إحداثيات الزاوية اليمنى السفلى
            int nWidthEllipse, // عرض الانحناء
            int nHeightEllipse // طول الانحناء
        );

        public AddBookingForm()
        {
            InitializeComponent();
        }

        private void AddBookingForm_Load(object sender, EventArgs e)
        {
            // تطبيق الحواف الدائرية للفورم الخارجي
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));

            // تحميل أنواع الملاعب والملاعب
            LoadCourtTypes();
            LoadCourts();

            // جعل الاختيار الافتراضي فارغاً لإجبار المستخدم على اختيار نوع ملعب أولاً
            cmbCourtType.SelectedIndex = -1;

            // ربط حدث الضغط على زر حفظ الحجز الأخضر
            roundedButton1.Click += roundedButton1_Click;
        }

        private void LoadCourtTypes()
        {
            cmbCourtType.DataSource = null;
            cmbCourtType.Items.Clear();

            // عرض الاسم برمجياً وتخزين المعرف الفريد للنوع
            cmbCourtType.DisplayMember = "TypeName";
            cmbCourtType.ValueMember = "TypeID";
            cmbCourtType.DataSource = DataStorage.CourtTypesList;
        }

        private void LoadCourts()
        {
            cmbCourt.DataSource = null;
            cmbCourt.Items.Clear();

            // عرض اسم الملعب للمستخدم وتخزينه كقيمة
            cmbCourt.DisplayMember = "CourtName";
            cmbCourt.ValueMember = "CourtName";

            if (cmbCourtType.SelectedIndex == -1)
            {
                cmbCourt.DataSource = DataStorage.CourtsList;
            }
            else
            {
                // التحقق من نوع الـ SelectedValue وتمريره للفلترة بأمان
                if (cmbCourtType.SelectedValue is int selectedTypeId)
                {
                    cmbCourt.DataSource = DataStorage.CourtsList
                        .Where(c => c.TypeID == selectedTypeId)
                        .ToList();
                }
                else
                {
                    string selectedTypeName = cmbCourtType.SelectedValue?.ToString();
                    cmbCourt.DataSource = DataStorage.CourtsList
                        .Where(c => c.Type != null && c.Type.TypeName == selectedTypeName)
                        .ToList();
                }
            }
        }

        private void AddBookingForm_Paint(object sender, PaintEventArgs e)
        {
            // رسم إطار خارجي رمادي فاتح وأنيق حول الفورم بدون حواف حادة
            Color borderColor = Color.FromArgb(224, 224, 224);
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, borderColor, ButtonBorderStyle.Solid);
        }

        private void cmbCourtType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // فلترة قائمة الملاعب فور تغيير نوع الملعب المحدد
            LoadCourts();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // حدث الضغط على زر Enter داخل حقل الهاتف (اختياري)
            if (e.KeyChar == 13)
            {
                e.Handled = true; // منع صوت التنبيه الافتراضي للويندوز
            }
        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            // حدث إضافي للـ DateTimePicker في حال احتجت لتحديث قيمة معينة برمجياً
        }

        // زر حفظ الحجز الأساسي (تم ربطه باسم الأدوات الفعلي في الديزاين roundedButton1)
        private void roundedButton1_Click(object sender, EventArgs e)
        {
            // 1. التحقق من إدخال البيانات المطلوبة
            if (string.IsNullOrEmpty(txtName.Texts) || string.IsNullOrEmpty(txtPhone.Texts) || cmbCourtType.SelectedValue == null || cmbCourt.SelectedItem == null)
            {
                MessageBox.Show("الرجاء ملء جميع الحقول المطلوبة واختيار الملعب المناسب.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // جلب الملعب المختار حالياً من الكومبو بوكس
                Court selectedCourt = (Court)cmbCourt.SelectedItem;

                // 2. إنشاء كائن الحجز وتعبئته بالبيانات من الواجهة
                Booking newBooking = new Booking
                {
                    BookingID = DataStorage.BookingsList.Count + 1,
                    CourtID = selectedCourt.CourtID,
                    UserID = 1, // المعرف الافتراضي للمستخدم الحالي
                    BookingDate = dtpBookingDate.Value.Date,
                    StartTime = dtpStartTime.Value.TimeOfDay,
                    EndTime = dtpEndTime.Value.TimeOfDay,

                    // استخدام أسماء التكست بوكس الفعلية في الديزاين (abdulTextBox1 للمبلغ)
                    TotalAmount = double.TryParse(abdulTextBox1.Texts, out double total) ? total : 0,
                    Deposit = double.TryParse(deposittxt.Texts, out double dep) ? dep : 0,
                    Status = BookingStatus.Confirmed,

                    // ربط كائنات العرض بالكامل لتحديث شاشات الجداول فوراً
                    Customer = new Customer
                    {
                        FullName = txtName.Texts,
                        Phone = txtPhone.Texts
                    },
                    Court = selectedCourt
                };

                // 3. إضافة الحجز الجديد لقائمة الذاكرة المؤقتة
                DataStorage.BookingsList.Add(newBooking);

                MessageBox.Show("تم تسجيل الحجز بنجاح ومزامنته مع الجدول الفعلي.", "نجاح العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ غير متوقع أثناء حفظ بيانات الحجز: " + ex.Message, "خطأ في النظام", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}