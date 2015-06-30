namespace Group1.Framework.Persistence
{
    public interface IUnitOfWork
    {
        void Commit();
        void Rollback();
    }
}
