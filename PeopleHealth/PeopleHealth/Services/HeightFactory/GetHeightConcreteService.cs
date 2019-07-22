using System;
using PeopleHealth.Models;
using PeopleHealth.Services.HeightFactory.Interface;

namespace PeopleHealth.Services.HeightFactory
{
    public class GetHeightConcreteService : GetHeightService
    {
        public override IGetHeightInterface GetHeightFactory(Race.RaceEnum personRace)
        {
            switch (personRace)
            {
                case Race.RaceEnum.Angles: return new GetHeightForAnglesService();
                case Race.RaceEnum.Hawaiian: return new GetHeightForHawaiianService();
                case Race.RaceEnum.Jute: return new GetHeightForJuteService();
                case Race.RaceEnum.Saxon: return new GetHeightForSaxonService();
                default:
                    throw new Exception();
            }

        }
    }
}