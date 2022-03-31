using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreshersManagement.Data;
using FreshersManagement.Model;

namespace FreshersManagement.Service
{
    public class TraineeService : ITraineeService
    {
        IDataAccess dataAccess = new DataAccess();

        public int CreateTrainee(Trainee trainee)
        {
            return dataAccess.InsertTrainee(trainee);
        }

        public List<Trainee> Display()
        {
            List<Trainee> trainee = dataAccess.FetchTrainee().ToList();
            return trainee;
        }

        public void UpdateTrainee(Trainee trainee)
        {
            dataAccess.UpdateTrainee(trainee);
        }

        public void DeleteTrainee(int id)
        {
            dataAccess.DeleteTrainee(id);
        }
    }
}
