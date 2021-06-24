using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_rent_car_prova.Entidades
{
    public class Veiculo
    {
        public Veiculo(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }

        public int Id { get; private set; }
        public string Marca { get; private set; }
        public string Modelo { get; private set; }
        public int Ano { get; private set; }
        public float Quilometragem { get; private set; }
        public IEnumerable<Veiculo> Veiculos { get; private set; }

        public void AtualizarDados(string marca, string modelo)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Ano = Ano;
            this.Quilometragem = Quilometragem;
        }
    }
}
