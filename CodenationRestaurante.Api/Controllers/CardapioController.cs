using System.Collections.Generic;
using CodenationRestaurante.Dominio.Modelo;
using CodenationRestaurante.Dominio.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace CodenationRestaurante.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardapioController : ControllerBase
    {
        private readonly ICardapioRepositorio _repo;
        public CardapioController(ICardapioRepositorio repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IEnumerable<Cardapio> Get()
        {
            return _repo.SelecionarTodos();
        }

        [HttpGet("{id}")]
        public Cardapio Get(int id)
        {
            return _repo.SelecionarPorId(id);
        }

        [HttpPost]
        public List<Cardapio> Post([FromBody] Cardapio cardapio)
        {
            _repo.Incluir(cardapio);
            return _repo.SelecionarTodos();
        }

        [HttpPut("{id}")]
        public List<Cardapio> Put([FromBody] Cardapio cardapio)
        {
            _repo.Alterar(cardapio);
            return _repo.SelecionarTodos();
        }

        [HttpDelete("{id}")]
        public List<Cardapio> Delete(int id)
        {
            _repo.Excluir(id);
            return _repo.SelecionarTodos();
        }
    }
}
