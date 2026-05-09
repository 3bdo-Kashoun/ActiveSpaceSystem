namespace ActiveSpaceSystem.Forms.DialogForms
{
    partial class AddExpens
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddExpens));
            label1 = new Label();
            txtCustomerName = new ActiveSpaceSystem.CustomItems.AbdulTextBox();
            label2 = new Label();
            label4 = new Label();
            label8 = new Label();
            txtPricePerHour = new ActiveSpaceSystem.CustomItems.AbdulTextBox();
            dtpEndTime = new DateTimePicker();
            btCancel = new ActiveSpaceSystem.CustomItems.RoundedButton();
            label10 = new Label();
            btSave = new ActiveSpaceSystem.CustomItems.RoundedButton();
            cmbCourtType = new ComboBox();
            customPanel1 = new ActiveSpaceSystem.CustomItems.CustomPanel();
            button1 = new Button();
            label3 = new Label();
            abdulTextBox1 = new ActiveSpaceSystem.CustomItems.AbdulTextBox();
            customPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tajawal", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(654, 3);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(265, 42);
            label1.TabIndex = 61;
            label1.Text = "إضافة مصروف جديد";
            // 
            // txtCustomerName
            // 
            txtCustomerName.BackColor = Color.White;
            txtCustomerName.BorderColor = Color.FromArgb(29, 53, 87);
            txtCustomerName.BorderRadius = 15;
            txtCustomerName.Icon = null;
            txtCustomerName.IconLocation = HorizontalAlignment.Left;
            txtCustomerName.IconSize = 20;
            txtCustomerName.Location = new Point(13, 270);
            txtCustomerName.Margin = new Padding(4);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.passwordChar = "\0";
            txtCustomerName.PlaceholderText = "أدخل النص هنا...";
            txtCustomerName.RightToLeft = RightToLeft.Yes;
            txtCustomerName.Size = new Size(412, 62);
            txtCustomerName.TabIndex = 84;
            txtCustomerName.Texts = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tajawal Medium", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(338, 216);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 30);
            label2.TabIndex = 65;
            label2.Text = "العنوان";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tajawal Medium", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(364, 71);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(63, 30);
            label4.TabIndex = 68;
            label4.Text = "الفئة";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tajawal Medium", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(814, 86);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(79, 30);
            label8.TabIndex = 72;
            label8.Text = "التاريخ";
            // 
            // txtPricePerHour
            // 
            txtPricePerHour.BackColor = Color.White;
            txtPricePerHour.BorderColor = Color.FromArgb(29, 53, 87);
            txtPricePerHour.BorderRadius = 15;
            txtPricePerHour.Icon = null;
            txtPricePerHour.IconLocation = HorizontalAlignment.Left;
            txtPricePerHour.IconSize = 20;
            txtPricePerHour.Location = new Point(481, 270);
            txtPricePerHour.Margin = new Padding(4);
            txtPricePerHour.Name = "txtPricePerHour";
            txtPricePerHour.passwordChar = "\0";
            txtPricePerHour.PlaceholderText = "أدخل النص هنا...";
            txtPricePerHour.RightToLeft = RightToLeft.Yes;
            txtPricePerHour.Size = new Size(412, 62);
            txtPricePerHour.TabIndex = 73;
            txtPricePerHour.Texts = "";
            // 
            // dtpEndTime
            // 
            dtpEndTime.CalendarFont = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpEndTime.Format = DateTimePickerFormat.Time;
            dtpEndTime.Location = new Point(485, 147);
            dtpEndTime.Margin = new Padding(4);
            dtpEndTime.Name = "dtpEndTime";
            dtpEndTime.RightToLeft = RightToLeft.Yes;
            dtpEndTime.RightToLeftLayout = true;
            dtpEndTime.ShowUpDown = true;
            dtpEndTime.Size = new Size(412, 31);
            dtpEndTime.TabIndex = 62;
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
            btCancel.Location = new Point(15, 581);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(405, 75);
            btCancel.TabIndex = 77;
            btCancel.Text = "إلغاء";
            btCancel.UseVisualStyleBackColor = false;
            btCancel.Click += btCancel_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tajawal Medium", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(814, 209);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(77, 30);
            label10.TabIndex = 78;
            label10.Text = "المبلغ";
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
            btSave.Location = new Point(514, 581);
            btSave.Name = "btSave";
            btSave.Size = new Size(405, 75);
            btSave.TabIndex = 80;
            btSave.Text = "حفظ ";
            btSave.UseVisualStyleBackColor = false;
            btSave.Click += btSave_Click;
            // 
            // cmbCourtType
            // 
            cmbCourtType.DisplayMember = "CourtName";
            cmbCourtType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCourtType.FlatStyle = FlatStyle.Flat;
            cmbCourtType.FormattingEnabled = true;
            cmbCourtType.Location = new Point(14, 17);
            cmbCourtType.Margin = new Padding(4);
            cmbCourtType.Name = "cmbCourtType";
            cmbCourtType.RightToLeft = RightToLeft.Yes;
            cmbCourtType.Size = new Size(368, 33);
            cmbCourtType.TabIndex = 6;
            // 
            // customPanel1
            // 
            customPanel1.BackColor = Color.White;
            customPanel1.BorderColor = Color.Black;
            customPanel1.BorderRadius = 10;
            customPanel1.BorderSize = 1F;
            customPanel1.Controls.Add(cmbCourtType);
            customPanel1.Location = new Point(15, 124);
            customPanel1.Margin = new Padding(4);
            customPanel1.Name = "customPanel1";
            customPanel1.ShowShadow = false;
            customPanel1.Size = new Size(412, 69);
            customPanel1.TabIndex = 82;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(2, 3);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(39, 36);
            button1.TabIndex = 64;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tajawal Medium", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(457, 381);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(85, 30);
            label3.TabIndex = 78;
            label3.Text = "الوصف";
            // 
            // abdulTextBox1
            // 
            abdulTextBox1.BackColor = Color.White;
            abdulTextBox1.BorderColor = Color.FromArgb(29, 53, 87);
            abdulTextBox1.BorderRadius = 15;
            abdulTextBox1.Icon = null;
            abdulTextBox1.IconLocation = HorizontalAlignment.Left;
            abdulTextBox1.IconSize = 20;
            abdulTextBox1.Location = new Point(156, 427);
            abdulTextBox1.Margin = new Padding(4);
            abdulTextBox1.Name = "abdulTextBox1";
            abdulTextBox1.passwordChar = "\0";
            abdulTextBox1.PlaceholderText = "أدخل النص هنا...";
            abdulTextBox1.RightToLeft = RightToLeft.Yes;
            abdulTextBox1.Size = new Size(640, 98);
            abdulTextBox1.TabIndex = 85;
            abdulTextBox1.Texts = "";
            // 
            // AddExpens
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(937, 682);
            Controls.Add(abdulTextBox1);
            Controls.Add(txtCustomerName);
            Controls.Add(customPanel1);
            Controls.Add(btSave);
            Controls.Add(label3);
            Controls.Add(label10);
            Controls.Add(btCancel);
            Controls.Add(dtpEndTime);
            Controls.Add(txtPricePerHour);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddExpens";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddExpens";
            customPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CustomItems.AbdulTextBox txtCustomerName;
        private Label label2;
        private Label label4;
        private Label label8;
        private CustomItems.AbdulTextBox txtPricePerHour;
        private DateTimePicker dtpEndTime;
        private CustomItems.RoundedButton btCancel;
        private Label label10;
        private CustomItems.RoundedButton btSave;
        public ComboBox cmbCourtType;
        private CustomItems.CustomPanel customPanel1;
        private Button button1;
        private Label label3;
        private CustomItems.AbdulTextBox abdulTextBox1;
    }
}