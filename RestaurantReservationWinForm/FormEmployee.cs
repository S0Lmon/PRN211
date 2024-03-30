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
    public partial class FormEmployee : Form
    {
        private RurestaurantReservationSystemContext context;
        public FormEmployee()
        {
            context = new RurestaurantReservationSystemContext();
            InitializeComponent();
            loadEmp();
            List<string> dataSource = new List<string>();
            dataSource.Add("quản lý");
            dataSource.Add("nhân viên");
            comboBox1.DataSource = dataSource;
            textBox7.PasswordChar = '*';
            textBox7.UseSystemPasswordChar = true;
            List<string> genders = new List<string> { "Male", "Female" };
            cbFood.DataSource = genders;
        }

        private void loadEmp()
        {
            if(textBox4.Text.Length > 0)
            {
                tableDgv.DataSource = context.Users.Where(n => n.Role.Equals("nhân viên") && n.Name.ToLower().Contains(textBox4.Text.ToLower())).ToList();
            }
            else
            {
                tableDgv.DataSource = context.Users.Where(n => n.Role.Equals("nhân viên")).ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Role = comboBox1.SelectedValue.ToString();
            user.Name = textBox2.Text;
            user.Gender = cbFood.Text;
            user.Phone = textBox3.Text;
            user.Address = textBox6.Text;
            user.Username = textBox5.Text;
            user.Password = textBox7.Text;
            User? userDB = context.Users.SingleOrDefault(n => n.Username == user.Username);
            if (userDB != null)
            {
                MessageBox.Show("Tên Đăng Nhập Đã Tồn Tại");
            }
            else
            {
                context.Users.Add(user);
                context.SaveChanges();
                MessageBox.Show("Thêm Thành Công");
            }
            loadEmp();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>();
            foreach (DataGridViewRow row in tableDgv.SelectedRows)
            {
                list.Add(int.Parse(row.Cells[0].Value.ToString()));
            }
            context.RemoveRange(list);
            MessageBox.Show("Xóa Thành Công");
            loadEmp();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            loadEmp();
        }
    }
}
