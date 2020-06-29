using System.Collections.Generic;
using CodenationRestaurante.Dominio.Modelo;
using CodenationRestaurante.Dominio.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace CodenationRestaurante.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoPratoController : ControllerBase
    {
        private readonly ITipoPratoRepositorio _repo;

        public TipoPratoController(ITipoPratoRepositorio repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IEnumerable<TipoPrato> Get()
        {
            return _repo.SelecionarTodos();
        }

        [HttpGet("{id}")]
        public TipoPrato Get(int id)
        {
            return _repo.SelecionarPorId(id);
        }

        [HttpPost]
        public IEnumerable<TipoPrato> Post([FromBody] TipoPrato tipoPrato)
        {
            _repo.Incluir(tipoPrato);
            return _repo.SelecionarTodos();
        }

        [HttpPut]
        public IEnumerable<TipoPrato> Put([FromBody] TipoPrato tipoPrato)
        {
            _repo.Alterar(tipoPrato);
            return _repo.SelecionarTodos();
        }

        [HttpDelete("{id}")]
        public IEnumerable<TipoPrato> Delete(int id)
        {
            _repo.Excluir(id);
            return _repo.SelecionarTodos();
        }
    }
}
