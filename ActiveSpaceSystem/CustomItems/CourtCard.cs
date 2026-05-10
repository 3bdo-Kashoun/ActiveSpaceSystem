using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ActiveSpaceSystem.CustomItems
{
    public partial class CourtCard : UserControl
    {
        // استيراد مكتبة لجعل الحواف دائرية
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public CourtCard()
        {
            InitializeComponent();
            // جعل الكارد يتمدد مع الشاشة
            this.Dock = DockStyle.Top;



        }

        // الخصائص التي تظهر الأخطاء الآن ستعمل إذا سميت الأدوات في التصميم
        public string CourtName { get => lblCourtName.Text; set => lblCourtName.Text = value; }
        public string SportType { get => lblSportType.Text; set => lblSportType.Text = value; }
        public string ReservationTime { get => lblTime.Text; set => lblTime.Text = value; }

        private bool _isReserved;
        public bool IsReserved
        {
            get => _isReserved;
            set { _isReserved = value; UpdateUI(); }
        }

        private void UpdateUI()
        {
            if (_isReserved)
            {
                // حالة المحجوز (أحمر) - بناءً على image_f72e29.png
                pnlStatusIndicator.BackColor = Color.Red;
                lblStatusTag.Text = "محجوز";
                lblStatusTag.BackColor = Color.FromArgb(255, 235, 235);
                lblStatusTag.ForeColor = Color.DarkRed;
                lblTime.Visible = true;
            }
            else
            {
                // حالة المتاح (أخضر) - بناءً على image_f726e6.png
                pnlStatusIndicator.BackColor = Color.LimeGreen;
                lblStatusTag.Text = "متاح";
                lblStatusTag.BackColor = Color.FromArgb(235, 255, 235);
                lblStatusTag.ForeColor = Color.DarkGreen;
                lblTime.Visible = false;
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            // تحديث الحواف الدائرية عند تغيير حجم الشاشة ليبقى الشكل متناسقاً
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        private void pnlStatusIndicator_Paint(object sender, PaintEventArgs e)
        {
            // إنشاء مسار دائري
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pnlStatusIndicator.Width - 1, pnlStatusIndicator.Height - 1);

            // تطبيق المسار على حدود البانل
            pnlStatusIndicator.Region = new Region(gp);
        }
    }
}