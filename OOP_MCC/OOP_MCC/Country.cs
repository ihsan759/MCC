using Microsoft.Data.SqlClient;

namespace OOP_MCC
{
    class Country
    {
        string connectionString = "Data Source=DESKTOP-2RVF447;Integrated Security=True;Connect Timeout=30;Database=db_hr;Encrypt=False;";
        public string Id { get; set; }
        public string Name { get; set; }
        public int RegionId { get; set; }

        public List<Country> GetAllCountries()
        {
            List<Country> countries = new List<Country>();

            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            SqlTransaction transaction = connection.BeginTransaction();

            try
            {
                string sql = "SELECT * FROM tb_m_countries";
                using (SqlCommand command = new SqlCommand(sql, connection, transaction))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Country country = new Country();
                            country.Id = reader["id"].ToString();
                            country.Name = reader["name"].ToString();
                            country.RegionId = (int)reader["region_id"];

                            countries.Add(country);
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

            return countries;

        }
    }
}
