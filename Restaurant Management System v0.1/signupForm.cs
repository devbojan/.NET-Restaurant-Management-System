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
    public partial class signupForm : Form
    {
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\BONJA\Documents\restaurantdatabase.mdf;Integrated Security=True;Connect Timeout=30";
        public signupForm()
        {
            InitializeComponent();
        }

        private void labelNoaccount_Click(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {


        }








        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure that you want to close this app?", "Confirmation message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void labelYesaccount_Click(object sender, EventArgs e)
        {

        }

        private void signup_showPassword_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LabelYesaccount1_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();

            this.Hide();
        }

        private void Signup_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();

                string checkUsername = "SELECT * FROM users WHERE username = @usern";

                using (SqlCommand checkUsern = new SqlCommand(checkUsername, connect))
                {
                    checkUsern.Parameters.AddWithValue("@usern", Signup_username.Text.Trim());


                    SqlDataAdapter adapter = new SqlDataAdapter(checkUsern);
                    DataTable table = new DataTable();

                    adapter.Fill(table);

                    if (table.Rows.Count != 0)
                    {
                        MessageBox.Show($"{Signup_username.Text.Trim()} was taken already", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else if (Signup_password.Text.Trim().Length < 8)
                    {
                        MessageBox.Show("Invalid password, at least 8 characters are required.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (Signup_password.Text.Trim() != Signup_ConfirmPassword.Text.Trim())
                    {
                        MessageBox.Show("Password does not match.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string insertData = "INSERT INTO users (username, password, status, date_created) VALUES(@usern, @pass, @status, @date)";
                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                        {
                            cmd.Parameters.AddWithValue("@usern", Signup_username.Text.Trim());
                            cmd.Parameters.AddWithValue("@pass", Signup_password.Text.Trim());
                            cmd.Parameters.AddWithValue("@status", "Active");

                            DateTime today = DateTime.Now;
                            cmd.Parameters.AddWithValue("@date", today);

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Registred successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Form1 loginForm = new Form1();
                            loginForm.Show();

                            this.Hide();
                        }
                    }
                }
            }
        }

        private void Signup_showPassword_CheckedChanged_1(object sender, EventArgs e)
        {
            Signup_password.PasswordChar = Signup_showPassword.Checked ? '\0' : '*';
            Signup_ConfirmPassword.PasswordChar = Signup_showPassword.Checked ? '\0' : '*';
        }

    }
}
