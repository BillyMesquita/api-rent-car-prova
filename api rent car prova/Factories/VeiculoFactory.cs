using api_rent_car_prova.Entidades;
using api_rent_car_prova.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_rent_car_prova.Factories
{
    public class VeiculoFactory
    {
        public static Veiculo MapearVeiculo(VeiculoViewModel veiculoViewModel)
        {
            return new Veiculo(veiculoViewModel.Marca, veiculoViewModel.Modelo);
        }

        public static VeiculoViewModel MapearVeiculoViewModel(Veiculo veiculo)
        {
            return new VeiculoViewModel() { Id = veiculo.Id, Marca = veiculo.Marca, Modelo = veiculo.Modelo };
        }

        public static IEnumerable<VeiculoViewModel> MapearListaVeiculoViewModel(IEnumerable<Veiculo> lista)
        {
            var listaVeiculoViewModel = new List<VeiculoViewModel>();
            VeiculoViewModel veiculoVm;

            foreach (var item in lista)
            {
                veiculoVm = new VeiculoViewModel { 
                    Id = item.Id,
                    Marca = item.Marca,
                    Modelo = item.Modelo
                };

                listaVeiculoViewModel.Add(veiculoVm);
            }

            return listaVeiculoViewModel;
        }
    }
}
