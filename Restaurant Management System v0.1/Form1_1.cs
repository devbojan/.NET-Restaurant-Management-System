using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Restaurant_Management_System_v0._1
   {
    
    public partial class Form1 : Form
    {
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\BONJA\Documents\restaurantdatabase.mdf;Integrated Security=True;Connect Timeout=30";
        public Form1()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            
        }

        private void LabelNoaccount_Click(object sender, EventArgs e)
        {
           
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            

        }

        private void login_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            
        }

    private void labelNoaccount_Click(object sender, EventArgs e)
    {

    }

        private void Login_btn_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();

                string query = "SELECT * FROM users WHERE username = @usern AND password = @pass";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@usern", Login_username.Text.Trim());
                    cmd.Parameters.AddWithValue("@pass", Login_password.Text.Trim());

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        MessageBox.Show("Login successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        MainForm mainForm = new MainForm();
                        mainForm.Show();

                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Incorrect username/password!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
            }
        }

        private void Login_showPassword_CheckedChanged_1(object sender, EventArgs e)
        {
            Login_password.PasswordChar = Login_showPassword.Checked ? '\0' : '*';
        }

        private void LabelNoaccount_Click_1(object sender, EventArgs e)
        {
            signupForm signupForm = new signupForm();
            signupForm.Show();

            this.Hide();
        }

       

        private void Close_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure that you want to close this app?", "Confirmation message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }

}
