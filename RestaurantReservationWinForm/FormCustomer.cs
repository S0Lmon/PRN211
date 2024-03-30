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
    public partial class FormCustomer : Form
    {
        private Order order;
        private RurestaurantReservationSystemContext context;
        public FormCustomer()
        {
            context = new RurestaurantReservationSystemContext();
            InitializeComponent();
            loadCustomers();
        }

        public FormCustomer(Order order)
        {
            this.order = order;
            context = new RurestaurantReservationSystemContext();
            InitializeComponent();
            loadCustomers();           
        }

        private void loadCustomers()
        {
            if (textBox4.Text.Length > 0)
            {
                tableDgv.DataSource = context.Customers.Where(n => n.CustomerName.ToLower().Contains(textBox4.Text.ToLower())).ToList();
            }
            else
            {
                tableDgv.DataSource = context.Customers.ToList();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            loadCustomers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer()
            {
                CustomerName = textBox2.Text,
                Phone = textBox6.Text,
                Status = true
            };
            context.Customers.Add(customer);
            context.SaveChanges();
            order.Customer = customer;
            context.Orders.Add(order);
            context.SaveChanges();  
            MessageBox.Show("Đặt Bàn Thành Công");
            loadCustomers();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Customer> list = new List<Customer>();
            foreach (DataGridViewRow row in tableDgv.SelectedRows)
            {
                list.Add(context.Customers.SingleOrDefault(n => n.CustomerId == int.Parse(row.Cells[0].Value.ToString())));
            }
            context.Customers.RemoveRange(list);
            MessageBox.Show("Xóa Thành Công");
            loadCustomers();
        }
    }
}
