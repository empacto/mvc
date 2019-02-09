using EFGetStarted.AspNetCore.NewDb.Entities;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.NewDb.Services
{
    public interface IRestaurantData
    {

        IEnumerable<Restaurant> GetAll();
         
    }
}