using System.Collections.Generic;
using EFGetStarted.AspNetCore.NewDb.Models;
namespace EFGetStarted.AspNetCore.NewDb.Services
{
    public interface IShop
    {
        IEnumerable<Shop> GetAll();
         
    }
}