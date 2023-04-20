using Microsoft.AspNetCore.Mvc;
using TemplatesetupTask.DataAccess;
using TemplatesetupTask.Models;
using TemplatesetupTask.ViewModels;

namespace TemplatesetupTask.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            ServiceViewModel smv= new ServiceViewModel();

              smv.ServiceList = Data.Services;

            return View(smv);
        }

        public IActionResult Detail(int id)
        {
            Service result= Data.Services.Find(x => x.Id == id);    

            return View(result);

        }
    }
}
