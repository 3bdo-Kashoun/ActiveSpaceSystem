namespace ActiveSpaceSystem.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            gradientPanel1 = new ActiveSpaceSystem.CustomItems.GradientPanel();
            panel1 = new Panel();
            label3 = new Label();
            roundedButton1 = new ActiveSpaceSystem.CustomItems.RoundedButton();
            txtPassword = new ActiveSpaceSystem.CustomItems.AbdulTextBox();
            label2 = new Label();
            label4 = new Label();
            roundedPictureBox1 = new ActiveSpaceSystem.CustomItems.RoundedPictureBox();
            label1 = new Label();
            txtUsername = new ActiveSpaceSystem.CustomItems.AbdulTextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roundedPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // gradientPanel1
            // 
            gradientPanel1.BorderRadius = 10;
            gradientPanel1.Dock = DockStyle.Left;
            gradientPanel1.GradientColor1 = Color.FromArgb(29, 53, 87);
            gradientPanel1.GradientColor2 = Color.FromArgb(26, 188, 156);
            gradientPanel1.ImageOpacity = 50;
            gradientPanel1.ImageSizeMode = PictureBoxSizeMode.StretchImage;
            gradientPanel1.Location = new Point(0, 0);
            gradientPanel1.Margin = new Padding(4);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.PanelImage = Properties.Resources.vienna_reyes_Zs_o1IjVPt4_unsplash;
            gradientPanel1.Size = new Size(512, 566);
            gradientPanel1.TabIndex = 6;
            gradientPanel1.TitleText = "";
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(roundedButton1);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(roundedPictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtUsername);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(512, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(528, 566);
            panel1.TabIndex = 7;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(112, 515);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(303, 25);
            label3.TabIndex = 38;
            label3.Text = "النظام مخصص للموظفين المصرح بهم فقط";
            // 
            // roundedButton1
            // 
            roundedButton1.Anchor = AnchorStyles.None;
            roundedButton1.BackColor = Color.FromArgb(52, 77, 149);
            roundedButton1.BorderColor = Color.PaleVioletRed;
            roundedButton1.BorderRadius = 15;
            roundedButton1.BorderSize = 0;
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedButton1.ForeColor = Color.White;
            roundedButton1.Location = new Point(32, 400);
            roundedButton1.Margin = new Padding(4);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(464, 65);
            roundedButton1.TabIndex = 37;
            roundedButton1.Text = "تسجيل الدخول";
            roundedButton1.UseVisualStyleBackColor = false;
            roundedButton1.Click += roundedButton1_Click_1;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.BackColor = Color.White;
            txtPassword.BorderColor = Color.FromArgb(29, 53, 87);
            txtPassword.BorderRadius = 15;
            txtPassword.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Icon = Properties.Resources.icons8_lock_50;
            txtPassword.IconLocation = HorizontalAlignment.Right;
            txtPassword.IconSize = 30;
            txtPassword.Location = new Point(32, 321);
            txtPassword.Margin = new Padding(4);
            txtPassword.Name = "txtPassword";
            txtPassword.passwordChar = ".";
            txtPassword.PlaceholderText = "أدخل كلمة المرور";
            txtPassword.RightToLeft = RightToLeft.Yes;
            txtPassword.Size = new Size(464, 41);
            txtPassword.TabIndex = 3;
            txtPassword.Texts = "";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(402, 282);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(94, 25);
            label2.TabIndex = 2;
            label2.Text = "كلمة المرور";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(164, 116);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(199, 40);
            label4.TabIndex = 32;
            label4.Text = "Active Space";
            // 
            // roundedPictureBox1
            // 
            roundedPictureBox1.Anchor = AnchorStyles.None;
            roundedPictureBox1.BackColor = Color.Transparent;
            roundedPictureBox1.BorderRadius = 60;
            roundedPictureBox1.Image = (Image)resources.GetObject("roundedPictureBox1.Image");
            roundedPictureBox1.Location = new Point(182, 27);
            roundedPictureBox1.Margin = new Padding(4);
            roundedPictureBox1.Name = "roundedPictureBox1";
            roundedPictureBox1.Size = new Size(147, 85);
            roundedPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            roundedPictureBox1.TabIndex = 31;
            roundedPictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(392, 178);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(104, 25);
            label1.TabIndex = 33;
            label1.Text = "اسم المستخدم";
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.None;
            txtUsername.BackColor = Color.White;
            txtUsername.BorderColor = Color.FromArgb(29, 53, 87);
            txtUsername.BorderRadius = 15;
            txtUsername.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Icon = Properties.Resources.icons8_user_50;
            txtUsername.IconLocation = HorizontalAlignment.Right;
            txtUsername.IconSize = 30;
            txtUsername.Location = new Point(32, 220);
            txtUsername.Margin = new Padding(4);
            txtUsername.Name = "txtUsername";
            txtUsername.passwordChar = "\0";
            txtUsername.PlaceholderText = "أدخل اسم المستخدم";
            txtUsername.RightToLeft = RightToLeft.Yes;
            txtUsername.Size = new Size(464, 46);
            txtUsername.TabIndex = 1;
            txtUsername.Texts = "";
            // 
            // LoginForm
            // 
            AcceptButton = roundedButton1;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1040, 566);
            Controls.Add(panel1);
            Controls.Add(gradientPanel1);
            Margin = new Padding(4);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += LoginForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)roundedPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CustomItems.GradientPanel gradientPanel1;
        private Panel panel1;
        private Label label3;
        private CustomItems.RoundedButton roundedButton1;
        private CustomItems.AbdulTextBox txtPassword;
        private Label label2;
        private Label label4;
        private CustomItems.RoundedPictureBox roundedPictureBox1;
        private Label label1;
        private CustomItems.AbdulTextBox txtUsername;
    }
}