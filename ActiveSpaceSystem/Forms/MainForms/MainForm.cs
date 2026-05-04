using System;
using System.Drawing;
using System.Windows.Forms;
using ActiveSpaceSystem.Forms.SideForms;
using ActiveSpace.Models;

namespace ActiveSpaceSystem.Forms.MainForms
{
    public partial class MainForm : Form
    {
        private Dashboard DashForm = null!;
        private ManageBooking BookingForm = null!;
        private Scheduling ScheduleForm = null!;
        private MonthlyContractForm MonthlyContractForm = null!;
        private MangeCustomers MangeCustomersForm = null!;
        private PaymentForm PaymentForm = null!;
        private ReportsForm ReportsForm = null!;
        private Settings SettingsForm = null!;

        private Button? currentActiveButton = null;

        public MainForm(User user)
        {
            InitializeComponent();
            button1.Click += button1_Click;
            button2.Click += button2_Click;
            button3.Click += button3_Click;
            button4.Click += button4_Click;
            button5.Click += button5_Click;
            button6.Click += button6_Click;
            button7.Click += button7_Click;
            button8.Click += button8_Click;
            LabelUser.Text = user.FullName;
            LabelRole.Text = user.Role == UserRole.Admin ? "مدير" : "موظف";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            lblDate.Text = DateTime.Now.ToString("dddd، dd MMMM yyyy", new System.Globalization.CultureInfo("ar-EG"));

            // تعيين الزر الرئيسي كنشط افتراضياً
            ActivateButton(button3);
            ShowFormInPanel(new Dashboard()); // أو أي شاشة ترغب بها
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dddd، dd MMMM yyyy", new System.Globalization.CultureInfo("ar-EG"));
        }

        // دالة لتغيير لون الأزرار
        private void ActivateButton(Button btn)
        {
            if (currentActiveButton != null)
            {
                currentActiveButton.BackColor = Color.FromArgb(31, 41, 55); // اللون الأصلي للقائمة
                currentActiveButton.ForeColor = Color.White;
            }
            btn.BackColor = Color.FromArgb(46, 204, 113); // اللون الأخضر
            btn.ForeColor = Color.White;
            currentActiveButton = btn;
        }

        // دالة لعرض النموذج داخل panel3
        private void ShowFormInPanel(Form form)
        {
            panel3.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.RightToLeft = RightToLeft.Yes;
            form.RightToLeftLayout = true;
            panel3.Controls.Add(form);
            form.Show();
        }

        // أزرار القائمة:
        private void button3_Click(object sender, EventArgs e)   // الرئيسية
        {
            ActivateButton(button3);
            if (DashForm == null || DashForm.IsDisposed)
            {
                DashForm = new Dashboard();
            }
            ShowFormInPanel(DashForm);
        }

        private void button1_Click(object sender, EventArgs e)   // إدارة الحجوزات
        {
            ActivateButton(button1);
            if (BookingForm == null || BookingForm.IsDisposed)
            {
                BookingForm = new ManageBooking();
            }
            ShowFormInPanel(BookingForm);
        }

        private void button2_Click(object sender, EventArgs e)   // الجدولة
        {
            ActivateButton(button2);
            if (ScheduleForm == null || ScheduleForm.IsDisposed)
            {
                ScheduleForm = new Scheduling();
            }
            ShowFormInPanel(ScheduleForm);
        }

        private void button5_Click(object sender, EventArgs e)   // العقود الشهرية
        {
            ActivateButton(button5);
            if (MonthlyContractForm == null || MonthlyContractForm.IsDisposed)
            {
                MonthlyContractForm = new MonthlyContractForm();
            }
            ShowFormInPanel(MonthlyContractForm);
        }

        private void button4_Click(object sender, EventArgs e)   // المدفوعات
        {
            ActivateButton(button4);
            if (PaymentForm == null || PaymentForm.IsDisposed)
            {
                PaymentForm = new PaymentForm();
            }
            ShowFormInPanel(PaymentForm);
        }

        private void button7_Click(object sender, EventArgs e)   // التقارير
        {
            ActivateButton(button7);
            if (ReportsForm == null || ReportsForm.IsDisposed)
            {
                ReportsForm = new ReportsForm();
            }
            ShowFormInPanel(ReportsForm);
        }

        private void button6_Click(object sender, EventArgs e)   // العملاء
        {
            ActivateButton(button6);
            if (MangeCustomersForm == null || MangeCustomersForm.IsDisposed)
            {
                MangeCustomersForm = new MangeCustomers();
            }
            ShowFormInPanel(MangeCustomersForm);
        }

        private void button8_Click(object sender, EventArgs e)   // الإعدادات
        {
            ActivateButton(button8);
            if (SettingsForm == null || SettingsForm.IsDisposed)
            {
                SettingsForm = new Settings();
            }
            ShowFormInPanel(SettingsForm);
        }


        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {

            if (this.Tag == null)
            {
                Application.Exit();
            }
        }

        

        private void button9_Click_1(object sender, EventArgs e)
        {

            this.Tag = "logout";

            // إظهار واجهة الدخول الموجودة مسبقاً في الذاكرة
            Application.OpenForms["LoginForm"].Show();

            // إغلاق الواجهة الحالية
            this.Close();

        }
    }
}