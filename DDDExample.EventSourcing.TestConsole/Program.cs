namespace DDDExample.EventSourcing.TestConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            PersonRepository personRepository = new PersonRepository();

            var person = personRepository.Get(1);
            var lotfi = personRepository.Get(2);

            Console.ReadLine();
        }
    }
}
