using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management_System_v0._1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure that you want to close this app?", "Confirmation message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure that you want to logout from this app?", "Confirmation message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();

                this.Hide();
            }
        }

        private void Dashboard_btn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = true;
            shopForm1.Visible = false;
            inventoryForm1.Visible = false;
            categoriesForm1.Visible = false;
            customersForm1.Visible = false;
        }

        private void Shop_btn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = false;
            shopForm1.Visible = true;
            inventoryForm1.Visible = false;
            categoriesForm1.Visible = false;
            customersForm1.Visible = false;
        }

        private void Inventory_btn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = false;
            shopForm1.Visible = false;
            inventoryForm1.Visible = true;
            categoriesForm1.Visible = false;
            customersForm1.Visible = false;
        }

        private void Categories_btn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = false;
            shopForm1.Visible = false;
            inventoryForm1.Visible = false;
            categoriesForm1.Visible = true;
            customersForm1.Visible = false;
        }

        private void Customers_btn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = false;
            shopForm1.Visible = false;
            inventoryForm1.Visible = false;
            categoriesForm1.Visible = false;
            customersForm1.Visible = true;
        }
    }
}
