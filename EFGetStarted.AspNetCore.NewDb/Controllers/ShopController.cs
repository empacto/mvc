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
    public class ShopController:Controller
    {

        private IShop _shop;

        public ShopController(IShop shop)
        {
            _shop = shop;

        }

        public ViewResult Index()
        {
            var model = _shop.GetAll();
            return View(model);
        }


        
    }
}