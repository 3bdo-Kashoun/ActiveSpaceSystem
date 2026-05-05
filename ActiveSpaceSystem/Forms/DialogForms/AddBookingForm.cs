using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ActiveSpaceSystem.Data; // ضروري لاستدعاء مكتبات الويندوز
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
            LoadCourtTypes();
            LoadCourts();

        }
        private void AddBookingForm_Load(object sender, EventArgs e)
        {
            // هنا نضع كود الحواف الدائرية الذي كتبناه سابقاً
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));


        }

        private void LoadCourtTypes()
        {
            cmbCourtType.Items.Clear();
            cmbCourtType.ValueMember = "TypeName";
            cmbCourtType.DataSource = DataStorage.CourtTypesList;
        }
        private void LoadCourts()
        {
            cmbCourt.DataSource = null;
            cmbCourt.Items.Clear();

            // السطرين هادم هم المهمين:
            cmbCourt.DisplayMember = "CourtName"; // النص اللي يشوفه الزبون
            cmbCourt.ValueMember = "CourtName";   // القيمة البرمجية (أو خليه CourtID لو تفضل)

            if (cmbCourtType.SelectedIndex == -1)
            {
                cmbCourt.DataSource = DataStorage.CourtsList;
            }
            else
            {
                string selectedTypeName = cmbCourtType.SelectedValue?.ToString();

                cmbCourt.DataSource = DataStorage.CourtsList
                    .Where(c => c.Type != null && c.Type.TypeName == selectedTypeName)
                    .ToList();
            }
        }
        private void AddBookingForm_Paint(object sender, PaintEventArgs e)
        {
            // رسم إطار خارجي رمادي فاتح جداً
            Color borderColor = Color.FromArgb(224, 224, 224);
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, borderColor, ButtonBorderStyle.Solid);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Panel pnl = (Panel)sender;
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // إعداد لون الإطار (رمادي فاتح مثل الصورة)
            Pen pen = new Pen(Color.Black, 2);

            // رسم مسار الحواف الدائرية للبانل
            int radius = 10;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(pnl.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(pnl.Width - radius, pnl.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, pnl.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();

            pnl.Region = new Region(path); // قص البانل ليكون دائرياً
            g.DrawPath(pen, path); // رسم الخط الرمادي حوله
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Panel pnl = (Panel)sender;
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // إعداد لون الإطار الأسود
            // يمكنك تغيير الرقم 2 للتحكم في غلظ الخط
            Pen blackPen = new Pen(Color.Black, 2);

            // رسم المسار الدائري (Radius = 15 بكسل)
            int radius = 15;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(pnl.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(pnl.Width - radius, pnl.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, pnl.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();

            // تطبيق القص لجعل الأركان دائرية
            pnl.Region = new Region(path);

            // رسم الخط الأسود حول المسار
            g.DrawPath(blackPen, path);
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            Panel pnl = (Panel)sender;
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // إعداد لون الإطار الأسود
            // يمكنك تغيير الرقم 2 للتحكم في غلظ الخط
            Pen blackPen = new Pen(Color.Black, 2);

            // رسم المسار الدائري (Radius = 15 بكسل)
            int radius = 15;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(pnl.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(pnl.Width - radius, pnl.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, pnl.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();

            // تطبيق القص لجعل الأركان دائرية
            pnl.Region = new Region(path);

            // رسم الخط الأسود حول المسار
            g.DrawPath(blackPen, path);
        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            Panel pnl = (Panel)sender;
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // إعداد لون الإطار الأسود
            // يمكنك تغيير الرقم 2 للتحكم في غلظ الخط
            Pen blackPen = new Pen(Color.Black, 2);

            // رسم المسار الدائري (Radius = 15 بكسل)
            int radius = 15;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(pnl.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(pnl.Width - radius, pnl.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, pnl.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();

            // تطبيق القص لجعل الأركان دائرية
            pnl.Region = new Region(path);

            // رسم الخط الأسود حول المسار
            g.DrawPath(blackPen, path);
        }

        private void button2_Paint(object sender, PaintEventArgs e)
        {
            Button but = (Button)sender;
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            // رسم المسار الدائري (Radius = 15 بكسل)
            int radius = 45;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(but.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(but.Width - radius, but.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, but.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();

            // تطبيق القص لجعل الأركان دائرية
            but.Region = new Region(path);

        }

        private void button3_Paint(object sender, PaintEventArgs e)
        {
            Button but = (Button)sender;
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            // رسم المسار الدائري (Radius = 15 بكسل)
            int radius = 45;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(but.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(but.Width - radius, but.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, but.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();

            // تطبيق القص لجعل الأركان دائرية
            but.Region = new Region(path);
        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbCourtType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCourts();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                
            }
        }
    }
}
