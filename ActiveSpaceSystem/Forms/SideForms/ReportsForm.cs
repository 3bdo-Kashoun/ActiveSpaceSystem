using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActiveSpaceSystem.Forms.SideForms
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // رسم إطار رمادي فاتح جداً حول الكرت
            Pen lightPen = new Pen(Color.FromArgb(226, 232, 240), 2);
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // رسم مستطيل بحواف ناعمة
            int radius = 20;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel1.Width - radius - 1, 0, radius, radius, 270, 90);
            path.AddArc(panel1.Width - radius - 1, panel1.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(0, panel1.Height - radius - 1, radius, radius, 90, 90);
            path.CloseAllFigures();

            panel1.Region = new Region(path);
            g.DrawPath(lightPen, path);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // تنعيم الرسم
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // تحديد أبعاد المستطيل مع ترك مسافة بسيطة للإطار
            Rectangle rect = new Rectangle(0, 0, panel2.Width - 1, panel2.Height - 1);
            int radius = 15; // مقدار انحناء الحواف

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                path.CloseAllFigures();

                // قص البانل ليأخذ شكل المسار الدائري
                panel2.Region = new Region(path);

                // رسم إطار رمادي خفيف لتعريف حدود التاريخ
                using (Pen pen = new Pen(Color.FromArgb(226, 232, 240), 1))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {
            // رسم إطار رمادي فاتح جداً حول الكرت
            Pen lightPen = new Pen(Color.FromArgb(226, 232, 240), 2);
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // رسم مستطيل بحواف ناعمة
            int radius = 20;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel2.Width - radius - 1, 0, radius, radius, 270, 90);
            path.AddArc(panel2.Width - radius - 1, panel2.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(0, panel2.Height - radius - 1, radius, radius, 90, 90);
            path.CloseAllFigures();

            panel2.Region = new Region(path);
            g.DrawPath(lightPen, path);

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            // رسم إطار رمادي فاتح جداً حول الكرت
            Pen lightPen = new Pen(Color.FromArgb(226, 232, 240), 2);
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // رسم مستطيل بحواف ناعمة
            int radius = 20;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel3.Width - radius - 1, 0, radius, radius, 270, 90);
            path.AddArc(panel3.Width - radius - 1, panel3.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(0, panel3.Height - radius - 1, radius, radius, 90, 90);
            path.CloseAllFigures();

            panel3.Region = new Region(path);
            g.DrawPath(lightPen, path);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            // رسم إطار رمادي فاتح جداً حول الكرت
            Pen lightPen = new Pen(Color.FromArgb(226, 232, 240), 2);
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // رسم مستطيل بحواف ناعمة
            int radius = 20;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel4.Width - radius - 1, 0, radius, radius, 270, 90);
            path.AddArc(panel4.Width - radius - 1, panel4.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(0, panel4.Height - radius - 1, radius, radius, 90, 90);
            path.CloseAllFigures();

            panel4.Region = new Region(path);
            g.DrawPath(lightPen, path);

            using (Pen shadowPen = new Pen(Color.FromArgb(240, 240, 240), 2))
            {
                e.Graphics.DrawPath(shadowPen, path); // رسم مسار الظل خلف الكارت
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            // رسم إطار رمادي فاتح جداً حول الكرت
            Pen lightPen = new Pen(Color.FromArgb(226, 232, 240), 2);
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // رسم مستطيل بحواف ناعمة
            int radius = 20;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel5.Width - radius - 1, 0, radius, radius, 270, 90);
            path.AddArc(panel5.Width - radius - 1, panel5.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(0, panel5.Height - radius - 1, radius, radius, 90, 90);
            path.CloseAllFigures();

            panel5.Region = new Region(path);
            g.DrawPath(lightPen, path);

            using (Pen shadowPen = new Pen(Color.FromArgb(240, 240, 240), 2))
            {
                e.Graphics.DrawPath(shadowPen, path); // رسم مسار الظل خلف الكارت
            }

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            // رسم إطار رمادي فاتح جداً حول الكرت
            Pen lightPen = new Pen(Color.FromArgb(226, 232, 240), 2);
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // رسم مستطيل بحواف ناعمة
            int radius = 20;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel6.Width - radius - 1, 0, radius, radius, 270, 90);
            path.AddArc(panel6.Width - radius - 1, panel6.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(0, panel6.Height - radius - 1, radius, radius, 90, 90);
            path.CloseAllFigures();

            panel6.Region = new Region(path);
            g.DrawPath(lightPen, path);

            using (Pen shadowPen = new Pen(Color.FromArgb(240, 240, 240), 2))
            {
                e.Graphics.DrawPath(shadowPen, path); // رسم مسار الظل خلف الكارت
            }
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            // رسم إطار رمادي فاتح جداً حول الكرت
            Pen lightPen = new Pen(Color.FromArgb(226, 232, 240), 2);
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // رسم مستطيل بحواف ناعمة
            int radius = 20;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel7.Width - radius - 1, 0, radius, radius, 270, 90);
            path.AddArc(panel7.Width - radius - 1, panel7.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(0, panel7.Height - radius - 1, radius, radius, 90, 90);
            path.CloseAllFigures();

            panel7.Region = new Region(path);
            g.DrawPath(lightPen, path);

            using (Pen shadowPen = new Pen(Color.FromArgb(240, 240, 240), 2))
            {
                e.Graphics.DrawPath(shadowPen, path); // رسم مسار الظل خلف الكارت
            }
        }

       
    }
}

