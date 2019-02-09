using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EFGetStarted.AspNetCore.NewDb.Services;
using EFGetStarted.AspNetCore.NewDb.ViewModels;
using EFGetStarted.AspNetCore.NewDb.Entities;

namespace EFGetStarted.AspNetCore.NewDb.Controllers
{
    public class HomeController : Controller
    {
        private IRestaurantData _restaurantData;
        
        

        public HomeController(IRestaurantData ir)
        {
            _restaurantData = ir;           
            
        }

        public ViewResult Index()
        {
           var model =  new HomePageViewModel();
           model.Restaurants = _restaurantData.GetAll();
           model.CurrentGreeting = "this is a GREETING";
            return View(model);

           
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        // public IActionResult Error()
        // {
        //     return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        // }
    }
}
