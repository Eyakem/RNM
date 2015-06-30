using System;
using System.Collections.Generic;
using System.Linq;

using Group1.Framework.Messaging.Interfaces.Events;

namespace RNM.FaultLogging.Domain
{
    public abstract class AggregateRoot : IEventProvider
    {
        private readonly List<IDomainEvent> unCommittedEvents;

        public Guid Id { get; protected set; }

        protected AggregateRoot()
        {
            unCommittedEvents = new List<IDomainEvent>();
        }

        public IEnumerable<IDomainEvent> GetUncommittedChanges()
        {
            return unCommittedEvents;
        }

        public void MarkChangesAsCommitted()
        {
            unCommittedEvents.Clear();
        }

    }

    public interface IEventProvider
    {
      IEnumerable<IDomainEvent> GetUncommittedChanges();
    }

}
