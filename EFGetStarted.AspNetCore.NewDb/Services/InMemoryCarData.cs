using EFGetStarted.AspNetCore.NewDb.Models;
using System.Collections.Generic;
namespace EFGetStarted.AspNetCore.NewDb.Services
{
    public class InMemoryCarData:ICar
    {
        public InMemoryCarData()
        {
            _car = new List<Car>();
            _car.Add(new Car(1,"porche"));
            _car.Add(new Car(2,"porche2"));
            _car.Add(new Car(3,"porche3"));
            _car.Add(new Car(4,"porche4"));   

            // _car = new List<Car>
            // {
            //     new Car{Id=1,Brand = "Porche1"},
            //     new Car{Id=2,Brand = "Porche1"},
            //     new Car{Id=3,Brand = "Porche1"}

            // };  

           
        }

       
            

        public IEnumerable<Car> GetAll()
        {
            return _car;
        }


        List<Car> _car;
        
        
    }
}