using Group1.Framework.Messaging.Interfaces.Commands;


namespace RNM.FaultLogging.Application.Messages.Fault.Commands
{
    public class CaptureFault:ICommand
    {
        public int TypeId { get; set; }
        public string Description { get; set; }
    }
}
