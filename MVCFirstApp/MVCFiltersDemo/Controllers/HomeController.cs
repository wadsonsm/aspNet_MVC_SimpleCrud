using MVCFiltersDemo.ActionFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFiltersDemo.Controllers
{
    [MyLogActionFilter]
    public class HomeController : Controller
    {
        // GET: Home
        [OutputCache(Duration =15)]
        public string Index()
        {
            return "This is ASP.NET MVC Filters Tutorial";
        }

        //[OutputCache(Duration = 20)]
        [ActionName("CurrentTime")]
        public string GetCurrentTime()
        {
            return DateTime.Now.ToString("T");
        }

        [NonAction]
        public string TimeString()
        {
            return "Time is " + DateTime.Now.ToString();
        }
    }
}