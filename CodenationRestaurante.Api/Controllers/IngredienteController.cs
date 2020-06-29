using System.Collections.Generic;
using CodenationRestaurante.Dados.Repositorio;
using CodenationRestaurante.Dominio.Modelo;
using Microsoft.AspNetCore.Mvc;

namespace CodenationRestaurante.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredienteController : ControllerBase
    {
        private IngredienteRepositorio _repo;

        public IngredienteController()
        {
            _repo = new IngredienteRepositorio();
        }

        // GET: api/<Ingrediente>
        [HttpGet]
        public IEnumerable<Ingrediente> Get()
        {
            return _repo.RetornarTodos();
        }

        // GET api/<Ingrediente>/5
        [HttpGet("{id}")]
        public Ingrediente Get(int id)
        {
            return _repo.BuscarPorId(id);
        }

        // POST api/<Ingrediente>
        [HttpPost]
        public IEnumerable<Ingrediente> Post([FromBody] Ingrediente ingrediente)
        {
            _repo.Incluir(ingrediente);
            return _repo.RetornarTodos();
        }

        // PUT api/<Ingrediente>/5
        [HttpPut]
        public IEnumerable<Ingrediente> Put([FromBody] Ingrediente ingrediente)
        {
            _repo.Alterar(ingrediente);
            return _repo.RetornarTodos();
        }

        // DELETE api/<Ingrediente>/5
        [HttpDelete("{id}")]
        public IEnumerable<Ingrediente> Delete(int id)
        {
            _repo.Excluir(id);
            return _repo.RetornarTodos();
        }
    }
}
