namespace ActiveSpaceSystem.CustomItems
{
    partial class CourtCard
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

        #region Component Designer generated code

        private void InitializeComponent()
        {
            mainPanel = new CustomPanel();
            pnlStatusIndicator = new Panel();
            lblStatusTag = new Label();
            lblTime = new Label();
            lblSportType = new Label();
            lblCourtName = new Label();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            mainPanel.BackColor = Color.White;
            mainPanel.BorderColor = Color.FromArgb(230, 230, 230);
            mainPanel.BorderRadius = 20;
            mainPanel.BorderSize = 1F;
            mainPanel.Controls.Add(pnlStatusIndicator);
            mainPanel.Controls.Add(lblStatusTag);
            mainPanel.Controls.Add(lblTime);
            mainPanel.Controls.Add(lblSportType);
            mainPanel.Controls.Add(lblCourtName);
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(15);
            mainPanel.ShowShadow = true;
            mainPanel.Size = new Size(786, 120);
            mainPanel.TabIndex = 0;
            // 
            // pnlStatusIndicator
            // 
            pnlStatusIndicator.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlStatusIndicator.Location = new Point(740, 32);
            pnlStatusIndicator.Margin = new Padding(10);
            pnlStatusIndicator.Name = "pnlStatusIndicator";
            pnlStatusIndicator.Size = new Size(15, 15);
            pnlStatusIndicator.TabIndex = 6;
            pnlStatusIndicator.Paint += pnlStatusIndicator_Paint;
            // 
            // lblStatusTag
            // 
            lblStatusTag.BackColor = Color.FromArgb(254, 226, 226);
            lblStatusTag.Font = new Font("Tajawal", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatusTag.ForeColor = Color.FromArgb(185, 28, 28);
            lblStatusTag.Location = new Point(25, 25);
            lblStatusTag.Name = "lblStatusTag";
            lblStatusTag.Size = new Size(100, 35);
            lblStatusTag.TabIndex = 5;
            lblStatusTag.Text = "محجوز";
            lblStatusTag.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.BackColor = Color.Transparent;
            lblTime.Font = new Font("Tajawal", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTime.ForeColor = Color.Gray;
            lblTime.Location = new Point(25, 70);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(122, 21);
            lblTime.TabIndex = 4;
            lblTime.Text = "ينتهي الساعة 8:00";
            lblTime.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSportType
            // 
            lblSportType.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSportType.AutoSize = true;
            lblSportType.BackColor = Color.Transparent;
            lblSportType.Font = new Font("Tajawal", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSportType.ForeColor = Color.Gray;
            lblSportType.Location = new Point(635, 60);
            lblSportType.Name = "lblSportType";
            lblSportType.Size = new Size(77, 25);
            lblSportType.TabIndex = 2;
            lblSportType.Text = "كرة القدم";
            lblSportType.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCourtName
            // 
            lblCourtName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCourtName.Font = new Font("Tajawal Medium", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCourtName.ForeColor = Color.Black;
            lblCourtName.Location = new Point(480, 22);
            lblCourtName.Margin = new Padding(10);
            lblCourtName.Name = "lblCourtName";
            lblCourtName.Size = new Size(250, 32);
            lblCourtName.TabIndex = 1;
            lblCourtName.Text = "ملعب رقم 1";
            lblCourtName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // CourtCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(mainPanel);
            Name = "CourtCard";
            Size = new Size(786, 120);
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CustomPanel mainPanel; // استخدام البانل المخصصة كخلفية
        private Label lblCourtName;
        private Label lblSportType;
        private Label lblTime;
        private Label lblStatusTag;
        private Panel pnlStatusIndicator;
    }
}