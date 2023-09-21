namespace DDDExample.DomainEvents.CoreDomain
{
    public class FakePersonRepository : PersonRepository
    {
        private static List<Person> person = new List<Person>
        {
            new Person
            {
                Id = 1,
                FirstName ="Rahim",
                LastName="Lotfi",
                Email ="Rahim@gmail.com",
                Mobile = "09199906342",
                IsActive = true
            },
                  new Person
            {
                Id = 2,
                FirstName ="Arezoo",
                LastName="Bagheri",
                Email ="Arezoo@gmail.com",
                Mobile = "09028749792",
                IsActive = true
            }
        };

        public Person Get(int id)
        {
            return person.FirstOrDefault(p => p.Id == id);

        }

        public List<Person> GetAll()
        {
         return person;
        }

    }
}