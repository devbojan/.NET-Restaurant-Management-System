using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Restaurant_Management_System_v0._1
{
    internal class CustomersList

    {
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\BONJA\Documents\restaurantdatabase.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True";

        public int id { set; get; }
        public string customerId { set; get; }
        public string productsIds { set; get; }
        public string quantities { set; get; }
        public string prices { set; get; }
        public string totalPrice { set; get; }
        public string dateOrder { set; get; }

        public List<CustomersList> customerListData()
        {
            List<CustomersList> listData = new List<CustomersList>();

            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();

                string selectData = "SELECT * FROM orders";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        CustomersList cData = new CustomersList();

                        cData.id = (int)reader["id"];
                        cData.customerId = reader["customerId"].ToString();
                        cData.productsIds = reader["productsIds"].ToString();
                        cData.quantities = reader["quantities"].ToString();
                        cData.prices = reader["prices"].ToString();
                        cData.totalPrice = reader["total"].ToString();
                        cData.dateOrder = ((DateTime)reader["date_order"]).ToString("MM-dd-yyyy");

                        listData.Add(cData);

                    }

                }

            }

                return listData;

        }


        public List<CustomersList> todaySalescustomerListData()
        {
            List<CustomersList> listData = new List<CustomersList>();

            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();

                string selectData = "SELECT * FROM orders WHERE date_order = @date";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {

                    DateTime today = DateTime.Now;
                    String getToday = today.ToString("yyyy-MM-dd");

                    cmd.Parameters.AddWithValue("@date", getToday);
                    SqlDataReader reader = cmd.ExecuteReader();
                    
                    while (reader.Read())
                    {
                        CustomersList cData = new CustomersList();

                        cData.id = (int)reader["id"];
                        cData.customerId = reader["customerId"].ToString();
                        cData.productsIds = reader["productsIds"].ToString();
                        cData.quantities = reader["quantities"].ToString();
                        cData.prices = reader["prices"].ToString();
                        cData.totalPrice = reader["total"].ToString();
                        cData.dateOrder = ((DateTime)reader["date_order"]).ToString("MM-dd-yyyy");

                        listData.Add(cData);

                    }

                }

            }

            return listData;

        }


    }
}
