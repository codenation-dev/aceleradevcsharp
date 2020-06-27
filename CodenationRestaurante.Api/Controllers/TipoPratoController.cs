using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodenationRestaurante.Dados;
using CodenationRestaurante.Dominio.Modelo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodenationRestaurante.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoPratoController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<TipoPrato> Get()
        {
            using (var contexto = new Contexto())
            {
                return contexto.TipoPrato.ToList();
            }
        }

        [HttpGet("{id}")]
        public TipoPrato Get(int id)
        {
            using (var contexto = new Contexto())
            {
                return contexto.TipoPrato.FirstOrDefault(x => x.Id == id);
            }
        }

        [HttpPost]
        public IEnumerable<TipoPrato> Post([FromBody] TipoPrato tipoPrato)
        {
            using (var contexto = new Contexto())
            {
                contexto.TipoPrato.Add(tipoPrato);
                contexto.SaveChanges();

                return contexto.TipoPrato.ToList();
            }
        }

        [HttpPut]
        public IEnumerable<TipoPrato> Put([FromBody] TipoPrato tipoPrato)
        {
            using (var contexto = new Contexto())
            {
                contexto.TipoPrato.Update(tipoPrato);
                contexto.SaveChanges();

                return contexto.TipoPrato.ToList();
            }
        }

        [HttpDelete("{id}")]
        public IEnumerable<TipoPrato> Delete(int id)
        {
            using (var contexto = new Contexto())
            {
                var entity = contexto.TipoPrato.FirstOrDefault(x => x.Id == id);
                contexto.TipoPrato.Remove(entity);
                contexto.SaveChanges();

                return contexto.TipoPrato.ToList();
            }
        }
    }
}
