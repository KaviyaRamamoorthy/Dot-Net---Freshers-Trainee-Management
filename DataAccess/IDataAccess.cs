using FreshersManagement.Model;
using System.Data;

namespace FreshersManagement.Data
{
    public interface IDataAccess
    {   
        int InsertTrainee(Trainee trainee);

        DataTable FetchTrainee();

        void UpdateTrainee(Trainee trainee);

        void DeleteTrainee(int id);
    }
}