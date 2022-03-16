using System;
using System.Data;
using System.Data.SqlClient;
using FreshersManagement.Model;

namespace FreshersManagement.Data
{
    public class DataAccess : IDataAccess
    {
        SqlConnection sqlConnection = null;
        SqlCommand sqlCommand = new SqlCommand();
        DatabaseManager databaseManager = new DatabaseManager();

        public int InsertTrainee(Trainee trainee)
        {
            string commandText = $"spSaveTrainee {trainee.Id}, '{trainee.Name}', " +
                    $"{trainee.MobileNumber}, '{trainee.Qualification}', '{trainee.Dob}', " +
                    $"'{trainee.Address}'";
            int affectedRows = 0;
            try
            {
                sqlConnection = databaseManager.GetConnection();
                sqlCommand = databaseManager.GetCommand(commandText, sqlConnection);
                affectedRows = sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException exception)
            {
                Console.WriteLine("Error: " + exception.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
            return affectedRows;
        }

        public DataTable FetchTrainee()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = null;
            string commandText = "spSelectTrainees";
            try
            {
                sqlConnection = databaseManager.GetConnection();
                sqlDataAdapter = databaseManager.GetValues(commandText, sqlConnection);
                sqlDataAdapter.Fill(dataTable);
            }
            catch (SqlException exception)
            {
                Console.WriteLine("Error: " + exception.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
            return dataTable;
        }

        public void UpdateTrainee(Trainee trainee)
        {
            string commandText = $"spSaveTrainee {trainee.Id}, '{trainee.Name}', " +
                    $"{trainee.MobileNumber}, '{trainee.Qualification}', '{trainee.Dob}', " +
                    $"'{trainee.Address}'";
            try
            {
                sqlConnection = databaseManager.GetConnection();
                sqlCommand = databaseManager.GetCommand(commandText, sqlConnection);
                sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException exception)
            {
                Console.WriteLine("Error: " + exception.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public void DeleteTrainee(int id)
        {
            string commandText = $"spDeleteTrainee {id}";
            try
            {
                sqlConnection = databaseManager.GetConnection();
                sqlCommand = databaseManager.GetCommand(commandText, sqlConnection);
                sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException exception)
            {
                Console.WriteLine("Error: " + exception.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
