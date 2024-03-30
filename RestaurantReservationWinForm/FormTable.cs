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
    public partial class FormTable : Form
    {
        private RurestaurantReservationSystemContext context;
        public FormTable()
        {
            context = new RurestaurantReservationSystemContext();
            InitializeComponent();
            loadTable();
        }

        private void loadTable()
        {
            tableDgv.DataSource = context.Tables.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Table table = new Table()
            {
                TableName = textBox2.Text,
                Status = true,
            };
            context.Tables.Add(table);
            context.SaveChanges();
            loadTable();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Table> list = new List<Table>();
            foreach (DataGridViewRow row in tableDgv.SelectedRows)
            {
                list.Add(context.Tables.SingleOrDefault(n => n.TableId == int.Parse(row.Cells[0].Value.ToString())));
            }
            context.Tables.RemoveRange(list);
            MessageBox.Show("Xóa Thành Công");
            loadTable();
        }
    }
}
