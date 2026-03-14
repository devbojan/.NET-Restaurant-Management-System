using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Restaurant_Management_System_v0._1
{
    public partial class InventoryForm : UserControl
    {
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\BONJA\Documents\restaurantdatabase.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True";

        public InventoryForm()
        {
            InitializeComponent();
            displayCategories();
            displayProducts();
        }

        private void displayProducts()
        {
            ProductsList pList = new ProductsList();
            List<ProductsList> listData = pList.productsListData();

            dataGridView1.DataSource = listData;
        }

        public void displayCategories()
        {
            Inventory_Category.Items.Clear();

            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();

                string selectCat = "SELECT * FROM categories WHERE status = 'Active'";

                using (SqlCommand cmd = new SqlCommand(selectCat, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Inventory_Category.Items.Add(reader["category"]);
                    }

                }
            }
        }

        private void Inventory_AddBtn_Click(object sender, EventArgs e)
        {
            if (Inventory_ProductID.Text == "" || Inventory_ProductName.Text == "" || Inventory_Category.SelectedIndex == -1 || Inventory_Stock.Text == "" || Inventory_Price.Text == "" || Inventory_Status.Text == "" || pictureBox1.Image == null)
            {
                MessageBox.Show("Empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                using (SqlConnection connect = new SqlConnection(connection))
                {
                    connect.Open();

                    string checkProductId = "SELECT * FROM products WHERE productid = @prodid";

                    using (SqlCommand checkProdId = new SqlCommand(checkProductId, connect))
                    {
                        checkProdId.Parameters.AddWithValue("@prodid", Inventory_ProductID.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(checkProdId);
                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        if(table.Rows.Count != 0)
                        {
                            MessageBox.Show($"{Inventory_ProductID.Text.Trim()} is existing already", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                        else
                        {
                            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

                            string insertData = "INSERT INTO products (productid, productname, category, stock, price, status, image, date_insert) VALUES(@productid, @productname, @category, @stock, @price, @status, @image, @date)";

                            string relativePath = Path.Combine("products_directory", Inventory_ProductID.Text.Trim() + ".jpg");
                            string path = Path.Combine(baseDirectory, relativePath);

                            string directoryPath = Path.GetDirectoryName(path);

                            if (!Directory.Exists(directoryPath))
                            {
                                Directory.CreateDirectory(directoryPath);
                            }

                            File.Copy(pictureBox1.ImageLocation, path, true);


                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@productid", Inventory_ProductID.Text.Trim());
                                cmd.Parameters.AddWithValue("@productname", Inventory_ProductName.Text.Trim());
                                cmd.Parameters.AddWithValue("@category", Inventory_Category.SelectedItem.ToString());
                                cmd.Parameters.AddWithValue("@stock", Inventory_Stock.Text.Trim());
                                cmd.Parameters.AddWithValue("@price", Inventory_Price.Text.Trim());
                                cmd.Parameters.AddWithValue("@status", Inventory_Status.SelectedItem.ToString());
                                cmd.Parameters.AddWithValue("@image", path);

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
            displayProducts();
        }

        private void Inventory_ImportBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Images Files (*.jpg, *.png|*jpg;*.png)";

                string imagePath = "";

                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    pictureBox1.ImageLocation = imagePath;
                }

            }
            
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {e}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void ClearFields()
        {
            Inventory_ProductID.Clear();
            Inventory_ProductName.Clear();
            Inventory_Category.SelectedIndex = -1;
            Inventory_Stock.Clear();
            Inventory_Price.Clear();
            Inventory_Status.SelectedIndex = -1;
            pictureBox1.Image = null;
            getID = 0;

        }

        private void Inventory_ClearBtn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private int getID = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                getID = (int)row.Cells[0].Value;
                Inventory_ProductID.Text = row.Cells[1].Value.ToString();
                Inventory_ProductName.Text = row.Cells[2].Value.ToString();
                Inventory_Category.Text = row.Cells[3].Value.ToString();
                Inventory_Stock.Text = row.Cells[4].Value.ToString();
                Inventory_Price.Text = row.Cells[5].Value.ToString();
                Inventory_Status.Text = row.Cells[6].Value.ToString();

                string imagePath = row.Cells[7].Value.ToString();

                try
                {
                    if(imagePath != null)
                    {
                        pictureBox1.Image = Image.FromFile(imagePath);
                    }
                    else
                    {
                        pictureBox1.Image = null;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Error: {ex}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }




            }
        }

        private void Inventory_UpdateBtn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show($"Are you sure you want to update ID {getID}?", "Confirmation Message", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (getID == 0)
                {
                    MessageBox.Show("Empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    using (SqlConnection connect = new SqlConnection(connection))
                    {
                        connect.Open();

                        string checkProductId = "SELECT * FROM products WHERE productid = @prodid";

                        using (SqlCommand checkProd = new SqlCommand(checkProductId, connect))
                        {
                            checkProd.Parameters.AddWithValue("@prodid", Inventory_ProductID.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(checkProd);
                            DataTable table = new DataTable();

                            adapter.Fill(table);

                            if (table.Rows.Count >= 2)
                            {
                                MessageBox.Show(Inventory_ProductID.Text.Trim() + "was existing already", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {
                                string updateData = "UPDATE products SET productid = @prodid, productname = @prodname, category = @cat, stock = @stock, price = @price, status = @status, date_update = @date WHERE id = @id";

                                using (SqlCommand cmd = new SqlCommand(updateData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@prodid", Inventory_ProductID.Text.Trim());
                                    cmd.Parameters.AddWithValue("@prodname", Inventory_ProductName.Text.Trim());
                                    cmd.Parameters.AddWithValue("@cat", Inventory_Category.SelectedItem.ToString());
                                    cmd.Parameters.AddWithValue("@stock", Inventory_Stock.Text.Trim());
                                    cmd.Parameters.AddWithValue("@price", Inventory_Price.Text.Trim());
                                    cmd.Parameters.AddWithValue("@status", Inventory_Status.SelectedItem.ToString());
                                    DateTime today = DateTime.Now;
                                    cmd.Parameters.AddWithValue("@date", today);
                                    cmd.Parameters.AddWithValue("@id", getID);

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    ClearFields();

                                }
                            }

                        }
                    }
                }
            }
            displayProducts();
        }

        private void Inventory_DeleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to delete ID {getID}?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (getID == 0)
                {
                    MessageBox.Show("Empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    using (SqlConnection connect = new SqlConnection(connection))
                    {
                        connect.Open();

                        string updateData = "DELETE FROM products WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {

                            cmd.Parameters.AddWithValue("@id", getID);

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Deleted successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields();

                        }


                    }
                }
            }
            displayProducts();
        }
    }
}
