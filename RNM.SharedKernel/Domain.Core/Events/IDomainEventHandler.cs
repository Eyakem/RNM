namespace RNM.SharedKernel.Domain.Core.Events
{
    public interface IDomainEventHandler<T> where T : IDomainEvent
    {
        void Handle(T domainEvent);
    }

    public interface IDomainEvent
    {

    }
}
