using ActiveSpace.Models;
using ActiveSpaceSystem.CustomItems;
using ActiveSpaceSystem.Data;
using ActiveSpaceSystem.Helpers;
using ActiveSpaceSystem.Models.enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ActiveSpaceSystem.Forms.DialogForms
{
    public partial class AddContract : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private Customer _currentCustomer = null;

        public AddContract()
        {
            InitializeComponent();
            LoadInitialData();
        }

        private void AddContract_Load(object sender, EventArgs e)
        {
            _currentCustomer = null;
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        private void LoadInitialData()
        {
            cmbCourtType.DataSource = DataStorage.CourtTypesList.ToList();
            cmbCourtType.DisplayMember = "TypeName";
            cmbCourtType.ValueMember = "TypeID";
            cmbCourtType.SelectedIndex = -1;

            cmbDays.DataSource = new BindingSource(DataStorage.DaysMap, null);
            cmbDays.DisplayMember = "Key";
            cmbDays.ValueMember = "Value";

            cmbCourt.SelectedIndex = -1;
            // 2. ضبط الوقت الافتراضي (Start Time & End Time)
            // الحصول على الساعة الحالية وزيادة ساعة واحدة
            DateTime nextHour = DateTime.Now.AddHours(1);

            // تصفير الدقائق والثواني (مثلاً من 14:35 إلى 15:00)
            DateTime startTime = new DateTime(nextHour.Year, nextHour.Month, nextHour.Day, nextHour.Hour, 0, 0);

            // وقت النهاية يكون بعد وقت البداية بساعة واحدة (مثلاً 16:00)
            DateTime endTime = startTime.AddHours(1);

            // إسناد القيم للـ DateTimePickers
            dtpStartTime.Value = startTime;
            dtpEndTime.Value = endTime;

            // 3. تحديث ملصق عدد الحصص
           
            UpdateOccurrencesLabel();
        }

        #region "التحقق من العميل"
        private void txtPhone_Leave(object sender, EventArgs e)
        {
            if (this.ActiveControl == btnCancel) return;
            ValidateAndCheckCustomer();
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

            _currentCustomer = DataStorage.CustomersList.FirstOrDefault(c => c.Phone == phoneText);

            if (_currentCustomer != null)
            {
                txtName.Texts = _currentCustomer.FullName;
                txtName.Enabled = false;
            }
            else
            {
                txtName.Texts = "";
                txtName.Enabled = true;
            }
            return true;
        }
        #endregion

        private void btSave_Click(object sender, EventArgs e)
        {
            // 1. التحقق من المدخلات والمبالغ
            if (!ValidateAllInputs(out double pricePerHour, out double totalDeposit)) return;

            TimeSpan startTime = new TimeSpan(dtpStartTime.Value.Hour, dtpStartTime.Value.Minute, 0);
            TimeSpan endTime = new TimeSpan(dtpEndTime.Value.Hour, dtpEndTime.Value.Minute, 0);

            if (cmbCourt.SelectedItem == null) { ShowWarning("الرجاء تحديد ملعب."); return; }
            Court selectedCourt = (Court)cmbCourt.SelectedItem;
            DayOfWeek selectedDay = (DayOfWeek)cmbDays.SelectedValue;

            // 2. معالجة بيانات العميل
            HandleCustomerData();

            // 3. إنشاء كائن العقد وتوليد الحصص
            MonthlyContract newContract = new MonthlyContract
            {
                ContractID = DataStorage.ContractsList.Count + 1,
                CustomerID = _currentCustomer.CustomerID,
                CourtID = selectedCourt.CourtID,
                DayOfWeek = selectedDay.ToString(),
                StartDate = dtpBookingDate.Value.Date,
                EndDate = dateTimePicker1.Value.Date,
                FixedStartTime = startTime,
                FixedEndTime = endTime,
                PricePerHour = pricePerHour,
                Status = MonthlyContractStatus.Active
            };

            newContract.GenerateBookings();

            // 4. التحقق من إجمالي العقد مقابل العربون (Double Check)
            if (totalDeposit > newContract.TotalAmount)
            {
                ShowWarning($"قيمة العربون ({totalDeposit}) لا يمكن أن تتجاوز إجمالي العقد ({newContract.TotalAmount})");
                return;
            }

            // 5. التحقق من التداخلات
            if (HasContractConflicts(newContract, selectedCourt, out string conflictMessage))
            {
                ShowWarning(conflictMessage);
                return;
            }

            // 6. الحفظ النهائي
            try
            {
                SaveContractAndBookings(newContract, totalDeposit);
                ShowInfo("تم تسجيل العقد بنجاح.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                ShowError("خطأ أثناء الحفظ: " + ex.Message);
            }
        }

        private bool ValidateAllInputs(out double price, out double deposit)
        {
            price = 0; deposit = 0;

            if (!ValidateAndCheckCustomer()) return false;
            if (cmbDays.SelectedValue == null) { ShowWarning("يرجى اختيار يوم العقد."); return false; }

            if (!ValidationHelper.IsValidDecimalValue(txtPricePerHour.Texts, "سعر الساعة", out price, out string pErr))
            { ShowWarning(pErr); return false; }

            if (!ValidationHelper.IsValidDecimalValue(deposittxt.Texts, "العربون", out deposit, out string dErr))
            { ShowWarning(dErr); return false; }

            if (dtpBookingDate.Value.Date > dateTimePicker1.Value.Date)
            {
                ShowWarning("تاريخ البداية بعد تاريخ النهاية!");
                return false;
            }

            return true;
        }

        private void HandleCustomerData()
        {
            if (_currentCustomer == null)
            {
                _currentCustomer = new Customer
                {
                    CustomerID = DataStorage.CustomersList.Count + 1,
                    FullName = txtName.Texts.Trim(),
                    Phone = txtPhone.Texts.Trim(),
                    TotalDebt = 0
                };
                DataStorage.CustomersList.Add(_currentCustomer);
            }
        }

        private bool HasContractConflicts(MonthlyContract contract, Court court, out string message)
        {
            message = "";
            foreach (var b in contract.Bookings)
            {
                if (BookingFormHelper.IsCourtReserved(court, b.BookingDate, b.StartTime, b.EndTime, out string warn))
                {
                    message = $"تداخل في تاريخ {b.BookingDate.ToShortDateString()}:\n{warn}";
                    return true;
                }
            }
            return false;
        }

        private void SaveContractAndBookings(MonthlyContract contract, double totalDeposit)
        {
            int sessionCount = contract.Bookings.Count;

            if (sessionCount > 0)
            {
                // 1. تحويل المبلغ الكلي لعدد صحيح (في حال كان المدخل فيه كسور)
                int total = (int)totalDeposit;

                // 2. حساب المبلغ الأساسي لكل حصة (بدون كسور)
                int baseDeposit = total / sessionCount;

                // 3. حساب الفكة أو الباقي الذي لم يقبل القسمة المتساوية
                int remainder = total % sessionCount;

                for (int i = 0; i < sessionCount; i++)
                {
                    var b = contract.Bookings[i];

                    // 4. توزيع المبلغ: إذا كان هناك باقي، نزيد 1 على الحصص الأولى حتى ينتهي الباقي
                    double currentSessionDeposit = baseDeposit;
                    if (i < remainder)
                    {
                        currentSessionDeposit += 1;
                    }

                    // إسناد البيانات للحجز
                    b.Deposit = currentSessionDeposit;
                    b.Customer = _currentCustomer;
                    b.CustomerID = _currentCustomer.CustomerID;

                    DataStorage.BookingsList.Add(b);

                    // تسجيل الدفعة المالية (Payment)
                    if (currentSessionDeposit > 0)
                    {
                        DataStorage.PaymentList.Add(new Payment
                        {
                            PaymentID = DataStorage.PaymentList.Count + 1,
                            BookingID = b.BookingID,
                            AmountPaid = currentSessionDeposit,
                            PaidAt = DateTime.Now,
                            Booking = b
                        });
                    }
                }
            }

            // تحديث ديون العميل: (إجمالي العقد - العربون الموزع)
            _currentCustomer.TotalDebt += (contract.TotalAmount - totalDeposit);
            DataStorage.ContractsList.Add(contract);
        }
        #region "تحديث الواجهة"
        private void cmbCourtType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCourtType.SelectedValue is int typeId)
            {
                cmbCourt.DataSource = DataStorage.CourtsList.Where(c => c.TypeID == typeId).ToList();
                cmbCourt.DisplayMember = "CourtName";
                cmbCourt.ValueMember = "CourtID";
            }
        }

        private int CalculateOccurrences()
        {
            DateTime start = dtpBookingDate.Value.Date;
            DateTime end = dateTimePicker1.Value.Date;
            if (cmbDays.SelectedValue is DayOfWeek selectedDay)
            {
                int count = 0;
                for (DateTime date = start; date <= end; date = date.AddDays(1))
                {
                    if (date.DayOfWeek == selectedDay) count++;
                }
                return count;
            }
            return 0;
        }

        private void UpdateOccurrencesLabel() => labelHours.Text = $"عدد الحصص: {CalculateOccurrences()}";
        private void dtpBookingDate_ValueChanged(object sender, EventArgs e) => UpdateOccurrencesLabel();
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) => UpdateOccurrencesLabel();
        private void cmbDays_SelectedIndexChanged(object sender, EventArgs e) => UpdateOccurrencesLabel();
        #endregion

        private void ShowWarning(string m) => MessageBox.Show(m, "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        private void ShowInfo(string m) => MessageBox.Show(m, "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
        private void ShowError(string m) => MessageBox.Show(m, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        private void btnCancel_Click(object sender, EventArgs e) => this.Close();

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}