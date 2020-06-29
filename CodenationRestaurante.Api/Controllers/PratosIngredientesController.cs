using System.Collections.Generic;
using CodenationRestaurante.Dados.Repositorio;
using CodenationRestaurante.Dominio.Modelo;
using Microsoft.AspNetCore.Mvc;

namespace CodenationRestaurante.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PratosIngredientesController : ControllerBase
    {
        private PratosIngredientesRepositorio _repo;

        public PratosIngredientesController()
        {
            _repo = new PratosIngredientesRepositorio();
        }

        [HttpGet]
        public IEnumerable<PratosIngredientes> Get()
        {
            return _repo.RetornarTodos();
        }

        [HttpGet("{id}")]
        public PratosIngredientes Get(int id)
        {
            return _repo.BuscarPorId(id);
        }

        [HttpPost]
        public IEnumerable<PratosIngredientes> Post([FromBody] PratosIngredientes pratosIngredientes)
        {
            _repo.Incluir(pratosIngredientes);
            return _repo.RetornarTodos();
        }

        [HttpPut]
        public IEnumerable<PratosIngredientes> Put([FromBody] PratosIngredientes pratosIngredientes)
        {
            _repo.Alterar(pratosIngredientes);
            return _repo.RetornarTodos();
        }

        [HttpDelete("{id}")]
        public IEnumerable<PratosIngredientes> Delete(int id)
        {
            _repo.Excluir(id);
            return _repo.RetornarTodos();
        }
    }
}
