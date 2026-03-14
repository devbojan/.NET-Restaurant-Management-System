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
    public partial class CategoriesForm : UserControl
    {
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\BONJA\Documents\restaurantdatabase.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True";
        public CategoriesForm()
        {
            InitializeComponent();
            displayCategories();
        }

        private void Categories_addBtn_Click(object sender, EventArgs e)
        {
            if (Categories_category.Text == "" || Categories_status.SelectedIndex == -1)
            {
                MessageBox.Show("Empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
                using (SqlConnection connect = new SqlConnection(connection))
                {
                    connect.Open();

                    string selectCategory = "SELECT * FROM categories WHERE category = @cat";

                    using (SqlCommand checkCat = new SqlCommand(selectCategory, connect))
                    {
                        checkCat.Parameters.AddWithValue("@cat", Categories_category.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(checkCat);
                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            MessageBox.Show(Categories_category.Text.Trim() + " is existing already", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else
                        {
                            string insertData = "INSERT INTO categories (category, status, date_insert) VALUES(@cat, @status, @date)";

                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@cat", Categories_category.Text.Trim());
                                cmd.Parameters.AddWithValue("@status", Categories_status.SelectedItem.ToString());

                                DateTime today = DateTime.Now;
                                cmd.Parameters.AddWithValue("@date", today);

                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                ClearFields();

                            }

                        }
                    }
                }
            }
            displayCategories();

        }

        void ClearFields()
        {
            Categories_category.Clear();
            Categories_status.SelectedIndex = -1;
            getID = 0;
        }

        private void Categories_clearBtn_Click(object sender, EventArgs e)
        {

            ClearFields();
        }

        public void displayCategories()
        {
            CategoriesList cData = new CategoriesList();
            List<CategoriesList> listData = cData.categoriesListData();

            dataGridView1.DataSource = listData;

        }

        private int getID = 0;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                getID = (int)row.Cells[0].Value;
                Categories_category.Text = row.Cells[1].Value.ToString();
                Categories_status.Text = row.Cells[2].Value.ToString();
            }
        }

        private void Categories_UpdateBtn_Click(object sender, EventArgs e)
        {
            if (getID == 0)
            {
                MessageBox.Show("Select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (MessageBox.Show($"Are you sure you want to update this ID {getID}?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(connection))
                    {
                        connect.Open();

                        string updateData = "UPDATE categories SET category = @cat,status = @status WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@id", getID);
                            cmd.Parameters.AddWithValue("@cat", Categories_category.Text.Trim());
                            cmd.Parameters.AddWithValue("@status", Categories_status.SelectedItem.ToString());

                            cmd.ExecuteNonQuery();
                            ClearFields();
                            

                            MessageBox.Show("Updated Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        }
                        connect.Close();
                    }
                }
            }
            displayCategories();
        }

        private void Categories_deleteBtn_Click(object sender, EventArgs e)
        {
                if (getID == 0)
                {
                    MessageBox.Show("Select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    if (MessageBox.Show($"Are you sure you want to delete this ID {getID}?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (SqlConnection connect = new SqlConnection(connection))
                        {
                            connect.Open();

                            string updateData = "DELETE FROM categories WHERE id = @id";

                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@id", getID);
                                
                                cmd.Parameters.AddWithValue("@status", Categories_status.SelectedItem.ToString());

                                cmd.ExecuteNonQuery();
                                ClearFields();


                                MessageBox.Show("Updated Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                            }
                            connect.Close();
                        }
                    }
                }
                displayCategories();
            }
    }
}
