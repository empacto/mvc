using System.Collections.Generic;
using EFGetStarted.AspNetCore.NewDb.Entities;

namespace EFGetStarted.AspNetCore.NewDb.ViewModels
{
    public class RestaurantEditViewModel
    {
        public string Name { get; set; }
        public CuisineType Cuisine { get; set; }
        
    }
}