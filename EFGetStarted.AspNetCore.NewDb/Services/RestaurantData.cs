using System.Collections.Generic;
using EFGetStarted.AspNetCore.NewDb.Entities;
using System.Linq;


namespace EFGetStarted.AspNetCore.NewDb.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        
        static InMemoryRestaurantData()
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

        public Restaurant Get(int id)
        {
            return _restaurants.FirstOrDefault(r => r.Id == id);

        }

        public void Add(Restaurant newRestaurant)
        {
            //use linqquery get maximumid. using System;
            
           newRestaurant.Id = _restaurants.Max(r => r.Id) + 1 ; // find the max id increment
           _restaurants.Add(newRestaurant); // save newRestaurant id + received data into collection 


        }

       static List<Restaurant> _restaurants;


    }
}