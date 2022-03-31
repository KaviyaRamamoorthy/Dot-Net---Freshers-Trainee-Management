using FreshersManagement.Model;
using System.Collections.Generic;

namespace FreshersManagement.Service
{
    public interface ITraineeService
    {
        int CreateTrainee(Trainee trainee);

        List<Trainee> Display();

        void UpdateTrainee(Trainee trainee);

        void DeleteTrainee(int id);
    }
}