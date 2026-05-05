using ActiveSpace.Models;
using ActiveSpaceSystem.CustomItems;
using ActiveSpaceSystem.Data;
using ActiveSpaceSystem.Models.enums;
using ActiveSpaceSystem.Helpers; // استدعاء فضاء أسماء المساعدات الجديد
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
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

        public AddBookingForm()
        {
            InitializeComponent();
        }

        private void AddBookingForm_Load(object sender, EventArgs e)
        {
            customer = null;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));

            LoadCourtTypes();
            LoadCourts();

            cmbCourtType.SelectedIndex = -1;
            roundedButton1.Click += roundedButton1_Click;
        }

        private void LoadCourtTypes()
        {
            cmbCourtType.DataSource = null;
            cmbCourtType.Items.Clear();

            cmbCourtType.DisplayMember = "TypeName";
            cmbCourtType.ValueMember = "TypeID";
            cmbCourtType.DataSource = DataStorage.CourtTypesList;
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
            if (!ValidateAllInputs(out double totalAmount, out double deposit))
            {
                return;
            }

            Court selectedCourt = (Court)cmbCourt.SelectedItem;
            DateTime bookingDate = dtpBookingDate.Value.Date;
            TimeSpan startTime = dtpStartTime.Value.TimeOfDay;
            TimeSpan endTime = dtpEndTime.Value.TimeOfDay;

            // استخدام كلاس الـ Helper للتحقق من حجز الساعة وتداخل الأوقات
            if (BookingFormHelper.IsCourtReserved(selectedCourt, bookingDate, startTime, endTime, out string reserveWarning))
            {
                ShowWarning(reserveWarning);
                return;
            }

            // التحقق المالي النهائي
            if (!BookingFormHelper.TryValidateFinancials(totalAmount, deposit, out string financialWarning))
            {
                ShowWarning(financialWarning);
                return;
            }

            try
            {
                SaveNewBooking(totalAmount, deposit);

                ShowInfo("تم تسجيل الحجز بنجاح ومزامنته مع الجدول الفعلي.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                ShowError("حدث خطأ غير متوقع أثناء حفظ بيانات الحجز: " + ex.Message);
            }
        }

        private bool ValidateAllInputs(out double totalAmount, out double deposit)
        {
            totalAmount = 0;
            deposit = 0;

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

            if (cmbCourtType.SelectedValue == null)
            {
                ShowWarning("الرجاء اختيار نوع الملعب أولاً.");
                cmbCourtType.Focus();
                return false;
            }

            if (cmbCourt.SelectedItem == null)
            {
                ShowWarning("الرجاء تحديد ملعب من القائمة.");
                cmbCourt.Focus();
                return false;
            }

            if (!ValidationHelper.IsValidDecimalValue(txtprice.Texts, "سعر الحجز الإجمالي", out totalAmount, out string priceError))
            {
                ShowWarning(priceError);
                txtprice.Focus();
                return false;
            }

            if (!ValidationHelper.IsValidDecimalValue(deposittxt.Texts, "قيمة العربون المدفوع", out deposit, out string depositError))
            {
                ShowWarning(depositError);
                deposittxt.Focus();
                return false;
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

        private void SaveNewBooking(double totalAmount, double deposit)
        {
            Court selectedCourt = (Court)cmbCourt.SelectedItem;
            double remainingDebt = totalAmount - deposit;

            if (customer == null)
            {
                customer = new Customer
                {
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
                BookingID = DataStorage.BookingsList.Count + 1,
                CourtID = selectedCourt.CourtID,
                UserID = 1,
                BookingDate = dtpBookingDate.Value.Date,
                StartTime = dtpStartTime.Value.TimeOfDay,
                EndTime = dtpEndTime.Value.TimeOfDay,
                TotalAmount = totalAmount,
                Deposit = deposit,
                Status = DetermineBookingStatus(totalAmount, deposit),
                Customer = customer,
                Court = selectedCourt
            };

            DataStorage.BookingsList.Add(newBooking);
            AddDepositPayment(newBooking);
        }

        private void AddDepositPayment(Booking booking)
        {
            Payment depositPayment = new Payment
            {
                PaymentID = DataStorage.PaymentList.Count + 1,
                BookingID = booking.BookingID,
                AmountPaid = booking.Deposit,
                Deposit = booking.Deposit,
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
    }
}