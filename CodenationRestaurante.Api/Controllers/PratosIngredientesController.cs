using System.Collections.Generic;
using CodenationRestaurante.Dominio.Modelo;
using CodenationRestaurante.Dominio.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace CodenationRestaurante.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PratosIngredientesController : ControllerBase
    {
        private readonly IPratosIngredientesRepositorio _repo;

        public PratosIngredientesController(IPratosIngredientesRepositorio repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IEnumerable<PratosIngredientes> Get()
        {
            return _repo.SelecionarCompleto();
        }

        [HttpGet("{id}")]
        public PratosIngredientes Get(int id)
        {
            return _repo.SelecionarPorId(id);
        }

        [HttpPost]
        public IEnumerable<PratosIngredientes> Post([FromBody] PratosIngredientes pratosIngredientes)
        {
            _repo.Incluir(pratosIngredientes);
            return _repo.SelecionarTodos();
        }

        [HttpPut]
        public IEnumerable<PratosIngredientes> Put([FromBody] PratosIngredientes pratosIngredientes)
        {
            _repo.Alterar(pratosIngredientes);
            return _repo.SelecionarTodos();
        }

        [HttpDelete("{id}")]
        public IEnumerable<PratosIngredientes> Delete(int id)
        {
            _repo.Excluir(id);
            return _repo.SelecionarTodos();
        }
    }
}
