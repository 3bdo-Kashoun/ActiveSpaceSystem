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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void SwitchPage(UserControl page, object sender)
        {
            // 1. تنظيف الحاوية الرئيسية
            mainContainer.Controls.Clear();

            // 2. ضبط الصفحة الجديدة لتملأ المكان
            page.Dock = DockStyle.Fill;
            mainContainer.Controls.Add(page);

            // 3. تحديث شكل الأزرار (جعل الزر الذي ضغطت عليه فقط هو النشط)
            foreach (Control ctrl in flowLayoutPanel1.Controls)
            {
               
            }
        }
        private void Settings_Load(object sender, EventArgs e)
        {

        }
    }
}
