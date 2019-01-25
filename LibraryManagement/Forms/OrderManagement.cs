using LibraryManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement.Forms
{
    public partial class OrderManagement : Form
    {
        private readonly LibraryManagementEntities db = new LibraryManagementEntities();
        Form form;
        public OrderManagement(Form _form)
        {
            form = _form;
            InitializeComponent();
            FillBooks();
            FillUsers();
            FillOrders();
        }

        public void FillUsers()
        {
            List<User> users = db.Users.OrderBy(b => b.Id).ToList();
            cmbUsers.DataSource = users;
            cmbUsers.DisplayMember = "Name";
        }

        public void FillBooks()
        {
            List<Book> books = db.Books.OrderBy(b => b.Id).ToList();
            cmbBooks.DataSource = books;
            cmbBooks.DisplayMember = "Name";
        }

        public void FillOrders()
        {
            List<Order> orders = db.Orders.OrderByDescending(o => o.TakeDate).ToList();
            foreach (var order in orders)
            {
                dgvOrders.Rows.Add(order.User.Name, order.Book.Name, order.TakeDate, order.Deadline);
            }

        }

        private void OrderManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.Close();
        }
    }
}
