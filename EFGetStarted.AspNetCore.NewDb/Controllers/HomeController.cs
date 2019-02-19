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

        public IActionResult Details(int id)
        {
              var model = _restaurantData.Get(id);
             if(model == null)
             {
              return RedirectToAction("Index");
             

             }
             
                return View(model);                
             

        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpGet]
         public IActionResult Edit(int id)
        {
            var model = _restaurantData.Get(id);
            if(model==null)
            {
                return RedirectToAction("Index");
            }

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(int id,RestaurantEditViewModel input)
        {
                var restaurant = _restaurantData.Get(id);
                return View(restaurant);
                
        }

        [HttpPost]
        public IActionResult Create(RestaurantEditViewModel model)
        {
            var restaurant = new Restaurant();
            restaurant.Name = model.Name;
            restaurant.Cuisine = model.Cuisine;
            _restaurantData.Add(restaurant);         
            return RedirectToAction("Details",new {id = restaurant.Id});
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
