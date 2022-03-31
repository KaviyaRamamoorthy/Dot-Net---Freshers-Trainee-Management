using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
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

        public IEnumerable<Trainee> FetchTrainee()
        { 
            string commandText = "spSelectTrainees";
            List<Trainee> trainees = new List<Trainee>();
            try
            {
                sqlConnection = databaseManager.GetConnection();
                sqlCommand = databaseManager.GetCommand(commandText, sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
               
                while (sqlDataReader.Read())
                {
                    Trainee trainee = new Trainee();
                    trainee.Id = int.Parse(sqlDataReader["Id"].ToString());
                    trainee.Name = sqlDataReader["Name"].ToString();
                    trainee.MobileNumber = long.Parse(sqlDataReader["MobileNumber"].ToString());
                    trainee.Qualification = sqlDataReader["Qualification"].ToString();
                    DateTime dateTime = DateTime.Parse(sqlDataReader["Dob"].ToString());
                    trainee.Dob = dateTime.ToString("yyyy/MM/dd");
                    trainee.Address = sqlDataReader["Address"].ToString();
                    trainees.Add(trainee);
                }
            }
            catch (SqlException exception)
            {
                Console.WriteLine("Error: " + exception.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
            return trainees;
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
