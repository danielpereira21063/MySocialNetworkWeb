namespace MySocialNetwork.Domain.Interfaces.Abstractions
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
        Task RoolBack();
    }
}
