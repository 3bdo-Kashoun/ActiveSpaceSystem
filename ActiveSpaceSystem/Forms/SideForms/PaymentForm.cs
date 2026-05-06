using ActiveSpace.Models;
using ActiveSpaceSystem.Data;
using ActiveSpaceSystem.Forms.DialogForms;
using ActiveSpaceSystem.Forms.GridStyle;
using ActiveSpaceSystem.Forms.Views;
using ActiveSpaceSystem.Models.enums;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ActiveSpaceSystem.Forms.SideForms
{
    public partial class PaymentForm : Form
    {
        private BindingList<PaymentViewModel> paymentsList;
        private PaymentGridRenderer gridRenderer;
        
        public PaymentForm()
        {
            InitializeComponent();
            this.TopLevel = false;
            gridRenderer = new PaymentGridRenderer();
            SetupGrid();
            this.Load += PaymentForm_Load;
            bookingDetailsCard.BtnPayment.Click += btn_payment_Click;
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            LoadData();
            dgvReservation.ClearSelection();
        }
        private void btn_payment_Click(object sender,EventArgs e)
        {
            string rawBookingID = bookingDetailsCard.BookingID;

            // 2. تنظيف النص للحصول على الأرقام فقط وتجاهل أي حروف أو رموز مثل "B-"
            string cleanNumbers = new string(rawBookingID.Where(char.IsDigit).ToArray());
            if (int.TryParse(cleanNumbers, out int bookingId))
            {


                using (var paymentDialog = new AddPaymentForm())
                {
                    // تمرير البيانات للفورم قبل عرضه
                    paymentDialog.SetBookingData(bookingId, $"{bookingDetailsCard.RemainingAmount}");

                    // فتح الفورم كـ Dialog (شاشة حوارية تمنع النقاش خلفها حتى تُغلق)
                    var result = paymentDialog.ShowDialog();

                    // إذا تمت العملية بنجاح وضغط المستخدم على تأكيد
                    if (result == DialogResult.OK)
                    {
                        // 1. إعادة تحميل البيانات وتحديث الجدول تلقائياً
                        LoadData();

                        // 2. تحديث كارد التفاصيل الجانبي ليظهر القيم الجديدة مباشرة
                        ShowBookingDetails(bookingId);

                        // 3. إلغاء أي تحديد عشوائي في الجدول
                        dgvReservation.ClearSelection();
                    }
                }
            }
        }

        private void SetupGrid()
        {
            dgvReservation.DataSource = null;
            dgvReservation.Rows.Clear();

            dgvReservation.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvReservation.EditMode = DataGridViewEditMode.EditProgrammatically;

            // ربط الأحداث بالجدول
            dgvReservation.CellPainting += dgvReservation_CellPainting;
            dgvReservation.CellClick += dgvReservation_CellClick;

            AddColumns();
        }

        private void AddColumns()
        {
  
            dgvReservation.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "BookingID",
                HeaderText = "رقم الحجز",
                Name = "BookingID",
                Width = 100
            });

            dgvReservation.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CustomerName",
                HeaderText = "العميل",
                Name = "CustomerName",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                DefaultCellStyle = new DataGridViewCellStyle { WrapMode = DataGridViewTriState.True }
            });

            dgvReservation.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "BookingDate",
                HeaderText = "التاريخ",
                Name = "BookingDate",
                Width = 110
            });

            dgvReservation.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TotalAmount",
                HeaderText = "المبلغ الكلي",
                Name = "TotalAmount",
                Width = 110
            });

            dgvReservation.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PaidAmount",
                HeaderText = "المدفوع",
                Name = "PaidAmount",
                Width = 100
            });

            dgvReservation.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Remaining",
                HeaderText = "المتبقي",
                Name = "Remaining",
                Width = 100
            });

            dgvReservation.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Status",
                HeaderText = "الحالة",
                Name = "Status",
                Width = 130
            });

            dgvReservation.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ActionBtn",
                HeaderText = "الإجراء",
                Width = 120
            });
        }

        public void LoadData()
        {
            paymentsList = new BindingList<PaymentViewModel>(
                DataStorage.BookingsList.Select(PaymentViewModel.FromBooking).ToList()
            );

            
         
            dgvReservation.DataSource = paymentsList;
        }

        private void dgvReservation_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            string columnName = dgvReservation.Columns[e.ColumnIndex].Name;

            if (columnName == "Status")
            {
                BookingStatus status = (BookingStatus)e.Value;
                gridRenderer.RenderStatusCell(e, status);
            }
            else if (columnName == "ActionBtn")
            {
                double remaining = Convert.ToDouble(dgvReservation.Rows[e.RowIndex].Cells["Remaining"].Value);
                gridRenderer.RenderActionColumn(e, remaining);
            }
        }

        private void dgvReservation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var item = dgvReservation.Rows[e.RowIndex].DataBoundItem as PaymentViewModel;
            if (item == null) return;

            string columnName = dgvReservation.Columns[e.ColumnIndex].Name;

            // 1. عند الضغط على زر الإجراء (تسجيل دفعة)
            if (columnName == "ActionBtn")
            {
                if (item.Remaining > 0)
                {
                    using (var paymentDialog = new AddPaymentForm())
                    {
                        // تمرير البيانات للفورم قبل عرضه
                        paymentDialog.SetBookingData(item.BookingID, $"{item.Remaining} د.ل");

                        // فتح الفورم كـ Dialog (شاشة حوارية تمنع النقاش خلفها حتى تُغلق)
                        var result = paymentDialog.ShowDialog();

                        // إذا تمت العملية بنجاح وضغط المستخدم على تأكيد
                        if (result == DialogResult.OK)
                        {
                            // 1. إعادة تحميل البيانات وتحديث الجدول تلقائياً
                            LoadData();

                            // 2. تحديث كارد التفاصيل الجانبي ليظهر القيم الجديدة مباشرة
                            ShowBookingDetails(item.BookingID);

                            // 3. إلغاء أي تحديد عشوائي في الجدول
                            dgvReservation.ClearSelection();
                        }
                    }
                }
            }
            // 2. عند الضغط على بقية الحقول يُظهر الكارد الخاص بالتفاصيل
            else
            {
                ShowBookingDetails(item.BookingID);
                bookingDetailsCard.BtnPayment.Visible = item.Remaining > 0;
            }
        }

        private void ShowBookingDetails(int bookingId)
        {
            var booking = DataStorage.BookingsList.FirstOrDefault(b => b.BookingID == bookingId);
            if (booking != null)
            {
                double paid = DataStorage.PaymentList
                              .Where(p => p.BookingID == booking.BookingID)
                              .Sum(p => p.AmountPaid);
                double remaining = booking.TotalAmount - paid;

                bookingDetailsCard.BookingID = $"B-{booking.BookingID}";
                bookingDetailsCard.CustomerName = booking.Customer?.FullName ?? "غير معروف";
                bookingDetailsCard.PhoneNumber = booking.Customer?.Phone ?? "---";

                bookingDetailsCard.TotalAmount = $"{booking.TotalAmount} د.ل";
                bookingDetailsCard.PaidAmount = $"{paid} د.ل";
                bookingDetailsCard.RemainingAmount = $"{remaining} د.ل";
                bookingDetailsCard.DepositAmount = $"{booking.Deposit} د.ل";

                bookingDetailsCard.IsItemSelected = true;
                bookingDetailsCard.RemainingColor = remaining > 0 ? Color.Red : Color.Green;
                bookingDetailsCard.BtnPayment.Visible = remaining > 0;
            }
        }
    }
}