using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PeopleHealth.Models;
using PeopleHealth.Services;
using PeopleHealth.Services.Interface;

namespace PeopleHealth.Controllers
{
    public class GetPeopleListController : Controller
    {
        // GET: GetPeopleList

        public ActionResult ListPeople(Race.RaceEnum race)
        {
            GetPeopleListforSpecificRaceService peopleListService = new GetPeopleListforSpecificRaceService();
            var peopleList = peopleListService.GetPeopleListforRace(race);
            return View(peopleList);
        }
    }
}
