namespace ActiveSpaceSystem.Forms.SideForms
{
    partial class MonthlyContractForm
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
            infoBox1 = new ActiveSpaceSystem.CustomItems.InfoBox();
            statusCard1 = new ActiveSpaceSystem.CustomItems.StatusCard();
            statusCard2 = new ActiveSpaceSystem.CustomItems.StatusCard();
            statusCard3 = new ActiveSpaceSystem.CustomItems.StatusCard();
            dgvMonthlyContract = new ActiveSpaceSystem.CustomItems.CustomDataGridView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMonthlyContract).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(myGunaButton1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1278, 156);
            panel1.TabIndex = 0;
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
            myGunaButton1.Margin = new Padding(4, 4, 4, 4);
            myGunaButton1.Name = "myGunaButton1";
            myGunaButton1.NormalBackColor = Color.FromArgb(39, 191, 141);
            myGunaButton1.Size = new Size(235, 59);
            myGunaButton1.TabIndex = 7;
            myGunaButton1.Text = "إضافة عقد جديد";
            myGunaButton1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(874, 105);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(297, 25);
            label3.TabIndex = 6;
            label3.Text = "إدارة الحجوزات المتكررة والعقود الدورية";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(892, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(224, 46);
            label1.TabIndex = 0;
            label1.Text = "العقود الشهرية";
            // 
            // infoBox1
            // 
            infoBox1.BackColor = Color.Transparent;
            infoBox1.BorderColor = Color.FromArgb(180, 210, 255);
            infoBox1.BorderRadius = 15;
            infoBox1.Description = "العقود الشهرية تتيح حجز موعد ثابت أسبوعياً لفترة محددة. مثلاً: حجز ملعب كرة القدم كل يوم سبت الساعة 6 مساءً لمدة 3 أشهر";
            infoBox1.DescriptionColor = Color.FromArgb(69, 123, 157);
            infoBox1.DescriptionFont = new Font("Microsoft Sans Serif", 9F);
            infoBox1.FillColor = Color.FromArgb(240, 248, 255);
            infoBox1.Icon = null;
            infoBox1.IconSize = 25;
            infoBox1.Location = new Point(62, 175);
            infoBox1.Margin = new Padding(4, 4, 4, 4);
            infoBox1.Name = "infoBox1";
            infoBox1.Size = new Size(1155, 121);
            infoBox1.TabIndex = 1;
            infoBox1.Title = "ما هي العقود الشهرية؟";
            infoBox1.TitleColor = Color.FromArgb(29, 53, 87);
            infoBox1.TitleFont = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            // 
            // statusCard1
            // 
            statusCard1.BackColor = Color.Transparent;
            statusCard1.BorderColor = Color.FromArgb(240, 240, 240);
            statusCard1.BorderRadius = 15;
            statusCard1.CardBackColor = Color.White;
            statusCard1.Location = new Point(13, 4);
            statusCard1.Margin = new Padding(4, 4, 4, 4);
            statusCard1.Name = "statusCard1";
            statusCard1.Padding = new Padding(6, 6, 6, 6);
            statusCard1.ShadowBlur = 5;
            statusCard1.ShadowColor = Color.FromArgb(100, 0, 0, 0);
            statusCard1.ShowShadow = true;
            statusCard1.Size = new Size(382, 132);
            statusCard1.TabIndex = 2;
            statusCard1.TitleColor = Color.Gray;
            statusCard1.TitleFont = new Font("Microsoft Sans Serif", 10F);
            statusCard1.TitleText = "العقود النشطة";
            statusCard1.ValueColor = Color.FromArgb(46, 204, 113);
            statusCard1.ValueFont = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            statusCard1.ValueText = "18";
            // 
            // statusCard2
            // 
            statusCard2.BackColor = Color.Transparent;
            statusCard2.BorderColor = Color.FromArgb(240, 240, 240);
            statusCard2.BorderRadius = 15;
            statusCard2.CardBackColor = Color.White;
            statusCard2.Location = new Point(403, 4);
            statusCard2.Margin = new Padding(4, 4, 4, 4);
            statusCard2.Name = "statusCard2";
            statusCard2.Padding = new Padding(6, 6, 6, 6);
            statusCard2.ShadowBlur = 5;
            statusCard2.ShadowColor = Color.FromArgb(100, 0, 0, 0);
            statusCard2.ShowShadow = true;
            statusCard2.Size = new Size(382, 132);
            statusCard2.TabIndex = 3;
            statusCard2.TitleColor = Color.Gray;
            statusCard2.TitleFont = new Font("Microsoft Sans Serif", 10F);
            statusCard2.TitleText = "الإيرادات الشهرية المتوقعة";
            statusCard2.ValueColor = Color.FromArgb(30, 58, 138);
            statusCard2.ValueFont = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            statusCard2.ValueText = "15,200 د.ل";
            // 
            // statusCard3
            // 
            statusCard3.BackColor = Color.Transparent;
            statusCard3.BorderColor = Color.FromArgb(240, 240, 240);
            statusCard3.BorderRadius = 15;
            statusCard3.CardBackColor = Color.White;
            statusCard3.Location = new Point(793, 4);
            statusCard3.Margin = new Padding(4, 4, 4, 4);
            statusCard3.Name = "statusCard3";
            statusCard3.Padding = new Padding(6, 6, 6, 6);
            statusCard3.ShadowBlur = 5;
            statusCard3.ShadowColor = Color.FromArgb(100, 0, 0, 0);
            statusCard3.ShowShadow = true;
            statusCard3.Size = new Size(382, 132);
            statusCard3.TabIndex = 4;
            statusCard3.TitleColor = Color.Gray;
            statusCard3.TitleFont = new Font("Microsoft Sans Serif", 10F);
            statusCard3.TitleText = "عقود تنتهي هذا الشهر";
            statusCard3.ValueColor = Color.FromArgb(245, 158, 11);
            statusCard3.ValueFont = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            statusCard3.ValueText = "3";
            // 
            // dgvMonthlyContract
            // 
            dgvMonthlyContract.AllowUserToAddRows = false;
            dgvMonthlyContract.AllowUserToResizeRows = false;
            dgvMonthlyContract.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMonthlyContract.BackgroundColor = Color.White;
            dgvMonthlyContract.BorderRadius = 15;
            dgvMonthlyContract.BorderStyle = BorderStyle.None;
            dgvMonthlyContract.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMonthlyContract.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(243, 244, 246);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(33, 37, 41);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(243, 244, 246);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(33, 37, 41);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvMonthlyContract.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMonthlyContract.ColumnHeadersHeight = 50;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(240, 245, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvMonthlyContract.DefaultCellStyle = dataGridViewCellStyle2;
            dgvMonthlyContract.EnableHeadersVisualStyles = false;
            dgvMonthlyContract.GridColor = Color.FromArgb(230, 230, 230);
            dgvMonthlyContract.HeaderBackColor = Color.FromArgb(243, 244, 246);
            dgvMonthlyContract.HeaderForeColor = Color.FromArgb(33, 37, 41);
            dgvMonthlyContract.Location = new Point(62, 492);
            dgvMonthlyContract.Margin = new Padding(4, 4, 4, 4);
            dgvMonthlyContract.MultiSelect = false;
            dgvMonthlyContract.Name = "dgvMonthlyContract";
            dgvMonthlyContract.RightToLeft = RightToLeft.Yes;
            dgvMonthlyContract.RowHeadersVisible = false;
            dgvMonthlyContract.RowHeadersWidth = 51;
            dgvMonthlyContract.RowHeight = 50;
            dgvMonthlyContract.RowTemplate.Height = 50;
            dgvMonthlyContract.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMonthlyContract.Size = new Size(1155, 346);
            dgvMonthlyContract.TabIndex = 5;
            dgvMonthlyContract.CellContentClick += dgvMonthlyContract_CellContentClick;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(statusCard3);
            flowLayoutPanel1.Controls.Add(statusCard2);
            flowLayoutPanel1.Controls.Add(statusCard1);
            flowLayoutPanel1.Location = new Point(39, 299);
            flowLayoutPanel1.Margin = new Padding(4, 4, 4, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.RightToLeft = RightToLeft.Yes;
            flowLayoutPanel1.Size = new Size(1179, 216);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // MonthlyContractForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(1278, 854);
            Controls.Add(dgvMonthlyContract);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(infoBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            Name = "MonthlyContractForm";
            Text = "MonthlyContractForm";
            Load += MonthlyContractForm_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMonthlyContract).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private CustomItems.MyGunaButton myGunaButton1;
        private Label label3;
        private CustomItems.InfoBox infoBox1;
        private CustomItems.StatusCard statusCard1;
        private CustomItems.StatusCard statusCard2;
        private CustomItems.StatusCard statusCard3;
        private CustomItems.CustomDataGridView dgvMonthlyContract;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}