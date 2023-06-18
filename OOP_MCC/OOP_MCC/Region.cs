using Microsoft.Data.SqlClient;

namespace OOP_MCC
{
    class Region
    {
        SqlConnection connection;
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Region> GetAllRegion()
        {
            string connectionString;
            connectionString = "Data Source=DESKTOP-2RVF447;Integrated Security=True;Connect Timeout=30;Database=db_hr;Encrypt=False;";

            var region = new List<Region>();
            try
            {
                connection = new SqlConnection(connectionString);

                // Membuat instance untuk command
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM tb_m_regions";

                // membuka koneksi
                connection.Open();
                using SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var reg = new Region();
                        reg.Id = reader.GetInt32(0);
                        reg.Name = reader.GetString(1);

                        region.Add(reg);
                    }
                }
                else
                {
                    Console.WriteLine("Data not found!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            connection.Close();
            return region;
        }
    }
}
