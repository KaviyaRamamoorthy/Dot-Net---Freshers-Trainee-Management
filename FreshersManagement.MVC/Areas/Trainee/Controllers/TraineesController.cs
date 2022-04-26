using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Newtonsoft.Json;
using System.Configuration;

namespace FreshersManagement.MVC.Areas.Trainee.Controllers
{
    public class TraineesController : Controller
    {
        Uri baseAddress = new Uri(ConfigurationManager.AppSettings["Baseurl"]);
        HttpClient client;

        public TraineesController()
        {
            client = new HttpClient();
            client.BaseAddress = baseAddress;
        }

        public ActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> DisplayTrainee()
        {
            List<Model.Trainee> trainees = new List<Model.Trainee>();
            try
            {
                client.DefaultRequestHeaders.Clear();
                HttpResponseMessage response = await client.GetAsync(client.BaseAddress + "/values");

                if (response.IsSuccessStatusCode)
                {
                    var data = response.Content.ReadAsStringAsync().Result;
                    trainees = JsonConvert.DeserializeObject<List<Model.Trainee>>(data);
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Server error try after some time.");
                }
            }
            catch (Exception)
            {
                return View("Error");
            }
            return View(trainees);
        }

        public async Task<ActionResult> DisplayTraineeById(int id)
        {
            Model.Trainee trainees = new Model.Trainee();
            try
            {
                client.DefaultRequestHeaders.Clear();
                HttpResponseMessage response = await client.GetAsync(client.BaseAddress + "/values/" + id);

                if (response.IsSuccessStatusCode)
                {
                    var data = response.Content.ReadAsStringAsync().Result;
                    trainees = JsonConvert.DeserializeObject<Model.Trainee>(data);
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Server error try after some time.");
                }
            }
            catch (Exception ex)
            {
                return View("Error");
            }
            return View(trainees);
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Name = "Create";
            return PartialView("Edit");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Model.Trainee trainee)
        {
            try
            {
                string data = JsonConvert.SerializeObject(trainee);
                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(client.BaseAddress + "/values", content);

                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("DisplayTrainee");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Server error try after some time.");
                }
            }
            catch (Exception ex)
            {
                return View("Error");
            }
            return View();
        }

        public async Task<ActionResult> Edit(int id)
        {
            List<Model.Trainee> trainees = new List<Model.Trainee>();
            Model.Trainee model = new Model.Trainee();
            try
            {
                client.DefaultRequestHeaders.Clear();
                HttpResponseMessage response = await client.GetAsync(client.BaseAddress + "/values");

                if (response.IsSuccessStatusCode)
                {
                    var data = response.Content.ReadAsStringAsync().Result;
                    trainees = JsonConvert.DeserializeObject<List<Model.Trainee>>(data);
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Server error try after some time.");
                }
                foreach (Model.Trainee trainee in trainees)
                {
                    if (trainee.Id == id)
                    {
                        model = trainee;
                    }
                }
            }
            catch (Exception ex)
            {
                return View("Error");
            }
            return View("Edit", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Model.Trainee trainee)
        {
            try
            {
                string data = JsonConvert.SerializeObject(trainee);
                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PutAsync(client.BaseAddress + "/values/" + trainee.Id, content);

                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("DisplayTrainee");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Server error try after some time.");
                }
            }
            catch (Exception ex)
            {
                return View("Error");
            }
            return View("Edit", trainee);
        }

        [HttpPost]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                HttpResponseMessage response = await client.DeleteAsync(client.BaseAddress + "/values/" + id);

                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("DisplayTrainee");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Server error try after some time.");
                }
            }
            catch (Exception ex)
            {
                return View("Error");
            }
            return RedirectToAction("Index");
        }
    }
}