using ActiveSpaceSystem.Data;
using ActiveSpaceSystem.Forms.DialogForms;
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
    public partial class StaduimSteting : Form
    {
        public StaduimSteting()
        {
            InitializeComponent();
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            AddStadiumForm frms = new AddStadiumForm();
            frms.ShowDialog();
            if (frms.DialogResult == DialogResult.OK)
            {
                refreshCourtGrid();
            }

        }
        private void refreshCourtGrid()
        {
            // 1. تصفير المصدر الحالي
            dgvMonthlyContract.DataSource = null;

            // 2. اختيار كافة الأعمدة المطلوب عرضها
            var displayList = DataStorage.CourtsList.Select(c => new
            {
                c.CourtID,
                c.CourtName,
                // جلب اسم النوع من القائمة المرجعية
                TypeName = DataStorage.CourtTypesList.FirstOrDefault(t => t.TypeID == c.TypeID)?.TypeName ?? "غير محدد",
                // إدراج الوقت هنا لكي يظهر في الجدول
                OpenTime = c.OpenTime.ToString(@"hh\:mm"),
                CloseTime = c.CloseTime.ToString(@"hh\:mm")
            }).ToList();

            // 3. ربط القائمة المكتملة بالجدول
            dgvMonthlyContract.DataSource = displayList;
        }

        private void StaduimSteting_Load(object sender, EventArgs e)
        {
            dgvMonthlyContract.AutoGenerateColumns = false;
            refreshCourtGrid();
        }

        private void dgvMonthlyContract_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // تجاهل النقرات على رؤوس الأعمدة
            string columnName = dgvMonthlyContract.Columns[e.ColumnIndex].Name;
            var selectedcourt = DataStorage.CourtsList[e.RowIndex];
            if (columnName == "EditColumn")
            {
                AddStadiumForm frm = new AddStadiumForm(selectedcourt);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    refreshCourtGrid();
                }
            }
            else if (columnName == "DeleteColumn")
            {
                var confirmResult = MessageBox.Show("هل أنت متأكد أنك تريد حذف هذا الملعب؟", "تأكيد الحذف", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    DataStorage.CourtsList.Remove(selectedcourt);
                    refreshCourtGrid();
                }
            }
        }
    }
}
