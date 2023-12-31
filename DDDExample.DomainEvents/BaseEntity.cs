﻿namespace DDDExample.DomainEvents.Frameworks
{
    public class BaseEntity
    {
        private readonly List<IDomainEvent> _events = new List<IDomainEvent>();

        public IEnumerable<IDomainEvent> Events
        {
            get
            {
                return _events;
            }
        }

        protected void AddEvent(IDomainEvent @event)
        {
            _events.Add(@event);
        }

        protected void ClearEvents()
        {
            _events.Clear();
        }

    }
}
