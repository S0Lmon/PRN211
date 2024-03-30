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
    public partial class FormCategory : Form
    {
        private RurestaurantReservationSystemContext context;
        public FormCategory()
        {
            context = new RurestaurantReservationSystemContext();
            InitializeComponent();
            loadCategory();
        }

        private void loadCategory()
        {
            tableDgv.DataSource = context.Categories.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName = textBox2.Text;
            context.Categories.Add(category);
            context.SaveChanges();
            MessageBox.Show("Thêm Thành Công!");
            loadCategory();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Category> list = new List<Category>();
            foreach (DataGridViewRow row in tableDgv.SelectedRows)
            {
                list.Add(context.Categories.SingleOrDefault(n => n.CategoryId == int.Parse(row.Cells[0].Value.ToString())));
            }
            context.Categories.RemoveRange(list);
            MessageBox.Show("Xóa Thành Công");
            loadCategory();
        }
    }
}
