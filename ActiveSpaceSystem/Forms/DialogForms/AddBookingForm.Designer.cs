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
            nametxt = new ActiveSpaceSystem.CustomItems.AbdulTextBox();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            phonetxt = new ActiveSpaceSystem.CustomItems.AbdulTextBox();
            comboBox1 = new ComboBox();
            panel1 = new Panel();
            label4 = new Label();
            label5 = new Label();
            studiomtxt = new ActiveSpaceSystem.CustomItems.AbdulTextBox();
            dateTimePicker2 = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            dateTimePicker5 = new DateTimePicker();
            label9 = new Label();
            abdulTextBox1 = new ActiveSpaceSystem.CustomItems.AbdulTextBox();
            label10 = new Label();
            deposittxt = new ActiveSpaceSystem.CustomItems.AbdulTextBox();
            button2 = new Button();
            button3 = new Button();
            dateTimePicker4 = new DateTimePicker();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // nametxt
            // 
            nametxt.BackColor = Color.White;
            nametxt.BorderColor = Color.FromArgb(29, 53, 87);
            nametxt.BorderRadius = 15;
            nametxt.Icon = null;
            nametxt.IconLocation = HorizontalAlignment.Left;
            nametxt.IconSize = 20;
            nametxt.Location = new Point(454, 131);
            nametxt.Name = "nametxt";
            nametxt.PlaceholderText = "أدخل النص هنا...";
            nametxt.Size = new Size(330, 50);
            nametxt.TabIndex = 0;
            nametxt.Texts = "";
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
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tajawal Medium", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(673, 94);
            label2.Name = "label2";
            label2.Size = new Size(115, 25);
            label2.TabIndex = 3;
            label2.Text = "اسم العميل";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tajawal Medium", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(272, 94);
            label3.Name = "label3";
            label3.Size = new Size(105, 25);
            label3.TabIndex = 5;
            label3.Text = "رقم الهاتف";
            // 
            // phonetxt
            // 
            phonetxt.BackColor = Color.White;
            phonetxt.BorderColor = Color.FromArgb(29, 53, 87);
            phonetxt.BorderRadius = 15;
            phonetxt.Icon = null;
            phonetxt.IconLocation = HorizontalAlignment.Left;
            phonetxt.IconSize = 20;
            phonetxt.Location = new Point(47, 131);
            phonetxt.Name = "phonetxt";
            phonetxt.PlaceholderText = "أدخل النص هنا...";
            phonetxt.Size = new Size(330, 50);
            phonetxt.TabIndex = 4;
            phonetxt.Texts = "";
            // 
            // comboBox1
            // 
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(3, 11);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(327, 28);
            comboBox1.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBox1);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(454, 233);
            panel1.Name = "panel1";
            panel1.Size = new Size(336, 47);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
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
            label5.Location = new Point(302, 196);
            label5.Name = "label5";
            label5.Size = new Size(75, 25);
            label5.TabIndex = 10;
            label5.Text = "الملعب";
            // 
            // studiomtxt
            // 
            studiomtxt.BackColor = Color.White;
            studiomtxt.BorderColor = Color.FromArgb(29, 53, 87);
            studiomtxt.BorderRadius = 15;
            studiomtxt.Icon = null;
            studiomtxt.IconLocation = HorizontalAlignment.Left;
            studiomtxt.IconSize = 20;
            studiomtxt.Location = new Point(47, 233);
            studiomtxt.Name = "studiomtxt";
            studiomtxt.PlaceholderText = "أدخل النص هنا...";
            studiomtxt.Size = new Size(330, 50);
            studiomtxt.TabIndex = 9;
            studiomtxt.Texts = "";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarFont = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(451, 342);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(330, 27);
            dateTimePicker2.TabIndex = 1;
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
            label7.Location = new Point(270, 300);
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
            // dateTimePicker5
            // 
            dateTimePicker5.CalendarFont = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker5.Format = DateTimePickerFormat.Time;
            dateTimePicker5.Location = new Point(451, 429);
            dateTimePicker5.Name = "dateTimePicker5";
            dateTimePicker5.Size = new Size(330, 27);
            dateTimePicker5.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tajawal Medium", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(310, 392);
            label9.Name = "label9";
            label9.Size = new Size(64, 25);
            label9.TabIndex = 17;
            label9.Text = "المبلغ";
            // 
            // abdulTextBox1
            // 
            abdulTextBox1.BackColor = Color.White;
            abdulTextBox1.BorderColor = Color.FromArgb(29, 53, 87);
            abdulTextBox1.BorderRadius = 15;
            abdulTextBox1.Icon = null;
            abdulTextBox1.IconLocation = HorizontalAlignment.Left;
            abdulTextBox1.IconSize = 20;
            abdulTextBox1.Location = new Point(47, 429);
            abdulTextBox1.Name = "abdulTextBox1";
            abdulTextBox1.PlaceholderText = "أدخل النص هنا...";
            abdulTextBox1.Size = new Size(330, 50);
            abdulTextBox1.TabIndex = 16;
            abdulTextBox1.Texts = "";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tajawal Medium", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(521, 483);
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
            deposittxt.Location = new Point(258, 520);
            deposittxt.Name = "deposittxt";
            deposittxt.PlaceholderText = "أدخل النص هنا...";
            deposittxt.Size = new Size(330, 50);
            deposittxt.TabIndex = 18;
            deposittxt.Texts = "";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(16, 185, 129);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Tajawal", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(454, 595);
            button2.Name = "button2";
            button2.Size = new Size(327, 64);
            button2.TabIndex = 20;
            button2.Text = "حفظ الحجز";
            button2.UseVisualStyleBackColor = false;
            button2.Paint += button2_Paint;
            // 
            // button3
            // 
            button3.BackColor = Color.WhiteSmoke;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Tajawal", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.GrayText;
            button3.Location = new Point(47, 595);
            button3.Name = "button3";
            button3.Size = new Size(330, 64);
            button3.TabIndex = 21;
            button3.Text = "إلغاء";
            button3.UseVisualStyleBackColor = false;
            button3.Paint += button3_Paint;
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.CalendarFont = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker4.Format = DateTimePickerFormat.Short;
            dateTimePicker4.Location = new Point(47, 342);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(330, 27);
            dateTimePicker4.TabIndex = 0;
            // 
            // AddBookingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 691);
            Controls.Add(dateTimePicker5);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label10);
            Controls.Add(deposittxt);
            Controls.Add(label9);
            Controls.Add(abdulTextBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(studiomtxt);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(phonetxt);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(nametxt);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddBookingForm";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddBookingForm";
            Load += AddBookingForm_Load;
            Paint += AddBookingForm_Paint;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomItems.AbdulTextBox nametxt;
        private Label label1;
        private Button button1;
        private Label label2;
        private Label label3;
        private CustomItems.AbdulTextBox phonetxt;
        private ComboBox comboBox1;
        private Panel panel1;
        private Label label4;
        private Label label5;
        private CustomItems.AbdulTextBox studiomtxt;
        private Label label6;
        private DateTimePicker dateTimePicker2;
        private Label label7;
        private Label label8;
        private DateTimePicker dateTimePicker5;
        private Label label9;
        private CustomItems.AbdulTextBox abdulTextBox1;
        private Label label10;
        private CustomItems.AbdulTextBox deposittxt;
        private Button button2;
        private Button button3;
        private DateTimePicker dateTimePicker4;
    }
}