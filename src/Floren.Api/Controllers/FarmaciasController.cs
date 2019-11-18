using System.Threading.Tasks;
using Floren.Domain.Contracts.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Floren.Api.Controllers
{
    [Route("api/v1/[controller]")]
    public class FarmaciasController : ControllerBase
    {
        private readonly IFarmaciaRepository _farmaciaRepository;

        public FarmaciasController(IFarmaciaRepository farmaciaRepository)
        {
            _farmaciaRepository = farmaciaRepository;

        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var data = await _farmaciaRepository.GetAllAsync();
            return Ok(data);
        }

    }
}