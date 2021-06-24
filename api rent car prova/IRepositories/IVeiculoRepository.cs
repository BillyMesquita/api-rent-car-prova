using api_rent_car_prova.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_rent_car_prova.IRepositories
{
    public interface IVeiculoRepository
    {
        Task Incluir(Veiculo veiculo);

        Task Atualizar(Veiculo veiculo);

        Task Excluir(int id);

        Task<Veiculo> BuscarPorId(int id);

        Task<Veiculo> BuscarPorMarca(string marca, string modelo);

        Task<IEnumerable<Veiculo>> ListarTodosVeiculos();
    }
}
