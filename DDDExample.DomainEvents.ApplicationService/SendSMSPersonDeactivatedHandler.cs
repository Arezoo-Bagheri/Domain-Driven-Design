using DDDExample.DomainEvents.CoreDomain;
using DDDExample.DomainEvents.Frameworks;

namespace DDDExample.DomainEvents.ApplicationService
{
    public class SendSMSPersonDeactivatedHandler : IEventHandler<PersonDeactivated>
    {
        public void Handler(PersonDeactivated @event)
        {
            Console.WriteLine("SMS For Send");
            Console.WriteLine($"Dear personId : {@event.Id}");
            Console.WriteLine("You Are Deactivated");
            Console.WriteLine("----------------- End of SMS -----------------------");
        }
    }
}
