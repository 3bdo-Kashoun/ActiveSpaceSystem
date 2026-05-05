using ActiveSpace.Models;
using ActiveSpaceSystem.Data;
using ActiveSpaceSystem.Forms.GridStyle;
using ActiveSpaceSystem.Forms.Views;
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

        public MangeCustomers()
        {
            // أولاً: بناء المكونات الأساسية للـ Form
            InitializeComponent();

            // ثانياً: إعداد الخصائص الأولية
            this.TopLevel = false;

            // ثالثاً: ربط حدث التحميل (Load)
            this.Load += MangeCustomers_Load;
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
                DataPropertyName = "ReliabilityFlag",
                HeaderText = "الموثوقية",
                Name = "ReliabilityFlag",
                Width = 130
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

            if (dgvCustomers.Rows.Count > 0)
                dgvCustomers.ClearSelection();
        }

        public void LoadData()
        {
            try
            {
                var data =DataStorage.CustomersList.Select(CustomerViewModel.FromCustomer).ToList();
                customersList = new BindingList<CustomerViewModel>(data);
                dgvCustomers.DataSource = customersList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في تحميل البيانات: " + ex.Message);
            }
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
            if (rowIndex >= 0 && rowIndex < customersList.Count)
            {
                MessageBox.Show("تعديل العميل: " + customersList[rowIndex].FullName);
            }
        }

        private void HandleDeleteClick(int rowIndex)
        {
            if (rowIndex >= 0 && rowIndex < customersList.Count)
            {
                if (MessageBox.Show($"هل أنت متأكد من حذف العميل: {customersList[rowIndex].FullName}؟",
                    "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    customersList.RemoveAt(rowIndex);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}