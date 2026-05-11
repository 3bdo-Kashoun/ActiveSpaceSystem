using ActiveSpace.Models;
using ActiveSpaceSystem.CustomItems;
using ActiveSpaceSystem.Data;
using ActiveSpaceSystem.Forms.SideForms;
using ActiveSpaceSystem.Forms.Views;
using ActiveSpaceSystem.Helpers;
using ActiveSpaceSystem.Models.enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ActiveSpaceSystem.Forms.DialogForms
{
    public partial class AddBookingForm : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        private Customer customer;
        private BookingViewModel _bookingToEdit;
        private bool _isDataLoadedExternally = false; // متغير للتحقق إذا تم تحميل بيانات من دالة خارجية
        public AddBookingForm()
        {

            InitializeComponent();
            LoadCourtTypes();
            LoadCourts();
            label1.Text = "إضافة حجز جديد";
        }
        public AddBookingForm(BookingViewModel booking) : this()
        {
            _bookingToEdit = booking;
            label1.Text = "تعديل بيانات الحجز"; // تغيير العنوان
            roundedButton1.Text = "تحديث"; // تغيير نص الزر

            // تعبئة الخانات ببيانات الحجز المختار
            FillData();
        }
        private void FillData()
        {
            if (_bookingToEdit == null) return;

            try
            {
                // 1. تعبئة النصوص الأساسية
                txtPhone.Texts = _bookingToEdit.Phone ?? "";
                txtName.Texts = _bookingToEdit.CustomerName ?? "";
                txtprice.Texts = _bookingToEdit.Amount.ToString();
                deposittxt.Visible = false;
                lblDeposit.Visible = false;
                txtName.Enabled = false; // لا نسمح بتعديل الاسم في وضع التعديل، لأنه مرتبط بالعميل
                txtPhone.Enabled = false;

                // 2. معالجة التاريخ (Date)
                if (DateTime.TryParse(_bookingToEdit.Date, out DateTime bookingDate))
                {
                    dtpBookingDate.Value = bookingDate;
                }

                // 3. معالجة الوقت (Time) 
                // إذا كان الوقت مخزن بصيغة "17:00 - 18:00"
                if (!string.IsNullOrEmpty(_bookingToEdit.Time) && _bookingToEdit.Time.Contains("-"))
                {
                    string[] times = _bookingToEdit.Time.Split('-');
                    if (DateTime.TryParse(times[0].Trim(), out DateTime start)) dtpStartTime.Value = start;
                    if (DateTime.TryParse(times[1].Trim(), out DateTime end)) dtpEndTime.Value = end;
                }

                // 4. معالجة الملعب (ComboBox)
                // إذا كان الكومبو بوكس مربوط بـ List من الملاعب، ابحث عن الملعب بالاسم
                if (_bookingToEdit.Court != null)
                {
                    cmbCourt.SelectedIndex = cmbCourt.FindStringExact(_bookingToEdit.Court);
                    // أو إذا كنت تستخدم الـ Value (ID):
                    // cmbCourt.SelectedValue = _bookingToEdit.CourtID; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تحميل بيانات الحجز: " + ex.Message);
            }
        }
        private bool IsBookingConflict(Court court, DateTime date, TimeSpan start, TimeSpan end, out string message)
        {
            // أولاً: نستخدم الهيلبر للتحقق العام (الماضي، ساعات العمل، والتداخل مع القائمة)
            // ملاحظة: الفانكشن IsCourtReserved في الهيلبر تتحقق من كل شيء
            bool reserved = BookingFormHelper.IsCourtReserved(court, date, start, end, out message);

            if (reserved)
            {
                // إذا كنا في حالة تعديل (_bookingToEdit != null)
                // يجب أن نتأكد: هل التداخل المكتشف هو مع الحجز الذي نقوم بتعديله حالياً؟
                if (_bookingToEdit != null)
                {
                    // نبحث في الداتا ستورج عن الحجوزات المتداخلة "عدا" الحجز الحالي
                    bool conflictWithOthers = DataStorage.BookingsList.Any(b =>
                        b.BookingID != _bookingToEdit.BookingID && // استثناء الحجز الحالي
                        b.CourtID == court.CourtID &&
                        b.BookingDate.Date == date.Date &&
                        start < b.EndTime &&
                        end > b.StartTime
                    );

                    if (!conflictWithOthers)
                    {
                        // إذا كان التداخل فقط مع نفسه، نعتبره متاحاً ونصفر الرسالة
                        message = string.Empty;
                        return false;
                    }
                }
                return true; // تداخل حقيقي
            }

            return false; // لا يوجد تداخل
        }

        private void AddBookingForm_Load(object sender, EventArgs e)
        {
            customer = null;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));

            // التعديل هنا: نتحقق إذا كان الفورم في وضع التعديل أو تم تحميل بيانات خارجياً
            if (_bookingToEdit == null && !_isDataLoadedExternally)
            {
                // فقط إذا كان حجز جديد تماماً ولم تأتِ بيانات من loadCourtData
                DateTime nextHour = DateTime.Now.AddHours(1);
                DateTime startTime = new DateTime(nextHour.Year, nextHour.Month, nextHour.Day, nextHour.Hour, 0, 0);
                DateTime endTime = startTime.AddHours(1);

                dtpStartTime.Value = startTime;
                dtpEndTime.Value = endTime;
            }

            roundedButton1.Click += roundedButton1_Click;
        }

        private void LoadCourtTypes()
        {
            cmbCourtType.DataSource = null;
            cmbCourtType.Items.Clear();

            cmbCourtType.DisplayMember = "TypeName";
            cmbCourtType.ValueMember = "TypeName";
            cmbCourtType.DataSource = DataStorage.CourtTypesList;
            _isDataLoadedExternally = true;
        }
        public void loadCourtData(string courtName, string TypeName, DateTime date, DateTime start, DateTime End)
        {
            cmbCourt.SelectedValue = courtName;
            cmbCourtType.SelectedValue = TypeName;
            dtpBookingDate.Value = date;
            dtpStartTime.Value = start;
            dtpEndTime.Value = End;
        }

        private void LoadCourts()
        {
            cmbCourt.DataSource = null;
            cmbCourt.Items.Clear();

            cmbCourt.DisplayMember = "CourtName";
            cmbCourt.ValueMember = "CourtName";

            if (cmbCourtType.SelectedIndex == -1)
            {
                cmbCourt.DataSource = DataStorage.CourtsList;
            }
            else
            {
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
            Color borderColor = Color.FromArgb(224, 224, 224);
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, borderColor, ButtonBorderStyle.Solid);
        }

        private void cmbCourtType_SelectedIndexChanged(object sender, EventArgs e)
        {
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

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            if (this.ActiveControl == btnCancel || this.ActiveControl == btnExit)
            {
                return;
            }

            var focusedControl = FindFocusedControl(this);
            if (focusedControl == btnCancel || focusedControl == btnExit)
            {
                return;
            }

            ValidateAndCheckCustomer();
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                if (ValidateAndCheckCustomer())
                {
                    txtName.Focus();
                }
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool ValidateAndCheckCustomer()
        {
            string phoneText = txtPhone.Texts.Trim();

            if (!ValidationHelper.IsValidPhoneNumber(phoneText, out string errorMessage))
            {
                ShowWarning(errorMessage);
                txtName.Texts = "";

                this.BeginInvoke(new Action(() => txtPhone.Focus()));
                return false;
            }

            customer = DataStorage.CustomersList.FirstOrDefault(c => c.Phone == phoneText);

            if (customer != null)
            {

                txtName.Texts = customer.FullName;
                txtName.Enabled = false;
            }
            else
            {
                txtName.Texts = "";
                txtName.Enabled = true;
            }

            return true;
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            // 1. التحقق من صحة المدخلات وتعبئة المتغيرات
            if (!ValidateAllInputs(out double totalAmount, out double deposit)) return;

            Court selectedCourt = (Court)cmbCourt.SelectedItem;
            DateTime bookingDate = dtpBookingDate.Value.Date;
            TimeSpan startTime = new TimeSpan(dtpStartTime.Value.Hour, dtpStartTime.Value.Minute, 0);
            TimeSpan endTime = new TimeSpan(dtpEndTime.Value.Hour, dtpEndTime.Value.Minute, 0);

            // 2. التحقق من تضارب المواعيد (وهي الإضافة التي طلبتها)
            if (IsBookingConflict(selectedCourt, bookingDate, startTime, endTime, out string conflictMessage))
            {
                ShowWarning(conflictMessage);
                return;
            }

            // 3. التحقق من المنطق المالي
            if (!BookingFormHelper.TryValidateFinancials(totalAmount, deposit, out string financialWarning))
            {
                ShowWarning(financialWarning);
                return;
            }

            try
            {
                if (_bookingToEdit == null)
                {
                    SaveNewBooking(totalAmount, deposit, startTime, endTime);
                    ShowInfo("تم تسجيل الحجز بنجاح.");
                }
                else
                {
                    UpdateExistingBooking(totalAmount, deposit, startTime, endTime);
                    ShowInfo("تم تحديث بيانات الحجز بنجاح.");
                }

                // تحديث الواجهات الخارجية
                Application.OpenForms.OfType<ManageBooking>().FirstOrDefault()?.LoadData();
                Application.OpenForms.OfType<MangeCustomers>().FirstOrDefault()?.LoadData();
                Application.OpenForms.OfType<PaymentForm>().FirstOrDefault()?.LoadData();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                ShowError("حدث خطأ أثناء الحفظ: " + ex.Message);
            }
        }
        private void UpdateExistingBooking(double totalAmount, double deposit, TimeSpan start, TimeSpan end)
        {
            // البحث عن الحجز الأصلي في الذاكرة باستخدام الـ ID
            var original = DataStorage.BookingsList.FirstOrDefault(b => b.BookingID == _bookingToEdit.BookingID);

            if (original != null)
            {
                // تحديث البيانات الأساسية
                original.Customer.FullName = txtName.Texts;
                original.Customer.Phone = txtPhone.Texts;
                original.Court = (Court)cmbCourt.SelectedItem;
                original.BookingDate = dtpBookingDate.Value.Date;
                original.StartTime = start;
                original.EndTime = end;
                original.TotalAmount = totalAmount;
                original.Deposit = deposit;
                original.CourtID = ((Court)cmbCourt.SelectedItem).CourtID;
                original.CustomerID = original.Customer.CustomerID;
                original.Customer.TotalDebt += (totalAmount - deposit) - (original.TotalAmount - original.Deposit); // تحديث الدين بناءً على الفرق بين القديم والجديد


                // تحديث الحالة المالية (مدفوع جزئي، مؤكد، إلخ) بناءً على المبلغ
                original.Status = (deposit >= totalAmount) ? BookingStatus.Completed : BookingStatus.Confirmed;
                var customerInStorage = DataStorage.CustomersList.FirstOrDefault(c => c.CustomerID == original.Customer.CustomerID);
                if (customerInStorage != null) { 
                    customerInStorage.TotalDebt = original.Customer.TotalDebt; // تحديث الدين في قائمة العملاء

                    NotifyMangeCustomersUpdate();

                }
            }
        }
        public void NotifyMangeCustomersUpdate()
        {
            // إعادة تحميل البيانات لتحديث العدادات
            var form = Application.OpenForms.OfType<MangeCustomers>().FirstOrDefault();
            if (form != null)
            {
                form.LoadData();
            }

        }

        private bool ValidateAllInputs(out double totalAmount, out double deposit)
        {
            totalAmount = 0;
            deposit = 0;

            // التحقق من الهاتف والاسم (كما هي)
            if (!ValidationHelper.IsValidPhoneNumber(txtPhone.Texts, out string phoneError))
            {
                ShowWarning(phoneError);
                txtPhone.Focus();
                return false;
            }

            if (!ValidationHelper.IsValidCustomerName(txtName.Texts, out string nameError))
            {
                ShowWarning(nameError);
                txtName.Focus();
                return false;
            }

            // التحقق من نوع الملعب والملعب (كما هي)
            if (cmbCourtType.SelectedValue == null) { /* ... تنبيه ... */ return false; }
            if (cmbCourt.SelectedItem == null) { /* ... تنبيه ... */ return false; }

            // 1. التحقق من السعر الإجمالي
            if (!ValidationHelper.IsValidDecimalValue(txtprice.Texts, "سعر الحجز الإجمالي", out totalAmount, out string priceError))
            {
                ShowWarning(priceError);
                txtprice.Focus();
                return false;
            }

            // 2. التعديل هنا: التحقق من العربون فقط إذا لم نكن في وضع التعديل
            if (_bookingToEdit == null)
            {
                if (!ValidationHelper.IsValidDecimalValue(deposittxt.Texts, "قيمة العربون المدفوع", out deposit, out string depositError))
                {
                    ShowWarning(depositError);
                    deposittxt.Focus();
                    return false;
                }
            }
            else
            {


                var original = DataStorage.BookingsList.FirstOrDefault(b => b.BookingID == _bookingToEdit.BookingID);
                deposit = original?.Deposit ?? 0;

            }

            return true;
        }

        private BookingStatus DetermineBookingStatus(double totalAmount, double deposit)
        {
            if (Math.Abs(deposit - totalAmount) < 0.001)
            {
                return BookingStatus.Completed;
            }

            return BookingStatus.Confirmed;
        }

        private void SaveNewBooking(double totalAmount, double deposit, TimeSpan cleanStart, TimeSpan cleanEnd)
        {
            Court selectedCourt = (Court)cmbCourt.SelectedItem;
            double remainingDebt = totalAmount - deposit;

            if (customer == null)
            {
                customer = new Customer
                {
                    CustomerID = DataStorage.CustomersList.Max(c=>c.CustomerID)+1,
                    FullName = txtName.Texts.Trim(),
                    Phone = txtPhone.Texts.Trim(),
                    TotalDebt = remainingDebt
                };
                DataStorage.CustomersList.Add(customer);
            }
            else
            {
                customer.TotalDebt += remainingDebt;
            }

            Booking newBooking = new Booking
            {
                BookingID = DataStorage.BookingsList.Max(c=>c.BookingID)+1,
                CourtID = selectedCourt.CourtID,
                UserID = 1,
                BookingDate = dtpBookingDate.Value.Date,
                StartTime = cleanStart, // تخزين وقت البداية بدون ثواني عشوائية
                EndTime = cleanEnd,     // تخزين وقت النهاية بدون ثواني عشوائية
                TotalAmount = totalAmount,
                Deposit = deposit,
                Status = DetermineBookingStatus(totalAmount, deposit),
                Customer = customer,
                Court = selectedCourt,
                CustomerID=customer.CustomerID
            };

            DataStorage.BookingsList.Add(newBooking);
            AddDepositPayment(newBooking);
        }

        private void AddDepositPayment(Booking booking)
        {
            Payment depositPayment = new Payment
            {
                PaymentID = DataStorage.PaymentList.Max(p=>p.PaymentID) +1,
                BookingID = booking.BookingID,
                AmountPaid = booking.Deposit,

                PaidAt = DateTime.Now,
                Booking = booking
            };

            DataStorage.PaymentList.Add(depositPayment);
        }

        private Control FindFocusedControl(Control control)
        {
            var container = control as IContainerControl;
            while (container != null && container.ActiveControl != null)
            {
                control = container.ActiveControl;
                container = control as IContainerControl;
            }
            return control;
        }

        private void ShowWarning(string message)
        {
            MessageBox.Show(message, "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ShowInfo(string message)
        {
            MessageBox.Show(message, "نجاح العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "خطأ في النظام", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void roundedButton1_Click_1(object sender, EventArgs e)
        {

        }
    }
}