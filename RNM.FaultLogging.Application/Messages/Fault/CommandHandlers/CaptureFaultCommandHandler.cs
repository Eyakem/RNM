using Group1.Framework.Messaging.Interfaces.Commands;
using RNM.FaultLogging.Application.Messages.Fault.Commands;


namespace RNM.FaultLogging.Application.Messages.Fault.CommandHandlers
{
    public class CaptureFaultCommandHandler :ICommandHandler<CaptureFault>
    {
        //inject fault repository
        public CaptureFaultCommandHandler()
        {
            
        }

        public void Execute(CaptureFault command)
        {
            throw new System.NotImplementedException();
        }
    }
}
