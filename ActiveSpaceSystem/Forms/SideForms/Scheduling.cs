
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

            //// Configure date picker initial format
            //dateTimePicker1.Format = DateTimePickerFormat.Custom;
            //dateTimePicker1.CustomFormat = "yyyy / MM / dd";

            //// Set human friendly column headers (hours)
            //string[] hours = { "23:00", "22:00", "21:00", "20:00", "19:00", "18:00", "17:00", "16:00", "15:00", "14:00" };
            //for (int i = 0; i < hours.Length && i + 1 < customDataGridView1.Columns.Count; i++)
            //{
            //    customDataGridView1.Columns[i + 1].HeaderText = hours[i];
            //}

            //// Header visual polish
            //customDataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(247, 249, 250);
            //customDataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(33, 37, 41);
            //customDataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Regular);
            //customDataGridView1.EnableHeadersVisualStyles = false;
            //customDataGridView1.RowTemplate.Height = 70;

            //// Example rows to visually match the design (you will replace with real data)
            //customDataGridView1.Rows.Clear();
            //customDataGridView1.Rows.Add(new object[] { "ملعب كرة القدم 1", "متاح", "متاح", "متاح", "محجوز\nخالد علي", "متاح", "متاح", "متاح", "متاح", "متاح", "متاح" });
            //customDataGridView1.Rows.Add(new object[] { "ملعب كرة القدم 2", "متاح", "متاح", "متاح", "متاح", "متاح", "متاح", "متاح", "متاح", "متاح", "متاح" });
            //customDataGridView1.Rows.Add(new object[] { "ملعب التنس 1", "متاح", "متاح", "متاح", "متاح", "محجوز\nسعيد أحمد", "متاح", "متاح", "متاح", "متاح", "متاح" });
            //customDataGridView1.Rows.Add(new object[] { "ملعب التنس 2", "متاح", "متاح", "محجوز\nعلي محمد", "متاح", "متاح", "متاح", "متاح", "متاح", "متاح", "متاح" });

            //// Style each cell according to its status
            //ApplyCellStatusStyles();
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