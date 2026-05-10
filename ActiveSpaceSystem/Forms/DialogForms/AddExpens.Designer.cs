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
            label4 = new Label();
            label8 = new Label();
            txtAmount = new ActiveSpaceSystem.CustomItems.AbdulTextBox();
            btCancel = new ActiveSpaceSystem.CustomItems.RoundedButton();
            label10 = new Label();
            btSave = new ActiveSpaceSystem.CustomItems.RoundedButton();
            cmbCategory = new ComboBox();
            panel1 = new ActiveSpaceSystem.CustomItems.CustomPanel();
            button1 = new Button();
            label3 = new Label();
            txtDescription = new ActiveSpaceSystem.CustomItems.AbdulTextBox();
            dtpDate = new DateTimePicker();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tajawal", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(277, 9);
            label1.Name = "label1";
            label1.Size = new Size(217, 33);
            label1.TabIndex = 61;
            label1.Text = "إضافة مصروف جديد";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tajawal", 11.999999F, FontStyle.Bold);
            label4.Location = new Point(295, 77);
            label4.Name = "label4";
            label4.Size = new Size(57, 29);
            label4.TabIndex = 68;
            label4.Text = "الفئة";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tajawal", 11.999999F, FontStyle.Bold);
            label8.Location = new Point(639, 77);
            label8.Name = "label8";
            label8.Size = new Size(70, 29);
            label8.TabIndex = 72;
            label8.Text = "التاريخ";
            // 
            // txtAmount
            // 
            txtAmount.BackColor = Color.White;
            txtAmount.BorderColor = Color.FromArgb(29, 53, 87);
            txtAmount.BorderRadius = 15;
            txtAmount.Icon = null;
            txtAmount.IconLocation = HorizontalAlignment.Left;
            txtAmount.IconSize = 20;
            txtAmount.Location = new Point(380, 217);
            txtAmount.Name = "txtAmount";
            txtAmount.passwordChar = "\0";
            txtAmount.PlaceholderText = "أدخل النص هنا...";
            txtAmount.RightToLeft = RightToLeft.Yes;
            txtAmount.Size = new Size(330, 50);
            txtAmount.TabIndex = 73;
            txtAmount.Texts = "";
            // 
            // btCancel
            // 
            btCancel.BackColor = Color.WhiteSmoke;
            btCancel.BorderColor = Color.White;
            btCancel.BorderRadius = 10;
            btCancel.BorderSize = 2;
            btCancel.FlatAppearance.BorderSize = 0;
            btCancel.FlatStyle = FlatStyle.Flat;
            btCancel.Font = new Font("Tajawal", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btCancel.ForeColor = Color.DimGray;
            btCancel.Location = new Point(71, 293);
            btCancel.Margin = new Padding(2, 2, 2, 2);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(277, 60);
            btCancel.TabIndex = 77;
            btCancel.Text = "إلغاء";
            btCancel.UseVisualStyleBackColor = false;
            btCancel.Click += btCancel_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tajawal", 11.999999F, FontStyle.Bold);
            label10.Location = new Point(642, 182);
            label10.Name = "label10";
            label10.Size = new Size(68, 29);
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
            btSave.Location = new Point(373, 293);
            btSave.Margin = new Padding(2, 2, 2, 2);
            btSave.Name = "btSave";
            btSave.Size = new Size(275, 60);
            btSave.TabIndex = 80;
            btSave.Text = "حفظ ";
            btSave.UseVisualStyleBackColor = false;
            btSave.Click += btSave_Click;
            // 
            // cmbCategory
            // 
            cmbCategory.DisplayMember = "CourtName";
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FlatStyle = FlatStyle.Flat;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(11, 14);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.RightToLeft = RightToLeft.Yes;
            cmbCategory.Size = new Size(295, 28);
            cmbCategory.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderColor = Color.Black;
            panel1.BorderRadius = 10;
            panel1.BorderSize = 1F;
            panel1.Controls.Add(cmbCategory);
            panel1.Location = new Point(21, 107);
            panel1.Name = "panel1";
            panel1.ShowShadow = false;
            panel1.Size = new Size(330, 55);
            panel1.TabIndex = 82;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(21, 9);
            button1.Name = "button1";
            button1.Size = new Size(31, 29);
            button1.TabIndex = 64;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tajawal", 11.999999F, FontStyle.Bold);
            label3.Location = new Point(277, 185);
            label3.Name = "label3";
            label3.Size = new Size(77, 29);
            label3.TabIndex = 78;
            label3.Text = "الوصف";
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.White;
            txtDescription.BorderColor = Color.FromArgb(29, 53, 87);
            txtDescription.BorderRadius = 15;
            txtDescription.Icon = null;
            txtDescription.IconLocation = HorizontalAlignment.Left;
            txtDescription.IconSize = 20;
            txtDescription.Location = new Point(21, 220);
            txtDescription.Name = "txtDescription";
            txtDescription.passwordChar = "\0";
            txtDescription.PlaceholderText = "أدخل النص هنا...";
            txtDescription.RightToLeft = RightToLeft.Yes;
            txtDescription.Size = new Size(330, 50);
            txtDescription.TabIndex = 85;
            txtDescription.Texts = "";
            // 
            // dtpDate
            // 
            dtpDate.CalendarFont = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(380, 115);
            dtpDate.Name = "dtpDate";
            dtpDate.RightToLeft = RightToLeft.Yes;
            dtpDate.RightToLeftLayout = true;
            dtpDate.Size = new Size(330, 34);
            dtpDate.TabIndex = 86;
            // 
            // AddExpens
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(729, 375);
            Controls.Add(dtpDate);
            Controls.Add(txtDescription);
            Controls.Add(panel1);
            Controls.Add(btSave);
            Controls.Add(label3);
            Controls.Add(label10);
            Controls.Add(btCancel);
            Controls.Add(txtAmount);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
            Name = "AddExpens";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddExpens";
            Load += AddExpens_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label4;
        private Label label8;
        private CustomItems.AbdulTextBox txtAmount;
        private CustomItems.RoundedButton btCancel;
        private Label label10;
        private CustomItems.RoundedButton btSave;
        public ComboBox cmbCategory;
        private CustomItems.CustomPanel panel1;
        private Button button1;
        private Label label3;
        private CustomItems.AbdulTextBox txtDescription;
        public DateTimePicker dtpDate;
    }
}