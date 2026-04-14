namespace ActiveSpaceSystem.Forms.SideForms
{
    partial class PaymentForm
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
            label1 = new Label();
            label3 = new Label();
            advancedStatusCard1 = new ActiveSpaceSystem.CustomItems.AdvancedStatusCard();
            advancedStatusCard2 = new ActiveSpaceSystem.CustomItems.AdvancedStatusCard();
            advancedStatusCard3 = new ActiveSpaceSystem.CustomItems.AdvancedStatusCard();
            customDataGridView1 = new ActiveSpaceSystem.CustomItems.CustomDataGridView();
            NameColumn = new DataGridViewTextBoxColumn();
            PhoneNumberColumn = new DataGridViewTextBoxColumn();
            StadiumTypeColumn = new DataGridViewTextBoxColumn();
            StadiumColumn = new DataGridViewTextBoxColumn();
            DayColumn = new DataGridViewTextBoxColumn();
            TimeColumn = new DataGridViewTextBoxColumn();
            StartDateColumn = new DataGridViewTextBoxColumn();
            EndDateColumn = new DataGridViewTextBoxColumn();
            bookingDetailsCard1 = new ActiveSpaceSystem.CustomItems.BookingDetailsCard();
            ((System.ComponentModel.ISupportInitialize)customDataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tajawal Medium", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(636, 25);
            label1.Name = "label1";
            label1.Size = new Size(358, 48);
            label1.TabIndex = 1;
            label1.Text = "المدفوعات والحسابات";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tajawal", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(741, 73);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(234, 23);
            label3.TabIndex = 7;
            label3.Text = "إدارة ومتابعة المدفوعات والديون";
            // 
            // advancedStatusCard1
            // 
            advancedStatusCard1.BackColor = Color.White;
            advancedStatusCard1.BorderRadius = 20;
            advancedStatusCard1.CardIcon = null;
            advancedStatusCard1.IconBackColor = Color.FromArgb(46, 204, 113);
            advancedStatusCard1.Location = new Point(672, 133);
            advancedStatusCard1.Name = "advancedStatusCard1";
            advancedStatusCard1.Padding = new Padding(10);
            advancedStatusCard1.ShadowSize = 1;
            advancedStatusCard1.Size = new Size(322, 124);
            advancedStatusCard1.SubValueColor = Color.FromArgb(46, 204, 113);
            advancedStatusCard1.SubValueFont = new Font("Tajawal", 9F);
            advancedStatusCard1.SubValueText = "+12% منذ الأمس";
            advancedStatusCard1.TabIndex = 8;
            advancedStatusCard1.TitleColor = Color.Gray;
            advancedStatusCard1.TitleFont = new Font("Tajawal", 10F);
            advancedStatusCard1.TitleText = "إجمالي الإيرادات اليوم";
            advancedStatusCard1.ValueColor = Color.FromArgb(46, 204, 113);
            advancedStatusCard1.ValueFont = new Font("Tajawal", 16F, FontStyle.Bold);
            advancedStatusCard1.ValueText = "12,450 ر.س";
            // 
            // advancedStatusCard2
            // 
            advancedStatusCard2.BackColor = Color.White;
            advancedStatusCard2.BorderRadius = 20;
            advancedStatusCard2.CardIcon = null;
            advancedStatusCard2.IconBackColor = Color.FromArgb(220, 38, 38);
            advancedStatusCard2.Location = new Point(342, 133);
            advancedStatusCard2.Name = "advancedStatusCard2";
            advancedStatusCard2.Padding = new Padding(10);
            advancedStatusCard2.ShadowSize = 1;
            advancedStatusCard2.Size = new Size(322, 124);
            advancedStatusCard2.SubValueColor = Color.Gray;
            advancedStatusCard2.SubValueFont = new Font("Tajawal", 9F);
            advancedStatusCard2.SubValueText = "15 حجز";
            advancedStatusCard2.TabIndex = 9;
            advancedStatusCard2.TitleColor = Color.Gray;
            advancedStatusCard2.TitleFont = new Font("Tajawal", 10F);
            advancedStatusCard2.TitleText = "إجمالي الديون";
            advancedStatusCard2.ValueColor = Color.FromArgb(220, 38, 38);
            advancedStatusCard2.ValueFont = new Font("Tajawal", 16F, FontStyle.Bold);
            advancedStatusCard2.ValueText = "12,450 ر.س";
            // 
            // advancedStatusCard3
            // 
            advancedStatusCard3.BackColor = Color.White;
            advancedStatusCard3.BorderRadius = 20;
            advancedStatusCard3.CardIcon = null;
            advancedStatusCard3.IconBackColor = Color.FromArgb(43, 127, 255);
            advancedStatusCard3.Location = new Point(12, 133);
            advancedStatusCard3.Name = "advancedStatusCard3";
            advancedStatusCard3.Padding = new Padding(10);
            advancedStatusCard3.ShadowSize = 1;
            advancedStatusCard3.Size = new Size(322, 124);
            advancedStatusCard3.SubValueColor = Color.Gray;
            advancedStatusCard3.SubValueFont = new Font("Tajawal", 9F);
            advancedStatusCard3.SubValueText = "اليوم";
            advancedStatusCard3.TabIndex = 10;
            advancedStatusCard3.TitleColor = Color.Gray;
            advancedStatusCard3.TitleFont = new Font("Tajawal", 10F);
            advancedStatusCard3.TitleText = "العربون المحصل";
            advancedStatusCard3.ValueColor = Color.FromArgb(43, 127, 255);
            advancedStatusCard3.ValueFont = new Font("Tajawal", 16F, FontStyle.Bold);
            advancedStatusCard3.ValueText = "12,450 ر.س";
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
            customDataGridView1.Columns.AddRange(new DataGridViewColumn[] { NameColumn, PhoneNumberColumn, StadiumTypeColumn, StadiumColumn, DayColumn, TimeColumn, StartDateColumn, EndDateColumn });
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
            customDataGridView1.Location = new Point(341, 345);
            customDataGridView1.MultiSelect = false;
            customDataGridView1.Name = "customDataGridView1";
            customDataGridView1.RightToLeft = RightToLeft.Yes;
            customDataGridView1.RowHeadersVisible = false;
            customDataGridView1.RowHeadersWidth = 51;
            customDataGridView1.RowHeight = 50;
            customDataGridView1.RowTemplate.Height = 50;
            customDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            customDataGridView1.Size = new Size(653, 583);
            customDataGridView1.TabIndex = 11;
            // 
            // NameColumn
            // 
            NameColumn.HeaderText = "رقم الحجز";
            NameColumn.MinimumWidth = 6;
            NameColumn.Name = "NameColumn";
            // 
            // PhoneNumberColumn
            // 
            PhoneNumberColumn.HeaderText = "العميل";
            PhoneNumberColumn.MinimumWidth = 6;
            PhoneNumberColumn.Name = "PhoneNumberColumn";
            // 
            // StadiumTypeColumn
            // 
            StadiumTypeColumn.HeaderText = "التاريخ";
            StadiumTypeColumn.MinimumWidth = 6;
            StadiumTypeColumn.Name = "StadiumTypeColumn";
            // 
            // StadiumColumn
            // 
            StadiumColumn.HeaderText = "المبلغ الكلي";
            StadiumColumn.MinimumWidth = 6;
            StadiumColumn.Name = "StadiumColumn";
            // 
            // DayColumn
            // 
            DayColumn.HeaderText = "المدفوع";
            DayColumn.MinimumWidth = 6;
            DayColumn.Name = "DayColumn";
            // 
            // TimeColumn
            // 
            TimeColumn.HeaderText = "المتبقي";
            TimeColumn.MinimumWidth = 6;
            TimeColumn.Name = "TimeColumn";
            // 
            // StartDateColumn
            // 
            StartDateColumn.HeaderText = "الحالة";
            StartDateColumn.MinimumWidth = 6;
            StartDateColumn.Name = "StartDateColumn";
            // 
            // EndDateColumn
            // 
            EndDateColumn.HeaderText = "الإجراء";
            EndDateColumn.MinimumWidth = 6;
            EndDateColumn.Name = "EndDateColumn";
            // 
            // bookingDetailsCard1
            // 
            bookingDetailsCard1.BackColor = Color.White;
            bookingDetailsCard1.BookingID = "B-2026-001";
            bookingDetailsCard1.ButtonBorderRadius = 12;
            bookingDetailsCard1.CardBorderRadius = 20;
            bookingDetailsCard1.CustomerName = "أحمد محمد علي";
            bookingDetailsCard1.DataFont = new Font("Tajawal", 12F, FontStyle.Bold);
            bookingDetailsCard1.DepositAmount = "100 ر.س";
            bookingDetailsCard1.IsItemSelected = true;
            bookingDetailsCard1.LabelsFont = new Font("Tajawal", 10F);
            bookingDetailsCard1.Location = new Point(12, 345);
            bookingDetailsCard1.Name = "bookingDetailsCard1";
            bookingDetailsCard1.PaidAmount = "100 ر.س";
            bookingDetailsCard1.PhoneNumber = "0501234567";
            bookingDetailsCard1.PrimaryColor = Color.FromArgb(46, 204, 113);
            bookingDetailsCard1.RemainingAmount = "200 ر.س";
            bookingDetailsCard1.RemainingColor = Color.Red;
            bookingDetailsCard1.Size = new Size(298, 583);
            bookingDetailsCard1.TabIndex = 12;
            bookingDetailsCard1.TotalAmount = "300 ر.س";
            bookingDetailsCard1.Paint += bookingDetailsCard1_Paint;
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(1022, 683);
            Controls.Add(bookingDetailsCard1);
            Controls.Add(customDataGridView1);
            Controls.Add(advancedStatusCard3);
            Controls.Add(advancedStatusCard2);
            Controls.Add(advancedStatusCard1);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PaymentForm";
            Text = "PaymentForm";
            ((System.ComponentModel.ISupportInitialize)customDataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private CustomItems.AdvancedStatusCard advancedStatusCard1;
        private CustomItems.AdvancedStatusCard advancedStatusCard2;
        private CustomItems.AdvancedStatusCard advancedStatusCard3;
        private CustomItems.CustomDataGridView customDataGridView1;
        private CustomItems.BookingDetailsCard bookingDetailsCard1;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn PhoneNumberColumn;
        private DataGridViewTextBoxColumn StadiumTypeColumn;
        private DataGridViewTextBoxColumn StadiumColumn;
        private DataGridViewTextBoxColumn DayColumn;
        private DataGridViewTextBoxColumn TimeColumn;
        private DataGridViewTextBoxColumn StartDateColumn;
        private DataGridViewTextBoxColumn EndDateColumn;
    }
}