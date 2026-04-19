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
            dgvReservation = new ActiveSpaceSystem.CustomItems.CustomDataGridView();
            bookingDetailsCard = new ActiveSpaceSystem.CustomItems.BookingDetailsCard();
            ((System.ComponentModel.ISupportInitialize)dgvReservation).BeginInit();
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
            advancedStatusCard1.CardIcon = Properties.Resources.icons8_money_50__1___2_;
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
            advancedStatusCard1.ValueText = "12,450 د.ل";
            // 
            // advancedStatusCard2
            // 
            advancedStatusCard2.BackColor = Color.White;
            advancedStatusCard2.BorderRadius = 20;
            advancedStatusCard2.CardIcon = Properties.Resources.icons8_alert_50__1_;
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
            advancedStatusCard2.ValueText = "3,290 د.ل";
            // 
            // advancedStatusCard3
            // 
            advancedStatusCard3.BackColor = Color.White;
            advancedStatusCard3.BorderRadius = 20;
            advancedStatusCard3.CardIcon = Properties.Resources.icons8_bank_approved_48;
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
            advancedStatusCard3.ValueText = "5,650 د.ل";
            // 
            // dgvReservation
            // 
            dgvReservation.AllowUserToAddRows = false;
            dgvReservation.AllowUserToResizeRows = false;
            dgvReservation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReservation.BackgroundColor = Color.White;
            dgvReservation.BorderRadius = 15;
            dgvReservation.BorderStyle = BorderStyle.None;
            dgvReservation.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvReservation.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(243, 244, 246);
            dataGridViewCellStyle1.Font = new Font("Tajawal Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(33, 37, 41);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(243, 244, 246);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(33, 37, 41);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvReservation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvReservation.ColumnHeadersHeight = 50;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Tajawal", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(240, 245, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvReservation.DefaultCellStyle = dataGridViewCellStyle2;
            dgvReservation.EnableHeadersVisualStyles = false;
            dgvReservation.GridColor = Color.FromArgb(230, 230, 230);
            dgvReservation.HeaderBackColor = Color.FromArgb(243, 244, 246);
            dgvReservation.HeaderForeColor = Color.FromArgb(33, 37, 41);
            dgvReservation.Location = new Point(341, 345);
            dgvReservation.MultiSelect = false;
            dgvReservation.Name = "dgvReservation";
            dgvReservation.RightToLeft = RightToLeft.Yes;
            dgvReservation.RowHeadersVisible = false;
            dgvReservation.RowHeadersWidth = 51;
            dgvReservation.RowHeight = 50;
            dgvReservation.RowTemplate.Height = 50;
            dgvReservation.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReservation.Size = new Size(653, 583);
            dgvReservation.TabIndex = 11;
            dgvReservation.CellContentClick += dgvReservation_CellContentClick;
            dgvReservation.CellPainting += dgvReservation_CellPainting;
            // 
            // bookingDetailsCard
            // 
            bookingDetailsCard.BackColor = Color.White;
            bookingDetailsCard.BookingID = "B-2026-001";
            bookingDetailsCard.ButtonBorderRadius = 12;
            bookingDetailsCard.CardBorderRadius = 20;
            bookingDetailsCard.CustomerName = "أحمد محمد علي";
            bookingDetailsCard.DataFont = new Font("Tajawal", 12F, FontStyle.Bold);
            bookingDetailsCard.DepositAmount = "100 ر.س";
            bookingDetailsCard.IsItemSelected = false;
            bookingDetailsCard.LabelsFont = new Font("Tajawal", 10F);
            bookingDetailsCard.Location = new Point(12, 345);
            bookingDetailsCard.Name = "bookingDetailsCard";
            bookingDetailsCard.PaidAmount = "100 ر.س";
            bookingDetailsCard.PhoneNumber = "0501234567";
            bookingDetailsCard.PrimaryColor = Color.FromArgb(46, 204, 113);
            bookingDetailsCard.RemainingAmount = "200 ر.س";
            bookingDetailsCard.RemainingColor = Color.Red;
            bookingDetailsCard.Size = new Size(298, 583);
            bookingDetailsCard.TabIndex = 12;
            bookingDetailsCard.TotalAmount = "300 ر.س";
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(1022, 683);
            Controls.Add(bookingDetailsCard);
            Controls.Add(dgvReservation);
            Controls.Add(advancedStatusCard3);
            Controls.Add(advancedStatusCard2);
            Controls.Add(advancedStatusCard1);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PaymentForm";
            Text = "PaymentForm";
            Load += PaymentForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReservation).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private CustomItems.AdvancedStatusCard advancedStatusCard1;
        private CustomItems.AdvancedStatusCard advancedStatusCard2;
        private CustomItems.AdvancedStatusCard advancedStatusCard3;
        private CustomItems.CustomDataGridView dgvReservation;
        private CustomItems.BookingDetailsCard bookingDetailsCard;
    }
}