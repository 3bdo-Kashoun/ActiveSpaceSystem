namespace ActiveSpaceSystem.Forms.SideForms
{
    partial class DashBoardForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoardForm));
            flowLayoutPanel1 = new FlowLayoutPanel();
            TotalBookingCountCard = new ActiveSpaceSystem.CustomItems.AdvancedStatusCard();
            TotalCustomersCard = new ActiveSpaceSystem.CustomItems.AdvancedStatusCard();
            TotalIncomeCard = new ActiveSpaceSystem.CustomItems.AdvancedStatusCard();
            PercentgeCard = new ActiveSpaceSystem.CustomItems.AdvancedStatusCard();
            label13 = new Label();
            panel1 = new Panel();
            CourtsPanel = new ActiveSpaceSystem.CustomItems.CustomPanel();
            CourtPanel = new FlowLayoutPanel();
            panel4 = new Panel();
            label19 = new Label();
            customPanel1 = new ActiveSpaceSystem.CustomItems.CustomPanel();
            customChart1 = new ActiveSpaceSystem.CustomItems.CustomChart();
            panel2 = new Panel();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            CourtsPanel.SuspendLayout();
            panel4.SuspendLayout();
            customPanel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(TotalBookingCountCard);
            flowLayoutPanel1.Controls.Add(TotalCustomersCard);
            flowLayoutPanel1.Controls.Add(TotalIncomeCard);
            flowLayoutPanel1.Controls.Add(PercentgeCard);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(15, 20, 15, 20);
            flowLayoutPanel1.Size = new Size(1001, 380);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.SizeChanged += flowLayoutPanel1_SizeChanged;
            // 
            // TotalBookingCountCard
            // 
            TotalBookingCountCard.BackColor = Color.Transparent;
            TotalBookingCountCard.BorderRadius = 20;
            TotalBookingCountCard.CardIcon = Properties.Resources.calendar_70;
            TotalBookingCountCard.IconBackColor = Color.White;
            TotalBookingCountCard.IconSize = 70;
            TotalBookingCountCard.Location = new Point(491, 30);
            TotalBookingCountCard.Margin = new Padding(10);
            TotalBookingCountCard.Name = "TotalBookingCountCard";
            TotalBookingCountCard.ShadowSize = 6;
            TotalBookingCountCard.Size = new Size(470, 150);
            TotalBookingCountCard.SubValueColor = Color.FromArgb(46, 204, 113);
            TotalBookingCountCard.SubValueFont = new Font("Tajawal", 9F);
            TotalBookingCountCard.SubValueText = "";
            TotalBookingCountCard.TabIndex = 0;
            TotalBookingCountCard.TitleColor = Color.Gray;
            TotalBookingCountCard.TitleFont = new Font("Tajawal Medium", 12F, FontStyle.Bold);
            TotalBookingCountCard.TitleText = "إجمالي الحجوزات اليوم";
            TotalBookingCountCard.ValueColor = SystemColors.ControlText;
            TotalBookingCountCard.ValueFont = new Font("Tajawal", 16F, FontStyle.Bold);
            TotalBookingCountCard.ValueText = "12,450 ر.س";
            // 
            // TotalCustomersCard
            // 
            TotalCustomersCard.BackColor = Color.Transparent;
            TotalCustomersCard.BorderRadius = 20;
            TotalCustomersCard.CardIcon = Properties.Resources.users_70__1_;
            TotalCustomersCard.IconBackColor = Color.White;
            TotalCustomersCard.IconSize = 70;
            TotalCustomersCard.Location = new Point(491, 200);
            TotalCustomersCard.Margin = new Padding(10);
            TotalCustomersCard.Name = "TotalCustomersCard";
            TotalCustomersCard.ShadowSize = 6;
            TotalCustomersCard.Size = new Size(470, 150);
            TotalCustomersCard.SubValueColor = Color.FromArgb(46, 204, 113);
            TotalCustomersCard.SubValueFont = new Font("Tajawal", 9F);
            TotalCustomersCard.SubValueText = "";
            TotalCustomersCard.TabIndex = 1;
            TotalCustomersCard.TitleColor = Color.Gray;
            TotalCustomersCard.TitleFont = new Font("Tajawal Medium", 12F, FontStyle.Bold);
            TotalCustomersCard.TitleText = "عدد العملاء النشطين";
            TotalCustomersCard.ValueColor = SystemColors.ControlText;
            TotalCustomersCard.ValueFont = new Font("Tajawal", 16F, FontStyle.Bold);
            TotalCustomersCard.ValueText = "12,450 ر.س";
            // 
            // TotalIncomeCard
            // 
            TotalIncomeCard.BackColor = Color.Transparent;
            TotalIncomeCard.BorderRadius = 20;
            TotalIncomeCard.CardIcon = Properties.Resources.mon_70;
            TotalIncomeCard.IconBackColor = Color.White;
            TotalIncomeCard.IconSize = 70;
            TotalIncomeCard.Location = new Point(491, 370);
            TotalIncomeCard.Margin = new Padding(10);
            TotalIncomeCard.Name = "TotalIncomeCard";
            TotalIncomeCard.ShadowSize = 6;
            TotalIncomeCard.Size = new Size(470, 150);
            TotalIncomeCard.SubValueColor = Color.FromArgb(46, 204, 113);
            TotalIncomeCard.SubValueFont = new Font("Tajawal", 9F);
            TotalIncomeCard.SubValueText = "";
            TotalIncomeCard.TabIndex = 2;
            TotalIncomeCard.TitleColor = Color.Gray;
            TotalIncomeCard.TitleFont = new Font("Tajawal Medium", 12F, FontStyle.Bold);
            TotalIncomeCard.TitleText = "إجمالي الإيرادات اليوم";
            TotalIncomeCard.ValueColor = SystemColors.ControlText;
            TotalIncomeCard.ValueFont = new Font("Tajawal", 16F, FontStyle.Bold);
            TotalIncomeCard.ValueText = "12,450 ر.س";
            // 
            // PercentgeCard
            // 
            PercentgeCard.BackColor = Color.Transparent;
            PercentgeCard.BorderRadius = 20;
            PercentgeCard.CardIcon = Properties.Resources.pulse_70;
            PercentgeCard.IconBackColor = Color.White;
            PercentgeCard.IconSize = 70;
            PercentgeCard.Location = new Point(491, 540);
            PercentgeCard.Margin = new Padding(10);
            PercentgeCard.Name = "PercentgeCard";
            PercentgeCard.ShadowSize = 6;
            PercentgeCard.Size = new Size(470, 150);
            PercentgeCard.SubValueColor = Color.FromArgb(46, 204, 113);
            PercentgeCard.SubValueFont = new Font("Tajawal", 9F);
            PercentgeCard.SubValueText = "";
            PercentgeCard.TabIndex = 3;
            PercentgeCard.TitleColor = Color.Gray;
            PercentgeCard.TitleFont = new Font("Tajawal Medium", 12F, FontStyle.Bold);
            PercentgeCard.TitleText = "معدل الإنشغال";
            PercentgeCard.ValueColor = SystemColors.ControlText;
            PercentgeCard.ValueFont = new Font("Tajawal", 16F, FontStyle.Bold);
            PercentgeCard.ValueText = "12,450 ر.س";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Font = new Font("Tajawal Medium", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(649, 17);
            label13.Name = "label13";
            label13.Size = new Size(315, 41);
            label13.TabIndex = 7;
            label13.Text = "الإيرادات خلال الأسبوع";
            // 
            // panel1
            // 
            panel1.Controls.Add(CourtsPanel);
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 946);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(1001, 410);
            panel1.TabIndex = 2;
            // 
            // CourtsPanel
            // 
            CourtsPanel.AutoScroll = true;
            CourtsPanel.BackColor = Color.White;
            CourtsPanel.BorderColor = Color.FromArgb(230, 230, 230);
            CourtsPanel.BorderRadius = 20;
            CourtsPanel.BorderSize = 1F;
            CourtsPanel.Controls.Add(CourtPanel);
            CourtsPanel.Dock = DockStyle.Fill;
            CourtsPanel.Location = new Point(10, 67);
            CourtsPanel.Name = "CourtsPanel";
            CourtsPanel.Padding = new Padding(30);
            CourtsPanel.ShowShadow = true;
            CourtsPanel.Size = new Size(981, 333);
            CourtsPanel.TabIndex = 1;
            // 
            // CourtPanel
            // 
            CourtPanel.AutoScroll = true;
            CourtPanel.Dock = DockStyle.Fill;
            CourtPanel.FlowDirection = FlowDirection.RightToLeft;
            CourtPanel.Location = new Point(30, 30);
            CourtPanel.Name = "CourtPanel";
            CourtPanel.Size = new Size(921, 273);
            CourtPanel.TabIndex = 0;
            CourtPanel.Resize += CourtPanel_Resize;
            // 
            // panel4
            // 
            panel4.Controls.Add(label19);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(10, 10);
            panel4.Name = "panel4";
            panel4.Size = new Size(981, 57);
            panel4.TabIndex = 0;
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.Right;
            label19.AutoSize = true;
            label19.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.Black;
            label19.Location = new Point(813, 15);
            label19.Name = "label19";
            label19.Size = new Size(122, 29);
            label19.TabIndex = 10;
            label19.Text = "حالة الملاعب";
            label19.Click += label19_Click;
            // 
            // customPanel1
            // 
            customPanel1.BackColor = Color.White;
            customPanel1.BorderColor = Color.FromArgb(230, 230, 230);
            customPanel1.BorderRadius = 20;
            customPanel1.BorderSize = 1F;
            customPanel1.Controls.Add(customChart1);
            customPanel1.Controls.Add(panel2);
            customPanel1.Dock = DockStyle.Top;
            customPanel1.Location = new Point(0, 380);
            customPanel1.Name = "customPanel1";
            customPanel1.Padding = new Padding(10);
            customPanel1.ShowShadow = true;
            customPanel1.Size = new Size(1001, 566);
            customPanel1.TabIndex = 1;
            // 
            // customChart1
            // 
            customChart1.BackColor = Color.White;
            customChart1.BarColor = Color.FromArgb(46, 204, 113);
            customChart1.ChartData = (Dictionary<string, double>)resources.GetObject("customChart1.ChartData");
            customChart1.Dock = DockStyle.Fill;
            customChart1.LabelFont = new Font("Tajawal", 8F);
            customChart1.Location = new Point(10, 87);
            customChart1.Name = "customChart1";
            customChart1.Size = new Size(981, 469);
            customChart1.TabIndex = 1;
            customChart1.ValueFont = new Font("Tajawal", 9F, FontStyle.Bold);
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(248, 250, 252);
            panel2.Controls.Add(label13);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(10, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(981, 77);
            panel2.TabIndex = 0;
            // 
            // DashBoardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(1022, 1102);
            Controls.Add(customPanel1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashBoardForm";
            Text = "DashBoardForm";
            DockChanged += DashBoardForm_DockChanged;
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            CourtsPanel.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            customPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private CustomItems.AdvancedStatusCard TotalBookingCountCard;
        private CustomItems.AdvancedStatusCard TotalCustomersCard;
        private CustomItems.AdvancedStatusCard TotalIncomeCard;
        private CustomItems.AdvancedStatusCard PercentgeCard;
        private Panel panel1;
        private Label label13;
        private Panel panel4;
        private Label label19;
        private CustomItems.CustomPanel CourtsPanel;
        private FlowLayoutPanel CourtPanel;
        private CustomItems.CustomPanel customPanel1;
        private Panel panel2;
        private CustomItems.CustomChart customChart1;
    }
}