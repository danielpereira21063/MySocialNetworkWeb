using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
