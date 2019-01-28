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
    public partial class BookManagement : Form
    {
        private readonly LibraryManagementEntities db = new LibraryManagementEntities();
        Form form;
        Dashboard dashboard;

        public BookManagement(Form _form,Dashboard _dashboard)
        {
            form = _form;
            dashboard = _dashboard;
            InitializeComponent();
            DefaultVisibilty();
            FillBooks();

        }

        public void DefaultVisibilty()
        {
            btnBookDelete.Visible = false;
            btnBookUpdate.Visible = false;
        }


        public void FillBooks()
        {
            dgvBooks.Rows.Clear();
            List<Book> books = db.Books.ToList();
            foreach (var book in books)
            {
                dgvBooks.Rows.Add(book.Name, book.Author, book.PageCount,book.Genre,book.Id);

            }
        }

        //kitab elave etmek uchun metod

        public void AddBook()
        {
            try
            {
                Book book = new Book()
                {
                    Name = txtBookname.Text,
                    Author = txtBookAuthor.Text,
                    PageCount = Convert.ToInt32(txtBookPage.Text),
                    Genre = txtBookgenre.Text,
                    BookStatus = true
                };

                txtBookname.Clear();
                txtBookAuthor.Clear();
                txtBookPage.Clear();
                txtBookgenre.Clear();

                db.Books.Add(book);
                db.SaveChanges();
                FillBooks();
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
  
            
        }

        private void BookManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.Close();
        }


       

        private void btnBookAdd_Click(object sender, EventArgs e)
        {
            AddBook();
        }

        public int SelectedId = 0;
        private void dgvBooks_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnBookAdd.Visible = false;
            btnBookDelete.Visible = true;
            btnBookUpdate.Visible = true;

            int id = Convert.ToInt32(dgvBooks.Rows[e.RowIndex].Cells[4].Value);
            SelectedId = id;

            string name = dgvBooks.Rows[e.RowIndex].Cells[0].Value.ToString();
            string auhtor = dgvBooks.Rows[e.RowIndex].Cells[1].Value.ToString();
            string pageCount = dgvBooks.Rows[e.RowIndex].Cells[2].Value.ToString();
            string genre = dgvBooks.Rows[e.RowIndex].Cells[3].Value.ToString();

            txtBookname.Text = name;
            txtBookAuthor.Text = auhtor;
            txtBookPage.Text = pageCount;
            txtBookgenre.Text = genre;
        }

        //resetlemek uchhun olan metod
        private void Reset()
        {
            txtBookname.Clear();
            txtBookAuthor.Clear();
            txtBookgenre.Clear();
            txtBookPage.Clear();

            FillBooks();

            btnBookAdd.Visible = true;
            btnBookDelete.Visible = false;
            btnBookUpdate.Visible = false;
        }

        private void btnBookUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBookname.Text) && string.IsNullOrEmpty(txtBookAuthor.Text))
            {
                MessageBox.Show("Name and author charts cannot be empty");
                return;
            }
            Book book = db.Books.Find(SelectedId);
            book.Name = txtBookname.Text;
            book.Genre = txtBookgenre.Text;
            book.Author = txtBookAuthor.Text;
            book.PageCount = Convert.ToInt32(txtBookPage.Text);
            db.SaveChanges();
            FillBooks();

        }

        private void btnBookDelete_Click(object sender, EventArgs e)
        {
            Book book = db.Books.Find(SelectedId);
            DialogResult r = MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                db.Books.Remove(book);
                db.SaveChanges();

                Reset();

            }
        }

        //geriye qaytarmaq uchun button
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            dashboard.Show();
        }

    }
}
