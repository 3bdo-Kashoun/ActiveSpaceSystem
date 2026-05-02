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
            panel1 = new Panel();
            roundedButton1 = new ActiveSpaceSystem.CustomItems.RoundedButton();
            label4 = new Label();
            roundedPictureBox1 = new ActiveSpaceSystem.CustomItems.RoundedPictureBox();
            label3 = new Label();
            abdulTextBox2 = new ActiveSpaceSystem.CustomItems.AbdulTextBox();
            label2 = new Label();
            abdulTextBox1 = new ActiveSpaceSystem.CustomItems.AbdulTextBox();
            label1 = new Label();
            gradientPanel1 = new ActiveSpaceSystem.CustomItems.GradientPanel();
            customLabel1 = new ActiveSpaceSystem.CustomItems.CustomLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roundedPictureBox1).BeginInit();
            gradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(roundedButton1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(roundedPictureBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(abdulTextBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(abdulTextBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(408, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(424, 453);
            panel1.TabIndex = 1;
            // 
            // roundedButton1
            // 
            roundedButton1.BackColor = Color.FromArgb(52, 77, 149);
            roundedButton1.BorderColor = Color.PaleVioletRed;
            roundedButton1.BorderRadius = 15;
            roundedButton1.BorderSize = 0;
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.Font = new Font("Tajawal", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedButton1.ForeColor = Color.White;
            roundedButton1.Location = new Point(30, 322);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(371, 52);
            roundedButton1.TabIndex = 8;
            roundedButton1.Text = "تسجيل الدخول";
            roundedButton1.UseVisualStyleBackColor = false;
            roundedButton1.Click += roundedButton1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(140, 93);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(172, 34);
            label4.TabIndex = 7;
            label4.Text = "Active Space";
            // 
            // roundedPictureBox1
            // 
            roundedPictureBox1.BackColor = Color.Transparent;
            roundedPictureBox1.BorderRadius = 60;
            roundedPictureBox1.Image = (Image)resources.GetObject("roundedPictureBox1.Image");
            roundedPictureBox1.Location = new Point(172, 12);
            roundedPictureBox1.Name = "roundedPictureBox1";
            roundedPictureBox1.Size = new Size(104, 78);
            roundedPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            roundedPictureBox1.TabIndex = 6;
            roundedPictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tajawal", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(51, 403);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(324, 23);
            label3.TabIndex = 5;
            label3.Text = "النظام مخصص للموظفين المصرح بهم فقط";
            // 
            // abdulTextBox2
            // 
            abdulTextBox2.BackColor = Color.White;
            abdulTextBox2.BorderColor = Color.FromArgb(29, 53, 87);
            abdulTextBox2.BorderRadius = 15;
            abdulTextBox2.Font = new Font("Tajawal", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            abdulTextBox2.Icon = Properties.Resources.icons8_lock_50;
            abdulTextBox2.IconLocation = HorizontalAlignment.Right;
            abdulTextBox2.IconSize = 30;
            abdulTextBox2.Location = new Point(30, 257);
            abdulTextBox2.Name = "abdulTextBox2";
            abdulTextBox2.PlaceholderText = "أدخل كلمة المرور";
            abdulTextBox2.RightToLeft = RightToLeft.Yes;
            abdulTextBox2.Size = new Size(371, 41);
            abdulTextBox2.TabIndex = 3;
            abdulTextBox2.Texts = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tajawal", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(288, 231);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(87, 23);
            label2.TabIndex = 2;
            label2.Text = "كلمة المرور";
            // 
            // abdulTextBox1
            // 
            abdulTextBox1.BackColor = Color.White;
            abdulTextBox1.BorderColor = Color.FromArgb(29, 53, 87);
            abdulTextBox1.BorderRadius = 15;
            abdulTextBox1.Font = new Font("Tajawal", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            abdulTextBox1.Icon = Properties.Resources.icons8_user_50;
            abdulTextBox1.IconLocation = HorizontalAlignment.Right;
            abdulTextBox1.IconSize = 30;
            abdulTextBox1.Location = new Point(30, 171);
            abdulTextBox1.Name = "abdulTextBox1";
            abdulTextBox1.PlaceholderText = "أدخل اسم المستخدم";
            abdulTextBox1.RightToLeft = RightToLeft.Yes;
            abdulTextBox1.Size = new Size(371, 41);
            abdulTextBox1.TabIndex = 1;
            abdulTextBox1.Texts = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tajawal", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(256, 145);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(119, 23);
            label1.TabIndex = 0;
            label1.Text = "اسم المستخدم";
            // 
            // gradientPanel1
            // 
            gradientPanel1.BorderRadius = 10;
            gradientPanel1.Controls.Add(customLabel1);
            gradientPanel1.Dock = DockStyle.Left;
            gradientPanel1.GradientColor1 = Color.FromArgb(29, 53, 87);
            gradientPanel1.GradientColor2 = Color.FromArgb(26, 188, 156);
            gradientPanel1.ImageOpacity = 50;
            gradientPanel1.ImageSizeMode = PictureBoxSizeMode.StretchImage;
            gradientPanel1.Location = new Point(0, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.PanelImage = Properties.Resources.vienna_reyes_Zs_o1IjVPt4_unsplash;
            gradientPanel1.Size = new Size(411, 453);
            gradientPanel1.TabIndex = 2;
            gradientPanel1.TitleText = "";
            // 
            // customLabel1
            // 
            customLabel1.AutoSize = true;
            customLabel1.BackColor = Color.Transparent;
            customLabel1.Font = new Font("Tajawal", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customLabel1.ForeColor = Color.White;
            customLabel1.Location = new Point(85, 145);
            customLabel1.Name = "customLabel1";
            customLabel1.Size = new Size(219, 32);
            customLabel1.TabIndex = 1;
            customLabel1.Text = "إدارة إحترافية لملاعبك";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(832, 453);
            Controls.Add(gradientPanel1);
            Controls.Add(panel1);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += LoginForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)roundedPictureBox1).EndInit();
            gradientPanel1.ResumeLayout(false);
            gradientPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private CustomItems.GradientPanel gradientPanel1;
        private CustomItems.AbdulTextBox abdulTextBox1;
        private Label label1;
        private CustomItems.AbdulTextBox abdulTextBox2;
        private Label label2;
        private Label label3;
        private CustomItems.RoundedPictureBox roundedPictureBox1;
        private Label label4;
        private CustomItems.CustomLabel customLabel1;
        private CustomItems.RoundedButton roundedButton1;
    }
}