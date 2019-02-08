using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EFGetStarted.AspNetCore.NewDb.Models;
using EFGetStarted.AspNetCore.NewDb.Services;

namespace EFGetStarted.AspNetCore.NewDb.Controllers
{
  
    public class CarController:Controller
    {
      private ICar _carData;

      public CarController(ICar carData)
      {
          _carData =carData;

      }

     
      public ViewResult Index()
      {
          var model = _carData.GetAll();
          return View(model);
      }


    }
}