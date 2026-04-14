namespace ActiveSpaceSystem.Forms.SideForms
{
    partial class Scheduling
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
            panel1 = new Panel();
            label3 = new Label();
            label1 = new Label();
            nextDateButton = new Button();
            prevDateButton = new Button();
            dateTimePicker1 = new DateTimePicker();
            statusCard4 = new ActiveSpaceSystem.CustomItems.StatusCard();
            pillButton5 = new ActiveSpaceSystem.CustomItems.PillButton();
            pillButton4 = new ActiveSpaceSystem.CustomItems.PillButton();
            pillButton3 = new ActiveSpaceSystem.CustomItems.PillButton();
            pillButton2 = new ActiveSpaceSystem.CustomItems.PillButton();
            pillButton1 = new ActiveSpaceSystem.CustomItems.PillButton();
            statusCard1 = new ActiveSpaceSystem.CustomItems.StatusCard();
            customLabel4 = new ActiveSpaceSystem.CustomItems.CustomLabel();
            customLabel3 = new ActiveSpaceSystem.CustomItems.CustomLabel();
            customLabel2 = new ActiveSpaceSystem.CustomItems.CustomLabel();
            customLabel1 = new ActiveSpaceSystem.CustomItems.CustomLabel();
            statusCard5 = new ActiveSpaceSystem.CustomItems.StatusCard();
            statusCard3 = new ActiveSpaceSystem.CustomItems.StatusCard();
            statusCard2 = new ActiveSpaceSystem.CustomItems.StatusCard();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            bookingDataGridView1 = new SportsApp.Controls.BookingDataGridView();
            stadium = new DataGridViewTextBoxColumn();
            h17 = new DataGridViewTextBoxColumn();
            h18 = new DataGridViewTextBoxColumn();
            h19 = new DataGridViewTextBoxColumn();
            h20 = new DataGridViewTextBoxColumn();
            h21 = new DataGridViewTextBoxColumn();
            h23 = new DataGridViewTextBoxColumn();
            h24 = new DataGridViewTextBoxColumn();
            h1 = new DataGridViewTextBoxColumn();
            h2 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            statusCard4.SuspendLayout();
            statusCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bookingDataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1256, 137);
            panel1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(874, 105);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(273, 25);
            label3.TabIndex = 6;
            label3.Text = "عرض وإدارة الجدول الزمني للملاعب";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(892, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(229, 46);
            label1.TabIndex = 0;
            label1.Text = "الجدولة الزمنية";
            // 
            // nextDateButton
            // 
            nextDateButton.BackColor = Color.White;
            nextDateButton.FlatStyle = FlatStyle.Popup;
            nextDateButton.Location = new Point(1136, 39);
            nextDateButton.Name = "nextDateButton";
            nextDateButton.Size = new Size(40, 32);
            nextDateButton.TabIndex = 7;
            nextDateButton.Text = "▶";
            nextDateButton.UseVisualStyleBackColor = false;
            nextDateButton.Click += nextDateButton_Click;
            // 
            // prevDateButton
            // 
            prevDateButton.BackColor = Color.Transparent;
            prevDateButton.FlatStyle = FlatStyle.Popup;
            prevDateButton.ForeColor = Color.Black;
            prevDateButton.Location = new Point(746, 39);
            prevDateButton.Name = "prevDateButton";
            prevDateButton.Size = new Size(40, 31);
            prevDateButton.TabIndex = 6;
            prevDateButton.Text = "◀";
            prevDateButton.UseVisualStyleBackColor = false;
            prevDateButton.Click += prevDateButton_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "yyyy / MM / dd";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(815, 39);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 3;
            // 
            // statusCard4
            // 
            statusCard4.BackColor = Color.Transparent;
            statusCard4.BorderColor = Color.Black;
            statusCard4.BorderRadius = 15;
            statusCard4.CardBackColor = Color.White;
            statusCard4.Controls.Add(pillButton5);
            statusCard4.Controls.Add(pillButton4);
            statusCard4.Controls.Add(pillButton3);
            statusCard4.Controls.Add(pillButton2);
            statusCard4.Controls.Add(pillButton1);
            statusCard4.Controls.Add(nextDateButton);
            statusCard4.Controls.Add(dateTimePicker1);
            statusCard4.Controls.Add(prevDateButton);
            statusCard4.Location = new Point(29, 160);
            statusCard4.Name = "statusCard4";
            statusCard4.Padding = new Padding(5);
            statusCard4.ShadowBlur = 5;
            statusCard4.ShadowColor = Color.FromArgb(0, 0, 192);
            statusCard4.ShowShadow = true;
            statusCard4.Size = new Size(1212, 113);
            statusCard4.TabIndex = 5;
            statusCard4.TitleColor = Color.Gray;
            statusCard4.TitleFont = new Font("Microsoft Sans Serif", 10F);
            statusCard4.TitleText = "";
            statusCard4.ValueColor = Color.FromArgb(46, 204, 113);
            statusCard4.ValueFont = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            statusCard4.ValueText = "";
            statusCard4.Paint += statusCard4_Paint;
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
            pillButton5.Font = new Font("Segoe UI Semibold", 10F);
            pillButton5.ForeColor = Color.FromArgb(64, 64, 64);
            pillButton5.GroupName = "";
            pillButton5.Location = new Point(33, 30);
            pillButton5.Name = "pillButton5";
            pillButton5.Radius = 10;
            pillButton5.Size = new Size(113, 54);
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
            pillButton4.Font = new Font("Segoe UI Semibold", 10F);
            pillButton4.ForeColor = Color.FromArgb(64, 64, 64);
            pillButton4.GroupName = "";
            pillButton4.Location = new Point(166, 30);
            pillButton4.Name = "pillButton4";
            pillButton4.Radius = 10;
            pillButton4.Size = new Size(113, 54);
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
            pillButton3.Font = new Font("Segoe UI Semibold", 10F);
            pillButton3.ForeColor = Color.FromArgb(64, 64, 64);
            pillButton3.GroupName = "";
            pillButton3.Location = new Point(299, 29);
            pillButton3.Name = "pillButton3";
            pillButton3.Radius = 10;
            pillButton3.Size = new Size(113, 54);
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
            pillButton2.Font = new Font("Segoe UI Semibold", 10F);
            pillButton2.ForeColor = Color.FromArgb(64, 64, 64);
            pillButton2.GroupName = "";
            pillButton2.Location = new Point(432, 28);
            pillButton2.Name = "pillButton2";
            pillButton2.Radius = 10;
            pillButton2.Size = new Size(113, 54);
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
            pillButton1.Font = new Font("Segoe UI Semibold", 10F);
            pillButton1.ForeColor = Color.FromArgb(64, 64, 64);
            pillButton1.GroupName = "";
            pillButton1.Location = new Point(565, 28);
            pillButton1.Name = "pillButton1";
            pillButton1.Radius = 10;
            pillButton1.Size = new Size(113, 54);
            pillButton1.TabIndex = 8;
            pillButton1.Text = "الكل ";
            pillButton1.UncheckedBackColor = Color.FromArgb(242, 242, 242);
            pillButton1.UncheckedForeColor = Color.FromArgb(64, 64, 64);
            pillButton1.UseVisualStyleBackColor = false;
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
            statusCard1.Location = new Point(21, 647);
            statusCard1.Name = "statusCard1";
            statusCard1.Padding = new Padding(5);
            statusCard1.ShadowBlur = 5;
            statusCard1.ShadowColor = Color.FromArgb(100, 0, 0, 0);
            statusCard1.ShowShadow = true;
            statusCard1.Size = new Size(1229, 113);
            statusCard1.TabIndex = 6;
            statusCard1.TitleColor = Color.Gray;
            statusCard1.TitleFont = new Font("Microsoft Sans Serif", 10F);
            statusCard1.TitleText = "";
            statusCard1.ValueColor = Color.FromArgb(46, 204, 113);
            statusCard1.ValueFont = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            statusCard1.ValueText = "";
            // 
            // customLabel4
            // 
            customLabel4.AutoSize = true;
            customLabel4.BackColor = Color.Transparent;
            customLabel4.Font = new Font("Segoe UI", 10F);
            customLabel4.Location = new Point(589, 64);
            customLabel4.Name = "customLabel4";
            customLabel4.Size = new Size(158, 28);
            customLabel4.TabIndex = 6;
            customLabel4.Text = "خارج أوقات العمل";
            // 
            // customLabel3
            // 
            customLabel3.AutoSize = true;
            customLabel3.BackColor = Color.Transparent;
            customLabel3.Font = new Font("Segoe UI", 10F);
            customLabel3.Location = new Point(834, 64);
            customLabel3.Name = "customLabel3";
            customLabel3.Size = new Size(66, 28);
            customLabel3.TabIndex = 5;
            customLabel3.Text = "محجوز";
            customLabel3.Click += customLabel3_Click_1;
            // 
            // customLabel2
            // 
            customLabel2.AutoSize = true;
            customLabel2.BackColor = Color.Transparent;
            customLabel2.Font = new Font("Segoe UI", 10F);
            customLabel2.Location = new Point(995, 64);
            customLabel2.Name = "customLabel2";
            customLabel2.Size = new Size(99, 28);
            customLabel2.TabIndex = 4;
            customLabel2.Text = "متاح للحجز";
            // 
            // customLabel1
            // 
            customLabel1.AutoSize = true;
            customLabel1.BackColor = Color.Transparent;
            customLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            customLabel1.Location = new Point(1016, 16);
            customLabel1.Name = "customLabel1";
            customLabel1.Size = new Size(155, 32);
            customLabel1.TabIndex = 3;
            customLabel1.Text = "مفتاح التوضيح";
            // 
            // statusCard5
            // 
            statusCard5.BackColor = Color.Transparent;
            statusCard5.BorderColor = Color.FromArgb(240, 240, 240);
            statusCard5.BorderRadius = 5;
            statusCard5.CardBackColor = Color.FromArgb(224, 224, 224);
            statusCard5.Location = new Point(753, 64);
            statusCard5.Name = "statusCard5";
            statusCard5.Padding = new Padding(5);
            statusCard5.ShadowBlur = 5;
            statusCard5.ShadowColor = Color.FromArgb(100, 0, 0, 0);
            statusCard5.ShowShadow = true;
            statusCard5.Size = new Size(45, 41);
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
            statusCard3.BackColor = Color.Transparent;
            statusCard3.BorderColor = Color.FromArgb(240, 240, 240);
            statusCard3.BorderRadius = 5;
            statusCard3.CardBackColor = Color.FromArgb(255, 128, 128);
            statusCard3.Location = new Point(906, 64);
            statusCard3.Name = "statusCard3";
            statusCard3.Padding = new Padding(5);
            statusCard3.ShadowBlur = 5;
            statusCard3.ShadowColor = Color.FromArgb(100, 0, 0, 0);
            statusCard3.ShowShadow = true;
            statusCard3.Size = new Size(45, 41);
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
            statusCard2.BackColor = Color.Transparent;
            statusCard2.BorderColor = Color.FromArgb(240, 240, 240);
            statusCard2.BorderRadius = 5;
            statusCard2.CardBackColor = Color.FromArgb(192, 255, 192);
            statusCard2.Location = new Point(1100, 64);
            statusCard2.Name = "statusCard2";
            statusCard2.Padding = new Padding(5);
            statusCard2.ShadowBlur = 5;
            statusCard2.ShadowColor = Color.FromArgb(100, 0, 0, 0);
            statusCard2.ShowShadow = true;
            statusCard2.Size = new Size(43, 41);
            statusCard2.TabIndex = 0;
            statusCard2.TitleColor = Color.Gray;
            statusCard2.TitleFont = new Font("Microsoft Sans Serif", 10F);
            statusCard2.TitleText = "";
            statusCard2.ValueColor = Color.FromArgb(46, 204, 113);
            statusCard2.ValueFont = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            statusCard2.ValueText = "";
            statusCard2.Paint += statusCard2_Paint;
            // 
            // bookingDataGridView1
            // 
            bookingDataGridView1.AllowUserToAddRows = false;
            bookingDataGridView1.BackgroundColor = Color.White;
            bookingDataGridView1.BorderStyle = BorderStyle.None;
            bookingDataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(245, 247, 249);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            bookingDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            bookingDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bookingDataGridView1.Columns.AddRange(new DataGridViewColumn[] { stadium, h17, h18, h19, h20, h21, h23, h24, h1, h2 });
            bookingDataGridView1.EnableHeadersVisualStyles = false;
            bookingDataGridView1.GridColor = Color.FromArgb(230, 230, 230);
            bookingDataGridView1.Location = new Point(29, 312);
            bookingDataGridView1.Name = "bookingDataGridView1";
            bookingDataGridView1.RightToLeft = RightToLeft.Yes;
            bookingDataGridView1.RowHeadersVisible = false;
            bookingDataGridView1.RowHeadersWidth = 62;
            bookingDataGridView1.RowTemplate.Height = 70;
            bookingDataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            bookingDataGridView1.Size = new Size(1212, 308);
            bookingDataGridView1.TabIndex = 7;
            // 
            // stadium
            // 
            stadium.HeaderText = "الملعب";
            stadium.MinimumWidth = 8;
            stadium.Name = "stadium";
            stadium.Width = 150;
            // 
            // h17
            // 
            h17.HeaderText = "17";
            h17.MinimumWidth = 8;
            h17.Name = "h17";
            h17.Width = 150;
            // 
            // h18
            // 
            h18.HeaderText = "18";
            h18.MinimumWidth = 8;
            h18.Name = "h18";
            h18.Width = 150;
            // 
            // h19
            // 
            h19.HeaderText = "19";
            h19.MinimumWidth = 8;
            h19.Name = "h19";
            h19.Width = 150;
            // 
            // h20
            // 
            h20.HeaderText = "20";
            h20.MinimumWidth = 8;
            h20.Name = "h20";
            h20.Width = 150;
            // 
            // h21
            // 
            h21.HeaderText = "21";
            h21.MinimumWidth = 8;
            h21.Name = "h21";
            h21.Width = 150;
            // 
            // h23
            // 
            h23.HeaderText = "23";
            h23.MinimumWidth = 8;
            h23.Name = "h23";
            h23.Width = 150;
            // 
            // h24
            // 
            h24.HeaderText = "24";
            h24.MinimumWidth = 8;
            h24.Name = "h24";
            h24.Width = 150;
            // 
            // h1
            // 
            h1.HeaderText = "1";
            h1.MinimumWidth = 8;
            h1.Name = "h1";
            h1.Width = 150;
            // 
            // h2
            // 
            h2.HeaderText = "2";
            h2.MinimumWidth = 8;
            h2.Name = "h2";
            h2.Width = 150;
            // 
            // Scheduling
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1256, 797);
            Controls.Add(bookingDataGridView1);
            Controls.Add(statusCard1);
            Controls.Add(statusCard4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Scheduling";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "Scheduling";
            Load += Scheduling_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            statusCard4.ResumeLayout(false);
            statusCard1.ResumeLayout(false);
            statusCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bookingDataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Button prevDateButton;
        private Button nextDateButton;
        private CustomItems.StatusCard statusCard4;
        private CustomItems.StatusCard statusCard1;
        private CustomItems.StatusCard statusCard2;
        private CustomItems.StatusCard statusCard5;
        private CustomItems.StatusCard statusCard3;
        private CustomItems.CustomLabel customLabel2;
        private CustomItems.CustomLabel customLabel1;
        private CustomItems.CustomLabel customLabel3;
        private CustomItems.CustomLabel customLabel4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private CustomItems.PillButton pillButton1;
        private CustomItems.PillButton pillButton5;
        private CustomItems.PillButton pillButton4;
        private CustomItems.PillButton pillButton3;
        private CustomItems.PillButton pillButton2;
        private SportsApp.Controls.BookingDataGridView bookingDataGridView1;
        private DataGridViewTextBoxColumn stadium;
        private DataGridViewTextBoxColumn h17;
        private DataGridViewTextBoxColumn h18;
        private DataGridViewTextBoxColumn h19;
        private DataGridViewTextBoxColumn h20;
        private DataGridViewTextBoxColumn h21;
        private DataGridViewTextBoxColumn h23;
        private DataGridViewTextBoxColumn h24;
        private DataGridViewTextBoxColumn h1;
        private DataGridViewTextBoxColumn h2;
    }
}