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
    public partial class Dashboard : Form
    {
        public Dashboard()
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

    }
}
