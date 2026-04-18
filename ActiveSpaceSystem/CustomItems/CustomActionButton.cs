using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.ComponentModel;

namespace ActiveSpaceSystem.CustomItems
{
    public class CustomActionButton : Button
    {
        // --- الخصائص القابلة للتعديل من الـ Properties ---
        private int borderRadius = 10;
        private int borderSize = 1;
        private Color borderColor = Color.FromArgb(225, 225, 225);
        private Color toggleColor = Color.FromArgb(245, 245, 245); // لون عند التفعيل
        private bool isToggled = false;
        private Color originalBackColor;

        [Category("Custom Layout")]
        public int BorderRadius
        {
            get => borderRadius;
            set { borderRadius = value; Invalidate(); }
        }

        [Category("Custom Layout")]
        public int BorderSize
        {
            get => borderSize;
            set { borderSize = value; Invalidate(); }
        }

        [Category("Custom Layout")]
        public Color BorderColor
        {
            get => borderColor;
            set { borderColor = value; Invalidate(); }
        }

        [Category("Custom Layout")]
        public Color ToggleColor
        {
            get => toggleColor;
            set { toggleColor = value; Invalidate(); }
        }

        [Category("Custom Layout")]
        public bool IsToggled
        {
            get => isToggled;
            set { isToggled = value; Invalidate(); }
        }

        public CustomActionButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(100, 40);
            this.BackColor = Color.White;
            this.originalBackColor = this.BackColor;
            this.Cursor = Cursors.Hand;
        }

        // تبديل الحالة عند الضغط
        protected override void OnClick(EventArgs e)
        {
            isToggled = !isToggled;
            base.OnClick(e);
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            Graphics g = pevent.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // مساحة الرسم (تنقيص 1 بكسل لضمان عدم قص الإطار)
            Rectangle rectSurface = new Rectangle(0, 0, this.Width, this.Height);
            Rectangle rectBorder = new Rectangle(1, 1, this.Width - 2, this.Height - 2);

            using (GraphicsPath pathSurface = GetRoundedPath(rectSurface, borderRadius))
            using (GraphicsPath pathBorder = GetRoundedPath(rectBorder, borderRadius))
            {
                this.Region = new Region(pathSurface);

                // 1. تلوين الخلفية بناءً على الفلاق (Toggle)
                Color currentBg = isToggled ? toggleColor : this.BackColor;
                using (SolidBrush brush = new SolidBrush(currentBg))
                {
                    g.FillPath(brush, pathSurface);
                }

                // 2. رسم الإطار (Border)
                if (borderSize > 0)
                {
                    using (Pen pen = new Pen(borderColor, borderSize))
                    {
                        pen.Alignment = PenAlignment.Inset;
                        g.DrawPath(pen, pathBorder);
                    }
                }

                // 3. رسم النص والأيقونة في المنتصف
                TextRenderer.DrawText(g, this.Text, this.Font, rectSurface, this.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }
        }

        private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float diameter = Math.Max(radius * 2f, 1f);

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}