using BaiTap1___NET.DataAccessLayer.DataClass;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1___NET.DataAccessLayer
{
    public class AnimalDAL
    {
        private string connectionString = "Data Source=MSI;Initial Catalog=QUANLYTRANGTRAI;Integrated Security=True";

        public List<Animal> GetAllAnimals()
        {
            List<Animal> animals = new List<Animal>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM ANIMALS";
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Animal animal = new Animal();
                }
            }

            return animals;
        }
    }
}
