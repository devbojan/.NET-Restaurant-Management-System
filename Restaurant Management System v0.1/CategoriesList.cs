using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Restaurant_Management_System_v0._1
{
    internal class CategoriesList
    {
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\BONJA\Documents\restaurantdatabase.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True";
        
        public int ID { set; get; }
        public string category { set; get; }
        public string status { set; get; }
        public string DateInsert { set; get; }

        public List<CategoriesList> categoriesListData()
        {
            List<CategoriesList> listData = new List<CategoriesList>();

            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();

                string selectData = "SELECT * FROM categories";
                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while(reader.Read())
                    {
                        CategoriesList cData = new CategoriesList();
                        cData.ID = (int)reader["id"];
                        cData.category = reader["category"].ToString();
                        cData.status = reader["status"].ToString();
                        cData.DateInsert = ((DateTime)reader["date_insert"]).ToString("MM-dd-yyyy");

                        listData.Add(cData);

                    }
                }
            }

            return listData;
        }

    }
}
