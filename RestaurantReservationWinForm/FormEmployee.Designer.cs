namespace RestaurantReservationWinForm
{
    partial class FormEmployee
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
            tableDgv = new DataGridView();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            textBox4 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            button3 = new Button();
            label5 = new Label();
            Food = new Label();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            cbFood = new ComboBox();
            textBox3 = new TextBox();
            label6 = new Label();
            textBox6 = new TextBox();
            label7 = new Label();
            label9 = new Label();
            textBox5 = new TextBox();
            label8 = new Label();
            textBox7 = new TextBox();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)tableDgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // tableDgv
            // 
            tableDgv.BackgroundColor = Color.FromArgb(236, 236, 236);
            tableDgv.BorderStyle = BorderStyle.None;
            tableDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableDgv.Dock = DockStyle.Left;
            tableDgv.Location = new Point(0, 0);
            tableDgv.Name = "tableDgv";
            tableDgv.RowHeadersWidth = 51;
            tableDgv.Size = new Size(511, 761);
            tableDgv.TabIndex = 73;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(554, 196);
            label4.Name = "label4";
            label4.Size = new Size(218, 25);
            label4.TabIndex = 88;
            label4.Text = "Thông Tin Nhân Viên";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = Properties.Resources.search;
            pictureBox2.Location = new Point(868, 92);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 87;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.None;
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Font = new Font("Microsoft Sans Serif", 9F);
            textBox4.Location = new Point(554, 95);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Tìm kiếm";
            textBox4.Size = new Size(308, 24);
            textBox4.TabIndex = 86;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label1.Location = new Point(554, 365);
            label1.Name = "label1";
            label1.Size = new Size(71, 18);
            label1.TabIndex = 84;
            label1.Text = "Giới tính";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Microsoft Sans Serif", 9F);
            textBox2.Location = new Point(554, 323);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(339, 24);
            textBox2.TabIndex = 83;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.BackColor = Color.FromArgb(192, 0, 0);
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(775, 703);
            button3.Name = "button3";
            button3.Size = new Size(118, 46);
            button3.TabIndex = 82;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(554, 52);
            label5.Name = "label5";
            label5.Size = new Size(226, 25);
            label5.TabIndex = 81;
            label5.Text = "Danh Sách Nhân Viên";
            // 
            // Food
            // 
            Food.Anchor = AnchorStyles.None;
            Food.AutoSize = true;
            Food.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            Food.Location = new Point(554, 300);
            Food.Name = "Food";
            Food.Size = new Size(36, 18);
            Food.TabIndex = 79;
            Food.Text = "Tên";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label3.Location = new Point(554, 231);
            label3.Name = "label3";
            label3.Size = new Size(107, 18);
            label3.TabIndex = 78;
            label3.Text = "Mã nhân viên";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label2.Location = new Point(677, 231);
            label2.Name = "label2";
            label2.Size = new Size(57, 18);
            label2.TabIndex = 77;
            label2.Text = "Vai trò";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(52, 78, 131);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(554, 703);
            button1.Name = "button1";
            button1.Size = new Size(113, 46);
            button1.TabIndex = 76;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Microsoft Sans Serif", 9F);
            textBox1.Location = new Point(554, 257);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(113, 24);
            textBox1.TabIndex = 75;
            // 
            // cbFood
            // 
            cbFood.Anchor = AnchorStyles.None;
            cbFood.DisplayMember = "Nam";
            cbFood.Font = new Font("Microsoft Sans Serif", 9F);
            cbFood.FormattingEnabled = true;
            cbFood.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbFood.Location = new Point(554, 388);
            cbFood.Name = "cbFood";
            cbFood.Size = new Size(339, 26);
            cbFood.TabIndex = 91;
            cbFood.ValueMember = "Nam";
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Microsoft Sans Serif", 9F);
            textBox3.Location = new Point(554, 455);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(339, 24);
            textBox3.TabIndex = 93;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label6.Location = new Point(554, 432);
            label6.Name = "label6";
            label6.Size = new Size(107, 18);
            label6.TabIndex = 92;
            label6.Text = "Số điện thoại";
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.None;
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.Font = new Font("Microsoft Sans Serif", 9F);
            textBox6.Location = new Point(554, 522);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(339, 24);
            textBox6.TabIndex = 95;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label7.Location = new Point(554, 499);
            label7.Name = "label7";
            label7.Size = new Size(60, 18);
            label7.TabIndex = 94;
            label7.Text = "Địa chỉ";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label9.Location = new Point(554, 565);
            label9.Name = "label9";
            label9.Size = new Size(124, 18);
            label9.TabIndex = 98;
            label9.Text = "Tên Đăng Nhập";
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.None;
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Font = new Font("Microsoft Sans Serif", 9F);
            textBox5.Location = new Point(554, 586);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(339, 24);
            textBox5.TabIndex = 99;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label8.Location = new Point(554, 627);
            label8.Name = "label8";
            label8.Size = new Size(79, 18);
            label8.TabIndex = 100;
            label8.Text = "Mật Khẩu";
            // 
            // textBox7
            // 
            textBox7.Anchor = AnchorStyles.None;
            textBox7.BorderStyle = BorderStyle.FixedSingle;
            textBox7.Font = new Font("Microsoft Sans Serif", 9F);
            textBox7.Location = new Point(554, 648);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(339, 24);
            textBox7.TabIndex = 101;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.None;
            comboBox1.DisplayMember = "Nam";
            comboBox1.Font = new Font("Microsoft Sans Serif", 9F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Nam", "Nữ" });
            comboBox1.Location = new Point(677, 257);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(216, 26);
            comboBox1.TabIndex = 102;
            comboBox1.ValueMember = "Nam";
            // 
            // FormEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(938, 761);
            Controls.Add(comboBox1);
            Controls.Add(textBox7);
            Controls.Add(label8);
            Controls.Add(textBox5);
            Controls.Add(label9);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(cbFood);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(textBox4);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(button3);
            Controls.Add(label5);
            Controls.Add(Food);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(tableDgv);
            Name = "FormEmployee";
            Text = "FormEmployee";
            ((System.ComponentModel.ISupportInitialize)tableDgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView tableDgv;
        private Button button5;
        private Label label4;
        private PictureBox pictureBox2;
        private TextBox textBox4;
        private Label label1;
        private TextBox textBox2;
        private Button button3;
        private Label label5;
        private Label Food;
        private Label label3;
        private Label label2;
        private Button button1;
        private TextBox textBox1;
        private ComboBox cbFood;
        private TextBox textBox3;
        private Label label6;
        private TextBox textBox6;
        private Label label7;
        private Label label9;
        private TextBox textBox5;
        private Label label8;
        private TextBox textBox7;
        private ComboBox comboBox1;
    }
}