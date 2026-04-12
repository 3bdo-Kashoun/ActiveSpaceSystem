using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.ComponentModel;

namespace ActiveSpaceSystem.CustomItems
{
    public class MyGunaButton : Button
    {
        [Category("Guna Style")]
        public int BorderRadius { get; set; } = 20;

        [Category("Guna Style")]
        public Color HoverBackColor { get; set; } = Color.FromArgb(29, 53, 87);

        [Category("Guna Style")]
        public Color NormalBackColor { get; set; } = Color.FromArgb(26, 188, 156);

        private bool isHovering = false;

        public MyGunaButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.BackColor = NormalBackColor;
            this.ForeColor = Color.White;
            this.Size = new Size(150, 45);
            this.Cursor = Cursors.Hand;
            this.UseVisualStyleBackColor = false; // مهم جداً في .NET 8
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            isHovering = true;
            this.BackColor = HoverBackColor;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            isHovering = false;
            this.BackColor = NormalBackColor;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);

            // تصحيح رسم المسار للحواف الدائرية
            using (GraphicsPath path = new GraphicsPath())
            {
                int d = BorderRadius;
                if (d > 1)
                {
                    path.AddArc(0, 0, d, d, 180, 90);
                    path.AddArc(this.Width - d, 0, d, d, 270, 90);
                    path.AddArc(this.Width - d, this.Height - d, d, d, 0, 90);
                    path.AddArc(0, this.Height - d, d, d, 90, 90);
                    path.CloseFigure();
                    this.Region = new Region(path);
                }
            }

            // رسم النص في المنتصف
            TextRenderer.DrawText(pevent.Graphics, this.Text, this.Font, rect, this.ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

            // رسم الأيقونة لو موجودة
            if (this.Image != null)
            {
                int iconSize = 20;
                int yPos = (this.Height - iconSize) / 2;
                pevent.Graphics.DrawImage(this.Image, new Rectangle(10, yPos, iconSize, iconSize));
            }
        }
    }
}