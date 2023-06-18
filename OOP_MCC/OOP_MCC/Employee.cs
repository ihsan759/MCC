using Microsoft.Data.SqlClient;

namespace OOP_MCC
{
    class Employee
    {
        string connectionString = "Data Source=DESKTOP-2RVF447;Integrated Security=True;Connect Timeout=30;Database=db_hr;Encrypt=False;";
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime HireDate { get; set; }
        public int Salary { get; set; }
        public decimal? ComissionPct { get; set; }
        public int ManagerId { get; set; }
        public string JobId { get; set; }
        public int DepartmentId { get; set; }


        public List<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();

            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            SqlTransaction transaction = connection.BeginTransaction();

            try
            {
                string sql = "SELECT * FROM tb_m_employess";
                using (SqlCommand command = new SqlCommand(sql, connection, transaction))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Employee employee = new Employee();
                            employee.Id = (int)reader["id"];
                            employee.FirstName = reader["first_name"].ToString();
                            employee.LastName = reader["last_name"].ToString();
                            employee.Email = reader["email"].ToString();
                            employee.PhoneNumber = reader["phone_number"].ToString();
                            employee.HireDate = (DateTime)reader["hire_date"];
                            employee.Salary = (int)reader["salary"];
                            if (Convert.IsDBNull(reader["comission_pct"]))
                            {
                                employee.ComissionPct = 0;
                            }
                            else
                            {
                                employee.ComissionPct = Convert.ToDecimal(reader["comission_pct"]);
                            }
                            if (Convert.IsDBNull(reader["manager_id"]))
                            {
                                employee.ManagerId = 0;
                            }
                            else
                            {

                                employee.ManagerId = (int)reader["manager_id"];
                            }
                            employee.JobId = reader["job_id"].ToString();
                            employee.DepartmentId = (int)reader["department_id"];

                            employees.Add(employee);
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

            return employees;

        }
    }


}
