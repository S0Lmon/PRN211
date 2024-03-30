using BusinessObjects.Models;
using DataAccessObjects;
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
    public partial class FormOrder : Form
    {
        private RurestaurantReservationSystemContext context;

        private List<FoodDTO> foodList;
        private User user;
        public FormOrder(User user)
        {
            foodList = new List<FoodDTO>();
            context = new RurestaurantReservationSystemContext();
            this.user = user;
            InitializeComponent();
        }

        private void FormOrder_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            cbCategory.DataSource = context.Categories.ToList();
            comboBox1.DataSource = context.Tables.Where(n => n.Status).ToList();
            tableDgv.DataSource = foodList;
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = comboBox1.SelectedItem.ToString();
            cbFood.DataSource = context.Foods.Where(n => n.CategoryId == int.Parse(selectedItem)).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FoodDTO foodDTO = new FoodDTO()
            {
                FoodId = int.Parse(comboBox1.SelectedItem.ToString()),
                quantity = int.Parse(textBox1.Text.ToString()),
                FoodName = context.Foods.SingleOrDefault(n => n.FoodId == int.Parse(comboBox1.SelectedItem.ToString())).FoodName,
            };
            int index = foodList.IndexOf(foodDTO);
            if (index != -1)
            {
                foodList[index].quantity += int.Parse(textBox1.Text.ToString());
            }
            else
            {
                foodList.Add(foodDTO);
            }
            loadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in tableDgv.SelectedRows)
            {
                foodList.RemoveAll(n => n.FoodId == int.Parse(row.Cells[0].Value.ToString()));
            }
            loadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal total = 0;
            foreach (FoodDTO item in foodList)
            {
                total += context.Foods.SingleOrDefault(n => n.FoodId == item.FoodId).Price * item.quantity;
            }
            Order order = new Order()
            {
                AmountOfPeople = int.Parse(textBox3.Text.ToString()),
                OrderTime = DateTime.Now,
                Status = "Đặt Bàn",
                Table = context.Tables.SingleOrDefault(n => n.TableId == int.Parse(comboBox1.SelectedItem.ToString())),
                TotalPrice = total,
                User = user
            };
            context.Orders.Add(order);
            context.SaveChanges();
            List<OrderDetail> orderDetails = new List<OrderDetail>();
            foreach (FoodDTO item in foodList)
            {
                OrderDetail orderDetail = new OrderDetail()
                {
                    Food = context.Foods.SingleOrDefault(n => n.FoodId == item.FoodId),
                    Order = order,
                    Quantity = item.quantity,
                    UnitPrice = context.Foods.SingleOrDefault(n => n.FoodId == item.FoodId).Price
                };
            }
            context.OrderDetails.AddRange(orderDetails);
            context.SaveChanges();
            loadData();
            FormCustomer formCustomer = new FormCustomer(order);
            formCustomer.FormBorderStyle = FormBorderStyle.None;
            formCustomer.Show();

        }
    }
}
