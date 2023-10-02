namespace DDDExample.EventSourcing
{
    public abstract class BaseEntity
    {
        private readonly List<IEvent> _events = new List<IEvent>();

        public IEnumerable<IEvent> Events
        {
            get
            {
                return _events;
            }
        }

        public void Add(IEvent @event)
        {
            _events.Add(@event);
        }

    }
}