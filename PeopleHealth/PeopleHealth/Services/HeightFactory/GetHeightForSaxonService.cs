using PeopleHealth.Services.HeightFactory.Interface;

namespace PeopleHealth.Services.HeightFactory
{
    public class GetHeightForSaxonService:IGetHeightInterface
    {
        public double CalculateHeight(int age)
        {
            return (1.5 + (age * 0.45));
        }
    }
}