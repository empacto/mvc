using  Microsoft.AspNetCore.Mvc;
namespace EFGetStarted.AspNetCore.NewDb.Controllers
{
      [Route("company/[controller]/[action]")]
    public class AboutController
    {
     
        public string Phone()
        {
            return "+55 81981888164";
        }

         public string Country()
        {
            return "Belgium";
        }
    }
}