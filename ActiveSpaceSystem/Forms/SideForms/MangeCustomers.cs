using ActiveSpace.Models;
using ActiveSpaceSystem.Data;
using ActiveSpaceSystem.Forms.DialogForms;
using ActiveSpaceSystem.Forms.GridStyle;
using ActiveSpaceSystem.Forms.Views;
using ActiveSpaceSystem.Models.enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActiveSpaceSystem.Forms.SideForms
{
    public partial class MangeCustomers : Form
    {
        private BindingList<CustomerViewModel> customersList;
        private ImageList actionImageList;
        private CustomerGridRenderer gridRenderer;
        private User currentUser;
        public MangeCustomers(User user)
        {
            // أولاً: بناء المكونات الأساسية للـ Form
            InitializeComponent();

            // ثانياً: إعداد الخصائص الأولية
            this.TopLevel = false;

            // ثالثاً: ربط حدث التحميل (Load)
            this.Load += MangeCustomers_Load;
                currentUser = user; // تخزين المستخدم الحالي لاستخدامه لاحقاً في الصلاحيات أو التخصيص
        }

        private void InitializeActionImages()
        {
            actionImageList = new ImageList();
            actionImageList.ImageSize = new Size(32, 32);
            actionImageList.ColorDepth = ColorDepth.Depth32Bit;

            // تأكد من تهيئة الـ renderer بعد إنشاء الـ ImageList
            gridRenderer = new CustomerGridRenderer(actionImageList);

            try
            {
                var assembly = typeof(ManageBooking).Assembly;
                // تأكد من صحة مسارات الـ Resources في مشروعك
                using (var editStream = assembly.GetManifestResourceStream("ActiveSpaceSystem.Resources.icons8-edit-48.png"))
                {
                    if (editStream != null) actionImageList.Images.Add("edit", Image.FromStream(editStream));
                }
                using (var deleteStream = assembly.GetManifestResourceStream("ActiveSpaceSystem.Resources.icons8-delete-48.png"))
                {
                    if (deleteStream != null) actionImageList.Images.Add("delete", Image.FromStream(deleteStream));
                }
            }
            catch (Exception ex)
            {
                // يفضل تسجيل الخطأ بدلاً من تجاهله تماماً أثناء التطوير
                Console.WriteLine("Resource Error: " + ex.Message);
            }
        }

        private void SetupGrid()
        {


            // إعدادات الـ Grid
            dgvCustomers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvCustomers.EditMode = DataGridViewEditMode.EditProgrammatically;

            // ربط الأحداث
            dgvCustomers.CellPainting += DgvCustomers_CellPainting;
            dgvCustomers.CellClick += DgvCustomers_CellClick;

            AddColumns();
        }

        private void AddColumns()
        {
            dgvCustomers.Columns.Clear(); // مسح أي أعمدة قديمة لتجنب التكرار

            dgvCustomers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FullName",
                HeaderText = "اسم العميل",
                Name = "FullName",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvCustomers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Phone",
                HeaderText = "رقم الهاتف",
                Name = "Phone",
                Width = 120
            });

            dgvCustomers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TotalDebt",
                HeaderText = "إجمالي الدين",
                Name = "TotalDebt",
                Width = 100
            });

            dgvCustomers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NoShowCount",
                HeaderText = "غياب",
                Name = "NoShowCount",
                Width = 70
            });

            dgvCustomers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "LastBookingDate",
                HeaderText = "آخر حجز",
                Name = "LastBookingDate",
                Width = 120
            });


            dgvCustomers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Actions",
                HeaderText = "الإجراءات",
                Width = 120
            });
        }

        private void MangeCustomers_Load(object sender, EventArgs e)
        {
            // تنفيذ العمليات عند تحميل الـ Form لضمان وجود الـ dgvCustomers في الذاكرة
            InitializeActionImages();
            SetupGrid();
            LoadData();
           
            btnAll.IsToggled = true; // تعيين زر "الكل" كافتراضي

            if (dgvCustomers.Rows.Count > 0)
                dgvCustomers.ClearSelection();
        }

        public void LoadData()
        {
            try
            {
                var data = DataStorage.CustomersList.Select(CustomerViewModel.FromCustomer).ToList();
                customersList = new BindingList<CustomerViewModel>(data);
                dgvCustomers.DataSource = customersList;
                if (dgvCustomers.Columns["CustomerId"]!=null)
                   dgvCustomers.Columns["CustomerId"].Visible = false; // إخفاء عمود المعرف إذا كان موجوداً
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في تحميل البيانات: " + ex.Message);
            }
            updateStatisticsCards();
        }

        private void DgvCustomers_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            string columnName = dgvCustomers.Columns[e.ColumnIndex].Name;


            if (columnName == "Actions")
            {
                gridRenderer.RenderActionsCell(e);
            }
        }

        private void DgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (dgvCustomers.Columns[e.ColumnIndex].Name == "Actions")
            {
                var cellRect = dgvCustomers.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                var mousePos = dgvCustomers.PointToClient(Cursor.Position);
                int relativeX = mousePos.X - cellRect.X;

                var (isEdit, isDelete) = gridRenderer.GetClickedButton(cellRect, relativeX);

                if (isEdit) HandleEditClick(e.RowIndex);
                else if (isDelete) HandleDeleteClick(e.RowIndex);
            }
        }

        private void HandleEditClick(int rowIndex)
        {
            if (currentUser.Role != UserRole.Admin )
            {
                MessageBox.Show("عذراً، لا تمتلك صلاحيات التعديل.", "صلاحيات غير كافية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 1. التحقق من صحة الفهرس ومحاولة الوصول للبيانات المرتبطة بالسطر
            if (rowIndex < 0 || dgvCustomers.Rows[rowIndex].DataBoundItem == null) return;

            // الحصول على الـ ViewModel للسطر المختار (أكثر أماناً من الاعتماد على الفهرس فقط)
            var selectedCustomerVm = (CustomerViewModel)dgvCustomers.Rows[rowIndex].DataBoundItem;
            int customerId = selectedCustomerVm.CustomerId;

            // 2. البحث عن الكائن الأصلي في DataStorage
            var customerToEdit = DataStorage.CustomersList.FirstOrDefault(c => c.CustomerID == customerId);

            if (customerToEdit != null)
            {
                // 3. فتح واجهة الإضافة وإرسال بيانات العميل لها باستخدام المشيد (Constructor) الجديد
                using (AddCustomerForm editForm = new AddCustomerForm(customerToEdit))
                {
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {

                        // 4. تحديث البيانات في الواجهة الحالية
                        // نفضل LoadData لإعادة بناء القائمة من الأصل المعدل
                        LoadData();
                        updateStatisticsCards();

                        // 5. تحديث واجهة الحجوزات إذا كانت مفتوحة لضمان ظهور الاسم الجديد هناك
                        var bookingForm = Application.OpenForms.OfType<ManageBooking>().FirstOrDefault();
                        if (bookingForm != null)
                        {
                            bookingForm.LoadData();
                        }
                        // تحديث واجهة المدفوعات إذا كانت مفتوحة
                        var paymentsForm = Application.OpenForms.OfType<PaymentForm>().FirstOrDefault(); // تأكد من اسم الكلاس لديك
                        if (paymentsForm != null)
                        {
                            paymentsForm.LoadData();
                        }

                        // اختيار السطر الذي تم تعديله مجدداً (اختياري لتحسين تجربة المستخدم)
                        foreach (DataGridViewRow row in dgvCustomers.Rows)
                        {
                            if (((CustomerViewModel)row.DataBoundItem).CustomerId == customerId)
                            {
                                row.Selected = true;
                                break;
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("عذراً، لم يتم العثور على بيانات العميل الأصلية.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HandleDeleteClick(int rowIndex)
        {
            if (currentUser.Role != UserRole.Admin)
            {
                MessageBox.Show("عذراً، لا تمتلك صلاحيات الحذف.", "صلاحيات غير كافية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (rowIndex < 0 || dgvCustomers.Rows[rowIndex].DataBoundItem == null) return;
            // 1. الوصول للـ ViewModel الموجود في السطر الذي نقر عليه المستخدم
            var customerVm = dgvCustomers.Rows[rowIndex].DataBoundItem as CustomerViewModel;

            if (customerVm == null) return;

            var result = MessageBox.Show("هل أنت متأكد من الحذف النهائي؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // 2. الحذف من القائمة الأصلية (المرجع الرئيسي)
                    // نستخدم RemoveAll لضمان البحث في القائمة الأصلية وحذف العنصر المطابق للمعرّف
                    DataStorage.CustomersList.RemoveAll(c => c.CustomerID == customerVm.CustomerId);

                    var bookingToRemove = DataStorage.BookingsList.Where(b => b.CustomerID == customerVm.CustomerId).ToList();
                    foreach (var booking in bookingToRemove)
                    {
                        var paymentToRemove = DataStorage.PaymentList.Where(p => p.BookingID == booking.BookingID).ToList();
                        foreach (var payment in paymentToRemove)
                        {
                            DataStorage.PaymentList.Remove(payment);
                        }
                        DataStorage.BookingsList.Remove(booking);
                    }
                    DataStorage.ContractsList.RemoveAll(c => c.CustomerID == customerVm.CustomerId);

                    // 3. تحديث العدادات العلوية
                    updateStatisticsCards();
                    NotifyMonthlyContractsUpdate();




                    // 4. تحديث الجدول: 
                    // إذا كان المستخدم يبحث حالياً، نحدث البحث، وإذا كان يعرض الكل، نحدث الكل
                    if (!string.IsNullOrWhiteSpace(txtSearch.Texts))
                    {
                        txtSearch__TextChanged(null, null); // إعادة تشغيل الفلتر الحالي
                    }
                    else
                    {
                        LoadData(); // إعادة تحميل القائمة الكاملة
                    }

                    MessageBox.Show("تم الحذف من الذاكرة بنجاح.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"خطأ: {ex.Message}");
                }
            }
        }
        public void NotifyMonthlyContractsUpdate()
        {
            // إعادة تحميل البيانات لتحديث العدادات
            var form = Application.OpenForms.OfType<MonthlyContractForm>().FirstOrDefault();
            if (form != null)
            {
                form.RefreshContractsGrid();
            }

        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            AddCustomerForm addForm = new AddCustomerForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                updateStatisticsCards();
                LoadData();
            }

        }
        private void updateStatisticsCards()
        {
            // 1. حساب إجمالي عدد العملاء
            int totalCustomers = DataStorage.CustomersList.Count;
            customerCard2.ValueText = totalCustomers.ToString();

            // 2. حساب العملاء النشطون (مثلاً الذين لديهم حجوزات مؤكدة)
            // نعتمد هنا على فرضية وجود قائمة حجوزات مرتبطة
            int activeCustomers = DataStorage.BookingsList
                                  .Where(b => b.Status == BookingStatus.Confirmed)
                                  .Select(b => b.CustomerID)
                                  .Distinct()
                                  .Count();
            customerCard1.ValueText = activeCustomers.ToString();

            // 3. حساب إجمالي الديون
            double totalDebts = DataStorage.CustomersList.Sum(c => c.TotalDebt);
            customerCard3.ValueText = totalDebts.ToString("N0"); // تنسيق رقمي بدون أعشار
        }

        private void txtSearch__TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Texts.Trim().ToLower();

            // دائماً نسحب من المصدر الرئيسي
            var filtered = DataStorage.CustomersList
                .Where(c => c.FullName.ToLower().Contains(searchTerm) || c.Phone.Contains(searchTerm))
                .Select(CustomerViewModel.FromCustomer)
                .ToList();

            dgvCustomers.DataSource = new BindingList<CustomerViewModel>(filtered);
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            try
            {
                var data = DataStorage.CustomersList.Select(CustomerViewModel.FromCustomer).ToList();
                customersList = new BindingList<CustomerViewModel>(data);

               

                if (dgvCustomers.Columns["CustomerId"] != null)
                    dgvCustomers.Columns["CustomerId"].Visible = false;

              
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في تحميل البيانات: " + ex.Message);
            }

            SetFilterButtonsState(btnAll);

        }

        private void btnDebtFilter_Click(object sender, EventArgs e)
        {
            var debtors = DataStorage.CustomersList
        .Where(c => c.TotalDebt > 0)
        .Select(CustomerViewModel.FromCustomer)
        .ToList();

            dgvCustomers.DataSource = new BindingList<CustomerViewModel>(debtors);
            SetFilterButtonsState(btnDebtFilter);
        }

        private void SetFilterButtonsState(Control activeBtn)
        {
            var buttons = new[] { btnAll, btnDebtFilter };
            foreach (var btn in buttons)
                if (btn != null) btn.IsToggled = (btn == activeBtn);
        }


    }
}