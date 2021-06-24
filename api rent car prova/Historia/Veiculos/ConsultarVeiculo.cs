using api_rent_car_prova.Entidades;
using api_rent_car_prova.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_rent_car_prova.Historia.Veiculos
{
    public class ConsultarVeiculo
    {
        private readonly IVeiculoRepository _veiculoRepository;

        public ConsultarVeiculo(IVeiculoRepository veiculoRepository)
        {
            _veiculoRepository = veiculoRepository;
        }

        public async Task<Veiculo> BuscarPorId(int id)
        {
            return await _veiculoRepository.BuscarPorId(id);
        }

        public async Task<IEnumerable<Veiculo>> ListarTodosCursos()
        {
            return await _veiculoRepository.ListarTodosVeiculos();
        }
        public async Task<Veiculo> BuscarPorMarca(string marca, string modelo)
        {
            return await _veiculoRepository.BuscarPorMarca(marca, modelo);
        }
    }
}
