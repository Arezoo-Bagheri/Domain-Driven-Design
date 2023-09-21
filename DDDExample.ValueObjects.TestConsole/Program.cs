using DDDExample.ValueObjects.Moneyv1;

namespace DDDExample.ValueObjects.TestConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            Money money1 = new Money(1000);
            Money money2 = new Money(1000);

            if (money1 == money2)
            {
                Console.WriteLine("Are Equal...");

            }
            else
            {
                Console.WriteLine("Are Not Equal...");
            }

            Console.ReadLine();
        }


    }
}
