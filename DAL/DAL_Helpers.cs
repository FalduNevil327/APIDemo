using Microsoft.AspNetCore.Mvc;

namespace APIDemo.DAL
{
    public class DAL_Helpers : Controller
    {

        public static String ConnString = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetConnectionString("MyConnectionString");

        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
