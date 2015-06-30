using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group1.Framework.Messaging.Interfaces.Events
{
    public interface IEventBus
    {
        void Send<TEvent>(TEvent @event) where TEvent : IDomainEvent;
    }
}
