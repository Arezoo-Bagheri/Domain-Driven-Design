using DDDExample.DomainEvents.ApplicationService;
using DDDExample.DomainEvents.CoreDomain;
using DDDExample.DomainEvents.Frameworks;

namespace DDDExample.DomainEvents.EndPoint
{
    public class Program
    {
        static void Main(string[] args)
        {
            var personRepository = new FakePersonRepository();
            foreach (var item in personRepository.GetAll())
            {
                Console.WriteLine($"FirstName:{item.FirstName} LastName:{item.LastName} IsActive:{item.IsActive}");
            }
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine();

            PersonDeactivation personDeactivation = new PersonDeactivation(personRepository, new EventDispatcher());
            personDeactivation.Execute(1);

            foreach (var item in personRepository.GetAll())
            {
                Console.WriteLine($"FirstName:{item.FirstName} LastName:{item.LastName} IsActive:{item.IsActive}");
            }
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine();
            Console.ReadLine();
        }


    }
}
