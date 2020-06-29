using System.Collections.Generic;
using CodenationRestaurante.Dominio.Modelo;
using CodenationRestaurante.Dominio.Repositorio;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CodenationRestaurante.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class IngredienteController : ControllerBase
    {
        private readonly IIngredienteRepositorio _repo;

        public IngredienteController(IIngredienteRepositorio repo)
        {
            _repo = repo;
        }

        // GET: api/<Ingrediente>
        [HttpGet]
        public IEnumerable<Ingrediente> Get()
        {
            return _repo.SelecionarTodos();
        }

        // GET api/<Ingrediente>/5
        [HttpGet("{id}")]
        public Ingrediente Get(int id)
        {
            return _repo.SelecionarPorId(id);
        }

        // POST api/<Ingrediente>
        [HttpPost]
        public IEnumerable<Ingrediente> Post([FromBody] Ingrediente ingrediente)
        {
            _repo.Incluir(ingrediente);
            return _repo.SelecionarTodos();
        }

        // PUT api/<Ingrediente>/5
        [HttpPut]
        public IEnumerable<Ingrediente> Put([FromBody] Ingrediente ingrediente)
        {
            _repo.Alterar(ingrediente);
            return _repo.SelecionarTodos();
        }

        // DELETE api/<Ingrediente>/5
        [HttpDelete("{id}")]
        public IEnumerable<Ingrediente> Delete(int id)
        {
            _repo.Excluir(id);
            return _repo.SelecionarTodos();
        }
    }
}
