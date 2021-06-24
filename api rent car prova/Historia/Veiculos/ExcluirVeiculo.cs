using api_rent_car_prova.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_rent_car_prova.Historia.Veiculos
{
    public class ExcluirVeiculo
    {
        private readonly IVeiculoRepository _veiculoRepository;

        public ExcluirVeiculo(IVeiculoRepository veiculoRepository)
        {
            _veiculoRepository = veiculoRepository;
        }

        public async Task Executar(int id)
        {
            await _veiculoRepository.Excluir(id);
        }
    }
}
