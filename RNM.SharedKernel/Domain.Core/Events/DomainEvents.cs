using System;
using System.Collections.Generic;

namespace RNM.SharedKernel.Domain.Core.Events
{
    public static class DomainEvents
    {
        /// Marked as ThreadStatic that each thread has its own callbacks
        [ThreadStatic]
        private static List<Delegate> actions;

        /// Registers the specified callback for the given domain event.
        public static void Register<T>(Action<T> callback) where T : IDomainEvent
        {
            if (actions == null)
                actions = new List<Delegate>();

            actions.Add(callback);
        }

        /// Raises the specified domain event and calls the event handlers.
        public static void Raise<T>(T domainEvent) where T : IDomainEvent
        {
            if (actions != null)
                foreach (var action in actions)
                    if (action is Action<T>)
                        ((Action<T>)action)(domainEvent);
        }
    }
    

}
