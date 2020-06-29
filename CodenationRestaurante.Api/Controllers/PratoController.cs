using System.Collections.Generic;
using CodenationRestaurante.Dominio.Modelo;
using CodenationRestaurante.Dominio.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace CodenationRestaurante.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PratoController : ControllerBase
    {
        private readonly IPratoRepositorio _repo;

        public PratoController(IPratoRepositorio repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IEnumerable<Prato> Get()
        {
            return _repo.SelecionarTodos();
        }
                
        [HttpGet("{id}")]
        public Prato Get(int id)
        {
            return _repo.SelecionarPorId(id);
        }
                
        [HttpPost]
        public IEnumerable<Prato> Post([FromBody] Prato prato)
        {
            _repo.Incluir(prato);
            return _repo.SelecionarTodos();
        }

        [HttpPut]
        public IEnumerable<Prato> Put([FromBody] Prato prato)
        {
            _repo.Alterar(prato);
            return _repo.SelecionarTodos();
        }
               
        [HttpDelete("{id}")]
        public IEnumerable<Prato> Delete(int id)
        {
            _repo.Excluir(id);
            return _repo.SelecionarTodos();
        }
    }
}
