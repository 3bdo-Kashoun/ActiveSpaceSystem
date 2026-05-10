using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ActiveSpaceSystem.Forms.GridStyle
{
    public class ExpenseGridRenderer
    {
        private readonly ImageList actionImageList;

        public ExpenseGridRenderer(ImageList actionImageList)
        {
            this.actionImageList = actionImageList ?? throw new ArgumentNullException(nameof(actionImageList));
        }

        public void RenderActionsCell(DataGridViewCellPaintingEventArgs e)
        {
            e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.ContentForeground);
            if (actionImageList?.Images.Count < 2) return;

            int buttonSize = ExpenseGridStyles.ActionButtonSize;
            int spacing = ExpenseGridStyles.ActionButtonSpacing;
            int totalWidth = (buttonSize * 2) + spacing;

            // تحديد نقطة البداية للرسم في منتصف الخلية
            int centerX = e.CellBounds.X + (e.CellBounds.Width - totalWidth) / 2;
            int centerY = e.CellBounds.Y + (e.CellBounds.Height - buttonSize) / 2;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

           
            DrawIcon(e.Graphics, centerX, centerY, buttonSize, "delete");

           
            DrawIcon(e.Graphics, centerX + buttonSize + spacing, centerY, buttonSize, "edit" );

            e.Handled = true;
        }

        private void DrawIcon(Graphics g, int x, int y, int size, string key)
        {
            int iconSize = ExpenseGridStyles.ActionIconSize;
            int offset = (size - iconSize) / 2;
            Rectangle iconRect = new Rectangle(x + offset, y + offset, iconSize, iconSize);
            g.DrawImage(actionImageList.Images[key], iconRect);
        }

        public (bool IsEdit, bool IsDelete) GetClickedButton(Rectangle cellRect, int relativeX)
        {
            int buttonSize = ExpenseGridStyles.ActionButtonSize;
            int spacing = ExpenseGridStyles.ActionButtonSpacing;
            int totalWidth = (buttonSize * 2) + spacing;

            // حساب نقطة البداية (startX) من يسار الخلية
            int startX = (cellRect.Width - totalWidth) / 2;

            // بناءً على الفيديو: الأحمر (حذف) على اليسار، والأزرق (تعديل) على اليمين
            // ملاحظة: relativeX هو المسافة من حافة الخلية اليسرى
            bool isDelete = relativeX >= startX && relativeX < startX + buttonSize;
            bool isEdit = relativeX >= startX + buttonSize + spacing && relativeX < startX + totalWidth;

            return (isEdit, isDelete);
        }
    }
}