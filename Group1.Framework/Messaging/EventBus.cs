
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

using Group1.Framework.Messaging.Interfaces.Events;

namespace Group1.Framework.Messaging
{
    public class EventBus:IEventBus
    {
        // ToDo use factory pattern
        readonly HashSet<IDomainEvent> submittedEvents = new HashSet<IDomainEvent>();

        public void Send<TEvent>(TEvent @event) where TEvent : IDomainEvent
        {
            if (submittedEvents.Contains(@event))
                return;

            submittedEvents.Add(@event);

            Type type = GetHandlerType(@event);

            List<object> handlers = DependencyResolver.Current.GetServices(type).ToList();

            if (handlers.Any())
            {
                foreach (var eventHandler in handlers)
                {
                    ((dynamic)eventHandler).Handle((dynamic)@event);
                }
            }
            else
            {
                throw new InvalidOperationException(String.Format("An Event handler for {0} could not  be located", type.FullName));
            }
        }

        private static Type GetHandlerType<TEvent>(TEvent @event) where TEvent : IDomainEvent
        {
            Type eventType = @event.GetType();
            Type handlerGenericType = typeof(IEventHandler<>);
            Type handlerType = handlerGenericType.MakeGenericType(eventType);
            return handlerType;
        }
    }
}
