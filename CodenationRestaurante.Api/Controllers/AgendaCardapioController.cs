using System.Collections.Generic;
using CodenationRestaurante.Dominio.Modelo;
using CodenationRestaurante.Dominio.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace CodenationRestaurante.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgendaCardapioController : ControllerBase
    {
        private readonly IAgendaCardapioRepositorio _repo;
        public AgendaCardapioController(IAgendaCardapioRepositorio repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IEnumerable<AgendaCardapio> Get()
        {
            return _repo.SelecionarTodos();
        }

        [HttpGet("{id}")]
        public AgendaCardapio Get(int id)
        {
            return _repo.SelecionarPorId(id);
        }

        [HttpPost]
        public List<AgendaCardapio> Post([FromBody] AgendaCardapio agendaCardapio)
        {
            _repo.Incluir(agendaCardapio);
            return _repo.SelecionarTodos();
        }

        [HttpPut]
        public List<AgendaCardapio> Put([FromBody] AgendaCardapio agendaCardapio)
        {
            _repo.Alterar(agendaCardapio);
            return _repo.SelecionarTodos();
        }

        [HttpDelete("{id}")]
        public List<AgendaCardapio> Delete(int id)
        {
            _repo.Excluir(id);
            return _repo.SelecionarTodos();
        }
    }
}
