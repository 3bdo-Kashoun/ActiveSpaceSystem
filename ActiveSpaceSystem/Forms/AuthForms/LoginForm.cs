using ActiveSpaceSystem.Forms.MainForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActiveSpaceSystem.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {


        }



        private void materialTextBoxEdit1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.panel1.ClientRectangle,
                                       Color.FromArgb(29, 53, 87),
                                       Color.FromArgb(26, 188, 156),
                                       45F)) // زاوية الميل 45 درجة
            {
                e.Graphics.FillRectangle(brush, this.panel1.ClientRectangle);
            }
        }

        private void abdulTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            Form form = new MainForm();
            form.Show();
            this.Hide();

        }
    }
}
