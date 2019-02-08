 using EFGetStarted.AspNetCore.NewDb.Models;
 using System.Collections.Generic;


namespace EFGetStarted.AspNetCore.NewDb.Services
{
    public interface IFactoryData
    {

        IEnumerable<Factory> GetAll();
    }
}