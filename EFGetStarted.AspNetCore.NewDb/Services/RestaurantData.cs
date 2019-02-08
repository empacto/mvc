using System.Collections.Generic;
using EFGetStarted.AspNetCore.NewDb.Models;


namespace EFGetStarted.AspNetCore.NewDb.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        
        public InMemoryRestaurantData()
        {

            _restaurants = new List<Restaurant>
            {
                new Restaurant{Id = 1, Name = "geert"},
                new Restaurant{Id = 2, Name = "patrizia"},
                new Restaurant{Id = 3, Name = "gael"},
                new Restaurant{Id = 4, Name = "max"},
                new Restaurant{Id = 5, Name = "olivier"},
            };
          
        }

        public IEnumerable<Restaurant>GetAll()
        {
            return _restaurants;
        }

        List<Restaurant> _restaurants;


    }
}