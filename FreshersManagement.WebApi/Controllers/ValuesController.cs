using System.Collections.Generic;
using System.Web.Http;
using FreshersManagement.Service;
using FreshersManagement.Model;

namespace FreshersManagement.WebApi.Controllers
{
   
    public class ValuesController : ApiController
    {
        ITraineeService traineeService = new TraineeService();
        // GET api/values
        public IEnumerable<Trainee> Get()
        {
            return traineeService.Display();
        }

        // GET api/values/5
        //public Trainee Get(int id)
        //{
        //    return traineeService.FetchTraineeById(id);
        //}

        // POST api/values
        public void Post([FromBody] Trainee trainee)
        {
            traineeService.CreateTrainee(trainee);
        }

        // PUT api/values/5
        public IHttpActionResult Put(int id, [FromBody] Trainee trainee)
        {
            if (1 == traineeService.UpdateTrainee(trainee))
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            traineeService.DeleteTrainee(id);
        }
    }
}
