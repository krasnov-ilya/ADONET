using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class CarRepository : ICarRepository
    {
        public bool Create(Car car)
        {
            string connectionString = @"Data Source=.;Initial Catalog=MyDB;Integrated Security=True";
            var query = $"INSERT INTO Cars (name) VALUES ('{car.Name}')";

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
            var query = $"DELETE FROM Cars WHERE id = {id}";

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

        public IEnumerable<Car> GetCars()
        {
            string connectionString = @"Data Source=.;Initial Catalog=MyDB;Integrated Security=True";
            var query = "SELECT * FROM Cars";
            var result = new List<Car>();

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
                        result.Add(new Car
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

        public IEnumerable<Detail> GetDetails(int Id)
        {
            string connectionString = @"Data Source=.;Initial Catalog=MyDB;Integrated Security=True";
            var query = $"SELECT Details.id, Details.name FROM Details INNER JOIN Cars on detail_id = Details.id WHERE Cars.id = ('{Id}')";
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

        public bool Update(Car car)
        {
            string connectionString = @"Data Source=.;Initial Catalog=MyDB;Integrated Security=True";

            SqlConnection connection = new SqlConnection(connectionString);

            using (connection)
            {
                connection.Open();

                var cars = GetCars();

                var query = $"UPDATE Cars SET name = '{car.Name}' where id = {car.Id}";

                var command = new SqlCommand(query, connection);

                var rowsChanged = command.ExecuteNonQuery();

                return rowsChanged != 0;
            }
        }
    }
}
