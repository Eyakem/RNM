namespace RNM.FaultResolution.Domain.Services
{
    public interface IAuthenticateUserService
    {
        bool IsSupervisor(string roleName);
    }
}
