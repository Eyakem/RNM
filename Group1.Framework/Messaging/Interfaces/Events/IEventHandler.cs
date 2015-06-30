
namespace Group1.Framework.Messaging.Interfaces.Events
{
    public interface IEventHandler<in TEvent> where TEvent : IDomainEvent
    {
        void Handle(TEvent @event);
    }
}
