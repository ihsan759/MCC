using Microsoft.Data.SqlClient;

namespace OOP_MCC
{
    class Department
    {
        string connectionString = "Data Source=DESKTOP-2RVF447;Integrated Security=True;Connect Timeout=30;Database=db_hr;Encrypt=False;";
        public int Id { get; set; }
        public string Name { get; set; }
        public int LocarionId { get; set; }
        public int ManagerId { get; set; }

        public List<Department> GetAllDepartments()
        {
            List<Department> departments = new List<Department>();

            SqlConnection connection = new SqlConnection(connectionString);

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

            return departments;

        }
    }
}
