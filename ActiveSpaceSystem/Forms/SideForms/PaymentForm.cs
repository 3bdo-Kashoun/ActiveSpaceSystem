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
    public partial class PaymentForm : Form
    {
        public PaymentForm()
        {
            InitializeComponent();
            this.TopLevel = false;
        }

        private void bookingDetailsCard1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            dgvReservation.Rows.Add(
     "B-2026-001",
     "محمد عبد الرحمن",
     "2026-04-15",
     "1500",
     "1000",
     "500",
     "نشط",
     "عرض التفاصيل"
 );

            dgvReservation.Rows.Add(
                "B-2026-002",
                "سارة محمود علي",
                "2026-04-16",
                "2400",
                "2400",
                "0",
                "مكتمل",
                "عرض التفاصيل"
            );

            dgvReservation.Rows.Add(
                "B-2026-003",
                "أحمد صالح الورفلي",
                "2026-04-17",
                "850",
                "300",
                "550",
                "قيد الانتظار",
                "عرض التفاصيل"
            );
        }
    }
}
