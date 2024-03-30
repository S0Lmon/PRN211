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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RestaurantReservationWinForm
{
    public partial class FormFood : Form
    {
        private RurestaurantReservationSystemContext context;
        public FormFood()
        {
            context = new RurestaurantReservationSystemContext();
            InitializeComponent();
        }

        private void FormFood_Load(object sender, EventArgs e)
        {
            loadFoods();
        }

        private void loadFoods()
        {
            cbCategory.DataSource = context.Categories.ToList();
            if (textBox4.Text.Length > 0)
            {
                tableDgv.DataSource = context.Foods.Where(n => n.FoodName.ToLower().Contains(textBox4.Text.ToLower())).ToList();
            }
            else
            {
                tableDgv.DataSource = context.Foods.ToList();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            loadFoods();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Food food = new Food()
            {
                FoodName = textBox2.Text,
                Category = context.Categories.SingleOrDefault(n => n.CategoryId == int.Parse(cbCategory.SelectedItem.ToString())),
                Price = int.Parse(textBox3.Text.ToString())
            };
            context.Foods.Add(food);
            context.SaveChanges();
            loadFoods();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Food> list = new List<Food>();
            foreach (DataGridViewRow row in tableDgv.SelectedRows)
            {
                list.Add(context.Foods.SingleOrDefault(n => n.FoodId == int.Parse(row.Cells[0].Value.ToString())));
            }
            context.Foods.RemoveRange(list);
            MessageBox.Show("Xóa Thành Công");
            loadFoods();
        }

    }
}
