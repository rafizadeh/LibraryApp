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

        public UserManagement(Form _form)
        {
            InitializeComponent();
            form = _form;
        }

        private void UserManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.Close();
        }
    }
}
