namespace ActiveSpaceSystem.Forms.SideForms
{
    partial class StaduimSteting
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
            roundedButton1 = new ActiveSpaceSystem.CustomItems.RoundedButton();
            label1 = new Label();
            dgvMonthlyContract = new ActiveSpaceSystem.CustomItems.CustomDataGridView();
            StdName = new DataGridViewTextBoxColumn();
            type = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            opentime = new DataGridViewTextBoxColumn();
            closeTime = new DataGridViewTextBoxColumn();
            Procedures = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMonthlyContract).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(roundedButton1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1130, 156);
            panel1.TabIndex = 1;
            // 
            // roundedButton1
            // 
            roundedButton1.BackColor = Color.FromArgb(39, 191, 141);
            roundedButton1.BorderColor = Color.FromArgb(39, 191, 141);
            roundedButton1.BorderRadius = 20;
            roundedButton1.BorderSize = 2;
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            roundedButton1.ForeColor = Color.White;
            roundedButton1.Image = Properties.Resources.icons8_plus_24;
            roundedButton1.Location = new Point(91, 32);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(225, 75);
            roundedButton1.TabIndex = 7;
            roundedButton1.Text = "إضافة ملعب جديد";
            roundedButton1.TextImageRelation = TextImageRelation.TextBeforeImage;
            roundedButton1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(749, 61);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(330, 46);
            label1.TabIndex = 0;
            label1.Text = "إدارة الملاعب والأسعار";
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
            dgvMonthlyContract.Columns.AddRange(new DataGridViewColumn[] { StdName, type, price, opentime, closeTime, Procedures });
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
            dgvMonthlyContract.Location = new Point(0, 164);
            dgvMonthlyContract.Margin = new Padding(4);
            dgvMonthlyContract.MultiSelect = false;
            dgvMonthlyContract.Name = "dgvMonthlyContract";
            dgvMonthlyContract.RightToLeft = RightToLeft.Yes;
            dgvMonthlyContract.RowHeadersVisible = false;
            dgvMonthlyContract.RowHeadersWidth = 51;
            dgvMonthlyContract.RowHeight = 50;
            dgvMonthlyContract.RowTemplate.Height = 50;
            dgvMonthlyContract.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMonthlyContract.Size = new Size(1130, 297);
            dgvMonthlyContract.TabIndex = 6;
            // 
            // StdName
            // 
            StdName.HeaderText = "اسم الملعب";
            StdName.MinimumWidth = 8;
            StdName.Name = "StdName";
            // 
            // type
            // 
            type.HeaderText = "النوع";
            type.MinimumWidth = 8;
            type.Name = "type";
            // 
            // price
            // 
            price.HeaderText = "السعر/الساعة";
            price.MinimumWidth = 8;
            price.Name = "price";
            // 
            // opentime
            // 
            opentime.HeaderText = "وقت الفتح";
            opentime.MinimumWidth = 8;
            opentime.Name = "opentime";
            // 
            // closeTime
            // 
            closeTime.HeaderText = " وقت الاغلاق";
            closeTime.MinimumWidth = 8;
            closeTime.Name = "closeTime";
            // 
            // Procedures
            // 
            Procedures.HeaderText = "االإجرأت";
            Procedures.MinimumWidth = 8;
            Procedures.Name = "Procedures";
            // 
            // StaduimSteting
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(1130, 489);
            Controls.Add(dgvMonthlyContract);
            Controls.Add(panel1);
            Name = "StaduimSteting";
            Text = "StaduimSteting";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMonthlyContract).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private CustomItems.RoundedButton roundedButton1;
        private Label label1;
        private CustomItems.CustomDataGridView dgvMonthlyContract;
        private DataGridViewTextBoxColumn StdName;
        private DataGridViewTextBoxColumn type;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn opentime;
        private DataGridViewTextBoxColumn closeTime;
        private DataGridViewTextBoxColumn Procedures;
    }
}