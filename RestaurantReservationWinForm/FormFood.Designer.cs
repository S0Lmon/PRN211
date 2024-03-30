namespace RestaurantReservationWinForm
{
    partial class FormFood
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
            button3 = new Button();
            label5 = new Label();
            Food = new Label();
            label2 = new Label();
            button1 = new Button();
            cbCategory = new ComboBox();
            tableDgv = new DataGridView();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            textBox4 = new TextBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)tableDgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.BackColor = Color.FromArgb(192, 0, 0);
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(797, 514);
            button3.Name = "button3";
            button3.Size = new Size(99, 46);
            button3.TabIndex = 45;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(557, 52);
            label5.Name = "label5";
            label5.Size = new Size(200, 25);
            label5.TabIndex = 42;
            label5.Text = "Danh Sách Món Ăn";
            // 
            // Food
            // 
            Food.Anchor = AnchorStyles.None;
            Food.AutoSize = true;
            Food.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            Food.Location = new Point(557, 340);
            Food.Name = "Food";
            Food.Size = new Size(97, 18);
            Food.TabIndex = 39;
            Food.Text = "Tên món ăn";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label2.Location = new Point(680, 271);
            label2.Name = "label2";
            label2.Size = new Size(84, 18);
            label2.TabIndex = 37;
            label2.Text = "Danh mục";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(52, 78, 131);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(557, 514);
            button1.Name = "button1";
            button1.Size = new Size(113, 46);
            button1.TabIndex = 36;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = false;
            // 
            // cbCategory
            // 
            cbCategory.Anchor = AnchorStyles.None;
            cbCategory.Font = new Font("Microsoft Sans Serif", 9F);
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(680, 297);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(216, 26);
            cbCategory.TabIndex = 33;
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
            tableDgv.Size = new Size(511, 637);
            tableDgv.TabIndex = 32;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label3.Location = new Point(557, 271);
            label3.Name = "label3";
            label3.Size = new Size(92, 18);
            label3.TabIndex = 38;
            label3.Text = "Mã món ăn";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Microsoft Sans Serif", 9F);
            textBox1.Location = new Point(557, 297);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(113, 24);
            textBox1.TabIndex = 35;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Microsoft Sans Serif", 9F);
            textBox2.Location = new Point(557, 363);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(339, 24);
            textBox2.TabIndex = 46;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Microsoft Sans Serif", 9F);
            textBox3.Location = new Point(557, 428);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(339, 24);
            textBox3.TabIndex = 48;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label1.Location = new Point(557, 405);
            label1.Name = "label1";
            label1.Size = new Size(34, 18);
            label1.TabIndex = 47;
            label1.Text = "Giá";
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.None;
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Font = new Font("Microsoft Sans Serif", 9F);
            textBox4.Location = new Point(557, 95);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Tìm kiếm";
            textBox4.Size = new Size(308, 24);
            textBox4.TabIndex = 49;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = Properties.Resources.search;
            pictureBox2.Location = new Point(871, 93);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 50;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(557, 196);
            label4.Name = "label4";
            label4.Size = new Size(180, 25);
            label4.TabIndex = 51;
            label4.Text = "Thông tin món ăn";
            // 
            // FormFood
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(935, 637);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(button3);
            Controls.Add(label5);
            Controls.Add(Food);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(cbCategory);
            Controls.Add(tableDgv);
            Name = "FormFood";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormFood";
            WindowState = FormWindowState.Maximized;
            Load += FormFood_Load;
            ((System.ComponentModel.ISupportInitialize)tableDgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button3;
        private Label label5;
        private Label Food;
        private Label label2;
        private Button button1;
        private ComboBox cbCategory;
        private DataGridView tableDgv;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private TextBox textBox4;
        private PictureBox pictureBox2;
        private Label label4;
    }
}