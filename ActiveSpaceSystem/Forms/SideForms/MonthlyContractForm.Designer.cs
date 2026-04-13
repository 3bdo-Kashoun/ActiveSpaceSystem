namespace ActiveSpaceSystem.Forms.SideForms
{
    partial class MonthlyContractForm
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
            myGunaButton1 = new ActiveSpaceSystem.CustomItems.MyGunaButton();
            label3 = new Label();
            label1 = new Label();
            infoBox1 = new ActiveSpaceSystem.CustomItems.InfoBox();
            statusCard1 = new ActiveSpaceSystem.CustomItems.StatusCard();
            statusCard2 = new ActiveSpaceSystem.CustomItems.StatusCard();
            statusCard3 = new ActiveSpaceSystem.CustomItems.StatusCard();
            customDataGridView1 = new ActiveSpaceSystem.CustomItems.CustomDataGridView();
            NameColumn = new DataGridViewTextBoxColumn();
            PhoneNumberColumn = new DataGridViewTextBoxColumn();
            StadiumTypeColumn = new DataGridViewTextBoxColumn();
            StadiumColumn = new DataGridViewTextBoxColumn();
            DayColumn = new DataGridViewTextBoxColumn();
            TimeColumn = new DataGridViewTextBoxColumn();
            StartDateColumn = new DataGridViewTextBoxColumn();
            EndDateColumn = new DataGridViewTextBoxColumn();
            BalanceColumn = new DataGridViewTextBoxColumn();
            StateColumn = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)customDataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(myGunaButton1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1022, 125);
            panel1.TabIndex = 0;
            // 
            // myGunaButton1
            // 
            myGunaButton1.BackColor = Color.FromArgb(39, 191, 141);
            myGunaButton1.BorderRadius = 20;
            myGunaButton1.FlatAppearance.BorderSize = 0;
            myGunaButton1.FlatStyle = FlatStyle.Flat;
            myGunaButton1.Font = new Font("Tajawal", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            myGunaButton1.ForeColor = Color.White;
            myGunaButton1.HoverBackColor = Color.FromArgb(29, 53, 87);
            myGunaButton1.Location = new Point(50, 50);
            myGunaButton1.Name = "myGunaButton1";
            myGunaButton1.NormalBackColor = Color.FromArgb(39, 191, 141);
            myGunaButton1.Size = new Size(188, 47);
            myGunaButton1.TabIndex = 7;
            myGunaButton1.Text = "إضافة عقد جديد";
            myGunaButton1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tajawal", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(699, 84);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(275, 23);
            label3.TabIndex = 6;
            label3.Text = "إدارة الحجوزات المتكررة والعقود الدورية";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tajawal Medium", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(714, 26);
            label1.Name = "label1";
            label1.Size = new Size(260, 48);
            label1.TabIndex = 0;
            label1.Text = "العقود الشهرية";
            // 
            // infoBox1
            // 
            infoBox1.BackColor = Color.Transparent;
            infoBox1.BorderColor = Color.FromArgb(180, 210, 255);
            infoBox1.BorderRadius = 15;
            infoBox1.Description = "العقود الشهرية تتيح حجز موعد ثابت أسبوعياً لفترة محددة. مثلاً: حجز ملعب كرة القدم كل يوم سبت الساعة 6 مساءً لمدة 3 أشهر";
            infoBox1.DescriptionColor = Color.FromArgb(69, 123, 157);
            infoBox1.DescriptionFont = new Font("Tajawal", 9F);
            infoBox1.FillColor = Color.FromArgb(240, 248, 255);
            infoBox1.Icon = null;
            infoBox1.IconSize = 25;
            infoBox1.Location = new Point(50, 140);
            infoBox1.Name = "infoBox1";
            infoBox1.Size = new Size(924, 97);
            infoBox1.TabIndex = 1;
            infoBox1.Title = "ما هي العقود الشهرية؟";
            infoBox1.TitleColor = Color.FromArgb(29, 53, 87);
            infoBox1.TitleFont = new Font("Tajawal", 14F, FontStyle.Bold);
            // 
            // statusCard1
            // 
            statusCard1.BackColor = Color.Transparent;
            statusCard1.BorderColor = Color.FromArgb(240, 240, 240);
            statusCard1.BorderRadius = 15;
            statusCard1.CardBackColor = Color.White;
            statusCard1.Location = new Point(670, 258);
            statusCard1.Name = "statusCard1";
            statusCard1.Padding = new Padding(5);
            statusCard1.ShadowBlur = 5;
            statusCard1.ShadowColor = Color.FromArgb(100, 0, 0, 0);
            statusCard1.ShowShadow = true;
            statusCard1.Size = new Size(306, 106);
            statusCard1.TabIndex = 2;
            statusCard1.TitleColor = Color.Gray;
            statusCard1.TitleFont = new Font("Tajawal", 10F);
            statusCard1.TitleText = "العقود النشطة";
            statusCard1.ValueColor = Color.FromArgb(46, 204, 113);
            statusCard1.ValueFont = new Font("Tajawal", 18F, FontStyle.Bold);
            statusCard1.ValueText = "18";
            // 
            // statusCard2
            // 
            statusCard2.BackColor = Color.Transparent;
            statusCard2.BorderColor = Color.FromArgb(240, 240, 240);
            statusCard2.BorderRadius = 15;
            statusCard2.CardBackColor = Color.White;
            statusCard2.Location = new Point(358, 258);
            statusCard2.Name = "statusCard2";
            statusCard2.Padding = new Padding(5);
            statusCard2.ShadowBlur = 5;
            statusCard2.ShadowColor = Color.FromArgb(100, 0, 0, 0);
            statusCard2.ShowShadow = true;
            statusCard2.Size = new Size(306, 106);
            statusCard2.TabIndex = 3;
            statusCard2.TitleColor = Color.Gray;
            statusCard2.TitleFont = new Font("Tajawal", 10F);
            statusCard2.TitleText = "الإيرادات الشهرية المتوقعة";
            statusCard2.ValueColor = Color.FromArgb(30, 58, 138);
            statusCard2.ValueFont = new Font("Tajawal", 18F, FontStyle.Bold);
            statusCard2.ValueText = "15,200 د.ل";
            // 
            // statusCard3
            // 
            statusCard3.BackColor = Color.Transparent;
            statusCard3.BorderColor = Color.FromArgb(240, 240, 240);
            statusCard3.BorderRadius = 15;
            statusCard3.CardBackColor = Color.White;
            statusCard3.Location = new Point(46, 258);
            statusCard3.Name = "statusCard3";
            statusCard3.Padding = new Padding(5);
            statusCard3.ShadowBlur = 5;
            statusCard3.ShadowColor = Color.FromArgb(100, 0, 0, 0);
            statusCard3.ShowShadow = true;
            statusCard3.Size = new Size(306, 106);
            statusCard3.TabIndex = 4;
            statusCard3.TitleColor = Color.Gray;
            statusCard3.TitleFont = new Font("Tajawal", 10F);
            statusCard3.TitleText = "عقود تنتهي هذا الشهر";
            statusCard3.ValueColor = Color.FromArgb(245, 158, 11);
            statusCard3.ValueFont = new Font("Tajawal", 18F, FontStyle.Bold);
            statusCard3.ValueText = "3";
            // 
            // customDataGridView1
            // 
            customDataGridView1.AllowUserToAddRows = false;
            customDataGridView1.AllowUserToResizeRows = false;
            customDataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            customDataGridView1.BackgroundColor = Color.White;
            customDataGridView1.BorderRadius = 15;
            customDataGridView1.BorderStyle = BorderStyle.None;
            customDataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            customDataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(243, 244, 246);
            dataGridViewCellStyle1.Font = new Font("Tajawal", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(33, 37, 41);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            customDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            customDataGridView1.ColumnHeadersHeight = 50;
            customDataGridView1.Columns.AddRange(new DataGridViewColumn[] { NameColumn, PhoneNumberColumn, StadiumTypeColumn, StadiumColumn, DayColumn, TimeColumn, StartDateColumn, EndDateColumn, BalanceColumn, StateColumn });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(240, 245, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            customDataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            customDataGridView1.EnableHeadersVisualStyles = false;
            customDataGridView1.GridColor = Color.FromArgb(230, 230, 230);
            customDataGridView1.HeaderBackColor = Color.FromArgb(243, 244, 246);
            customDataGridView1.HeaderForeColor = Color.FromArgb(33, 37, 41);
            customDataGridView1.Location = new Point(50, 394);
            customDataGridView1.MultiSelect = false;
            customDataGridView1.Name = "customDataGridView1";
            customDataGridView1.RightToLeft = RightToLeft.Yes;
            customDataGridView1.RowHeadersVisible = false;
            customDataGridView1.RowHeadersWidth = 51;
            customDataGridView1.RowHeight = 50;
            customDataGridView1.RowTemplate.Height = 50;
            customDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            customDataGridView1.Size = new Size(924, 277);
            customDataGridView1.TabIndex = 5;
            // 
            // NameColumn
            // 
            NameColumn.HeaderText = "اسم العميل";
            NameColumn.MinimumWidth = 6;
            NameColumn.Name = "NameColumn";
            // 
            // PhoneNumberColumn
            // 
            PhoneNumberColumn.HeaderText = " رقم الهاتف";
            PhoneNumberColumn.MinimumWidth = 6;
            PhoneNumberColumn.Name = "PhoneNumberColumn";
            // 
            // StadiumTypeColumn
            // 
            StadiumTypeColumn.HeaderText = "نوع الملعب";
            StadiumTypeColumn.MinimumWidth = 6;
            StadiumTypeColumn.Name = "StadiumTypeColumn";
            // 
            // StadiumColumn
            // 
            StadiumColumn.HeaderText = "الملعب";
            StadiumColumn.MinimumWidth = 6;
            StadiumColumn.Name = "StadiumColumn";
            // 
            // DayColumn
            // 
            DayColumn.HeaderText = "اليوم";
            DayColumn.MinimumWidth = 6;
            DayColumn.Name = "DayColumn";
            // 
            // TimeColumn
            // 
            TimeColumn.HeaderText = "الوقت";
            TimeColumn.MinimumWidth = 6;
            TimeColumn.Name = "TimeColumn";
            // 
            // StartDateColumn
            // 
            StartDateColumn.HeaderText = "تاريخ البداية";
            StartDateColumn.MinimumWidth = 6;
            StartDateColumn.Name = "StartDateColumn";
            // 
            // EndDateColumn
            // 
            EndDateColumn.HeaderText = "تاريخ النهاية";
            EndDateColumn.MinimumWidth = 6;
            EndDateColumn.Name = "EndDateColumn";
            // 
            // BalanceColumn
            // 
            BalanceColumn.HeaderText = "المبلغ";
            BalanceColumn.MinimumWidth = 6;
            BalanceColumn.Name = "BalanceColumn";
            // 
            // StateColumn
            // 
            StateColumn.HeaderText = "الحالة";
            StateColumn.MinimumWidth = 6;
            StateColumn.Name = "StateColumn";
            // 
            // MonthlyContractForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(1022, 683);
            Controls.Add(customDataGridView1);
            Controls.Add(statusCard3);
            Controls.Add(statusCard2);
            Controls.Add(statusCard1);
            Controls.Add(infoBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MonthlyContractForm";
            Text = "MonthlyContractForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)customDataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private CustomItems.MyGunaButton myGunaButton1;
        private Label label3;
        private CustomItems.InfoBox infoBox1;
        private CustomItems.StatusCard statusCard1;
        private CustomItems.StatusCard statusCard2;
        private CustomItems.StatusCard statusCard3;
        private CustomItems.CustomDataGridView customDataGridView1;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn PhoneNumberColumn;
        private DataGridViewTextBoxColumn StadiumTypeColumn;
        private DataGridViewTextBoxColumn StadiumColumn;
        private DataGridViewTextBoxColumn DayColumn;
        private DataGridViewTextBoxColumn TimeColumn;
        private DataGridViewTextBoxColumn StartDateColumn;
        private DataGridViewTextBoxColumn EndDateColumn;
        private DataGridViewTextBoxColumn BalanceColumn;
        private DataGridViewTextBoxColumn StateColumn;
    }
}