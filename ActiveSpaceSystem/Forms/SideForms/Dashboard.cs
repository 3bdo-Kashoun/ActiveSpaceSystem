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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            this.TopLevel = false;
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

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint_1(object sender, PaintEventArgs e)
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

        }

        private void label14_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rect = new Rectangle(0, 0, label14.Width - 1, label14.Height - 1);
            int radius = 10; // درجة الانحناء

            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseAllFigures();

            label14.Region = new Region(path);
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
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
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
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

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
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
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
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

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            Pen lightPen = new Pen(Color.FromArgb(226, 232, 240), 2);
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // رسم مستطيل بحواف ناعمة
            int radius = 20;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel8.Width - radius - 1, 0, radius, radius, 270, 90);
            path.AddArc(panel8.Width - radius - 1, panel8.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(0, panel8.Height - radius - 1, radius, radius, 90, 90);
            path.CloseAllFigures();

            panel8.Region = new Region(path);
            g.DrawPath(lightPen, path);
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
            Pen lightPen = new Pen(Color.FromArgb(226, 232, 240), 2);
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // رسم مستطيل بحواف ناعمة
            int radius = 20;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel9.Width - radius - 1, 0, radius, radius, 270, 90);
            path.AddArc(panel9.Width - radius - 1, panel9.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(0, panel9.Height - radius - 1, radius, radius, 90, 90);
            path.CloseAllFigures();

            panel9.Region = new Region(path);
            g.DrawPath(lightPen, path);
        }

        private void label22_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rect = new Rectangle(0, 0, label22.Width - 1, label22.Height - 1);
            int radius = 10; // درجة الانحناء

            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseAllFigures();

            label22.Region = new Region(path);
        }

        private void label27_Click(object sender, EventArgs e)
        {
            Rectangle rect = new Rectangle(0, 0, label27.Width - 1, label27.Height - 1);
            int radius = 10; // درجة الانحناء

            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseAllFigures();

            label27.Region = new Region(path);
        }
    }
}
