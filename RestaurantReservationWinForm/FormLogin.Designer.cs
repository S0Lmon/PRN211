namespace RestaurantReservationWinForm
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            label7 = new Label();
            label6 = new Label();
            panel3 = new Panel();
            label4 = new Label();
            button1 = new Button();
            txtPassword = new TextBox();
            txtUser = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnLogin = new Button();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Beige;
            label7.Font = new Font("SVN-Oscine", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(64, 64, 64);
            label7.Location = new Point(37, 116);
            label7.Name = "label7";
            label7.Size = new Size(209, 26);
            label7.TabIndex = 18;
            label7.Text = "Chúc một ngày tốt lành";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Beige;
            label6.Font = new Font("SVN-Oscine", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(37, 81);
            label6.Name = "label6";
            label6.Size = new Size(296, 36);
            label6.TabIndex = 17;
            label6.Text = "Chào mừng quay trở lại !";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Thistle;
            panel3.BackgroundImage = Properties.Resources.hotpotBg;
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(549, 750);
            panel3.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(621, 490);
            label4.Name = "label4";
            label4.Size = new Size(0, 18);
            label4.TabIndex = 35;
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.hidden__2_;
            button1.Location = new Point(898, 415);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(30, 38);
            button1.TabIndex = 33;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("SVN-Oscine", 9F);
            txtPassword.ForeColor = Color.Black;
            txtPassword.Location = new Point(655, 419);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(273, 38);
            txtPassword.TabIndex = 32;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // txtUser
            // 
            txtUser.BorderStyle = BorderStyle.None;
            txtUser.Font = new Font("SVN-Oscine", 9F);
            txtUser.ForeColor = Color.Black;
            txtUser.Location = new Point(653, 338);
            txtUser.Margin = new Padding(3, 4, 3, 4);
            txtUser.Multiline = true;
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(273, 38);
            txtUser.TabIndex = 31;
            txtUser.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SVN-Oscine", 11.999999F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(739, 663);
            label2.Name = "label2";
            label2.Size = new Size(62, 27);
            label2.TabIndex = 30;
            label2.Text = "Thoát";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SVN-Oscine", 11.999999F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(865, 551);
            label1.Name = "label1";
            label1.Size = new Size(65, 27);
            label1.TabIndex = 29;
            label1.Text = "Đặt lại";
            label1.Click += label1_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Tomato;
            btnLogin.DialogResult = DialogResult.Cancel;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("SVN-Oscine", 11.999999F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(619, 586);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(310, 56);
            btnLogin.TabIndex = 28;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(34, 23, 56);
            panel2.ForeColor = Color.FromArgb(0, 117, 214);
            panel2.Location = new Point(619, 460);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(310, 2);
            panel2.TabIndex = 27;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.padlock;
            pictureBox3.Location = new Point(619, 419);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 31);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 26;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(34, 23, 56);
            panel1.ForeColor = Color.FromArgb(0, 117, 214);
            panel1.Location = new Point(619, 376);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(310, 2);
            panel1.TabIndex = 25;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user;
            pictureBox2.Location = new Point(619, 335);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Beige_and_Red_Modern_Illustration_Street_Food___Logo;
            pictureBox1.Location = new Point(657, 39);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(239, 231);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(319, -55);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(33, 35);
            button2.TabIndex = 34;
            button2.UseVisualStyleBackColor = true;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(985, 750);
            Controls.Add(panel3);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(panel2);
            Controls.Add(pictureBox3);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Name = "FormLogin";
            Text = "FormLogin";
            FormClosing += FormLogin_FormClosing;
            Load += FormLogin_Load_1;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label7;
        private Label label6;
        private Panel panel3;
        private Label label4;
        private Button button1;
        private TextBox txtPassword;
        private TextBox txtUser;
        private Label label2;
        private Label label1;
        private Button btnLogin;
        private Panel panel2;
        private PictureBox pictureBox3;
        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button button2;
    }
}