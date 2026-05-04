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
            panel1 = new Panel();
            label3 = new Label();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            advancedStatusCard1 = new ActiveSpaceSystem.CustomItems.AdvancedStatusCard();
            advancedStatusCard2 = new ActiveSpaceSystem.CustomItems.AdvancedStatusCard();
            tableLayoutPanel2 = new TableLayoutPanel();
            bookingDetailsCard = new ActiveSpaceSystem.CustomItems.BookingDetailsCard();
            advancedStatusCard3 = new ActiveSpaceSystem.CustomItems.AdvancedStatusCard();
            dgvReservation = new ActiveSpaceSystem.CustomItems.CustomDataGridView();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReservation).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1330, 150);
            panel1.TabIndex = 13;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(1083, 89);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(234, 25);
            label3.TabIndex = 9;
            label3.Text = "إدارة ومتابعة المدفوعات والديون";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(992, 21);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(325, 46);
            label1.TabIndex = 8;
            label1.Text = "المدفوعات والحسابات";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(advancedStatusCard3, 2, 0);
            tableLayoutPanel1.Controls.Add(advancedStatusCard2, 1, 0);
            tableLayoutPanel1.Controls.Add(advancedStatusCard1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 150);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1330, 159);
            tableLayoutPanel1.TabIndex = 16;
            // 
            // advancedStatusCard1
            // 
            advancedStatusCard1.BackColor = Color.White;
            advancedStatusCard1.BorderRadius = 20;
            advancedStatusCard1.CardIcon = Properties.Resources.icons8_money_50__1___2_;
            advancedStatusCard1.Dock = DockStyle.Fill;
            advancedStatusCard1.IconBackColor = Color.FromArgb(46, 204, 113);
            advancedStatusCard1.Location = new Point(891, 4);
            advancedStatusCard1.Margin = new Padding(4);
            advancedStatusCard1.Name = "advancedStatusCard1";
            advancedStatusCard1.Padding = new Padding(12);
            advancedStatusCard1.ShadowSize = 1;
            advancedStatusCard1.Size = new Size(435, 151);
            advancedStatusCard1.SubValueColor = Color.FromArgb(46, 204, 113);
            advancedStatusCard1.SubValueFont = new Font("Microsoft Sans Serif", 9F);
            advancedStatusCard1.SubValueText = "+12% منذ الأمس";
            advancedStatusCard1.TabIndex = 16;
            advancedStatusCard1.TitleColor = Color.Gray;
            advancedStatusCard1.TitleFont = new Font("Microsoft Sans Serif", 10F);
            advancedStatusCard1.TitleText = "إجمالي الإيرادات اليوم";
            advancedStatusCard1.ValueColor = Color.FromArgb(46, 204, 113);
            advancedStatusCard1.ValueFont = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            advancedStatusCard1.ValueText = "12,450 د.ل";
            // 
            // advancedStatusCard2
            // 
            advancedStatusCard2.BackColor = Color.White;
            advancedStatusCard2.BorderRadius = 20;
            advancedStatusCard2.CardIcon = Properties.Resources.icons8_alert_50__1_;
            advancedStatusCard2.Dock = DockStyle.Fill;
            advancedStatusCard2.IconBackColor = Color.FromArgb(220, 38, 38);
            advancedStatusCard2.Location = new Point(448, 4);
            advancedStatusCard2.Margin = new Padding(4);
            advancedStatusCard2.Name = "advancedStatusCard2";
            advancedStatusCard2.Padding = new Padding(12);
            advancedStatusCard2.ShadowSize = 1;
            advancedStatusCard2.Size = new Size(435, 151);
            advancedStatusCard2.SubValueColor = Color.Gray;
            advancedStatusCard2.SubValueFont = new Font("Microsoft Sans Serif", 9F);
            advancedStatusCard2.SubValueText = "15 حجز";
            advancedStatusCard2.TabIndex = 15;
            advancedStatusCard2.TitleColor = Color.Gray;
            advancedStatusCard2.TitleFont = new Font("Microsoft Sans Serif", 10F);
            advancedStatusCard2.TitleText = "إجمالي الديون";
            advancedStatusCard2.ValueColor = Color.FromArgb(220, 38, 38);
            advancedStatusCard2.ValueFont = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            advancedStatusCard2.ValueText = "3,290 د.ل";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.Controls.Add(dgvReservation, 0, 0);
            tableLayoutPanel2.Controls.Add(bookingDetailsCard, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 309);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1330, 545);
            tableLayoutPanel2.TabIndex = 17;
            // 
            // bookingDetailsCard
            // 
            bookingDetailsCard.BackColor = Color.White;
            bookingDetailsCard.BookingID = "B-2026-001";
            bookingDetailsCard.ButtonBorderRadius = 12;
            bookingDetailsCard.CardBorderRadius = 20;
            bookingDetailsCard.CustomerName = "أحمد محمد علي";
            bookingDetailsCard.DataFont = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            bookingDetailsCard.DepositAmount = "100 ر.س";
            bookingDetailsCard.Dock = DockStyle.Fill;
            bookingDetailsCard.IsItemSelected = false;
            bookingDetailsCard.LabelsFont = new Font("Microsoft Sans Serif", 10F);
            bookingDetailsCard.Location = new Point(4, 4);
            bookingDetailsCard.Margin = new Padding(4);
            bookingDetailsCard.Name = "bookingDetailsCard";
            bookingDetailsCard.PaidAmount = "100 ر.س";
            bookingDetailsCard.PhoneNumber = "0501234567";
            bookingDetailsCard.PrimaryColor = Color.FromArgb(46, 204, 113);
            bookingDetailsCard.RemainingAmount = "200 ر.س";
            bookingDetailsCard.RemainingColor = Color.Red;
            bookingDetailsCard.Size = new Size(391, 537);
            bookingDetailsCard.TabIndex = 23;
            bookingDetailsCard.TotalAmount = "300 ر.س";
            // 
            // advancedStatusCard3
            // 
            advancedStatusCard3.BackColor = Color.White;
            advancedStatusCard3.BorderRadius = 20;
            advancedStatusCard3.CardIcon = Properties.Resources.icons8_bank_approved_48;
            advancedStatusCard3.Dock = DockStyle.Fill;
            advancedStatusCard3.IconBackColor = Color.FromArgb(43, 127, 255);
            advancedStatusCard3.Location = new Point(4, 4);
            advancedStatusCard3.Margin = new Padding(4);
            advancedStatusCard3.Name = "advancedStatusCard3";
            advancedStatusCard3.Padding = new Padding(12);
            advancedStatusCard3.ShadowSize = 1;
            advancedStatusCard3.Size = new Size(436, 151);
            advancedStatusCard3.SubValueColor = Color.Gray;
            advancedStatusCard3.SubValueFont = new Font("Microsoft Sans Serif", 9F);
            advancedStatusCard3.SubValueText = "اليوم";
            advancedStatusCard3.TabIndex = 18;
            advancedStatusCard3.TitleColor = Color.Gray;
            advancedStatusCard3.TitleFont = new Font("Microsoft Sans Serif", 10F);
            advancedStatusCard3.TitleText = "العربون المحصل";
            advancedStatusCard3.ValueColor = Color.FromArgb(43, 127, 255);
            advancedStatusCard3.ValueFont = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
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
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(33, 37, 41);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(243, 244, 246);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(33, 37, 41);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvReservation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvReservation.ColumnHeadersHeight = 50;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(240, 245, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvReservation.DefaultCellStyle = dataGridViewCellStyle2;
            dgvReservation.Dock = DockStyle.Fill;
            dgvReservation.EnableHeadersVisualStyles = false;
            dgvReservation.GridColor = Color.FromArgb(230, 230, 230);
            dgvReservation.HeaderBackColor = Color.FromArgb(243, 244, 246);
            dgvReservation.HeaderForeColor = Color.FromArgb(33, 37, 41);
            dgvReservation.Location = new Point(403, 4);
            dgvReservation.Margin = new Padding(4);
            dgvReservation.MultiSelect = false;
            dgvReservation.Name = "dgvReservation";
            dgvReservation.RightToLeft = RightToLeft.Yes;
            dgvReservation.RowHeadersVisible = false;
            dgvReservation.RowHeadersWidth = 51;
            dgvReservation.RowHeight = 50;
            dgvReservation.RowTemplate.Height = 50;
            dgvReservation.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReservation.Size = new Size(923, 537);
            dgvReservation.TabIndex = 25;
            dgvReservation.CellContentClick += dgvReservation_CellContentClick;
            dgvReservation.CellPainting += dgvReservation_CellPainting;
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(1330, 854);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "PaymentForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "PaymentForm";
            Load += PaymentForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReservation).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label3;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private CustomItems.AdvancedStatusCard advancedStatusCard1;
        private CustomItems.AdvancedStatusCard advancedStatusCard2;
        private TableLayoutPanel tableLayoutPanel2;
        private CustomItems.BookingDetailsCard bookingDetailsCard;
        private CustomItems.AdvancedStatusCard advancedStatusCard3;
        private CustomItems.CustomDataGridView dgvReservation;
    }
}