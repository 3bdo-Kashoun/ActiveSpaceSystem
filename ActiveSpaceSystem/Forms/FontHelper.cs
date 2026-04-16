using System.Drawing;
using System.Windows.Forms;

namespace ActiveSpaceSystem.Forms
{
    public static class FontHelper
    {
        public static void ApplyTajawalFont(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is Label || ctrl is Button || ctrl is TextBox || ctrl is DataGridView)
                {
                    ctrl.Font = new Font("Tajawal", ctrl.Font.Size, ctrl.Font.Style);
                }
                else if (ctrl.HasChildren)
                {
                    ApplyTajawalFont(ctrl);
                }
            }
        }
    }
}