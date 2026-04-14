namespace ActiveSpaceSystem.Forms.SideForms
{
    partial class ReportsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportsForm));
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            panel2 = new Panel();
            dateTimePicker2 = new DateTimePicker();
            myGunaButton1 = new ActiveSpaceSystem.CustomItems.MyGunaButton();
            label4 = new Label();
            label3 = new Label();
            panel4 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            panel5 = new Panel();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            panel6 = new Panel();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            panel7 = new Panel();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            panel8 = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tajawal", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(30, 58, 138);
            label1.Location = new Point(709, 29);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(281, 44);
            label1.TabIndex = 0;
            label1.Text = "التقارير والإحصائيات";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tajawal Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(107, 114, 128);
            label2.Location = new Point(707, 78);
            label2.Name = "label2";
            label2.Size = new Size(283, 23);
            label2.TabIndex = 1;
            label2.Text = "تحليل شامل لأداء المجمع الرياضي";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(myGunaButton1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(12, 120);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(998, 109);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // panel3
            // 
            panel3.Controls.Add(dateTimePicker1);
            panel3.Location = new Point(644, 44);
            panel3.Name = "panel3";
            panel3.Size = new Size(334, 52);
            panel3.TabIndex = 9;
            panel3.Paint += panel3_Paint;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Tajawal Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(14, 11);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(305, 27);
            dateTimePicker1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(dateTimePicker2);
            panel2.Location = new Point(274, 44);
            panel2.Name = "panel2";
            panel2.Size = new Size(334, 52);
            panel2.TabIndex = 8;
            panel2.Paint += panel2_Paint_1;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarFont = new Font("Tajawal Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(14, 11);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(305, 27);
            dateTimePicker2.TabIndex = 1;
            // 
            // myGunaButton1
            // 
            myGunaButton1.BackColor = Color.FromArgb(16, 185, 129);
            myGunaButton1.BorderRadius = 20;
            myGunaButton1.FlatAppearance.BorderSize = 0;
            myGunaButton1.FlatStyle = FlatStyle.Flat;
            myGunaButton1.Font = new Font("Tajawal", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            myGunaButton1.ForeColor = Color.White;
            myGunaButton1.HoverBackColor = Color.FromArgb(29, 53, 87);
            myGunaButton1.Image = (Image)resources.GetObject("myGunaButton1.Image");
            myGunaButton1.ImageAlign = ContentAlignment.MiddleRight;
            myGunaButton1.Location = new Point(57, 29);
            myGunaButton1.Name = "myGunaButton1";
            myGunaButton1.NormalBackColor = Color.FromArgb(26, 188, 156);
            myGunaButton1.Size = new Size(162, 56);
            myGunaButton1.TabIndex = 4;
            myGunaButton1.Text = "تطبيق";
            myGunaButton1.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tajawal Medium", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(523, 11);
            label4.Name = "label4";
            label4.Size = new Size(85, 25);
            label4.TabIndex = 2;
            label4.Text = "إلى تاريخ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tajawal Medium", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(893, 12);
            label3.Name = "label3";
            label3.Size = new Size(85, 25);
            label3.TabIndex = 0;
            label3.Text = "من تاريخ";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label5);
            panel4.Font = new Font("Tajawal", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel4.ForeColor = Color.LimeGreen;
            panel4.Location = new Point(790, 255);
            panel4.Name = "panel4";
            panel4.Size = new Size(220, 122);
            panel4.TabIndex = 3;
            panel4.Paint += panel4_Paint;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(44, 85);
            label7.Name = "label7";
            label7.Size = new Size(156, 21);
            label7.TabIndex = 2;
            label7.Text = "+12% عن الشهر الماضي";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tajawal", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(16, 185, 129);
            label6.Location = new Point(52, 41);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.Yes;
            label6.Size = new Size(155, 40);
            label6.TabIndex = 1;
            label6.Text = "245,800 د.ل";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Tajawal", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(107, 114, 128);
            label5.Location = new Point(92, 12);
            label5.Name = "label5";
            label5.Size = new Size(115, 23);
            label5.TabIndex = 0;
            label5.Text = "إجمالي الإيرادات";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(label8);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(label10);
            panel5.Font = new Font("Tajawal", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel5.ForeColor = Color.LimeGreen;
            panel5.Location = new Point(533, 255);
            panel5.Name = "panel5";
            panel5.Size = new Size(220, 122);
            panel5.TabIndex = 4;
            panel5.Paint += panel5_Paint;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tajawal", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(20, 85);
            label8.Name = "label8";
            label8.Size = new Size(175, 23);
            label8.TabIndex = 2;
            label8.Text = "+18% عن الشهر الماضي";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tajawal", 16.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(30, 58, 138);
            label9.Location = new Point(136, 42);
            label9.Name = "label9";
            label9.RightToLeft = RightToLeft.Yes;
            label9.Size = new Size(59, 43);
            label9.TabIndex = 1;
            label9.Text = "821";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Tajawal", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(107, 114, 128);
            label10.Location = new Point(64, 12);
            label10.Name = "label10";
            label10.Size = new Size(131, 25);
            label10.TabIndex = 0;
            label10.Text = "إجمالي الحجوزات";
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(label11);
            panel6.Controls.Add(label12);
            panel6.Controls.Add(label13);
            panel6.Font = new Font("Tajawal", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel6.ForeColor = Color.LimeGreen;
            panel6.Location = new Point(272, 255);
            panel6.Name = "panel6";
            panel6.Size = new Size(220, 122);
            panel6.TabIndex = 4;
            panel6.Paint += panel6_Paint;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tajawal", 10.2F);
            label11.ForeColor = Color.FromArgb(107, 114, 128);
            label11.Location = new Point(126, 85);
            label11.Name = "label11";
            label11.Size = new Size(81, 23);
            label11.TabIndex = 2;
            label11.Text = "هذا الشهر";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Tajawal", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(37, 99, 235);
            label12.Location = new Point(86, 40);
            label12.Name = "label12";
            label12.RightToLeft = RightToLeft.Yes;
            label12.Size = new Size(121, 40);
            label12.TabIndex = 1;
            label12.Text = "8,193 د.ل";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Tajawal", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.FromArgb(107, 114, 128);
            label13.Location = new Point(45, 12);
            label13.Name = "label13";
            label13.Size = new Size(162, 25);
            label13.TabIndex = 0;
            label13.Text = "متوسط الإيراد اليومي";
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(label14);
            panel7.Controls.Add(label15);
            panel7.Controls.Add(label16);
            panel7.Font = new Font("Tajawal", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel7.ForeColor = Color.LimeGreen;
            panel7.Location = new Point(12, 255);
            panel7.Name = "panel7";
            panel7.Size = new Size(220, 122);
            panel7.TabIndex = 4;
            panel7.Paint += panel7_Paint;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Tajawal", 10.2F);
            label14.ForeColor = Color.FromArgb(107, 114, 128);
            label14.Location = new Point(86, 85);
            label14.Name = "label14";
            label14.Size = new Size(115, 23);
            label14.TabIndex = 2;
            label14.Text = "متوسط الشهر";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Tajawal", 16.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.FromArgb(13, 148, 136);
            label15.Location = new Point(132, 40);
            label15.Name = "label15";
            label15.RightToLeft = RightToLeft.Yes;
            label15.Size = new Size(69, 43);
            label15.TabIndex = 1;
            label15.Text = "76%";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Tajawal", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.FromArgb(107, 114, 128);
            label16.Location = new Point(86, 12);
            label16.Name = "label16";
            label16.Size = new Size(120, 25);
            label16.TabIndex = 0;
            label16.Text = "معدل الإشغال";
            // 
            // panel8
            // 
            panel8.Location = new Point(15, 407);
            panel8.Name = "panel8";
            panel8.Size = new Size(992, 387);
            panel8.TabIndex = 5;
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(1022, 683);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReportsForm";
            Text = "ReportsForm";
            Load += ReportsForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel1;
        private Label label3;
        private Label label4;
        private CustomItems.MyGunaButton myGunaButton1;
        private Panel panel2;
        private DateTimePicker dateTimePicker2;
        private Panel panel3;
        private DateTimePicker dateTimePicker1;
        private Panel panel4;
        private Label label7;
        private Label label6;
        private Label label5;
        private Panel panel5;
        private Label label8;
        private Label label9;
        private Label label10;
        private Panel panel6;
        private Label label11;
        private Label label12;
        private Label label13;
        private Panel panel7;
        private Label label14;
        private Label label15;
        private Label label16;
        private Panel panel8;
    }
}