using ActiveSpace.Models;
using ActiveSpaceSystem.Data;
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

            FillCourtTypesCompo();
            // هنا نضع كود الحواف الدائرية الذي كتبناه سابقاً
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));


        }

        private void roundedButton3_Click(object sender, EventArgs e)
        {
            AddCourtTypeForm frm = new AddCourtTypeForm();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                FillCourtTypesCompo();
            }
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            // 1. التحقق من البيانات (نفس الكود لكل الحالتين)
            if (string.IsNullOrEmpty(nametxt.Texts))
            {
                MessageBox.Show("الرجاء كتابة اسم الملعب", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // الخروج من الدالة لمنع الاستمرار
            }

            if (cmbCourtType.SelectedItem == null)
            {
                MessageBox.Show("الرجاء اختيار نوع الملعب", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var selecttype = (CourtType)cmbCourtType.SelectedItem;

                if (_courtToEdit == null)
                {
                    // --- حالة الإضافة الجديدة ---
                    Court newcort = new Court
                    {
                        CourtID = DataStorage.CourtsList.Max(c=>c.CourtID) + 1, // إعطاء ID تلقائي بسيط
                        CourtName = nametxt.Texts,
                        TypeID = selecttype.TypeID,
                        OpenTime = dtpOpenTime.Value.TimeOfDay,
                        CloseTime = dtpCloseTime.Value.TimeOfDay,
                        Type= selecttype
                    };

                    DataStorage.CourtsList.Add(newcort);
                    MessageBox.Show("تم إضافة الملعب بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // --- حالة التعديل ---
                    // تأكد من أن nametxt هو الاسم الصحيح للأداة (في الكود تحت كنت كاتب txtCourtName)
                    _courtToEdit.CourtName = nametxt.Texts;
                    _courtToEdit.TypeID = selecttype.TypeID;
                    _courtToEdit.OpenTime = dtpOpenTime.Value.TimeOfDay;
                    _courtToEdit.CloseTime = dtpCloseTime.Value.TimeOfDay;

                    MessageBox.Show("تم تحديث بيانات الملعب بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // إغلاق الواجهة وإعادة النتيجة OK لتحديث الجدول في الشاشة الرئيسية
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillCourtTypesCompo()
        {
            cmbCourtType.DataSource = null;
            cmbCourtType.DataSource = DataStorage.CourtTypesList;
            cmbCourtType.DisplayMember = "TypeName";
            cmbCourtType.ValueMember = "TypeID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private Court _courtToEdit;
        public AddStadiumForm(Court court)
        {
            InitializeComponent();
            _courtToEdit = court; // استلام الملعب
            label1.Text = "تعديل بيانات الملعب"; // تغيير الـ Label
            roundedButton2.Text = "تحديث"; // اختياري: تغيير نص الزر أيضاً

            // تعبئة البيانات في الحقول تلقائياً
            nametxt.Texts = court.CourtName;
            cmbCourtType.SelectedValue = court.TypeID;
            dtpOpenTime.Value = DateTime.Today.Add(court.OpenTime);
            dtpCloseTime.Value = DateTime.Today.Add(court.CloseTime);
        }
    }
}
