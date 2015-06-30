using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Group1.Framework.Messaging.Interfaces.Commands
{
    public interface IValidationHandler<in TCommand> where TCommand : ICommand
    {
        IEnumerable<ValidationResult> Validate(TCommand command);
    }
}
