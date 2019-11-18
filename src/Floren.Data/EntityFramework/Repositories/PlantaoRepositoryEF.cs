using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Floren.Domain.Contracts.Repositories;
using Floren.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Floren.Data.EntityFramework.Repositories
{
    public class PlantaoRepositoryEF : RepositoryEF<Plantao>, IPlantaoRepository
    {
        public PlantaoRepositoryEF(FlorenDataContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Plantao>> GetByName(string name)
        {
            return await _db.Where(p => p.Nome.Contains(name)).ToListAsync();
        }
    }
}