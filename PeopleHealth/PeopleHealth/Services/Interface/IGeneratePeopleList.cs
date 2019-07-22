using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PeopleHealth.Models;

namespace PeopleHealth.Services.Interface
{
    interface IGeneratePeopleList
    {
        List<Person> GeneratePeopleList();
    }
}
