using EFGetStarted.AspNetCore.NewDb.Data;
using EFGetStarted.AspNetCore.NewDb.Entities;
using System.Collections.Generic;
using System.Linq;
using System;

namespace EFGetStarted.AspNetCore.NewDb.Services
{
    public class SQLRestaurantData : IRestaurantData
    {
        private OdeToFoodDBContext _context;
        public SQLRestaurantData(OdeToFoodDBContext context)
        {

            _context = context;
        }


        public void Add(Restaurant newRestaurant)
        {
           
            _context.Add(newRestaurant);
            _context.SaveChanges();

        }

        public Restaurant Get(int id)
        {
            return _context.Restaurants.FirstOrDefault(r => r.Id == id);
               
        }

        public IEnumerable<Restaurant> GetAll()
        {
                return _context.Restaurants.ToList();
        }


        
    }
}