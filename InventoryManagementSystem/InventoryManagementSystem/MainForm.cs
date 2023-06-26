using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void ProductBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new ProductForm());
        }



        private void CustomerBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new CustomerForm());
        }

        private void CategoriesBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new CategoryForm());
        }

        private void UsersBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new UserForm());
        }

        private void OrdersBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new OrderForm());
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void UserLoad()
        {

        }
    }
}
