using System.Collections.Generic;
using System.Threading.Tasks;
using Floren.Services.Exceptions;
using Floren.Domain.Contracts.Repositories;
using Floren.Domain.DTO;
using Floren.Domain.Entities;
using System;

namespace Floren.Services
{
    public class PlantaoService : IPlantaoService
    {
        private readonly IFarmaciaRepository _farmaciaRepository;
        private readonly IPlantaoRepository _plantaoRepository;

        public PlantaoService(IFarmaciaRepository farmaciaRepository, IPlantaoRepository plantaoRepository)
        {
            _farmaciaRepository = farmaciaRepository;
            _plantaoRepository = plantaoRepository;
        }

        //Converte Plantão em PlantãoDTO
        public async Task<PlantaoDTO> ToPlantaoDTO(Plantao plantao)
        {

            var farmacia = await _farmaciaRepository.GetAllAsync();
            PlantaoDTO plantaoDTO = new PlantaoDTO();
            try
            {
                Farmacia farmaciaPrincipal = await _farmaciaRepository.GetByIdAsync(plantao.FarmaciaPrincipal);
                Farmacia farmaciaSecundaria = await _farmaciaRepository.GetByIdAsync(plantao.FarmaciaSecundaria);

                FarmaciaDTO farmaciaDTOPrincipal = new FarmaciaDTO()
                {
                    Nome = farmaciaPrincipal.Nome,
                    Endereco = farmaciaPrincipal.Endereco,
                    Telefone = farmaciaPrincipal.Telefone
                };

                FarmaciaDTO farmaciaDTOSecundaria = new FarmaciaDTO()
                {
                    Nome = farmaciaSecundaria.Nome,
                    Endereco = farmaciaSecundaria.Endereco,
                    Telefone = farmaciaSecundaria.Telefone
                };

                plantaoDTO.Grupo = plantao.Nome;
                plantaoDTO.Principal = farmaciaDTOPrincipal;
                plantaoDTO.Secundaria = farmaciaDTOSecundaria;


            }
            catch (DbConcurrencyException e)
            {

                throw new DbConcurrencyException(e.Message);
            }

            return plantaoDTO;

        }


        //Retorna todos os Plantoes
        public async Task<IEnumerable<Plantao>> GetAll() => await _plantaoRepository.GetAllAsync();


        //Retorna o plantão pelo ID
        public async Task<PlantaoDTO> GetByIdAsync(int? id)
        {
            var plantao = await _plantaoRepository.GetByIdAsync(id);
            return await ToPlantaoDTO(plantao);
        }

        //Verifica se é dia de semana
        public void CheckPlantao(DateTime escala)
        {
            int numeroSemana = (int)escala.DayOfWeek;

            if (numeroSemana >= 1 && numeroSemana <= 5)
            {
                plantalSemanal();
            }
            else if (numeroSemana == 6)
            {
                plantaoSabado();
            }
            else
            {
                plantaoDomingo();
            }

        }

        private void plantaoDomingo()
        {
            throw new NotImplementedException();
        }

        private void plantaoSabado()
        {
            throw new NotImplementedException();
        }

        public Plantao plantalSemanal()
        {

            throw new NotImplementedException();
        }
    }
}