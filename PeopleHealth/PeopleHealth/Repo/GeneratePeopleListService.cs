using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PeopleHealth.Models;
using PeopleHealth.Services.HeightFactory;
using PeopleHealth.Services.Interface;

namespace PeopleHealth.Repo
{
    public class GeneratePeopleListService : IGeneratePeopleList
    {
        public List<Person> GeneratePeopleList()
        {
            GetHeightService heightServiceFactory = new GetHeightConcreteService();

            List<Person> people = new List<Person>();
            Random rnd = new Random();
            for (int i = 0; i < 10000; i++)
            {
                var race = (Race.RaceEnum)(i % 4);
                var getHeight = heightServiceFactory.GetHeightFactory(race);
                var age = rnd.Next(1, 99);
                people.Add(new Person()
                {
                    Name = "Person #" + i.ToString(),
                    Age = age,
                    Race = race,
                    Height = getHeight.CalculateHeight(age)
                });
            }
            return people;
        }
    }
}