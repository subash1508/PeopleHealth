using PeopleHealth.Models;
using PeopleHealth.Services.HeightFactory.Interface;

namespace PeopleHealth.Services.HeightFactory
{
    public abstract class GetHeightService
    {

        public abstract IGetHeightInterface GetHeightFactory(Race.RaceEnum personRace);
    }
}