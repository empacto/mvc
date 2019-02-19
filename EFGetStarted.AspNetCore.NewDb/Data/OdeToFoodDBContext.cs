using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using EFGetStarted.AspNetCore.NewDb.Entities;

namespace EFGetStarted.AspNetCore.NewDb.Data
{
    public class OdeToFoodDBContext: DbContext
    {

        public OdeToFoodDBContext(DbContextOptions<OdeToFoodDBContext> options): base(options)
        { 

        }
        public DbSet<Restaurant> Restaurants { get; set; }    
       
    }
}