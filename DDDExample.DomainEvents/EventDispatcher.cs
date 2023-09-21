using System.Reflection;

namespace DDDExample.DomainEvents.Frameworks
{
    public class EventDispatcher : IEventDispatcher
    {
        public void Dispatche<T>(params T[] events) where T : IDomainEvent
        {
            var _handlers = AppDomain.CurrentDomain.GetAssemblies().SelectMany(p =>
            p.GetTypes().Where(x => x.GetInterfaces().Any(y => y.IsGenericType &&
            y.GetGenericTypeDefinition() == typeof(IEventHandler<>))));

            foreach (var @event in events)
            {
                if (events == null)
                    throw new ArgumentNullException(nameof(@event), "Event can not be null");

                foreach (var handler in _handlers)
                {
                    bool canHandleEvent = handler.GetInterfaces()
                        .Any(x => x.IsGenericType
                        && x.GetGenericTypeDefinition() == typeof(IEventHandler<>)
                        && x.GenericTypeArguments[0] == @event.GetType());

                    if (canHandleEvent)
                    {
                        var instance = Activator.CreateInstance(handler);

                        var method = instance.GetType().GetRuntimeMethods().First(x => x.Name.Equals("Handle"));
                        object[] parametersArray = new object[] { @event };
                        method.Invoke(instance, parametersArray);
                    }
                }
            }
        }

    }
}
