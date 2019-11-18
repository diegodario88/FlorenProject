using System.Collections.Generic;
using System.Threading.Tasks;
using Floren.Domain.Entities;

namespace Floren.Domain.Contracts.Repositories
{
    public interface IPlantaoRepository : IRepository<Plantao>
    {
        Task<IEnumerable<Plantao>> GetByName(string name);

    }
}