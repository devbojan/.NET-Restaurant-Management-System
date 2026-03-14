using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Restaurant_Management_System_v0._1
{
    internal class ProductsList
    {
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\BONJA\Documents\restaurantdatabase.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True";

        public int ID { set; get; }
        public string ProductId { set; get; }
        public string ProductName { set; get; }
        public string Category { set; get; }
        public string Stock { set; get; }
        public string Price { set; get; }
        public string Status { set; get; }
        public string Image { set; get; }
        public string DateInsert { set; get; }
        public string DateUpdate { set; get; }

        public List<ProductsList> productsListData()
        {
            List<ProductsList> listData = new List<ProductsList>();


            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();

                string selectData = "SELECT * FROM products";

                using(SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while(reader.Read())
                    {
                        ProductsList pList = new ProductsList();

                        pList.ID = (int)reader["id"];
                        pList.ProductName = reader["productname"].ToString();
                        pList.ProductId = reader["productid"].ToString();
                        pList.Category = reader["category"].ToString();
                        pList.Stock = reader["stock"].ToString();
                        pList.Price = reader["price"].ToString();
                        pList.DateInsert = ((DateTime)reader["date_insert"]).ToString("MM-dd-yyyy");
                        pList.DateUpdate = ((DateTime)reader["date_update"]).ToString("MM-dd-yyyy");

                        listData.Add(pList);



                    }

                }

            }



                return listData;

        }

    }
}
