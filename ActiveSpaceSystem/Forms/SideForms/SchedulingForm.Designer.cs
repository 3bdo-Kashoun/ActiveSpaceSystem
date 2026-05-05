namespace ActiveSpaceSystem.Forms.SideForms
{
    partial class SchedulingForm
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
            panel2 = new Panel();
            statusCard1 = new ActiveSpaceSystem.CustomItems.StatusCard();
            customLabel4 = new ActiveSpaceSystem.CustomItems.CustomLabel();
            customLabel3 = new ActiveSpaceSystem.CustomItems.CustomLabel();
            customLabel2 = new ActiveSpaceSystem.CustomItems.CustomLabel();
            customLabel1 = new ActiveSpaceSystem.CustomItems.CustomLabel();
            statusCard5 = new ActiveSpaceSystem.CustomItems.StatusCard();
            statusCard3 = new ActiveSpaceSystem.CustomItems.StatusCard();
            statusCard2 = new ActiveSpaceSystem.CustomItems.StatusCard();
            panel3 = new Panel();
            stadiumGrid1 = new ActiveSpaceSystem.CustomItems.StadiumGrid();
            panel4 = new Panel();
            statusCard4 = new ActiveSpaceSystem.CustomItems.StatusCard();
            dateTimePicker2 = new DateTimePicker();
            pillButton5 = new ActiveSpaceSystem.CustomItems.PillButton();
            pillButton4 = new ActiveSpaceSystem.CustomItems.PillButton();
            pillButton3 = new ActiveSpaceSystem.CustomItems.PillButton();
            pillButton2 = new ActiveSpaceSystem.CustomItems.PillButton();
            pillButton1 = new ActiveSpaceSystem.CustomItems.PillButton();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            statusCard1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)stadiumGrid1).BeginInit();
            panel4.SuspendLayout();
            statusCard4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1043, 85);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Tajawal", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(757, 57);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(249, 23);
            label3.TabIndex = 8;
            label3.Text = "عرض وإدارة الجدول الزمني للملاعب";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Tajawal Medium", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(780, 9);
            label1.Name = "label1";
            label1.Size = new Size(240, 48);
            label1.TabIndex = 7;
            label1.Text = "الجدولة الزمنية";
            // 
            // panel2
            // 
            panel2.Controls.Add(statusCard1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 585);
            panel2.Name = "panel2";
            panel2.Size = new Size(1043, 98);
            panel2.TabIndex = 1;
            // 
            // statusCard1
            // 
            statusCard1.BackColor = Color.Transparent;
            statusCard1.BorderColor = Color.Black;
            statusCard1.BorderRadius = 15;
            statusCard1.CardBackColor = Color.White;
            statusCard1.Controls.Add(customLabel4);
            statusCard1.Controls.Add(customLabel3);
            statusCard1.Controls.Add(customLabel2);
            statusCard1.Controls.Add(customLabel1);
            statusCard1.Controls.Add(statusCard5);
            statusCard1.Controls.Add(statusCard3);
            statusCard1.Controls.Add(statusCard2);
            statusCard1.Dock = DockStyle.Bottom;
            statusCard1.Location = new Point(0, 8);
            statusCard1.Margin = new Padding(2);
            statusCard1.Name = "statusCard1";
            statusCard1.Padding = new Padding(4);
            statusCard1.ShadowBlur = 5;
            statusCard1.ShadowColor = Color.FromArgb(100, 0, 0, 0);
            statusCard1.ShowShadow = true;
            statusCard1.Size = new Size(1043, 90);
            statusCard1.TabIndex = 7;
            statusCard1.TitleColor = Color.Gray;
            statusCard1.TitleFont = new Font("Microsoft Sans Serif", 10F);
            statusCard1.TitleText = "";
            statusCard1.ValueColor = Color.FromArgb(46, 204, 113);
            statusCard1.ValueFont = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            statusCard1.ValueText = "";
            // 
            // customLabel4
            // 
            customLabel4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            customLabel4.AutoSize = true;
            customLabel4.BackColor = Color.Transparent;
            customLabel4.Font = new Font("Microsoft Sans Serif", 10.2F);
            customLabel4.Location = new Point(470, 50);
            customLabel4.Margin = new Padding(2, 0, 2, 0);
            customLabel4.Name = "customLabel4";
            customLabel4.Size = new Size(112, 20);
            customLabel4.TabIndex = 6;
            customLabel4.Text = "خارج أوقات العمل";
            // 
            // customLabel3
            // 
            customLabel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            customLabel3.AutoSize = true;
            customLabel3.BackColor = Color.Transparent;
            customLabel3.Font = new Font("Microsoft Sans Serif", 10.2F);
            customLabel3.Location = new Point(666, 50);
            customLabel3.Margin = new Padding(2, 0, 2, 0);
            customLabel3.Name = "customLabel3";
            customLabel3.Size = new Size(49, 20);
            customLabel3.TabIndex = 5;
            customLabel3.Text = "محجوز";
            // 
            // customLabel2
            // 
            customLabel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            customLabel2.AutoSize = true;
            customLabel2.BackColor = Color.Transparent;
            customLabel2.Font = new Font("Microsoft Sans Serif", 10.2F);
            customLabel2.Location = new Point(795, 50);
            customLabel2.Margin = new Padding(2, 0, 2, 0);
            customLabel2.Name = "customLabel2";
            customLabel2.Size = new Size(72, 20);
            customLabel2.TabIndex = 4;
            customLabel2.Text = "متاح للحجز";
            // 
            // customLabel1
            // 
            customLabel1.Anchor = AnchorStyles.Right;
            customLabel1.AutoSize = true;
            customLabel1.BackColor = Color.Transparent;
            customLabel1.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customLabel1.Location = new Point(785, 3);
            customLabel1.Margin = new Padding(2, 0, 2, 0);
            customLabel1.Name = "customLabel1";
            customLabel1.Size = new Size(118, 25);
            customLabel1.TabIndex = 3;
            customLabel1.Text = "مفتاح التوضيح";
            // 
            // statusCard5
            // 
            statusCard5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            statusCard5.BackColor = Color.Transparent;
            statusCard5.BorderColor = Color.FromArgb(240, 240, 240);
            statusCard5.BorderRadius = 5;
            statusCard5.CardBackColor = Color.FromArgb(224, 224, 224);
            statusCard5.Location = new Point(602, 44);
            statusCard5.Margin = new Padding(2);
            statusCard5.Name = "statusCard5";
            statusCard5.Padding = new Padding(4);
            statusCard5.ShadowBlur = 5;
            statusCard5.ShadowColor = Color.FromArgb(100, 0, 0, 0);
            statusCard5.ShowShadow = true;
            statusCard5.Size = new Size(36, 33);
            statusCard5.TabIndex = 2;
            statusCard5.TitleColor = Color.Gray;
            statusCard5.TitleFont = new Font("Microsoft Sans Serif", 10F);
            statusCard5.TitleText = "";
            statusCard5.ValueColor = Color.FromArgb(46, 204, 113);
            statusCard5.ValueFont = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            statusCard5.ValueText = "";
            // 
            // statusCard3
            // 
            statusCard3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            statusCard3.BackColor = Color.Transparent;
            statusCard3.BorderColor = Color.FromArgb(240, 240, 240);
            statusCard3.BorderRadius = 5;
            statusCard3.CardBackColor = Color.FromArgb(255, 128, 128);
            statusCard3.Location = new Point(725, 44);
            statusCard3.Margin = new Padding(2);
            statusCard3.Name = "statusCard3";
            statusCard3.Padding = new Padding(4);
            statusCard3.ShadowBlur = 5;
            statusCard3.ShadowColor = Color.FromArgb(100, 0, 0, 0);
            statusCard3.ShowShadow = true;
            statusCard3.Size = new Size(36, 33);
            statusCard3.TabIndex = 1;
            statusCard3.TitleColor = Color.Gray;
            statusCard3.TitleFont = new Font("Microsoft Sans Serif", 10F);
            statusCard3.TitleText = "";
            statusCard3.ValueColor = Color.FromArgb(46, 204, 113);
            statusCard3.ValueFont = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            statusCard3.ValueText = "";
            // 
            // statusCard2
            // 
            statusCard2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            statusCard2.BackColor = Color.Transparent;
            statusCard2.BorderColor = Color.FromArgb(240, 240, 240);
            statusCard2.BorderRadius = 5;
            statusCard2.CardBackColor = Color.FromArgb(192, 255, 192);
            statusCard2.Location = new Point(880, 44);
            statusCard2.Margin = new Padding(2);
            statusCard2.Name = "statusCard2";
            statusCard2.Padding = new Padding(4);
            statusCard2.ShadowBlur = 5;
            statusCard2.ShadowColor = Color.FromArgb(100, 0, 0, 0);
            statusCard2.ShowShadow = true;
            statusCard2.Size = new Size(34, 33);
            statusCard2.TabIndex = 0;
            statusCard2.TitleColor = Color.Gray;
            statusCard2.TitleFont = new Font("Microsoft Sans Serif", 10F);
            statusCard2.TitleText = "";
            statusCard2.ValueColor = Color.FromArgb(46, 204, 113);
            statusCard2.ValueFont = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            statusCard2.ValueText = "";
            // 
            // panel3
            // 
            panel3.Controls.Add(stadiumGrid1);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 85);
            panel3.Name = "panel3";
            panel3.Size = new Size(1043, 500);
            panel3.TabIndex = 2;
            // 
            // stadiumGrid1
            // 
            stadiumGrid1.AllowUserToAddRows = false;
            stadiumGrid1.BackgroundColor = Color.White;
            stadiumGrid1.BorderRadius = 25;
            stadiumGrid1.BorderStyle = BorderStyle.None;
            stadiumGrid1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            stadiumGrid1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(243, 244, 246);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(52, 58, 64);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            stadiumGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            stadiumGrid1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            stadiumGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            stadiumGrid1.Dock = DockStyle.Fill;
            stadiumGrid1.EnableHeadersVisualStyles = false;
            stadiumGrid1.GridColor = Color.White;
            stadiumGrid1.Location = new Point(0, 93);
            stadiumGrid1.Name = "stadiumGrid1";
            stadiumGrid1.ReadOnly = true;
            stadiumGrid1.RightToLeft = RightToLeft.Yes;
            stadiumGrid1.RowHeadersVisible = false;
            stadiumGrid1.RowHeadersWidth = 51;
            stadiumGrid1.RowTemplate.Height = 70;
            stadiumGrid1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            stadiumGrid1.Size = new Size(1043, 407);
            stadiumGrid1.TabIndex = 9;
            stadiumGrid1.CellDoubleClick += stadiumGrid1_CellDoubleClick;
            // 
            // panel4
            // 
            panel4.Controls.Add(statusCard4);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1043, 93);
            panel4.TabIndex = 0;
            // 
            // statusCard4
            // 
            statusCard4.BackColor = Color.Transparent;
            statusCard4.BorderColor = Color.Black;
            statusCard4.BorderRadius = 15;
            statusCard4.CardBackColor = Color.White;
            statusCard4.Controls.Add(dateTimePicker2);
            statusCard4.Controls.Add(pillButton5);
            statusCard4.Controls.Add(pillButton4);
            statusCard4.Controls.Add(pillButton3);
            statusCard4.Controls.Add(pillButton2);
            statusCard4.Controls.Add(pillButton1);
            statusCard4.Dock = DockStyle.Fill;
            statusCard4.Location = new Point(0, 0);
            statusCard4.Margin = new Padding(80);
            statusCard4.Name = "statusCard4";
            statusCard4.Padding = new Padding(40);
            statusCard4.ShadowBlur = 5;
            statusCard4.ShadowColor = Color.FromArgb(0, 0, 192);
            statusCard4.ShowShadow = true;
            statusCard4.Size = new Size(1043, 93);
            statusCard4.TabIndex = 6;
            statusCard4.TitleColor = Color.Gray;
            statusCard4.TitleFont = new Font("Microsoft Sans Serif", 10F);
            statusCard4.TitleText = "";
            statusCard4.ValueColor = Color.FromArgb(46, 204, 113);
            statusCard4.ValueFont = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            statusCard4.ValueText = "";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Anchor = AnchorStyles.Right;
            dateTimePicker2.CustomFormat = "yyyy / MM / dd";
            dateTimePicker2.Font = new Font("Tajawal", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(713, 34);
            dateTimePicker2.Margin = new Padding(2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.RightToLeft = RightToLeft.Yes;
            dateTimePicker2.RightToLeftLayout = true;
            dateTimePicker2.Size = new Size(237, 31);
            dateTimePicker2.TabIndex = 13;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // pillButton5
            // 
            pillButton5.BackColor = Color.White;
            pillButton5.BackgroundImageLayout = ImageLayout.None;
            pillButton5.Checked = false;
            pillButton5.CheckedBackColor = Color.FromArgb(41, 51, 146);
            pillButton5.CheckedForeColor = Color.White;
            pillButton5.FlatAppearance.BorderSize = 0;
            pillButton5.FlatStyle = FlatStyle.Flat;
            pillButton5.Font = new Font("Tajawal Medium", 10.2F, FontStyle.Bold);
            pillButton5.ForeColor = Color.FromArgb(64, 64, 64);
            pillButton5.GroupName = "";
            pillButton5.Location = new Point(26, 24);
            pillButton5.Margin = new Padding(2);
            pillButton5.Name = "pillButton5";
            pillButton5.Radius = 10;
            pillButton5.Size = new Size(90, 43);
            pillButton5.TabIndex = 12;
            pillButton5.Text = "بادل";
            pillButton5.UncheckedBackColor = Color.FromArgb(242, 242, 242);
            pillButton5.UncheckedForeColor = Color.FromArgb(64, 64, 64);
            pillButton5.UseVisualStyleBackColor = false;
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
            pillButton4.Location = new Point(133, 24);
            pillButton4.Margin = new Padding(2);
            pillButton4.Name = "pillButton4";
            pillButton4.Radius = 10;
            pillButton4.Size = new Size(90, 43);
            pillButton4.TabIndex = 11;
            pillButton4.Text = "الطائرة";
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
            pillButton3.Location = new Point(239, 23);
            pillButton3.Margin = new Padding(2);
            pillButton3.Name = "pillButton3";
            pillButton3.Radius = 10;
            pillButton3.Size = new Size(90, 43);
            pillButton3.TabIndex = 10;
            pillButton3.Text = "تنس";
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
            pillButton2.Location = new Point(346, 22);
            pillButton2.Margin = new Padding(2);
            pillButton2.Name = "pillButton2";
            pillButton2.Radius = 10;
            pillButton2.Size = new Size(90, 43);
            pillButton2.TabIndex = 9;
            pillButton2.Text = "القدم";
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
            pillButton1.Location = new Point(452, 22);
            pillButton1.Margin = new Padding(2);
            pillButton1.Name = "pillButton1";
            pillButton1.Radius = 10;
            pillButton1.Size = new Size(90, 43);
            pillButton1.TabIndex = 8;
            pillButton1.Text = "الكل ";
            pillButton1.UncheckedBackColor = Color.FromArgb(242, 242, 242);
            pillButton1.UncheckedForeColor = Color.FromArgb(64, 64, 64);
            pillButton1.UseVisualStyleBackColor = false;
            // 
            // SchedulingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(1043, 683);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SchedulingForm";
            Text = "SchedulingForm";
            Load += SchedulingForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            statusCard1.ResumeLayout(false);
            statusCard1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)stadiumGrid1).EndInit();
            panel4.ResumeLayout(false);
            statusCard4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private CustomItems.StadiumGrid stadiumGrid1;
        private CustomItems.StatusCard statusCard4;
        private CustomItems.PillButton pillButton5;
        private CustomItems.PillButton pillButton4;
        private CustomItems.PillButton pillButton3;
        private CustomItems.PillButton pillButton2;
        private CustomItems.PillButton pillButton1;
        
        
       
        private DateTimePicker dateTimePicker2;
        private Label label3;
        private Label label1;
        private CustomItems.StatusCard statusCard1;
        private CustomItems.CustomLabel customLabel4;
        private CustomItems.CustomLabel customLabel3;
        private CustomItems.CustomLabel customLabel2;
        private CustomItems.CustomLabel customLabel1;
        private CustomItems.StatusCard statusCard5;
        private CustomItems.StatusCard statusCard3;
        private CustomItems.StatusCard statusCard2;
    }
}