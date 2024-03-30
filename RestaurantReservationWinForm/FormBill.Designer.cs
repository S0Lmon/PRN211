namespace RestaurantReservationWinForm
{
    partial class FormBill
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
            textBox3 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            cbCategory = new ComboBox();
            button2 = new Button();
            label4 = new Label();
            tableDgv = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)tableDgv).BeginInit();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Microsoft Sans Serif", 9F);
            textBox3.Location = new Point(573, 219);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(339, 24);
            textBox3.TabIndex = 35;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Bold);
            label7.Location = new Point(573, 61);
            label7.Name = "label7";
            label7.Size = new Size(236, 25);
            label7.TabIndex = 34;
            label7.Text = "Thông Tin Khách Hàng";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold);
            label6.Location = new Point(573, 193);
            label6.Name = "label6";
            label6.Size = new Size(127, 18);
            label6.TabIndex = 33;
            label6.Text = "Tên khách hàng";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold);
            label1.Location = new Point(573, 129);
            label1.Name = "label1";
            label1.Size = new Size(107, 18);
            label1.TabIndex = 32;
            label1.Text = "Số điện thoại";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Microsoft Sans Serif", 9F);
            textBox2.Location = new Point(573, 155);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(339, 24);
            textBox2.TabIndex = 31;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold);
            label2.Location = new Point(573, 258);
            label2.Name = "label2";
            label2.Size = new Size(63, 18);
            label2.TabIndex = 37;
            label2.Text = "Mã bàn";
            // 
            // cbCategory
            // 
            cbCategory.Anchor = AnchorStyles.None;
            cbCategory.Font = new Font("Microsoft Sans Serif", 9F);
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(573, 281);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(339, 26);
            cbCategory.TabIndex = 38;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.Tomato;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(573, 400);
            button2.Name = "button2";
            button2.Size = new Size(339, 52);
            button2.TabIndex = 40;
            button2.Text = "Xuất hóa đơn";
            button2.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold);
            label4.Location = new Point(573, 365);
            label4.Name = "label4";
            label4.Size = new Size(83, 18);
            label4.TabIndex = 39;
            label4.Text = "Tổng tiền:";
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
            tableDgv.Size = new Size(526, 510);
            tableDgv.TabIndex = 41;
            tableDgv.CellContentClick += tableDgv_CellContentClick;
            // 
            // FormBill
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(956, 510);
            Controls.Add(tableDgv);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(cbCategory);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold);
            Name = "FormBill";
            Text = "FormBill";
            Load += FormBill_Load;
            ((System.ComponentModel.ISupportInitialize)tableDgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox3;
        private Label label7;
        private Label label6;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private ComboBox cbCategory;
        private Button button2;
        private Label label4;
        private DataGridView tableDgv;
    }
}