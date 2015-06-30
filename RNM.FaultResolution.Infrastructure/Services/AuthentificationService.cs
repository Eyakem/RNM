using RNM.FaultResolution.Domain.Services;

namespace RNM.FaultResolution.Infrastructure.Services
{
    public class AuthentificationService:IAuthenticateUserService
    {
        public bool IsSupervisor(string roleName)
        {
            return true;
        }
    }
}
