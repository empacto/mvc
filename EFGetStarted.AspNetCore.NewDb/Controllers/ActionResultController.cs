using Microsoft.AspNetCore.Mvc;
using EFGetStarted.AspNetCore.NewDb.Models;

namespace EFGetStarted.AspNetCore.NewDb.Controllers
{
    public class ActionResultController:Controller
    {
        public IActionResult Index()
        {
            // TODO: Your code here
            return View("this is a result a simple string");
        }


        //http://localhost:56318/ActionResult/restaurant
        public ObjectResult Restaurant()
        {
            var model = new Restaurant{Id=1,Name="de lork"};

            return new ObjectResult(model);
        }
        
    }
}

