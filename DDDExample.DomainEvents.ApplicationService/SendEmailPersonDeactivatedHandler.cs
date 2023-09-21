using DDDExample.DomainEvents.CoreDomain;
using DDDExample.DomainEvents.Frameworks;

namespace DDDExample.DomainEvents.ApplicationService
{
    public class SendEmailPersonDeactivatedHandler : IEventHandler<PersonDeactivated>
    {
        public void Handler(PersonDeactivated @event)
        {
            Console.WriteLine("Email For Send");
            Console.WriteLine($"Dear personId : {@event.Id}");
            Console.WriteLine("You Are Deactivated");
            Console.WriteLine("----------------- End of Email -----------------------");
        }
    }
}
