using api_rent_car_prova.Entidades;
using api_rent_car_prova.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_rent_car_prova.Historia.Veiculos
{
    public class IncluirVeiculo
    {
        private readonly IVeiculoRepository _veiculoRepository;

        public IncluirVeiculo(IVeiculoRepository veiculoRepository)
        {
            _veiculoRepository = veiculoRepository;
        }

        public async Task Executar(Veiculo veiculo)
        {
            await _veiculoRepository.Incluir(veiculo);
        }
    }
}
