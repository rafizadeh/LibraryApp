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
    public partial class Dashboard : Form
    {

        Form form;
        public Dashboard(Form _form)
        {
            form = _form;
            InitializeComponent();
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.Close();
        }

        #region Menu
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            BookManagement bk = new BookManagement(form);
            bk.Show();
            this.Hide();
        }

        #endregion

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OrderManagement or = new OrderManagement(form);
            or.Show();
            this.Hide();
        }
    }
}
