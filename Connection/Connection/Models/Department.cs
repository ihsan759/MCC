using Connection.Contexts;
using Microsoft.Data.SqlClient;

namespace Connection.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int LocarionId { get; set; }
        public int ManagerId { get; set; }

        public List<Department> GetAll()
        {
            List<Department> departments = new List<Department>();

            SqlConnection connection = Connections.Get();

            connection.Open();

            SqlTransaction transaction = connection.BeginTransaction();

            try
            {
                string sql = "SELECT * FROM tb_m_departments";
                using (SqlCommand command = new SqlCommand(sql, connection, transaction))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Department department = new Department();
                            department.Id = (int)reader["id"];
                            department.Name = reader["name"].ToString();
                            department.LocarionId = (int)reader["location_id"];
                            department.ManagerId = (int)reader["manager_id"];

                            departments.Add(department);
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
            return departments;

        }
    }
}
