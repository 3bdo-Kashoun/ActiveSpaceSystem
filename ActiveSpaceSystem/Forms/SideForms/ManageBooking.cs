using ActiveSpace.Models;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace ActiveSpaceSystem.Forms.SideForms
{
    public partial class ManageBooking : Form
    {
        private string TextConfirmed = "مؤكد";
        private string TextCompleted = "مكتمل الدفع";
        private string TextCanceled = "ملغي";
        private string TextPending = "قيد الانتظار";

        private Color ColorConfirmedBack = Color.FromArgb(232, 244, 255);
        private Color ColorConfirmedText = Color.FromArgb(0, 120, 215);
        private Color ColorCompletedBack = Color.FromArgb(232, 245, 233);
        private Color ColorCompletedText = Color.FromArgb(46, 125, 50);
        private Color ColorCanceledBack = Color.FromArgb(255, 235, 238);
        private Color ColorCanceledText = Color.FromArgb(198, 40, 40);
        private Color ColorPendingBack = Color.FromArgb(255, 248, 225);
        private Color ColorPendingText = Color.FromArgb(255, 143, 0);

        // ألوان الأيقونات
        private Color EditButtonBack = Color.FromArgb(200, 230, 255); // أزرق شفاف
        private Color DeleteButtonBack = Color.FromArgb(255, 200, 200); // أحمر شفاف
        private Color EditButtonColor = Color.FromArgb(13, 110, 253); // أزرق
        private Color DeleteButtonColor = Color.FromArgb(220, 53, 69); // أحمر

        private BindingList<BookingViewModel> bookingsList;
        private ImageList actionImageList;

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

            // إنشاء أيقونة التعديل (قلم)
            actionImageList.Images.Add("edit", CreateButtonIcon(EditButtonColor, isEdit: true));

            // إنشاء أيقونة الحذف (سلة)
            actionImageList.Images.Add("delete", CreateButtonIcon(DeleteButtonColor, isEdit: false));
        }

        private Image CreateButtonIcon(Color color, bool isEdit)
        {
            var bmp = new Bitmap(32, 32);
            using (var g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.Transparent);
                g.SmoothingMode = SmoothingMode.AntiAlias;

                using (var pen = new Pen(color, 2.5f))
                {
                    if (isEdit)
                    {
                        // رسم قلم (Edit)
                        g.DrawLine(pen, 6, 24, 22, 8);
                        g.DrawLine(pen, 20, 6, 26, 12);
                        g.DrawRectangle(pen, 16, 18, 12, 10);
                    }
                    else
                    {
                        // رسم سلة (Delete)
                        g.DrawLine(pen, 8, 10, 24, 10);
                        g.DrawLine(pen, 10, 10, 10, 26);
                        g.DrawLine(pen, 22, 10, 22, 26);
                        g.DrawRectangle(pen, 9, 6, 14, 4);
                    }
                }
            }
            return bmp;
        }

        private GraphicsPath CreateRoundedRectangle(Rectangle rect, int radius)
        {
            var path = new GraphicsPath();
            int d = radius * 2;

            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();

            return path;
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
                e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.ContentForeground);

                BookingStatus status = (BookingStatus)e.Value;
                string displayStatus = "";
                Color backColor = Color.White;
                Color textColor = Color.Black;

                switch (status)
                {
                    case BookingStatus.Confirmed:
                        displayStatus = TextConfirmed;
                        backColor = ColorConfirmedBack;
                        textColor = ColorConfirmedText;
                        break;
                    case BookingStatus.Completed:
                        displayStatus = TextCompleted;
                        backColor = ColorCompletedBack;
                        textColor = ColorCompletedText;
                        break;
                    case BookingStatus.Canceled:
                        displayStatus = TextCanceled;
                        backColor = ColorCanceledBack;
                        textColor = ColorCanceledText;
                        break;
                    default:
                        displayStatus = TextPending;
                        backColor = ColorPendingBack;
                        textColor = ColorPendingText;
                        break;
                }

                // رسم الشكل البيضاوي (Capsule)
                Rectangle rect = new Rectangle(e.CellBounds.X + 10, e.CellBounds.Y + 15, 
                                               Math.Max(0, e.CellBounds.Width - 20), 
                                               Math.Max(0, e.CellBounds.Height - 30));

                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                if (rect.Width > 0 && rect.Height > 0)
                {
                    using (GraphicsPath path = new GraphicsPath())
                    {
                        int d = rect.Height;
                        if (d > 0)
                        {
                            path.AddArc(rect.X, rect.Y, d, d, 90, 180);
                            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 180);
                            path.CloseFigure();

                            using (SolidBrush sb = new SolidBrush(backColor))
                                e.Graphics.FillPath(sb, path);
                        }
                    }
                }

                TextRenderer.DrawText(e.Graphics, displayStatus, e.CellStyle.Font, e.CellBounds, 
                                      textColor, TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);
                e.Handled = true;
            }
            else if (dgvBookings.Columns[e.ColumnIndex].Name == "Actions")
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.ContentForeground);

                if (actionImageList?.Images.Count >= 2)
                {
                    int iconSize = 32;
                    int spacing = 15;
                    int totalWidth = (iconSize * 2) + spacing;
                    int centerX = e.CellBounds.X + (e.CellBounds.Width - totalWidth) / 2;
                    int centerY = e.CellBounds.Y + (e.CellBounds.Height - iconSize) / 2;
                    int cornerRadius = 8;

                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                    // رسم خلفية التعديل (أزرق شفاف) برواديوس
                    var editBackRect = new Rectangle(centerX, centerY, iconSize, iconSize);
                    using (var path = CreateRoundedRectangle(editBackRect, cornerRadius))
                    using (var brush = new SolidBrush(EditButtonBack))
                        e.Graphics.FillPath(brush, path);

                    // رسم خلفية الحذف (أحمر شفاف) برواديوس
                    var deleteBackRect = new Rectangle(centerX + iconSize + spacing, centerY, iconSize, iconSize);
                    using (var path = CreateRoundedRectangle(deleteBackRect, cornerRadius))
                    using (var brush = new SolidBrush(DeleteButtonBack))
                        e.Graphics.FillPath(brush, path);

                    // رسم الأيقونات
                    e.Graphics.DrawImage(actionImageList.Images["edit"], editBackRect);
                    e.Graphics.DrawImage(actionImageList.Images["delete"], deleteBackRect);
                }

                e.Handled = true;
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

                int iconSize = 32;
                int spacing = 15;
                int totalWidth = (iconSize * 2) + spacing;
                int centerX = (cellRect.Width - totalWidth) / 2;

                // منطقة التعديل
                if (relativeX >= centerX && relativeX < centerX + iconSize)
                {
                    HandleEditClick(e.RowIndex);
                }
                // منطقة الحذف
                else if (relativeX >= centerX + iconSize + spacing && relativeX < centerX + totalWidth)
                {
                    HandleDeleteClick(e.RowIndex);
                }
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
