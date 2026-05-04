using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActiveSpaceSystem.Forms.DialogForms
{
    public partial class AddStadiumForm : Form
    {
        public AddStadiumForm()
        {
            InitializeComponent();
        }

        // استدعاء دالة من الويندوز لعمل الأركان الدائرية
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
    (
        int nLeftRect,     // إحداثيات الزاوية اليسرى
        int nTopRect,      // إحداثيات الزاوية العلوية
        int nRightRect,    // إحداثيات الزاوية اليمنى السفلى
        int nBottomRect,   // إحداثيات الزاوية اليمنى السفلى
        int nWidthEllipse, // عرض الانحناء (كلما زاد زاد الدوران)
        int nHeightEllipse // طول الانحناء
    );

        private void AddStadiumForm_Load(object sender, EventArgs e)
        {
            // هنا نضع كود الحواف الدائرية الذي كتبناه سابقاً
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));

        }
    }
}
