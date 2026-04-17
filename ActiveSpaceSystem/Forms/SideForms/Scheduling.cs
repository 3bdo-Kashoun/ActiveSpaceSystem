
using ActiveSpaceSystem.CustomItems;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ActiveSpaceSystem.Forms.SideForms
{
    public partial class Scheduling : Form
    {
        public Scheduling()
        {
            InitializeComponent();
            
           
        }

        
        private void infoBox1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customLabel1_Click(object sender, EventArgs e)
        {

        }

        private void customLabel3_Click(object sender, EventArgs e)
        {

        }

        private void Scheduling_Load(object sender, EventArgs e)
        {        
            SetupGrid();
           
        }
        private void SetupGrid()
        {
            
            
            // إضافة الأعمدة (ساعات)
            stadiumGrid1.Columns.Add("Stadium", "الملعب");
            for (int i = 8; i <= 23; i++)
            {
                stadiumGrid1.Columns.Add($"h{i}", $"{i}:00");
            }

            // إضافة بيانات تجريبية
            stadiumGrid1.Rows.Clear();

            // ملعب كرة القدم 1
            stadiumGrid1.Rows.Add("ملعب كرة القدم 1",
                "متاح", "متاح", "محجوز|أحمد محمد", "متاح", "متاح", "متاح",
                "متاح", "محجوز|يحيى حسن", "متاح", "متاح", "متاح", "متاح",
                "خارج وقت العمل", "خارج وقت العمل", "خارج وقت العمل", "خارج وقت العمل");

            // ملعب كرة القدم 2
            stadiumGrid1.Rows.Add("ملعب كرة القدم 2",
                "متاح", "متاح", "متاح", "محجوز|يوسف أحمد", "متاح", "متاح",
                "متاح", "متاح", "متاح", "محجوز|سالم علي", "متاح", "متاح",
                "متاح", "متاح", "خارج وقت العمل", "خارج وقت العمل");

            // ملعب التنس 1
            stadiumGrid1.Rows.Add("ملعب التنس 1",
                "محجوز|سعيد أحمد", "متاح", "متاح", "متاح", "متاح", "متاح",
                "متاح", "متاح", "محجوز|وائل جمعة", "متاح", "متاح", "متاح",
                "متاح", "متاح", "متاح", "متاح");

            // ملعب السلة
            stadiumGrid1.Rows.Add("ملعب السلة",
                "خارج وقت العمل", "خارج وقت العمل", "متاح", "متاح", "متاح", "محجوز|عمر خالد",
                "متاح", "متاح", "متاح", "متاح", "متاح", "محجوز|إيهاب وجدي",
                "متاح", "متاح", "متاح", "متاح");
        }
        private void ApplyCellStatusStyles()
        {
            //// Cells in column 0 are stadium names; start at column 1
            //for (int r = 0; r < customDataGridView1.Rows.Count; r++)
            //{
            //    var row = customDataGridView1.Rows[r];
            //    for (int c = 1; c < customDataGridView1.Columns.Count; c++)
            //    {
            //        var cell = row.Cells[c];
            //        string text = cell.Value?.ToString() ?? string.Empty;
            //        cell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //        cell.Style.Font = new Font("Segoe UI", 11F, FontStyle.Regular);

            //        if (text.Contains("محجوز"))
            //        {
            //            cell.Style.BackColor = Color.FromArgb(255, 218, 218);
            //            cell.Style.ForeColor = Color.FromArgb(176, 0, 0);
            //            // Make reserved cell show a subtle border
            //            cell.Style.SelectionBackColor = Color.FromArgb(255, 200, 200);
            //        }
            //        else if (text.Contains("متاح"))
            //        {
            //            cell.Style.BackColor = Color.FromArgb(235, 255, 248);
            //            cell.Style.ForeColor = Color.FromArgb(0, 150, 110);
            //            cell.Style.SelectionBackColor = Color.FromArgb(220, 255, 240);
            //        }
            //        else
            //        {
            //            // default neutral
            //            cell.Style.BackColor = Color.White;
            //            cell.Style.ForeColor = Color.Black;
            //        }
            //    }

            //    // Stadium (first column) styling
            //    var stadiumCell = row.Cells[0];
            //    stadiumCell.Style.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            //    stadiumCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            //    stadiumCell.Style.BackColor = Color.White;
            //    stadiumCell.Style.ForeColor = Color.FromArgb(33, 37, 41);
            //}

            //// Grid lines and other tweaks
            //customDataGridView1.GridColor = Color.FromArgb(230, 230, 230);
        }

        private void prevDateButton_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker1.Value.AddDays(-1);
        }

        private void nextDateButton_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker1.Value.AddDays(1);
        }

        private void statusCard4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void statusCard2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customLabel3_Click_1(object sender, EventArgs e)
        {

        }
    }
}