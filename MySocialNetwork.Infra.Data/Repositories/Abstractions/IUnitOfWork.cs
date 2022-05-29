namespace MySocialNetwork.Infra.Data.Repositories.Abstractions
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
       Task RoolBack();
    }
}
