using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TemplatesetupTask.DataAccess;
using TemplatesetupTask.Models;
using TemplatesetupTask.ViewModels;

namespace TemplatesetupTask.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            HomeViewModel homeViewModel = new HomeViewModel();
            homeViewModel.features = Data.Features;

            return View(homeViewModel);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }


    }
}
