using System.Collections.Generic;
using System.Threading.Tasks;
using Floren.Domain.DTO;
using Floren.Domain.Entities;

namespace Floren.Services
{
    public interface IPlantaoService
    {
        Task<IEnumerable<Plantao>> GetAll();
        Task<PlantaoDTO> ToPlantaoDTO(Plantao plantao);
        Task<PlantaoDTO> GetByIdAsync(int? id);

    }
}