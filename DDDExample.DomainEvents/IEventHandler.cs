namespace DDDExample.DomainEvents.Frameworks
{
    public interface IEventHandler<in T> where T : IDomainEvent
    {
        void Handler(T @event);
    }
}
