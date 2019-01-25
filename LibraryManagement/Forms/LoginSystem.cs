using LibraryManagement.Forms;
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

namespace LibraryManagement
{
    public partial class LoginSystem : Form
    {
        private readonly LibraryManagementEntities db = new LibraryManagementEntities();

        public LoginSystem()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            List<Admin> admins = db.Admins.ToList();
            foreach (var admin in admins)
            {
                if(admin.Email == txtUserName.Text && admin.Password == txtPassword.Text)
                {
                    Dashboard dsh = new Dashboard(this);
                    dsh.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Password or E-mail is wrong, check and fix it");
                }
            }

        }
    }
}
