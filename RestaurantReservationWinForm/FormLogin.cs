using BusinessObjects.Models;
using Repositories;
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
    public partial class FormLogin : Form
    {
        IUserRepository repo = new UserRepository();
        public FormLogin()
        {
            InitializeComponent();
            label4.Enabled = true;
            txtUser.Focus();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtUser.Clear();
            txtUser.Focus();
            label4.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {

                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUser.Text;
            string passWord = txtPassword.Text;
            User loginUser = repo.CheckLogin(userName, passWord);
            if (loginUser != null)
            {
                MessageBox.Show("Bạn đã đăng nhập thành công với vai trò " + (loginUser.Role.Equals("quản lý") ? "người điều hành" : "nhân viên"), "Thông báo");
                FormManager f = new FormManager(loginUser);
                this.Hide();
                f.ShowDialog();

            }
            else
            {
                label4.Text = "Sai tên đăng nhập hoặc mật khẩu";
            }
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát ?", "Thông Báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
                
            }
        }

        private void FormLogin_Load_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
