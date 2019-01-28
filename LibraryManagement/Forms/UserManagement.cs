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
    public partial class UserManagement : Form
    {
        private readonly LibraryManagementEntities db = new LibraryManagementEntities();
        Form form;
        Dashboard dashboard;
        public UserManagement(Form _form,Dashboard _dashboard)
        {
            InitializeComponent();
            form = _form;
            dashboard = _dashboard;
            DefaultVisibilty();
            FillUsers();
        }

        public void DefaultVisibilty()
        {
            btnUserDelete.Visible = false;
            btnUserUpdate.Visible = false;
        }


        public void FillUsers()
        {
            dgvUsers.Rows.Clear();
            List<User> users = db.Users.ToList();
            foreach (var user in users)
            {
                dgvUsers.Rows.Add(user.Id, user.Name, user.Surname, user.Email, user.Number);

            }
        }

        // user elave edilmesi
        public void AddUser()
        {
            try
            {
                User user = new User()
                {
                    Name = txtUsername.Text,
                    Surname = txtUserSurname.Text,
                    Email = txtUserEmail.Text,
                    Number = Convert.ToInt32(txtUserNmb.Text)
                };

                txtUsername.Clear();
                txtUserSurname.Clear();
                txtUserEmail.Clear();
                txtUserNmb.Clear();

                db.Users.Add(user);
                db.SaveChanges();
                dgvUsers.Rows.Clear();
                FillUsers();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }


        private void UserManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.Close();
        }

        private void btnUserAdd_Click(object sender, EventArgs e)
        {
            AddUser();
        }

        public int SelectedId = 0;
        //resetlemek uchhun olan metod
        private void Reset()
        {
            txtUsername.Clear();
            txtUserSurname.Clear();
            txtUserEmail.Clear();
            txtUserNmb.Clear();

            FillUsers();

            btnUserAdd.Visible = true;
            btnUserDelete.Visible = false;
            btnUserUpdate.Visible = false;
        }

        private void btnUserUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) && string.IsNullOrEmpty(txtUserSurname.Text))
            {
                MessageBox.Show("Name and Surname charts cannot be empty");
                return;
            }
            User user = db.Users.Find(SelectedId);
            user.Name = txtUsername.Text;
            user.Surname = txtUserSurname.Text;
            user.Email = txtUserEmail.Text;
            user.Number = Convert.ToInt32(txtUserNmb.Text);
            db.SaveChanges();
            FillUsers();
        }

        private void btnUserDelete_Click(object sender, EventArgs e)
        {
            User user = db.Users.Find(SelectedId);
            DialogResult r = MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                db.Users.Remove(user);
                db.SaveChanges();

                Reset();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            dashboard.Show();
        }

        private void dgvUsers_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnUserAdd.Visible = false;
            btnUserDelete.Visible = true;
            btnUserUpdate.Visible = true;

            int id = Convert.ToInt32(dgvUsers.Rows[e.RowIndex].Cells[0].Value);
            SelectedId = id;

            string name = dgvUsers.Rows[e.RowIndex].Cells[1].Value.ToString();
            string surname = dgvUsers.Rows[e.RowIndex].Cells[2].Value.ToString();
            string Email = dgvUsers.Rows[e.RowIndex].Cells[3].Value.ToString();
            string Number = dgvUsers.Rows[e.RowIndex].Cells[4].Value.ToString();

            txtUsername.Text = name;
            txtUserSurname.Text = surname;
            txtUserEmail.Text = Email;
            txtUserNmb.Text = Number;
        }
    }
}