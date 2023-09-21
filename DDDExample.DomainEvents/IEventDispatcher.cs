namespace DDDExample.DomainEvents.Frameworks
{
    public interface IEventDispatcher
    {
        void Dispatche<T>(params T[] events) where T : IDomainEvent;
    }
}
