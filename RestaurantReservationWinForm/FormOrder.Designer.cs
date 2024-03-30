namespace RestaurantReservationWinForm
{
    partial class FormOrder
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
            Food = new Label();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            cbFood = new ComboBox();
            cbCategory = new ComboBox();
            label4 = new Label();
            button2 = new Button();
            label5 = new Label();
            button3 = new Button();
            label10 = new Label();
            comboBox1 = new ComboBox();
            label7 = new Label();
            textBox3 = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)tableDgv).BeginInit();
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
            tableDgv.Size = new Size(519, 711);
            tableDgv.TabIndex = 1;
            // 
            // Food
            // 
            Food.Anchor = AnchorStyles.None;
            Food.AutoSize = true;
            Food.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold);
            Food.Location = new Point(550, 175);
            Food.Name = "Food";
            Food.Size = new Size(65, 18);
            Food.TabIndex = 17;
            Food.Text = "Món Ăn";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold);
            label3.Location = new Point(776, 111);
            label3.Name = "label3";
            label3.Size = new Size(80, 18);
            label3.TabIndex = 16;
            label3.Text = "Số Lượng";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold);
            label2.Location = new Point(550, 111);
            label2.Name = "label2";
            label2.Size = new Size(84, 18);
            label2.TabIndex = 15;
            label2.Text = "Danh mục";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(52, 78, 131);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(678, 257);
            button1.Name = "button1";
            button1.Size = new Size(211, 46);
            button1.TabIndex = 14;
            button1.Text = "Thêm Món";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Microsoft Sans Serif", 9F);
            textBox1.Location = new Point(776, 137);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(113, 24);
            textBox1.TabIndex = 13;
            // 
            // cbFood
            // 
            cbFood.Anchor = AnchorStyles.None;
            cbFood.Font = new Font("Microsoft Sans Serif", 9F);
            cbFood.FormattingEnabled = true;
            cbFood.Location = new Point(550, 201);
            cbFood.Name = "cbFood";
            cbFood.Size = new Size(339, 26);
            cbFood.TabIndex = 12;
            // 
            // cbCategory
            // 
            cbCategory.Anchor = AnchorStyles.None;
            cbCategory.Font = new Font("Microsoft Sans Serif", 9F);
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(550, 137);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(216, 26);
            cbCategory.TabIndex = 11;
            cbCategory.SelectedIndexChanged += cbCategory_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold);
            label4.Location = new Point(550, 555);
            label4.Name = "label4";
            label4.Size = new Size(83, 18);
            label4.TabIndex = 19;
            label4.Text = "Tổng tiền:";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.Tomato;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(550, 595);
            button2.Name = "button2";
            button2.Size = new Size(339, 52);
            button2.TabIndex = 20;
            button2.Text = "Đặt bàn";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Bold);
            label5.Location = new Point(550, 54);
            label5.Name = "label5";
            label5.Size = new Size(93, 25);
            label5.TabIndex = 22;
            label5.Text = "Đặt Món";
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.BackColor = SystemColors.ButtonHighlight;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(550, 257);
            button3.Name = "button3";
            button3.Size = new Size(113, 46);
            button3.TabIndex = 27;
            button3.Text = "Xóa Món";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold);
            label10.Location = new Point(550, 455);
            label10.Name = "label10";
            label10.Size = new Size(61, 18);
            label10.TabIndex = 29;
            label10.Text = "Bàn số";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.None;
            comboBox1.Font = new Font("Microsoft Sans Serif", 9F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(550, 481);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(339, 26);
            comboBox1.TabIndex = 31;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Bold);
            label7.Location = new Point(550, 339);
            label7.Name = "label7";
            label7.Size = new Size(103, 25);
            label7.TabIndex = 26;
            label7.Text = "Thông tin";
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Microsoft Sans Serif", 9F);
            textBox3.Location = new Point(550, 417);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(339, 24);
            textBox3.TabIndex = 28;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold);
            label6.Location = new Point(550, 391);
            label6.Name = "label6";
            label6.Size = new Size(125, 18);
            label6.TabIndex = 25;
            label6.Text = "Số lượng khách";
            // 
            // FormOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(921, 711);
            Controls.Add(comboBox1);
            Controls.Add(label10);
            Controls.Add(textBox3);
            Controls.Add(button3);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(Food);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(cbFood);
            Controls.Add(cbCategory);
            Controls.Add(tableDgv);
            Name = "FormOrder";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormOrder";
            TopMost = true;
            Load += FormOrder_Load;
            ((System.ComponentModel.ISupportInitialize)tableDgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView tableDgv;
        private Label Food;
        private Label label3;
        private Label label2;
        private Button button1;
        private TextBox textBox1;
        private ComboBox cbFood;
        private ComboBox cbCategory;
        private Label label4;
        private Button button2;
        private Label label5;
        private Button button3;
        private Label label8;
        private Label label9;
        private Label label10;
        private ComboBox comboBox1;
        private Label label7;
        private TextBox textBox3;
        private Label label6;
    }
}