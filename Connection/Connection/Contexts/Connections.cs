using Microsoft.Data.SqlClient;

namespace Connection.Contexts
{
    public class Connections
    {
        private static string connectionString = "Data Source=DESKTOP-2RVF447;Initial Catalog=db_hr;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
        public static SqlConnection Get()
        {
            return new SqlConnection(connectionString);
        }
    }
}
