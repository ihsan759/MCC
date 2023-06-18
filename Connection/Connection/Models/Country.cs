using Connection.Contexts;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Connection.Models
{
    public class Country
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public int RegionId { get; set; }

        public List<Country> GetAll()
        {
            List<Country> countries = new List<Country>();

            SqlConnection connection = Connections.Get();


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

        public int Insert(string countryId, string nama, int regionId)
        {
            int result = 0;
            SqlConnection connection = Connections.Get();

            connection.Open();
            SqlTransaction transaction = connection.BeginTransaction();
            try
            {
                // Membuat Instance untuk command
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "INSERT INTO tb_m_countries (id, name, region_id) VALUES (@country_id, @country_name, @region_id)";
                command.Transaction = transaction;

                // Membuat array
                SqlParameter[] parameters =
                {
                new SqlParameter("@country_id",SqlDbType.VarChar){Value = countryId},
                new SqlParameter("@country_name",SqlDbType.VarChar){Value=nama},
                new SqlParameter("@region_id",SqlDbType.Int){Value=regionId}
            };

                // Menambahkan parameter ke command
                command.Parameters.AddRange(parameters);

                // Menjalankan command
                result = command.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                try
                {
                    transaction.Rollback();
                }
                catch (Exception rollback)
                {
                    Console.WriteLine(rollback.Message);
                }
            }
            connection.Close();
            return result;
        }

        public Country Get(string id)
        {
            var country = new Country();
            SqlConnection connection = Connections.Get();

            connection.Open();

            string sql = "SELECT * FROM tb_m_countries WHERE id = @country_id";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                SqlParameter pId = new SqlParameter("@country_id", SqlDbType.VarChar);
                pId.Value = id;
                command.Parameters.Add(pId);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        country.Id = reader["id"].ToString();
                        country.Name = reader["name"].ToString();
                        country.RegionId = (int)reader["region_id"];
                    }
                    else
                    {
                        country = null;
                    }
                }
            }
            connection.Close();
            return country;
        }

        public int Update(string countryId, string name, int regionId)
        {
            int result = 0;
            SqlConnection connection = Connections.Get();

            connection.Open();
            SqlTransaction transaction = connection.BeginTransaction();
            try
            {
                // Membuat Instance untuk command
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "UPDATE tb_m_countries SET name = @country_name, region_id = @region_id  WHERE id = @country_id";
                command.Transaction = transaction;

                // Membuat array
                SqlParameter[] parameters =
                {
                new SqlParameter("@country_name",SqlDbType.VarChar){Value = name},
                new SqlParameter("@country_id",SqlDbType.VarChar){Value = countryId},
                new SqlParameter("@region_id",SqlDbType.Int){Value=regionId}
            };

                // Menambahkan parameter ke command
                command.Parameters.AddRange(parameters);

                // Menjalankan command
                result = command.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                try
                {
                    transaction.Rollback();
                }
                catch (Exception rollback)
                {
                    Console.WriteLine(rollback.Message);
                }
            }
            connection.Close();
            return result;
        }

        public int Delete(string id)
        {
            int result = 0;
            SqlConnection connection = Connections.Get();

            connection.Open();
            SqlTransaction transaction = connection.BeginTransaction();
            try
            {
                // Membuat Instance untuk command
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "DELETE FROM tb_m_countries WHERE (id) = (@country_id)";
                command.Transaction = transaction;

                // Membuat parameter
                SqlParameter pId = new SqlParameter();
                pId.ParameterName = "@country_id";
                pId.Value = id;
                pId.SqlDbType = SqlDbType.VarChar;

                // Menambahkan parameter ke command
                command.Parameters.Add(pId);

                // Menjalankan command
                result = command.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                try
                {
                    transaction.Rollback();
                }
                catch (Exception rollback)
                {
                    Console.WriteLine(rollback.Message);
                }
            }
            connection.Close();
            return result;
        }
    }
}
