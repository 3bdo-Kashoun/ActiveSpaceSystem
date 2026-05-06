using ActiveSpace.Models;
using ActiveSpaceSystem.Data;
using ActiveSpaceSystem.Helpers;
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
using System.Xml.Linq;

namespace ActiveSpaceSystem.Forms.DialogForms
{
    public partial class AddCustomerForm : Form
    {
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
       
        public AddCustomerForm()
        {
            InitializeComponent();
        }

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {
            // هنا نضع كود الحواف الدائرية الذي كتبناه سابقاً
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));

        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            string errorMsg;

            if (!ValidationHelper.IsValidCustomerName(nametxt.Texts, out errorMsg))
            {
                MessageBox.Show(errorMsg, "خطأ في البيانات", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nametxt.Focus();
                return;
            }

          
            if (!ValidationHelper.IsValidPhoneNumber(phonetxt.Texts, out errorMsg))
            {
                MessageBox.Show(errorMsg, "خطأ في البيانات", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                phonetxt.Focus();
                return;
            }

            try
            {
                Customer newCustomer = new Customer
                {
                  
                    CustomerID = DataStorage.CustomersList.Count + 1,

                  
                    FullName = nametxt.Texts.Trim(),
                    Phone = phonetxt.Texts.Trim(),

                    TotalDebt = 0
                };

                
                DataStorage.CustomersList.Add(newCustomer);

                MessageBox.Show("تمت إضافة العميل بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

               
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ غير متوقع: " + ex.Message, "خطأ برمي", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                phonetxt.Focus();
            }
        }

        private void phonetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                roundedButton2.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
       
    }
}
