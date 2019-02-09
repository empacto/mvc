using System.Collections.Generic;
using EFGetStarted.AspNetCore.NewDb.Entities;

namespace EFGetStarted.AspNetCore.NewDb.ViewModels
{
    public class HomePageViewModel
    {
        public IEnumerable<Restaurant> Restaurants { get; set; }      
        public string CurrentGreeting { get; set; }  
    }
}