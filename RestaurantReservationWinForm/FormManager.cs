using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantReservationWinForm
{
    public partial class FormManager : Form
    {
        private User user;
        public FormManager(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (this.pnDisplay.Controls.Count > 0)
            {
                this.pnDisplay.Controls.RemoveAt(0);
            }
            FormOrder formOrder = new FormOrder(user) { TopLevel = false, TopMost = true, Dock = DockStyle.Fill };
            formOrder.FormBorderStyle = FormBorderStyle.None;
            pnDisplay.Controls.Add(formOrder);
            formOrder.Show();
        }

        private void FormManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát ?", "Thông Báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        public void loadForm(object sender)
        {
            if (this.panel1.Controls.Count > 0)
            {
                this.panel1.Controls.RemoveAt(0);
                Form f = sender as Form;
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                this.panel1.Controls.Add(f);
                this.panel1.Tag = f;
                f.Show();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.pnDisplay.Controls.Count > 0)
            {
                this.pnDisplay.Controls.RemoveAt(0);
            }
            FormBill formBill = new FormBill() { TopLevel = false, TopMost = true, Dock = DockStyle.Fill };
            formBill.FormBorderStyle = FormBorderStyle.None;
            pnDisplay.Controls.Add(formBill);
            formBill.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.pnDisplay.Controls.Count > 0)
            {
                this.pnDisplay.Controls.RemoveAt(0);
            }
            FormCustomer formCustomer = new FormCustomer() { TopLevel = false, TopMost = true, Dock = DockStyle.Fill };
            formCustomer.FormBorderStyle = FormBorderStyle.None;
            pnDisplay.Controls.Add(formCustomer);
            formCustomer.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.pnDisplay.Controls.Count > 0)
            {
                this.pnDisplay.Controls.RemoveAt(0);
            }
            FormEmployee formEmployee = new FormEmployee() { TopLevel = false, TopMost = true, Dock = DockStyle.Fill };
            formEmployee.FormBorderStyle = FormBorderStyle.None;
            pnDisplay.Controls.Add(formEmployee);
            formEmployee.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.pnDisplay.Controls.Count > 0)
            {
                this.pnDisplay.Controls.RemoveAt(0);
            }
            FormCategory formCategory = new FormCategory() { TopLevel = false, TopMost = true, Dock = DockStyle.Fill };
            formCategory.FormBorderStyle = FormBorderStyle.None;
            pnDisplay.Controls.Add(formCategory);
            formCategory.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.pnDisplay.Controls.Count > 0)
            {
                this.pnDisplay.Controls.RemoveAt(0);
            }
            FormFood formFood = new FormFood() { TopLevel = false, TopMost = true, Dock = DockStyle.Fill };
            formFood.FormBorderStyle = FormBorderStyle.None;
            pnDisplay.Controls.Add(formFood);
            formFood.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (this.pnDisplay.Controls.Count > 0)
            {
                this.pnDisplay.Controls.RemoveAt(0);
            }
            FormTable formTable = new FormTable() { TopLevel = false, TopMost = true, Dock = DockStyle.Fill };
            formTable.FormBorderStyle = FormBorderStyle.None;
            pnDisplay.Controls.Add(formTable);
            formTable.Show();
        }

        private void FormManager_Load(object sender, EventArgs e)
        {

        }
    }
}
