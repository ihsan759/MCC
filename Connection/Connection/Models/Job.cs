using Connection.Contexts;
using Microsoft.Data.SqlClient;

namespace Connection.Models
{
    public class Job
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public int MinSalary { get; set; }
        public int MaxSalary { get; set; }

        public List<Job> GetAll()
        {
            List<Job> jobs = new List<Job>();

            SqlConnection connection = Connections.Get();

            connection.Open();

            SqlTransaction transaction = connection.BeginTransaction();

            try
            {
                string sql = "SELECT * FROM tb_m_jobs";
                using (SqlCommand command = new SqlCommand(sql, connection, transaction))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Job job = new Job();
                            job.Id = reader["id"].ToString();
                            job.Title = reader["title"].ToString();
                            if (Convert.IsDBNull(reader["min_salary"]))
                            {
                                job.MinSalary = 0;
                            }
                            else
                            {
                                job.MinSalary = (int)reader["min_salary"];
                            }
                            if (Convert.IsDBNull(reader["max_salary"]))
                            {
                                job.MaxSalary = 0;
                            }
                            else
                            {

                                job.MaxSalary = (int)reader["max_salary"];
                            }

                            jobs.Add(job);
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
            return jobs;

        }
    }
}
