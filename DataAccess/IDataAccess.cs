using FreshersManagement.Model;
using System.Collections.Generic;
using System.Data;

namespace FreshersManagement.Data
{
    public interface IDataAccess
    {   
        int InsertTrainee(Trainee trainee);

        IEnumerable<Trainee> FetchTrainee();

        void UpdateTrainee(Trainee trainee);

        void DeleteTrainee(int id);
    }
}