
namespace ActiveSpaceSystem.Forms.SideForms
{
    partial class ExpensesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnOpenAdd = new ActiveSpaceSystem.CustomItems.RoundedButton();
            label3 = new Label();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            advancedStatusCard4 = new ActiveSpaceSystem.CustomItems.AdvancedStatusCard();
            advancedStatusCard3 = new ActiveSpaceSystem.CustomItems.AdvancedStatusCard();
            advancedStatusCard1 = new ActiveSpaceSystem.CustomItems.AdvancedStatusCard();
            statusCard4 = new ActiveSpaceSystem.CustomItems.StatusCard();
            btnFilterSalaries = new ActiveSpaceSystem.CustomItems.PillButton();
            btnFilterElectricity = new ActiveSpaceSystem.CustomItems.PillButton();
            btnFilterMaintenance = new ActiveSpaceSystem.CustomItems.PillButton();
            btnFilterAll = new ActiveSpaceSystem.CustomItems.PillButton();
            panel2 = new Panel();
            dgvExpenses = new ActiveSpaceSystem.CustomItems.CustomDataGridView();
            txtSearch = new TextBox();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            statusCard4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExpenses).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnOpenAdd);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1278, 150);
            panel1.TabIndex = 0;
            // 
            // btnOpenAdd
            // 
            btnOpenAdd.Anchor = AnchorStyles.Left;
            btnOpenAdd.BackColor = Color.FromArgb(38, 191, 141);
            btnOpenAdd.BorderColor = Color.PaleVioletRed;
            btnOpenAdd.BorderRadius = 15;
            btnOpenAdd.BorderSize = 0;
            btnOpenAdd.FlatAppearance.BorderSize = 0;
            btnOpenAdd.FlatStyle = FlatStyle.Flat;
            btnOpenAdd.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOpenAdd.ForeColor = Color.White;
            btnOpenAdd.Image = Properties.Resources.icons8_add_24;
            btnOpenAdd.ImageAlign = ContentAlignment.MiddleRight;
            btnOpenAdd.Location = new Point(45, 44);
            btnOpenAdd.Margin = new Padding(4);
            btnOpenAdd.Name = "btnOpenAdd";
            btnOpenAdd.Padding = new Padding(25, 12, 25, 12);
            btnOpenAdd.Size = new Size(285, 80);
            btnOpenAdd.TabIndex = 12;
            btnOpenAdd.Text = "إضافة مصروف جديد";
            btnOpenAdd.TextAlign = ContentAlignment.MiddleLeft;
            btnOpenAdd.UseVisualStyleBackColor = false;
            btnOpenAdd.Click += roundedButton1_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(1016, 85);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(227, 25);
            label3.TabIndex = 11;
            label3.Text = "متابعة بيانات وحجوزات العملاء";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(1047, 21);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(196, 46);
            label1.TabIndex = 10;
            label1.Text = "إدارة العملاء";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(advancedStatusCard4, 2, 0);
            tableLayoutPanel1.Controls.Add(advancedStatusCard3, 1, 0);
            tableLayoutPanel1.Controls.Add(advancedStatusCard1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 150);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1278, 159);
            tableLayoutPanel1.TabIndex = 17;
            // 
            // advancedStatusCard4
            // 
            advancedStatusCard4.BackColor = Color.White;
            advancedStatusCard4.BorderRadius = 20;
            advancedStatusCard4.CardIcon = Properties.Resources.icons8_money_50;
            advancedStatusCard4.Dock = DockStyle.Fill;
            advancedStatusCard4.IconBackColor = Color.FromArgb(220, 38, 38);
            advancedStatusCard4.Location = new Point(856, 4);
            advancedStatusCard4.Margin = new Padding(4);
            advancedStatusCard4.Name = "advancedStatusCard4";
            advancedStatusCard4.Padding = new Padding(12);
            advancedStatusCard4.ShadowSize = 1;
            advancedStatusCard4.Size = new Size(418, 151);
            advancedStatusCard4.SubValueColor = Color.Gray;
            advancedStatusCard4.SubValueFont = new Font("Tajawal", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            advancedStatusCard4.SubValueText = "";
            advancedStatusCard4.TabIndex = 19;
            advancedStatusCard4.TitleColor = Color.Gray;
            advancedStatusCard4.TitleFont = new Font("Tajawal Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            advancedStatusCard4.TitleText = "إجمالي المصروفات";
            advancedStatusCard4.ValueColor = Color.FromArgb(220, 38, 38);
            advancedStatusCard4.ValueFont = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            advancedStatusCard4.ValueText = "١٧٬٥٨٠ د.ل";
            // 
            // advancedStatusCard3
            // 
            advancedStatusCard3.BackColor = Color.White;
            advancedStatusCard3.BorderRadius = 20;
            advancedStatusCard3.CardIcon = Properties.Resources.icons8_money_50__1_;
            advancedStatusCard3.Dock = DockStyle.Fill;
            advancedStatusCard3.IconBackColor = Color.FromArgb(43, 127, 255);
            advancedStatusCard3.Location = new Point(430, 4);
            advancedStatusCard3.Margin = new Padding(4);
            advancedStatusCard3.Name = "advancedStatusCard3";
            advancedStatusCard3.Padding = new Padding(12);
            advancedStatusCard3.ShadowSize = 1;
            advancedStatusCard3.Size = new Size(418, 151);
            advancedStatusCard3.SubValueColor = Color.Gray;
            advancedStatusCard3.SubValueFont = new Font("Tajawal", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            advancedStatusCard3.SubValueText = "";
            advancedStatusCard3.TabIndex = 18;
            advancedStatusCard3.TitleColor = Color.Gray;
            advancedStatusCard3.TitleFont = new Font("Tajawal Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            advancedStatusCard3.TitleText = "مصروفات الشهرالحالي";
            advancedStatusCard3.ValueColor = Color.FromArgb(43, 127, 255);
            advancedStatusCard3.ValueFont = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            advancedStatusCard3.ValueText = "١٧٬٥٨٠ د.ل";
            // 
            // advancedStatusCard1
            // 
            advancedStatusCard1.BackColor = Color.White;
            advancedStatusCard1.BorderRadius = 20;
            advancedStatusCard1.CardIcon = Properties.Resources.icons8_invoice_50;
            advancedStatusCard1.Dock = DockStyle.Fill;
            advancedStatusCard1.IconBackColor = Color.FromArgb(46, 204, 113);
            advancedStatusCard1.Location = new Point(4, 4);
            advancedStatusCard1.Margin = new Padding(4);
            advancedStatusCard1.Name = "advancedStatusCard1";
            advancedStatusCard1.Padding = new Padding(12);
            advancedStatusCard1.ShadowSize = 1;
            advancedStatusCard1.Size = new Size(418, 151);
            advancedStatusCard1.SubValueColor = Color.FromArgb(46, 204, 113);
            advancedStatusCard1.SubValueFont = new Font("Tajawal", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            advancedStatusCard1.SubValueText = "";
            advancedStatusCard1.TabIndex = 16;
            advancedStatusCard1.TitleColor = Color.Gray;
            advancedStatusCard1.TitleFont = new Font("Tajawal Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            advancedStatusCard1.TitleText = "عدد المصروفات";
            advancedStatusCard1.ValueColor = Color.FromArgb(46, 204, 113);
            advancedStatusCard1.ValueFont = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            advancedStatusCard1.ValueText = "١٧٬٥٨٠ د.ل";
            // 
            // statusCard4
            // 
            statusCard4.BackColor = Color.Transparent;
            statusCard4.BorderColor = Color.Black;
            statusCard4.BorderRadius = 15;
            statusCard4.CardBackColor = Color.White;
            statusCard4.Controls.Add(txtSearch);
            statusCard4.Controls.Add(btnFilterSalaries);
            statusCard4.Controls.Add(btnFilterElectricity);
            statusCard4.Controls.Add(btnFilterMaintenance);
            statusCard4.Controls.Add(btnFilterAll);
            statusCard4.Dock = DockStyle.Top;
            statusCard4.Location = new Point(0, 309);
            statusCard4.Margin = new Padding(100);
            statusCard4.Name = "statusCard4";
            statusCard4.Padding = new Padding(50);
            statusCard4.ShadowBlur = 5;
            statusCard4.ShadowColor = Color.FromArgb(0, 0, 192);
            statusCard4.ShowShadow = true;
            statusCard4.Size = new Size(1278, 116);
            statusCard4.TabIndex = 18;
            statusCard4.TitleColor = Color.Gray;
            statusCard4.TitleFont = new Font("Microsoft Sans Serif", 10F);
            statusCard4.TitleText = "";
            statusCard4.ValueColor = Color.FromArgb(46, 204, 113);
            statusCard4.ValueFont = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            statusCard4.ValueText = "";
            // 
            // btnFilterSalaries
            // 
            btnFilterSalaries.BackColor = Color.White;
            btnFilterSalaries.BackgroundImageLayout = ImageLayout.None;
            btnFilterSalaries.Checked = false;
            btnFilterSalaries.CheckedBackColor = Color.FromArgb(41, 51, 146);
            btnFilterSalaries.CheckedForeColor = Color.White;
            btnFilterSalaries.FlatAppearance.BorderSize = 0;
            btnFilterSalaries.FlatStyle = FlatStyle.Flat;
            btnFilterSalaries.Font = new Font("Tajawal Medium", 10.2F, FontStyle.Bold);
            btnFilterSalaries.ForeColor = Color.FromArgb(64, 64, 64);
            btnFilterSalaries.GroupName = "";
            btnFilterSalaries.Location = new Point(45, 28);
            btnFilterSalaries.Margin = new Padding(2);
            btnFilterSalaries.Name = "btnFilterSalaries";
            btnFilterSalaries.Radius = 10;
            btnFilterSalaries.Size = new Size(178, 54);
            btnFilterSalaries.TabIndex = 11;
            btnFilterSalaries.Text = "رواتب الموظفين";
            btnFilterSalaries.UncheckedBackColor = Color.FromArgb(242, 242, 242);
            btnFilterSalaries.UncheckedForeColor = Color.FromArgb(64, 64, 64);
            btnFilterSalaries.UseVisualStyleBackColor = false;
            btnFilterSalaries.Click += btnFilterSalaries_Click;
            // 
            // btnFilterElectricity
            // 
            btnFilterElectricity.BackColor = Color.White;
            btnFilterElectricity.BackgroundImageLayout = ImageLayout.None;
            btnFilterElectricity.Checked = false;
            btnFilterElectricity.CheckedBackColor = Color.FromArgb(41, 51, 146);
            btnFilterElectricity.CheckedForeColor = Color.White;
            btnFilterElectricity.FlatAppearance.BorderSize = 0;
            btnFilterElectricity.FlatStyle = FlatStyle.Flat;
            btnFilterElectricity.Font = new Font("Tajawal Medium", 10.2F, FontStyle.Bold);
            btnFilterElectricity.ForeColor = Color.FromArgb(64, 64, 64);
            btnFilterElectricity.GroupName = "";
            btnFilterElectricity.Location = new Point(245, 28);
            btnFilterElectricity.Margin = new Padding(2);
            btnFilterElectricity.Name = "btnFilterElectricity";
            btnFilterElectricity.Radius = 10;
            btnFilterElectricity.Size = new Size(112, 54);
            btnFilterElectricity.TabIndex = 10;
            btnFilterElectricity.Text = "كهرباء";
            btnFilterElectricity.UncheckedBackColor = Color.FromArgb(242, 242, 242);
            btnFilterElectricity.UncheckedForeColor = Color.FromArgb(64, 64, 64);
            btnFilterElectricity.UseVisualStyleBackColor = false;
            btnFilterElectricity.Click += btnFilterElectricity_Click;
            // 
            // btnFilterMaintenance
            // 
            btnFilterMaintenance.BackColor = Color.White;
            btnFilterMaintenance.BackgroundImageLayout = ImageLayout.None;
            btnFilterMaintenance.Checked = false;
            btnFilterMaintenance.CheckedBackColor = Color.FromArgb(41, 51, 146);
            btnFilterMaintenance.CheckedForeColor = Color.White;
            btnFilterMaintenance.FlatAppearance.BorderSize = 0;
            btnFilterMaintenance.FlatStyle = FlatStyle.Flat;
            btnFilterMaintenance.Font = new Font("Tajawal Medium", 10.2F, FontStyle.Bold);
            btnFilterMaintenance.ForeColor = Color.FromArgb(64, 64, 64);
            btnFilterMaintenance.GroupName = "";
            btnFilterMaintenance.Location = new Point(379, 28);
            btnFilterMaintenance.Margin = new Padding(2);
            btnFilterMaintenance.Name = "btnFilterMaintenance";
            btnFilterMaintenance.Radius = 10;
            btnFilterMaintenance.Size = new Size(163, 54);
            btnFilterMaintenance.TabIndex = 9;
            btnFilterMaintenance.Text = " صيانة الملاعب";
            btnFilterMaintenance.UncheckedBackColor = Color.FromArgb(242, 242, 242);
            btnFilterMaintenance.UncheckedForeColor = Color.FromArgb(64, 64, 64);
            btnFilterMaintenance.UseVisualStyleBackColor = false;
            btnFilterMaintenance.Click += btnFilterMaintenance_Click;
            // 
            // btnFilterAll
            // 
            btnFilterAll.BackColor = Color.White;
            btnFilterAll.BackgroundImageLayout = ImageLayout.None;
            btnFilterAll.Checked = true;
            btnFilterAll.CheckedBackColor = Color.FromArgb(41, 51, 146);
            btnFilterAll.CheckedForeColor = Color.White;
            btnFilterAll.FlatAppearance.BorderSize = 0;
            btnFilterAll.FlatStyle = FlatStyle.Flat;
            btnFilterAll.Font = new Font("Tajawal Medium", 10.2F, FontStyle.Bold);
            btnFilterAll.ForeColor = Color.FromArgb(64, 64, 64);
            btnFilterAll.GroupName = "";
            btnFilterAll.Location = new Point(564, 28);
            btnFilterAll.Margin = new Padding(2);
            btnFilterAll.Name = "btnFilterAll";
            btnFilterAll.Radius = 10;
            btnFilterAll.Size = new Size(112, 54);
            btnFilterAll.TabIndex = 8;
            btnFilterAll.Text = "الكل ";
            btnFilterAll.UncheckedBackColor = Color.FromArgb(242, 242, 242);
            btnFilterAll.UncheckedForeColor = Color.FromArgb(64, 64, 64);
            btnFilterAll.UseVisualStyleBackColor = false;
            btnFilterAll.Click += btnFilterAll_Click_1;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvExpenses);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 425);
            panel2.Name = "panel2";
            panel2.Size = new Size(1278, 429);
            panel2.TabIndex = 19;
            // 
            // dgvExpenses
            // 
            dgvExpenses.AllowUserToAddRows = false;
            dgvExpenses.AllowUserToResizeRows = false;
            dgvExpenses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvExpenses.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvExpenses.BackgroundColor = Color.White;
            dgvExpenses.BorderRadius = 15;
            dgvExpenses.BorderStyle = BorderStyle.None;
            dgvExpenses.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvExpenses.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(243, 244, 246);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(33, 37, 41);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(243, 244, 246);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(33, 37, 41);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvExpenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvExpenses.ColumnHeadersHeight = 50;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(240, 245, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvExpenses.DefaultCellStyle = dataGridViewCellStyle2;
            dgvExpenses.Dock = DockStyle.Fill;
            dgvExpenses.EnableHeadersVisualStyles = false;
            dgvExpenses.GridColor = Color.White;
            dgvExpenses.HeaderBackColor = Color.FromArgb(243, 244, 246);
            dgvExpenses.HeaderForeColor = Color.FromArgb(33, 37, 41);
            dgvExpenses.Location = new Point(0, 0);
            dgvExpenses.Margin = new Padding(4);
            dgvExpenses.MultiSelect = false;
            dgvExpenses.Name = "dgvExpenses";
            dgvExpenses.ReadOnly = true;
            dgvExpenses.RightToLeft = RightToLeft.Yes;
            dgvExpenses.RowHeadersVisible = false;
            dgvExpenses.RowHeadersWidth = 51;
            dgvExpenses.RowHeight = 50;
            dgvExpenses.RowTemplate.Height = 50;
            dgvExpenses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvExpenses.Size = new Size(1278, 429);
            dgvExpenses.TabIndex = 9;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Right;
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Location = new Point(754, 28);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.RightToLeft = RightToLeft.Yes;
            txtSearch.Size = new Size(471, 54);
            txtSearch.TabIndex = 15;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // ExpensesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1278, 854);
            Controls.Add(panel2);
            Controls.Add(statusCard4);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ExpensesForm";
            Text = "ExpensesForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            statusCard4.ResumeLayout(false);
            statusCard4.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvExpenses).EndInit();
            ResumeLayout(false);
        }

        private void dgvExpenses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label1;
        private CustomItems.RoundedButton btnOpenAdd;
        private TableLayoutPanel tableLayoutPanel1;
        private CustomItems.AdvancedStatusCard advancedStatusCard3;
        private CustomItems.AdvancedStatusCard advancedStatusCard1;
        private CustomItems.StatusCard statusCard4;
        private CustomItems.PillButton btnFilterSalaries;
        private CustomItems.PillButton btnFilterElectricity;
        private CustomItems.PillButton btnFilterMaintenance;
        private CustomItems.PillButton btnFilterAll;
        private Panel panel2;
        private CustomItems.CustomDataGridView dgvExpenses;
        private CustomItems.AdvancedStatusCard advancedStatusCard4;
        private TextBox txtSearch;
    }
}