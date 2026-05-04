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
using ActiveSpaceSystem.Data;
using ActiveSpaceSystem.Forms.MainForms;

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
        }

        private void abdulTextBox1_Load(object sender, EventArgs e)
        {

        }


        private void roundedButton1_Click_1(object sender, EventArgs e)
        {

            string inputUser = txtUsername.Texts.Trim();
            string inputPass = txtPassword.Texts.Trim();

            // التأكد من أن الحقول ليست فارغة
            if (string.IsNullOrEmpty(inputUser) || string.IsNullOrEmpty(inputPass))
            {
                MessageBox.Show("الرجاء إدخال اسم المستخدم وكلمة المرور", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // البحث في Data Structure باستخدام LINQ
            var user = DataStorage.UsersList.FirstOrDefault(u => u.Username == inputUser && u.Password == inputPass);

            if (user != null)
            {
                //MessageBox.Show($"أهلاً بك يا {user.Username}، تم الدخول بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassword.Texts = ""; // مسح كلمة المرور بعد تسجيل الدخول
                txtPassword.Focus(); // إعادة التركيز على حقل كلمة المرور
                Form form = new MainForm( user);
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("اسم المستخدم أو كلمة المرور غير صحيحة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
