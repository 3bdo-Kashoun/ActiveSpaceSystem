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
            txtPhone = new ActiveSpaceSystem.CustomItems.AbdulTextBox();
            label1 = new Label();
            btnExit = new Button();
            label2 = new Label();
            label3 = new Label();
            txtName = new ActiveSpaceSystem.CustomItems.AbdulTextBox();
            label4 = new Label();
            label5 = new Label();
            dtpBookingDate = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            dtpEndTime = new DateTimePicker();
            label9 = new Label();
            txtprice = new ActiveSpaceSystem.CustomItems.AbdulTextBox();
            label10 = new Label();
            deposittxt = new ActiveSpaceSystem.CustomItems.AbdulTextBox();
            cmbCourtType = new ComboBox();
            customPanel1 = new ActiveSpaceSystem.CustomItems.CustomPanel();
            dtpStartTime = new DateTimePicker();
            customPanel2 = new ActiveSpaceSystem.CustomItems.CustomPanel();
            cmbCourt = new ComboBox();
            roundedButton1 = new ActiveSpaceSystem.CustomItems.RoundedButton();
            btnCancel = new ActiveSpaceSystem.CustomItems.RoundedButton();
            customPanel1.SuspendLayout();
            customPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.White;
            txtPhone.BorderColor = Color.FromArgb(29, 53, 87);
            txtPhone.BorderRadius = 15;
            txtPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Icon = null;
            txtPhone.IconLocation = HorizontalAlignment.Left;
            txtPhone.IconSize = 20;
            txtPhone.Location = new Point(564, 164);
            txtPhone.Margin = new Padding(4, 4, 4, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.passwordChar = "\0";
            txtPhone.PlaceholderText = "أدخل النص هنا...";
            txtPhone.RightToLeft = RightToLeft.Yes;
            txtPhone.Size = new Size(412, 62);
            txtPhone.TabIndex = 0;
            txtPhone.Texts = "";
            txtPhone.KeyPress += txtPhone_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tajawal", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(769, 25);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(212, 42);
            label1.TabIndex = 1;
            label1.Text = "إضافة حجز جديد";
            // 
            // btnExit
            // 
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.Location = new Point(35, 25);
            btnExit.Margin = new Padding(4, 4, 4, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(39, 36);
            btnExit.TabIndex = 2;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tajawal Medium", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(328, 114);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(136, 30);
            label2.TabIndex = 3;
            label2.Text = "اسم العميل";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tajawal Medium", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(845, 114);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(124, 30);
            label3.TabIndex = 5;
            label3.Text = "رقم الهاتف";
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.BorderColor = Color.FromArgb(29, 53, 87);
            txtName.BorderRadius = 15;
            txtName.Font = new Font("Tajawal", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Icon = null;
            txtName.IconLocation = HorizontalAlignment.Left;
            txtName.IconSize = 20;
            txtName.Location = new Point(59, 164);
            txtName.Margin = new Padding(4, 4, 4, 4);
            txtName.Name = "txtName";
            txtName.passwordChar = "\0";
            txtName.PlaceholderText = "أدخل النص هنا...";
            txtName.RightToLeft = RightToLeft.Yes;
            txtName.Size = new Size(412, 62);
            txtName.TabIndex = 4;
            txtName.Texts = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tajawal Medium", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(841, 245);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(129, 30);
            label4.TabIndex = 8;
            label4.Text = "نوع الملعب";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tajawal Medium", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(380, 245);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(89, 30);
            label5.TabIndex = 10;
            label5.Text = "الملعب";
            // 
            // dtpBookingDate
            // 
            dtpBookingDate.CalendarFont = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpBookingDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpBookingDate.Format = DateTimePickerFormat.Short;
            dtpBookingDate.Location = new Point(564, 428);
            dtpBookingDate.Margin = new Padding(4, 4, 4, 4);
            dtpBookingDate.Name = "dtpBookingDate";
            dtpBookingDate.RightToLeft = RightToLeft.Yes;
            dtpBookingDate.RightToLeftLayout = true;
            dtpBookingDate.Size = new Size(412, 39);
            dtpBookingDate.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tajawal Medium", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(892, 375);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(79, 30);
            label6.TabIndex = 12;
            label6.Text = "التاريخ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tajawal Medium", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(340, 375);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(129, 30);
            label7.TabIndex = 13;
            label7.Text = "وقت البداية";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tajawal Medium", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(838, 490);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(134, 30);
            label8.TabIndex = 15;
            label8.Text = "وقت النهاية";
            // 
            // dtpEndTime
            // 
            dtpEndTime.CalendarFont = new Font("Tajawal", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpEndTime.CustomFormat = "HH:mm";
            dtpEndTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpEndTime.Format = DateTimePickerFormat.Custom;
            dtpEndTime.Location = new Point(564, 536);
            dtpEndTime.Margin = new Padding(4, 4, 4, 4);
            dtpEndTime.Name = "dtpEndTime";
            dtpEndTime.RightToLeft = RightToLeft.Yes;
            dtpEndTime.RightToLeftLayout = true;
            dtpEndTime.ShowUpDown = true;
            dtpEndTime.Size = new Size(412, 39);
            dtpEndTime.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tajawal Medium", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(391, 490);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(77, 30);
            label9.TabIndex = 17;
            label9.Text = "السعر";
            // 
            // txtprice
            // 
            txtprice.BackColor = Color.White;
            txtprice.BorderColor = Color.FromArgb(29, 53, 87);
            txtprice.BorderRadius = 15;
            txtprice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtprice.Icon = null;
            txtprice.IconLocation = HorizontalAlignment.Left;
            txtprice.IconSize = 20;
            txtprice.Location = new Point(61, 536);
            txtprice.Margin = new Padding(4, 4, 4, 4);
            txtprice.Name = "txtprice";
            txtprice.passwordChar = "\0";
            txtprice.PlaceholderText = "أدخل السعر هنا...";
            txtprice.RightToLeft = RightToLeft.Yes;
            txtprice.Size = new Size(412, 62);
            txtprice.TabIndex = 16;
            txtprice.Texts = "";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tajawal Medium", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(651, 596);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(73, 30);
            label10.TabIndex = 19;
            label10.Text = "عربون";
            // 
            // deposittxt
            // 
            deposittxt.BackColor = Color.White;
            deposittxt.BorderColor = Color.FromArgb(29, 53, 87);
            deposittxt.BorderRadius = 15;
            deposittxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deposittxt.Icon = null;
            deposittxt.IconLocation = HorizontalAlignment.Left;
            deposittxt.IconSize = 20;
            deposittxt.Location = new Point(322, 639);
            deposittxt.Margin = new Padding(4, 4, 4, 4);
            deposittxt.Name = "deposittxt";
            deposittxt.passwordChar = "\0";
            deposittxt.PlaceholderText = "أدخل قيمة العربون هنا...";
            deposittxt.RightToLeft = RightToLeft.Yes;
            deposittxt.Size = new Size(412, 62);
            deposittxt.TabIndex = 18;
            deposittxt.Texts = "";
            // 
            // cmbCourtType
            // 
            cmbCourtType.DisplayMember = "CourtName";
            cmbCourtType.FlatStyle = FlatStyle.Flat;
            cmbCourtType.FormattingEnabled = true;
            cmbCourtType.Location = new Point(22, 16);
            cmbCourtType.Margin = new Padding(4, 4, 4, 4);
            cmbCourtType.Name = "cmbCourtType";
            cmbCourtType.RightToLeft = RightToLeft.Yes;
            cmbCourtType.Size = new Size(368, 33);
            cmbCourtType.TabIndex = 6;
            cmbCourtType.SelectedIndexChanged += cmbCourtType_SelectedIndexChanged;
            // 
            // customPanel1
            // 
            customPanel1.BackColor = Color.White;
            customPanel1.BorderColor = Color.Black;
            customPanel1.BorderRadius = 10;
            customPanel1.BorderSize = 1F;
            customPanel1.Controls.Add(cmbCourtType);
            customPanel1.Location = new Point(564, 291);
            customPanel1.Margin = new Padding(4, 4, 4, 4);
            customPanel1.Name = "customPanel1";
            customPanel1.ShowShadow = false;
            customPanel1.Size = new Size(412, 69);
            customPanel1.TabIndex = 49;
            // 
            // dtpStartTime
            // 
            dtpStartTime.CalendarFont = new Font("Tajawal", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpStartTime.CustomFormat = "HH:mm";
            dtpStartTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpStartTime.Format = DateTimePickerFormat.Custom;
            dtpStartTime.Location = new Point(59, 428);
            dtpStartTime.Margin = new Padding(4, 4, 4, 4);
            dtpStartTime.Name = "dtpStartTime";
            dtpStartTime.RightToLeft = RightToLeft.Yes;
            dtpStartTime.RightToLeftLayout = true;
            dtpStartTime.ShowUpDown = true;
            dtpStartTime.Size = new Size(412, 39);
            dtpStartTime.TabIndex = 50;
            // 
            // customPanel2
            // 
            customPanel2.BackColor = Color.White;
            customPanel2.BorderColor = Color.Black;
            customPanel2.BorderRadius = 10;
            customPanel2.BorderSize = 1F;
            customPanel2.Controls.Add(cmbCourt);
            customPanel2.Location = new Point(59, 291);
            customPanel2.Margin = new Padding(4, 4, 4, 4);
            customPanel2.Name = "customPanel2";
            customPanel2.ShowShadow = false;
            customPanel2.Size = new Size(412, 69);
            customPanel2.TabIndex = 51;
            // 
            // cmbCourt
            // 
            cmbCourt.FlatStyle = FlatStyle.Flat;
            cmbCourt.FormattingEnabled = true;
            cmbCourt.Location = new Point(22, 16);
            cmbCourt.Margin = new Padding(4, 4, 4, 4);
            cmbCourt.Name = "cmbCourt";
            cmbCourt.RightToLeft = RightToLeft.Yes;
            cmbCourt.Size = new Size(368, 33);
            cmbCourt.TabIndex = 6;
            // 
            // roundedButton1
            // 
            roundedButton1.BackColor = Color.FromArgb(16, 185, 129);
            roundedButton1.BorderColor = Color.PaleVioletRed;
            roundedButton1.BorderRadius = 10;
            roundedButton1.BorderSize = 0;
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.Font = new Font("Tajawal", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedButton1.ForeColor = Color.White;
            roundedButton1.Location = new Point(549, 744);
            roundedButton1.Margin = new Padding(4, 4, 4, 4);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(390, 80);
            roundedButton1.TabIndex = 52;
            roundedButton1.Text = "حفظ الحجز";
            roundedButton1.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.WhiteSmoke;
            btnCancel.BorderColor = Color.PaleVioletRed;
            btnCancel.BorderRadius = 10;
            btnCancel.BorderSize = 0;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Tajawal", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = SystemColors.GrayText;
            btnCancel.Location = new Point(59, 744);
            btnCancel.Margin = new Padding(4, 4, 4, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(390, 80);
            btnCancel.TabIndex = 53;
            btnCancel.Text = "إلغاء";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddBookingForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 864);
            Controls.Add(btnCancel);
            Controls.Add(roundedButton1);
            Controls.Add(customPanel2);
            Controls.Add(dtpStartTime);
            Controls.Add(customPanel1);
            Controls.Add(dtpEndTime);
            Controls.Add(dtpBookingDate);
            Controls.Add(label10);
            Controls.Add(deposittxt);
            Controls.Add(label9);
            Controls.Add(txtprice);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(btnExit);
            Controls.Add(label1);
            Controls.Add(txtPhone);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            Name = "AddBookingForm";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddBookingForm";
            Load += AddBookingForm_Load;
            Paint += AddBookingForm_Paint;
            customPanel1.ResumeLayout(false);
            customPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomItems.AbdulTextBox txtPhone;
        private Label label1;
        private Button btnExit;
        private Label label2;
        private Label label3;
        private CustomItems.AbdulTextBox txtName;
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
        public DateTimePicker dtpBookingDate;
        public DateTimePicker dtpEndTime;
        public ComboBox cmbCourtType;
        public DateTimePicker dtpStartTime;
        private CustomItems.CustomPanel customPanel2;
        public ComboBox cmbCourt;
        private CustomItems.RoundedButton roundedButton1;
        private CustomItems.RoundedButton btnCancel;
    }
}