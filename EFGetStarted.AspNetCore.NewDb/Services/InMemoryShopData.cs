using System.Collections.Generic;
using EFGetStarted.AspNetCore.NewDb.Models;

namespace EFGetStarted.AspNetCore.NewDb.Services
{
    public class InMemoryShopData:IShop
    {

        public InMemoryShopData()
        {
             _shop = new List<Shop>();
             _shop.Add( new Shop(1,"ava 1"));
             _shop.Add( new Shop(2,"ava 2"));
             _shop.Add( new Shop(3,"ava 3"));
             _shop.Add( new Shop(4,"ava 4"));
            
        }

        public IEnumerable<Shop> GetAll()
        {

            return _shop;

        }

        List<Shop> _shop;

        
    }

    
}