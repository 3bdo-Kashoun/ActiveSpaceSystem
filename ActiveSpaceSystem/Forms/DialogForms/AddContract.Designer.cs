namespace ActiveSpaceSystem.Forms.DialogForms
{
    partial class AddContract
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddContract));
            dtpEndTime = new DateTimePicker();
            dtpStartDate = new DateTimePicker();
            dtpStartTime = new DateTimePicker();
            label9 = new Label();
            txtPricePerHour = new ActiveSpaceSystem.CustomItems.AbdulTextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtPhone = new ActiveSpaceSystem.CustomItems.AbdulTextBox();
            label2 = new Label();
            button1 = new Button();
            label1 = new Label();
            dtpEndDate = new DateTimePicker();
            label11 = new Label();
            btCancel = new ActiveSpaceSystem.CustomItems.RoundedButton();
            label10 = new Label();
            btSave = new ActiveSpaceSystem.CustomItems.RoundedButton();
            customPanel1 = new ActiveSpaceSystem.CustomItems.CustomPanel();
            cmbCourtType = new ComboBox();
            customPanel2 = new ActiveSpaceSystem.CustomItems.CustomPanel();
            cmbCourts = new ComboBox();
            customPanel3 = new ActiveSpaceSystem.CustomItems.CustomPanel();
            cmbDays = new ComboBox();
            labelHours = new Label();
            txtCustomerName = new ActiveSpaceSystem.CustomItems.AbdulTextBox();
            customPanel1.SuspendLayout();
            customPanel2.SuspendLayout();
            customPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // dtpEndTime
            // 
            dtpEndTime.CalendarFont = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpEndTime.Format = DateTimePickerFormat.Time;
            dtpEndTime.Location = new Point(534, 500);
            dtpEndTime.Margin = new Padding(4);
            dtpEndTime.Name = "dtpEndTime";
            dtpEndTime.RightToLeft = RightToLeft.Yes;
            dtpEndTime.RightToLeftLayout = true;
            dtpEndTime.ShowUpDown = true;
            dtpEndTime.Size = new Size(412, 31);
            dtpEndTime.TabIndex = 25;
            // 
            // dtpStartDate
            // 
            dtpStartDate.CalendarFont = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.Location = new Point(26, 483);
            dtpStartDate.Margin = new Padding(4);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.RightToLeft = RightToLeft.Yes;
            dtpStartDate.RightToLeftLayout = true;
            dtpStartDate.Size = new Size(412, 31);
            dtpStartDate.TabIndex = 26;
            dtpStartDate.ValueChanged += dtpStartDate_ValueChanged;
            // 
            // dtpStartTime
            // 
            dtpStartTime.CalendarFont = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpStartTime.Format = DateTimePickerFormat.Time;
            dtpStartTime.Location = new Point(26, 388);
            dtpStartTime.Margin = new Padding(4);
            dtpStartTime.Name = "dtpStartTime";
            dtpStartTime.RightToLeft = RightToLeft.Yes;
            dtpStartTime.RightToLeftLayout = true;
            dtpStartTime.ShowUpDown = true;
            dtpStartTime.Size = new Size(412, 31);
            dtpStartTime.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tajawal Medium", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(252, 436);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(179, 30);
            label9.TabIndex = 39;
            label9.Text = "تاريخ بداية العقد";
            // 
            // txtPricePerHour
            // 
            txtPricePerHour.BackColor = Color.White;
            txtPricePerHour.BorderColor = Color.FromArgb(29, 53, 87);
            txtPricePerHour.BorderRadius = 15;
            txtPricePerHour.Icon = null;
            txtPricePerHour.IconLocation = HorizontalAlignment.Left;
            txtPricePerHour.IconSize = 20;
            txtPricePerHour.Location = new Point(24, 586);
            txtPricePerHour.Margin = new Padding(4);
            txtPricePerHour.Name = "txtPricePerHour";
            txtPricePerHour.passwordChar = "\0";
            txtPricePerHour.PlaceholderText = "أدخل النص هنا...";
            txtPricePerHour.RightToLeft = RightToLeft.Yes;
            txtPricePerHour.Size = new Size(412, 62);
            txtPricePerHour.TabIndex = 38;
            txtPricePerHour.Texts = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tajawal Medium", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(808, 441);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(134, 30);
            label8.TabIndex = 37;
            label8.Text = "وقت النهاية";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tajawal Medium", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(305, 341);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(129, 30);
            label7.TabIndex = 36;
            label7.Text = "وقت البداية";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tajawal Medium", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(781, 339);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(165, 30);
            label6.TabIndex = 35;
            label6.Text = "اليوم الاسبوعي";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tajawal Medium", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(345, 208);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(89, 30);
            label5.TabIndex = 34;
            label5.Text = "الملعب";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tajawal Medium", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(811, 196);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(129, 30);
            label4.TabIndex = 32;
            label4.Text = "نوع الملعب";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tajawal Medium", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(307, 82);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(124, 30);
            label3.TabIndex = 30;
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
            txtPhone.Location = new Point(26, 129);
            txtPhone.Margin = new Padding(4);
            txtPhone.Name = "txtPhone";
            txtPhone.passwordChar = "\0";
            txtPhone.PlaceholderText = "أدخل النص هنا...";
            txtPhone.RightToLeft = RightToLeft.Yes;
            txtPhone.Size = new Size(412, 62);
            txtPhone.TabIndex = 29;
            txtPhone.Texts = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tajawal Medium", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(811, 69);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(136, 30);
            label2.TabIndex = 28;
            label2.Text = "اسم العميل";
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(13, 5);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(39, 36);
            button1.TabIndex = 27;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tajawal", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(665, 5);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(301, 42);
            label1.TabIndex = 24;
            label1.Text = "إضافة عقد شهري جديد";
            // 
            // dtpEndDate
            // 
            dtpEndDate.CalendarFont = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpEndDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.Location = new Point(535, 608);
            dtpEndDate.Margin = new Padding(4);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.RightToLeft = RightToLeft.Yes;
            dtpEndDate.RightToLeftLayout = true;
            dtpEndDate.Size = new Size(412, 31);
            dtpEndDate.TabIndex = 46;
            dtpEndDate.ValueChanged += dtpEndDate_ValueChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tajawal Medium", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(761, 562);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(179, 30);
            label11.TabIndex = 47;
            label11.Text = "تاريخ بداية العقد";
            // 
            // btCancel
            // 
            btCancel.BackColor = Color.White;
            btCancel.BorderColor = Color.White;
            btCancel.BorderRadius = 10;
            btCancel.BorderSize = 2;
            btCancel.FlatAppearance.BorderSize = 0;
            btCancel.FlatStyle = FlatStyle.Flat;
            btCancel.Font = new Font("Tajawal", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btCancel.ForeColor = Color.DimGray;
            btCancel.Location = new Point(40, 728);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(405, 75);
            btCancel.TabIndex = 48;
            btCancel.Text = "إلغاء";
            btCancel.UseVisualStyleBackColor = false;
            btCancel.Click += roundedButton1_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tajawal Medium", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(252, 539);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(184, 30);
            label10.TabIndex = 49;
            label10.Text = "المبلغ لكل ساعة";
            // 
            // btSave
            // 
            btSave.BackColor = Color.FromArgb(16, 185, 129);
            btSave.BorderColor = Color.FromArgb(16, 185, 129);
            btSave.BorderRadius = 10;
            btSave.BorderSize = 2;
            btSave.FlatAppearance.BorderSize = 0;
            btSave.FlatStyle = FlatStyle.Flat;
            btSave.Font = new Font("Tajawal", 16.1999989F, FontStyle.Bold);
            btSave.ForeColor = Color.White;
            btSave.Location = new Point(542, 728);
            btSave.Name = "btSave";
            btSave.Size = new Size(405, 75);
            btSave.TabIndex = 50;
            btSave.Text = "حفظ الحجز";
            btSave.UseVisualStyleBackColor = false;
            btSave.Click += roundedButton2_Click;
            // 
            // customPanel1
            // 
            customPanel1.BackColor = Color.White;
            customPanel1.BorderColor = Color.Black;
            customPanel1.BorderRadius = 10;
            customPanel1.BorderSize = 1F;
            customPanel1.Controls.Add(cmbCourtType);
            customPanel1.Location = new Point(538, 255);
            customPanel1.Margin = new Padding(4);
            customPanel1.Name = "customPanel1";
            customPanel1.ShowShadow = false;
            customPanel1.Size = new Size(420, 69);
            customPanel1.TabIndex = 51;
            // 
            // cmbCourtType
            // 
            cmbCourtType.DisplayMember = "CourtName";
            cmbCourtType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCourtType.FlatStyle = FlatStyle.Flat;
            cmbCourtType.FormattingEnabled = true;
            cmbCourtType.Location = new Point(22, 16);
            cmbCourtType.Margin = new Padding(4);
            cmbCourtType.Name = "cmbCourtType";
            cmbCourtType.RightToLeft = RightToLeft.Yes;
            cmbCourtType.Size = new Size(368, 33);
            cmbCourtType.TabIndex = 6;
            cmbCourtType.SelectedIndexChanged += cmbCourtType_SelectedIndexChanged;
            // 
            // customPanel2
            // 
            customPanel2.BackColor = Color.White;
            customPanel2.BorderColor = Color.Black;
            customPanel2.BorderRadius = 10;
            customPanel2.BorderSize = 1F;
            customPanel2.Controls.Add(cmbCourts);
            customPanel2.Location = new Point(26, 255);
            customPanel2.Margin = new Padding(4);
            customPanel2.Name = "customPanel2";
            customPanel2.ShowShadow = false;
            customPanel2.Size = new Size(412, 69);
            customPanel2.TabIndex = 50;
            // 
            // cmbCourts
            // 
            cmbCourts.DisplayMember = "CourtName";
            cmbCourts.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCourts.FlatStyle = FlatStyle.Flat;
            cmbCourts.FormattingEnabled = true;
            cmbCourts.Location = new Point(22, 16);
            cmbCourts.Margin = new Padding(4);
            cmbCourts.Name = "cmbCourts";
            cmbCourts.RightToLeft = RightToLeft.Yes;
            cmbCourts.Size = new Size(368, 33);
            cmbCourts.TabIndex = 6;
            // 
            // customPanel3
            // 
            customPanel3.BackColor = Color.White;
            customPanel3.BorderColor = Color.Black;
            customPanel3.BorderRadius = 10;
            customPanel3.BorderSize = 1F;
            customPanel3.Controls.Add(cmbDays);
            customPanel3.Location = new Point(538, 373);
            customPanel3.Margin = new Padding(4);
            customPanel3.Name = "customPanel3";
            customPanel3.RightToLeft = RightToLeft.Yes;
            customPanel3.ShowShadow = false;
            customPanel3.Size = new Size(420, 69);
            customPanel3.TabIndex = 50;
            // 
            // cmbDays
            // 
            cmbDays.DisplayMember = "CourtName";
            cmbDays.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDays.FlatStyle = FlatStyle.Flat;
            cmbDays.FormattingEnabled = true;
            cmbDays.Items.AddRange(new object[] { "السبت", "الاحد", "الاتنين", "التلاتاء", "الاربعاء", "الخميس", "الجمعة" });
            cmbDays.Location = new Point(22, 16);
            cmbDays.Margin = new Padding(4);
            cmbDays.Name = "cmbDays";
            cmbDays.RightToLeft = RightToLeft.Yes;
            cmbDays.Size = new Size(368, 33);
            cmbDays.TabIndex = 6;
            cmbDays.SelectedIndexChanged += cmbDays_SelectedIndexChanged;
            // 
            // labelHours
            // 
            labelHours.AutoSize = true;
            labelHours.Font = new Font("Segoe UI", 11F);
            labelHours.Location = new Point(752, 673);
            labelHours.Name = "labelHours";
            labelHours.Size = new Size(0, 30);
            labelHours.TabIndex = 55;
            // 
            // txtCustomerName
            // 
            txtCustomerName.BackColor = Color.White;
            txtCustomerName.BorderColor = Color.FromArgb(29, 53, 87);
            txtCustomerName.BorderRadius = 15;
            txtCustomerName.Icon = null;
            txtCustomerName.IconLocation = HorizontalAlignment.Left;
            txtCustomerName.IconSize = 20;
            txtCustomerName.Location = new Point(538, 129);
            txtCustomerName.Margin = new Padding(4);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.passwordChar = "\0";
            txtCustomerName.PlaceholderText = "أدخل النص هنا...";
            txtCustomerName.RightToLeft = RightToLeft.Yes;
            txtCustomerName.Size = new Size(412, 62);
            txtCustomerName.TabIndex = 59;
            txtCustomerName.Texts = "";
            // 
            // AddContract
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(978, 808);
            Controls.Add(txtCustomerName);
            Controls.Add(labelHours);
            Controls.Add(customPanel3);
            Controls.Add(customPanel2);
            Controls.Add(customPanel1);
            Controls.Add(btSave);
            Controls.Add(label10);
            Controls.Add(btCancel);
            Controls.Add(dtpEndDate);
            Controls.Add(label11);
            Controls.Add(dtpEndTime);
            Controls.Add(dtpStartDate);
            Controls.Add(dtpStartTime);
            Controls.Add(label9);
            Controls.Add(txtPricePerHour);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtPhone);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddContract";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddContract";
            Load += AddContract_Load;
            customPanel1.ResumeLayout(false);
            customPanel2.ResumeLayout(false);
            customPanel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dtpEndTime;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpStartTime;
        private Label label9;
        private CustomItems.AbdulTextBox txtPricePerHour;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private CustomItems.AbdulTextBox txtPhone;
        private Label label2;
        private Button button1;
        private Label label1;
        private DateTimePicker dtpEndDate;
        private Label label11;
        private CustomItems.RoundedButton btCancel;
        private Label label10;
        private CustomItems.RoundedButton btSave;
        private CustomItems.CustomPanel customPanel1;
        public ComboBox cmbCourtType;
        private CustomItems.CustomPanel customPanel2;
        public ComboBox cmbCourts;
        private CustomItems.CustomPanel customPanel3;
        public ComboBox cmbDays;
        private Label labelHours;
        private CustomItems.AbdulTextBox txtCustomerName;
    }
}