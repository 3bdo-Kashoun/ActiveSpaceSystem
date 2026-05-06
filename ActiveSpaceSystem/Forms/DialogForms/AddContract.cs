using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ActiveSpace.Models;
using ActiveSpaceSystem.Data;
using ActiveSpaceSystem.Models.enums;

namespace ActiveSpaceSystem.Forms.DialogForms
{

    public partial class AddContract : Form
    {





        public AddContract()
        {
            InitializeComponent();
            LoadInitialData();
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        
           
        {
            string customerName = txtCustomerName.Texts.Trim();

            // البحث عن العميل
            var customer = DataStorage.CustomersList
                .FirstOrDefault(c => c.FullName.Equals(customerName, StringComparison.OrdinalIgnoreCase));

            // إذا لم يوجد العميل، نقوم بإنشائه فوراً
            if (customer == null)
            {
                customer = new Customer
                {
                    CustomerID = DataStorage.CustomersList.Count + 1,
                    FullName = customerName,
                    Phone = txtPhone.Texts // استخدام رقم الهاتف من الواجهة
                };
                DataStorage.CustomersList.Add(customer);
            }

            // إكمال عملية إنشاء العقد باستخدام العميل (القديم أو الجديد)
            MonthlyContract newContract = new MonthlyContract
            {
                ContractID = DataStorage.ContractsList.Count + 1,
                CustomerID = customer.CustomerID,
                CourtID = (int)cmbCourts.SelectedValue,
                DayOfWeek = ((DayOfWeek)cmbDays.SelectedValue).ToString(),
                StartDate = dtpStartDate.Value.Date,
                EndDate = dtpEndDate.Value.Date,
                FixedStartTime = dtpStartTime.Value.TimeOfDay,
                FixedEndTime = dtpEndTime.Value.TimeOfDay,
                PricePerHour = double.TryParse(txtPricePerHour.Text, out double price) ? price : 0,
                Status = MonthlyContractStatus.Active
            };

            newContract.GenerateBookings();

            if (IsPeriodAvailable(newContract))
            {
                DataStorage.ContractsList.Add(newContract);
                DataStorage.BookingsList.AddRange(newContract.Bookings);
                MessageBox.Show("تمت إضافة العميل الجديد وحفظ العقد بنجاح!");
                // داخل كود زر الحفظ بعد نجاح عملية الإضافة لـ DataStorage
                this.DialogResult = DialogResult.OK; // هذه هي الإشارة للواجهة الرئيسية
                this.Close();
             
            }
         
        }
        

        private void AddContract_Load(object sender, EventArgs e)
        {

        }

        private void LoadInitialData()
        {
            



            //  تعبئة قائمة الملاعب
            cmbCourts.DataSource = null;
            cmbCourts.DataSource = DataStorage.CourtsList;
            cmbCourts.DisplayMember = "CourtName";
            cmbCourts.ValueMember = "CourtID";


            //  تعبئة قائمة انواع الملاعب
            cmbCourtType.DataSource = null;
            cmbCourtType.DataSource = DataStorage.CourtTypesList;
            cmbCourtType.DisplayMember = "TypeName";
            cmbCourtType.ValueMember = "TypeID";

            // في Form_Load
            cmbDays.DataSource = new BindingSource(DataStorage.DaysMap, null);
            cmbDays.DisplayMember = "Key";   // يظهر للمستخدم: الأحد، الاثنين...
            cmbDays.ValueMember = "Value";   // القيمة البرمجية: Sunday, Monday...
            // جعل القوائم تبدأ بدون اختيار 
            cmbCourts.SelectedIndex = -1;
            cmbCourtType.SelectedIndex = -1;
            cmbDays.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
   
            this.DialogResult = DialogResult.Cancel;
            this.Close();
         
        }

        private void cmbCourtType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCourtType.SelectedValue != null && cmbCourtType.SelectedValue is int typeId)
            {
                // 2. فلترة قائمة الملاعب من المخزن بناءً على الـ TypeID المختار
                var filteredCourts = DataStorage.CourtsList
                    .Where(c => c.TypeID == typeId)
                    .ToList();

                // 3. تحديث قائمة الملاعب
                cmbCourts.DataSource = null; // تنظيف القائمة أولاً
                cmbCourts.DataSource = filteredCourts;
                cmbCourts.DisplayMember = "CourtName";
                cmbCourts.ValueMember = "CourtID";

                // اختيار أول ملعب تلقائياً أو تركه فارغاً
                cmbCourts.SelectedIndex = -1;
            }
        }

        private int CalculateOccurrences()
        {
            DateTime start = dtpStartDate.Value.Date;
            DateTime end = dtpEndDate.Value.Date;

            // جلب اليوم كـ Enum مباشرة بفضل الـ ValueMember
            if (cmbDays.SelectedValue is DayOfWeek selectedDay)
            {
                if (start > end) return 0;

                int count = 0;
                for (DateTime date = start; date <= end; date = date.AddDays(1))
                {
                    if (date.DayOfWeek == selectedDay)
                    {
                        count++;
                    }
                }
                return count;
            }
            return 0;
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {

            int Hours = CalculateOccurrences();
                labelHours.Text = $"عدد الحصص: {Hours}";
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            int Hours = CalculateOccurrences();
            labelHours.Text = $"عدد الحصص: {Hours}";
        }

        private void cmbDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Hours = CalculateOccurrences();
            labelHours.Text = $"عدد الحصص: {Hours}";
        }


        private bool IsPeriodAvailable(MonthlyContract contract)
        {
            // فحص كل حجز مولد من العقد الجديد مقابل الحجوزات الموجودة فعلياً
            foreach (var newBooking in contract.Bookings)
            {
                bool hasConflict = DataStorage.BookingsList.Any(old =>
                    old.CourtID == contract.CourtID &&
                    old.BookingDate.Date == newBooking.BookingDate.Date &&
                    old.Status != BookingStatus.Completed &&
                    ((newBooking.StartTime >= old.StartTime && newBooking.StartTime < old.EndTime) ||
                     (newBooking.EndTime > old.StartTime && newBooking.EndTime <= old.EndTime)));

                if (hasConflict) return false;
            }
            return true;
        }
    }



}
