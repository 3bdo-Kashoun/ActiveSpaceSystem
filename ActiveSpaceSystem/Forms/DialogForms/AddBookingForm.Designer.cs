namespace ActiveSpaceSystem.Forms.DialogForms
{
    partial class AddBookingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBookingForm));
            txtName = new ActiveSpaceSystem.CustomItems.AbdulTextBox();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            txtPhone = new ActiveSpaceSystem.CustomItems.AbdulTextBox();
            label4 = new Label();
            label5 = new Label();
            txtCourt = new ActiveSpaceSystem.CustomItems.AbdulTextBox();
            dtpBookingDate = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtprice = new ActiveSpaceSystem.CustomItems.AbdulTextBox();
            label10 = new Label();
            deposittxt = new ActiveSpaceSystem.CustomItems.AbdulTextBox();
            dtpStartTime = new DateTimePicker();
            cmbCourtType = new ComboBox();
            customPanel1 = new ActiveSpaceSystem.CustomItems.CustomPanel();
            roundedButton2 = new ActiveSpaceSystem.CustomItems.RoundedButton();
            roundedButton1 = new ActiveSpaceSystem.CustomItems.RoundedButton();
            dtpEndTime = new DateTimePicker();
            customPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.BorderColor = Color.FromArgb(29, 53, 87);
            txtName.BorderRadius = 15;
            txtName.Icon = null;
            txtName.IconLocation = HorizontalAlignment.Left;
            txtName.IconSize = 20;
            txtName.Location = new Point(451, 131);
            txtName.Name = "txtName";
            txtName.passwordChar = "\0";
            txtName.PlaceholderText = "أدخل النص هنا...";
            txtName.RightToLeft = RightToLeft.Yes;
            txtName.Size = new Size(330, 50);
            txtName.TabIndex = 0;
            txtName.Texts = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tajawal", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(615, 20);
            label1.Name = "label1";
            label1.Size = new Size(173, 33);
            label1.TabIndex = 1;
            label1.Text = "إضافة حجز جديد";
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(28, 20);
            button1.Name = "button1";
            button1.Size = new Size(31, 29);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tajawal Medium", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(666, 94);
            label2.Name = "label2";
            label2.Size = new Size(115, 25);
            label2.TabIndex = 3;
            label2.Text = "اسم العميل";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tajawal Medium", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(274, 94);
            label3.Name = "label3";
            label3.Size = new Size(105, 25);
            label3.TabIndex = 5;
            label3.Text = "رقم الهاتف";
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.White;
            txtPhone.BorderColor = Color.FromArgb(29, 53, 87);
            txtPhone.BorderRadius = 15;
            txtPhone.Icon = null;
            txtPhone.IconLocation = HorizontalAlignment.Left;
            txtPhone.IconSize = 20;
            txtPhone.Location = new Point(49, 131);
            txtPhone.Name = "txtPhone";
            txtPhone.passwordChar = "\0";
            txtPhone.PlaceholderText = "أدخل النص هنا...";
            txtPhone.RightToLeft = RightToLeft.Yes;
            txtPhone.Size = new Size(330, 50);
            txtPhone.TabIndex = 4;
            txtPhone.Texts = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tajawal Medium", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(673, 196);
            label4.Name = "label4";
            label4.Size = new Size(108, 25);
            label4.TabIndex = 8;
            label4.Text = "نوع الملعب";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tajawal Medium", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(304, 196);
            label5.Name = "label5";
            label5.Size = new Size(75, 25);
            label5.TabIndex = 10;
            label5.Text = "الملعب";
            // 
            // txtCourt
            // 
            txtCourt.BackColor = Color.White;
            txtCourt.BorderColor = Color.FromArgb(29, 53, 87);
            txtCourt.BorderRadius = 15;
            txtCourt.Icon = null;
            txtCourt.IconLocation = HorizontalAlignment.Left;
            txtCourt.IconSize = 20;
            txtCourt.Location = new Point(49, 233);
            txtCourt.Name = "txtCourt";
            txtCourt.passwordChar = "\0";
            txtCourt.PlaceholderText = "أدخل النص هنا...";
            txtCourt.RightToLeft = RightToLeft.Yes;
            txtCourt.Size = new Size(330, 50);
            txtCourt.TabIndex = 9;
            txtCourt.Texts = "";
            // 
            // dtpBookingDate
            // 
            dtpBookingDate.CalendarFont = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpBookingDate.Format = DateTimePickerFormat.Short;
            dtpBookingDate.Location = new Point(451, 342);
            dtpBookingDate.Name = "dtpBookingDate";
            dtpBookingDate.RightToLeft = RightToLeft.Yes;
            dtpBookingDate.Size = new Size(330, 27);
            dtpBookingDate.TabIndex = 1;
            dtpBookingDate.ValueChanged += dtp_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tajawal Medium", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(714, 300);
            label6.Name = "label6";
            label6.Size = new Size(67, 25);
            label6.TabIndex = 12;
            label6.Text = "التاريخ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tajawal Medium", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(272, 300);
            label7.Name = "label7";
            label7.Size = new Size(107, 25);
            label7.TabIndex = 13;
            label7.Text = "وقت البداية";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tajawal Medium", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(670, 392);
            label8.Name = "label8";
            label8.Size = new Size(111, 25);
            label8.TabIndex = 15;
            label8.Text = "وقت النهاية";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tajawal Medium", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(313, 392);
            label9.Name = "label9";
            label9.Size = new Size(66, 25);
            label9.TabIndex = 17;
            label9.Text = "السعر";
            // 
            // txtprice
            // 
            txtprice.BackColor = Color.White;
            txtprice.BorderColor = Color.FromArgb(29, 53, 87);
            txtprice.BorderRadius = 15;
            txtprice.Icon = null;
            txtprice.IconLocation = HorizontalAlignment.Left;
            txtprice.IconSize = 20;
            txtprice.Location = new Point(49, 429);
            txtprice.Name = "txtprice";
            txtprice.passwordChar = "\0";
            txtprice.PlaceholderText = "أدخل السعر هنا...";
            txtprice.RightToLeft = RightToLeft.Yes;
            txtprice.Size = new Size(330, 50);
            txtprice.TabIndex = 16;
            txtprice.Texts = "";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tajawal Medium", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(521, 477);
            label10.Name = "label10";
            label10.Size = new Size(62, 25);
            label10.TabIndex = 19;
            label10.Text = "عربون";
            // 
            // deposittxt
            // 
            deposittxt.BackColor = Color.White;
            deposittxt.BorderColor = Color.FromArgb(29, 53, 87);
            deposittxt.BorderRadius = 15;
            deposittxt.Icon = null;
            deposittxt.IconLocation = HorizontalAlignment.Left;
            deposittxt.IconSize = 20;
            deposittxt.Location = new Point(258, 511);
            deposittxt.Name = "deposittxt";
            deposittxt.passwordChar = "\0";
            deposittxt.PlaceholderText = "أدخل قيمة العربون هنا...";
            deposittxt.RightToLeft = RightToLeft.Yes;
            deposittxt.Size = new Size(330, 50);
            deposittxt.TabIndex = 18;
            deposittxt.Texts = "";
            // 
            // dtpStartTime
            // 
            dtpStartTime.CalendarFont = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpStartTime.CustomFormat = "hh/mm";
            dtpStartTime.Format = DateTimePickerFormat.Time;
            dtpStartTime.Location = new Point(49, 342);
            dtpStartTime.Name = "dtpStartTime";
            dtpStartTime.RightToLeft = RightToLeft.Yes;
            dtpStartTime.Size = new Size(330, 27);
            dtpStartTime.TabIndex = 0;
            // 
            // cmbCourtType
            // 
            cmbCourtType.DisplayMember = "CourtName";
            cmbCourtType.FlatStyle = FlatStyle.Flat;
            cmbCourtType.FormattingEnabled = true;
            cmbCourtType.Location = new Point(18, 13);
            cmbCourtType.Name = "cmbCourtType";
            cmbCourtType.RightToLeft = RightToLeft.Yes;
            cmbCourtType.Size = new Size(295, 28);
            cmbCourtType.TabIndex = 6;
            cmbCourtType.ValueMember = "CourtID";
            // 
            // customPanel1
            // 
            customPanel1.BackColor = Color.White;
            customPanel1.BorderColor = Color.Black;
            customPanel1.BorderRadius = 10;
            customPanel1.BorderSize = 1F;
            customPanel1.Controls.Add(cmbCourtType);
            customPanel1.Location = new Point(451, 233);
            customPanel1.Name = "customPanel1";
            customPanel1.ShowShadow = false;
            customPanel1.Size = new Size(330, 55);
            customPanel1.TabIndex = 49;
            // 
            // roundedButton2
            // 
            roundedButton2.BackColor = Color.FromArgb(16, 185, 129);
            roundedButton2.BorderColor = Color.Transparent;
            roundedButton2.BorderRadius = 10;
            roundedButton2.BorderSize = 2;
            roundedButton2.FlatAppearance.BorderSize = 0;
            roundedButton2.FlatStyle = FlatStyle.Flat;
            roundedButton2.Font = new Font("Tajawal", 13.8F, FontStyle.Bold);
            roundedButton2.ForeColor = Color.White;
            roundedButton2.Location = new Point(418, 595);
            roundedButton2.Name = "roundedButton2";
            roundedButton2.Size = new Size(317, 60);
            roundedButton2.TabIndex = 51;
            roundedButton2.Text = "حفظ الحجز";
            roundedButton2.UseVisualStyleBackColor = false;
            roundedButton2.Click += roundedButton2_Click;
            // 
            // roundedButton1
            // 
            roundedButton1.BackColor = Color.WhiteSmoke;
            roundedButton1.BorderColor = Color.Transparent;
            roundedButton1.BorderRadius = 10;
            roundedButton1.BorderSize = 2;
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.Font = new Font("Tajawal", 13.8F, FontStyle.Bold);
            roundedButton1.ForeColor = Color.Gray;
            roundedButton1.Location = new Point(95, 595);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(317, 60);
            roundedButton1.TabIndex = 50;
            roundedButton1.Text = "إلغاء";
            roundedButton1.UseVisualStyleBackColor = false;
            roundedButton1.Click += roundedButton1_Click;
            // 
            // dtpEndTime
            // 
            dtpEndTime.CalendarFont = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpEndTime.CustomFormat = "hh/mm";
            dtpEndTime.Format = DateTimePickerFormat.Time;
            dtpEndTime.Location = new Point(451, 429);
            dtpEndTime.Name = "dtpEndTime";
            dtpEndTime.RightToLeft = RightToLeft.Yes;
            dtpEndTime.Size = new Size(330, 27);
            dtpEndTime.TabIndex = 52;
            // 
            // AddBookingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 679);
            Controls.Add(dtpEndTime);
            Controls.Add(roundedButton2);
            Controls.Add(roundedButton1);
            Controls.Add(customPanel1);
            Controls.Add(dtpBookingDate);
            Controls.Add(dtpStartTime);
            Controls.Add(label10);
            Controls.Add(deposittxt);
            Controls.Add(label9);
            Controls.Add(txtprice);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtCourt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtPhone);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(txtName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddBookingForm";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddBookingForm";
            Load += AddBookingForm_Load;
            Paint += AddBookingForm_Paint;
            customPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomItems.AbdulTextBox txtName;
        private Label label1;
        private Button button1;
        private Label label2;
        private Label label3;
        private CustomItems.AbdulTextBox txtPhone;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker dateTimePicker2;
        private Label label7;
        private Label label8;
        private Label label9;
        private CustomItems.AbdulTextBox txtprice;
        private Label label10;
        private CustomItems.AbdulTextBox deposittxt;
        private CustomItems.CustomPanel customPanel1;
        public CustomItems.AbdulTextBox txtCourt;
        public DateTimePicker dtpBookingDate;
        public DateTimePicker dtpStartTime;
        public ComboBox cmbCourtType;
        private CustomItems.RoundedButton roundedButton2;
        private CustomItems.RoundedButton roundedButton1;
        public DateTimePicker dtpEndTime;
    }
}