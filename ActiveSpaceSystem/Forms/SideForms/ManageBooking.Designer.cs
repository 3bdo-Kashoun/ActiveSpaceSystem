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
            dgvBookings = new ActiveSpaceSystem.CustomItems.CustomDataGridView();
            statusCard4 = new ActiveSpaceSystem.CustomItems.StatusCard();
            roundedButton1 = new ActiveSpaceSystem.CustomItems.RoundedButton();
            abdulTextBox1 = new ActiveSpaceSystem.CustomItems.AbdulTextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookings).BeginInit();
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
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1278, 156);
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
            myGunaButton1.Location = new Point(30, 65);
            myGunaButton1.Margin = new Padding(4, 4, 4, 4);
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
            label3.Location = new Point(921, 95);
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
            label1.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(904, 35);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(244, 46);
            label1.TabIndex = 0;
            label1.Text = "إدارة الحجوزات";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(248, 249, 250);
            panel2.Controls.Add(dgvBookings);
            panel2.Controls.Add(statusCard4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 156);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1278, 698);
            panel2.TabIndex = 2;
            // 
            // dgvBookings
            // 
            dgvBookings.AllowUserToAddRows = false;
            dgvBookings.AllowUserToResizeRows = false;
            dgvBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBookings.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvBookings.BackgroundColor = Color.White;
            dgvBookings.BorderRadius = 15;
            dgvBookings.BorderStyle = BorderStyle.None;
            dgvBookings.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvBookings.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(243, 244, 246);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(33, 37, 41);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(243, 244, 246);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(33, 37, 41);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvBookings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvBookings.ColumnHeadersHeight = 50;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(240, 245, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvBookings.DefaultCellStyle = dataGridViewCellStyle2;
            dgvBookings.EnableHeadersVisualStyles = false;
            dgvBookings.GridColor = Color.White;
            dgvBookings.HeaderBackColor = Color.FromArgb(243, 244, 246);
            dgvBookings.HeaderForeColor = Color.FromArgb(33, 37, 41);
            dgvBookings.Location = new Point(30, 198);
            dgvBookings.Margin = new Padding(4, 4, 4, 4);
            dgvBookings.MultiSelect = false;
            dgvBookings.Name = "dgvBookings";
            dgvBookings.ReadOnly = true;
            dgvBookings.RightToLeft = RightToLeft.Yes;
            dgvBookings.RowHeadersVisible = false;
            dgvBookings.RowHeadersWidth = 51;
            dgvBookings.RowHeight = 50;
            dgvBookings.RowTemplate.Height = 50;
            dgvBookings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBookings.Size = new Size(1210, 468);
            dgvBookings.TabIndex = 7;
            // 
            // statusCard4
            // 
            statusCard4.BackColor = Color.Transparent;
            statusCard4.BorderColor = Color.Black;
            statusCard4.BorderRadius = 15;
            statusCard4.CardBackColor = Color.White;
            statusCard4.Controls.Add(roundedButton1);
            statusCard4.Controls.Add(abdulTextBox1);
            statusCard4.Location = new Point(30, 41);
            statusCard4.Margin = new Padding(2);
            statusCard4.Name = "statusCard4";
            statusCard4.Padding = new Padding(5, 5, 5, 5);
            statusCard4.ShadowBlur = 5;
            statusCard4.ShadowColor = Color.FromArgb(0, 0, 192);
            statusCard4.ShowShadow = true;
            statusCard4.Size = new Size(1210, 112);
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
            roundedButton1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedButton1.ForeColor = Color.Black;
            roundedButton1.Image = Properties.Resources.filter;
            roundedButton1.Location = new Point(92, 29);
            roundedButton1.Margin = new Padding(2);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(162, 58);
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
            abdulTextBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            abdulTextBox1.Icon = Properties.Resources.magnifying_glass;
            abdulTextBox1.IconLocation = HorizontalAlignment.Right;
            abdulTextBox1.IconSize = 30;
            abdulTextBox1.Location = new Point(320, 29);
            abdulTextBox1.Margin = new Padding(2);
            abdulTextBox1.Name = "abdulTextBox1";
            abdulTextBox1.PlaceholderText = "بحث عن رقم هاتف";
            abdulTextBox1.RightToLeft = RightToLeft.Yes;
            abdulTextBox1.Size = new Size(802, 58);
            abdulTextBox1.TabIndex = 2;
            // 
            // ManageBooking
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(1278, 854);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "ManageBooking";
            Text = "ManageBooking";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBookings).EndInit();
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
        private CustomItems.CustomDataGridView dgvBookings;
    }
}