using System.Threading.Tasks;
using Floren.Services;
using Microsoft.AspNetCore.Mvc;

namespace Floren.Api.Controllers
{
    [Route("api/v1/[controller]")]
    public class PlantoesController : ControllerBase
    {
        private readonly IPlantaoService _plantaoService;

        public PlantoesController(IPlantaoService plantaoService)
        {
            _plantaoService = plantaoService;
        }

        //Retorna todos os plantões 
        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _plantaoService.GetAll());


        //Retorna um PlantaoDTO(Formatado)
        [Route("{id:int}")]
        public async Task<IActionResult> GetByID(int? id)
        {
            if (id != null)
            {
                var plantao = await _plantaoService.GetByIdAsync(id);

                if (plantao == null)
                {
                    return NotFound();
                }

                return Ok(plantao);
            }
            return NotFound();
        }

    }
}