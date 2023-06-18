using Connection.Contexts;
using Microsoft.Data.SqlClient;

namespace Connection.Models
{
    public class History
    {
        public DateTime StartDate { get; set; }
        public int EmployeeId { get; set; }
        public DateTime? EndDate { get; set; }
        public int DepartmentId { get; set; }
        public string JobId { get; set; }

        public List<History> GetAll()
        {
            List<History> histories = new List<History>();

            SqlConnection connection = Connections.Get();

            connection.Open();

            SqlTransaction transaction = connection.BeginTransaction();

            try
            {
                string sql = "SELECT * FROM tb_tr_histories";
                using (SqlCommand command = new SqlCommand(sql, connection, transaction))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            History history = new History();
                            history.StartDate = (DateTime)reader["start_date"];
                            history.EmployeeId = (int)reader["employee_id"];
                            if (Convert.IsDBNull(reader["end_date"]))
                            {
                                history.EndDate = null;
                            }
                            else
                            {
                                history.EndDate = (DateTime)reader["end_date"];
                            }
                            history.DepartmentId = (int)reader["department_id"];
                            history.JobId = reader["job_id"].ToString();

                            histories.Add(history);
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
            return histories;

        }
    }
}
