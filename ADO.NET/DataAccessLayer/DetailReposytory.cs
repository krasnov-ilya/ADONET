using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DetailReposytory : IDetailRepositoy
    {
        public bool Create(Detail detail)
        {
            string connectionString = @"Data Source=.;Initial Catalog=MyDB;Integrated Security=True";
            var query = $"INSERT INTO Details (name) VALUES ('{detail.Name}')";

            SqlConnection connection = new SqlConnection(connectionString);

            using (connection)
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                var result = command.ExecuteNonQuery();

                connection.Close();
            }

            return true;
        }

        public bool Delete(int id)
        {
            string connectionString = @"Data Source=.;Initial Catalog=MyApp;Integrated Security=True";
            var query = $"DELETE FROM Details WHERE id = {id}";

            SqlConnection connection = new SqlConnection(connectionString);

            using (connection)
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                var result = command.ExecuteNonQuery();

                connection.Close();
            }

            return true;
        }

        public IEnumerable<Detail> GetDetails()
        {
            string connectionString = @"Data Source=.;Initial Catalog=MyDB;Integrated Security=True";
            var query = "SELECT * FROM Details";
            var result = new List<Detail>();

            SqlConnection connection = new SqlConnection(connectionString);

            using (connection)
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        result.Add(new Detail
                        {
                            Id = (int)reader["id"],
                            Name = (string)reader["name"]
                        });
                    }
                }
                connection.Close();

                return result;
            }
            
        }

        public bool Update(Detail detail)
        {
            string connectionString = @"Data Source=.;Initial Catalog=MyDB;Integrated Security=True";

            SqlConnection connection = new SqlConnection(connectionString);

            using (connection)
            {
                connection.Open();

                var details = GetDetails();

                var query = $"UPDATE Details SET name = '{detail.Name}' where id = {detail.Id}";

                var command = new SqlCommand(query, connection);

                var rowsChanged = command.ExecuteNonQuery();

                return rowsChanged != 0;
            }
        }
    }
}
