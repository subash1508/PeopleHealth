using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeopleHealth.Models
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Race.RaceEnum Race { get; set; }
        public double Height { get; set; }

        public override string ToString()
        {
            return "My name is '" + Name + "' and I am " + Age + " years old.";
        }
    }
}