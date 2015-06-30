namespace RNM.SharedKernel
{
    public interface IAuditLogger
    {
        void CreateLog(string type, string description);
    }
}
