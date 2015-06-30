using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Group1.Framework.Messaging.Interfaces.Commands
{
    public interface ICommandBus
    {
        void Submit<TCommand>(TCommand command) where TCommand : ICommand;
        IEnumerable<ValidationResult> Validate<TCommand>(TCommand command) where TCommand : ICommand;
    }
}
