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

namespace ActiveSpaceSystem.Forms.DialogForms
{
    public partial class AddContract : Form
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
        public AddContract()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void AddContract_Load(object sender, EventArgs e)
        {
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddContract_Paint(object sender, PaintEventArgs e)
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

        private void panel3_Paint(object sender, PaintEventArgs e)
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
    }
}
