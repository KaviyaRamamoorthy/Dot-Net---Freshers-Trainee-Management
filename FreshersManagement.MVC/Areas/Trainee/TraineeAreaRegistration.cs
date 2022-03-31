using System.Web.Mvc;

namespace FreshersManagement.MVC.Areas.Trainee
{
    public class TraineeAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Trainee";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Trainee_default",
                "Trainee/{controller}/{action}/{id}",
                new {contoller = "Trainee", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}