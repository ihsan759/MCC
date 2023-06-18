using Connection.Contexts;
using Microsoft.Data.SqlClient;

namespace Connection.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string StreetAddress { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string CountryId { get; set; }

        public List<Location> GetAll()
        {
            List<Location> locations = new List<Location>();

            SqlConnection connection = Connections.Get();

            connection.Open();

            SqlTransaction transaction = connection.BeginTransaction();

            try
            {
                string sql = "SELECT * FROM tb_m_locations";
                using (SqlCommand command = new SqlCommand(sql, connection, transaction))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Location location = new Location();
                            location.Id = (int)reader["id"];
                            location.StreetAddress = reader["street_address"].ToString();
                            location.PostalCode = reader["postal_code"].ToString();
                            location.City = reader["city"].ToString();
                            location.StateProvince = reader["state_province"].ToString();
                            location.CountryId = reader["country_id"].ToString();

                            locations.Add(location);
                        }
                    }
                }

                transaction.Commit();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                try
                {
                    transaction.Rollback();
                }
                catch (Exception rollbackEx)
                {
                    Console.WriteLine(rollbackEx.Message);
                }
            }
            connection.Close();
            return locations;

        }
    }
}
