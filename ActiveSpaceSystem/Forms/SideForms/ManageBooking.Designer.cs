namespace ActiveSpaceSystem.Forms.SideForms
{
    partial class ManageBooking
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
            myGunaButton1 = new ActiveSpaceSystem.CustomItems.MyGunaButton();
            label3 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            customDataGridView1 = new ActiveSpaceSystem.CustomItems.CustomDataGridView();
            NameColumn = new DataGridViewTextBoxColumn();
            PhoneNumberColumn = new DataGridViewTextBoxColumn();
            StadiumTypeColumn = new DataGridViewTextBoxColumn();
            StadiumColumn = new DataGridViewTextBoxColumn();
            DayColumn = new DataGridViewTextBoxColumn();
            TimeColumn = new DataGridViewTextBoxColumn();
            StartDateColumn = new DataGridViewTextBoxColumn();
            EndDateColumn = new DataGridViewTextBoxColumn();
            BalanceColumn = new DataGridViewTextBoxColumn();
            StateColumn = new DataGridViewTextBoxColumn();
            statusCard4 = new ActiveSpaceSystem.CustomItems.StatusCard();
            roundedButton1 = new ActiveSpaceSystem.CustomItems.RoundedButton();
            abdulTextBox1 = new ActiveSpaceSystem.CustomItems.AbdulTextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)customDataGridView1).BeginInit();
            statusCard4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(248, 249, 250);
            panel1.Controls.Add(myGunaButton1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1256, 156);
            panel1.TabIndex = 1;
            // 
            // myGunaButton1
            // 
            myGunaButton1.BackColor = Color.FromArgb(39, 191, 141);
            myGunaButton1.BorderRadius = 20;
            myGunaButton1.FlatAppearance.BorderSize = 0;
            myGunaButton1.FlatStyle = FlatStyle.Flat;
            myGunaButton1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            myGunaButton1.ForeColor = Color.White;
            myGunaButton1.HoverBackColor = Color.FromArgb(29, 53, 87);
            myGunaButton1.Location = new Point(62, 62);
            myGunaButton1.Margin = new Padding(4);
            myGunaButton1.Name = "myGunaButton1";
            myGunaButton1.NormalBackColor = Color.FromArgb(39, 191, 141);
            myGunaButton1.Size = new Size(235, 59);
            myGunaButton1.TabIndex = 7;
            myGunaButton1.Text = "إضافة حجز جديد";
            myGunaButton1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(930, 108);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(217, 25);
            label3.TabIndex = 6;
            label3.Text = "إدارة ومتابعة جميع الحجوزات";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(930, 33);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(244, 46);
            label1.TabIndex = 0;
            label1.Text = "إدارة الحجوزات";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(248, 249, 250);
            panel2.Controls.Add(customDataGridView1);
            panel2.Controls.Add(statusCard4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 156);
            panel2.Name = "panel2";
            panel2.Size = new Size(1256, 642);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // customDataGridView1
            // 
            customDataGridView1.AllowUserToAddRows = false;
            customDataGridView1.AllowUserToResizeRows = false;
            customDataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            customDataGridView1.BackgroundColor = Color.White;
            customDataGridView1.BorderRadius = 15;
            customDataGridView1.BorderStyle = BorderStyle.None;
            customDataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            customDataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(243, 244, 246);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(33, 37, 41);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            customDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            customDataGridView1.ColumnHeadersHeight = 50;
            customDataGridView1.Columns.AddRange(new DataGridViewColumn[] { NameColumn, PhoneNumberColumn, StadiumTypeColumn, StadiumColumn, DayColumn, TimeColumn, StartDateColumn, EndDateColumn, BalanceColumn, StateColumn });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(240, 245, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            customDataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            customDataGridView1.EnableHeadersVisualStyles = false;
            customDataGridView1.GridColor = Color.FromArgb(230, 230, 230);
            customDataGridView1.HeaderBackColor = Color.FromArgb(243, 244, 246);
            customDataGridView1.HeaderForeColor = Color.FromArgb(33, 37, 41);
            customDataGridView1.Location = new Point(12, 191);
            customDataGridView1.Margin = new Padding(4);
            customDataGridView1.MultiSelect = false;
            customDataGridView1.Name = "customDataGridView1";
            customDataGridView1.RightToLeft = RightToLeft.Yes;
            customDataGridView1.RowHeadersVisible = false;
            customDataGridView1.RowHeadersWidth = 51;
            customDataGridView1.RowHeight = 50;
            customDataGridView1.RowTemplate.Height = 50;
            customDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            customDataGridView1.Size = new Size(1212, 346);
            customDataGridView1.TabIndex = 7;
            // 
            // NameColumn
            // 
            NameColumn.HeaderText = "اسم العميل";
            NameColumn.MinimumWidth = 6;
            NameColumn.Name = "NameColumn";
            // 
            // PhoneNumberColumn
            // 
            PhoneNumberColumn.HeaderText = " رقم الهاتف";
            PhoneNumberColumn.MinimumWidth = 6;
            PhoneNumberColumn.Name = "PhoneNumberColumn";
            // 
            // StadiumTypeColumn
            // 
            StadiumTypeColumn.HeaderText = "نوع الملعب";
            StadiumTypeColumn.MinimumWidth = 6;
            StadiumTypeColumn.Name = "StadiumTypeColumn";
            // 
            // StadiumColumn
            // 
            StadiumColumn.HeaderText = "الملعب";
            StadiumColumn.MinimumWidth = 6;
            StadiumColumn.Name = "StadiumColumn";
            // 
            // DayColumn
            // 
            DayColumn.HeaderText = "اليوم";
            DayColumn.MinimumWidth = 6;
            DayColumn.Name = "DayColumn";
            // 
            // TimeColumn
            // 
            TimeColumn.HeaderText = "الوقت";
            TimeColumn.MinimumWidth = 6;
            TimeColumn.Name = "TimeColumn";
            // 
            // StartDateColumn
            // 
            StartDateColumn.HeaderText = "تاريخ البداية";
            StartDateColumn.MinimumWidth = 6;
            StartDateColumn.Name = "StartDateColumn";
            // 
            // EndDateColumn
            // 
            EndDateColumn.HeaderText = "تاريخ النهاية";
            EndDateColumn.MinimumWidth = 6;
            EndDateColumn.Name = "EndDateColumn";
            // 
            // BalanceColumn
            // 
            BalanceColumn.HeaderText = "المبلغ";
            BalanceColumn.MinimumWidth = 6;
            BalanceColumn.Name = "BalanceColumn";
            // 
            // StateColumn
            // 
            StateColumn.HeaderText = "الحالة";
            StateColumn.MinimumWidth = 6;
            StateColumn.Name = "StateColumn";
            // 
            // statusCard4
            // 
            statusCard4.BackColor = Color.Transparent;
            statusCard4.BorderColor = Color.Black;
            statusCard4.BorderRadius = 15;
            statusCard4.CardBackColor = Color.White;
            statusCard4.Controls.Add(roundedButton1);
            statusCard4.Controls.Add(abdulTextBox1);
            statusCard4.Location = new Point(12, 44);
            statusCard4.Name = "statusCard4";
            statusCard4.Padding = new Padding(5);
            statusCard4.ShadowBlur = 5;
            statusCard4.ShadowColor = Color.FromArgb(0, 0, 192);
            statusCard4.ShowShadow = true;
            statusCard4.Size = new Size(1212, 113);
            statusCard4.TabIndex = 6;
            statusCard4.TitleColor = Color.Gray;
            statusCard4.TitleFont = new Font("Microsoft Sans Serif", 10F);
            statusCard4.TitleText = "";
            statusCard4.ValueColor = Color.FromArgb(46, 204, 113);
            statusCard4.ValueFont = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            statusCard4.ValueText = "";
            // 
            // roundedButton1
            // 
            roundedButton1.BackColor = Color.White;
            roundedButton1.BorderColor = Color.Black;
            roundedButton1.BorderRadius = 10;
            roundedButton1.BorderSize = 2;
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            roundedButton1.ForeColor = Color.Black;
            roundedButton1.Image = Properties.Resources.filter;
            roundedButton1.Location = new Point(93, 29);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(163, 58);
            roundedButton1.TabIndex = 3;
            roundedButton1.Text = "تصفية";
            roundedButton1.TextImageRelation = TextImageRelation.TextBeforeImage;
            roundedButton1.UseVisualStyleBackColor = false;
            // 
            // abdulTextBox1
            // 
            abdulTextBox1.BackColor = Color.White;
            abdulTextBox1.BorderColor = Color.FromArgb(29, 53, 87);
            abdulTextBox1.BorderRadius = 15;
            abdulTextBox1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            abdulTextBox1.Icon = Properties.Resources.magnifying_glass;
            abdulTextBox1.IconLocation = HorizontalAlignment.Right;
            abdulTextBox1.IconSize = 30;
            abdulTextBox1.Location = new Point(581, 36);
            abdulTextBox1.Margin = new Padding(4);
            abdulTextBox1.Name = "abdulTextBox1";
            abdulTextBox1.PlaceholderText = "بحث عن عميل أو رقم هاتف";
            abdulTextBox1.RightToLeft = RightToLeft.Yes;
            abdulTextBox1.Size = new Size(554, 51);
            abdulTextBox1.TabIndex = 2;
            // 
            // ManageBooking
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1256, 798);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageBooking";
            Text = "ManageBooking";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)customDataGridView1).EndInit();
            statusCard4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private CustomItems.MyGunaButton myGunaButton1;
        private Label label3;
        private Label label1;
        private Panel panel2;
        private CustomItems.StatusCard statusCard4;
        private CustomItems.AbdulTextBox abdulTextBox1;
        private CustomItems.RoundedButton roundedButton1;
        private CustomItems.CustomDataGridView customDataGridView1;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn PhoneNumberColumn;
        private DataGridViewTextBoxColumn StadiumTypeColumn;
        private DataGridViewTextBoxColumn StadiumColumn;
        private DataGridViewTextBoxColumn DayColumn;
        private DataGridViewTextBoxColumn TimeColumn;
        private DataGridViewTextBoxColumn StartDateColumn;
        private DataGridViewTextBoxColumn EndDateColumn;
        private DataGridViewTextBoxColumn BalanceColumn;
        private DataGridViewTextBoxColumn StateColumn;
    }
}