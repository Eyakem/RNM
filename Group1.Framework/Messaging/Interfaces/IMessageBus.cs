
namespace Group1.Framework.Messaging.Interfaces
{
    public interface IMessageBus
    {
        void Send<TMessage>(TMessage command) where TMessage : IMessage;
    }
}
