using FreshersManagement.Model;
using System.Collections.Generic;

namespace FreshersManagement.Service
{
    public interface ITraineeService
    {
        int CreateTrainee(Trainee trainee);

        void DeleteTrainee(int id);

        List<Trainee> Display();
  
        int UpdateTrainee(Trainee trainee);
    }
}