using System.Collections.Generic;
using EFGetStarted.AspNetCore.NewDb.Models;

namespace EFGetStarted.AspNetCore.NewDb.Services
{
    public class InMemoryFactoryData:IFactoryData
    {
        public InMemoryFactoryData()
        {
            _factories = new List<Factory>
            {
                new Factory{Id=1,Name="vermeiren 1"},
                new Factory{Id=2,Name="vermeiren 2"},
                new Factory{Id=3,Name="vermeiren 3"},
                new Factory{Id=4,Name="vermeiren 4"},
                
                
            };
            
        }

        public IEnumerable<Factory>GetAll()
        {
            return _factories;

        }


        List<Factory> _factories;
    }
}