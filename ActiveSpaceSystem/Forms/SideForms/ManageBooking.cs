using ActiveSpace.Models;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ActiveSpaceSystem.Forms.SideForms
{
    public partial class ManageBooking : Form
    {
        private BindingList<BookingViewModel> bookingsList;
        private ImageList actionImageList;
        private BookingGridRenderer gridRenderer;

        public ManageBooking()
        {
            InitializeComponent();
            this.TopLevel = false;
            InitializeActionImages();
            SetupGrid();
            this.Load += ManageBooking_Load;
        }

        private void InitializeActionImages()
        {
            actionImageList = new ImageList();
            actionImageList.ImageSize = new Size(32, 32);
            actionImageList.ColorDepth = ColorDepth.Depth32Bit;
            gridRenderer = new BookingGridRenderer(actionImageList);

            try
            {
                // تحميل صور الأيقونات من الموارد المدمجة
                var assembly = typeof(ManageBooking).Assembly;

                using (var editStream = assembly.GetManifestResourceStream("ActiveSpaceSystem.Resources.icons8-edit-48.png"))
                {
                    if (editStream != null)
                    {
                        var editImage = Image.FromStream(editStream);
                        actionImageList.Images.Add("edit", editImage);
                    }
                }

                using (var deleteStream = assembly.GetManifestResourceStream("ActiveSpaceSystem.Resources.icons8-delete-48.png"))
                {
                    if (deleteStream != null)
                    {
                        var deleteImage = Image.FromStream(deleteStream);
                        actionImageList.Images.Add("delete", deleteImage);
                    }
                }
            }
            catch
            {
                // إذا فشل تحميل الصور، يتم ترك ImageList فارغاً
            }
        }

        private void SetupGrid()
        {
            dgvBookings.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvBookings.EditMode = DataGridViewEditMode.EditProgrammatically;

            dgvBookings.CellPainting += DgvBookings_CellPainting;
            dgvBookings.CellClick += DgvBookings_CellClick;
            AddColumns();
        }

        private void AddColumns()
        {
            dgvBookings.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CustomerName",
                HeaderText = "اسم العميل",
                Name = "CustomerName",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                DefaultCellStyle = new DataGridViewCellStyle { WrapMode = DataGridViewTriState.True }
            });

            dgvBookings.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Phone",
                HeaderText = "رقم الهاتف",
                Width = 110
            });

            dgvBookings.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Court",
                HeaderText = "الملعب",
                Width = 130,
                DefaultCellStyle = new DataGridViewCellStyle { WrapMode = DataGridViewTriState.True }
            });

            dgvBookings.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Date",
                HeaderText = "التاريخ",
                Width = 95
            });

            dgvBookings.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Time",
                HeaderText = "الوقت",
                Width = 120
            });

            dgvBookings.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Amount",
                HeaderText = "المبلغ",
                Width = 80
            });

            dgvBookings.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Status",
                HeaderText = "الحالة",
                Name = "Status",
                Width = 130
            });

            dgvBookings.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Actions",
                HeaderText = "الإجراءات",
                Width = 120
            });
        }

        private void ManageBooking_Load(object sender, EventArgs e)
        {
            LoadData();
            dgvBookings.ClearSelection();
        }

        private void LoadData()
        {
            bookingsList = new BindingList<BookingViewModel>(
                Booking.GetFakeData().Select(BookingViewModel.FromBooking).ToList()
            );
            dgvBookings.DataSource = bookingsList;
        }

        private void DgvBookings_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (dgvBookings.Columns[e.ColumnIndex].Name == "Status")
            {
                BookingStatus status = (BookingStatus)e.Value;
                gridRenderer.RenderStatusCell(e, status);
            }
            else if (dgvBookings.Columns[e.ColumnIndex].Name == "Actions")
            {
                gridRenderer.RenderActionsCell(e);
            }
        }

        private void DgvBookings_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (dgvBookings.Columns[e.ColumnIndex].Name == "Actions")
            {
                var item = dgvBookings.Rows[e.RowIndex].DataBoundItem as BookingViewModel;
                if (item == null)
                    return;

                var cellRect = dgvBookings.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                var mousePos = dgvBookings.PointToClient(Cursor.Position);
                int relativeX = mousePos.X - cellRect.X;

                var (isEdit, isDelete) = gridRenderer.GetClickedButton(cellRect, relativeX);

                if (isEdit)
                    HandleEditClick(e.RowIndex);
                else if (isDelete)
                    HandleDeleteClick(e.RowIndex);
            }
        }

        private void HandleEditClick(int rowIndex)
        {
            var item = dgvBookings.Rows[rowIndex].DataBoundItem as BookingViewModel;
            if (item == null)
                return;

            using (var dlg = new EditBookingForm(item))
            {
                if (dlg.ShowDialog(this) == DialogResult.OK)
                    bookingsList.ResetItem(rowIndex);
            }
        }

        private void HandleDeleteClick(int rowIndex)
        {
            if (MessageBox.Show("هل أنت متأكد من حذف هذا الحجز؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (rowIndex >= 0 && rowIndex < bookingsList.Count)
                    bookingsList.RemoveAt(rowIndex);
            }
        }
    }
}
