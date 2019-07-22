using PeopleHealth.Services.HeightFactory.Interface;

namespace PeopleHealth.Services.HeightFactory
{
    public class GetHeightForHawaiianService : IGetHeightInterface
    {
        public double CalculateHeight(int age)
        {
            return (1.7 + ((age + 2) * 0.23));
        }
    }
}