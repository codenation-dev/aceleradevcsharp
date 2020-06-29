using System.Collections.Generic;
using CodenationRestaurante.Dados.Repositorio;
using CodenationRestaurante.Dominio.Modelo;
using Microsoft.AspNetCore.Mvc;

namespace CodenationRestaurante.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoPratoController : ControllerBase
    {
        private TipoPratoRepositorio _repo;

        public TipoPratoController()
        {
            _repo = new TipoPratoRepositorio();
        }

        [HttpGet]
        public IEnumerable<TipoPrato> Get()
        {
            return _repo.RetornarTodos();
        }

        [HttpGet("{id}")]
        public TipoPrato Get(int id)
        {
            return _repo.BuscarPorId(id);
        }

        [HttpPost]
        public IEnumerable<TipoPrato> Post([FromBody] TipoPrato tipoPrato)
        {
            _repo.Incluir(tipoPrato);
            return _repo.RetornarTodos();
        }

        [HttpPut]
        public IEnumerable<TipoPrato> Put([FromBody] TipoPrato tipoPrato)
        {
            _repo.Alterar(tipoPrato);
            return _repo.RetornarTodos();
        }

        [HttpDelete("{id}")]
        public IEnumerable<TipoPrato> Delete(int id)
        {
            _repo.Excluir(id);
            return _repo.RetornarTodos();
        }
    }
}
