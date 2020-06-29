using System.Collections.Generic;
using CodenationRestaurante.Dados.Repositorio;
using CodenationRestaurante.Dominio.Modelo;
using Microsoft.AspNetCore.Mvc;

namespace CodenationRestaurante.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PratoController : ControllerBase
    {
        private PratoRepositorio _repo;

        public PratoController()
        {
            _repo = new PratoRepositorio();
        }

        [HttpGet]
        public IEnumerable<Prato> Get()
        {
            return _repo.RetornarTodos();
        }
                
        [HttpGet("{id}")]
        public Prato Get(int id)
        {
            return _repo.BuscarPorId(id);
        }
                
        [HttpPost]
        public IEnumerable<Prato> Post([FromBody] Prato prato)
        {
            _repo.Incluir(prato);
            return _repo.RetornarTodos();
        }

        [HttpPut]
        public IEnumerable<Prato> Put([FromBody] Prato prato)
        {
            _repo.Alterar(prato);
            return _repo.RetornarTodos();
        }
               
        [HttpDelete("{id}")]
        public IEnumerable<Prato> Delete(int id)
        {
            _repo.Excluir(id);
            return _repo.RetornarTodos();
        }
    }
}
