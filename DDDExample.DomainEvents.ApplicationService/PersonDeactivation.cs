using DDDExample.DomainEvents.CoreDomain;
using DDDExample.DomainEvents.Frameworks;

namespace DDDExample.DomainEvents.ApplicationService
{
    public class PersonDeactivation
    {
        private readonly PersonRepository personRepository;
        private readonly IEventDispatcher _eventDispatcher;

        public PersonDeactivation(PersonRepository personRepository, IEventDispatcher eventDispatcher)
        {
            this.personRepository = personRepository;
            _eventDispatcher = eventDispatcher;
        }

        public void Execute(int personId)
        {
            var person = personRepository.Get(personId);
            person.Deactivate();
            _eventDispatcher.Dispatche(person.Events.ToArray());

            // Send Email
            // Send SMS
        }


    }
}