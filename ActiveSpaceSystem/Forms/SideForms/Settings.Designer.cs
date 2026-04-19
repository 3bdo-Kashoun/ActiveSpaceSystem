namespace ActiveSpaceSystem.Forms.SideForms
{
    partial class Settings
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
            panel1 = new Panel();
            label3 = new Label();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            tabButton1 = new ActiveSpaceSystem.CustomItems.TabButton();
            tabButton3 = new ActiveSpaceSystem.CustomItems.TabButton();
            tabButton2 = new ActiveSpaceSystem.CustomItems.TabButton();
            mainContainer = new Panel();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1256, 156);
            panel1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(984, 96);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(224, 25);
            label3.TabIndex = 6;
            label3.Text = "إدارة إعدادات النظام والملاعب";
            label3.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(1052, 30);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(156, 46);
            label1.TabIndex = 0;
            label1.Text = "الإعدادات";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(tabButton1);
            flowLayoutPanel1.Controls.Add(tabButton3);
            flowLayoutPanel1.Controls.Add(tabButton2);
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(56, 163);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1152, 121);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // tabButton1
            // 
            tabButton1.BackColor = Color.FromArgb(41, 51, 146);
            tabButton1.BorderColor = Color.White;
            tabButton1.BorderRadius = 20;
            tabButton1.BorderSize = 2;
            tabButton1.FlatAppearance.BorderSize = 0;
            tabButton1.FlatStyle = FlatStyle.Flat;
            tabButton1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            tabButton1.ForeColor = Color.White;
            tabButton1.IsActive = true;
            tabButton1.Location = new Point(924, 3);
            tabButton1.Name = "tabButton1";
            tabButton1.Size = new Size(225, 75);
            tabButton1.TabIndex = 7;
            tabButton1.Text = "إعدادات الملاعب";
            tabButton1.UseVisualStyleBackColor = false;
            tabButton1.Click += tabButton1_Click;
            // 
            // tabButton3
            // 
            tabButton3.BackColor = Color.White;
            tabButton3.BorderColor = Color.White;
            tabButton3.BorderRadius = 20;
            tabButton3.BorderSize = 2;
            tabButton3.FlatAppearance.BorderSize = 0;
            tabButton3.FlatStyle = FlatStyle.Flat;
            tabButton3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            tabButton3.ForeColor = Color.Black;
            tabButton3.IsActive = false;
            tabButton3.Location = new Point(693, 3);
            tabButton3.Name = "tabButton3";
            tabButton3.Size = new Size(225, 75);
            tabButton3.TabIndex = 9;
            tabButton3.Text = "المستخدمين";
            tabButton3.UseVisualStyleBackColor = false;
            tabButton3.Click += tabButton3_Click;
            // 
            // tabButton2
            // 
            tabButton2.BackColor = Color.White;
            tabButton2.BorderColor = Color.White;
            tabButton2.BorderRadius = 20;
            tabButton2.BorderSize = 2;
            tabButton2.FlatAppearance.BorderSize = 0;
            tabButton2.FlatStyle = FlatStyle.Flat;
            tabButton2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            tabButton2.ForeColor = Color.Black;
            tabButton2.IsActive = false;
            tabButton2.Location = new Point(462, 3);
            tabButton2.Name = "tabButton2";
            tabButton2.Size = new Size(225, 75);
            tabButton2.TabIndex = 8;
            tabButton2.Text = "حول النظام";
            tabButton2.UseVisualStyleBackColor = false;
            tabButton2.Click += tabButton2_Click;
            // 
            // mainContainer
            // 
            mainContainer.AutoSize = true;
            mainContainer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mainContainer.Location = new Point(56, 290);
            mainContainer.Name = "mainContainer";
            mainContainer.Size = new Size(0, 0);
            mainContainer.TabIndex = 3;
            mainContainer.Paint += mainContainer_Paint;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(1256, 798);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Controls.Add(mainContainer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Settings";
            Text = "Settings";
            Load += Settings_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel mainContainer;
        private CustomItems.TabButton tabButton1;
        private CustomItems.TabButton tabButton2;
        private CustomItems.TabButton tabButton3;
    }
}