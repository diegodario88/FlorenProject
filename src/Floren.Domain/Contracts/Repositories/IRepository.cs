using System.Collections.Generic;
using System.Threading.Tasks;
using Floren.Domain.Entities;

namespace Floren.Domain.Contracts.Repositories
{
    public interface IRepository<TEntity> where TEntity : Entity
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);

        //Métodos assíncronos
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(object id);

    }
}