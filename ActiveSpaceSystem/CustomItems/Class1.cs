using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiveSpaceSystem.CustomItems
{
    public class AbdulTextBox : UserControl
    {
        // الخصائص الجديدة
        private Color borderColor = Color.FromArgb(29, 53, 87);
        private int borderRadius = 15;
        private Image icon = null;
        private int iconSize = 20; // التحكم في الحجم
        private HorizontalAlignment iconLocation = HorizontalAlignment.Left; // التحكم في المكان
        private string placeholderText = "أدخل النص هنا...";
        private bool isPlaceholder = true;

        private TextBox textBox1;

        [Category("Abdul Style")]
        public int BorderRadius { get => borderRadius; set { borderRadius = value; Invalidate(); } }

        [Category("Abdul Style")]
        public Color BorderColor { get => borderColor; set { borderColor = value; Invalidate(); } }

        [Category("Abdul Style")]
        public Image Icon { get => icon; set { icon = value; Invalidate(); } }

        [Category("Abdul Style")]
        public int IconSize { get => iconSize; set { iconSize = value; UpdateTextBoxPosition(); Invalidate(); } }

        [Category("Abdul Style")]
        public HorizontalAlignment IconLocation { get => iconLocation; set { iconLocation = value; UpdateTextBoxPosition(); Invalidate(); } }

        [Category("Abdul Style")]
        public string PlaceholderText { get => placeholderText; set { placeholderText = value; if (isPlaceholder) textBox1.Text = value; Invalidate(); } }

        public AbdulTextBox()
        {
            textBox1 = new TextBox();
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Tajawal", 11);
            textBox1.ForeColor = Color.Gray;

            textBox1.Enter += (s, e) => {
                if (isPlaceholder)
                {
                    textBox1.Text = "";
                    textBox1.ForeColor = Color.Black;
                    isPlaceholder = false;
                }
            };
            textBox1.Leave += (s, e) => {
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    textBox1.Text = placeholderText;
                    textBox1.ForeColor = Color.Gray;
                    isPlaceholder = true;
                }
            };

            this.Controls.Add(textBox1);
            this.Size = new Size(250, 40);
            this.BackColor = Color.White;
            UpdateTextBoxPosition();
        }

        // دالة لتعديل مكان النص بناءً على الأيقونة وحجمها
        private void UpdateTextBoxPosition()
        {
            if (icon == null)
            {
                textBox1.Location = new Point(15, (this.Height - textBox1.Height) / 2);
                textBox1.Width = this.Width - 30;
            }
            else
            {
                int margin = iconSize + 20;
                if (iconLocation == HorizontalAlignment.Left)
                {
                    textBox1.Location = new Point(margin, (this.Height - textBox1.Height) / 2);
                }
                else
                {
                    textBox1.Location = new Point(15, (this.Height - textBox1.Height) / 2);
                }
                textBox1.Width = this.Width - margin - 10;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, borderRadius, borderRadius, 180, 90);
            path.AddArc(rect.Right - borderRadius, rect.Y, borderRadius, borderRadius, 270, 90);
            path.AddArc(rect.Right - borderRadius, rect.Bottom - borderRadius, borderRadius, borderRadius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - borderRadius, borderRadius, borderRadius, 90, 90);
            path.CloseFigure();

            this.Region = new Region(path);

            using (Pen pen = new Pen(borderColor, 2))
            {
                g.DrawPath(pen, path);
            }

            if (icon != null)
            {
                int yPos = (this.Height - iconSize) / 2;
                int xPos = (iconLocation == HorizontalAlignment.Left) ? 10 : this.Width - iconSize - 10;
                g.DrawImage(icon, new Rectangle(xPos, yPos, iconSize, iconSize));
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            UpdateTextBoxPosition();
        }
    }
}
