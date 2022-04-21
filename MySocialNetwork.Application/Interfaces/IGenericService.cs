namespace MySocialNetwork.Application.Interfaces
{
    public interface IGenericService<Entity>
    {
        Entity? GetById(int id);
        List<Entity>? GetAll();
        void Create(Entity? entity);
        void Update(Entity? entity);
        void Remove(Entity? entity);
    }
}
