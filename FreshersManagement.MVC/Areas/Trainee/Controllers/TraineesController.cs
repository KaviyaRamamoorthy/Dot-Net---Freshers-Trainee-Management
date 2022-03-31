using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FreshersManagement.Service;

namespace FreshersManagement.MVC.Areas.Trainee.Controllers
{
    public class TraineesController : Controller
    {
        // GET: Trainee/Trainee
        ITraineeService traineeService = new TraineeService();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DisplayTrainee()
        {
            return View(traineeService.Display().ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Name = "Create";
            return PartialView("Edit");
        }

        [HttpPost]
        public ActionResult Create(Model.Trainee trainee)
        {
            traineeService.CreateTrainee(trainee);
            return RedirectToAction("DisplayTrainee");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            ViewBag.Name = "Edit";
            List<Model.Trainee> trainees = traineeService.Display().ToList();
            Model.Trainee trainee = null;
            foreach (var traine in trainees)
            {
                if (traine.Id == id) {
                    trainee = traine;
                }
               
            }
            return PartialView(trainee);
        }

        [HttpPost]
        public ActionResult Edit(Model.Trainee trainee)
        {
            traineeService.UpdateTrainee(trainee);
            return RedirectToAction("DisplayTrainee");
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            traineeService.DeleteTrainee(id);
            return RedirectToAction("DisplayTrainee");
        }
    }
}