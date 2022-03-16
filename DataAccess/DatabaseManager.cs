using System.Data.SqlClient;

namespace FreshersManagement.Data
{
    public class DatabaseManager
    {
        public SqlConnection GetConnection()
        {
            string connectionString = "data source=.; database=Fresher_Management; integrated security=SSPI";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            return sqlConnection;
        }

        public SqlCommand GetCommand(string commandText, SqlConnection sqlConnection)
        {
            SqlCommand sqlCommand = new SqlCommand(commandText, sqlConnection);
            return sqlCommand;
        }

        public SqlDataAdapter GetValues(string commandText, SqlConnection sqlConnection)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(commandText, sqlConnection);
            return sqlDataAdapter;
        }
    }
}
