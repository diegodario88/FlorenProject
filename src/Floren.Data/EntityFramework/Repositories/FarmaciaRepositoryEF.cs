using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Floren.Domain.Contracts.Repositories;
using Floren.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Floren.Data.EntityFramework.Repositories
{
    public class FarmaciaRepositoryEF : RepositoryEF<Farmacia>, IFarmaciaRepository
    {
        public FarmaciaRepositoryEF(FlorenDataContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Farmacia>> GetByName(string name)
        {
            return await _db.Where(f => f.Nome.Contains(name)).ToListAsync();
        }
    }
}