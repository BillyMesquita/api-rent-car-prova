using api_rent_car_prova.Factories;
using api_rent_car_prova.Historia.Veiculos;
using api_rent_car_prova.IRepositories;
using api_rent_car_prova.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_rent_car_prova.Controllers
{ 
        [Route("api/veiculo")]
        public class VeiculoController : ControllerBase
        {
            private readonly IncluirVeiculo _incluirVeiculo;
            private readonly ConsultarVeiculo _consultarVeiculo;
            private readonly AtualizarVeiculo _atualizarVeiculo;
            private readonly ExcluirVeiculo _excluirVeiculo;

            public VeiculoController(IVeiculoRepository veiculoRepository)
            {
                _incluirVeiculo = new IncluirVeiculo(veiculoRepository);
                _consultarVeiculo = new ConsultarVeiculo(veiculoRepository);
                _atualizarVeiculo = new AtualizarVeiculo(veiculoRepository);
                _excluirVeiculo   = new ExcluirVeiculo(veiculoRepository);
            }
        [HttpPost("incluir-veiculo")]
        public async Task<IActionResult> Criar([FromBody] VeiculoViewModel veiculoViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new { mensagem = "Campo obrigatório" });
            }

            var veiculo = VeiculoFactory.MapearVeiculo(veiculoViewModel);

            await _incluirVeiculo.Executar(veiculo);

            return Ok(new { mensagem = "Veiculo adicionado" });
        }
        [HttpPut("atualizar-veiculo")]
        public async Task<IActionResult> Alterar([FromBody] VeiculoViewModel veiculoViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new { mensagem = "Campo obrigatório" });
            }

            try
            {
                var veiculo = VeiculoFactory.MapearVeiculo(veiculoViewModel);

                await _atualizarVeiculo.Executar(veiculoViewModel.Id, veiculo);

                return Ok(new { mensagem = "Carro Alterado" });
            }
            catch (System.Exception)
            {

                return BadRequest(new { erro = "Erro ao alterar Carro" });
            }

        }
        [HttpDelete("excluir-veiculo/{id}")]
        public async Task<IActionResult> Excluir(int id)
        {
            try
            {
                await _excluirVeiculo.Executar(id);
                return Ok(new { mensagem = "Veiculo excluido" });
            }
            catch (System.Exception)
            {

                return BadRequest(new { erro = "Erro ao excluir o veiculo" });
            }

        }
        [HttpGet("buscar-veiculo/{Marca} {Modelo}")]
        public async Task<VeiculoViewModel> Buscar(string marca, string modelo)
        {
            var veiculo = await _consultarVeiculo.BuscarPorMarca(marca, modelo);

            if (veiculo == null)
            {
                return null;
            }

            var cursoViewModel = VeiculoFactory.MapearVeiculoViewModel(veiculo);

            return cursoViewModel;
        }

    }
 
}
