using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using PeopleHealth.Models;

namespace PeopleHealth.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

      
        //HTTP Post: to navigate from Home page to PeopleListPage
        // POST: Home/Create
        [HttpPost]
        public ActionResult GetRace(string race)
        {
            try
            {
                Race.RaceEnum raceEnumValue = Race.RaceEnum.Angles;
                if (Enum.IsDefined(typeof(Race.RaceEnum), race))
                    raceEnumValue = (Race.RaceEnum) Enum.Parse(typeof(Race.RaceEnum), race, true);
                return RedirectToAction("ListPeople", "GetPeopleList", new {@race = raceEnumValue});
            }
            catch
            {
                return View();
            }
        }

       
    }
}
