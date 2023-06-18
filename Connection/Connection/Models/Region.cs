using Connection.Contexts;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Connection.Models
{
    public class Region
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Region> GetAll()
        {
            var region = new List<Region>();
            SqlConnection connection = Connections.Get();
            try
            {
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

        public Region Get(int id)
        {
            SqlConnection connection = Connections.Get();

            var region = new Region();
            connection.Open();

            string sql = "SELECT * FROM tb_m_regions WHERE id = @region_id";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                SqlParameter pId = new SqlParameter("@region_id", SqlDbType.Int);
                pId.Value = id;
                command.Parameters.Add(pId);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        region.Name = reader["name"].ToString();
                        region.Id = (int)reader["id"];
                    }
                    else
                    {
                        region = new Region();
                    }
                }
            }
            connection.Close();
            return region;
        }

        public int Insert(string nama)
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
                command.CommandText = "Insert Into tb_m_regions (name) VALUES (@region_name)";
                command.Transaction = transaction;

                // Membuat parameter
                SqlParameter pName = new SqlParameter();
                pName.ParameterName = "@region_name";
                pName.Value = nama;
                pName.SqlDbType = SqlDbType.VarChar;

                // Menambahkan parameter ke command
                command.Parameters.Add(pName);

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

        public int Update(string nama, int id)
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
                command.CommandText = "UPDATE tb_m_regions SET name = @region_name WHERE id = @region_id";
                command.Transaction = transaction;

                // Membuat array
                SqlParameter[] parameters =
                {
                new SqlParameter("@region_name",SqlDbType.VarChar){Value = nama},
                new SqlParameter("@region_id",SqlDbType.Int){Value=id}
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

        public int Delete(int id)
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
                command.CommandText = "DELETE FROM tb_m_regions WHERE (id) = (@region_id)";
                command.Transaction = transaction;

                // Membuat parameter
                SqlParameter pId = new SqlParameter();
                pId.ParameterName = "@region_id";
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
