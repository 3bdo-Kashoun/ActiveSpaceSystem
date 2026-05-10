using System;
using System.Drawing;
using System.Windows.Forms;
using ActiveSpaceSystem.Forms.SideForms;
using ActiveSpace.Models;
using ActiveSpaceSystem.Models.enums;

namespace ActiveSpaceSystem.Forms.MainForms
{
    public partial class MainForm : Form
    {
        private DashBoardForm DashForm = null!;
        private ManageBooking BookingForm = null!;
        private SchedulingForm ScheduleForm = null!;
        private MonthlyContractForm MonthlyContractForm = null!;
        private MangeCustomers MangeCustomersForm = null!;
        private PaymentForm PaymentForm = null!;
        private ReportsForm ReportsForm = null!;
        private Settings SettingsForm = null!;
        private ExpensesForm ExpensesForm = null!;

        private Button? currentActiveButton = null;

        public MainForm(User user)
        {
            InitializeComponent();
            btBooking.Click += button1_Click;
            btScheduling.Click += button2_Click;
            btMain.Click += button3_Click;
            btPayment.Click += button4_Click;
            btContract.Click += button5_Click;
            btCustomers.Click += button6_Click;
            btReports.Click += button7_Click;
            btSettings.Click += button8_Click;
            LabelUser.Text = user.FullName;
            LabelRole.Text = user.Role == UserRole.Admin ? "مدير" : "موظف";
            this.WindowState= FormWindowState.Maximized;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            lblDate.Text = DateTime.Now.ToString("dddd، dd MMMM yyyy", new System.Globalization.CultureInfo("ar-EG"));

            // تعيين الزر الرئيسي كنشط افتراضياً
            ActivateButton(btMain);
            ShowFormInPanel(new Dashboard()); // أو أي شاشة ترغب بها
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dddd، dd MMMM yyyy", new System.Globalization.CultureInfo("ar-EG"));
        }
     

        // أزرار القائمة:
        private void button3_Click(object sender, EventArgs e)   // الرئيسية
        {
            ActivateButton(btMain);
            if (DashForm == null || DashForm.IsDisposed)
            {
                DashForm = new DashBoardForm();
            }
            ShowFormInPanel(DashForm);
        }

        private void button1_Click(object sender, EventArgs e)   // إدارة الحجوزات
        {
            ActivateButton(btBooking);
            if (BookingForm == null || BookingForm.IsDisposed)
            {
                BookingForm = new ManageBooking();
                BookingForm.LoadData();
            }

            ShowFormInPanel(BookingForm);
        }

        private void button2_Click(object sender, EventArgs e)   // الجدولة
        {
            ActivateButton(btScheduling);
            if (ScheduleForm == null || ScheduleForm.IsDisposed)
            {
                ScheduleForm = new SchedulingForm();
                ScheduleForm.LoadDataToGrid(ScheduleForm.dateTimePicker2.Value);

            }
            ShowFormInPanel(ScheduleForm);
        }

        private void button5_Click(object sender, EventArgs e)   // العقود الشهرية
        {
            ActivateButton(btContract);
            if (MonthlyContractForm == null || MonthlyContractForm.IsDisposed)
            {
                MonthlyContractForm = new MonthlyContractForm();
            }
            ShowFormInPanel(MonthlyContractForm);
        }

        private void button4_Click(object sender, EventArgs e)   // المدفوعات
        {
            ActivateButton(btPayment);
            if (PaymentForm == null || PaymentForm.IsDisposed)
            {
                PaymentForm = new PaymentForm();
                PaymentForm.LoadData();
            }
           
            ShowFormInPanel(PaymentForm);
        }

        private void button7_Click(object sender, EventArgs e)   // التقارير
        {
            ActivateButton(btReports);
            if (ReportsForm == null || ReportsForm.IsDisposed)
            {
                ReportsForm = new ReportsForm();
            }
            ShowFormInPanel(ReportsForm);
        }

        private void button6_Click(object sender, EventArgs e)   // العملاء
        {
            ActivateButton(btCustomers);
            if (MangeCustomersForm == null || MangeCustomersForm.IsDisposed)
            {
                MangeCustomersForm = new MangeCustomers();
                MangeCustomersForm.LoadData();
            }
            ShowFormInPanel(MangeCustomersForm);
        }

        private void button8_Click(object sender, EventArgs e)   // الإعدادات
        {
            ActivateButton(btSettings);
            if (SettingsForm == null || SettingsForm.IsDisposed)
            {
                SettingsForm = new Settings();
            }
            ShowFormInPanel(SettingsForm);
        }

        private void button9_Click_1(object sender, EventArgs e)
        {

            this.Tag = "logout";
            // إظهار واجهة الدخول الموجودة مسبقاً في الذاكرة
            Application.OpenForms["LoginForm"].Show();

            // إغلاق الواجهة الحالية
            this.Close();

        }

        private void button10_Click(object sender, EventArgs e) //المصروفات
        {
            ActivateButton(btExpense);
            if (ExpensesForm == null || ExpensesForm.IsDisposed)
            {
                ExpensesForm = new ExpensesForm();
            }
            ShowFormInPanel(ExpensesForm);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {

            if (this.Tag == null)
            {
                Application.Exit();
            }
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




        // دالة لعرض النموذج داخل PanelContaint
        private void ShowFormInPanel(Form form)
        {
            PanelContaint.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.RightToLeft = RightToLeft.Yes;
            form.RightToLeftLayout = true;
            PanelContaint.Controls.Add(form);
            form.Show();
        }

    }
}