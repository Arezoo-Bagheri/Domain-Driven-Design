using DDDExample.Entities.Validations;

namespace DDDExample.Entities.TestConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            FlightBooking flightBooking = new FlightBooking
                                  (Guid.NewGuid(), DateTime.Now.AddDays(1), Guid.NewGuid());

            flightBooking.Reschedule(DateTime.Now.AddDays(3));
            Console.WriteLine("Done");
            Console.ReadLine();

            flightBooking.Confirm();
            flightBooking.Reschedule(DateTime.Now.AddDays(3));
            Console.WriteLine("Done");
            Console.ReadLine();
        }

    }
}
