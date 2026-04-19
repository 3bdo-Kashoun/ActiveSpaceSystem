using ActiveSpace.Models;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ActiveSpaceSystem.Forms.SideForms
{
    public class CustomerGridRenderer
    {
        private readonly ImageList actionImageList;

        public CustomerGridRenderer(ImageList actionImageList)
        {
            this.actionImageList = actionImageList ?? throw new ArgumentNullException(nameof(actionImageList));
        }

        public void RenderReliabilityCell(DataGridViewCellPaintingEventArgs e, ReliabilityFlag flag)
        {
            e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.ContentForeground);

            var (displayText, backColor, textColor) = GetReliabilityStyle(flag);

            Rectangle rect = new Rectangle(
                e.CellBounds.X + CustomerGridStyles.StatusPadding,
                e.CellBounds.Y + CustomerGridStyles.StatusVerticalPadding,
                Math.Max(0, e.CellBounds.Width - 20),
                Math.Max(0, e.CellBounds.Height - 30)
            );

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            if (rect.Width > 0 && rect.Height > 0)
            {
                using (GraphicsPath path = CreateCapsulePath(rect))
                using (SolidBrush sb = new SolidBrush(backColor))
                    e.Graphics.FillPath(sb, path);
            }

            TextRenderer.DrawText(e.Graphics, displayText, e.CellStyle.Font, e.CellBounds,
                                  textColor, TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);
            e.Handled = true;
        }

        public void RenderActionsCell(DataGridViewCellPaintingEventArgs e)
        {
            e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.ContentForeground);

            if (actionImageList?.Images.Count < 2)
                return;

            int buttonSize = CustomerGridStyles.ActionButtonSize;
            int iconSize = CustomerGridStyles.ActionIconSize;
            int spacing = CustomerGridStyles.ActionButtonSpacing;
            int cornerRadius = CustomerGridStyles.ActionButtonRadius;

            int totalWidth = (buttonSize * 2) + spacing;
            int centerX = e.CellBounds.X + (e.CellBounds.Width - totalWidth) / 2;
            int centerY = e.CellBounds.Y + (e.CellBounds.Height - buttonSize) / 2;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            DrawActionButton(e.Graphics, centerX, centerY, buttonSize, iconSize, cornerRadius,
                            CustomerGridStyles.EditButtonBack, "edit");

            DrawActionButton(e.Graphics, centerX + buttonSize + spacing, centerY, buttonSize, iconSize,
                            cornerRadius, CustomerGridStyles.DeleteButtonBack, "delete");

            e.Handled = true;
        }

        private (string DisplayText, Color BackColor, Color TextColor) GetReliabilityStyle(ReliabilityFlag flag)
        {
            return flag switch
            {
                ReliabilityFlag.Safe => (CustomerGridStyles.TextSafe, CustomerGridStyles.ColorSafeBack, CustomerGridStyles.ColorSafeText),
                ReliabilityFlag.Risky => (CustomerGridStyles.TextRisky, CustomerGridStyles.ColorRiskyBack, CustomerGridStyles.ColorRiskyText),
                ReliabilityFlag.Banned => (CustomerGridStyles.TextBanned, CustomerGridStyles.ColorBannedBack, CustomerGridStyles.ColorBannedText),
                _ => (CustomerGridStyles.TextSafe, CustomerGridStyles.ColorSafeBack, CustomerGridStyles.ColorSafeText)
            };
        }

        private void DrawActionButton(Graphics graphics, int x, int y, int buttonSize, int iconSize,
                                     int cornerRadius, Color backgroundColor, string iconKey)
        {
            var buttonRect = new Rectangle(x, y, buttonSize, buttonSize);
            using (var path = CreateRoundedRectangle(buttonRect, cornerRadius))
            using (var brush = new SolidBrush(backgroundColor))
                graphics.FillPath(brush, path);

            int iconOffsetX = (buttonSize - iconSize) / 2;
            int iconOffsetY = (buttonSize - iconSize) / 2;
            var iconRect = new Rectangle(x + iconOffsetX, y + iconOffsetY, iconSize, iconSize);
            graphics.DrawImage(actionImageList.Images[iconKey], iconRect);
        }

        private GraphicsPath CreateRoundedRectangle(Rectangle rect, int radius)
        {
            var path = new GraphicsPath();
            int d = radius * 2;
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }

        private GraphicsPath CreateCapsulePath(Rectangle rect)
        {
            var path = new GraphicsPath();
            int d = rect.Height;
            if (d > 0)
            {
                path.AddArc(rect.X, rect.Y, d, d, 90, 180);
                path.AddArc(rect.Right - d, rect.Y, d, d, 270, 180);
                path.CloseFigure();
            }
            return path;
        }

        public (bool IsEdit, bool IsDelete) GetClickedButton(Rectangle cellRect, int relativeX)
        {
            int buttonSize = CustomerGridStyles.ActionButtonSize;
            int spacing = CustomerGridStyles.ActionButtonSpacing;
            int totalWidth = (buttonSize * 2) + spacing;
            int centerX = (cellRect.Width - totalWidth) / 2;

            bool isEdit = relativeX >= centerX && relativeX < centerX + buttonSize;
            bool isDelete = relativeX >= centerX + buttonSize + spacing && relativeX < centerX + totalWidth;

            return (isEdit, isDelete);
        }
    }
}
