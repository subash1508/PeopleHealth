using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeopleHealth.Models
{
    public class Race
    {
        public enum RaceEnum
        {
            Angles = 0,
            Hawaiian = 1,
            Jute = 2,
            Saxon = 3
        }

        public static explicit operator Race(string v)
        {
            throw new NotImplementedException();
        }
    }
}