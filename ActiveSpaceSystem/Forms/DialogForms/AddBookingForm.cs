using ActiveSpace.Models;
using ActiveSpaceSystem.Data; // ضروري لاستدعاء مكتبات الويندوز
using ActiveSpaceSystem.Models.enums;
using System;
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
namespace ActiveSpaceSystem.Forms.DialogForms
{
    public partial class AddBookingForm : Form
    {
        // استدعاء دالة من الويندوز لعمل الأركان الدائرية
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
    (
        int nLeftRect,     // إحداثيات الزاوية اليسرى
        int nTopRect,      // إحداثيات الزاوية العلوية
        int nRightRect,    // إحداثيات الزاوية اليمنى السفلى
        int nBottomRect,   // إحداثيات الزاوية اليمنى السفلى
        int nWidthEllipse, // عرض الانحناء (كلما زاد زاد الدوران)
        int nHeightEllipse // طول الانحناء
    );
        public AddBookingForm()
        {
            InitializeComponent();

        }
        private void AddBookingForm_Load(object sender, EventArgs e)
        {
            // هنا نضع كود الحواف الدائرية الذي كتبناه سابقاً
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            // ربط الكومبو بوكس بقائمة الأنواع (قدم، سلة، بادل)
            cmbCourtType.DataSource = DataStorage.CourtTypesList.ToList();
            cmbCourtType.DisplayMember = "TypeName";
            cmbCourtType.ValueMember = "TypeID";

            // اجعل الكومبو يبدأ فارغاً لكي يجبر المستخدم على الاختيار
            cmbCourtType.SelectedIndex = -1;

        }
        private void AddBookingForm_Paint(object sender, PaintEventArgs e)
        {
            // رسم إطار خارجي رمادي فاتح جداً
            Color borderColor = Color.FromArgb(224, 224, 224);
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, borderColor, ButtonBorderStyle.Solid);
        }

   
        

        

        private void dtp_ValueChanged(object sender, EventArgs e)
        {

        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            // 1. التحقق من الحقول
            if (string.IsNullOrEmpty(txtName.Texts) || string.IsNullOrEmpty(txtPhone.Texts) || cmbCourtType.SelectedValue == null)
            {
                MessageBox.Show("الرجاء ملء جميع الحقول واختيار الملعب", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int selectedCourtId = (int)cmbCourtType.SelectedValue;

                // 2. إنشاء كائن الحجز
                Booking newBooking = new Booking
                {
                    BookingID = DataStorage.BookingsList.Count + 1,
                    CourtID = selectedCourtId,
                    UserID = 1,
                    BookingDate = dtpBookingDate.Value.Date,
                    StartTime = dtpStartTime.Value.TimeOfDay,
                    EndTime = dtpEndTime.Value.TimeOfDay,
                    TotalAmount = double.TryParse(txtprice.Texts, out double total) ? total : 0,
                    Deposit = double.TryParse(deposittxt.Texts, out double dep) ? dep : 0,
                    Status = BookingStatus.Confirmed, // ضروري جداً للعرض في الجدول

                    // 3. ربط البيانات للعرض
                    // إنشاء كائن عميل مؤقت لكي يظهر الاسم في الجدول فوراً
                    Customer = new Customer
                    {
                        FullName = txtName.Texts,
                        Phone = txtPhone.Texts
                    },
                    Court = DataStorage.CourtsList.FirstOrDefault(c => c.CourtID == selectedCourtId)
                };

                // 4. الإضافة للقائمة
                DataStorage.BookingsList.Add(newBooking);

                MessageBox.Show("تم تسجيل الحجز بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
