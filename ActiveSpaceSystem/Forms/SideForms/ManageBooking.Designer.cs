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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new Panel();
            roundedButton1 = new ActiveSpaceSystem.CustomItems.RoundedButton();
            label3 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            customPanel1 = new ActiveSpaceSystem.CustomItems.CustomPanel();
            customActionButton1 = new ActiveSpaceSystem.CustomItems.CustomActionButton();
            abdulTextBox1 = new ActiveSpaceSystem.CustomItems.AbdulTextBox();
            dgvBookings = new ActiveSpaceSystem.CustomItems.CustomDataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookings).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(248, 249, 250);
            panel1.Controls.Add(roundedButton1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1022, 125);
            panel1.TabIndex = 1;
            // 
            // roundedButton1
            // 
            roundedButton1.BackColor = Color.FromArgb(38, 191, 141);
            roundedButton1.BorderColor = Color.PaleVioletRed;
            roundedButton1.BorderRadius = 15;
            roundedButton1.BorderSize = 0;
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.Font = new Font("Tajawal", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedButton1.ForeColor = Color.White;
            roundedButton1.Image = Properties.Resources.icons8_add_50__1_;
            roundedButton1.ImageAlign = ContentAlignment.MiddleRight;
            roundedButton1.Location = new Point(24, 35);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Padding = new Padding(20, 10, 20, 10);
            roundedButton1.Size = new Size(219, 64);
            roundedButton1.TabIndex = 7;
            roundedButton1.Text = "إضافة حجز جديد";
            roundedButton1.TextAlign = ContentAlignment.MiddleLeft;
            roundedButton1.UseVisualStyleBackColor = false;
            roundedButton1.Click += roundedButton1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tajawal", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(775, 76);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(208, 23);
            label3.TabIndex = 6;
            label3.Text = "إدارة ومتابعة جميع الحجوزات";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tajawal Medium", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(755, 28);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(237, 48);
            label1.TabIndex = 0;
            label1.Text = "إدارة الحجوزات";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(248, 249, 250);
            panel2.Controls.Add(customPanel1);
            panel2.Controls.Add(dgvBookings);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 125);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1022, 558);
            panel2.TabIndex = 2;
            // 
            // customPanel1
            // 
            customPanel1.BackColor = Color.White;
            customPanel1.BorderColor = Color.FromArgb(230, 230, 230);
            customPanel1.BorderRadius = 20;
            customPanel1.BorderSize = 1F;
            customPanel1.Controls.Add(customActionButton1);
            customPanel1.Controls.Add(abdulTextBox1);
            customPanel1.Location = new Point(24, 27);
            customPanel1.Name = "customPanel1";
            customPanel1.ShowShadow = true;
            customPanel1.Size = new Size(968, 107);
            customPanel1.TabIndex = 8;
            // 
            // customActionButton1
            // 
            customActionButton1.BackColor = Color.White;
            customActionButton1.BorderColor = Color.FromArgb(225, 225, 225);
            customActionButton1.BorderRadius = 10;
            customActionButton1.BorderSize = 1;
            customActionButton1.ButtonIcon = Properties.Resources.filter;
            customActionButton1.FlatAppearance.BorderSize = 0;
            customActionButton1.FlatStyle = FlatStyle.Flat;
            customActionButton1.Font = new Font("Tajawal", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customActionButton1.IconAlignment = ContentAlignment.MiddleRight;
            customActionButton1.IconSize = new Size(24, 24);
            customActionButton1.IsToggled = false;
            customActionButton1.Location = new Point(60, 28);
            customActionButton1.Name = "customActionButton1";
            customActionButton1.Size = new Size(151, 50);
            customActionButton1.TabIndex = 1;
            customActionButton1.Text = "تصفية";
            customActionButton1.ToggleColor = Color.White;
            customActionButton1.UseVisualStyleBackColor = false;
            // 
            // abdulTextBox1
            // 
            abdulTextBox1.BackColor = Color.White;
            abdulTextBox1.BorderColor = Color.FromArgb(29, 53, 87);
            abdulTextBox1.BorderRadius = 15;
            abdulTextBox1.Icon = Properties.Resources.magnifying_glass;
            abdulTextBox1.IconLocation = HorizontalAlignment.Right;
            abdulTextBox1.IconSize = 32;
            abdulTextBox1.Location = new Point(287, 28);
            abdulTextBox1.Name = "abdulTextBox1";
            abdulTextBox1.PlaceholderText = "بحث عن رقم الهاتف";
            abdulTextBox1.RightToLeft = RightToLeft.Yes;
            abdulTextBox1.Size = new Size(636, 50);
            abdulTextBox1.TabIndex = 0;
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
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(243, 244, 246);
            dataGridViewCellStyle5.Font = new Font("Tajawal Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(33, 37, 41);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(243, 244, 246);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(33, 37, 41);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvBookings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvBookings.ColumnHeadersHeight = 50;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Tajawal", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(240, 245, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvBookings.DefaultCellStyle = dataGridViewCellStyle6;
            dgvBookings.EnableHeadersVisualStyles = false;
            dgvBookings.GridColor = Color.White;
            dgvBookings.HeaderBackColor = Color.FromArgb(243, 244, 246);
            dgvBookings.HeaderForeColor = Color.FromArgb(33, 37, 41);
            dgvBookings.Location = new Point(24, 155);
            dgvBookings.MultiSelect = false;
            dgvBookings.Name = "dgvBookings";
            dgvBookings.ReadOnly = true;
            dgvBookings.RightToLeft = RightToLeft.Yes;
            dgvBookings.RowHeadersVisible = false;
            dgvBookings.RowHeadersWidth = 51;
            dgvBookings.RowHeight = 50;
            dgvBookings.RowTemplate.Height = 50;
            dgvBookings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBookings.Size = new Size(968, 374);
            dgvBookings.TabIndex = 7;
            // 
            // ManageBooking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(1022, 683);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "ManageBooking";
            Text = "ManageBooking";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            customPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBookings).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label1;
        private Panel panel2;
        private CustomItems.CustomDataGridView dgvBookings;
        private CustomItems.CustomPanel customPanel1;
        private CustomItems.AbdulTextBox abdulTextBox1;
        private CustomItems.CustomActionButton customActionButton1;
        private CustomItems.RoundedButton roundedButton1;
    }
}