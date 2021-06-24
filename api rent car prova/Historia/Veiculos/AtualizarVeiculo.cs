using api_rent_car_prova.Entidades;
using api_rent_car_prova.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_rent_car_prova.Historia.Veiculos
{
    public class AtualizarVeiculo
    {
        private readonly IVeiculoRepository _veiculoRepository;

        public AtualizarVeiculo(IVeiculoRepository veiculoRepository)
        {
            _veiculoRepository = veiculoRepository;
        }

        public async Task Executar(int id, Veiculo veiculo)
        {
            var dadosDoVeiculo = await _veiculoRepository.BuscarPorId(id);

            dadosDoVeiculo.AtualizarDados(veiculo.Marca, veiculo.Modelo);

            await _veiculoRepository.Atualizar(dadosDoVeiculo);
        }

    }
}
