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
            FineCalculator();
            FillFines();

        }

        //Userlerin comboboxa yigilmasi
        public void FillUsers()
        {
            List<User> users = db.Users.OrderBy(b => b.Id).ToList();
            cmbUsers.DataSource = users;
            cmbUsers.DisplayMember = "Name";
        }

        //Book larin comboboxa yigilmasi
        public void FillBooks()
        {
            List<Book> books = db.Books.Where(b=>b.BookStatus == true).OrderBy(b => b.Id).ToList();
            cmbBooks.DataSource = books;
            cmbBooks.DisplayMember = "Name";
        }


        //Butun Orderlerin data grid view ya getirilmesi
        public void FillOrders()
        {
            List<Order> orders = db.Orders.OrderByDescending(o => o.TakeDate).ToList();
            foreach (var order in orders)
            {
                dgvOrders.Rows.Add(order.User.Name, order.Book.Name, order.TakeDate, order.Deadline);
            }

        }

        //Yeni orderin yaradilmasi
        public void AddOrder()
        {
            try
            {
                Order order = new Order();
                Book book = (Book)cmbBooks.SelectedItem;
                User user = (User)cmbUsers.SelectedItem;


                //Order propertileri elave olunur
                order.User = user;
                order.UserId = user.Id;
                order.TakeDate = DateTime.Now;
                order.Deadline = DateTime.Now.AddMonths(1);
                order.DelayedDays = 0;
                order.Book = book;
                order.BookId = book.Id;
                order.FinePrice = 0;


                //Kitab stokdan goturuldu
                book.BookStatus = false;


                

                db.Orders.Add(order);
                db.SaveChanges();

                dgvOrders.Rows.Clear();
                FillOrders();
            }
            catch(Exception exp)
            {
                MessageBox.Show("Something is wrong");
            }



        }


        //Proqramin baglanilmasi
        private void OrderManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.Close();
        }

        // cerime hesablayicisi
        public void FineCalculator()
        {
            List<Order> orders = db.Orders.ToList();

            foreach (var order in orders)
            {
                if(DateTime.Now > order.Deadline)
                {
                    DateTime currentDay = DateTime.Now;
                    DateTime deadline =(DateTime)order.Deadline;
                    TimeSpan delayedTime = currentDay.Subtract(deadline);
                    int delayedDays = delayedTime.Days;

                    order.FinePrice = delayedDays;
                    order.DelayedDays = delayedDays;
                    db.SaveChanges();

                }
            }

        }

        //Butona klikde yeni order yaranmasi
        private void btnOrder_Click(object sender, EventArgs e)
        {
            AddOrder();
        }



        //Cerime cedvelini doldur
        public void FillFines()
        {
            List<Order> orders = db.Orders.Where(o => o.DelayedDays >= 1).OrderByDescending(o=>o.TakeDate).ToList();
            foreach (var order in orders)
            {
                dgvFines.Rows.Add(order.User.Name, order.Book.Name, order.DelayedDays + " " + "days", order.FinePrice + " " + "manat");
            }
        }

    }
}
