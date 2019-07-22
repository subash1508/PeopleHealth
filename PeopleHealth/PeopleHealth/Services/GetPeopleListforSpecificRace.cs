using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PeopleHealth.Models;
using PeopleHealth.Repo;
using PeopleHealth.Services.HeightFactory;
using PeopleHealth.Services.Interface;

namespace PeopleHealth.Services
{
    public class GetPeopleListforSpecificRaceService 
    {
        private IGeneratePeopleList getPeopleList;
        public GetPeopleListforSpecificRaceService()
        {
            getPeopleList = new GeneratePeopleListService() ;
        }
        public List<Person> GetPeopleListforRace(Race.RaceEnum race)
        {
            var personList = new List<Person>();
            foreach (var person in GetPeopleListforRaceFromPeople(race))
            {
                personList.Add(new Person()
                {
                    Age = person.Age+1,
                    Race = person.Race,
                    Height = person.Height,
                    Name = person.Name
                });
            }

            return personList.Where(i => i.Age % 2 == 0).OrderBy(j => j.Age).ToList();


        }

        private List<Person> GetPeopleListforRaceFromPeople(Race.RaceEnum race)
        {
            var peopleList = getPeopleList.GeneratePeopleList();
            return peopleList.FindAll(i => i.Race == race).ToList();
        }
    }
}