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

    public class FactoryController: Controller
    {

        private IFactoryData _factoryData;
        public FactoryController(IFactoryData factoryData)
        {
            _factoryData = factoryData;


        }


        public ViewResult Index()
        {
            var model = _factoryData.GetAll();

            return View(model);
        }

        
        
    }
}