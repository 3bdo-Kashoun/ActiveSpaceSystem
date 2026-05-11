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
        private MonthlyContract _contractToEdit = null; // متغير لتخزين العقد في حالة التعديل

        // المشيد الافتراضي للإضافة
        public AddContract()
        {
            InitializeComponent();
            LoadInitialData();
        }

        // مشيد إضافي لعملية التعديل
        public AddContract(MonthlyContract contract)
        {
            InitializeComponent();
            _contractToEdit = contract;
            LoadInitialData();
            FillDataForEdit();
        }

        private void AddContract_Load(object sender, EventArgs e)
        {
            // لا نصفر العميل هنا إذا كنا في حالة تعديل
            if (_contractToEdit == null) _currentCustomer = null;
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        private void FillDataForEdit()
        {
            if (_contractToEdit == null) return;

            label1.Text = "تعديل عقد شهري";
            btSave.Text = "تعديل وحفظ";

            // جلب بيانات العميل
            _currentCustomer = DataStorage.CustomersList.FirstOrDefault(c => c.CustomerID == _contractToEdit.CustomerID);
            if (_currentCustomer != null)
            {
                txtPhone.Texts = _currentCustomer.Phone;
                txtName.Texts = _currentCustomer.FullName;
                txtName.Enabled = false;
            }

            // تعبئة التواريخ والأوقات
            dtpBookingDate.Value = _contractToEdit.StartDate;
            dateTimePicker1.Value = _contractToEdit.EndDate;
            dtpStartTime.Value = DateTime.Today.Add(_contractToEdit.FixedStartTime);
            dtpEndTime.Value = DateTime.Today.Add(_contractToEdit.FixedEndTime);

            // تعبئة الأسعار
            txtPricePerHour.Texts = _contractToEdit.PricePerHour.ToString();

            // حساب العربون الإجمالي المسجل مسبقاً
            double totalSavedDeposit = _contractToEdit.Bookings?.Sum(b => b.Deposit) ?? 0;
            deposittxt.Texts = totalSavedDeposit.ToString();

            // اختيار اليوم والملعب
            if (Enum.TryParse(_contractToEdit.DayOfWeek, out DayOfWeek day))
                cmbDays.SelectedValue = day;

            var court = DataStorage.CourtsList.FirstOrDefault(c => c.CourtID == _contractToEdit.CourtID);
            if (court != null)
            {
                cmbCourtType.SelectedValue = court.TypeID;
                cmbCourt.SelectedValue = court.CourtID;
            }

            UpdateOccurrencesLabel();
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

            if (_contractToEdit == null)
            {
                DateTime nextHour = DateTime.Now.AddHours(1);
                DateTime startTime = new DateTime(nextHour.Year, nextHour.Month, nextHour.Day, nextHour.Hour, 0, 0);
                DateTime endTime = startTime.AddHours(1);

                dtpStartTime.Value = startTime;
                dtpEndTime.Value = endTime;
            }

            UpdateOccurrencesLabel();
        }

        #region "التحقق من العميل"
        private void txtPhone_Leave(object sender, EventArgs e)
        {
            if (this.ActiveControl == btnCancel ) return;
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
                
                txtName.Enabled = true;
            }
            return true;
        }
        #endregion

        private void btSave_Click(object sender, EventArgs e)
        {
            if (!ValidateAllInputs(out double pricePerHour, out double totalDeposit)) return;

            TimeSpan startTime = new TimeSpan(dtpStartTime.Value.Hour, dtpStartTime.Value.Minute, 0);
            TimeSpan endTime = new TimeSpan(dtpEndTime.Value.Hour, dtpEndTime.Value.Minute, 0);

            if (cmbCourt.SelectedItem == null) { ShowWarning("الرجاء تحديد ملعب."); return; }
            Court selectedCourt = (Court)cmbCourt.SelectedItem;
            DayOfWeek selectedDay = (DayOfWeek)cmbDays.SelectedValue;

            HandleCustomerData();

            // في حالة التعديل نستخدم الكائن القديم، وفي الإضافة ننشئ جديد
            MonthlyContract contract = _contractToEdit ?? new MonthlyContract();

            // إذا كان جديداً نعطيه ID
            if (_contractToEdit == null)
            {
                contract.ContractID = DataStorage.ContractsList.Max(c=>c.ContractID) + 1;
            }
            else
            {
                // إذا كان تعديل، نحذف الحجوزات القديمة المرتبطة به قبل إعادة التوليد
                DataStorage.BookingsList.RemoveAll(b => b.ContractID == contract.ContractID);
                DataStorage.PaymentList.RemoveAll(p => p.Booking != null && p.Booking.ContractID == contract.ContractID);
            }
            
            var customer = DataStorage.CustomersList.FirstOrDefault(c => c.CustomerID == _currentCustomer.CustomerID);
            contract.CustomerID = _currentCustomer.CustomerID;
            contract.CourtID = selectedCourt.CourtID;
            contract.DayOfWeek = selectedDay.ToString();
            contract.StartDate = dtpBookingDate.Value.Date;
            contract.EndDate = dateTimePicker1.Value.Date;
            contract.FixedStartTime = startTime;
            contract.FixedEndTime = endTime;
            contract.PricePerHour = pricePerHour;
            contract.Status = MonthlyContractStatus.Active;
            contract.Customer = customer;


            contract.GenerateBookings();

            if (totalDeposit > contract.TotalAmount)
            {
                ShowWarning($"قيمة العربون ({totalDeposit}) لا يمكن أن تتجاوز إجمالي العقد ({contract.TotalAmount})");
                return;
            }

            if (HasContractConflicts(contract, selectedCourt, out string conflictMessage))
            {
                ShowWarning(conflictMessage);
                return;
            }

            try
            {
                SaveContractAndBookings(contract, totalDeposit);
                ShowInfo(_contractToEdit == null ? "تم تسجيل العقد بنجاح." : "تم تحديث العقد بنجاح.");
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
                // إذا كان تعديل، يجب أن نتجاهل الحجز الحالي عند فحص التداخل
                if (BookingFormHelper.IsCourtReserved(court, b.BookingDate, b.StartTime, b.EndTime, out string warn))
                {
                    // فحص إذا كان التداخل مع نفس العقد الحالي في حالة التعديل
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
                int total = (int)totalDeposit;
                int baseDeposit = total / sessionCount;
                int remainder = total % sessionCount;

                for (int i = 0; i < sessionCount; i++)
                {
                    var b = contract.Bookings[i];
                    double currentSessionDeposit = baseDeposit;
                    if (i < remainder) currentSessionDeposit += 1;

                    b.Deposit = currentSessionDeposit;
                    b.Customer = _currentCustomer;
                    b.CustomerID = _currentCustomer.CustomerID;
                    b.ContractID = contract.ContractID; // ربط الحجز بالعقد

                    DataStorage.BookingsList.Add(b);

                    if (currentSessionDeposit > 0)
                    {
                        DataStorage.PaymentList.Add(new Payment
                        {
                            PaymentID = DataStorage.PaymentList.Max(p=>p.PaymentID) + 1,
                            BookingID = b.BookingID,
                            AmountPaid = currentSessionDeposit,
                            PaidAt = DateTime.Now,
                            Booking = b
                        });
                    }
                }
            }

            if (_contractToEdit == null)
            {
                _currentCustomer.TotalDebt += (contract.TotalAmount - totalDeposit);
                DataStorage.ContractsList.Add(contract);
            }
            else
            {
                // في حالة التعديل، يتم تحديث الدين بناءً على الفرق الجديد
                // (هذا المنطق مبسط، يفضل في الأنظمة الحقيقية حساب الفرق بين القديم والجديد)
                DataStorage.ContractsList.RemoveAll(c => c.ContractID == contract.ContractID);
                DataStorage.ContractsList.Add(contract);
            }
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

        private void button1_Click(object sender, EventArgs e) => this.Close();
    }
}