
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
            roundedButton1 = new ActiveSpaceSystem.CustomItems.RoundedButton();
            label3 = new Label();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            advancedStatusCard4 = new ActiveSpaceSystem.CustomItems.AdvancedStatusCard();
            advancedStatusCard3 = new ActiveSpaceSystem.CustomItems.AdvancedStatusCard();
            advancedStatusCard2 = new ActiveSpaceSystem.CustomItems.AdvancedStatusCard();
            advancedStatusCard1 = new ActiveSpaceSystem.CustomItems.AdvancedStatusCard();
            statusCard4 = new ActiveSpaceSystem.CustomItems.StatusCard();
            txtSearch = new ActiveSpaceSystem.CustomItems.AbdulTextBox();
            pillButton4 = new ActiveSpaceSystem.CustomItems.PillButton();
            pillButton3 = new ActiveSpaceSystem.CustomItems.PillButton();
            pillButton2 = new ActiveSpaceSystem.CustomItems.PillButton();
            pillButton1 = new ActiveSpaceSystem.CustomItems.PillButton();
            panel2 = new Panel();
            dgvExpenses = new ActiveSpaceSystem.CustomItems.CustomDataGridView();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            statusCard4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExpenses).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(roundedButton1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1278, 150);
            panel1.TabIndex = 0;
            // 
            // roundedButton1
            // 
            roundedButton1.Anchor = AnchorStyles.Left;
            roundedButton1.BackColor = Color.FromArgb(38, 191, 141);
            roundedButton1.BorderColor = Color.PaleVioletRed;
            roundedButton1.BorderRadius = 15;
            roundedButton1.BorderSize = 0;
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedButton1.ForeColor = Color.White;
            roundedButton1.Image = Properties.Resources.icons8_add_50__1_;
            roundedButton1.ImageAlign = ContentAlignment.MiddleRight;
            roundedButton1.Location = new Point(45, 44);
            roundedButton1.Margin = new Padding(4);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Padding = new Padding(25, 12, 25, 12);
            roundedButton1.Size = new Size(285, 80);
            roundedButton1.TabIndex = 12;
            roundedButton1.Text = "إضافة مصروف جديد";
            roundedButton1.TextAlign = ContentAlignment.MiddleLeft;
            roundedButton1.UseVisualStyleBackColor = false;
            roundedButton1.Click += roundedButton1_Click;
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
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(advancedStatusCard4, 3, 0);
            tableLayoutPanel1.Controls.Add(advancedStatusCard3, 2, 0);
            tableLayoutPanel1.Controls.Add(advancedStatusCard2, 1, 0);
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
            advancedStatusCard4.Location = new Point(961, 4);
            advancedStatusCard4.Margin = new Padding(4);
            advancedStatusCard4.Name = "advancedStatusCard4";
            advancedStatusCard4.Padding = new Padding(12);
            advancedStatusCard4.ShadowSize = 1;
            advancedStatusCard4.Size = new Size(313, 151);
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
            advancedStatusCard3.Location = new Point(642, 4);
            advancedStatusCard3.Margin = new Padding(4);
            advancedStatusCard3.Name = "advancedStatusCard3";
            advancedStatusCard3.Padding = new Padding(12);
            advancedStatusCard3.ShadowSize = 1;
            advancedStatusCard3.Size = new Size(311, 151);
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
            // advancedStatusCard2
            // 
            advancedStatusCard2.BackColor = Color.White;
            advancedStatusCard2.BorderRadius = 20;
            advancedStatusCard2.CardIcon = Properties.Resources.icons8_alert_50__1_;
            advancedStatusCard2.Dock = DockStyle.Fill;
            advancedStatusCard2.IconBackColor = Color.SandyBrown;
            advancedStatusCard2.Location = new Point(323, 4);
            advancedStatusCard2.Margin = new Padding(4);
            advancedStatusCard2.Name = "advancedStatusCard2";
            advancedStatusCard2.Padding = new Padding(12);
            advancedStatusCard2.ShadowSize = 1;
            advancedStatusCard2.Size = new Size(311, 151);
            advancedStatusCard2.SubValueColor = Color.Gray;
            advancedStatusCard2.SubValueFont = new Font("Tajawal", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            advancedStatusCard2.SubValueText = "";
            advancedStatusCard2.TabIndex = 15;
            advancedStatusCard2.TitleColor = Color.Gray;
            advancedStatusCard2.TitleFont = new Font("Tajawal Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            advancedStatusCard2.TitleText = "مصروفات معلقة";
            advancedStatusCard2.ValueColor = Color.SandyBrown;
            advancedStatusCard2.ValueFont = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            advancedStatusCard2.ValueText = "١٧٬٥٨٠ د.ل";
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
            advancedStatusCard1.Size = new Size(311, 151);
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
            statusCard4.Controls.Add(pillButton4);
            statusCard4.Controls.Add(pillButton3);
            statusCard4.Controls.Add(pillButton2);
            statusCard4.Controls.Add(pillButton1);
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
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Right;
            txtSearch.BackColor = Color.White;
            txtSearch.BorderColor = Color.FromArgb(29, 53, 87);
            txtSearch.BorderRadius = 15;
            txtSearch.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Icon = Properties.Resources.magnifying_glass;
            txtSearch.IconLocation = HorizontalAlignment.Right;
            txtSearch.IconSize = 30;
            txtSearch.Location = new Point(745, 28);
            txtSearch.Margin = new Padding(2);
            txtSearch.Name = "txtSearch";
            txtSearch.passwordChar = "\0";
            txtSearch.PlaceholderText = "بحث عن رقم هاتف";
            txtSearch.RightToLeft = RightToLeft.Yes;
            txtSearch.Size = new Size(481, 54);
            txtSearch.TabIndex = 14;
            txtSearch.Texts = "";
            // 
            // pillButton4
            // 
            pillButton4.BackColor = Color.White;
            pillButton4.BackgroundImageLayout = ImageLayout.None;
            pillButton4.Checked = false;
            pillButton4.CheckedBackColor = Color.FromArgb(41, 51, 146);
            pillButton4.CheckedForeColor = Color.White;
            pillButton4.FlatAppearance.BorderSize = 0;
            pillButton4.FlatStyle = FlatStyle.Flat;
            pillButton4.Font = new Font("Tajawal Medium", 10.2F, FontStyle.Bold);
            pillButton4.ForeColor = Color.FromArgb(64, 64, 64);
            pillButton4.GroupName = "";
            pillButton4.Location = new Point(45, 28);
            pillButton4.Margin = new Padding(2);
            pillButton4.Name = "pillButton4";
            pillButton4.Radius = 10;
            pillButton4.Size = new Size(178, 54);
            pillButton4.TabIndex = 11;
            pillButton4.Text = "رواتب الموظفين";
            pillButton4.UncheckedBackColor = Color.FromArgb(242, 242, 242);
            pillButton4.UncheckedForeColor = Color.FromArgb(64, 64, 64);
            pillButton4.UseVisualStyleBackColor = false;
            // 
            // pillButton3
            // 
            pillButton3.BackColor = Color.White;
            pillButton3.BackgroundImageLayout = ImageLayout.None;
            pillButton3.Checked = false;
            pillButton3.CheckedBackColor = Color.FromArgb(41, 51, 146);
            pillButton3.CheckedForeColor = Color.White;
            pillButton3.FlatAppearance.BorderSize = 0;
            pillButton3.FlatStyle = FlatStyle.Flat;
            pillButton3.Font = new Font("Tajawal Medium", 10.2F, FontStyle.Bold);
            pillButton3.ForeColor = Color.FromArgb(64, 64, 64);
            pillButton3.GroupName = "";
            pillButton3.Location = new Point(245, 28);
            pillButton3.Margin = new Padding(2);
            pillButton3.Name = "pillButton3";
            pillButton3.Radius = 10;
            pillButton3.Size = new Size(112, 54);
            pillButton3.TabIndex = 10;
            pillButton3.Text = "كهرباء";
            pillButton3.UncheckedBackColor = Color.FromArgb(242, 242, 242);
            pillButton3.UncheckedForeColor = Color.FromArgb(64, 64, 64);
            pillButton3.UseVisualStyleBackColor = false;
            // 
            // pillButton2
            // 
            pillButton2.BackColor = Color.White;
            pillButton2.BackgroundImageLayout = ImageLayout.None;
            pillButton2.Checked = false;
            pillButton2.CheckedBackColor = Color.FromArgb(41, 51, 146);
            pillButton2.CheckedForeColor = Color.White;
            pillButton2.FlatAppearance.BorderSize = 0;
            pillButton2.FlatStyle = FlatStyle.Flat;
            pillButton2.Font = new Font("Tajawal Medium", 10.2F, FontStyle.Bold);
            pillButton2.ForeColor = Color.FromArgb(64, 64, 64);
            pillButton2.GroupName = "";
            pillButton2.Location = new Point(379, 28);
            pillButton2.Margin = new Padding(2);
            pillButton2.Name = "pillButton2";
            pillButton2.Radius = 10;
            pillButton2.Size = new Size(163, 54);
            pillButton2.TabIndex = 9;
            pillButton2.Text = " صيانة الملاعب";
            pillButton2.UncheckedBackColor = Color.FromArgb(242, 242, 242);
            pillButton2.UncheckedForeColor = Color.FromArgb(64, 64, 64);
            pillButton2.UseVisualStyleBackColor = false;
            // 
            // pillButton1
            // 
            pillButton1.BackColor = Color.White;
            pillButton1.BackgroundImageLayout = ImageLayout.None;
            pillButton1.Checked = true;
            pillButton1.CheckedBackColor = Color.FromArgb(41, 51, 146);
            pillButton1.CheckedForeColor = Color.White;
            pillButton1.FlatAppearance.BorderSize = 0;
            pillButton1.FlatStyle = FlatStyle.Flat;
            pillButton1.Font = new Font("Tajawal Medium", 10.2F, FontStyle.Bold);
            pillButton1.ForeColor = Color.FromArgb(64, 64, 64);
            pillButton1.GroupName = "";
            pillButton1.Location = new Point(564, 28);
            pillButton1.Margin = new Padding(2);
            pillButton1.Name = "pillButton1";
            pillButton1.Radius = 10;
            pillButton1.Size = new Size(112, 54);
            pillButton1.TabIndex = 8;
            pillButton1.Text = "الكل ";
            pillButton1.UncheckedBackColor = Color.FromArgb(242, 242, 242);
            pillButton1.UncheckedForeColor = Color.FromArgb(64, 64, 64);
            pillButton1.UseVisualStyleBackColor = false;
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
            dgvExpenses.RowHeadersVisible = false;
            dgvExpenses.RowHeadersWidth = 51;
            dgvExpenses.RowHeight = 50;
            dgvExpenses.RowTemplate.Height = 50;
            dgvExpenses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvExpenses.Size = new Size(1278, 429);
            dgvExpenses.TabIndex = 10;
            dgvExpenses.CellContentClick += dgvExpenses_CellContentClick;
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
            Load += ExpensesForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            statusCard4.ResumeLayout(false);
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
        private CustomItems.RoundedButton roundedButton1;
        private TableLayoutPanel tableLayoutPanel1;
        private CustomItems.AdvancedStatusCard advancedStatusCard4;
        private CustomItems.AdvancedStatusCard advancedStatusCard3;
        private CustomItems.AdvancedStatusCard advancedStatusCard2;
        private CustomItems.AdvancedStatusCard advancedStatusCard1;
        private CustomItems.StatusCard statusCard4;
        private CustomItems.PillButton pillButton4;
        private CustomItems.PillButton pillButton3;
        private CustomItems.PillButton pillButton2;
        private CustomItems.PillButton pillButton1;
        private CustomItems.AbdulTextBox txtSearch;
        private Panel panel2;
        private CustomItems.CustomDataGridView dgvExpenses;
    }
}