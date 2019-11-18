using System.Collections.Generic;
using System.Threading.Tasks;
using Floren.Domain.Entities;

namespace Floren.Domain.Contracts.Repositories
{
    public interface IFarmaciaRepository : IRepository<Farmacia>
    {
        Task<IEnumerable<Farmacia>> GetByName(string name);
    }
}