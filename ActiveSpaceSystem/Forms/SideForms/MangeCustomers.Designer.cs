namespace ActiveSpaceSystem.Forms.SideForms
{
    partial class MangeCustomers
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
            customerCard2 = new ActiveSpaceSystem.CustomItems.CustomerCard();
            customerCard1 = new ActiveSpaceSystem.CustomItems.CustomerCard();
            customerCard3 = new ActiveSpaceSystem.CustomItems.CustomerCard();
            panel1 = new Panel();
            roundedButton1 = new ActiveSpaceSystem.CustomItems.RoundedButton();
            label3 = new Label();
            label1 = new Label();
            customActionButton2 = new ActiveSpaceSystem.CustomItems.CustomActionButton();
            customActionButton1 = new ActiveSpaceSystem.CustomItems.CustomActionButton();
            abdulTextBox1 = new ActiveSpaceSystem.CustomItems.AbdulTextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            customPanel1 = new ActiveSpaceSystem.CustomItems.CustomPanel();
            panel2 = new Panel();
            dgvCustomers = new ActiveSpaceSystem.CustomItems.CustomDataGridView();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            customPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            SuspendLayout();
            // 
            // customerCard2
            // 
            customerCard2.BackColor = Color.White;
            customerCard2.BorderRadius = 15;
            customerCard2.Dock = DockStyle.Fill;
            customerCard2.IconBackColor = Color.FromArgb(235, 239, 253);
            customerCard2.IconImage = Properties.Resources.icons8_users_48__1_;
            customerCard2.IconSize = 32;
            customerCard2.Location = new Point(856, 4);
            customerCard2.Margin = new Padding(4);
            customerCard2.Name = "customerCard2";
            customerCard2.Size = new Size(418, 159);
            customerCard2.TabIndex = 1;
            customerCard2.TitleColor = Color.Gray;
            customerCard2.TitleFont = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customerCard2.TitleText = "إجمالي العملاء";
            customerCard2.ValueColor = Color.MidnightBlue;
            customerCard2.ValueFont = new Font("Segoe UI", 18F, FontStyle.Bold);
            customerCard2.ValueText = "156";
            // 
            // customerCard1
            // 
            customerCard1.BackColor = Color.White;
            customerCard1.BorderRadius = 15;
            customerCard1.Dock = DockStyle.Fill;
            customerCard1.IconBackColor = Color.FromArgb(231, 248, 242);
            customerCard1.IconImage = Properties.Resources.icons8_users_48;
            customerCard1.IconSize = 32;
            customerCard1.Location = new Point(430, 4);
            customerCard1.Margin = new Padding(4);
            customerCard1.Name = "customerCard1";
            customerCard1.Size = new Size(418, 159);
            customerCard1.TabIndex = 2;
            customerCard1.TitleColor = Color.Gray;
            customerCard1.TitleFont = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customerCard1.TitleText = "العملاء النشطون";
            customerCard1.ValueColor = Color.FromArgb(100, 185, 129);
            customerCard1.ValueFont = new Font("Segoe UI", 18F, FontStyle.Bold);
            customerCard1.ValueText = "120";
            // 
            // customerCard3
            // 
            customerCard3.BackColor = Color.White;
            customerCard3.BorderRadius = 15;
            customerCard3.Dock = DockStyle.Fill;
            customerCard3.IconBackColor = Color.FromArgb(251, 233, 233);
            customerCard3.IconImage = Properties.Resources.icons8_alert_50;
            customerCard3.IconSize = 32;
            customerCard3.Location = new Point(4, 4);
            customerCard3.Margin = new Padding(4);
            customerCard3.Name = "customerCard3";
            customerCard3.Size = new Size(418, 159);
            customerCard3.TabIndex = 3;
            customerCard3.TitleColor = Color.Gray;
            customerCard3.TitleFont = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customerCard3.TitleText = "إجمالي الديون";
            customerCard3.ValueColor = Color.FromArgb(220, 38, 38);
            customerCard3.ValueFont = new Font("Segoe UI", 18F, FontStyle.Bold);
            customerCard3.ValueText = "156";
            // 
            // panel1
            // 
            panel1.Controls.Add(roundedButton1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1278, 168);
            panel1.TabIndex = 4;
            // 
            // roundedButton1
            // 
            roundedButton1.Anchor = AnchorStyles.Left;
            roundedButton1.BackColor = Color.FromArgb(38, 191, 141);
            roundedButton1.BorderColor = Color.PaleVioletRed;
            roundedButton1.BorderRadius = 15;
            roundedButton1.BorderSize = 0;
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedButton1.ForeColor = Color.White;
            roundedButton1.Image = Properties.Resources.icons8_add_50__1_;
            roundedButton1.ImageAlign = ContentAlignment.MiddleRight;
            roundedButton1.Location = new Point(44, 55);
            roundedButton1.Margin = new Padding(4);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Padding = new Padding(25, 12, 25, 12);
            roundedButton1.Size = new Size(285, 80);
            roundedButton1.TabIndex = 10;
            roundedButton1.Text = "إضافة عميل جديد";
            roundedButton1.TextAlign = ContentAlignment.MiddleLeft;
            roundedButton1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(1004, 99);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(227, 25);
            label3.TabIndex = 9;
            label3.Text = "متابعة بيانات وحجوزات العملاء";
            label3.Click += label3_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(1035, 35);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(196, 46);
            label1.TabIndex = 8;
            label1.Text = "إدارة العملاء";
            // 
            // customActionButton2
            // 
            customActionButton2.BackColor = Color.White;
            customActionButton2.BorderColor = Color.FromArgb(225, 225, 225);
            customActionButton2.BorderRadius = 10;
            customActionButton2.BorderSize = 1;
            customActionButton2.ButtonIcon = null;
            customActionButton2.FlatAppearance.BorderSize = 0;
            customActionButton2.FlatStyle = FlatStyle.Flat;
            customActionButton2.Font = new Font("Microsoft Sans Serif", 12F);
            customActionButton2.ForeColor = Color.FromArgb(220, 38, 38);
            customActionButton2.IconAlignment = ContentAlignment.MiddleLeft;
            customActionButton2.IconSize = new Size(16, 16);
            customActionButton2.IsToggled = false;
            customActionButton2.Location = new Point(18, 38);
            customActionButton2.Margin = new Padding(4);
            customActionButton2.Name = "customActionButton2";
            customActionButton2.Size = new Size(179, 58);
            customActionButton2.TabIndex = 9;
            customActionButton2.Text = "عليه ديون";
            customActionButton2.ToggleColor = Color.FromArgb(245, 245, 245);
            customActionButton2.UseVisualStyleBackColor = false;
            // 
            // customActionButton1
            // 
            customActionButton1.BackColor = Color.White;
            customActionButton1.BorderColor = Color.FromArgb(225, 225, 225);
            customActionButton1.BorderRadius = 10;
            customActionButton1.BorderSize = 1;
            customActionButton1.ButtonIcon = null;
            customActionButton1.FlatAppearance.BorderSize = 0;
            customActionButton1.FlatStyle = FlatStyle.Flat;
            customActionButton1.Font = new Font("Microsoft Sans Serif", 12F);
            customActionButton1.IconAlignment = ContentAlignment.MiddleLeft;
            customActionButton1.IconSize = new Size(16, 16);
            customActionButton1.IsToggled = false;
            customActionButton1.Location = new Point(204, 38);
            customActionButton1.Margin = new Padding(4);
            customActionButton1.Name = "customActionButton1";
            customActionButton1.Size = new Size(148, 58);
            customActionButton1.TabIndex = 4;
            customActionButton1.Text = "الكل";
            customActionButton1.ToggleColor = Color.FromArgb(245, 245, 245);
            customActionButton1.UseVisualStyleBackColor = false;
            // 
            // abdulTextBox1
            // 
            abdulTextBox1.Anchor = AnchorStyles.Right;
            abdulTextBox1.BackColor = Color.White;
            abdulTextBox1.BorderColor = Color.FromArgb(29, 53, 87);
            abdulTextBox1.BorderRadius = 15;
            abdulTextBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            abdulTextBox1.Icon = Properties.Resources.magnifying_glass;
            abdulTextBox1.IconLocation = HorizontalAlignment.Right;
            abdulTextBox1.IconSize = 30;
            abdulTextBox1.Location = new Point(430, 38);
            abdulTextBox1.Margin = new Padding(2);
            abdulTextBox1.Name = "abdulTextBox1";
            abdulTextBox1.PlaceholderText = "بحث عن رقم هاتف";
            abdulTextBox1.RightToLeft = RightToLeft.Yes;
            abdulTextBox1.Size = new Size(802, 58);
            abdulTextBox1.TabIndex = 3;
            abdulTextBox1.Texts = "";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(customerCard2, 2, 0);
            tableLayoutPanel1.Controls.Add(customerCard1, 1, 0);
            tableLayoutPanel1.Controls.Add(customerCard3, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 168);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1278, 167);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // customPanel1
            // 
            customPanel1.BackColor = Color.White;
            customPanel1.BorderColor = Color.FromArgb(230, 230, 230);
            customPanel1.BorderRadius = 20;
            customPanel1.BorderSize = 1F;
            customPanel1.Controls.Add(customActionButton2);
            customPanel1.Controls.Add(abdulTextBox1);
            customPanel1.Controls.Add(customActionButton1);
            customPanel1.Dock = DockStyle.Top;
            customPanel1.Location = new Point(0, 335);
            customPanel1.Name = "customPanel1";
            customPanel1.ShowShadow = true;
            customPanel1.Size = new Size(1278, 150);
            customPanel1.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvCustomers);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 485);
            panel2.Name = "panel2";
            panel2.Size = new Size(1278, 369);
            panel2.TabIndex = 11;
            // 
            // dgvCustomers
            // 
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.AllowUserToResizeRows = false;
            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCustomers.BackgroundColor = Color.White;
            dgvCustomers.BorderRadius = 15;
            dgvCustomers.BorderStyle = BorderStyle.None;
            dgvCustomers.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvCustomers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(243, 244, 246);
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(33, 37, 41);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(243, 244, 246);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(33, 37, 41);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvCustomers.ColumnHeadersHeight = 50;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(240, 245, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvCustomers.DefaultCellStyle = dataGridViewCellStyle6;
            dgvCustomers.Dock = DockStyle.Fill;
            dgvCustomers.EnableHeadersVisualStyles = false;
            dgvCustomers.GridColor = Color.White;
            dgvCustomers.HeaderBackColor = Color.FromArgb(243, 244, 246);
            dgvCustomers.HeaderForeColor = Color.FromArgb(33, 37, 41);
            dgvCustomers.Location = new Point(0, 0);
            dgvCustomers.Margin = new Padding(4);
            dgvCustomers.MultiSelect = false;
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dgvCustomers.RightToLeft = RightToLeft.Yes;
            dgvCustomers.RowHeadersVisible = false;
            dgvCustomers.RowHeadersWidth = 51;
            dgvCustomers.RowHeight = 50;
            dgvCustomers.RowTemplate.Height = 50;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.Size = new Size(1278, 369);
            dgvCustomers.TabIndex = 9;
            // 
            // MangeCustomers
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(1278, 854);
            Controls.Add(panel2);
            Controls.Add(customPanel1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "MangeCustomers";
            Text = "MangeCustomers";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            customPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        
        private CustomItems.CustomerCard customerCard2;
        private CustomItems.CustomerCard customerCard1;
        private CustomItems.CustomerCard customerCard3;
        private Panel panel1;
        private Label label3;
        private Label label1;
        private CustomItems.AbdulTextBox abdulTextBox1;
        private CustomItems.CustomActionButton customActionButton2;
        private CustomItems.CustomActionButton customActionButton1;
        private CustomItems.RoundedButton roundedButton1;
        private TableLayoutPanel tableLayoutPanel1;
        private CustomItems.CustomPanel customPanel1;
        private CustomItems.CustomDataGridView dgvCustomers;
    }
}