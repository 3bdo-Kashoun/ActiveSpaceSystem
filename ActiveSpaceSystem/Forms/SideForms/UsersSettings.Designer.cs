namespace ActiveSpaceSystem.Forms.SideForms
{
    partial class UsersSettings
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
            roundedButton1 = new ActiveSpaceSystem.CustomItems.RoundedButton();
            label1 = new Label();
            infoBox1 = new ActiveSpaceSystem.CustomItems.InfoBox();
            panel2 = new Panel();
            userListItem2 = new ActiveSpaceSystem.CustomItems.UserListItem();
            userListItem1 = new ActiveSpaceSystem.CustomItems.UserListItem();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            panel1.Size = new Size(1130, 86);
            panel1.TabIndex = 2;
            // 
            // roundedButton1
            // 
            roundedButton1.BackColor = Color.FromArgb(39, 191, 141);
            roundedButton1.BorderColor = Color.FromArgb(39, 191, 141);
            roundedButton1.BorderRadius = 18;
            roundedButton1.BorderSize = 2;
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            roundedButton1.ForeColor = Color.White;
            roundedButton1.Location = new Point(34, 12);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(225, 70);
            roundedButton1.TabIndex = 7;
            roundedButton1.Text = "إضافة مستخدم ";
            roundedButton1.TextImageRelation = TextImageRelation.TextBeforeImage;
            roundedButton1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(852, 17);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(245, 46);
            label1.TabIndex = 0;
            label1.Text = "إدارة المستخدمين";
            // 
            // infoBox1
            // 
            infoBox1.BackColor = Color.Transparent;
            infoBox1.BorderColor = Color.FromArgb(180, 210, 255);
            infoBox1.BorderRadius = 15;
            infoBox1.Description = "(يمكنك إضافة موظفين جدد وتحديد صلاحياتهم في النظام (مدير، موظف استقبال، محاسب";
            infoBox1.DescriptionColor = Color.FromArgb(69, 123, 157);
            infoBox1.DescriptionFont = new Font("Microsoft Sans Serif", 9F);
            infoBox1.FillColor = Color.FromArgb(240, 248, 255);
            infoBox1.Icon = null;
            infoBox1.IconSize = 25;
            infoBox1.Location = new Point(34, 94);
            infoBox1.Margin = new Padding(4);
            infoBox1.Name = "infoBox1";
            infoBox1.Size = new Size(1042, 121);
            infoBox1.TabIndex = 3;
            infoBox1.Title = "إدارة صلاحيات المستخدمين";
            infoBox1.TitleColor = Color.FromArgb(29, 53, 87);
            infoBox1.TitleFont = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            // 
            // panel2
            // 
            panel2.Controls.Add(userListItem2);
            panel2.Controls.Add(userListItem1);
            panel2.Location = new Point(34, 240);
            panel2.Name = "panel2";
            panel2.Size = new Size(1052, 193);
            panel2.TabIndex = 4;
            // 
            // userListItem2
            // 
            userListItem2.BackColor = Color.FromArgb(243, 244, 246);
            userListItem2.EditIcon = Properties.Resources.icons8_edit_48;
            userListItem2.Location = new Point(0, 103);
            userListItem2.Name = "userListItem2";
            userListItem2.Padding = new Padding(10);
            userListItem2.RoleColor = Color.Silver;
            userListItem2.RoleText = "محاسب";
            userListItem2.Size = new Size(1049, 90);
            userListItem2.TabIndex = 1;
            userListItem2.UserEmail = "abdo@gmail.com";
            userListItem2.UserName = "عبد المهيمن كشون";
            // 
            // userListItem1
            // 
            userListItem1.BackColor = Color.FromArgb(243, 244, 246);
            userListItem1.EditIcon = Properties.Resources.icons8_edit_48;
            userListItem1.Location = new Point(0, 3);
            userListItem1.Name = "userListItem1";
            userListItem1.Padding = new Padding(10);
            userListItem1.RoleColor = Color.FromArgb(46, 204, 113);
            userListItem1.RoleText = "مدير النظام";
            userListItem1.Size = new Size(1049, 94);
            userListItem1.TabIndex = 0;
            userListItem1.UserEmail = "moha@gmail.com";
            userListItem1.UserName = "محمد يوسف";
            // 
            // UsersSettings
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(1130, 521);
            Controls.Add(panel2);
            Controls.Add(infoBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UsersSettings";
            Text = "UsersSettings";
            Load += UsersSettings_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private CustomItems.RoundedButton roundedButton1;
        private Label label1;
        private CustomItems.InfoBox infoBox1;
        private Panel panel2;
        private CustomItems.UserListItem userListItem1;
        private CustomItems.UserListItem userListItem2;
    }
}