using System.Collections.Generic;
using System.Linq;
using CodenationRestaurante.Dados;
using CodenationRestaurante.Dominio.Modelo;
using Microsoft.AspNetCore.Mvc;

namespace CodenationRestaurante.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PratosIngredientesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<PratosIngredientes> Get()
        {
            using (var contexto = new Contexto())
            {
                return contexto.PratosIngredientes.ToList();
            }
        }

        [HttpGet("{id}")]
        public PratosIngredientes Get(int id)
        {
            using (var contexto = new Contexto())
            {
                return contexto.PratosIngredientes.FirstOrDefault(x => x.Id == id);
            }
        }

        [HttpPost]
        public IEnumerable<PratosIngredientes> Post([FromBody] PratosIngredientes pratosIngredientes)
        {
            using (var contexto = new Contexto())
            {
                contexto.PratosIngredientes.Add(pratosIngredientes);
                contexto.SaveChanges();

                return contexto.PratosIngredientes.ToList();
            }
        }

        [HttpPut]
        public IEnumerable<PratosIngredientes> Put([FromBody] PratosIngredientes pratosIngredientes)
        {
            using (var contexto = new Contexto())
            {
                contexto.PratosIngredientes.Update(pratosIngredientes);
                contexto.SaveChanges();

                return contexto.PratosIngredientes.ToList();
            }
        }

        [HttpDelete("{id}")]
        public IEnumerable<PratosIngredientes> Delete(int id)
        {
            using (var contexto = new Contexto())
            {
                var entity = contexto.PratosIngredientes.FirstOrDefault(x => x.Id == id);
                contexto.PratosIngredientes.Remove(entity);
                contexto.SaveChanges();

                return contexto.PratosIngredientes.ToList();
            }
        }
    }
}
