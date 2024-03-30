namespace RestaurantReservationWinForm
{
    partial class FormManager
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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            btnOrder = new Button();
            miniToolStrip = new MenuStrip();
            pnDisplay = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Beige_and_Red_Modern_Illustration_Street_Food___Logo;
            pictureBox1.Location = new Point(24, 25);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(239, 231);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.BackgroundImage = Properties.Resources.Red_Illustrated_Background_Recipe_Card4;
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnOrder);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(286, 946);
            panel1.TabIndex = 11;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(255, 128, 0);
            button6.Cursor = Cursors.Hand;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.Location = new Point(24, 807);
            button6.Name = "button6";
            button6.Size = new Size(239, 52);
            button6.TabIndex = 29;
            button6.Text = "Danh Sách Bàn Ăn";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Orange;
            button5.Cursor = Cursors.Hand;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(24, 724);
            button5.Name = "button5";
            button5.Size = new Size(239, 52);
            button5.TabIndex = 28;
            button5.Text = "Thực Đơn";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.PaleVioletRed;
            button4.Cursor = Cursors.Hand;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(24, 639);
            button4.Name = "button4";
            button4.Size = new Size(239, 52);
            button4.TabIndex = 27;
            button4.Text = "Danh Mục";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Tomato;
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(24, 557);
            button3.Name = "button3";
            button3.Size = new Size(239, 52);
            button3.TabIndex = 26;
            button3.Text = "Danh Sách Nhân Viên";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(227, 66, 66);
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(24, 476);
            button2.Name = "button2";
            button2.Size = new Size(239, 52);
            button2.TabIndex = 25;
            button2.Text = "Danh Sách Khách Hàng";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(22, 104, 158);
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(24, 392);
            button1.Name = "button1";
            button1.Size = new Size(239, 52);
            button1.TabIndex = 24;
            button1.Text = "Xuất Hóa Đơn";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.FromArgb(41, 66, 103);
            btnOrder.Cursor = Cursors.Hand;
            btnOrder.FlatStyle = FlatStyle.Flat;
            btnOrder.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnOrder.ForeColor = SystemColors.ButtonHighlight;
            btnOrder.Location = new Point(24, 309);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(239, 52);
            btnOrder.TabIndex = 0;
            btnOrder.Text = "Đặt Bàn";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // miniToolStrip
            // 
            miniToolStrip.AccessibleName = "New item selection";
            miniToolStrip.AccessibleRole = AccessibleRole.ComboBox;
            miniToolStrip.Anchor = AnchorStyles.None;
            miniToolStrip.AutoSize = false;
            miniToolStrip.Dock = DockStyle.None;
            miniToolStrip.ImageScalingSize = new Size(20, 20);
            miniToolStrip.Location = new Point(72, 3);
            miniToolStrip.Name = "miniToolStrip";
            miniToolStrip.Size = new Size(74, 31);
            miniToolStrip.TabIndex = 0;
            // 
            // pnDisplay
            // 
            pnDisplay.BackColor = SystemColors.ButtonHighlight;
            pnDisplay.Dock = DockStyle.Fill;
            pnDisplay.Location = new Point(286, 0);
            pnDisplay.Margin = new Padding(3, 4, 3, 4);
            pnDisplay.Name = "pnDisplay";
            pnDisplay.Size = new Size(943, 946);
            pnDisplay.TabIndex = 12;
            // 
            // FormManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1229, 946);
            Controls.Add(pnDisplay);
            Controls.Add(panel1);
            IsMdiContainer = true;
            MainMenuStrip = miniToolStrip;
            Name = "FormManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormManager";
            WindowState = FormWindowState.Maximized;
            FormClosing += FormManager_FormClosing;
            Load += FormManager_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private MenuStrip miniToolStrip;
        private Panel pnDisplay;
        private Button btnOrder;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button6;
        private Button button5;
        private Button button4;
    }
}