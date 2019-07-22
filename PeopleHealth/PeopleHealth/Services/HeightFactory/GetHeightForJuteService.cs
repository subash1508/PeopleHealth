using PeopleHealth.Services.HeightFactory.Interface;

namespace PeopleHealth.Services.HeightFactory
{
    public class GetHeightForJuteService: IGetHeightInterface
    {
        public double CalculateHeight(int age)
        {
            return ((age * 1.6) / 2);
        }
    }
}