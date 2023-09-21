namespace DDDExample.DomainServices
{

    public interface IGetWeather
    {
        int Get(Person person);
    }

    public class GetTehranWeather : IGetWeather
    {
        public int Get(Person person)
        {
            // Use Person

            return 10;
        }
    }


    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int GetWeather(IGetWeather getWeather)
        {
            return getWeather.Get(this);
        }


    }
}