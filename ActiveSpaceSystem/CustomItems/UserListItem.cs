using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.ComponentModel;

namespace ActiveSpaceSystem.CustomItems
{
    public class UserListItem : Panel
    {
        // --- الخصائص العامة (Properties) ---
        [Category("User Data")]
        public string UserName { get; set; } = "اسم المستخدم";
        [Category("User Data")]
        public string UserEmail { get; set; } = "user@example.com";
        [Category("User Data")]
        public string RoleText { get; set; } = "مدير النظام";
        [Category("User Data")]
        public Color RoleColor { get; set; } = Color.FromArgb(46, 204, 113);

        public UserListItem()
        {
            this.DoubleBuffered = true;
            this.Size = new Size(800, 75);
            this.BackColor = Color.White;
            this.Cursor = Cursors.Hand;
            this.Padding = new Padding(10);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            // 1. رسم خلفية السطر وحوافه المنحنية
            Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            using (GraphicsPath path = GetRoundedPath(rect, 15))
            {
                // إطار خفيف جداً بين الأسطر
                using (Pen pen = new Pen(Color.FromArgb(240, 240, 240), 1))
                {
                    g.DrawPath(pen, path);
                }
            }

            // --- إعدادات الرسم باللغة العربية (من اليمين لليسار) ---
            int margin = 20;

            // 2. رسم الأفاتار الدائري (على اليمين)
            //int avatarSize = 45;
            //Rectangle avatarRect = new Rectangle(this.Width - avatarSize - margin, (this.Height - avatarSize) / 2, avatarSize, avatarSize);

            //using (GraphicsPath avatarPath = new GraphicsPath())
            //{
            //    avatarPath.AddEllipse(avatarRect);
            //    g.FillPath(new SolidBrush(Color.FromArgb(52, 152, 219)), avatarPath);

            //    // رسم أول حرف
            //    string firstLetter = string.IsNullOrEmpty(UserName) ? "U" : UserName.Substring(0, 1).ToUpper();
            //    using (Font fontAvatar = new Font("Tajawal", 13, FontStyle.Bold))
            //    {
            //        StringFormat sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
            //        g.DrawString(firstLetter, fontAvatar, Brushes.White, avatarRect, sf);
            //    }
            //}

            // 3. رسم النصوص (الاسم والإيميل)
            // نصوص محاذية لليمين بجانب الأفاتار
            Rectangle textRect = new Rectangle(margin + 150, 0, this.Width  - margin - 40 - 150, this.Height);
            StringFormat rf = new StringFormat { Alignment = StringAlignment.Far, LineAlignment = StringAlignment.Center };

            // الاسم (أعلى)
            using (Font nameFont = new Font("Tajawal", 11, FontStyle.Bold))
            {
                g.DrawString(UserName, nameFont, new SolidBrush(Color.FromArgb(44, 62, 80)),
                    new Rectangle(textRect.X, textRect.Y + 20, textRect.Width, 25), rf);
            }
            // الإيميل (أسفل)
            using (Font emailFont = new Font("Tajawal", 9))
            {
                g.DrawString(UserEmail, emailFont, Brushes.Gray,
                    new Rectangle(textRect.X, textRect.Y + 43, textRect.Width, 20), rf);
            }

            // 4. رسم "تاج" الحالة (Badge)
            int badgeWidth = 80;
            int badgeHeight = 26;
            Rectangle badgeRect = new Rectangle(margin + 60, (this.Height - badgeHeight) / 2, badgeWidth, badgeHeight);

            using (GraphicsPath badgePath = GetRoundedPath(badgeRect, 8))
            {
                // خلفية شفافة من لون الحالة
                g.FillPath(new SolidBrush(Color.FromArgb(40, RoleColor)), badgePath);

                using (Font badgeFont = new Font("Tajawal", 8, FontStyle.Bold))
                {
                    StringFormat sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                    g.DrawString(RoleText, badgeFont, new SolidBrush(RoleColor), badgeRect, sf);
                }
            }

            //// 5. رسم أيقونة التعديل (أقصى اليسار)
            //int iconSize = 24;
            //Rectangle iconRect = new Rectangle(margin, (this.Height - iconSize) / 2, iconSize, iconSize);
            //// رسم شكل مبسط للقلم (أو يمكنك استخدام g.DrawImage لو عندك صورة)
            //g.DrawEllipse(new Pen(Color.LightGray, 2), iconRect);
        }

        private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int d = radius * 2;
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }

        // تحسين تجربة المستخدم عند مرور الماوس
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            this.BackColor = Color.FromArgb(252, 252, 252);
            this.Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            this.BackColor = Color.White;
            this.Invalidate();
        }
    }
}